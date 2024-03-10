using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    public enum UserGroupType
    {
        [Description("Compliance")]
        Compliance = 0,
        [Description("Handelsüberwachung ")]
        Handelsueberwachung = 1,
        [Description("Admin ")]
        Admin = 2
    }
}
