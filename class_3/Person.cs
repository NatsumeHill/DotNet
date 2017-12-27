/**
 * @author 谢方奎
 * @email xiefangkui@outlook.com
 * @create date 2017-12-27 02:32:16
 * @modify date 2017-12-27 02:32:16
 * @desc Utility person declaration
*/
using System;
namespace class_3
{
	public class Person : IComparable
	{
		private int age;
		private string name;
		public Person(int age, string name)
		{
			this.age = age;
			this.name = name;
		}

		public int CompareTo(object obj)
		{
			Person other = (Person)obj;
			int i = this.age - other.age;
			if (i == 0)
				return this.name.CompareTo(other.name);
			return i;
		}

		public override string ToString()
		{
			return name + ":" + age.ToString();
		}
	}
}