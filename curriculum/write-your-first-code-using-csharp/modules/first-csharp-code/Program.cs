// Program.cs
// Module: Write Your First C# Code
//
// Purpose:
// Demonstrate the difference between Console.WriteLine() and Console.Write()
// in a simple C# console application.
//
// Learning points:
// - Console.WriteLine() prints text and then moves the cursor to a new line.
// - Console.Write() prints text without automatically starting a new line.
// - Text enclosed in double quotation marks is a string literal.
// - Each C# statement ends with a semicolon.
//
// Console belongs to the System namespace.
// Modern .NET console project templates enable implicit global usings,
// so an explicit "using System;" directive is not required here.

// Print the first sentence and move the cursor to the next line.
Console.WriteLine("This is the first line.");

// Print the second sentence in three separate parts.
//
// Console.Write() keeps the cursor on the same line after each call.
// The spaces at the ends of the first two string literals prevent the
// words from being joined together.
Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");