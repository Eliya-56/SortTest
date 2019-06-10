namespace SortTest
{
	static class InsertionSort
	{
		public static int[] Sort(int[] array)
		{
			var output = new int[array.Length];
			output[0] = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (output[j] > array[i])
					{
						var temp = array[i];
						ArrayShiftForward(output, j, i - j);
						output[j] = temp;
						break;
					}
				}
			}

			return output;
		}

		static int[] ArrayShiftForward(int[] array, int startIndex, int length)
		{
			for (int i = length + startIndex; i > startIndex; i--)
			{
				array[i] = array[i - 1];
			}

			return array;
		}
	}
}
