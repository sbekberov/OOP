using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Ingredient
    {
        private string name;
        public Ingredient(string n)
        {
            name = n;
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
    }
}
