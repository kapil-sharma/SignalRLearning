using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;

namespace WcfTraining.Contracts
{
    
    [ServiceContract]
    public interface IRegional
    {
        [OperationContract]
        ZipCodeData GetZipInfo(string zipCode);
    }
}
