using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmAgentCustomerMapping
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int? AgentId { get; set; }
        public int CustomerId { get; set; }
        public int CompanyCode { get; set; }
        public string UserId { get; set; }

        public virtual CrmAgentes Agent { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
