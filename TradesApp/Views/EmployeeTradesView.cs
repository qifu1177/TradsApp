using App.Infrastructure;
using App.Infrastructure.Interfaces;
using System.ComponentModel;
using TradesApp.Dialogs;
using TradesApp.Models;
using TradesApp.Services;

namespace TradesApp.Views
{
    public partial class EmployeeTradesView : AbstractDetailView
    {
        private IEmployeeTradeService _dataService;
        private UiService _uiService;
        private Dictionary<BusinessType, EnumItem<BusinessType>> _businessTypeToValue;
        public EmployeeTradesView(IEmployeeTradeService dataService,UiService uiService)
        {
            _dataService = dataService;
            _uiService = uiService;
            InitializeComponent();
            Init();
            LoadDatas();
        }
        private void Init()
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Now;
            _businessTypeToValue = _uiService.GetEnumItems<BusinessType>().ToDictionary(item => item.Value);
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            _uiService.ShowDialog<EmployeeTradeInputDialog>((form) => { 
                form.UserName = _user.UserName;
                form.UiService = _uiService;
                form.DataService = _dataService;
            }, null, null);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            LoadDatas();
        }
        private void LoadDatas()
        {
            DateTimeOffset sdt = DateTime.SpecifyKind(dtFrom.Value, DateTimeKind.Local);
            DateTimeOffset edt = DateTime.SpecifyKind(dtTo.Value, DateTimeKind.Local);
            var datas = _dataService.LoadDatas(sdt, edt);
            var bindingList = new BindingList<EmployeeTradeGridItem>();

            foreach (var item in datas)
            {
                bindingList.Add(new EmployeeTradeGridItem(item, _businessTypeToValue));
            }
            var source = new BindingSource(bindingList, null);
            dgView.DataSource = source;
        }
    }
}
