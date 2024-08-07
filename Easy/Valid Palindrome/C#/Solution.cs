namespace Valid_Palindrome;

public class Solution {
	public bool IsPalindrome(string s) {
		if (s.Length < 2) return true;

		int left = 0, right = s.Length - 1;
		while (left <= right) {
			while (!isAlphaNum(s[left])) {
				if (++left > right) return true;
			}
			while (!isAlphaNum(s[right])) {
				if (--right < left) return true;
			}

			if (!Same(s[left++], s[right--])) {
				return false;
			}
		}

		return true;	
	}
	private bool Same(char c1, char c2) {
		return char.ToLower(c1) == char.ToLower(c2);
	}
	private bool isAlphaNum(char c) {
		c = char.ToLower(c);
		return (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
	}
}
