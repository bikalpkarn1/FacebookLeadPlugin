using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmMenuSettings
    {
        public CrmMenuSettings()
        {
            CrmSubMenuSettings = new HashSet<CrmSubMenuSettings>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string MenuIcon { get; set; }
        public string MenuComponentName { get; set; }
        public string Menudata { get; set; }
        public bool HasCaret { get; set; }
        public string MenuBadge { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmSubMenuSettings> CrmSubMenuSettings { get; set; }
    }
}
