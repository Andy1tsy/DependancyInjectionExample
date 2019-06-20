using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    /// <summary>
    /// defines context for EF processing DB
    /// </summary>
    public class WorkerContext : DbContext
    {
        public WorkerContext() : base("DbConnection") { } // DbConnection
        public DbSet<Worker> Workers { get; set; }
       
    }
}
