using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InstancingAndConcurrency.Contract
{
    class MyClient : ClientBase<IMyContract>, IMyContract
    {
        public void IncrementCounter()
        {
            Channel.IncrementCounter();
        }
    }
}
