using Prism.Modularity;
using Prism.Regions;

namespace UI.Navigation
{
    [Module(ModuleName = Infrastructure.Constants.ModuleNames.NAVIGATION_MENU)]
    class NavigationModule : IModule
    {
        IRegionManager regionManager;
        public NavigationModule(IRegionManager regionManager)
        {

            this.regionManager = regionManager;
        }
        public void Initialize()
        {          
            regionManager.RegisterViewWithRegion(Infrastructure.Constants.RegionNames.MENU_REGION,typeof(NavigationMenu));
        }

    }
}
