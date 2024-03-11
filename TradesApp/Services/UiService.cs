
using App.Infrastructure.Datas;
using App.Infrastructure;
using System.ComponentModel;
using TradesApp.Models;
using static System.Windows.Forms.Control;

namespace TradesApp.Services
{
    public class UiService
    {
        public Form MainForm { get; set; }
        public C CreateView<C>(Size size) where C : UserControl
        {
            Type viewType = typeof(C);
            C view = AppService.ServiceProvider.GetService(viewType) as C;
            view.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            view.Location = new Point(0, 0);
            view.Name = viewType.Name;
            view.Size = size;
            view.TabIndex = 0;
            return view;
        }
        public void AddView<C>(ControlCollection controls, C view) where C : UserControl
        {
            controls.Clear();
            controls.Add(view);
        }
        public void ShowDialog<T>(Action<T> init,Action<T> excuitOk,Action<T> excuitCancel) where T : Form
        {
            T form=AppService.ServiceProvider.GetService(typeof(T)) as T;
            init(form);
            if(form.ShowDialog(MainForm)== DialogResult.OK)
            {
                if(excuitOk != null)
                {
                    excuitOk(form);
                }
            }else
            {
                if(excuitCancel != null)
                {
                    excuitCancel(form);
                }
            }
            form.Dispose();
        }
        public IList<EnumItem<T>> GetEnumItems<T>()
        {
            List<EnumItem<T>> list = new List<Models.EnumItem<T>>();
            var values = Enum.GetValues(typeof(T));
            var enumType = typeof(T);
            var attributType = typeof(DescriptionAttribute);
            foreach (var item in values)
            {
                var enumItem = new EnumItem<T>
                {
                    Value = (T)item,
                    Text = item.ToString()
                };
                var enumMemberAttribute =
                   ((DescriptionAttribute[])enumType.GetField(item.ToString()).GetCustomAttributes(attributType, true)).Single();
                if (enumMemberAttribute != null)
                {
                    enumItem.Text = enumMemberAttribute.Description;
                }
                list.Add(enumItem);
            }
            return list;
        }
    }
}
