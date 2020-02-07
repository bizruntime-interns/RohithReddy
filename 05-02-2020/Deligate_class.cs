using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate_example
{
	//Defining a deligate must always be done next to the namespace
	public delegate void AddDelegate(int x, int y);
	public delegate string SayDelegate(string names); 
	class Program
	{
		public void AddNum(int a,int b)
		{
			Console.WriteLine("Sum is: "+(a + b));
		}
		public static string SayHello(string name)
		{
			return "Hello! " + name;
		}
		static void Main(string[] args)
		{
			//Instantiating an deligate
			Program p = new Program();
			AddDelegate ad = new AddDelegate(p.AddNum);
			ad(500, 400);

			SayDelegate sd = new SayDelegate(Program.SayHello);
			string str=sd("Rohith Reddy M.T");
			Console.WriteLine(str);

			 
			Console.ReadLine();
		}
	}
}
