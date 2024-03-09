

using App.Infrastructure.Datas;

namespace App.Infrastructure.Interfaces
{
    public interface IUserService
    {
        bool TryLogin(string username, string password, out User user);
    }
}