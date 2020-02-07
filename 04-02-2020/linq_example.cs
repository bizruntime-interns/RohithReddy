using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_example
{
	class arrays
	{
		static void Main()
		{
			int[] array = { 11, 14, 15, 87, 14, 17, 49, 20,54,47,48,51,52,57,59,61,63,68,71,54,87,89,99,100};
			var brr = from i in array where i>40 orderby i descending select i;
			foreach (int x in brr)
				Console.Write(x + " ");
			Console.ReadLine();
		}
	}
}
