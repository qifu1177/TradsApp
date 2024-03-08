using TradesApp.Services;
using TradesApp.Views;

namespace TradesApp
{
    public partial class TradsApp : Form
    {
        private AppService _appService;
        private UiService _uiService;
        public TradsApp(AppService appSerivce, UiService uiService)
        {
            _appService = appSerivce;
            _uiService = uiService;
            InitializeComponent();

        }

        private void TradsApp_Load(object sender, EventArgs e)
        {
           AddLoginView();
        }
        

        private void LoginView_Login(App.Infrastructure.UserGroupType obj)
        {
            AddMainView();
        }

        private void View_Logout()
        {
            AddLoginView();
        }
        private void AddLoginView()
        {
            var loginView = _uiService.CreateView<LoginView>(this.Size);
            loginView.Login += LoginView_Login;
            _uiService.AddView(this.Controls, loginView);
        }
        private void AddMainView()
        {
            var view = _uiService.CreateView<MainView>(this.Size);
            view.Logout += View_Logout; ;
            _uiService.AddView(this.Controls, view);
        }
    }
}
