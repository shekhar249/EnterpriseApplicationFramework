using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UI.Infrastructure;
using UI.Services.Interfaces.Services.TransactionManagerService;

namespace UI.TestApp1
{
    [Module(ModuleName = Infrastructure.Constants.ModuleNames.TESTAPP1)]
    public class TestApp1Module : IModule
    {
        
        IRegionManager regionManager;
        IUnityContainer container;
        public TestApp1Module(IRegionManager regionManager, IUnityContainer contanier)
        {
            this.regionManager = regionManager;
            this.container = contanier;
        }
        public void Initialize()
        {
            //container.RegisterInstance<ITransactionManager>(new TransactionManagerClient(new WSHttpBinding(), new EndpointAddress(ConfigPropertiesHelper.ConfigProperties["TransactionManagerService"])));
            regionManager.RegisterViewWithRegion(UI.Infrastructure.Constants.RegionNames.SHELL_TOP_REGION, typeof(TestApp1));

            EventAggregator ea = new EventAggregator();
            container.RegisterInstance<EventAggregator>(ea);
         
        }
    }
}