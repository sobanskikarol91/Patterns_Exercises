using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPizza
{
    abstract class Pizza
    {
        string name;
        protected int cost;

        public Pizza(string name = "")
        {
            this.name = name;
        }

        public abstract string GetName();
        public abstract int CalculateCost();
    }
}
