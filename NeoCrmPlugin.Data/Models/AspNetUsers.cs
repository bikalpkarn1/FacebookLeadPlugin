using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            CallRecordsCreatedByNavigation = new HashSet<CallRecords>();
            CallRecordsModifiedByNavigation = new HashSet<CallRecords>();
            CategorySetupsCreatedByNavigation = new HashSet<CategorySetups>();
            CategorySetupsModifiedByNavigation = new HashSet<CategorySetups>();
            CccommunicationInformationsCreatedByNavigation = new HashSet<CccommunicationInformations>();
            CccommunicationInformationsModifiedByNavigation = new HashSet<CccommunicationInformations>();
            ChatsCreatedByNavigation = new HashSet<Chats>();
            ChatsModifiedByNavigation = new HashSet<Chats>();
            CommentHistoryFacebooksCreatedByNavigation = new HashSet<CommentHistoryFacebooks>();
            CommentHistoryFacebooksModifiedByNavigation = new HashSet<CommentHistoryFacebooks>();
            CommunicationInformationsCreatedByNavigation = new HashSet<CommunicationInformations>();
            CommunicationInformationsModifiedByNavigation = new HashSet<CommunicationInformations>();
            CommunicationModesCreatedByNavigation = new HashSet<CommunicationModes>();
            CommunicationModesModifiedByNavigation = new HashSet<CommunicationModes>();
            CrmActionsCreatedByNavigation = new HashSet<CrmActions>();
            CrmActionsModifiedByNavigation = new HashSet<CrmActions>();
            CrmAgentCustomerMappingCreatedByNavigation = new HashSet<CrmAgentCustomerMapping>();
            CrmAgentCustomerMappingModifiedByNavigation = new HashSet<CrmAgentCustomerMapping>();
            CrmAgentCustomerMappingUser = new HashSet<CrmAgentCustomerMapping>();
            CrmAgentProductCreatedByNavigation = new HashSet<CrmAgentProduct>();
            CrmAgentProductModifiedByNavigation = new HashSet<CrmAgentProduct>();
            CrmAgentTypeCreatedByNavigation = new HashSet<CrmAgentType>();
            CrmAgentTypeModifiedByNavigation = new HashSet<CrmAgentType>();
            CrmAgentesCreatedByNavigation = new HashSet<CrmAgentes>();
            CrmAgentesModifiedByNavigation = new HashSet<CrmAgentes>();
            CrmBranchSetupsCreatedByNavigation = new HashSet<CrmBranchSetups>();
            CrmBranchSetupsModifiedByNavigation = new HashSet<CrmBranchSetups>();
            CrmBrandSetupsCreatedByNavigation = new HashSet<CrmBrandSetups>();
            CrmBrandSetupsModifiedByNavigation = new HashSet<CrmBrandSetups>();
            CrmCampaignFaqsCreatedByNavigation = new HashSet<CrmCampaignFaqs>();
            CrmCampaignFaqsModifiedByNavigation = new HashSet<CrmCampaignFaqs>();
            CrmCampaignsCreatedByNavigation = new HashSet<CrmCampaigns>();
            CrmCampaignsModifiedByNavigation = new HashSet<CrmCampaigns>();
            CrmCompanySetupsCreatedByNavigation = new HashSet<CrmCompanySetups>();
            CrmCompanySetupsModifiedByNavigation = new HashSet<CrmCompanySetups>();
            CrmCompanySubTypesCreatedByNavigation = new HashSet<CrmCompanySubTypes>();
            CrmCompanySubTypesModifiedByNavigation = new HashSet<CrmCompanySubTypes>();
            CrmCompanyTypesCreatedByNavigation = new HashSet<CrmCompanyTypes>();
            CrmCompanyTypesModifiedByNavigation = new HashSet<CrmCompanyTypes>();
            CrmCustomerCompaniesCreatedByNavigation = new HashSet<CrmCustomerCompanies>();
            CrmCustomerCompaniesModifiedByNavigation = new HashSet<CrmCustomerCompanies>();
            CrmCustomerSectorsCreatedByNavigation = new HashSet<CrmCustomerSectors>();
            CrmCustomerSectorsModifiedByNavigation = new HashSet<CrmCustomerSectors>();
            CrmCustomersCreatedByNavigation = new HashSet<CrmCustomers>();
            CrmCustomersModifiedByNavigation = new HashSet<CrmCustomers>();
            CrmLeadDetailsCreatedByNavigation = new HashSet<CrmLeadDetails>();
            CrmLeadDetailsModifiedByNavigation = new HashSet<CrmLeadDetails>();
            CrmLeadTypesCreatedByNavigation = new HashSet<CrmLeadTypes>();
            CrmLeadTypesModifiedByNavigation = new HashSet<CrmLeadTypes>();
            CrmLeadsCreatedByNavigation = new HashSet<CrmLeads>();
            CrmLeadsModifiedByNavigation = new HashSet<CrmLeads>();
            CrmLocationTypesCreatedByNavigation = new HashSet<CrmLocationTypes>();
            CrmLocationTypesModifiedByNavigation = new HashSet<CrmLocationTypes>();
            CrmLocationsCreatedByNavigation = new HashSet<CrmLocations>();
            CrmLocationsModifiedByNavigation = new HashSet<CrmLocations>();
            CrmMenuSettingsCreatedByNavigation = new HashSet<CrmMenuSettings>();
            CrmMenuSettingsModifiedByNavigation = new HashSet<CrmMenuSettings>();
            CrmPreferenceTableCreatedByNavigation = new HashSet<CrmPreferenceTable>();
            CrmPreferenceTableModifiedByNavigation = new HashSet<CrmPreferenceTable>();
            CrmProcessFollowUpsCreatedByNavigation = new HashSet<CrmProcessFollowUps>();
            CrmProcessFollowUpsModifiedByNavigation = new HashSet<CrmProcessFollowUps>();
            CrmProcesseCreatedByNavigation = new HashSet<CrmProcesse>();
            CrmProcesseModifiedByNavigation = new HashSet<CrmProcesse>();
            CrmProductModelsCreatedByNavigation = new HashSet<CrmProductModels>();
            CrmProductModelsModifiedByNavigation = new HashSet<CrmProductModels>();
            CrmProductsCreatedByNavigation = new HashSet<CrmProducts>();
            CrmProductsModifiedByNavigation = new HashSet<CrmProducts>();
            CrmSubMenuSettingsCreatedByNavigation = new HashSet<CrmSubMenuSettings>();
            CrmSubMenuSettingsModifiedByNavigation = new HashSet<CrmSubMenuSettings>();
            CrmWorkFlowCreatedByNavigation = new HashSet<CrmWorkFlow>();
            CrmWorkFlowModifiedByNavigation = new HashSet<CrmWorkFlow>();
            CustomFreeFiledTablesCreatedByNavigation = new HashSet<CustomFreeFiledTables>();
            CustomFreeFiledTablesModifiedByNavigation = new HashSet<CustomFreeFiledTables>();
            CustomerAddressesCreatedByNavigation = new HashSet<CustomerAddresses>();
            CustomerAddressesModifiedByNavigation = new HashSet<CustomerAddresses>();
            CustomerFamilyInfomationsCreatedByNavigation = new HashSet<CustomerFamilyInfomations>();
            CustomerFamilyInfomationsModifiedByNavigation = new HashSet<CustomerFamilyInfomations>();
            CustomerPhysicalInformationsCreatedByNavigation = new HashSet<CustomerPhysicalInformations>();
            CustomerPhysicalInformationsModifiedByNavigation = new HashSet<CustomerPhysicalInformations>();
            DocumentTypesCreatedByNavigation = new HashSet<DocumentTypes>();
            DocumentTypesModifiedByNavigation = new HashSet<DocumentTypes>();
            DropdownManagementsCreatedByNavigation = new HashSet<DropdownManagements>();
            DropdownManagementsModifiedByNavigation = new HashSet<DropdownManagements>();
            DynamicReportsCreatedByNavigation = new HashSet<DynamicReports>();
            DynamicReportsModifiedByNavigation = new HashSet<DynamicReports>();
            EducationInformationsCreatedByNavigation = new HashSet<EducationInformations>();
            EducationInformationsModifiedByNavigation = new HashSet<EducationInformations>();
            EmployeesCreatedByNavigation = new HashSet<Employees>();
            EmployeesModifiedByNavigation = new HashSet<Employees>();
            FreeFieldDataLinkTablesCreatedByNavigation = new HashSet<FreeFieldDataLinkTables>();
            FreeFieldDataLinkTablesModifiedByNavigation = new HashSet<FreeFieldDataLinkTables>();
            FreeFieldLinkTablesCreatedByNavigation = new HashSet<FreeFieldLinkTables>();
            FreeFieldLinkTablesModifiedByNavigation = new HashSet<FreeFieldLinkTables>();
            InboxMailsCreatedByNavigation = new HashSet<InboxMails>();
            InboxMailsModifiedByNavigation = new HashSet<InboxMails>();
            LeadProductDetailMastersCreatedByNavigation = new HashSet<LeadProductDetailMasters>();
            LeadProductDetailMastersModifiedByNavigation = new HashSet<LeadProductDetailMasters>();
            LeadProductDetailsCreatedByNavigation = new HashSet<LeadProductDetails>();
            LeadProductDetailsModifiedByNavigation = new HashSet<LeadProductDetails>();
            LeadProductModelDetailsCreatedByNavigation = new HashSet<LeadProductModelDetails>();
            LeadProductModelDetailsModifiedByNavigation = new HashSet<LeadProductModelDetails>();
            MailSetupsCreatedByNavigation = new HashSet<MailSetups>();
            MailSetupsModifiedByNavigation = new HashSet<MailSetups>();
            NotificationsCreatedByNavigation = new HashSet<Notifications>();
            NotificationsFromUser = new HashSet<Notifications>();
            NotificationsModifiedByNavigation = new HashSet<Notifications>();
            NotificationsToUser = new HashSet<Notifications>();
            PreferenceSetupsCreatedByNavigation = new HashSet<PreferenceSetups>();
            PreferenceSetupsModifiedByNavigation = new HashSet<PreferenceSetups>();
            PrefixesCreatedByNavigation = new HashSet<Prefixes>();
            PrefixesModifiedByNavigation = new HashSet<Prefixes>();
            ProfessionalInformationsCreatedByNavigation = new HashSet<ProfessionalInformations>();
            ProfessionalInformationsModifiedByNavigation = new HashSet<ProfessionalInformations>();
            RatingSetupsCreatedByNavigation = new HashSet<RatingSetups>();
            RatingSetupsModifiedByNavigation = new HashSet<RatingSetups>();
            SentMailsCreatedByNavigation = new HashSet<SentMails>();
            SentMailsModifiedByNavigation = new HashSet<SentMails>();
            SocialWebRecordsCreatedByNavigation = new HashSet<SocialWebRecords>();
            SocialWebRecordsModifiedByNavigation = new HashSet<SocialWebRecords>();
            SocioDemographicInformationsCreatedByNavigation = new HashSet<SocioDemographicInformations>();
            SocioDemographicInformationsModifiedByNavigation = new HashSet<SocioDemographicInformations>();
            SuffixesCreatedByNavigation = new HashSet<Suffixes>();
            SuffixesModifiedByNavigation = new HashSet<Suffixes>();
            TaModesCreatedByNavigation = new HashSet<TaModes>();
            TaModesModifiedByNavigation = new HashSet<TaModes>();
            TestsCreatedByNavigation = new HashSet<Tests>();
            TestsModifiedByNavigation = new HashSet<Tests>();
            UserMailCredentialsCreatedByNavigation = new HashSet<UserMailCredentials>();
            UserMailCredentialsModifiedByNavigation = new HashSet<UserMailCredentials>();
        }

        public int AccessFailedCount { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string IpAddress { get; set; }

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<CallRecords> CallRecordsCreatedByNavigation { get; set; }
        public virtual ICollection<CallRecords> CallRecordsModifiedByNavigation { get; set; }
        public virtual ICollection<CategorySetups> CategorySetupsCreatedByNavigation { get; set; }
        public virtual ICollection<CategorySetups> CategorySetupsModifiedByNavigation { get; set; }
        public virtual ICollection<CccommunicationInformations> CccommunicationInformationsCreatedByNavigation { get; set; }
        public virtual ICollection<CccommunicationInformations> CccommunicationInformationsModifiedByNavigation { get; set; }
        public virtual ICollection<Chats> ChatsCreatedByNavigation { get; set; }
        public virtual ICollection<Chats> ChatsModifiedByNavigation { get; set; }
        public virtual ICollection<CommentHistoryFacebooks> CommentHistoryFacebooksCreatedByNavigation { get; set; }
        public virtual ICollection<CommentHistoryFacebooks> CommentHistoryFacebooksModifiedByNavigation { get; set; }
        public virtual ICollection<CommunicationInformations> CommunicationInformationsCreatedByNavigation { get; set; }
        public virtual ICollection<CommunicationInformations> CommunicationInformationsModifiedByNavigation { get; set; }
        public virtual ICollection<CommunicationModes> CommunicationModesCreatedByNavigation { get; set; }
        public virtual ICollection<CommunicationModes> CommunicationModesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmActions> CrmActionsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmActions> CrmActionsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentCustomerMapping> CrmAgentCustomerMappingCreatedByNavigation { get; set; }
        public virtual ICollection<CrmAgentCustomerMapping> CrmAgentCustomerMappingModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentCustomerMapping> CrmAgentCustomerMappingUser { get; set; }
        public virtual ICollection<CrmAgentProduct> CrmAgentProductCreatedByNavigation { get; set; }
        public virtual ICollection<CrmAgentProduct> CrmAgentProductModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentType> CrmAgentTypeCreatedByNavigation { get; set; }
        public virtual ICollection<CrmAgentType> CrmAgentTypeModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentes> CrmAgentesCreatedByNavigation { get; set; }
        public virtual ICollection<CrmAgentes> CrmAgentesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmBranchSetups> CrmBranchSetupsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmBranchSetups> CrmBranchSetupsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmBrandSetups> CrmBrandSetupsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmBrandSetups> CrmBrandSetupsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCampaignFaqs> CrmCampaignFaqsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCampaignFaqs> CrmCampaignFaqsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCampaigns> CrmCampaignsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCampaigns> CrmCampaignsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCompanySetups> CrmCompanySetupsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCompanySetups> CrmCompanySetupsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCompanySubTypes> CrmCompanySubTypesCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCompanySubTypes> CrmCompanySubTypesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCompanyTypes> CrmCompanyTypesCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCompanyTypes> CrmCompanyTypesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomerCompanies> CrmCustomerCompaniesCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCustomerCompanies> CrmCustomerCompaniesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomerSectors> CrmCustomerSectorsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCustomerSectors> CrmCustomerSectorsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomersCreatedByNavigation { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomersModifiedByNavigation { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetailsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmLeadTypes> CrmLeadTypesCreatedByNavigation { get; set; }
        public virtual ICollection<CrmLeadTypes> CrmLeadTypesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmLeads> CrmLeadsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmLeads> CrmLeadsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmLocationTypes> CrmLocationTypesCreatedByNavigation { get; set; }
        public virtual ICollection<CrmLocationTypes> CrmLocationTypesModifiedByNavigation { get; set; }
        public virtual ICollection<CrmLocations> CrmLocationsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmLocations> CrmLocationsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmMenuSettings> CrmMenuSettingsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmMenuSettings> CrmMenuSettingsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmPreferenceTable> CrmPreferenceTableCreatedByNavigation { get; set; }
        public virtual ICollection<CrmPreferenceTable> CrmPreferenceTableModifiedByNavigation { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUpsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUpsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmProcesse> CrmProcesseCreatedByNavigation { get; set; }
        public virtual ICollection<CrmProcesse> CrmProcesseModifiedByNavigation { get; set; }
        public virtual ICollection<CrmProductModels> CrmProductModelsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmProductModels> CrmProductModelsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmProducts> CrmProductsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmProducts> CrmProductsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmSubMenuSettings> CrmSubMenuSettingsCreatedByNavigation { get; set; }
        public virtual ICollection<CrmSubMenuSettings> CrmSubMenuSettingsModifiedByNavigation { get; set; }
        public virtual ICollection<CrmWorkFlow> CrmWorkFlowCreatedByNavigation { get; set; }
        public virtual ICollection<CrmWorkFlow> CrmWorkFlowModifiedByNavigation { get; set; }
        public virtual ICollection<CustomFreeFiledTables> CustomFreeFiledTablesCreatedByNavigation { get; set; }
        public virtual ICollection<CustomFreeFiledTables> CustomFreeFiledTablesModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAddresses> CustomerAddressesCreatedByNavigation { get; set; }
        public virtual ICollection<CustomerAddresses> CustomerAddressesModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerFamilyInfomations> CustomerFamilyInfomationsCreatedByNavigation { get; set; }
        public virtual ICollection<CustomerFamilyInfomations> CustomerFamilyInfomationsModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerPhysicalInformations> CustomerPhysicalInformationsCreatedByNavigation { get; set; }
        public virtual ICollection<CustomerPhysicalInformations> CustomerPhysicalInformationsModifiedByNavigation { get; set; }
        public virtual ICollection<DocumentTypes> DocumentTypesCreatedByNavigation { get; set; }
        public virtual ICollection<DocumentTypes> DocumentTypesModifiedByNavigation { get; set; }
        public virtual ICollection<DropdownManagements> DropdownManagementsCreatedByNavigation { get; set; }
        public virtual ICollection<DropdownManagements> DropdownManagementsModifiedByNavigation { get; set; }
        public virtual ICollection<DynamicReports> DynamicReportsCreatedByNavigation { get; set; }
        public virtual ICollection<DynamicReports> DynamicReportsModifiedByNavigation { get; set; }
        public virtual ICollection<EducationInformations> EducationInformationsCreatedByNavigation { get; set; }
        public virtual ICollection<EducationInformations> EducationInformationsModifiedByNavigation { get; set; }
        public virtual ICollection<Employees> EmployeesCreatedByNavigation { get; set; }
        public virtual ICollection<Employees> EmployeesModifiedByNavigation { get; set; }
        public virtual ICollection<FreeFieldDataLinkTables> FreeFieldDataLinkTablesCreatedByNavigation { get; set; }
        public virtual ICollection<FreeFieldDataLinkTables> FreeFieldDataLinkTablesModifiedByNavigation { get; set; }
        public virtual ICollection<FreeFieldLinkTables> FreeFieldLinkTablesCreatedByNavigation { get; set; }
        public virtual ICollection<FreeFieldLinkTables> FreeFieldLinkTablesModifiedByNavigation { get; set; }
        public virtual ICollection<InboxMails> InboxMailsCreatedByNavigation { get; set; }
        public virtual ICollection<InboxMails> InboxMailsModifiedByNavigation { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMastersCreatedByNavigation { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMastersModifiedByNavigation { get; set; }
        public virtual ICollection<LeadProductDetails> LeadProductDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<LeadProductDetails> LeadProductDetailsModifiedByNavigation { get; set; }
        public virtual ICollection<LeadProductModelDetails> LeadProductModelDetailsCreatedByNavigation { get; set; }
        public virtual ICollection<LeadProductModelDetails> LeadProductModelDetailsModifiedByNavigation { get; set; }
        public virtual ICollection<MailSetups> MailSetupsCreatedByNavigation { get; set; }
        public virtual ICollection<MailSetups> MailSetupsModifiedByNavigation { get; set; }
        public virtual ICollection<Notifications> NotificationsCreatedByNavigation { get; set; }
        public virtual ICollection<Notifications> NotificationsFromUser { get; set; }
        public virtual ICollection<Notifications> NotificationsModifiedByNavigation { get; set; }
        public virtual ICollection<Notifications> NotificationsToUser { get; set; }
        public virtual ICollection<PreferenceSetups> PreferenceSetupsCreatedByNavigation { get; set; }
        public virtual ICollection<PreferenceSetups> PreferenceSetupsModifiedByNavigation { get; set; }
        public virtual ICollection<Prefixes> PrefixesCreatedByNavigation { get; set; }
        public virtual ICollection<Prefixes> PrefixesModifiedByNavigation { get; set; }
        public virtual ICollection<ProfessionalInformations> ProfessionalInformationsCreatedByNavigation { get; set; }
        public virtual ICollection<ProfessionalInformations> ProfessionalInformationsModifiedByNavigation { get; set; }
        public virtual ICollection<RatingSetups> RatingSetupsCreatedByNavigation { get; set; }
        public virtual ICollection<RatingSetups> RatingSetupsModifiedByNavigation { get; set; }
        public virtual ICollection<SentMails> SentMailsCreatedByNavigation { get; set; }
        public virtual ICollection<SentMails> SentMailsModifiedByNavigation { get; set; }
        public virtual ICollection<SocialWebRecords> SocialWebRecordsCreatedByNavigation { get; set; }
        public virtual ICollection<SocialWebRecords> SocialWebRecordsModifiedByNavigation { get; set; }
        public virtual ICollection<SocioDemographicInformations> SocioDemographicInformationsCreatedByNavigation { get; set; }
        public virtual ICollection<SocioDemographicInformations> SocioDemographicInformationsModifiedByNavigation { get; set; }
        public virtual ICollection<Suffixes> SuffixesCreatedByNavigation { get; set; }
        public virtual ICollection<Suffixes> SuffixesModifiedByNavigation { get; set; }
        public virtual ICollection<TaModes> TaModesCreatedByNavigation { get; set; }
        public virtual ICollection<TaModes> TaModesModifiedByNavigation { get; set; }
        public virtual ICollection<Tests> TestsCreatedByNavigation { get; set; }
        public virtual ICollection<Tests> TestsModifiedByNavigation { get; set; }
        public virtual ICollection<UserMailCredentials> UserMailCredentialsCreatedByNavigation { get; set; }
        public virtual ICollection<UserMailCredentials> UserMailCredentialsModifiedByNavigation { get; set; }
    }
}
