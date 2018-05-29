using System;

namespace ObserverDPApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Doer doer = new Doer();

            doer.Attach(new Logger());

            doer.DoSomething();
            
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
