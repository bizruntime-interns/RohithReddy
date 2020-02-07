using System;
namespace inheritance_example
{
	public class User
	{
		public int Id;
		public string Name;
		private string Location;
		
		public void GetUserInfo(string loc)
		{
			Location = loc;
			Console.WriteLine("Id :{0}", Id);
			Console.WriteLine("Name: {0}", Name);
			Console.WriteLine("Location: {0}", Location);
			
		}
	}
	public class Details : User
	{
		public int Age;
		
		public void GetAge()
		{
			Console.WriteLine("Age: {0}", Age);

		}
	}
	public class Salary : User
	{
		internal int salary;

		public void GetSalary()
		{
			Console.WriteLine("Salary: {0}", salary);

		}
	}
	class inheritance
	{
		static void Main(string[] args)
		{
			Details d1 = new Details();

			Salary s1 = new Salary();

			d1.Id = 1;
			d1.Name = "Rohith Reddy";
			d1.Age = 22;
			d1.GetUserInfo("Bangalore");
			d1.GetAge();

			

			s1.salary = 500000;
			s1.GetSalary();
			

			Console.ReadLine();
		}
	}
}