using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TestApp3
{
    [Module(ModuleName =Infrastructure.Constants.ModuleNames.TESTAPP3)]
    public class TestApp3Module : IModule
    {
        IRegionManager regionManager;
        public TestApp3Module(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(Infrastructure.Constants.RegionNames.SHELL_MIDDLE_REGION, typeof(TestApp3));  
        }
    }
}
