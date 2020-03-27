using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCampaignFaqs
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int CampaignCode { get; set; }
        public string CompaignFaqEngDesc { get; set; }
        public string CompaignFaqNepDesc { get; set; }
        public string FaqAnswer { get; set; }
        public bool TagFlag { get; set; }
        public int CompanyCode { get; set; }
        public int BranchCode { get; set; }

        public virtual CrmBranchSetups BranchCodeNavigation { get; set; }
        public virtual CrmCampaigns CampaignCodeNavigation { get; set; }
        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
