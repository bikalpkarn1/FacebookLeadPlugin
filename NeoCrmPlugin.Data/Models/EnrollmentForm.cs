using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class EnrollmentForm
    {
        public int Id { get; set; }
        public int? Fees { get; set; }
        public string CourseCode { get; set; }
        public string EnrollmentCourseName { get; set; }
        public string CurrentEngagement { get; set; }
        public bool? IHaveReadAndAgreedTheTermsAndConditionsOfEnrollmentToTheInstitute { get; set; }
        public string PaymentOption { get; set; }
        public int? OfficialIdNo { get; set; }
        public string OfficialIdType { get; set; }
        public int? EmergencyContactNo { get; set; }
        public string ParentsGuardianContactNumber { get; set; }
    }
}
