using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Person
    {
        public string Name;
        public List<Item> Inventory = new List<Item>();

        public Person(string name)
        {
            Name = name;
        }
    }
}
