using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Datas
{
    public class UserGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public UserGroupType UserGroupType { get; set; }
    }
}
