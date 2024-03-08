

using static System.Windows.Forms.Control;

namespace TradesApp.Services
{
    public class UiService
    {
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
            foreach (Control control in controls)
            {
                control.Dispose();
            }
            controls.Clear();
            controls.Add(view);
        }
    }
}
