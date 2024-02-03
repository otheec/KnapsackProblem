﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFC3
{
    internal class Item
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, int weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }
    }
}
