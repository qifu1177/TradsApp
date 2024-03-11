using App.Infrastructure.Datas;
using System.ComponentModel;
using TradesApp.Models;

namespace TradesApp.Dialogs
{
    public partial class AlarmDialog : Form
    {
        public AlarmDialog()
        {
            InitializeComponent();
        }
        public void InitData(IList<TradeData> datas)
        {
            var bindingList = new BindingList<TradeDataGridItem>();
            foreach (var item in datas)
            {
                bindingList.Add(new TradeDataGridItem(item));
            }
            var source = new BindingSource(bindingList, null);
            dgView.DataSource = source;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
