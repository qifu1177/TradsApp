using App.Infrastructure;
using App.Infrastructure.Datas;
using System.ComponentModel;

namespace TradesApp.Models
{
    public class TradeDataGridItem
    {
        private readonly TradeData _data;
        public TradeDataGridItem(TradeData data)
        {
            _data = data;
        }
        [DisplayName("Zeitstempel")]
        public string TimeStamp => string.Format("{0:dd.MM.yyyy HH:mm:ss.fff}", _data.TimeStamp);
        [DisplayName("PREIS")]
        public string Price => string.Format("{0:f3}", _data.Price);
        [DisplayName("VOLUMEN EINHEITEN")]
        public string VolumeUnits => string.Format("{0:n}", _data.VolumeUnits);
        [DisplayName("VOLUMEN EURO")]
        public string VolumeEuro => string.Format("{0:f2}", _data.VolumeEuro);
        [DisplayName("VOLUMEN (KUM.) STÜCK")]
        public string VolumePieces => string.Format("{0:n}", _data.VolumePieces);
        [DisplayName("VOLUMEN (KUM.) EURO")]
        public string VolumeCumEuro => string.Format("{0:f2}", _data.VolumeCumEuro);
    }
}
