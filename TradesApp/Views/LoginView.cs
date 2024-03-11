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
using TradesApp.Models;
using TradesApp.Services;

namespace TradesApp.Views
{
    public partial class LoginView : UserControl
    {
        private IUserService _userService;
        private AppService _appService;
        private UiService _uiService;
        public event Action<User> Login;
        public LoginView(IUserService userService, AppService appService, UiService uiService)
        {
            _userService = userService;
            _appService = appService;
            _uiService = uiService;
            InitializeComponent();
            Init();
            
        }
        private void Init()
        {
            cbGroupType.Items.Clear();
            var list = _uiService.GetEnumItems<UserGroupType>();
            cbGroupType.DisplayMember= "Text";
            cbGroupType.ValueMember = "Value";
            cbGroupType.DataSource = list;
            cbGroupType.SelectedIndex = 0;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            lbErrorMessage.Text = string.Empty;
            try
            {
                _appService.UpdateConnectionString(tbUserName.Text, tbPassword.Text);
                UserGroupType selctedGroup=(UserGroupType)cbGroupType.SelectedValue;
                if (_userService.TryLogin(tbUserName.Text, selctedGroup, out User user))
                {
                    Login(user);
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
