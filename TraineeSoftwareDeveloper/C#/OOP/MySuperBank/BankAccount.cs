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
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = +item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

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
