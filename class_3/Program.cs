/**
 * @author 谢方奎
 * @email xiefangkui@outlook.com
 * @create date 2017-12-27 02:31:57
 * @modify date 2017-12-27 02:31:57
 * @desc Program entry
*/
using System;
using System.Collections.Generic;
namespace class_3
{
	class Program
	{
		static void Main(string[] args)
		{
			string []names = {"fank","andrew","sindy","jorje","dandy","kitty"};
			List<IComparable> list = new List<IComparable>(0);
			Console.WriteLine("Before sort:");
			for (int i = 0; i < 10; i++)
			{
				list.Add(new Person(i,names[i%6]));
				Console.Write(" {0}", list[i].ToString());
			}
			for (int i = 0; i < 10; i++)
			{
				list.Add(new Person(40 - i,names[i%6]));
				Console.Write(" {0}", list[i + 10].ToString());
			}
			Console.WriteLine("\nAfter sort:");
			Sort.selectsort(list);
			foreach (var p in list)
				Console.Write(" {0}", p.ToString());
		}
	}
}
