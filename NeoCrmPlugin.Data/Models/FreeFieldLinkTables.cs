using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class FreeFieldLinkTables
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int DocumentTemplateId { get; set; }
        public string FormConnectTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsShownToMenu { get; set; }
        public int? ProcessId { get; set; }
        public int? ActionId { get; set; }
        public int CompanyCode { get; set; }
        public string Columns { get; set; }

        public virtual CrmActions Action { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual DocumentTypes DocumentTemplate { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmProcesse Process { get; set; }
    }
}
