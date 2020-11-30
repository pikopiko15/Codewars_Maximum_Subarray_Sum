using System;


namespace Codewars_Maximum_Subarray_Sum
{
    public static class Kata
    {
        /// <summary>
        /// This method finds the maximum sum of a contiguous subsequence in an array or list of integers
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>it return the largest possible sum</returns>
        public static int MaxSequence(int[] arr)
        {
            if(arr.Length.Equals(0))
            {
                return 0;
            }

            int bestSum = 0;
            int currentSum = 0;

            foreach(var x in arr)
            {
                currentSum = Math.Max(0, currentSum + x);
                bestSum = Math.Max(bestSum, currentSum);
            }

            return bestSum;
        }
    }
}
