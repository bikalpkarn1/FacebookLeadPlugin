using System;
using System.Collections.Generic;

namespace NeoCrmPlugin.Data.Models
{
    public partial class TaskActions
    {
        public TaskActions()
        {
            RoleDetails = new HashSet<RoleDetails>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string ActionName { get; set; }

        public virtual ICollection<RoleDetails> RoleDetails { get; set; }
    }
}
