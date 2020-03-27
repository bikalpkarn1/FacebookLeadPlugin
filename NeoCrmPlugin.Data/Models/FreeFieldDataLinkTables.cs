using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class FreeFieldDataLinkTables
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int DocumentTemplateId { get; set; }
        public int LeadNo { get; set; }
        public int PrimaryKeyForAssociateTable { get; set; }
        public int DocumentSaveFrom { get; set; }
        public int ProcessNo { get; set; }
        public int CompanyCode { get; set; }
        public string LeadName { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual DocumentTypes DocumentTemplate { get; set; }
        public virtual CrmLeads LeadNoNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
