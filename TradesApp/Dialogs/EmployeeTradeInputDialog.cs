

using App.Infrastructure;
using App.Infrastructure.Datas;
using App.Infrastructure.Interfaces;
using System.Collections.Generic;
using TradesApp.Services;

namespace TradesApp.Dialogs
{
    public partial class EmployeeTradeInputDialog : Form
    {
        public string UserName { get => tbUser.Text; set => tbUser.Text = value; }
        public string ISIN { get => tbISIN.Text; set => tbISIN.Text = value; }
        public int Volum { get => Convert.ToInt32(tbVolum.Value); set => tbVolum.Value = value; }
        public IEmployeeTradeService DataService { get; set; }
        public UiService UiService { get; set; }
        public EmployeeTradeInputDialog()
        {
            InitializeComponent();
            lbErrorMessage.Text = string.Empty;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            lbErrorMessage.Text = string.Empty;
            if (string.IsNullOrWhiteSpace(UserName))
            {
                lbErrorMessage.Text = "Benutzer ist erfordlich!";
                return;
            }
            if (string.IsNullOrWhiteSpace(ISIN))
            {
                lbErrorMessage.Text = "ISIN ist erfordlich!";
                return;
            }
            EmployeeTrade data = new EmployeeTrade
            {
                Employee = UserName,
                Isin = ISIN,
                Volumen = Volum,
                BusinessType = (BusinessType)cbArt.SelectedValue,
                TimeStamp = DateTime.Now
            };
            try
            {
                DataService.Save(data);
            }
            catch (Exception ex)
            {
                lbErrorMessage.Text = ex.Message;
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EmployeeTradeInputDialog_Load(object sender, EventArgs e)
        {
            cbArt.Items.Clear();
            var list = UiService.GetEnumItems<BusinessType>();
            cbArt.DisplayMember = "Text";
            cbArt.ValueMember = "Value";
            cbArt.DataSource = list;
            cbArt.SelectedIndex = 0;
        }
    }
}
