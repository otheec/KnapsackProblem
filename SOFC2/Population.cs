using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFC3
{
    internal class Population
    {
        public List<Individual> Individuals { get; set; }

        public Population(int size)
        {
            Individuals = new List<Individual>();
            for (int i = 0; i < size; i++)
            {
                Individuals.Add(new Individual());
            }
        }

    }
}
