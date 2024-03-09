using System;
using System.Collections.Generic;

namespace App.DataAccess.Models
{
    public partial class Dbuser
    {
        public string Oid { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string UserGroupId { get; set; } = null!;

        public virtual DbuserGroup UserGroup { get; set; } = null!;
    }
}
