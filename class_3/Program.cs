using System;
using System.Collections.Generic;
namespace class_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> list = new List<Person>(0);
			for (int i = 0; i < 10; i++)
			{
				list.Add(new Person(i));
				Console.Write(" {0}", list[i].ToString());
			}
			for (int i = 0; i < 10; i++)
			{
				list.Add(new Person(40 - i));
				Console.Write(" {0}", list[i + 10].ToString());
			}
			Console.WriteLine("");
			Sort.dosort(list);
			foreach (var p in list)
				Console.Write(" {0}", p.ToString());
		}
	}
}
