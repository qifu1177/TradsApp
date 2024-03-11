using App.Infrastructure;
using App.Infrastructure.Common;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System.ComponentModel;
using TradesApp.Models;
using TradesApp.Services;

namespace TradesApp.Views
{
    public partial class TradesView : AbstractDetailView
    {
        private ITradeDataService _dataService;
        private HtmlService _htmlService;
        private Config _config;
        private DateTime _lastDataTimeStamp;
        public TradesView(ITradeDataService dataService, HtmlService htmlService, Config config)
        {
            _dataService = dataService;
            _htmlService = htmlService;
            _config = config;
            InitializeComponent();
            Init();
            LoadDatas();
        }
        private void Init()
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Now;
            _lastDataTimeStamp = DateTime.Today;
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
            var bindingList = new BindingList<TradeDataGridItem>();

            foreach (var item in datas)
            {
                if (_lastDataTimeStamp < item.TimeStamp)
                    _lastDataTimeStamp = item.TimeStamp;
                bindingList.Add(new TradeDataGridItem(item));
            }
            var source = new BindingSource(bindingList, null);
            dgView.DataSource = source;
        }

        private async void btImport_Click(object sender, EventArgs e)
        {
            try
            {
                var datas = await _htmlService.LoadDatasFromWebPage(_config.DataPageUrl);
                var list = new List<TradeData>();
                DateTime max = DateTime.MinValue;
                foreach (var data in datas)
                {
                    if (data.TimeStamp > _lastDataTimeStamp)
                    {
                        list.Add(data);
                        if (data.TimeStamp > max)
                            max = data.TimeStamp;
                    }
                }
                if (max > _lastDataTimeStamp)
                {
                    _lastDataTimeStamp = max;
                }
                _dataService.SaveList(list);
            }
            catch (Exception ex)
            {

            }

        }
    }
}
