# Search Insert Position

## Description
Given a **sorted array** of **distinct integers** and a target value, return the `index` if the target is found.   
If not, return the `index` where *it would be if it were inserted in order*.
- You must write an algorithm with **O(log n)** runtime complexity.

### Example 1: 
***Input:*** `nums` = [1,3,5,6], `target` = 5  
***Output:*** 2

### Example 2:
***Input:*** `nums` = [1,3,5,6], `target` = 2  
***Output:*** 1

### Example 3:
***Input:*** `nums` = [1,3,5,6], `target` = 7  
***Output:*** 4

### Constraints:
- 1 <= `nums.length` <= 104  
- -104 <= `nums[i]` <= 104  
- `nums` contains distinct values sorted in ascending order.  
- -104 <= `target` <= 104

## Strategy
Use binary search:
- Use two pointers from right and left and compare the target to the middle.
- If the target is greater than the middle, it means that the target is not in the first half of the array. Same for the other case.
-  If the pointers meet, it means that the target is not in the array. 

The index shared by the pointers is the index where the target would be if it were inserted in order.

## Time Complexity - O(log n)
Each teration reduces the search space by half, by excluding the halves that don't contain the target.

## Space Complexity - O(1)
The variables have costant space complexity.
