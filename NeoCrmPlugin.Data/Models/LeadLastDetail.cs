using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class LeadLastDetail
    {
        public int Id { get; set; }
        public int? LeadNo { get; set; }
        public int? LastActionId { get; set; }
        public int? LastProcessId { get; set; }
        public int? LastProcessTypeId { get; set; }
        public string LastRemarks { get; set; }
        public DateTime? LeadCreatedDate { get; set; }
        public DateTime? LastDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
    }
}
