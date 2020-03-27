using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class RatingSetups
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string RatingName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CompanyCode { get; set; }
        public string MainIcon { get; set; }
        public string Color { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
