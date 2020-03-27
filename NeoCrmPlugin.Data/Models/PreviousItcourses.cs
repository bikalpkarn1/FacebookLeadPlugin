using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class PreviousItcourses
    {
        public int Id { get; set; }
        public bool? CourseDone { get; set; }
        public string InstituteName { get; set; }
        public string CourseName { get; set; }
    }
}
