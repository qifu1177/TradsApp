using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradesApp.Models;

namespace TradesApp.Views
{
    public partial class SettingView : AbstractDetailView
    {
        private Setting _setting;
        public SettingView(Setting setting)
        {
            _setting = setting;
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            tbAlarmChangePrice.Value = _setting.AlarmChangeValue;
            tbAlarmChangeVolumen.Value = _setting.AlarmChangeVolumne;
        }

        private void tbAlarmChangePrice_ValueChanged(object sender, EventArgs e)
        {
            _setting.AlarmChangeValue = tbAlarmChangePrice.Value;
        }

        private void tbAlarmChangeVolumen_ValueChanged(object sender, EventArgs e)
        {
            _setting.AlarmChangeVolumne = Convert.ToInt32(tbAlarmChangeVolumen.Value);
        }
    }
}
