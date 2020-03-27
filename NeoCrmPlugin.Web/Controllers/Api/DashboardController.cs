using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NeoCrmPlugin.Web.Models;
using NeoCrmPlugin.Data.Models;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeoCrmPlugin.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : Controller
    {
        private NeoCRMContext db = new NeoCRMContext();
        // GET: api/values
        [HttpGet]
        [Route("DashboardWidgets")]
        public IActionResult GetDashboardWidget()
        {
            var model = new DashboardViewModel();
            var Customerdata = db.CrmCustomers.ToList();
            model.TotalCustomer = Customerdata.Count.ToString();
            model.TodayCustomer = Customerdata.Count(x => x.CreatedDate.ToShortDateString() == DateTime.Now.ToShortDateString()).ToString();
            model.ThisMonthCustomer = Customerdata.Count(x => x.CreatedDate.Month == DateTime.Now.Month).ToString();
            model.LastMonthCustomer = Customerdata.Count(x => x.CreatedDate.Month - 1 == DateTime.Now.Month - 1).ToString();
            return Ok(new { Message = "Input Format not Match", StatusCode = (int)HttpStatusCode.BadRequest, data = model });

        }
        [HttpPost]
        [Route("Top10Product")]
        public IActionResult Top10Product()
        {
            List<TopTenTendersViewModel> lstTopTen = new List<TopTenTendersViewModel>();
            try
            {
                var lstTopTens = (from db in db.CrmLeads
                                  join p in db.LeadProductDetails on db.Id equals p.LeadNo
                                  join c in db.CrmCustomers on db.CustomerId equals c.Id
                                  join cc in db.CrmCustomerCompanies on db.CustomerCompanyId equals cc.Id into ps
                                  from cc in ps.DefaultIfEmpty()
                                  select new { LeadNo = db.Id, CreatedDate = db.CreatedDate, LeadQuantity = p.LeadQuantity, LeadValue = db.LeadValue, CustomerId = db.CustomerId, CustomerCompanyId = db.CustomerCompanyId, FirstName = c.FirstName, LastName = c.LastName, Email = c.Email, Subject = db.Subject, CCompanyEngDesc = cc == null ? "-" : cc.CompanyCode.ToString() }).ToList();


                var groupItem = lstTopTens.GroupBy(x => x.LeadNo).Select(t => new TopTenTendersViewModel()
                {
                    LeadNo = t.Key,
                    LeadQuantity = t.Sum(y => y.LeadQuantity),
                    LeadValue = int.Parse(t.FirstOrDefault().LeadValue),
                    CustomerCompany = t.FirstOrDefault().CCompanyEngDesc,
                    CustomerId = t.FirstOrDefault().CustomerId,
                    CustomerName = t.FirstOrDefault().FirstName == null ? t.FirstOrDefault().Email == null ? t.FirstOrDefault().CustomerId.ToString() : t.FirstOrDefault().Email : t.FirstOrDefault().FirstName + " " + t.FirstOrDefault().LastName,
                    LeadSubject = t.FirstOrDefault().Subject,
                    CreatedDate = t.FirstOrDefault().CreatedDate
                }).OrderByDescending(x => x.LeadValue).Take(10).ToList();
                return Ok(new { Message = "Input Format not Match", StatusCode = (int)HttpStatusCode.BadRequest, data = groupItem });
               
            }
            catch (Exception ex)
            {
                return Ok(new { Message = "Input Format not Match", StatusCode = (int)HttpStatusCode.BadRequest, data = lstTopTen });
            }
           

        }
    }
}
