using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
	public class Student:IComparable<Student>
	{
		public int Sid { get; set; }
		public string Name { get; set; }
		public int Class { get; set; }
		public int Marks { get; set; }

		public int CompareTo(Student other)
		{
			if (this.Sid > other.Sid)
				return 1;
			else if (this.Sid < other.Sid)
				return -1;
			else
				return 0;
		}
	}
     class TestStudent
	{
		static void Main()
		{
			Student s1 = new Student { Sid = 063, Name = "Rohith", Class = 10, Marks = 525 };
			Student s2 = new Student { Sid = 064, Name = "Rahul", Class = 12, Marks = 575 };
			Student s3 = new Student { Sid = 065, Name = "Rakesh", Class = 11, Marks = 545 };
			Student s4 = new Student { Sid = 066, Name = "Raj", Class = 09, Marks = 505 };

			List<Student> Students = new List<Student>() { s1, s2, s3, s4 };
			Students.Reverse();
			foreach(Student S in Students)
			{
				Console.WriteLine("SId:"+S.Sid + " ," +"Name:"+ S.Name + " ," +"Class:"+ S.Class + " ," +"Marks:"+ S.Marks);
			}
			Console.ReadLine();
		}

	}
}
