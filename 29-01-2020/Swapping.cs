using System;

namespace numberswapping
{
    class Swapping
    {
        static void Main(string[] args)
        {
			int number1, number2, temporary;
            Console.Write("\nNumber1 : ");
			number1 = int.Parse(Console.ReadLine());
            Console.Write("\nNumber2 : ");
			number2 = int.Parse(Console.ReadLine());

			temporary = number1;
			number1 = number2;
			number2 = temporary;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nNumber1 : " + number1);
            Console.Write("\nNumber2 : " + number2);
			Console.ReadKey();
			
		}
	}
}