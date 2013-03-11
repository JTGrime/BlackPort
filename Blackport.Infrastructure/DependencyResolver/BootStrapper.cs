using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Blackport.Infrastructure.DependencyResolver
{
    public static class BootStrapper
    {
        public static void Run()
        {
            ObjectFactory.Configure((x => x.AddRegistry(new DependencyRegistry())));
        }
    }
}