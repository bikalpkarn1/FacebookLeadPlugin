using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class ClassJoin
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }
        public bool? Payment { get; set; }
        public string Date { get; set; }
        public int? Amount { get; set; }
    }
}
