using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace MoviesRememberServices.Utils
{
    public static class Bootstrapper
    {
        private static void RegisterDependencies()
        {
            ObjectFactory.Initialize(
                x => x.Scan(
                    scan =>
                    {
                        scan.TheCallingAssembly();
                        scan.WithDefaultConventions();
                        scan.LookForRegistries();
                    }));
#if DEBUG
            // Place a breakpoint on the line and see the configuration of StructureMap.
            string configuration = ObjectFactory.WhatDoIHave();
#endif
        }

        public static void Bootstrap()
        {
            RegisterDependencies();
        }
    }
}
