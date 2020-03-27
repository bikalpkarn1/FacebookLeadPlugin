using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class MailSetups
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string IncommingHostName { get; set; }
        public int IncommingPort { get; set; }
        public string OutgoingHostName { get; set; }
        public int OutgoingPort { get; set; }
        public bool UseSsl { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
