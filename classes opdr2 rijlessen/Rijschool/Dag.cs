using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rijschool
{
    internal class Dag
    {
        public class dag
        {
            public DateTime Datum { get; set; }
            public List<LesUur> Lessen { get; set; } = new List<LesUur>();
        }

    }
}
