using System;

namespace multicast_deligates
{
	//Defining a deligate must always be done next to the namespace
	public delegate void CalciDeligate(int num1, int num2);

	class calculator
	{
		public void GetSum(int num1, int num2)
		{
			Console.WriteLine("Sum is: " + (num1 + num2));
		}
		public void GetSub(int num1, int num2)
		{
			Console.WriteLine("Subtraction is: "+(num1 - num2));
		}
		public void GetMul(int num1, int num2)
		{
			Console.WriteLine("Multiplication is: " + (num1 * num2));
		}
		public void GetDiv(int num1, int num2)
		{
			Console.WriteLine("Division is: " + (num1 / num2));
		}
		public void GetAvg(int num1, int num2)
		{
			Console.WriteLine("Average of given two numbers is: " + (num1 + num2)/2);
		}
		static void Main()
		{
			calculator c = new calculator();

			//Createing instantiation of deligate
			CalciDeligate obj = c.GetSum;
			obj += c.GetSub;
			obj += c.GetMul;
			obj += c.GetDiv;
			obj += c.GetAvg;

			obj.Invoke(150, 100);
			Console.WriteLine();

			Console.ReadLine();


		}
	}
}
