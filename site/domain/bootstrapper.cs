using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;
using lab.domain.interfaces;

namespace lab.domain
{
    public class bootstrapper
    {
        public bootstrapper()
        {
            StructureMapConfiguration.AddRegistry(new Registry1());
        }
    }

    class Registry1 : Registry
    {
        protected override void configure()
        {
            base.configure();

            StructureMapConfiguration.UseDefaultStructureMapConfigFile = false;

            ForRequestedType<IProductRepository>().TheDefaultIsConcreteType<ZohoProductRepository>();
        }
    }
}
