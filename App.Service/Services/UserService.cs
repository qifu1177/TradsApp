using App.Infrastructure;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace App.Service.Services
{
    public class UserService : IUserService
    {
        private IDBUserService _userService;
        public UserService(IDBUserService userService)
        {
            _userService = userService;
        }

        public IList<UserGroup> GroupList
        {
            get
            {
                List<UserGroup> list = new List<UserGroup>();
                var values = Enum.GetValues(typeof(UserGroupType));
                var enumType = typeof(UserGroupType);
                var attributType = typeof(DescriptionAttribute);
                foreach (var item in values)
                {
                    var userGroup = new UserGroup
                    {
                        Value = (UserGroupType)item,
                        Text = item.ToString()
                    };
                    var enumMemberAttribute =
                       ((DescriptionAttribute[])enumType.GetField(item.ToString()).GetCustomAttributes(attributType, true)).Single();
                    if (enumMemberAttribute != null)
                    {
                        userGroup.Text = enumMemberAttribute.Description;
                    }
                    list.Add(userGroup);
                }
                return list.ToArray();
            }
        }

        public bool TryLogin(string username, UserGroupType userGroupType, out User user)
        {
            user = null;
            bool result = _userService.CheckUserGroup(username, userGroupType);
            if (result)
            {
                user = new User { UserGroupType = userGroupType, UserName = username };

            }
            return result;
        }
    }
}
