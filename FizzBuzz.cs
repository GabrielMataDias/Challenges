// Given an integer n, return a string array answer (1-indexed) where:

// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
// answer[i] == "Fizz" if i is divisible by 3.
// answer[i] == "Buzz" if i is divisible by 5.
// answer[i] == i (as a string) if none of the above conditions are true.

// Constraints:

// 1 <= n <= 104

public IList<string> FizzBuzz(int n)
{
    var result = new List<string>();

    var values = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
            };

    for (int i = 0; i < n; i++)
    {
        var stringBuilder = new StringBuilder();

        var j = i + 1;

        foreach (var key in values.Keys)
        {
            if (j % key == 0)
            {
                stringBuilder.Append(values[key]);
            }
        }

        var tempValue = stringBuilder.Length > 0 ? stringBuilder.ToString() : j.ToString();

        result.Add(tempValue);
    }

    return result;
}