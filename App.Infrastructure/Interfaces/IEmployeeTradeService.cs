using App.Infrastructure.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Interfaces
{
    public interface IEmployeeTradeService
    {
        IList<EmployeeTrade> LoadDatas(DateTimeOffset sdt, DateTimeOffset edt);
        void Save(EmployeeTrade entity);
    }
}
