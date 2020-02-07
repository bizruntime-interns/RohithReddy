using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genereiccollections
{
	class generictype
	{
		
			public bool Compare<T>(T a,T b)
		{
			if(a.Equals(b))
				return true;
			else
			return false;
		}
		static void Main()
		{
			generictype obj = new generictype();
			bool result = obj.Compare<double>(10.5,10.5);
			Console.WriteLine(result);
			bool result1 = obj.Compare<int>(10, 11);
			Console.WriteLine(result1);
			Console.ReadKey();
		}
	}
}
