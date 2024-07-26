using _3Sum;

var task = new Solution();
var result = task.ThreeSum([-1, 0, 1, 2, -1, -4]);

string output = string.Empty;
foreach (var list in result) {
	output += $"[{string.Join(", ", list)}]\n";
}
Console.WriteLine(output);
