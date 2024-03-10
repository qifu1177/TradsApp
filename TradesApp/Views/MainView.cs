
using App.Infrastructure.Datas;
using TradesApp.Services;
using TradesApp.Views.Items;

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
            listViewNavi.Items.Clear();
            foreach (var item in menuItems)
            {
                listViewNavi.Items.Add(new ListViewItem(item.Name));
            }
            listViewNavi.ItemSelectionChanged += ListViewNavi_ItemSelectionChanged;
            listViewNavi.MultiSelect = false;
            listViewNavi.Items[0].Selected = true;
        }

        private void ListViewNavi_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (!_selectedMenu.Equals(e.Item.Text) && _menuItems.TryGetValue(e.Item.Text, out var menuItem))
            {
                menuItem.AddToParent();
            }
            _selectedMenu = e.Item.Text;
        }
    }
}
