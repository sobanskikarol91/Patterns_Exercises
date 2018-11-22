using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPizza
{
    class LargePizza : Pizza
    {
        public LargePizza() : base() { }

        public override int CalculateCost()
        {
            return 30;
        }

        public override string GetName()
        {
            return "Large";
        }
    }
}
