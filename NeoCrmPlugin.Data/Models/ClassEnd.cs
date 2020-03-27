using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class ClassEnd
    {
        public int Id { get; set; }
        public string EndDate { get; set; }
        public string FeedbackForm { get; set; }
        public string ExamDate { get; set; }
        public string CertificateDate { get; set; }
        public int? CertificateNumber { get; set; }
    }
}
