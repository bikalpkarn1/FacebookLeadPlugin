using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoCrmPlugin.Web.Models
{
    public class DashboardViewModel
    {
        public string TotalCustomer { get; set; }
        public string ThisMonthCustomer { get; set; }
        public string LastMonthCustomer { get; set; }
        public string TodayCustomer { get; set; }
    }

    public class TopTenProudct
    {
        public decimal Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string ProductName { get; set; }
    }
    public class TopTenTendersViewModel
    {
        public int LeadNo { get; set; }
        public int LeadValue { get; set; }
        public int LeadQuantity { get; set; }
        public string LeadSubject { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCompany { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
