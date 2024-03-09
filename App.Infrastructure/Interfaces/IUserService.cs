

using App.Infrastructure.Datas;

namespace App.Infrastructure.Interfaces
{
    public interface IUserService
    {
        bool TryLogin(string username, UserGroupType UserGroupType, out User user);
    }
}