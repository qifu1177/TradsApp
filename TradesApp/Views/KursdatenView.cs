using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;
using TradesApp.Models;

namespace TradesApp.Views
{
    public partial class KursdatenView : AbstractDetailView
    {
        private ITradeDataService _dataService;
        public KursdatenView(ITradeDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            Init();
            LoadDatas();
        }
        private void Init()
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Now;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            LoadDatas();
        }
        private void LoadDatas()
        {
            DateTimeOffset sdt = DateTime.SpecifyKind(dtFrom.Value, DateTimeKind.Local);
            DateTimeOffset edt = DateTime.SpecifyKind(dtTo.Value, DateTimeKind.Local);
            var datas = _dataService.LoadDatas(sdt, edt).OrderBy(item=>item.TimeStamp).ToArray();
            var bindingList = new BindingList<TradeData>();
            decimal max = decimal.MinValue;
            decimal min = decimal.MaxValue;
            foreach (var item in datas)
            {
                if (item.Price > max)
                    max = item.Price;
                if (item.Price < min)
                    min = item.Price;
                bindingList.Add(item);
            }
            if(datas.Length == 0) {
                min = 0;
                max = 100;
            }else
            {
                min = min * 0.9m;
                max = max * 1.1m;
            }           
            chartView.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartView.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(max);
            chartView.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(min);
            chartView.ChartAreas[0].AxisY.LabelStyle.Format = "n2";
            chartView.ChartAreas[0].AxisX.LabelStyle.Format="dd.MM.yy HH:mm";
            var source = new BindingSource(bindingList, null);
            chartView.DataSource = source;

        }
    }
}
