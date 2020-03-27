using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmProductModels
    {
        public CrmProductModels()
        {
            CrmLeads = new HashSet<CrmLeads>();
            LeadProductModelDetails = new HashSet<LeadProductModelDetails>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string ModelNumber { get; set; }
        public string ModelEngDesc { get; set; }
        public string ModelNepDesc { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<LeadProductModelDetails> LeadProductModelDetails { get; set; }
    }
}
