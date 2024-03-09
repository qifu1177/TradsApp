using App.Infrastructure;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradesApp.Services;

namespace TradesApp.Views
{
    public partial class LoginView : UserControl
    {
        private IUserService _userService;
        private AppService _appService;
        public event Action<UserGroupType> Login;
        public LoginView(IUserService userService, AppService appService)
        {
            _userService = userService;
            _appService = appService;
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lbErrorMessage.Text = string.Empty;
            try
            {
                _appService.UpdateConnectionString(tbUserName.Text, tbPassword.Text);
                if (_userService.TryLogin(tbUserName.Text, tbPassword.Text, out User user))
                {
                    Login(user.UserGroup.UserGroupType);
                }
                else
                {
                    lbErrorMessage.Text = "Benutzer Name oder Passwort oder Gruppe ist falsch!!!";
                }
            }
            catch (Exception ex)
            {
                lbErrorMessage.Text = "Benutzer Name oder Passwort oder Gruppe ist falsch!!!";
            }
            
        }

       
    }
}
