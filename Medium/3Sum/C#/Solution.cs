namespace _3Sum;

public class Solution {
	public IList<IList<int>> ThreeSum(int[] nums) {
		Array.Sort(nums);
		
		IList<IList<int>> result = [];
		if (nums[0] > 0 || nums[^1] < 0) return result;
		
		for (int i = 0; i < nums.Length - 2; i++) {
			if (nums[i] > 0) return result;
			if (i == 0 && nums[i] != nums[i - 1]) {
				TwoSum(nums, i, result);
			}
		}

		return result;
	}
	private void TwoSum(int[] nums, int targetIndex, IList<IList<int>> result) {
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
				result.Add([
					nums[targetIndex],
					nums[left++],
					nums[right--]
				]);
				while (left < right && nums[left] == nums[left - 1]) left++;
				while (left < right && nums[right] == nums[right + 1]) right--;
			}
		}
	}
}
