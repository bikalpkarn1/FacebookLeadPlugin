using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class DynamicReports
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeletedFlag { get; set; }
        public string Remark { get; set; }
        public string ModifiedBy { get; set; }
        public string ReportName { get; set; }
        public string ReportHeading { get; set; }
        public bool IsStoreProcedure { get; set; }
        public string StoreProcedureName { get; set; }
        public string Query { get; set; }
        public string WhereCondition { get; set; }
        public bool Date { get; set; }
        public bool DateRange { get; set; }
        public bool User { get; set; }
        public int CompanyCode { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
