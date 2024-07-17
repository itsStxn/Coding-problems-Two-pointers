namespace Palindrome_Number;


public class Solution {
    public bool IsPalindromeNum(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reverse = 0;
        while (x > reverse) {
            reverse = (reverse * 10) + x % 10;
            x/= 10;
        }

        return x == reverse || x == reverse / 10;
    }
    public bool IsPalindromeStr(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        string str = x.ToString();
        int R = str.Length - 1;
        int L = 0; 

        while (str[L] == str[R]) {
            if (L++ >= R--) return true;
        }

        return false;
    }
}
