using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public interface IObserver
    {
        void Update(ISubject sender);
    }
}
