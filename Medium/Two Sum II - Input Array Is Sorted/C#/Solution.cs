namespace Two_Sum_II___Input_Array_Is_Sorted;

public class Solution {
	public int[] TwoSum(int[] numbers, int target) {
		int left = 0, right = numbers.Length - 1;

		while (true) {
			int sum = numbers[left] + numbers[right];

			if (target > sum) left++;
			else if (target < sum) right--;
			else return [left + 1, right + 1];
		}
	}
}
