using System;
using System.Collections.Generic;
using System.Text;

namespace SortTest
{
	class BubbleSort
	{
		public static int[] Sort(int[] array)
		{
			var output = new int[array.Length];
			for (int i = 0; i < output.Length; i++)
			{
				output[i] = array[i];
			}

			for (int i = 0; i < output.Length; i++)
			{
				for (int j = i; j < array.Length; j++)
				{
					if (output[i] > output[j])
					{
						var temp = output[j];
						output[j] = output[i];
						output[i] = temp;
					}
				}

			}
			return output;
		}
	}
}
