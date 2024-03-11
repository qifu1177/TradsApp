using Microsoft.VisualBasic.ApplicationServices;


namespace TradesApp.Models
{
    public abstract class AbstractMenuItem
    {
        public string Name { get; set; }
        public Panel ParentView { get; set; }
        public abstract void AddToParent(App.Infrastructure.Datas.User user);
    }
}
