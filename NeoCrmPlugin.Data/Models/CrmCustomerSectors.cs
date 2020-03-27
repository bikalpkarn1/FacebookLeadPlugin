using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class CrmCustomerSectors
    {
        public CrmCustomerSectors()
        {
            CrmCampaigns = new HashSet<CrmCampaigns>();
            CrmCustomers = new HashSet<CrmCustomers>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string CustomerSectorId { get; set; }
        public string CustomerSectorEngDesc { get; set; }
        public string CustomerSectorNepDesc { get; set; }
        public int CompanyCode { get; set; }

        public virtual CrmCompanySetups CompanyCodeNavigation { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCampaigns> CrmCampaigns { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomers { get; set; }
    }
}
