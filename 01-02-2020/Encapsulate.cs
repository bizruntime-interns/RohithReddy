using System;

namespace Encapsulation_Example
{
	public class Bank
	{
		private double balance;
		public double getBalance()
		{
		return balance;
		}
		public void setBalance(double balance)
		{		
this.balance = balance;
		}
	}
	class Encapsulate
	{
		public static void Main()
		{
			Bank SBI = new Bank();
			SBI.setBalance(1000);
			Console.WriteLine(SBI.getBalance());
			Console.ReadKey();
		}
	}
}