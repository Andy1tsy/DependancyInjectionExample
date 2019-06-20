using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    class EFDbReader : IDbReader
    {
        public void ExecuteStoredProcedure()
        {
            // TODO
        }

        public void Read()
        {
            using (var workerContext = new WorkerContext())
            {
                Console.WriteLine("Entity Framework method:");
                Console.WriteLine("Workers Database");
                Console.WriteLine("Id\tName\tBossId\tSpecialityId\tIsBoss");
                var workers = workerContext.Workers;
                foreach (var item in workers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
