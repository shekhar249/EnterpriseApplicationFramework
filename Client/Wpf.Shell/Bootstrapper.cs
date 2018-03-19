using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Windows;

namespace Wpf.Shell
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return Prism.Modularity.ModuleCatalog.CreateFromXaml(new Uri("/Wpf.Shell;component/ModulesCatalog.xaml", UriKind.Relative));
        }
    }
}