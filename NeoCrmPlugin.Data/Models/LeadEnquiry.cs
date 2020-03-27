using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class LeadEnquiry
    {
        public int Id { get; set; }
        public string HighestQualification { get; set; }
        public string CollegeName { get; set; }
        public string Stream { get; set; }
        public string GaurdianName { get; set; }
        public bool? WorkingStatus { get; set; }
        public string CarrierFocusOn { get; set; }
        public string KnowHow { get; set; }
        public string ReferredBy { get; set; }
    }
}
