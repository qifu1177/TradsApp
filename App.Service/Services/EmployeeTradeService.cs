using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;


namespace App.Service.Services
{
    public class EmployeeTradeService : IEmployeeTradeService
    {
        private IDBEmployeeTradeService _dBEmployeeTradeService;
        public EmployeeTradeService(IDBEmployeeTradeService dBEmployeeTradeService) {
            _dBEmployeeTradeService = dBEmployeeTradeService;
        }
        public IList<EmployeeTrade> LoadDatas(DateTimeOffset sdt, DateTimeOffset edt)
        {
            return _dBEmployeeTradeService.LoadDatas(sdt, edt);
        }

        public void Save(EmployeeTrade entity)
        {
            _dBEmployeeTradeService.Save(entity);
        }
    }
}
