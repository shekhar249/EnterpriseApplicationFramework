using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Bottom
{
    [Module(ModuleName =Infrastructure.Constants.ModuleNames.BOTTOM)]
    public class BottomModule : IModule
    {
        IRegionManager regionManager;
        public BottomModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(Infrastructure.Constants.RegionNames.SHELL_BOTTOM_REGION, typeof(Bottom));   
        }
    }
}
