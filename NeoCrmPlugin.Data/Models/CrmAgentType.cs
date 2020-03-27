using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmAgentType
    {
        public CrmAgentType()
        {
            CrmAgentes = new HashSet<CrmAgentes>();
            CrmWorkFlow = new HashSet<CrmWorkFlow>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string AgentTypeId { get; set; }
        public string AgentTypeEngDesc { get; set; }
        public string AgentTypeNepDesc { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmAgentes> CrmAgentes { get; set; }
        public virtual ICollection<CrmWorkFlow> CrmWorkFlow { get; set; }
    }
}
