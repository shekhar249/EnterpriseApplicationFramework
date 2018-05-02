using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TestApp2
{
    [Module(ModuleName =Infrastructure.Constants.ModuleNames.TESTAPP2)]
    public class TestApp2Module : IModule
    {
        IRegionManager regionManager;
        public TestApp2Module(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(Infrastructure.Constants.RegionNames.SHELL_BOTTOM_REGION, typeof(TestApp2));   
        }
    }
}
