using System;
namespace polymorphism_example
{
	// Base Class
	public class BasicClass
	{
		public virtual void GetInfo()
		{
			Console.WriteLine("Learn to code in C#");
		}
	}
	// Derived Class
	public class DerivedClass : BasicClass
	{
		public override void GetInfo()
		{
			Console.WriteLine("Welcome to My World!");
		}
	}
	class polymorphism
	{
		static void Main(string[] args)
		{
			DerivedClass d = new DerivedClass();
			d.GetInfo();
			BasicClass b = new BasicClass();
			b.GetInfo();
			Console.ReadLine();
		}
	}
}