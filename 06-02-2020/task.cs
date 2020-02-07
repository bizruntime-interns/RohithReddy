using System;
using System.Threading.Tasks;
namespace TaskExample
{
	public static class TaskProgram
	{
		public static void Main()
		{
			Task t = Task.Run(() =>

			{
				for (int x = 0; x < 10; x++)
				{
					Console.WriteLine("Hello Everyone... ");
					Console.ReadLine();
				}
			});
			t.Wait();
		}
	}
}