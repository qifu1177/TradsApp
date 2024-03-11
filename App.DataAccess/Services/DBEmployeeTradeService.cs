
using App.Infrastructure;
using App.Infrastructure.Common;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace App.DataAccess.Services
{
    public class DBEmployeeTradeService : IDBEmployeeTradeService
    {
        private Config _config;
        public DBEmployeeTradeService(Config config)
        {
            _config = config;
        }
        public IList<EmployeeTrade> LoadDatas(DateTimeOffset sdt, DateTimeOffset edt)
        {
            List<EmployeeTrade> list = new List<EmployeeTrade>();
            using (AppDBContext dbContext = new AppDBContext(_config))
            {
                list = dbContext.EmployeeTrades.Where(item => item.TimeStamp >= sdt && item.TimeStamp <= edt).Select(item => new EmployeeTrade
                {
                    Id = item.Oid,
                    Employee = item.Employee,
                    Isin = item.Isin,
                    Volumen = item.Volumen,
                    BusinessType = (BusinessType)item.BusinessType,
                    TimeStamp = item.TimeStamp.LocalDateTime

                }).ToList();
            }
            return list;
        }

        public void Save(EmployeeTrade entity)
        {
            using (AppDBContext dbContext = new AppDBContext(_config))
            {
                Models.EmployeeTrade data = new Models.EmployeeTrade
                {
                    Employee = entity.Employee,
                    Isin = entity.Isin,
                    Volumen = entity.Volumen,
                    BusinessType = (byte)entity.BusinessType,
                    TimeStamp = DateTime.SpecifyKind(entity.TimeStamp, DateTimeKind.Local)
                };
                dbContext.EmployeeTrades.Add(data);
                dbContext.SaveChanges();
            }
        }
    }
}
