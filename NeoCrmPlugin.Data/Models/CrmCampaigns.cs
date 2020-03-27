using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCampaigns
    {
        public CrmCampaigns()
        {
            CrmCampaignFaqs = new HashSet<CrmCampaignFaqs>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CampaignType { get; set; }
        public string CampaignEngDesc { get; set; }
        public string CampaignNepDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int TargetQty { get; set; }
        public double TargetAmount { get; set; }
        public string Description { get; set; }
        public bool TagFlag { get; set; }
        public int? ProductCode { get; set; }
        public int? CustomerCode { get; set; }
        public int? CustomerSectorCode { get; set; }
        public int? CompanyTypeCode { get; set; }
        public int CompanyCode { get; set; }
        public int BranchCode { get; set; }
        public bool IsNotDeleted { get; set; }

        public virtual CrmBranchSetups BranchCodeNavigation { get; set; }
        public virtual CrmCompanyTypes CompanyTypeCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomerSectors CustomerSectorCodeNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProducts ProductCodeNavigation { get; set; }
        public virtual ICollection<CrmCampaignFaqs> CrmCampaignFaqs { get; set; }
    }
}
