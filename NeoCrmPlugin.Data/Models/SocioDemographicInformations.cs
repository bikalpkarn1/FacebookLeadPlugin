using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class SocioDemographicInformations
    {
        public SocioDemographicInformations()
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
        public string Religion { get; set; }
        public string Ethnicity { get; set; }
        public string SocioEconomyGroup { get; set; }
        public string PoliticalAlignment { get; set; }
        public string PersonalityTraits { get; set; }
        public string LifeStyleIntrest { get; set; }
        public string VehicleDriven { get; set; }
        public string HouseSize { get; set; }
        public string HouseType { get; set; }
        public string TravelIntrest { get; set; }
        public int? CustomerId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual CrmCustomers Customer { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<CrmCustomers> CrmCustomers { get; set; }
    }
}
