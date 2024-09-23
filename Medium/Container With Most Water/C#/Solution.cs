namespace Container_With_Most_Water;

public class Solution {
	public int MaxArea(int[] height) {
		int n = height.Length - 1,
		right = n, 
		left = 0;

		for (int r = 0, l = n; r <= n; r++, l--) {
			int h = height[r],
			areaRight = right * height[right],
			areaLeft = (n - left) * height[left];

			left = l * h > areaLeft ? r : left;
			right = r * h >= areaRight ? r : right;
		}

		Console.WriteLine($"{left}, {right}");
		Console.WriteLine($"{Math.Min(height[left], height[right])}");

		return GetArea(height, left, right);
	}
	private int GetArea(int[] height, int left, int right) {
		return (right - left) * Math.Min(height[left], height[right]);
	}
}
