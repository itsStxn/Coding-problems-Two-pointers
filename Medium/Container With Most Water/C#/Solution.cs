namespace Container_With_Most_Water;

public class Solution {
	public int MaxArea(int[] height) {
		int n = height.Length,
		right = n - 1, 
		left = 0;

		for (int W = 0; W < n; W++) {
			int areaRight = right * height[right],
			areaLeft = (n - left) * height[left];

			left = GetArea(height, W, right) > areaLeft ? W : left;
			right = GetArea(height, left, W) >= areaRight ? W : right;
		Console.WriteLine($"{left}, {right}");
		}

		return GetArea(height, left, right);
	}
	private int GetArea(int[] height, int left, int right) {
		return (right - left) * Math.Min(height[left], height[right]);
	}
}
