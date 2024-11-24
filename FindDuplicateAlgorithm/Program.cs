using System;

namespace FindDuplicate
{
    class Program
    {
        // Function to find the duplicate number using Floyd's cycle detection
        public static int FindDuplicate(int[] nums)
        {
            // Phase 1: Finding the intersection point in the cycle
            int tortoise = nums[0];
            int hare = nums[0];

            // First, find the meeting point
            do
            {
                tortoise = nums[tortoise];   // Move tortoise by 1 step
                hare = nums[nums[hare]];     // Move hare by 2 steps
            }
            while (tortoise != hare);        // Continue until they meet

            // Phase 2: Find the entrance to the cycle (duplicate number)
            tortoise = nums[0];              // Move tortoise to the start
            while (tortoise != hare)
            {
                tortoise = nums[tortoise];   // Move tortoise by 1 step
                hare = nums[hare];           // Move hare by 1 step
            }

            // When tortoise and hare meet, we found the duplicate number
            return hare;
        }

        static void Main(string[] args)
        {
            // Example array with duplicate number
            int[] nums = { 3, 1, 3, 4, 2 };

            // Finding the duplicate number
            int duplicate = FindDuplicate(nums);

            // Output the result
            Console.WriteLine("The duplicate number is: " + duplicate);
        }
    }
}
