using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFC3
{
    internal class Individual
    {
        public List<bool> Genes { get; set; }
        public int Fitness { get; set; }

        public Individual()
        {
            Genes = new List<bool>();
            Fitness = 0;
        }
    }
}
