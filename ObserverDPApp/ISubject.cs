using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public interface ISubject
    {
        string Data { get; set; }

        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void Notify(ISubject sender);
    }
}
