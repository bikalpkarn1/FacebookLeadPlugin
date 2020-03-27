using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class ProfessionalInformations
    {
        public ProfessionalInformations()
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
        public string Company { get; set; }
        public string Profession { get; set; }
        public string Designation { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
        public DateTime? LastKnownDate { get; set; }
        public int? CustomerCompanyId { get; set; }
        public int CustomerId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual CrmCustomerCompanies CustomerCompany { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomers { get; set; }
    }
}
