using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFC3
{
    internal class Knapsack
    {
        public int Capacity { get; set; }
        public List<Item> Items { get; set; }

        public Knapsack(int capacity)
        {
            Capacity = capacity;
            Items = new List<Item>();
        }

        public int TotalValue()
        {
            return Items.Sum(item => item.Value);
        }

        public int TotalWeight()
        {
            return Items.Sum(item => item.Weight);
        }
    }
}
