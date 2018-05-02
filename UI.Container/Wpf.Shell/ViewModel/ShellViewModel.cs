using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Shell.ViewModel
{
    class ShellViewModel
    {

        public ObservableCollection<ModuleInfo> Modules { get; set; }
    }
}
