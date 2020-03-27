using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmProcesse
    {
        public CrmProcesse()
        {
            CrmActions = new HashSet<CrmActions>();
            CrmLeadDetails = new HashSet<CrmLeadDetails>();
            CrmLeads = new HashSet<CrmLeads>();
            CrmProcessFollowUpsNextProcessCodeNavigation = new HashSet<CrmProcessFollowUps>();
            CrmProcessFollowUpsProcessType = new HashSet<CrmProcessFollowUps>();
            CrmWorkFlow = new HashSet<CrmWorkFlow>();
            FreeFieldLinkTables = new HashSet<FreeFieldLinkTables>();
            LeadProductDetailMasters = new HashSet<LeadProductDetailMasters>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string ProcessEngDesc { get; set; }
        public int ProcessDay { get; set; }
        public bool LeadCloseFlag { get; set; }
        public bool PrintFlag { get; set; }
        public string ProcessType { get; set; }
        public int CompanyCode { get; set; }
        public bool IsActive { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmActions> CrmActions { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetails { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUpsNextProcessCodeNavigation { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUpsProcessType { get; set; }
        public virtual ICollection<CrmWorkFlow> CrmWorkFlow { get; set; }
        public virtual ICollection<FreeFieldLinkTables> FreeFieldLinkTables { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
    }
}
