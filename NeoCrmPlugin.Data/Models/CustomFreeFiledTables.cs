using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CustomFreeFiledTables
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int DocumentTypeId { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public bool IsNull { get; set; }
        public bool IsUpdated { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual DocumentTypes DocumentType { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
