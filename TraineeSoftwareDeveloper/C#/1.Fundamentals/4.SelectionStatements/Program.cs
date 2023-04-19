// SELECTION STATEMENTS
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#case-guards
//The if, else and switch statements select statements to execute from many possible paths
//based on the value of an expression.
int x = 50;

// 1. If Statement without Else
// An if statement without an else part executes its body only if a Boolean expression evaluates to true
if (x % 2 == 0)
{
    Console.WriteLine($"{x} is an even number");
}

// 2. If Statement with Else
// An if statement with an else part selects one of the two statements to execute based on the value of a Boolean expression
if (x % 2 == 0)
{
    Console.WriteLine($"{x} is an even number");
}
else
{
    Console.WriteLine($"{x} is an odd number");
}

// 3. Nested If/Else
//  Nest if statements to check multiple conditions
if (x == 0)
{
    Console.WriteLine($"{x} is a zero");
}
else if (x % 2 == 0)
{
    Console.WriteLine($"{x} is an even number");
}
else
{
    Console.WriteLine($"{x} is an odd number");
}

// 4. Ternaty Conditional Operator
// condition ? consequent : alternative
int y = (int)((x % 2 == 0) ? Math.Sqrt(x) : x);
Console.WriteLine(y);

// 5. Switch
switch (x)
{
    case > 0:
        Console.WriteLine("Positive Number"); break;
    case < 0:
        Console.WriteLine("Negative Number"); break;
    default:
        Console.WriteLine("Zero"); break;
}
// You can specify multiple case patterns for one section of a switch statement
switch (x)
{
    case < 0:
    case > 0:
        Console.WriteLine("Non-Zero");
        break;
    default:
        Console.WriteLine("Zero");
        break;
}

/* The default case can appear in any place within a switch statement. 
 * Regardless of its position, the default case is always evaluated last and only if all other case patterns aren't matched, 
 * except if goto default is encountered.

 * Switch statement uses the following patterns:
 * A relational pattern (available in C# 9.0 and later): to compare an expression result with a constant.
 * A constant pattern: test if an expression result equals a constant.
*/

// Case Guards: 
// A case pattern may be not expressive enough to specify the condition for the execution of the switch section.
// In such a case, you can use a case guard.
// That is an additional condition that must be satisfied together with a matched pattern.
// A case guard must be a Boolean expression.
// You specify a case guard after the 'when' keyword that follows a pattern
int a = 18, b = 81;
switch (a, b)
{
    case ( > 0, > 0) when a == b:
        Console.WriteLine($"Both numbers are valid and same: {a}");
        break;

    case ( > 0, > 0):
        Console.WriteLine($"Number 1: {a} \nNumber 2: {b}");
        break;

    default:
        Console.WriteLine("Invalid number(s)");
        break;
}