﻿using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
