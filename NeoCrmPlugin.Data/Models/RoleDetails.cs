using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class RoleDetails
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public int TaskActionId { get; set; }

        public virtual AspNetRoles Role { get; set; }
        public virtual TaskActions TaskAction { get; set; }
    }
}
