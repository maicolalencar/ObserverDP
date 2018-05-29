using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class UserInterface : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Hey user, look at {sender.Data.ToUpper()}");
        }
    }
}
