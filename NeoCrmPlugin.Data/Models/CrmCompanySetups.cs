using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCompanySetups
    {
        public CrmCompanySetups()
        {
            CategorySetups = new HashSet<CategorySetups>();
            CommunicationModes = new HashSet<CommunicationModes>();
            CrmAgentCustomerMapping = new HashSet<CrmAgentCustomerMapping>();
            CrmAgentType = new HashSet<CrmAgentType>();
            CrmBrandSetups = new HashSet<CrmBrandSetups>();
            CrmCampaignFaqs = new HashSet<CrmCampaignFaqs>();
            CrmCompanyTypes = new HashSet<CrmCompanyTypes>();
            CrmCustomerSectors = new HashSet<CrmCustomerSectors>();
            CrmCustomers = new HashSet<CrmCustomers>();
            CrmLeadDetails = new HashSet<CrmLeadDetails>();
            CrmLeadTypes = new HashSet<CrmLeadTypes>();
            CrmLeads = new HashSet<CrmLeads>();
            CrmLocations = new HashSet<CrmLocations>();
            CrmMenuSettings = new HashSet<CrmMenuSettings>();
            CrmProcessFollowUps = new HashSet<CrmProcessFollowUps>();
            CrmProcesse = new HashSet<CrmProcesse>();
            CrmProductModels = new HashSet<CrmProductModels>();
            CrmProducts = new HashSet<CrmProducts>();
            CrmSubMenuSettings = new HashSet<CrmSubMenuSettings>();
            DocumentTypes = new HashSet<DocumentTypes>();
            MailSetups = new HashSet<MailSetups>();
            RatingSetups = new HashSet<RatingSetups>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CompanyId { get; set; }
        public string CompanyEdesc { get; set; }
        public string CompanyNdesc { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        public string LogoFileName { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime ValidDate { get; set; }
        public string TpinVatNo { get; set; }
        public bool ConsolidateFlag { get; set; }
        public string AbbrCode { get; set; }
        public string SmtpHost { get; set; }
        public string FooterLogoFileName { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CategorySetups> CategorySetups { get; set; }
        public virtual ICollection<CommunicationModes> CommunicationModes { get; set; }
        public virtual ICollection<CrmAgentCustomerMapping> CrmAgentCustomerMapping { get; set; }
        public virtual ICollection<CrmAgentType> CrmAgentType { get; set; }
        public virtual ICollection<CrmBrandSetups> CrmBrandSetups { get; set; }
        public virtual ICollection<CrmCampaignFaqs> CrmCampaignFaqs { get; set; }
        public virtual ICollection<CrmCompanyTypes> CrmCompanyTypes { get; set; }
        public virtual ICollection<CrmCustomerSectors> CrmCustomerSectors { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomers { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetails { get; set; }
        public virtual ICollection<CrmLeadTypes> CrmLeadTypes { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<CrmLocations> CrmLocations { get; set; }
        public virtual ICollection<CrmMenuSettings> CrmMenuSettings { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUps { get; set; }
        public virtual ICollection<CrmProcesse> CrmProcesse { get; set; }
        public virtual ICollection<CrmProductModels> CrmProductModels { get; set; }
        public virtual ICollection<CrmProducts> CrmProducts { get; set; }
        public virtual ICollection<CrmSubMenuSettings> CrmSubMenuSettings { get; set; }
        public virtual ICollection<DocumentTypes> DocumentTypes { get; set; }
        public virtual ICollection<MailSetups> MailSetups { get; set; }
        public virtual ICollection<RatingSetups> RatingSetups { get; set; }
    }
}
