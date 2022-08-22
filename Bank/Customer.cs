using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Customer
    {
        private string name;
        private int age;

        List<BankAccount> accounts;

        public Customer(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
