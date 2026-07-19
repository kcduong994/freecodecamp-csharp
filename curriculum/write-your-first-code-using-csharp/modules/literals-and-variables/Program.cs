// Program.cs
// Module: Store and Retrieve Data Using Literal and Variable Values in C#
//
// Purpose:
// Demonstrate C# literal values, data types, variable declaration,
// assignment, initialization, reassignment, and implicit typing.
//
// Learning points:
// - Character literals use single quotation marks.
// - String literals use double quotation marks.
// - Numeric literal suffixes identify specific numeric types.
// - Variables must be declared before use.
// - Variables must be assigned before their values can be retrieved.
// - Assignment operates from right to left.
// - The var keyword allows the compiler to infer a variable's type.
// - Once inferred, a var variable remains strongly typed.

// -----------------------------------------------------------------------------
// Character and string literals
// -----------------------------------------------------------------------------

// A character literal contains exactly one character and uses single quotes.
Console.WriteLine('b');

// A string literal can contain multiple characters and uses double quotes.
Console.WriteLine("Hello World!");

// Intentional compiler error from the lesson:
//
// Console.WriteLine('Hello World!');
//
// CS1012: Too many characters in character literal.
//
// Single quotation marks define a char literal, so the compiler expects
// exactly one character. Use double quotation marks for a string instead.

// -----------------------------------------------------------------------------
// Numeric literals
// -----------------------------------------------------------------------------

// Numeric types provide different ranges and levels of precision:
//
// float   : approximately 6 to 9 digits of precision
// double  : approximately 15 to 17 digits of precision
// decimal : approximately 28 to 29 digits of precision

// The F suffix tells the compiler that this literal is a float.
Console.WriteLine(0.25F);

// A decimal number without a suffix is treated as a double by default.
Console.WriteLine(2.625);

// The M suffix tells the compiler that this literal is a decimal.
Console.WriteLine(12.39816m);

// -----------------------------------------------------------------------------
// Boolean literals
// -----------------------------------------------------------------------------

// Boolean literals represent the logical values true and false.
Console.WriteLine(true);
Console.WriteLine(false);

// Boolean values are commonly used in conditional logic and expressions.

// -----------------------------------------------------------------------------
// Data types define how values behave
// -----------------------------------------------------------------------------

// These two values produce similar visible output, but they have different types.
Console.WriteLine("123"); // string
Console.WriteLine(123);   // int

// These values also appear similar, but one is text and the other is Boolean.
Console.WriteLine("true"); // string
Console.WriteLine(true);   // bool

// Common data types introduced in this module:
//
// string  - text or alphanumeric data intended for presentation
// char    - a single character
// int     - a whole number
// decimal - a number with a fractional component and high precision
// bool    - a true or false value

// -----------------------------------------------------------------------------
// Variable declaration
// -----------------------------------------------------------------------------

// A variable is a named storage location for a value of a specific type.
//
// Variable names should:
// - contain letters, numbers, or underscores;
// - begin with a letter or underscore;
// - not contain spaces or unsupported special characters;
// - not use reserved C# keywords;
// - use camelCase for local variables;
// - describe the meaning of the stored value;
// - avoid unnecessary abbreviations or type prefixes.

string customerFirstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

// The variables above are declared but not yet assigned.
// They cannot be read until they receive values.

// -----------------------------------------------------------------------------
// Assignment and retrieval
// -----------------------------------------------------------------------------

customerFirstName = "Bob";
userOption = 'A';
gameScore = 100;
particlesPerMillion = 0.625m;
processedCustomer = true;

// Assignment stores a compatible value on the right in the variable on the left.
// Retrieving every assigned value below keeps each declaration executable and
// prevents CS0168 warnings for variables that are declared but never used.
Console.WriteLine($"Customer first name: {customerFirstName}");
Console.WriteLine($"Selected option: {userOption}");
Console.WriteLine($"Game score: {gameScore}");
Console.WriteLine($"Particles per million: {particlesPerMillion}");
Console.WriteLine($"Customer processed: {processedCustomer}");

// Intentional compiler error from the lesson:
//
// "Bob" = customerFirstName;
//
// CS0131: The left-hand side of an assignment must be a variable,
// property, or indexer.
//
// A literal cannot appear on the left side of the assignment operator.

// Intentional compiler error from the lesson:
//
// int invalidFirstName;
// invalidFirstName = "Bob";
//
// CS0029: Cannot implicitly convert type 'string' to 'int'.
//
// The assigned value must be compatible with the variable's declared type.

// -----------------------------------------------------------------------------
// Reassignment
// -----------------------------------------------------------------------------

string currentFirstName = "Bob";

Console.WriteLine(currentFirstName);

currentFirstName = "Liem";
Console.WriteLine(currentFirstName);

currentFirstName = "Isabella";
Console.WriteLine(currentFirstName);

currentFirstName = "Yasmin";
Console.WriteLine(currentFirstName);

// Reassignment replaces the value currently stored in the variable.

// -----------------------------------------------------------------------------
// Initialization
// -----------------------------------------------------------------------------

// Intentional compiler error from the lesson:
//
// string unassignedFirstName;
// Console.WriteLine(unassignedFirstName);
//
// CS0165: Use of unassigned local variable 'unassignedFirstName'.
//
// A local variable must be assigned before its value can be retrieved.

// Declaration and assignment can be combined in one statement.
// This is called initialization.
string initializedFirstName = "Bob";

Console.WriteLine(initializedFirstName);

// Summary:
// - Declaration creates a variable with a name and data type.
// - Assignment stores a value in the variable.
// - Initialization declares the variable and assigns its first value.
// - Reassignment replaces the currently stored value.
// - Assignment proceeds from right to left.

// -----------------------------------------------------------------------------
// Implicitly typed local variables
// -----------------------------------------------------------------------------

// The var keyword tells the compiler to infer the type from the assigned value.
var greetingMessage = "Hello World!";

Console.WriteLine(greetingMessage);

// Although var is used, greetingMessage is still strongly typed as string.

// Intentional compiler error from the lesson:
//
// greetingMessage = 10.703m;
//
// CS0029: Cannot implicitly convert type 'decimal' to 'string'.
//
// The compiler inferred string when greetingMessage was initialized.
// Its type cannot later change to decimal.

// Intentional compiler error from the lesson:
//
// var uninitializedMessage;
//
// CS0818: Implicitly typed variables must be initialized.
//
// The compiler requires an initial value so it can infer the variable's type.

// The var keyword is useful when the type is obvious or lengthy.
// Explicit types are often preferable when they improve readability.

// -----------------------------------------------------------------------------
// Challenge: Display literal and variable values
// -----------------------------------------------------------------------------

string name = "Bob";
int messageCount = 3;
decimal temperatureCelsius = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messageCount);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperatureCelsius);
Console.WriteLine(" celsius.");