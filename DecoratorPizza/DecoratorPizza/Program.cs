using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DecoratorPizza
{
    class Program
    {
        static void Main()
        {
            Pizza pizza = new LargePizza();
            pizza = new CheeseDecorator(pizza);
            pizza = new HamDecorator(pizza);
            pizza.CalculateCost();
            Console.WriteLine(pizza.GetName());
            Console.Read();
        }
    }
}
