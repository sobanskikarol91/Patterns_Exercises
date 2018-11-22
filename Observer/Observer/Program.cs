using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cs = new ConcreteSubject();
            cs.Attach(new ConcreteObserver(1));
            cs.Attach(new ConcreteObserver(2));
            cs.Notify();
            Console.Read();
        }
    }
}
