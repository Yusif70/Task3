using System;

namespace task1
{
	internal class Class
	{
		public string FindFirstAndLast(int[] nums, int target)
		{
			int start = -1;
			int end = -1;
			for(int i = 0; i <nums.Length; i++)
			{
				if (nums[i] == target)
				{
					start = i;
					break;
				}
			}
			for(int i = nums.Length - 1; i >= 0; i--)
			{
				if (nums[i] == target)
				{
					end = i;
					break;
				}
			}

            return start + "," + end;
        }
	}
}

namespace task2 {
	class Class
	{
		public void computePower(int[] nums)
		{
            Console.WriteLine("\n val^val: ");
            foreach (int num in nums)
			{
				int newNum = 1;
				for(int i = 0; i< num; i++)
				{
					newNum *= num;
				}
                Console.Write(newNum + " ");
            }
			
			Console.WriteLine("\n val^2: ");
			foreach (int num in nums)
			{
				Console.Write(num*num + " ");
			}

            Console.WriteLine("\n 2^val: ");
            foreach (int num in nums)
			{
				int newNum = 1;
				for (int i = 0; i < num; i++)
				{
					newNum *= 2;
				}
				Console.Write(newNum + " ");
			}
        }
	}

}

