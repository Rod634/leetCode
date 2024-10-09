namespace leetCode.TwoSum
{
    public class TwoSum
    {
        public int[] Sum(int[] nums, int target)
        {
            int[] output = new int[2];
            //Dictionary of numbers that already passed through the loop
            var alreadySeen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //Subtraction of the number with the target to find the difference value
                int diff = target - nums[i];
                //Check if we already seen the diff value
                if (alreadySeen.ContainsKey(diff))
                {
                    output = [alreadySeen.GetValueOrDefault(diff), i];
                    break;
                }
                else
                {
                    //Add the number in alreadySeen Dictionary with their index
                    alreadySeen.TryAdd(nums[i], i);
                }
            }
            return output;
        }
    }
}