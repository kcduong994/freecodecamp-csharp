/*
 * Control Variable Scope and Logic Using Code Blocks in C#
 *
 * Learning objectives:
 * - Understand how curly braces define code blocks.
 * - Understand how code blocks affect variable scope.
 * - Declare variables in the correct scope.
 * - Initialize variables before accessing them.
 * - Use braces consistently in if-else statements.
 * - Improve the readability of conditional logic.
 * - Complete a challenge involving variable scope.
 */

/*
 * A code block contains one or more C# statements.
 *
 * Code blocks are normally defined by curly braces:
 *
 * {
 *     // Statements inside the code block.
 * }
 *
 * A code block creates a boundary that can affect:
 *
 * - which statements belong to a conditional structure;
 * - when those statements execute;
 * - which variables can be accessed;
 * - how long local variables remain available.
 */

// ------------------------------------------------------------
// Code blocks and local variable scope
// ------------------------------------------------------------

{
    bool flag = true;

    if (flag)
    {
        /*
         * localValue is declared inside the if-statement block.
         *
         * Therefore, localValue can only be accessed from inside
         * this pair of curly braces.
         */
        int localValue = 10;

        Console.WriteLine(
            $"Inside the code block: {localValue}");
    }

    /*
     * The following statement would cause a compiler error:
     *
     * Console.WriteLine(localValue);
     *
     * Compiler error:
     *
     * CS0103:
     * The name 'localValue' does not exist in the current context.
     *
     * localValue is not visible here because it was declared
     * inside the preceding if-statement block.
     */
}

/*
 * Expected output:
 *
 * Inside the code block: 10
 */

// ------------------------------------------------------------
// Declare a variable outside a code block
// ------------------------------------------------------------

{
    bool flag = true;

    /*
     * value is declared outside the if-statement block.
     *
     * This means that value is visible both:
     *
     * - inside the if block;
     * - after the if block.
     *
     * The variable is also initialized immediately so that every
     * possible execution path has a valid value to access.
     */
    int value = 0;

    if (flag)
    {
        Console.WriteLine(
            $"Inside the code block: {value}");
    }

    /*
     * The variable remains accessible here because it was
     * declared in the surrounding block rather than inside
     * the if-statement block.
     */
    value = 10;

    Console.WriteLine(
        $"Outside the code block: {value}");
}

/*
 * Expected output:
 *
 * Inside the code block: 0
 * Outside the code block: 10
 */

// ------------------------------------------------------------
// Definite assignment
// ------------------------------------------------------------

/*
 * Declaring a variable does not automatically assign it a value.
 *
 * The following code would produce an error:
 *
 * bool flag = true;
 * int value;
 *
 * if (flag)
 * {
 *     Console.WriteLine(value);
 * }
 *
 * Compiler error:
 *
 * CS0165:
 * Use of unassigned local variable 'value'.
 *
 * C# requires a local variable to be definitely assigned before
 * the program attempts to read its value.
 *
 * Initializing the variable during declaration solves the issue:
 *
 * int value = 0;
 */

// ------------------------------------------------------------
// Use braces with a single-statement if block
// ------------------------------------------------------------

{
    bool flag = true;

    /*
     * The if-statement body contains only one statement.
     *
     * Curly braces are not technically required in this case,
     * but using them clearly marks the boundary of the block.
     */
    if (flag)
    {
        Console.WriteLine(flag);
    }
}

/*
 * Expected output:
 *
 * True
 */

// ------------------------------------------------------------
// Remove braces from a single-statement if block
// ------------------------------------------------------------

{
    bool flag = true;

    /*
     * When an if statement controls exactly one statement,
     * C# allows the braces to be omitted.
     *
     * The controlled statement should remain on a separate,
     * indented line so the relationship stays readable.
     */
    if (flag)
        Console.WriteLine(flag);
}

/*
 * Expected output:
 *
 * True
 */

/*
 * Although the following form is valid C#, it should be avoided:
 *
 * if (flag) Console.WriteLine(flag);
 *
 * Placing the condition and controlled statement on the same
 * line makes the code denser and more difficult to scan.
 */

// ------------------------------------------------------------
// Readable if-else if-else structure
// ------------------------------------------------------------

{
    string name = "steve";

    /*
     * A dense single-line version would be valid:
     *
     * if (name == "bob") Console.WriteLine("Found Bob");
     * else if (name == "steve") Console.WriteLine("Found Steve");
     * else Console.WriteLine("Found Chuck");
     *
     * However, placing each condition and statement on separate
     * lines makes the decision structure easier to understand.
     *
     * This repository version also retains braces consistently.
     */
    if (name == "bob")
    {
        Console.WriteLine("Found Bob");
    }
    else if (name == "steve")
    {
        Console.WriteLine("Found Steve");
    }
    else
    {
        Console.WriteLine("Found Chuck");
    }
}

/*
 * Expected output:
 *
 * Found Steve
 */

// ------------------------------------------------------------
// Variable scope challenge
// ------------------------------------------------------------

{
    /*
     * The array contains the values that the application
     * must inspect and add together.
     */
    int[] numbers = { 4, 8, 15, 16, 23, 42 };

    /*
     * total must be declared outside the foreach block because
     * its final value is needed after the loop has completed.
     */
    int total = 0;

    /*
     * found must also be declared outside the foreach block.
     *
     * The loop can change its value, and the if statement after
     * the loop must still be able to access that result.
     */
    bool found = false;

    foreach (int number in numbers)
    {
        /*
         * Add the current array value to the running total.
         */
        total += number;

        /*
         * When the target value is found, record that result.
         *
         * found remains true for the rest of the program once
         * the value 42 has been encountered.
         */
        if (number == 42)
        {
            found = true;
        }
    }

    /*
     * This statement is outside the foreach block but can access
     * found because found was declared in the surrounding block.
     */
    if (found)
    {
        Console.WriteLine("Set contains 42");
    }

    /*
     * total is also accessible here because it was declared
     * before the foreach block.
     */
    Console.WriteLine($"Total: {total}");
}

/*
 * Expected challenge output:
 *
 * Set contains 42
 * Total: 108
 */