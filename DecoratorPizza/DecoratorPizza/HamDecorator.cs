using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPizza
{
    class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza) : base(pizza)
        {

        }

        public override int CalculateCost()
        {
            return base.CalculateCost() + 10;
        }

        public override string GetName()
        {
            return base.GetName() + " Ham";
        }
    }
}
