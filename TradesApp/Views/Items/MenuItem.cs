using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradesApp.Services;

namespace TradesApp.Views.Items
{
    public class MenuItem<T> : AbstractMenuItem where T : UserControl
    {
        private UiService _uiService;
        public MenuItem(UiService uiService) { 
            _uiService = uiService;
        }
        private T _view;

        public override void AddToParent()
        {
            _view = _uiService.CreateView<T>(ParentView.Size);
            _uiService.AddView(ParentView.Controls, _view);
        }
    }
}
