using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class DropdownManagements
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string TableName { get; set; }
        public bool IsStaticDropdown { get; set; }
        public string Values { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string ReferenceTable { get; set; }
        public string ColumnName { get; set; }
        public int CompanyCode { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
