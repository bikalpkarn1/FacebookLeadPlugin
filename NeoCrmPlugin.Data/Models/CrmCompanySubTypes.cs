using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCompanySubTypes
    {
        public CrmCompanySubTypes()
        {
            CrmCustomerCompanies = new HashSet<CrmCustomerCompanies>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CompanySubTypeEngDesc { get; set; }
        public int CompanyTypeId { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanyTypes CompanyType { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomerCompanies> CrmCustomerCompanies { get; set; }
    }
}
