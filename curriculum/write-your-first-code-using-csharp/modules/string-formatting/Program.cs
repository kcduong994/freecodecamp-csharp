// Program.cs
// Module: Perform Basic String Formatting in C#
//
// Purpose:
// Demonstrate string formatting with escape sequences, verbatim strings,
// Unicode escape sequences, concatenation, and interpolation.
//
// Learning points:
// - Escape sequences insert special characters such as new lines and tabs.
// - Verbatim strings preserve backslashes and whitespace.
// - Unicode escape sequences represent UTF-16 characters.
// - Concatenation combines strings with the + operator.
// - Interpolation inserts expressions into a string template.

// -----------------------------------------------------------------------------
// Character escape sequences
// -----------------------------------------------------------------------------

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

// Intentional compiler error from the lesson:
//
// Console.WriteLine("Hello "World"!");
//
// Typical diagnostics:
// CS1003: Syntax error, ',' expected.
// CS0103: The name 'World' does not exist in the current context.
//
// The inner quotation marks terminate the string too early.
// Escape them with \" when they are part of the output.

// Intentional compiler error from the lesson:
//
// Console.WriteLine("c:\source\repos");
//
// CS1009: Unrecognized escape sequence.
//
// A normal string interprets backslashes as escape-sequence prefixes.
// Use \\ or a verbatim string literal for Windows paths.

// -----------------------------------------------------------------------------
// Formatting output with escape sequences
// -----------------------------------------------------------------------------

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

// -----------------------------------------------------------------------------
// Verbatim string literals
// -----------------------------------------------------------------------------

Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");

Console.WriteLine(@"c:\invoices");

// -----------------------------------------------------------------------------
// Unicode escape sequences
// -----------------------------------------------------------------------------

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Japanese text: 日本の請求書を生成するには：
Console.Write(
    "\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

Console.WriteLine(@"c:\invoices\app.exe -j");

// -----------------------------------------------------------------------------
// String concatenation
// -----------------------------------------------------------------------------

string concatenationFirstName = "Bob";
string greeting = "Hello";

Console.WriteLine(greeting + " " + concatenationFirstName + "!");

string concatenatedMessage = "Hello " + concatenationFirstName;
Console.WriteLine(concatenatedMessage);

// -----------------------------------------------------------------------------
// String interpolation
// -----------------------------------------------------------------------------

string interpolationFirstName = "Bob";

Console.WriteLine($"Hello {interpolationFirstName}!");

int version = 11;
string updateText = "Update to Windows";

Console.WriteLine($"{updateText} {version}!");

string sampleProjectName = "First-Project";

Console.WriteLine($@"C:\Output\{sampleProjectName}\Data");

// -----------------------------------------------------------------------------
// Challenge: Format and display instructions
// -----------------------------------------------------------------------------

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

string russianMessage =
    "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c " +
    "\u0440\u0443\u0441\u0441\u043a\u0438\u0439 " +
    "\u0432\u044b\u0432\u043e\u0434";

string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

// The challenge permits only two output instructions.
// New lines and tabs are embedded in the formatted strings.
Console.WriteLine($"View English output:\n\t{englishLocation}\n");
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}");

// Expected challenge output:
//
// View English output:
//     c:\Exercise\ACME\data.txt
//
// Посмотреть русский вывод:
//     c:\Exercise\ACME\ru-RU\data.txt