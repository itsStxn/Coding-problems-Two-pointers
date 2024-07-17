# Palindrome Number

## Description
Given an integer x, return `true` if x is a <a href="https://en.wikipedia.org/wiki/Palindrome">palindrome</a>, and `false` otherwise.

### Example 1:
***Input:*** `x` = 121  
***Output:*** `true`  
***Explanation:*** 
- 121 reads as 121 from left to right and from right to left.

### Example 2:
***Input:*** `x` = -121  
***Output:*** `false`  
***Explanation:*** 
- From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

### Example 3:
***Input:*** `x` = 10  
***Output:*** `false`  
***Explanation:*** 
- Reads 01 from right to left. Therefore *it is not a palindrome*.

### Constraints:
- -231 <= `x` <= 231 - 1

**Follow up:** Could you solve it without converting the integer to a string?

## Strategy
### Pointers
Turn input into a string and check if each character from the left mirrors the ones on the right.

### Math
Carry out the reverse of the input by multiplying it by 10 and adding the remainder. Then:  
***For inputs with odd n digits***
- The input must be equal to the reverse.

***For inputs with even n digits***
- The input must be equal to the reverse/10.

## Time Complexity - O(n)
Both strategies have the input on a linear relation with the runtime. The 2 pointers approach uses an iteration of max n/2 times, which is still linear time. 

## Space Complexity
### Pointers - O(n)
The input is stored in memory as a string. The size of the string depends on the number of digits in the input.

### Math - O(1)
The variable `reverse` is used to store the reverse of the input. It grows in value at each iteration, but numbers in modern systems always hold either 32 or 64 bits. Thus, no extra space is needed.
