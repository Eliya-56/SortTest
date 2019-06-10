namespace SortTest
{
	static class SelectionSort
	{
		public static int[] Sort(int[] array)
		{
			var output = new int[array.Length];
			for (int i = 0; i < output.Length; i++)
			{
				var item = FindMin(array);
				output[i] = item;
			}

			return output;
		}

		static int FindMin(int[] array)
		{
			var min = int.MaxValue;
			var last = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < min)
				{
					min = array[i];
					last = i;
				}
			}

			array[last] = int.MaxValue;
			return min;
		}
	}
}
