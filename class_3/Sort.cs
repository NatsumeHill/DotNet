/**
 * @author 谢方奎
 * @email xiefangkui@outlook.com
 * @create date 2017-12-27 02:31:15
 * @modify date 2017-12-27 02:31:15
 * @desc Sort class implemention
*/
using System;
using System.Collections.Generic;
namespace class_3
{
	public class Sort
	{
		public static void selectsort(List<IComparable> src)
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
					swap(src, step, j);
			}
		}
		public static void swap<T>(List<T> src, int i, int j)
		{
			T tmp = src[i];
			src[i] = src[j];
			src[j] = tmp;
		}
	}
}