using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTraining.Contracts;

namespace WcfTraining.Services
{
    public class RegionalService: IRegional
    {
        public ZipCodeData GetZipInfo(string zipCode)
        {
            ZipCodeData result = new ZipCodeData();
            result.City = "Jaipur";
            result.State = "Rajasthan";
            result.Zip = "302017";
            return result;
        }
    }
}
