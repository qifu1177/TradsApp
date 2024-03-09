using System;
using System.Collections.Generic;

namespace App.DataAccess.Models
{
    public partial class DbuserGroup
    {
        public DbuserGroup()
        {
            Dbusers = new HashSet<Dbuser>();
        }

        public string Oid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int UserGroupType { get; set; }

        public virtual ICollection<Dbuser> Dbusers { get; set; }
    }
}
