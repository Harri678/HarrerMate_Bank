using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFeladat
{
	internal class BankCard : BankingService
	{
		double accountBalance;
		string cardNumber;

		public string CardNumber { get; }
		public double AccountBalance { get; }

		public BankCard(Owner owner, double accountBalance, string cardNumber)
		{
			this.accountBalance = accountBalance;
			this.cardNumber = cardNumber;
		}

		public bool Purchace(double amount)
		{
			if (accountBalance - amount >= 0)
			{
				accountBalance -= amount;
				return true;
			}
			return false;
		}
	}
}
