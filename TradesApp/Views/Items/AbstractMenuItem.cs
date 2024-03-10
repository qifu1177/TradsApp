using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradesApp.Views.Items
{
    public abstract class AbstractMenuItem
    {
        public string Name { get; set; }
        public Panel ParentView { get; set; }
        public abstract void AddToParent();
    }
}
