﻿using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmPreferenceTable
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string TypeName { get; set; }
        public string RoleName { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
