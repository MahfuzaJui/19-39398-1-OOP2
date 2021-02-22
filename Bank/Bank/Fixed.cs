using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Fixed : Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int openingYear;

        public int OpeningYear
        {
            get { return openingYear; }
            set { openingYear = value; }
        }

        public Fixed()
        {
            Console.WriteLine("Empty Fixed Constructor.");
        }
        public Fixed(String accName, string accId, double balance, int tenureYear, int openingYear)
            : base(accName, accId, balance)
        {
            this.tenureYear = tenureYear;
            this.openingYear = openingYear;
        }

        public override void Withdraw(int amount)
        {
            if ((Int32.Parse(DateTime.Now.Year.ToString()) - openingYear) == tenureYear && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw amount : " + amount);
            }
            else
                Console.WriteLine("Withdraw failed.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Account ID : " + AccId);
            Console.WriteLine("Balance : " + Balance);

        }

    }
}
