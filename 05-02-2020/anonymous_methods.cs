using System;
namespace Lambda_expression
{
	public delegate string GreetDeligate(string name);
	class anonymous_methods
	{
		static void Main()
		{
			GreetDeligate obj = (name) =>
			{
				return "Hello " + name + " a very Good afternoon!";
			};
			string str = obj.Invoke("Rohith Reddy");
			Console.WriteLine(str);
			Console.ReadLine();

		}
	}
}
