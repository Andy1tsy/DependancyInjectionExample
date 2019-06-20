using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    /// <summary>
    /// resolving dependancy injection
    /// </summary>
    public static class DIConfig
    {
        public static IDbReader Configure(string ProviderType)
        {
            var builder = new ContainerBuilder();
            switch (ProviderType)
            {
                case "AdoNet":
                    {
                        builder.RegisterType<AdoNetDbReader>().As<IDbReader>().SingleInstance();
                        break;
                    }
                case "Dapper":
                    {
                        builder.RegisterType<DapperDbReader>().As<IDbReader>().SingleInstance();
                        break;
                    }
                case "EF":
                    {
                        builder.RegisterType<EFDbReader>().As<IDbReader>().SingleInstance();
                        break;
                    }
                default:
                    {
                        builder.RegisterType<IDbReader>().As<IDbReader>().SingleInstance();
                        break;
                    }
            }

            var container = builder.Build();
            IDbReader reader = container.Resolve<IDbReader>();
            return reader;
        }

    }
}
