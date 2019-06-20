using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    /// <summary>
    /// base entity for processing
    /// </summary>
    public class Worker
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int BossId { get; set; }
       public int SpecialityId { get; set; }
       public bool IsBoss { get; set; }

        public Worker()
        { }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{BossId}\t{SpecialityId}\t\t{IsBoss}";
        }
    }
}
