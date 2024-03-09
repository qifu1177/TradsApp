

using App.Infrastructure.Datas;

namespace App.Infrastructure.Interfaces
{
    public interface IDBUserService
    {
        public User LoadUser(string username,string password);
    }
}
