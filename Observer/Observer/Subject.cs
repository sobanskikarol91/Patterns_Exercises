using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class Subject
    {
        List<IObserver> IObservers = new List<IObserver>();

        public void Attach(IObserver o) { IObservers.Add(o); }
        public void Detach(IObserver o) { IObservers.Remove(o); }
        public void Notify() { IObservers.ForEach(o => o.Update()); }
    }
}
