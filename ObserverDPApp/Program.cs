using System;

namespace ObserverDPApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Doer doer = new Doer();

            doer.Attach(new Logger());
            doer.Attach(new UserInterface());

            doer.DoSomething("my data");
            
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
