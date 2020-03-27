using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class DashboardLinkedElements
    {
        public int Id { get; set; }
        public int DashboardId { get; set; }
        public int ElementId { get; set; }
        public string Placement { get; set; }
    }
}
