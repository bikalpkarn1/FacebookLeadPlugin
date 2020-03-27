using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class TaModes
    {
        public TaModes()
        {
            CrmActions = new HashSet<CrmActions>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string ModeName { get; set; }
        public string Icon { get; set; }
        public string SystemMode { get; set; }
        public int CompanyCode { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmActions> CrmActions { get; set; }
    }
}
