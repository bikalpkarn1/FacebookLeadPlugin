using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class LeadProductModelDetails
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int ProductModelId { get; set; }
        public int LeadNo { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmLeads LeadNoNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProductModels ProductModel { get; set; }
    }
}
