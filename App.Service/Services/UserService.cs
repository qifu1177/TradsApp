using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services
{
    public class UserService : IUserService
    {
        private IDBUserService _userService;
        public UserService(IDBUserService userService)
        {
            _userService = userService;
        }
        public bool TryLogin(string username, string password, out User user)
        {
            user = _userService.LoadUser(username, password);
            return user != null;
        }
    }
}
