
using TradesApp.Services;

namespace TradesApp.Views
{
    public partial class MainView : UserControl
    {
        private AppService _appService;
        public event Action Logout;
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
    }
}
