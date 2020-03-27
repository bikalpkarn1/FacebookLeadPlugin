using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmLeadDetails
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int TransNo { get; set; }
        public int LeadNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AgentId { get; set; }
        public int? ProcessTypeId { get; set; }
        public string Description { get; set; }
        public int? BranchCode { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmAgentes Agent { get; set; }
        public virtual CrmBranchSetups BranchCodeNavigation { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmLeads LeadNoNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProcesse ProcessType { get; set; }
    }
}
