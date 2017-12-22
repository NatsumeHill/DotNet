using System;
namespace class_3
{
    public class Person:IComparable<Person>
    {
        private int age;
        public Person(int age)
        {
            this.age = age;
        }

		public int CompareTo(Person other)
		{
			return this.age - other.age;
		}

        public static void Swap(Person left, Person right)
        {
            int temp = left.age;
            left.age = right.age;
            right.age = temp;
        }

        public override string ToString()
        {
            return age.ToString();
        }
	}
}