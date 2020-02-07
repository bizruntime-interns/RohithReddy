using System;

namespace exception
{
	class exceptionhandling
	{
		public static void Main(string[] args)
		{
			try
			{
				int number1, number2, result;
				Console.WriteLine("Enter number1: ");
				number1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter number2: ");
				number2 = int.Parse(Console.ReadLine());

				result = number1 / number2;
				Console.WriteLine("The result is :" + result);
				Console.ReadKey();
			}
			catch
			{
				Console.WriteLine("Error in the input values :");
				Console.ReadKey();
				throw;
								
			}
			finally
			{
				Console.WriteLine("Program executed successfully ");
				Console.ReadKey();
			}
			
		}
	}
}