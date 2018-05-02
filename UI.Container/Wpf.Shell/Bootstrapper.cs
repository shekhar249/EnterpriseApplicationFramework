using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Windows;
using UI.Infrastructure;
using Wpf.Shell.ViewModel;

namespace Wpf.Shell
{
    class Bootstrapper : UnityBootstrapper
    {
        private const string MODULES_PATH = @".\";

        private Shell shell = null;// ServiceLocator.Current.GetInstance<Shell>();
        private List<ModuleInfo> modules = new List<ModuleInfo>();
        protected override DependencyObject CreateShell()
        {
             shell = ServiceLocator.Current.GetInstance<Shell>();
            ShellViewModel vm = shell.DataContext as ShellViewModel;
            if (vm != null)
            {
                vm.Modules = new System.Collections.ObjectModel.ObservableCollection<ModuleInfo>(modules);
            }
            return shell;
        }
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {

            return new DirectoryModuleCatalog() { ModulePath = MODULES_PATH };
            // return Prism.Modularity.ModuleCatalog.CreateFromXaml(new Uri("/Wpf.Shell;component/ModulesCatalog.xaml", UriKind.Relative));
        }
        protected override void ConfigureModuleCatalog()
        {
           
            //Adding infrastructure module as the first module to be loaded with shell            
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(InfrastructureModule));


            //base.ConfigureModuleCatalog();
            var directoryCatalog = (DirectoryModuleCatalog)ModuleCatalog;
            directoryCatalog.Initialize();

            foreach (var module in directoryCatalog.Items)
            {
                var mi = module as ModuleInfo;
                if (mi != null && mi.ModuleName!="InfrastructureModule")
                {
                    modules.Add(mi);
                }
            }
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
        }
    }
}