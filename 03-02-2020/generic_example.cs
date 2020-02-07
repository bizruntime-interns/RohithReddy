using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections

{
	class generic_example
	{
		static void Main(string[] args)
		{

			Console.WriteLine("\t Now lets see example for generic collections.\t");

			List<int> li = new List<int>();
			List<string> ls = new List<string>();

			li.Add(10);
			li.Add(11);
			li.Add(12);
			ls.Add("Rohith");
			ls.Add("Rahul");
			ls.Add("Rakesh");
			for (int i = 0; i < li.Count; i++)
					Console.WriteLine(li[i] +" ");
			for (int j = 0; j < ls.Count; j++)
				Console.WriteLine(ls[j] + " ");
	    	Console.ReadLine();
		
}
	}
}
