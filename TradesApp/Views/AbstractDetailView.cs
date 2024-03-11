

using App.Infrastructure;

namespace TradesApp.Views
{
    public abstract class AbstractDetailView : UserControl
    {
        protected App.Infrastructure.Datas.User _user;
        public void Setuser(App.Infrastructure.Datas.User user)
        {
            _user = user;
        }        
    }
}
