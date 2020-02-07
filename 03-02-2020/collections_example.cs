using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_example

{
	class arraylist
	{
		static void Main(string[] args)
		{
			ArrayList al = new ArrayList();
			al.Add("rohith");
			Console.WriteLine(al.Capacity);
			al.Add("rahul");
			al.Add("rakesh");
			al.Add("rajesh");
			al.Add("rohith-reddy");
			Console.WriteLine(al.Capacity);
			foreach (object obj in al)
				Console.Write(obj + " ");
			Console.WriteLine();

			al.Insert(1, "ashutosh");
			foreach (object obj in al)
				Console.Write(obj + " ");
			Console.WriteLine();

			al.Remove("rohith");
			foreach (object obj in al)
				Console.Write(obj + " ");
			Console.ReadLine();

			Console.WriteLine("\t Now lets see example for Hashcode.\t");

			Hashtable ht = new Hashtable();
			ht.Add("Id",10);
			ht.Add("Name","Rohith Reddy MT");
			ht.Add("Mobile", 9876543310);
			ht.Add("Email","rrr@gmail.com");
			ht.Add("Location", "Bangalore");
			ht.Add("Salary", 50000);
			foreach (object key in ht.Keys)
            Console.WriteLine(key+ " : " + ht[key]);
			Console.ReadLine();

		}
	}
}
