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

namespace TradesApp.Views
{
    public partial class LoginView : UserControl
    {
        private IUserService _userService;
        public event Action<UserGroupType> Login;
        public LoginView(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lbErrorMessage.Text = string.Empty;
            try
            {
                if (_userService.TryLogin(tbUserName.Text, tbPassword.Text, out User user))
                {
                    Login(user.UserGroup.UserGroupType);
                }
                else
                {
                    lbErrorMessage.Text = "Benutzer Name oder Passwort ist falsch!!!";
                }
            }
            catch (Exception ex)
            {
                lbErrorMessage.Text = ex.Message;
            }
            
        }

       
    }
}
