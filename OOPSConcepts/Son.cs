using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Son : Father
    {
        public string Name { get; set; }
        public string BankAccount
        {
            get
            {
                return base.BankAccount;
            }
            set
            {
                base.BankAccount = value;
            }
        }
        public Son()
        {
        }
        public string Age { get; set; }
    }
}
