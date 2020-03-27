using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class SocialWebRecords
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int CompanyCode { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime MessageCreatedDate { get; set; }
        public string UserId { get; set; }
        public string Subject { get; set; }
        public string MessageId { get; set; }
        public string PostCreaterName { get; set; }
        public string PostCreaterId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
