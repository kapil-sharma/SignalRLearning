using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfTraining.Contracts
{
    public class RegionalClient : ClientBase<IRegional>, IRegional
    {
        public ZipCodeData GetZipInfo(string zipCode)
        {
            return Channel.GetZipInfo(zipCode);
        }
    }
}
