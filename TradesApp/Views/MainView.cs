
using App.Infrastructure.Datas;
using TradesApp.Models;
using TradesApp.Services;

namespace TradesApp.Views
{
    public partial class MainView : UserControl
    {
        private AppService _appService;
        private User _user;
        private string _selectedMenu;
        public event Action Logout;
        private Dictionary<string, AbstractMenuItem> _menuItems;
        public MainView(AppService appService)
        {
            InitializeComponent();
            _appService = appService;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            _appService.UpdateConnectionString(string.Empty, string.Empty);
            Logout();
        }
        public void Init(User user)
        {
            _user = user;
            lbUser.Text = user.UserName;
        }
        public void SetMenuItems(IList<AbstractMenuItem> menuItems)
        {
            _selectedMenu = string.Empty;
            foreach (var item in menuItems)
            {
                item.ParentView = pnView;
            }
            _menuItems = menuItems.ToDictionary(item => item.Name);
            listViewNavi.DisplayMember = "Name";
            listViewNavi.ValueMember = "Name";            
            listViewNavi.DataSource = menuItems;           
           
        }


        private void listViewNavi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listViewNavi.SelectedValue == null)
                return;
            string value = (string)listViewNavi.SelectedValue;
            if (!_selectedMenu.Equals(value) && _menuItems.TryGetValue(value, out var menuItem))
            {
                menuItem.AddToParent(_user);
            }
            _selectedMenu = value;
        }
    }
}
