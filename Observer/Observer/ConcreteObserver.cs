using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver : IObserver
    {
        int nr;
        public ConcreteObserver(int nr) { this.nr = nr; }

        public void Update()
        {
            Console.WriteLine(nr);
        }
    }
}
