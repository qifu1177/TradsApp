using App.Infrastructure.Interfaces;

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
            var datas = _dataService.LoadDatas(sdt, edt);
            
        }
    }
}
