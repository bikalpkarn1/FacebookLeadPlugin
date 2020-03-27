using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmProcessFollowUps
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int ProcessNo { get; set; }
        public int LeadNo { get; set; }
        public int ProcessTypeId { get; set; }
        public int AgentId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int EstdValue { get; set; }
        public string EstdType { get; set; }
        public DateTime? EstdDate { get; set; }
        public int EstdComplete { get; set; }
        public bool CloseFlag { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? NextProcessCode { get; set; }
        public int? NextAgentCode { get; set; }
        public DateTime? NextDeadLineDate { get; set; }
        public string NextDescription { get; set; }
        public string FilePath { get; set; }
        public int? BranchCode { get; set; }
        public int CompanyCode { get; set; }
        public string EstdCost { get; set; }
        public string SynRowId { get; set; }
        public string Subject { get; set; }
        public int WorkCompleted { get; set; }
        public int ActionId { get; set; }
        public int? NextActionId { get; set; }
        public string EmojiIcon { get; set; }
        public string NextLeadFilePath { get; set; }
        public string Result { get; set; }
        public bool IsLeadFile { get; set; }

        public virtual CrmActions Action { get; set; }
        public virtual CrmAgentes Agent { get; set; }
        public virtual CrmBranchSetups BranchCodeNavigation { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmLeads LeadNoNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmAgentes NextAgentCodeNavigation { get; set; }
        public virtual CrmProcesse NextProcessCodeNavigation { get; set; }
        public virtual CrmProcesse ProcessType { get; set; }
    }
}
