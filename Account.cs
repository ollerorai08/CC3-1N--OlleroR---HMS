using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Account
    {
        public string AccountId { get; set; }
        public string Password { get; set; }

        public Account(string accountId, string password)
        {
            AccountId = accountId;
            Password = password;
        }
    }
}
