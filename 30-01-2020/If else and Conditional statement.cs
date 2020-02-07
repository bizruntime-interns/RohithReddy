using System;

namespace calci
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;                   
            string operation;
            int answer;

            Console.WriteLine("-----Hello, welcome to Universal calculator!-----");
            Console.ReadLine();

            Console.Write("Enter num1:");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2:");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Ok now enter the operation to perform : ");
            operation = Console.ReadLine();

            if (operation == "*")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " * " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "%")
            {
                answer = firstNum % secondNum;
                Console.WriteLine(firstNum + " % " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("  Please select a proper operation!  ");     
                Console.ReadLine();
            }
        }
    }
}