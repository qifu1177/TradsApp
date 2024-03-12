using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using TradesApp.Dialogs;
using TradesApp.Models;
using TradesApp.Services;
using TradesApp.Views;

namespace TradesApp
{
    public partial class TradsApp : Form
    {
        private AppService _appService;
        private UiService _uiService;
        private ITradeDataService _dataService;
        private Setting _setting;
        DateTime _sdt = DateTime.Today;
        public TradsApp(AppService appSerivce, UiService uiService, ITradeDataService dataService, Setting setting)
        {
            _appService = appSerivce;
            _uiService = uiService;
            _dataService = dataService;
            _setting = setting;
            InitializeComponent();
            _uiService.MainForm = this;
            timerAlarm.Interval = _setting.AlarmIntervalMinutes * 60 * 1000;
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
            timerAlarm.Stop();
            timerAlarm.Enabled = false;
            _sdt = DateTime.Today;
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
                AddMenuItemsForCompliance(menuItems);
            }
            else if (user.UserGroupType == App.Infrastructure.UserGroupType.Handelsueberwachung)
            {
                AddMenuItemsForHandelsueberwachung(menuItems);
            }
            else if (user.UserGroupType == App.Infrastructure.UserGroupType.Admin)
            {
                AddMenuItemsForCompliance(menuItems);
                AddMenuItemsForHandelsueberwachung(menuItems);
            }
            var view = _uiService.CreateView<MainView>(this.Size);
            view.Init(user);
            view.SetMenuItems(menuItems);
            view.Logout += View_Logout; ;
            _uiService.AddView(this.Controls, view);
            if (user.UserGroupType != App.Infrastructure.UserGroupType.Compliance)
            {
                timerAlarm.Enabled = true;
                timerAlarm.Start();
            }
        }
        private void AddMenuItemsForCompliance(List<AbstractMenuItem> menuItems)
        {
            menuItems.Add(new MenuItem<EmployeeTradesView>(_uiService)
            {
                Name = "Geschäfte Liste"
            });
        }
        private void AddMenuItemsForHandelsueberwachung(List<AbstractMenuItem> menuItems)
        {
            menuItems.Add(new MenuItem<TradesView>(_uiService)
            {
                Name = "Trades"
            });
            menuItems.Add(new MenuItem<KursdatenView>(_uiService)
            {
                Name = "Kursdaten"
            });
            menuItems.Add(new MenuItem<SettingView>(_uiService)
            {
                Name = "Einstellungen"
            });
        }
        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            DateTime edt = DateTime.Now;            
            var list = _dataService.LoadDatas(_sdt, edt).OrderBy(item => item.TimeStamp).ToArray();
            List<TradeData> alarmList = new List<TradeData>();
            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0 && list[i].VolumePieces > _setting.AlarmVolumen)
                {
                    alarmList.Add(list[i]);
                    continue;
                }
                var deltaPrice = Math.Abs(list[i].Price - list[i - 1].Price);
                if (deltaPrice > _setting.AlarmChangeValue || list[i].VolumePieces > _setting.AlarmVolumen)
                {
                    alarmList.Add(list[i]);
                }
            }
            if (alarmList.Count > 0)
            {
                _uiService.ShowDialog<AlarmDialog>((form) =>
                {
                    form.InitData(alarmList);
                }, null, null);
            }
            _sdt = edt;
        }
    }
}
