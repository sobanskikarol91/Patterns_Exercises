using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPizza
{
    class PizzaDecorator : Pizza
    {
        protected float cost;
        protected string size;
        Pizza pizza;

        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int CalculateCost()
        {
            return pizza.CalculateCost();
        }

        public override string GetName()
        {
            return pizza.GetName();
        }
    }
}
