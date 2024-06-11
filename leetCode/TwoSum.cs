public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] output = new int[2];
        var alreadySeen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (alreadySeen.ContainsKey(diff))
            {
                output = [alreadySeen.GetValueOrDefault(diff), i];
                break;
            }
            else 
            {
                alreadySeen.TryAdd(nums[i], i);
            }
        }
        return output;
    }
}
