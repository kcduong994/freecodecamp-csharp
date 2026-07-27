/*
 * Module:
 * Iterate Through a Code Block Using the for Statement in C#
 *
 * Learning objectives:
 * - Use a for statement to repeat a code block a known number of times.
 * - Configure the initializer, condition, and iterator expressions.
 * - Count upward, count downward, and change the iteration step.
 * - Stop a loop early with the break keyword.
 * - Traverse an array by index in either direction.
 * - Modify array elements by using their indexes.
 * - Combine for and if statements to solve the FizzBuzz challenge.
 */

Console.WriteLine("ITERATE THROUGH A CODE BLOCK USING THE FOR STATEMENT");
Console.WriteLine("====================================================");
Console.WriteLine();

RunBasicForLoop();
RunCountdownLoop();
RunCustomStepLoop();
RunBreakExample();
RunReverseArrayExample();
RunArrayUpdateExample();
RunFizzBuzzChallenge();


/// <summary>
/// Demonstrates the basic structure of a for statement.
/// </summary>
static void RunBasicForLoop()
{
    WriteSectionHeader("Example 1: Basic for loop");

    /*
     * A for statement contains three control expressions:
     *
     * 1. Initializer: int index = 0
     *    Runs once before the first iteration.
     *
     * 2. Condition: index < 10
     *    Checked before each iteration.
     *    The loop continues while this expression is true.
     *
     * 3. Iterator: index++
     *    Runs after each completed iteration.
     *
     * The code inside the braces is the loop body.
     */
    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine(index);
    }

    Console.WriteLine();
}


/// <summary>
/// Demonstrates how to configure a for statement to count downward.
/// </summary>
static void RunCountdownLoop()
{
    WriteSectionHeader("Example 2: Count downward");

    /*
     * The loop starts at 10.
     * It continues while counter is greater than or equal to 0.
     * counter-- subtracts 1 after each iteration.
     */
    for (int counter = 10; counter >= 0; counter--)
    {
        Console.WriteLine(counter);
    }

    Console.WriteLine();
}


/// <summary>
/// Demonstrates how the iterator expression can change by more than one.
/// </summary>
static void RunCustomStepLoop()
{
    WriteSectionHeader("Example 3: Change the iteration step");

    /*
     * counter += 3 increases the iterator by 3 after each iteration.
     *
     * Values produced:
     * 0, 3, 6, 9
     */
    for (int counter = 0; counter < 10; counter += 3)
    {
        Console.WriteLine(counter);
    }

    Console.WriteLine();
}


/// <summary>
/// Demonstrates how break exits a for statement before its normal condition
/// becomes false.
/// </summary>
static void RunBreakExample()
{
    WriteSectionHeader("Example 4: Stop a loop with break");

    for (int counter = 0; counter < 10; counter++)
    {
        Console.WriteLine(counter);

        // Stop the loop immediately after printing 7.
        if (counter == 7)
        {
            break;
        }
    }

    Console.WriteLine();
}


/// <summary>
/// Demonstrates how to traverse an array from the last element to the first.
/// </summary>
static void RunReverseArrayExample()
{
    WriteSectionHeader("Example 5: Traverse an array in reverse");

    string[] names = { "Alex", "Eddie", "David", "Michael" };

    /*
     * Array indexes are zero-based.
     *
     * For an array containing four elements:
     * - Length is 4.
     * - The last valid index is 3.
     *
     * Therefore, the loop starts at names.Length - 1.
     */
    for (int index = names.Length - 1; index >= 0; index--)
    {
        Console.WriteLine(names[index]);
    }

    Console.WriteLine();
}


/// <summary>
/// Demonstrates how a for statement can modify array elements by index.
/// </summary>
static void RunArrayUpdateExample()
{
    WriteSectionHeader("Example 6: Modify an array element");

    string[] names = { "Alex", "Eddie", "David", "Michael" };

    /*
     * A foreach iteration variable cannot be reassigned.
     *
     * The following code is intentionally invalid and is preserved only
     * as a learning reference:
     *
     * foreach (string name in names)
     * {
     *     if (name == "David")
     *     {
     *         name = "Sammy";
     *     }
     * }
     *
     * The compiler rejects the assignment because name is a foreach
     * iteration variable.
     *
     * A for statement solves this problem because it gives access to the
     * array index. The program can therefore assign a new value directly
     * to names[index].
     */
    for (int index = 0; index < names.Length; index++)
    {
        if (names[index] == "David")
        {
            names[index] = "Sammy";
        }
    }

    // foreach remains useful for reading and displaying all array values.
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }

    Console.WriteLine();
}


/// <summary>
/// Completes the module challenge by combining a for statement, conditional
/// statements, the remainder operator, and the logical AND operator.
/// </summary>
static void RunFizzBuzzChallenge()
{
    WriteSectionHeader("Challenge: FizzBuzz from 1 to 100");

    /*
     * Rules:
     * - Print every number from 1 through 100.
     * - A number divisible by 3 receives "Fizz".
     * - A number divisible by 5 receives "Buzz".
     * - A number divisible by both 3 and 5 receives "FizzBuzz".
     *
     * The remainder operator (%) returns the remainder after division.
     * A remainder of 0 means that the number is evenly divisible.
     *
     * The combined condition must be checked first.
     * For example, 15 is divisible by both 3 and 5. If the divisible-by-3
     * condition were checked first, the program would print only "Fizz"
     * and never reach the "FizzBuzz" branch.
     */
    for (int number = 1; number <= 100; number++)
    {
        if ((number % 3 == 0) && (number % 5 == 0))
        {
            Console.WriteLine($"{number} - FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine($"{number} - Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine($"{number} - Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}


/// <summary>
/// Writes a consistent heading before each independent example.
/// </summary>
/// <param name="title">The heading displayed in the console.</param>
static void WriteSectionHeader(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
}