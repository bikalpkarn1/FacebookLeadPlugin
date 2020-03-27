using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NeoCrmPlugin.Data.Models;
using NeoCrmPlugin.Web.Models;

namespace NeoCrmPlugin.Web.Controllers
{
    public class HomeController : Controller
    {
        private NeoCRMContext _ctx;
        public HomeController(NeoCRMContext ctx)
        {
            this._ctx = ctx;
        }
        public IActionResult Index()
        {
          //  _ctx.Databas;
            var model = new DropdownModel1();
            var agent=_ctx.CrmAgentes.Where(x=>x.DeletedFlag==false).Select(r => new  {Id= r.Id,r.AgentEngDesc }).ToList();
            var product = _ctx.CrmProducts.Where(x => x.DeletedFlag == false).Select(r => new  {r.Id,r.ProductEngDesc }).ToList();
            var rating = _ctx.RatingSetups.Where(x => x.DeletedFlag == false).Select(r => new  { r.Id, r.RatingName }).ToList();
            model.AgentSelectList = new SelectList(agent, "Id", "AgentEngDesc");
            model.ProductSelectList = new SelectList(product, "Id", "ProductEngDesc");
            model.RatingSelectList = new SelectList(rating, "Id", "RatingName");

            return View(model);
        }
        [HttpPost]
        public ActionResult SaveData([FromBody]FormDataModel model)
        {
            bool result = true;
            using (var trans = _ctx.Database.BeginTransaction())
            {
                try
                {
                    string createdBy = _ctx.AspNetUsers.Where(x => x.DeletedFlag == false && x.CompanyCode == 1).Select(x => x.Id).FirstOrDefault();
                    int processTypeId = _ctx.CrmProcesse.Select(x => x.Id).FirstOrDefault();
                    int actionId = _ctx.CrmActions.Where(x => x.ProcessCode == processTypeId && x.LeadStartFlag == true).Select(x => x.Id).FirstOrDefault();
                    List<CrmLeads> leadsList=new List<CrmLeads>();
                    int LeadId = _ctx.CrmLeads.Select(x => x.Id).ToList().Max() + 1;
                    int FollowupsId = _ctx.CrmProcessFollowUps.Select(x => x.Id).ToList().Max() + 1;
                    foreach (var item in model.FormData)
                    {
                        if (string.IsNullOrEmpty(item.LeadSubject))
                            continue;
                      //  var findLead=_ctx.CrmLeads.Where(x=>x.Subject.ToLowerInvariant()==item.LeadSubject.ToLowerInvariant() &&x.CustomerId)
                        var cus = _ctx.CrmCustomers.FirstOrDefault(x => x.Email == item.CustomerEmail && x.MobileNo == item.CustomerPhone && x.DeletedFlag == false);
                        var findLead = _ctx.CrmLeads.Where(x => x.Subject.ToLowerInvariant() == item.LeadSubject.ToLowerInvariant() && x.CustomerId.ToString() == cus.CustomerId).FirstOrDefault();
                        if (findLead != null)
                            continue;

                        if (cus==null)
                        {
                            cus = new CrmCustomers();
                            cus.CreatedBy = createdBy;
                            cus.FirstName = item.CustomerName;
                            cus.MobileNo = item.CustomerPhone;
                            cus.Email = item.CustomerEmail;
                            cus.DeletedFlag = false;
                            cus.CreatedDate = DateTime.Now;
                            cus.TagFlag = false;
                            cus.CompanyCode = 1;
                            cus.LastKnownMartialStatus = true;
                            InsertCustomer(cus);
                        }

                       

                        var leads = new CrmLeads();
                        leads.Id = LeadId;
                        leads.CreatedBy = createdBy;
                        leads.CreatedDate = DateTime.Now;
                        leads.DeletedFlag = false;
                        leads.CustomerId = cus.Id;
                        leads.CompanyCode = 1;
                        leads.ProcessTypeId = processTypeId;
                        leads.LeadValue ="0";
                        leads.AgentId = Convert.ToInt32(model.AgentId);
                        leads.Rating = Convert.ToInt32(model.RatingId);
                        leads.ProductId = Convert.ToInt32(model.ProductId);
                        leads.Description = item.LeadDescription;
                        leads.CompletionDate = DateTime.Now;
                        leads.LeadDate = DateTime.Now;
                        leads.Subject = item.LeadSubject;
                        leads.CrmProcessFollowUps = new List<CrmProcessFollowUps>()
                        {
                            new CrmProcessFollowUps()
                            {
                                Id=FollowupsId,
                                CreatedBy=createdBy,
                                CreatedDate = DateTime.Now,
                                DeletedFlag = false,
                                ProcessNo = 1,
                                LeadNo = LeadId,
                                ProcessTypeId = processTypeId,
                                AgentId = Convert.ToInt32(model.AgentId),
                                StartDate = DateTime.Now,
                                EstdValue = 0,
                                CompanyCode = 1,
                                ActionId = actionId
                            }

                        };
                        leadsList.Add(leads);
                        LeadId++;
                        FollowupsId++;
                    }
                   
                    _ctx.CrmLeads.AddRange(leadsList);
                    _ctx.SaveChanges();
                    trans.Commit();

                }
                catch(Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
            return Json(result);
        }
        private void InsertCustomer(CrmCustomers cus)
        {
            using (var context = new NeoCRMContext())
            {
                context.CrmCustomers.Add(cus);
                context.SaveChanges();
            }
        }

        public IActionResult Logs()
        {
            var logdata = _ctx.Log.ToList();
            return View(logdata);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
