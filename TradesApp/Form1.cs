using App.Infrastructure.Datas;
using TradesApp.Services;
using TradesApp.Views;
using TradesApp.Views.Items;

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


        private void LoginView_Login(User user)
        {
            AddMainView(user);
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
        private void AddMainView(User user)
        {
            if (user == null)
                return;
            List<AbstractMenuItem> menuItems = new List<AbstractMenuItem>();
            if (user.UserGroupType == App.Infrastructure.UserGroupType.Compliance)
            {
                menuItems.Add(new MenuItem<EmployeeTradesView>(_uiService)
                {
                    Name = "Geschäfte Liste"
                });
            }
            else if (user.UserGroupType == App.Infrastructure.UserGroupType.Handelsueberwachung)
            {
                menuItems.Add(new MenuItem<TradesView>(_uiService)
                {
                    Name = "Trades"
                });
                menuItems.Add(new MenuItem<KursdatenView>(_uiService)
                {
                    Name = "Kursdaten"
                });
            }
            else if (user.UserGroupType == App.Infrastructure.UserGroupType.Admin)
            {
                menuItems.Add(new MenuItem<EmployeeTradesView>(_uiService)
                {
                    Name = "Geschäfte Liste"
                });
                menuItems.Add(new MenuItem<TradesView>(_uiService)
                {
                    Name = "Trades"
                });
                menuItems.Add(new MenuItem<KursdatenView>(_uiService)
                {
                    Name = "Kursdaten"
                });
            }
            var view = _uiService.CreateView<MainView>(this.Size);
            view.Init(user);
            view.SetMenuItems(menuItems);
            view.Logout += View_Logout; ;
            _uiService.AddView(this.Controls, view);
        }
    }
}
