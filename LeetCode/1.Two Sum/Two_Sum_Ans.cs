//two solution
public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {                   
        return TwoSum_BruteForce(nums,target);
    }   
    //1. Brute force
    private int[] TwoSum_BruteForce(int[] nums, int target)
    {
        for(int i = 0;i<nums.Length;++i)
        {
            for(int j =i+1;j < nums.Length;++j)
            {
                int result = nums[i] + nums[j];

                if(result == target)
                return new int[2]{i,j};                
            }
        }

        return null;
    }


    //2. Hashtable
    private int[] TwoSum_BruteForce(int[] nums, int target)
    {
        Dictionary<int, int> valToIndex = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++) {
                if (valToIndex.ContainsKey(target - nums[i])) {
                    return new int[] { valToIndex[target - nums[i]], i };
                }
                valToIndex[nums[i]] = i;
            }
            return new int[] { -1, -1 };
    }
}