using App.Infrastructure;
using App.Infrastructure.Datas;
using System.ComponentModel;

namespace TradesApp.Models
{
    public class EmployeeTradeGridItem
    {
        private readonly EmployeeTrade _data;
        private readonly Dictionary<BusinessType, EnumItem<BusinessType>> _businessTypeToValue;
        public EmployeeTradeGridItem(EmployeeTrade data, Dictionary<BusinessType, EnumItem<BusinessType>> dic)
        {
            _data = data;
            _businessTypeToValue = dic;
        }
        [DisplayName("Mitarbeiter")]
        public string Employee => _data.Employee;
        [DisplayName("ISIN")]
        public string Isin => _data.Isin;
        [DisplayName("Stückzahl")]
        public string Volumen => string.Format("{0:n0}", _data.Volumen);
        [DisplayName("Geschäftsart")]
        public string BusinessType => _businessTypeToValue[_data.BusinessType].Text;
        [DisplayName("Zeitstempel")]
        public string TimeStamp => string.Format("{0:dd.MM.yyyy HH:mm}", _data.TimeStamp);
    }
}
