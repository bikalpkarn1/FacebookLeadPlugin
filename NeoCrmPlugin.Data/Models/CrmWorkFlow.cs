using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmWorkFlow
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int ProcessCode { get; set; }
        public int ActionCode { get; set; }
        public int AgentTypeCode { get; set; }
        public int Priority { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmActions ActionCodeNavigation { get; set; }
        public virtual CrmAgentType AgentTypeCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProcesse ProcessCodeNavigation { get; set; }
    }
}
