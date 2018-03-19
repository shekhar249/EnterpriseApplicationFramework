using Microsoft.Practices.Unity;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI.Infrastructure;

namespace UI.Navigation.ViewModel
{
   public class NavigationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AboutCommand { get; set; }
        public NavigationViewModel(IUnityContainer container)
        {
            AboutCommand = new UICommand((o) => {
                EventAggregator ea = container.Resolve<EventAggregator>();

                AboutSelectedEvent event1 = ea.GetEvent<AboutSelectedEvent>();
                event1.Publish("hi");
            });

        }


        


    }
}
