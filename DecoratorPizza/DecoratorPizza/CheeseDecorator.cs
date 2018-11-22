using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPizza
{
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)  { }
        
        public override int CalculateCost()
        {
            Console.WriteLine("Extra Cheese");
            return base.CalculateCost() + 20;
        }

        public override string GetName()
        {
            return base.GetName() + " Cheese";
        }
    }
}
