using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmAgentes
    {
        public CrmAgentes()
        {
            CrmAgentCustomerMapping = new HashSet<CrmAgentCustomerMapping>();
            CrmAgentProduct = new HashSet<CrmAgentProduct>();
            CrmLeadDetails = new HashSet<CrmLeadDetails>();
            CrmLeads = new HashSet<CrmLeads>();
            CrmProcessFollowUpsAgent = new HashSet<CrmProcessFollowUps>();
            CrmProcessFollowUpsNextAgentCodeNavigation = new HashSet<CrmProcessFollowUps>();
            LeadProductDetailMasters = new HashSet<LeadProductDetailMasters>();
            Notifications = new HashSet<Notifications>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string AgentId { get; set; }
        public string AgentEngDesc { get; set; }
        public string AgentNepDesc { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string EmployeeCode { get; set; }
        public int MasterCode { get; set; }
        public int PreCode { get; set; }
        public bool GroupFlag { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AgentTypeCode { get; set; }
        public bool AgentLock { get; set; }
        public bool TagFlag { get; set; }
        public int CompanyCode { get; set; }
        public string AgentUserId { get; set; }
        public string AgentShortName { get; set; }

        public virtual CrmAgentType AgentTypeCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentCustomerMapping> CrmAgentCustomerMapping { get; set; }
        public virtual ICollection<CrmAgentProduct> CrmAgentProduct { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetails { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUpsAgent { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUpsNextAgentCodeNavigation { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
    }
}
