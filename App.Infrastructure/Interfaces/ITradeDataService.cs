using App.Infrastructure.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Infrastructure.Interfaces
{
    public interface ITradeDataService
    {
        IList<TradeData> LoadDatas(DateTimeOffset sdt, DateTimeOffset edt);
        void Save(TradeData data);
        void SaveList(IList<TradeData> datas);

    }
}
