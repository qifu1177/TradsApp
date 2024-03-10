

using App.Infrastructure.Datas;

namespace App.Infrastructure.Interfaces
{
    public interface IDBUserService
    {
        bool CheckUserGroup(string username,UserGroupType userGroupType);
    }
}
