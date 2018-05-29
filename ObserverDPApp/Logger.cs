﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class Logger : IObserver
    {
        
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Writing down {sender.Data.ToUpper()}");
        }

        
    }
}
