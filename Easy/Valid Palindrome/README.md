# Valid Palindrome

## Description
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return `true` if it is a palindrome, or `false` otherwise.

### Example 1:
***Input:*** `s` = "A man, a plan, a canal: Panama"  
***Output:*** true  
***Explanation:*** "amanaplanacanalpanama" is a palindrome.

### Example 2:
***Input:*** `s` = "race a car"  
***Output:*** false  
***Explanation:*** "raceacar" is not a palindrome.

### Example 3:
***Input:*** `s` = " "  
***Output:*** true  
***Explanation:*** 
- s is an empty string "" after removing non-alphanumeric characters.
- Since an empty string reads the same forward and backward, it is a palindrome.

### Constraints:
- 1 <= `s.length` <= 2 * 105
- s consists only of printable ASCII characters.

## Strategy
Use two pointers to check if each alphanumeric character is the same. Skip non-alphanumeric characters using a while loop. 

If the skip brings pointers to clash, it means that the remaining string has no other alphanumeric characters. Hence, it is still a palindrome.

## Time Complexity - O(n)
The nested loops speed up the iteration, moving a pointer forward when it indexes to a non-alphanumeric character. Each index is processed a costant amount of times.

## Space Complexity - O(1)
Each variable has costant size.
