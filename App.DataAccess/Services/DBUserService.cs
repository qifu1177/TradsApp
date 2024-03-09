

using App.Infrastructure;
using App.Infrastructure.Common;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;

namespace App.DataAccess.Services
{
    public class DBUserService : IDBUserService
    {
        private Config _config;
        public DBUserService(Config config)
        {
            _config = config;
        }
        public User LoadUser(string username, string password)
        {
            User user = null;
            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            //    return user;
            //}
            //AppDBContext dBContext = new AppDBContext(_config);
            //user = dBContext.Dbusers.Where((item) => item.UserName == username && item.Password == password).Select((data) => new User
            //{
            //    UserName = data.UserName,
            //    UserGroup = new UserGroup
            //    {
            //        UserGroupType = (UserGroupType)data.UserGroup.UserGroupType
            //    }
            //}).FirstOrDefault();
            //if (data != null)
            //{
            //    user = new User
            //    {
            //        UserName = data.UserName,
            //        UserGroup = new UserGroup
            //        {
            //            UserGroupType = (UserGroupType)data.UserGroup.UserGroupType
            //        }
            //    };
            //}
            return user;
        }
    }
}
