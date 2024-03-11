using App.Infrastructure.Common;
using App.Infrastructure;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services
{
    public class DBTradeDataService : IDBTradeDataService
    {
        private Config _config;
        public DBTradeDataService(Config config)
        {
            _config = config;
        }
        public IList<TradeData> LoadDatas(DateTimeOffset sdt, DateTimeOffset edt)
        {
            List<TradeData> list = new List<TradeData>();
            using (AppDBContext dbContext = new AppDBContext(_config))
            {
                list = dbContext.TradData.Where(item => item.TimeStamp >= sdt && item.TimeStamp <= edt).Select(item => new TradeData
                {
                    Id = item.Oid,
                    TimeStamp = item.TimeStamp.LocalDateTime,
                    Price = item.Price,
                    VolumeCumEuro = item.VolumeCumEuro,
                    VolumeEuro = item.VolumeEuro,
                    VolumePieces = item.VolumePieces,
                    VolumeUnits = item.VolumeUnits

                }).ToList();
            }
            return list;
        }

        public void Save(TradeData item)
        {
            using (AppDBContext dbContext = new AppDBContext(_config))
            {
                Models.TradDatum data = new Models.TradDatum
                {
                    Price = item.Price,
                    VolumeCumEuro = item.VolumeCumEuro,
                    VolumeEuro = item.VolumeEuro,
                    VolumePieces = item.VolumePieces,
                    VolumeUnits = item.VolumeUnits,
                    TimeStamp = DateTime.SpecifyKind(item.TimeStamp, DateTimeKind.Local)
                };
                dbContext.TradData.Add(data);
                dbContext.SaveChanges();
            }
        }

        public void SaveList(IList<TradeData> datas)
        {
            using (AppDBContext dbContext = new AppDBContext(_config))
            {
                foreach(var item in datas)
                {
                    Models.TradDatum data = new Models.TradDatum
                    {
                        Price = item.Price,
                        VolumeCumEuro = item.VolumeCumEuro,
                        VolumeEuro = item.VolumeEuro,
                        VolumePieces = item.VolumePieces,
                        VolumeUnits = item.VolumeUnits,
                        TimeStamp = DateTime.SpecifyKind(item.TimeStamp, DateTimeKind.Local)
                    };
                    dbContext.TradData.Add(data);
                }                
                dbContext.SaveChanges();
            }
        }
    }
}
