using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmProducts
    {
        public CrmProducts()
        {
            CrmAgentProduct = new HashSet<CrmAgentProduct>();
            CrmCampaigns = new HashSet<CrmCampaigns>();
            CrmLeads = new HashSet<CrmLeads>();
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
        public string ProductId { get; set; }
        public string ProductEngDesc { get; set; }
        public string ProductNepDesc { get; set; }
        public string Brand { get; set; }
        public string ProductType { get; set; }
        public bool TagFlag { get; set; }
        public int CompanyCode { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public string ModelNumber { get; set; }

        public virtual CategorySetups Category { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentProduct> CrmAgentProduct { get; set; }
        public virtual ICollection<CrmCampaigns> CrmCampaigns { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
        public virtual ICollection<LeadProductDetails> LeadProductDetails { get; set; }
    }
}
