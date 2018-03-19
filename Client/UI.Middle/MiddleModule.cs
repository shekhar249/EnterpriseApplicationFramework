using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Middle
{
    [Module(ModuleName =Infrastructure.Constants.ModuleNames.MIDDLE)]
    public class MiddleModule : IModule
    {
        IRegionManager regionManager;
        public MiddleModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(Infrastructure.Constants.RegionNames.SHELL_MIDDLE_REGION, typeof(Middle));  
        }
    }
}
