using System;
using System.Diagnostics;

namespace SortTest
{
	class Program
	{
		static readonly Random Random = new Random();
		static readonly int ArrayLength = 10000;
		static readonly int[] devTestArray = {67, 43, 123, 435, 65};

		static void Main(string[] args)
		{
			// TODO Delete
			//// FOR TEST
			var t = QuickSort.Sort(devTestArray);
			Environment.Exit(1);
			//// FOR TEST

			var testArray = GenereateArray(ArrayLength);
			Stopwatch watch;

			// InsertionSort
			watch = System.Diagnostics.Stopwatch.StartNew();
			var insertionOutput = InsertionSort.Sort(testArray);
			watch.Stop();
			var insertionDuration = watch.ElapsedMilliseconds;

			// MergeSort
			watch = System.Diagnostics.Stopwatch.StartNew();
			var mergeOutput = MergeSort.Sort(testArray);
			watch.Stop();
			var mergeDuration = watch.ElapsedMilliseconds;
			

			// SelectionSort
			watch = System.Diagnostics.Stopwatch.StartNew();
			var selectionOutput = SelectionSort.Sort(testArray);
			watch.Stop();
			var selectionDuration = watch.ElapsedMilliseconds;

			// BubbleSort
			watch = System.Diagnostics.Stopwatch.StartNew();
			var bubbleOutput = BubbleSort.Sort(testArray);
			watch.Stop();
			var bubbleDuration = watch.ElapsedMilliseconds;

			// Results
			Console.WriteLine("Array length: " + ArrayLength + " items");
			Console.WriteLine();
			Console.WriteLine("Insertion Sort Duration: " + insertionDuration + " ms");
			Console.WriteLine("Merge Sort Duration: " + mergeDuration + " ms");
			Console.WriteLine("Selection Sort Duration: " + selectionDuration + " ms");
			Console.WriteLine("Bubble Sort Duration: " + bubbleDuration + " ms");

			Console.ReadLine();
		}

		static int[] GenereateArray(int length)
		{
			var output = new int[length];
			for (int i = 0; i < length; i++)
			{
				output[i] = Random.Next(10000);
			}

			return output;
		}
	}
}
