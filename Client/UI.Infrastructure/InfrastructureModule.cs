using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Infrastructure
{
    public class InfrastructureModule : IModule
    {
        public void Initialize()
        {
            //throw new NotImplementedException();
            ConfigPropertiesHelper.LoadProperties();
        }
    }
}
