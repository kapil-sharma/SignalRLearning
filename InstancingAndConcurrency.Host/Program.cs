using InstancingAndConcurrency.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InstancingAndConcurrency.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MyService));
            host.Open();

            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();
        }
    }
}
