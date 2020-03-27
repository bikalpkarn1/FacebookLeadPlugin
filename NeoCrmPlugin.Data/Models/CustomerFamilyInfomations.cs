using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CustomerFamilyInfomations
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string RelationToMainPerson { get; set; }
        public int? IdOfOtherCustomer { get; set; }
        public string FirstNameFamily { get; set; }
        public string LastNameFamily { get; set; }
        public string MiddleNameFamily { get; set; }
        public string PrefixFamily { get; set; }
        public string SuffixFamily { get; set; }
        public DateTime? AddateOfBirthFamily { get; set; }
        public string BsdateOfBirthFamily { get; set; }
        public string CountryOfBirthFamily { get; set; }
        public string NationalityFamily { get; set; }
        public bool LastKnownMartialStatusFamily { get; set; }
        public string PassportFamily { get; set; }
        public string CitizenshipFamily { get; set; }
        public string DrivingLicenseNoFamily { get; set; }
        public string Photo { get; set; }
        public int? CustomerId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual CrmCustomers IdOfOtherCustomerNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
