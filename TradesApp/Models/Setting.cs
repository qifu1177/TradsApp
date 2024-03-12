using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradesApp.Models
{
    public class Setting
    {
        public decimal AlarmChangeValue { get; set; } = 100;
        public int AlarmVolumen { get; set; } = 10000;
        public int AlarmIntervalMinutes { get; set; } = 10;
    }
}
