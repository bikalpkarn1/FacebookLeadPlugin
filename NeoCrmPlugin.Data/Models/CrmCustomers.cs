using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCustomers
    {
        public CrmCustomers()
        {
            CommunicationInformations = new HashSet<CommunicationInformations>();
            CrmAgentCustomerMapping = new HashSet<CrmAgentCustomerMapping>();
            CrmLeads = new HashSet<CrmLeads>();
            CustomerAddresses = new HashSet<CustomerAddresses>();
            CustomerFamilyInfomationsCustomer = new HashSet<CustomerFamilyInfomations>();
            CustomerFamilyInfomationsIdOfOtherCustomerNavigation = new HashSet<CustomerFamilyInfomations>();
            CustomerPhysicalInformations = new HashSet<CustomerPhysicalInformations>();
            EducationInformations = new HashSet<EducationInformations>();
            InboxMails = new HashSet<InboxMails>();
            ProfessionalInformations = new HashSet<ProfessionalInformations>();
            SentMails = new HashSet<SentMails>();
            SocioDemographicInformations = new HashSet<SocioDemographicInformations>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CustomerId { get; set; }
        public string CustomerEngDesc { get; set; }
        public string CustomerNepDesc { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public int? ReferalCustomerCode { get; set; }
        public int? CcompanyCode { get; set; }
        public int? CustomerSectorCode { get; set; }
        public int? LocationCode { get; set; }
        public bool TagFlag { get; set; }
        public int CompanyCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string SpouseName { get; set; }
        public string SpouseMobileNo { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string MemberCount { get; set; }
        public string Education { get; set; }
        public string CollegeName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string PreviousCompany { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public DateTime? BirthDateAd { get; set; }
        public string BirthDateBs { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }
        public bool LastKnownMartialStatus { get; set; }
        public string PassportNumber { get; set; }
        public string CitizenshipNo { get; set; }
        public string DrivingLinceseNumber { get; set; }
        public int? CustomerAddressId { get; set; }
        public int? CommunicationInfoId { get; set; }
        public int? CustomerFamilyInfoId { get; set; }
        public int? ProfessionalInfoId { get; set; }
        public int? EducationInfoId { get; set; }
        public int? CustomerPhysicalInfoId { get; set; }
        public int? SocioDemographiInfoId { get; set; }

        public virtual CrmCustomerCompanies CcompanyCodeNavigation { get; set; }
        public virtual CommunicationInformations CommunicationInfo { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CustomerAddresses CustomerAddress { get; set; }
        public virtual CustomerPhysicalInformations CustomerPhysicalInfo { get; set; }
        public virtual CrmCustomerSectors CustomerSectorCodeNavigation { get; set; }
        public virtual EducationInformations EducationInfo { get; set; }
        public virtual CrmLocations LocationCodeNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ProfessionalInformations ProfessionalInfo { get; set; }
        public virtual SocioDemographicInformations SocioDemographiInfo { get; set; }
        public virtual ICollection<CommunicationInformations> CommunicationInformations { get; set; }
        public virtual ICollection<CrmAgentCustomerMapping> CrmAgentCustomerMapping { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerFamilyInfomations> CustomerFamilyInfomationsCustomer { get; set; }
        public virtual ICollection<CustomerFamilyInfomations> CustomerFamilyInfomationsIdOfOtherCustomerNavigation { get; set; }
        public virtual ICollection<CustomerPhysicalInformations> CustomerPhysicalInformations { get; set; }
        public virtual ICollection<EducationInformations> EducationInformations { get; set; }
        public virtual ICollection<InboxMails> InboxMails { get; set; }
        public virtual ICollection<ProfessionalInformations> ProfessionalInformations { get; set; }
        public virtual ICollection<SentMails> SentMails { get; set; }
        public virtual ICollection<SocioDemographicInformations> SocioDemographicInformations { get; set; }
    }
}
