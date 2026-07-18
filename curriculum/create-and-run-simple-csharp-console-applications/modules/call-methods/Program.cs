// Module: Call Methods from the .NET Class Library Using C#
// Demonstrates static methods, instance methods, return values, parameters,
// arguments, method overloads, and the Math.Max() challenge.
//
// Long-form explanations are kept in the section README so that Program.cs
// remains focused on executable C# examples.

Console.WriteLine("=== Static and instance methods ===");

// Console.WriteLine() is a static method. It is called directly from the
// Console class and does not require a Console object.
Console.WriteLine("Creating a Random object and rolling a six-sided die...");

// Random.Next() is an instance method, so an object must be created first.
// Target-typed new() avoids repeating the type name on the right-hand side.
Random dice = new();

// Next(1, 7) accepts two arguments:
// - 1 is the inclusive minimum.
// - 7 is the exclusive maximum.
// Therefore, the returned value is an integer from 1 through 6.
int dieRoll = dice.Next(1, 7);

// Next() returns an int. The returned value is stored in dieRoll and is then
// passed as an argument to Console.WriteLine().
Console.WriteLine($"A six-sided die roll: {dieRoll}");

Console.WriteLine();
Console.WriteLine("=== Method overloads ===");

// Random.Next() is overloaded. The same method name supports multiple valid
// signatures with different parameter lists.
int anyNonNegativeInteger = dice.Next();
int belowOneHundredOne = dice.Next(101);
int betweenFiftyAndOneHundred = dice.Next(50, 101);

Console.WriteLine($"Next(): {anyNonNegativeInteger}");
Console.WriteLine($"Next(101): {belowOneHundredOne}");
Console.WriteLine($"Next(50, 101): {betweenFiftyAndOneHundred}");

Console.WriteLine();
Console.WriteLine("=== Directly use a return value ===");

// A return value can be passed directly to another method without first being
// assigned to a variable.
Console.WriteLine($"Another six-sided die roll: {dice.Next(1, 7)}");

Console.WriteLine();
Console.WriteLine("=== Math.Max challenge ===");

int firstValue = 500;
int secondValue = 600;

// Math.Max() is a static method. It returns the larger of its two arguments.
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(
    $"The larger value between {firstValue} and {secondValue} is {largerValue}.");