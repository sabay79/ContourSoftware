using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {

        }

    }
}
