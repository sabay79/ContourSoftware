// EXPRESSIONS //
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/expressions

// 1. Interpolated String Expression
// Provide convenient syntax to create formatted strings
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
var r = 2.3;
var message = $"Area of Circle with Radius {r} is {Math.PI * r * r:F2}";
Console.WriteLine(message);

// 2. Lambda Expression
// Allow you to create anonymous functions
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
int[] num = { 2, 4, 6, 7, 10 };
var maxSquare = num.Max(x => x * x);
Console.WriteLine("Square of Greatest Number is " + maxSquare);

// 3. Query Expression
// Allow you to use query capabilities directly in C#
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords
var scores = new[] { 10, 20, 50, 90, 70, 80 };
IEnumerable<int> highScoresQuery =
    from score in scores
    where score > 50
    orderby score descending
    select score;
Console.WriteLine("Highest Scores are" + string.Join(", ", highScoresQuery));