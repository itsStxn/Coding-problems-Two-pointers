namespace Container_With_Most_Water;

public class Solution {
	public int MaxArea(int[] height) {
		int n = height.Length,
		r = n - 1,
		l = 0,

		area = 0;
		while (l < r) {
			int w = r - l,
			h = Math.Min(height[l], height[r]); 
			area = Math.Max(area, h * w);

			if (height[l] < height[r]) {
				l++;
			} else if (height[l] == height[r]) {
				l++;
				r--;
			} else r--;
		}

		return area;
	}
}
