

namespace App.Infrastructure.Datas
{
    public class TradeData
    {
        public long Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Price { get; set; }
        public int VolumeUnits { get; set; }
        public decimal VolumeEuro { get; set; }
        public int VolumePieces { get; set; }
        public decimal VolumeCumEuro { get; set; }
    }
}
