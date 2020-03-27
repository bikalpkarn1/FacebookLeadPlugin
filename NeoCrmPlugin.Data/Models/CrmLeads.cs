using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmLeads
    {
        public CrmLeads()
        {
            CallRecords = new HashSet<CallRecords>();
            CrmLeadDetails = new HashSet<CrmLeadDetails>();
            CrmProcessFollowUps = new HashSet<CrmProcessFollowUps>();
            FreeFieldDataLinkTables = new HashSet<FreeFieldDataLinkTables>();
            InboxMails = new HashSet<InboxMails>();
            LeadProductDetailMasters = new HashSet<LeadProductDetailMasters>();
            LeadProductDetails = new HashSet<LeadProductDetails>();
            LeadProductModelDetails = new HashSet<LeadProductModelDetails>();
            SentMails = new HashSet<SentMails>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int LeadNo { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductModelId { get; set; }
        public int CompanyCode { get; set; }
        public int? ProcessTypeId { get; set; }
        public int? BranchCode { get; set; }
        public string LeadValue { get; set; }
        public int LeadQuantity { get; set; }
        public int AgentId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string CompletionNepaliDate { get; set; }
        public DateTime LeadDate { get; set; }
        public string LeadNepaliDate { get; set; }
        public string Version { get; set; }
        public string RequestBy { get; set; }
        public string FilePath { get; set; }
        public string FirstNextProcess { get; set; }
        public string SocialMediaType { get; set; }
        public string ThirdPartyId { get; set; }
        public bool IsLeadClosed { get; set; }
        public int? CustomerCompanyId { get; set; }
        public string Subject { get; set; }

        public virtual CrmAgentes Agent { get; set; }
        public virtual CrmBranchSetups BranchCodeNavigation { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual CrmCustomerCompanies CustomerCompany { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProcesse ProcessType { get; set; }
        public virtual CrmProducts Product { get; set; }
        public virtual CrmProductModels ProductModel { get; set; }
        public virtual ICollection<CallRecords> CallRecords { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetails { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUps { get; set; }
        public virtual ICollection<FreeFieldDataLinkTables> FreeFieldDataLinkTables { get; set; }
        public virtual ICollection<InboxMails> InboxMails { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
        public virtual ICollection<LeadProductDetails> LeadProductDetails { get; set; }
        public virtual ICollection<LeadProductModelDetails> LeadProductModelDetails { get; set; }
        public virtual ICollection<SentMails> SentMails { get; set; }
    }
}
