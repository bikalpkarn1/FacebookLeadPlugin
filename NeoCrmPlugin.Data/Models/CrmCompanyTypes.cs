using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCompanyTypes
    {
        public CrmCompanyTypes()
        {
            CrmCampaigns = new HashSet<CrmCampaigns>();
            CrmCompanySubTypes = new HashSet<CrmCompanySubTypes>();
            CrmCustomerCompanies = new HashSet<CrmCustomerCompanies>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CompanyTypeId { get; set; }
        public string CompanyTypeEngDesc { get; set; }
        public string CompanyTypeNepDesc { get; set; }
        public bool TagFlag { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCampaigns> CrmCampaigns { get; set; }
        public virtual ICollection<CrmCompanySubTypes> CrmCompanySubTypes { get; set; }
        public virtual ICollection<CrmCustomerCompanies> CrmCustomerCompanies { get; set; }
    }
}
