namespace Algoritms
{
    public static class BinarySearch
    {
        public static int GetNumber(int[] nums, int target)
        {
            nums = nums.OrderBy(x => x).ToArray();
            int leftPointer = 0;
            int rightPointer = nums.Length - 1;
            while (leftPointer <= rightPointer)
            {
                int midPointer = (leftPointer + rightPointer) / 2;
                
                if (nums[midPointer] > target)
                {
                    rightPointer= midPointer-1;
                    continue;
                }
                if (nums[midPointer] < target)
                {
                    leftPointer = midPointer + 1;
                    continue;
                }
                return midPointer;

            }
            return -1;
        }
    }
}
