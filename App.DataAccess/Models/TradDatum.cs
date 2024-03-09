using System;
using System.Collections.Generic;

namespace App.DataAccess.Models
{
    public partial class TradDatum
    {
        public long Oid { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public decimal Price { get; set; }
        public int VolumeUnits { get; set; }
        public decimal VolumeEuro { get; set; }
        public int VolumePieces { get; set; }
        public decimal VolumeCumEuro { get; set; }
    }
}
