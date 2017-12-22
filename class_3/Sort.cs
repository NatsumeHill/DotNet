using System;
using System.Collections.Generic;
namespace class_3
{
	public class Sort
	{
		public static void dosort(List<Person> src)
		{
			int step;
			for (step = 0; step < src.Count; step++)
			{
				int i, j;
				j = step;
				/* Find the index of minimu data */
				for (i = step + 1; i < src.Count; i++)
					if (src[i].CompareTo(src[j]) < 0)
						j = i;
				/* If the minimu one is not first one, swap */
				if (step != j)
					Person.Swap(src[step], src[j]);
			}
		}
	}
}