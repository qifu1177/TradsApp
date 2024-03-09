using System;
using System.Collections.Generic;

namespace App.DataAccess.Models
{
    public partial class EmployeeTrade
    {
        public long Oid { get; set; }
        public string Employee { get; set; } = null!;
        public string Isin { get; set; } = null!;
        public int Volumen { get; set; }
        public byte BusinessType { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}
