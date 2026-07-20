// Module: Store and Iterate Through Sequences of Data Using Arrays
// and the foreach Statement in C#
//
// This program consolidates the completed Microsoft Learn exercises into three
// focused demonstrations:
//
// 1. Declaring, initializing, reading, updating, and measuring an array.
// 2. Iterating through an integer array with foreach while calculating a
//    running total.
// 3. Combining foreach with an if statement to identify order IDs that require
//    further investigation.
//
// Detailed lesson notes belong in the Section 2 README. Program.cs remains
// focused on clear, executable C# examples.

Console.WriteLine("=== Array basics ===");

// An array stores multiple values of the same data type under one variable name.
//
// The [] after string tells the compiler that fraudulentOrderIds is an array.
// The collection expression [ ... ] creates and initializes the array in one
// statement. This syntax is supported by modern C# versions used by .NET 10.
string[] fraudulentOrderIds = ["A123", "B456", "C789"];

// Array indexes are zero-based:
// - index 0 refers to the first element;
// - index 1 refers to the second element;
// - index 2 refers to the third element.
Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

// Array elements behave like individual variables. Their values can be read,
// assigned, and reassigned as long as the new value matches the array's type.
fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassigned first: {fraudulentOrderIds[0]}");

// Length returns the number of elements in the array.
// Unlike an array index, Length is not zero-based.
Console.WriteLine(
    $"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

Console.WriteLine();
Console.WriteLine("=== Inventory report with foreach ===");

// Each value represents the number of finished products stored in one bin.
int[] inventory = [200, 450, 700, 175, 250];

// sum is declared outside the loop because its value must be preserved between
// iterations and used again after the loop finishes.
int sum = 0;

// bin records the human-readable bin number. It starts at zero and is
// incremented before each report so that the first displayed bin is Bin 1.
int bin = 0;

// foreach processes every element in increasing index order.
//
// During each iteration, the current array element is copied into the temporary
// variable items. The loop body then uses that value to update the running
// total and produce an audit line for the current bin.
foreach (int items in inventory)
{
    sum += items;
    bin++;

    Console.WriteLine(
        $"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

Console.WriteLine();
Console.WriteLine("=== Orders requiring investigation ===");

// These order IDs represent the data supplied by the fraud-analysis team.
string[] orderIds =
[
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
];

// Combine iteration and selection:
// - foreach examines every order ID;
// - if selects only the IDs that start with the letter B;
// - StartsWith() returns a Boolean value: true or false.
foreach (string orderId in orderIds)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine(orderId);
    }
}