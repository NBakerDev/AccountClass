using System;
using System.Collections.Generic;
using System.Text;
//using composition
namespace AccountClass {
   public class Checking {
        private Account _account = null;

        public bool Deposit(decimal amount) {
           return _account.Deposit(amount);
        }
        public bool Withdraw(decimal amount) {
            return _account.Withdraw(amount);
        }

        public bool WriteCheck(int checkNbr, decimal amount) {
            return false;
        }

        public string Print() {
            return _account.Print();
        }

        public decimal GetBalance() {
            return _account.GetBalance();
        }

        public Checking(string description, Customer customer) {
            _account = new Account(description, customer);
        }
    }
}
