using System;
namespace Exceptions
{
	class exceptionhandling
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter number: ");
				int num = Convert.ToInt32(Console.ReadLine());

				Console.Write("Square root of " +num+ " is " +Math.Sqrt(num) +".");
				Console.ReadKey();
			}
			catch
			{
				Console.WriteLine(" Error in input ");
				Console.ReadKey();
			}
			finally
			{
				Console.WriteLine(" User input is correct ");
				Console.ReadKey();

			}
		}
	}
}
	