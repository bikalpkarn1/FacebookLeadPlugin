using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmBranchSetups
    {
        public CrmBranchSetups()
        {
            CrmCampaignFaqs = new HashSet<CrmCampaignFaqs>();
            CrmCampaigns = new HashSet<CrmCampaigns>();
            CrmLeadDetails = new HashSet<CrmLeadDetails>();
            CrmLeads = new HashSet<CrmLeads>();
            CrmProcessFollowUps = new HashSet<CrmProcessFollowUps>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public string BranchEngDesc { get; set; }
        public string BranchNepDesc { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public int CompanyCode { get; set; }
        public string AbbrCode { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCampaignFaqs> CrmCampaignFaqs { get; set; }
        public virtual ICollection<CrmCampaigns> CrmCampaigns { get; set; }
        public virtual ICollection<CrmLeadDetails> CrmLeadDetails { get; set; }
        public virtual ICollection<CrmLeads> CrmLeads { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUps { get; set; }
    }
}
