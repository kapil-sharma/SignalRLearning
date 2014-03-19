using InstancingAndConcurrency.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InstancingAndConcurrency.Service
{
    [ServiceBehavior(
        InstanceContextMode= InstanceContextMode.PerCall,
        ConcurrencyMode=ConcurrencyMode.Single)]
    public class MyService : IMyContract
    {
        public MyService()
        {
            Console.WriteLine("MyService Constructor Called.");
        }

        int _Counter = 0;
        public void IncrementCounter()
        {

        }
    }
}
