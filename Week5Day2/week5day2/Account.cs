using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5day2
{
    internal class Account
    {
        public string OwnerFullName { get; set; }
        public string AccountNumber { get; set; }
        public float Amount { get; set; }


        public float Deposit(float _amount)
        {

            Amount = Amount + _amount;
            return Amount;
        }

        public float Credit(float _amount)
        {
            Amount = Amount - _amount;
            return Amount;
        }
    }

}
