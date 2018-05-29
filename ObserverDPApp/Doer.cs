using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class Doer : ISubject
    {
        IList<IObserver> ObsList = new List<IObserver>();

        public void DoSomething()
        {
            Console.WriteLine("Doing Something");
            this.Notify();
        }

        public void Attach(IObserver obs)
        {
            ObsList.Add(obs);
        }

        public void Dettach(IObserver obs)
        {
            ObsList.Remove(obs);
        }

        public void Notify()
        {
            foreach(var itemObs in ObsList)
            {
                itemObs.Update();
            }
        }
    }
}
