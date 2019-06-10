namespace SortTest
{
	class QuickSort
	{
		public static int[] Sort(int[] array)
		{
			var output = new int[array.Length];
			for (int i = 0; i < output.Length; i++)
			{
				output[i] = array[i];
			}

			return Sort(output, 0, array.Length - 1);
		}

		static int[] Sort(int[] array, int start, int end)
		{

			var support = array[array.Length / 2];

			var l = start;
			var r = end;

			while (l <= r)
			{
				while (array[l] < support)
				{
					l++;
				}

				while (array[r] >= support)
				{
					r++;
				}

				if (l <= r)
				{
					Swap(ref array[l++], ref array[r--]);
				}
			}

			if (start < r)
			{
				Sort(array, start, r);
			}

			if (end > l)
			{
				Sort(array, l, end);
			}

			return array;
		}

		static void Swap(ref int el1, ref int el2)
		{
			var temp = el1;
			el1 = el2;
			el2 = temp;
		}

	}
}

