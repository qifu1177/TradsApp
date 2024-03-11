using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services
{
    public class TradeDataService : ITradeDataService
    {
        private IDBTradeDataService _dbService;
        public TradeDataService(IDBTradeDataService dbService)
        {
            _dbService = dbService;
        }
        public IList<TradeData> LoadDatas(DateTimeOffset sdt, DateTimeOffset edt)
        {
            return _dbService.LoadDatas(sdt, edt);
        }

        public void Save(TradeData data)
        {
            _dbService.Save(data);
        }

        public void SaveList(IList<TradeData> datas)
        {
            _dbService.SaveList(datas);
        }
    }
}
