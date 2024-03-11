using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Datas
{
    public class EmployeeTrade
    {
        public long Id { get; set; }
        public string Employee { get; set; } = null!;
        public string Isin { get; set; } = null!;
        public int Volumen { get; set; }
        public BusinessType BusinessType { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
