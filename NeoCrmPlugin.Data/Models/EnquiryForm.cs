using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class EnquiryForm
    {
        public int Id { get; set; }
        public string HighestQualification { get; set; }
        public string Stream { get; set; }
        public string GuardianName { get; set; }
        public string GuardianMobileNumber { get; set; }
        public string InterestedIn { get; set; }
        public string HeardFrom { get; set; }
        public string ReferredBy { get; set; }
        public bool PreviousComputerCourse { get; set; }
        public string PreviousComputerCourseAt { get; set; }
        public string PreviousComputerCourseName { get; set; }
        public string PreferredTimeForCourse { get; set; }
    }
}
