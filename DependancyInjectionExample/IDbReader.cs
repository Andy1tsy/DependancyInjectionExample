using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    public interface IDbReader
    {
        void Read();
        void ExecuteStoredProcedure();
    }
}
