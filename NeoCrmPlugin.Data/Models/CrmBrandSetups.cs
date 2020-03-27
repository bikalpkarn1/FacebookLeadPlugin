using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmBrandSetups
    {
        public CrmBrandSetups()
        {
            LeadProductDetailMasters = new HashSet<LeadProductDetailMasters>();
            LeadProductDetails = new HashSet<LeadProductDetails>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string BrandName { get; set; }
        public string BrandNepaliName { get; set; }
        public string Description { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
        public virtual ICollection<LeadProductDetails> LeadProductDetails { get; set; }
    }
}
