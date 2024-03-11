
using TradesApp.Services;
using TradesApp.Views;

namespace TradesApp.Models
{
    public class MenuItem<T> : AbstractMenuItem where T : AbstractDetailView
    {
        private UiService _uiService;
        public MenuItem(UiService uiService)
        {
            _uiService = uiService;
        }
        private T _view;

        public override void AddToParent(App.Infrastructure.Datas.User user)
        {
            _view = _uiService.CreateView<T>(ParentView.Size);
            _view.Setuser(user);
            _uiService.AddView(ParentView.Controls, _view);
        }
    }
}
