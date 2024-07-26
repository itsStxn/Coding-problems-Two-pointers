namespace _3Sum;

public class Solution {
	public IList<IList<int>> ThreeSum(int[] nums) {
		Array.Sort(nums);
		
		IList<IList<int>> result = [];
		HashSet<string> seen = [];
		
		for (int i = 0; i < nums.Length - 2; i++) {
			if (i > 0 && nums[i] == nums[i - 1]) continue;
			TwoSum(nums, i, seen, result);
		}

		return result;
	}
	public void TwoSum(int[] nums, int targetIndex, HashSet<string> seen, IList<IList<int>> result) {
		int target = -nums[targetIndex],
		right = nums.Length - 1,
		left = targetIndex + 1;

		while (left < right) {
			int sum = nums[left] + nums[right];

			if (target > sum)
				left++;
			else if (target < sum)
				right--;
			else {
				List<int> triplet = [nums[targetIndex], nums[left++], nums[right--]];
				if (seen.Add(string.Join(",", triplet))) {
					result.Add(triplet);
				}

				while (left < right && nums[left] == nums[left - 1]) left++;
				while (left < right && nums[right] == nums[right + 1]) right--;
			}
		}
	}
}
