using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.Infrastructure.DependencyResolver
{
    class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            //For<Interface>().Use<concreate>();
        }
    }
}
