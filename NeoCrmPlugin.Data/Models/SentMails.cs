using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class SentMails
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string TextMessage { get; set; }
        public bool IsAttachment { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string FileName { get; set; }
        public string MessageId { get; set; }
        public string SenderName { get; set; }
        public string HtmlBody { get; set; }
        public int CompanyCode { get; set; }
        public DateTime? MailDate { get; set; }
        public string Email { get; set; }
        public int? LeadNo { get; set; }
        public int? CustomerId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual CrmLeads LeadNoNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
