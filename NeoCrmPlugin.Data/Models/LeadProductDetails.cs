using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class LeadProductDetails
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int ProductId { get; set; }
        public int LeadNo { get; set; }
        public int? BrandId { get; set; }
        public int LeadQuantity { get; set; }
        public int LeadValue { get; set; }
        public int? CategoryId { get; set; }
        public Guid UniqueKey { get; set; }

        public virtual CrmBrandSetups Brand { get; set; }
        public virtual CategorySetups Category { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmLeads LeadNoNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProducts Product { get; set; }
    }
}
