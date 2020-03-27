using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCustomerCompanies
    {
        public CrmCustomerCompanies()
        {
            CccommunicationInformations = new HashSet<CccommunicationInformations>();
            CrmCustomers = new HashSet<CrmCustomers>();
            CrmLeads = new HashSet<CrmLeads>();
            ProfessionalInformations = new HashSet<ProfessionalInformations>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CcompanyId { get; set; }
        public string CcompanyEngDesc { get; set; }
        public string CcompanyNepDesc { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPosition { get; set; }
        public int? CompanyTypeId { get; set; }
        public int? CompanySubTypeId { get; set; }
        public bool TagFlag { get; set; }
        public string RegistrationNo { get; set; }
        public string CompanySubType { get; set; }
        public string NatureOfCompany { get; set; }
        public string ProductOfCompany { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySubTypes CompanySubTypeNavigation { get; set; }
        public virtual CrmCompanyTypes CompanyType { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CccommunicationInformations> CccommunicationInformations { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomers { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<ProfessionalInformations> ProfessionalInformations { get; set; }
    }
}
