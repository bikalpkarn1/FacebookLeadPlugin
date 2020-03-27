using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CustomerAddresses
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string AddressStatus { get; set; }
        public string HouseNo { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public bool IsVillage { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string LandMark { get; set; }
        public string LatLong { get; set; }
        public string PhotoOfAddress { get; set; }
        public string AddressOfHomeOrOffice { get; set; }
        public string LandLineNumber { get; set; }
        public int? CustomerId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual CrmCustomers CrmCustomers { get; set; }
    }
}
