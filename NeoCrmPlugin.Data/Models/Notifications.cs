using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class Notifications
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string NotificationType { get; set; }
        public int? AgentId { get; set; }
        public string ToUserId { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public string FromUserId { get; set; }
        public bool IsRead { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmAgentes Agent { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers FromUser { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual AspNetUsers ToUser { get; set; }
    }
}
