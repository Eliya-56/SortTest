using System.Collections;
using System.Linq;

namespace SortTest
{
	static class MergeSort
	{
		public static int[] Sort(int[] array)
		{
			var diveded = DivideArray(array);
			if (diveded.Item1.Length != 1)
			{
				diveded.Item1 = Sort(diveded.Item1);
			}

			if (diveded.Item2.Length != 1)
			{
				diveded.Item2 = Sort(diveded.Item2);
			}

			return MergeArrays(diveded.Item1, diveded.Item2);
		}

		static (int[], int[]) DivideArray(int[] array)
		{
			var center = array.Length / 2;
			return (array.Take(center).ToArray(), array.Skip(center).ToArray());
		}

		static int[] MergeArrays(int[] sortedArray1, int[] sortedArray2)
		{
			var output = new int[sortedArray1.Length + sortedArray2.Length];
			var count1 = 0;
			var count2 = 0;
			for (int i = 0; i < output.Length; i++)
			{
				if (sortedArray1[count1] < sortedArray2[count2])
				{
					output[i] = sortedArray1[count1];
					count1++;
					if (count1 >= sortedArray1.Length)
					{
						AppendArray(output, sortedArray2, ++i, count2);
						break;
					}
				}
				else
				{
					output[i] = sortedArray2[count2];
					count2++;
					if (count2 >= sortedArray2.Length)
					{
						AppendArray(output, sortedArray1, ++i, count1);
						break;
					}
				}
			}
			return output;
		}

		static void AppendArray(int[] array1, int[] array2, int startIndex1, int startIndex2)
		{
			for (int i = startIndex1, j = startIndex2; i < array1.Length; i++, j++)
			{
				array1[i] = array2[j];
			}
		}
	}
}
