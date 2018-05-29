using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class Doer : ISubject
    {
        IList<IObserver> ObsList = new List<IObserver>();

        public string Data { get; set; }

        public void DoSomething(string data)
        {
            this.Data = data;
            //Console.WriteLine($"Doing Something with {data}");
            this.Notify(this);
        }

        public void Attach(IObserver obs)
        {
            ObsList.Add(obs);
        }

        public void Dettach(IObserver obs)
        {
            ObsList.Remove(obs);
        }

        public void Notify(ISubject sender)
        {
            foreach(var itemObs in ObsList)
            {
                itemObs.Update(sender);
            }
        }
    }
}
