using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfTraining.Services;

namespace WcfTraining.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(RegionalService));
            host.Open();

            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();
        }
    }
}
