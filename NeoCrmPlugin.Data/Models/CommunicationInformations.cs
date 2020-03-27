using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CommunicationInformations
    {
        public CommunicationInformations()
        {
            CrmCustomers = new HashSet<CrmCustomers>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string ModeType { get; set; }
        public string ModeId { get; set; }
        public bool IsActive { get; set; }
        public int? CustomerId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomers { get; set; }
    }
}
