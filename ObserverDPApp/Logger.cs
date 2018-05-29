using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class Logger : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Notificado log");
        }

        
    }
}
