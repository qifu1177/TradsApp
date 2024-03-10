

using App.Infrastructure.Datas;

namespace App.Infrastructure.Interfaces
{
    public interface IUserService
    {
        IList<UserGroup> GroupList { get; }
        bool TryLogin(string username, UserGroupType UserGroupType, out User user);
    }
}