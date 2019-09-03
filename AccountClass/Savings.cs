using System;
using System.Collections.Generic;
using System.Text;
//using inherit
namespace AccountClass {
  public class Savings : Account {

        private decimal IntRate = 0.01M;

        public string Print() {
            return base.Print() +$" Int Rate: {IntRate}";
        }

        public decimal CalcInterest(int months) {
            return IntRate / 12 * months * GetBalance();
        }

        public void CalcAndPayInterest(int months) {
            var interest = CalcInterest(months);
            this.Deposit(interest);
        }
        public void SetInterestRate(decimal intrate) {
            this.IntRate = intrate;
        }

        public Savings(decimal intRate, string description, Customer customer) : base(description, customer) {
            this.IntRate = intRate;
        }
    }
}
