using System;

namespace namespaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 3, 4, 5 };

			task1.Class obj = new task1.Class();
			task2.Class obj2 = new task2.Class();

            Console.WriteLine("task1: ");
            Console.WriteLine("ilk ve sonuncu indeks: " + obj.FindFirstAndLast(nums, 3));

			
			foreach (int num in nums)
			{
				Console.Write(num + " ");
			}

            obj2.computePower(nums);
			Console.WriteLine();

		}
	}
}
