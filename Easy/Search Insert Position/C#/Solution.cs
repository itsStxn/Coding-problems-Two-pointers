namespace Search_Insert_Position;


public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int right = nums.Length - 1;    
        int left = 0;

        while (left <= right) {
            int mid = (left + right)/2;
            if (target > nums[mid]) left = mid + 1;
            else if (target < nums[mid]) right = mid - 1;
            else return mid;
        }
        
        return left; 
    }
}
