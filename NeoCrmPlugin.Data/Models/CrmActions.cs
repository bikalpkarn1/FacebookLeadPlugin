using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmActions
    {
        public CrmActions()
        {
            CrmProcessFollowUps = new HashSet<CrmProcessFollowUps>();
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
        public string ActionEngDesc { get; set; }
        public int ActionDays { get; set; }
        public int ProcessCode { get; set; }
        public bool LeadCloseFlag { get; set; }
        public bool PrintFlag { get; set; }
        public string ProcessType { get; set; }
        public int CompanyCode { get; set; }
        public bool LeadStartFlag { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }
        public string EstimatedTime { get; set; }
        public int? TaMode { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProcesse ProcessCodeNavigation { get; set; }
        public virtual TaModes TaModeNavigation { get; set; }
        public virtual ICollection<CrmProcessFollowUps> CrmProcessFollowUps { get; set; }
        public virtual ICollection<CrmWorkFlow> CrmWorkFlow { get; set; }
        public virtual ICollection<FreeFieldLinkTables> FreeFieldLinkTables { get; set; }
        public virtual ICollection<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
    }
}
