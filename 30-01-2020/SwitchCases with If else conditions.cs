using System;
namespace atm_program
{
    class atmworking
    {
        static void Main(String[] args)
        {
            int amount = 90000003, withdrawamount, currentbalance,pin = 1234, pin1, pin2;

            Console.WriteLine("--------------------WELCOME TO UNIVERSAL BANK---------------------");

			//reading the pin
			Console.WriteLine("Enter the pin... ");
            pin1 = int.Parse(Console.ReadLine());

            //comparing the pin
            if (pin1 == pin)
            {
                Console.WriteLine("1.Check Balance ");
                Console.WriteLine("2.Withdraw Amount ");
                Console.WriteLine("3.Show Balance ");
                Console.WriteLine("4.Change pin ");
                Console.WriteLine("   ENTER YOUR CHOICE   ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Your current balance is :" + amount);
                        break;

                    case 2:
                        Console.WriteLine("Enter amount to withdraw(Only in multiples of 100).");
                        {
							withdrawamount = int.Parse(Console.ReadLine());
                            if (amount >= withdrawamount)
                            {
                                if (withdrawamount % 100 == 0)
                                {
                                    Console.WriteLine("Please collect the cash....." + withdrawamount);
									currentbalance = amount - withdrawamount;
                                    Console.WriteLine("The current balance is : " + currentbalance);
                                }
                                else
                                    Console.WriteLine("Please enter the amount to withdraw in the multiples of 100.");
                            }
                            else
                                Console.WriteLine("NO BALANCE.....");
                            Console.ReadKey();

                        }

                        break;

                    case 3:
                        Console.WriteLine(amount);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Want to change your pin. ");
                        Console.WriteLine("Enter your previous pin. ");
                        int previouspin = int.Parse(Console.ReadLine());
                        if (previouspin == pin)
                        {
                            Console.WriteLine("Enter your new pin. ");
                            pin2 = int.Parse(Console.ReadLine());
                            pin1 = pin2;
                            Console.WriteLine("Your pin is changed");
                        }
                        else
                            Console.WriteLine("Enter your correct pin");
                        Console.ReadKey();

                        break;

                    default:
                        Console.WriteLine("Please select correct option");
                        Console.ReadKey();

          break;
                }
            }
            else
       Console.WriteLine("Pin is wrong");
       Console.ReadKey();

        }
    }
}
