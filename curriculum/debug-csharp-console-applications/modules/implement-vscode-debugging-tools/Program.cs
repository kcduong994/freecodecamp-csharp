// ============================================================================
// Module: Implement the Visual Studio Code Debugging Tools for C#
// Learning Path: Debug C# Console Applications
//
// Purpose:
// - Review the Visual Studio Code debugger interface.
// - Practice standard and conditional breakpoints.
// - Practice Step Over, Step Into, Step Out, and Continue.
// - Inspect runtime state with VARIABLES and WATCH.
// - Follow method execution with CALL STACK.
// - Review launch.json / tasks.json concepts.
// - Demonstrate pass-by-value behavior discovered through debugging.
//
// Notes:
// - The examples are intentionally small and deterministic so they can be
//   debugged repeatedly with predictable results.
// - No infinite loop is used in this repository version.
// ============================================================================

Console.WriteLine("========================================================");
Console.WriteLine(" C# Visual Studio Code Debugging Tools Review");
Console.WriteLine("========================================================");
Console.WriteLine();

ReviewDebuggerInterface();
DemonstrateGreetingBugFix();
DemonstrateConditionalBreakpointScenario();
DemonstrateVariableStateAndZeroBasedIndexing();
DemonstrateWatchExpression();
DemonstrateCallStack();
DemonstratePassByValueChallenge();

Console.WriteLine();
Console.WriteLine("Debugger tools review completed.");


// ============================================================================
// 1. DEBUGGER INTERFACE
// ============================================================================

static void ReviewDebuggerInterface()
{
    Console.WriteLine("1. DEBUGGER INTERFACE");
    Console.WriteLine("---------------------");

    // The RUN AND DEBUG view exposes several important areas:
    //
    // VARIABLES
    //     Shows variables in the current scope.
    //
    // WATCH
    //     Tracks a variable or expression while execution progresses.
    //
    // CALL STACK
    //     Shows the chain of method calls that led to the current line.
    //
    // BREAKPOINTS
    //     Displays and manages configured breakpoints.
    //
    // DEBUG CONSOLE
    //     Displays debugger messages and application output when the
    //     internal console is used.
    //
    // Common execution controls:
    //
    // Continue
    //     Resume execution until another breakpoint or termination.
    //
    // Step Over
    //     Execute the current statement without entering a called method.
    //
    // Step Into
    //     Enter a called method and inspect its statements.
    //
    // Step Out
    //     Complete the current method and return to its caller.
    //
    // Restart
    //     Restart the current debugging session.
    //
    // Stop
    //     Terminate the debugging session.

    Console.WriteLine("RUN AND DEBUG:");
    Console.WriteLine("VARIABLES + WATCH + CALL STACK + BREAKPOINTS");
    Console.WriteLine(
        "Controls: Continue, Step Over, Step Into, Step Out, Restart, Stop.");
    Console.WriteLine();
}


// ============================================================================
// 2. BREAKPOINTS AND EXECUTION FLOW
// ============================================================================

static void DemonstrateGreetingBugFix()
{
    Console.WriteLine("2. BREAKPOINTS AND EXECUTION FLOW");
    Console.WriteLine("--------------------------------");

    string[] names =
    [
        "Sophia",
        "Andrew",
        "AllGreetings"
    ];

    foreach (string name in names)
    {
        string messageText;

        // GOOD BREAKPOINT LOCATION:
        // Place a breakpoint on the following if statement.
        //
        // Then use:
        // - Step Into to follow the actual execution path.
        // - Step Out to return from SophiaMessage() or AndrewMessage().
        // - VARIABLES to inspect 'name' and 'messageText'.

        if (name == "Sophia")
        {
            messageText = SophiaMessage();
        }
        else if (name == "Andrew")
        {
            messageText = AndrewMessage();
        }
        else
        {
            messageText =
                SophiaMessage() +
                Environment.NewLine +
                AndrewMessage();
        }

        Console.WriteLine(messageText);
        Console.WriteLine();
    }

    // ------------------------------------------------------------------------
    // ORIGINAL LOGIC BUG FROM THE LESSON
    // ------------------------------------------------------------------------
    //
    // The instructional version effectively behaved like this:
    //
    // if (name == "Sophia")
    //     messageText = SophiaMessage();
    // else if (name == "Andrew")
    //     messageText = AndrewMessage();
    // else if (name == "AllGreetings")
    //     messageText = SophiaMessage();
    //
    // messageText =
    //     messageText +
    //     Environment.NewLine +
    //     AndrewMessage();
    //
    // Indentation made the final assignment LOOK like part of the last branch,
    // but without braces it was outside the if/else-if structure.
    //
    // The debugger reveals the REAL execution path, not the path suggested by
    // formatting.

    Console.WriteLine(
        "Breakpoint lesson: trust execution flow, not indentation.");
    Console.WriteLine();
}


static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}


static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}


// ============================================================================
// 3. CONDITIONAL BREAKPOINTS
// ============================================================================

static void DemonstrateConditionalBreakpointScenario()
{
    Console.WriteLine("3. CONDITIONAL BREAKPOINTS");
    Console.WriteLine("--------------------------");

    const int productCount = 2000;

    string[,] products =
        new string[productCount, 2];

    LoadProducts(
        products,
        productCount);

    int newProductCount = 0;
    int obsoleteProductCount = 0;

    for (int index = 0; index < productCount; index++)
    {
        string status =
            ProcessProductStatus(
                products,
                index);

        // CONDITIONAL BREAKPOINT EXAMPLE:
        //
        // Put a breakpoint on the following if statement and configure:
        //
        // products[index, 1] == "new"
        //
        // Each time the debugger reaches the breakpoint:
        //
        // false -> continue execution
        // true  -> pause execution

        if (status == "new")
        {
            newProductCount++;
        }
        else if (status == "obsolete")
        {
            obsoleteProductCount++;
        }
    }

    Console.WriteLine($"Products processed: {productCount}");
    Console.WriteLine($"New products:       {newProductCount}");
    Console.WriteLine($"Obsolete products:  {obsoleteProductCount}");

    // Other breakpoint variants:
    //
    // STANDARD BREAKPOINT
    //     Pauses whenever the statement is reached.
    //
    // CONDITIONAL BREAKPOINT
    //     Pauses only when a Boolean expression is true.
    //
    // HIT COUNT BREAKPOINT
    //     Pauses after the breakpoint has been encountered a configured
    //     number of times.
    //
    // LOGPOINT
    //     Logs information without pausing execution.
    //
    // Example Logpoint:
    //
    // index = {index}, status = {products[index, 1]}

    Console.WriteLine();
}


static void LoadProducts(
    string[,] products,
    int productCount)
{
    // Positional constructor argument is used intentionally.
    // Random does not expose a lowercase named parameter called "seed".
    //
    // A fixed seed makes this educational example reproducible.
    Random random = new(42);

    for (int index = 0; index < productCount; index++)
    {
        int productNumber =
            random.Next(
                10_001,
                20_000);

        int categoryNumber =
            random.Next(
                1,
                101);

        string productId =
            productNumber.ToString();

        if (categoryNumber < 91)
        {
            products[index, 1] =
                "existing";
        }
        else if (categoryNumber == 91)
        {
            products[index, 1] =
                "new";

            productId += "-n";
        }
        else
        {
            products[index, 1] =
                "obsolete";

            productId += "-o";
        }

        products[index, 0] =
            productId;
    }
}


static string ProcessProductStatus(
    string[,] products,
    int item)
{
    return products[item, 1];
}


// ============================================================================
// 4. VARIABLES AND ZERO-BASED INDEXING
// ============================================================================

static void DemonstrateVariableStateAndZeroBasedIndexing()
{
    Console.WriteLine("4. VARIABLES AND PROGRAM STATE");
    Console.WriteLine("------------------------------");

    int[] numbers =
    [
        1,
        2,
        3,
        4,
        5
    ];

    int userVisibleStartingPosition = 3;

    // The user thinks in positions:
    //
    // Position: 1  2  3  4  5
    // Value:    1  2  3  4  5
    //
    // C# uses zero-based indexes:
    //
    // Index:    0  1  2  3  4
    // Value:    1  2  3  4  5
    //
    // User position 3 therefore maps to array index 2.

    int arrayStartIndex =
        userVisibleStartingPosition - 1;

    int sum =
        SumValues(
            numbers,
            arrayStartIndex);

    // GOOD BREAKPOINT LOCATION:
    // Place a breakpoint on the following Console.WriteLine statement.
    //
    // Inspect:
    // userVisibleStartingPosition = 3
    // arrayStartIndex             = 2
    // numbers                     = { 1, 2, 3, 4, 5 }
    // sum                         = 12

    Console.WriteLine(
        $"Sum of positions {userVisibleStartingPosition} " +
        $"through {numbers.Length}: {sum}");

    // The original lesson bug passed:
    //
    // SumValues(numbers, userVisibleStartingPosition)
    //
    // which meant:
    //
    // SumValues(numbers, 3)
    //
    // Array index 3 contains 4, so the calculation became:
    //
    // 4 + 5 = 9
    //
    // VARIABLES makes the mismatch between UI position and array index easy
    // to identify.

    Console.WriteLine();
}


static int SumValues(
    int[] numbers,
    int startIndex)
{
    int sum = 0;

    for (
        int index = startIndex;
        index < numbers.Length;
        index++)
    {
        // Step through this line while watching:
        //
        // index
        // numbers[index]
        // sum

        sum +=
            numbers[index];
    }

    return sum;
}


// ============================================================================
// 5. WATCH EXPRESSIONS
// ============================================================================

static void DemonstrateWatchExpression()
{
    Console.WriteLine("5. WATCH EXPRESSIONS");
    Console.WriteLine("--------------------");

    Random random = new(123);

    bool ratioExceededFive = false;

    int numerator = 0;
    int denominator = 0;

    for (
        int iteration = 1;
        iteration <= 20;
        iteration++)
    {
        denominator =
            random.Next(
                1,
                11);

        numerator =
            denominator +
            random.Next(
                1,
                51);

        // WATCH expression from the lesson:
        //
        // numerator / denominator > 5
        //
        // Because numerator and denominator are int values, that expression
        // performs integer division.
        //
        // For an exact ratio, a more explicit WATCH expression is:
        //
        // (double)numerator / denominator > 5

        double ratio =
            (double)numerator /
            denominator;

        if (ratio > 5)
        {
            ratioExceededFive = true;

            // A debugger lets us inspect the exact values that caused the
            // watched condition to become true.

            break;
        }
    }

    Console.WriteLine($"Numerator:   {numerator}");
    Console.WriteLine($"Denominator: {denominator}");

    Console.WriteLine(
        $"Ratio:       {(double)numerator / denominator:F2}");

    Console.WriteLine(
        $"Ratio > 5:   {ratioExceededFive}");

    // The VARIABLES section can also change a variable value at runtime.
    // This is useful when testing how code reacts to a specific state without
    // rewriting source code just to create that state.

    Console.WriteLine();
}


// ============================================================================
// 6. CALL STACK
// ============================================================================

static void DemonstrateCallStack()
{
    Console.WriteLine("6. CALL STACK");
    Console.WriteLine("-------------");

    try
    {
        StartCalculation();
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine(
            $"Handled exception: {exception.GetType().Name}");

        Console.WriteLine(
            "The application continues after the demonstration.");
    }

    Console.WriteLine();
}


static void StartCalculation()
{
    // CALL STACK:
    //
    // top-level statements
    //     ↓
    // DemonstrateCallStack()
    //     ↓
    // StartCalculation()
    //     ↓
    // CalculateRatio()
    //     ↓
    // DivideValues()

    CalculateRatio();
}


static void CalculateRatio()
{
    const int numerator = 100;
    const int denominator = 0;

    DivideValues(
        numerator,
        denominator);
}


static int DivideValues(
    int numerator,
    int denominator)
{
    // GOOD BREAKPOINT LOCATION:
    //
    // Put a breakpoint here and inspect CALL STACK.
    //
    // The debugger shows:
    // - WHERE execution currently is.
    // - HOW execution reached this method.

    if (denominator == 0)
    {
        throw new DivideByZeroException(
            "The denominator cannot be zero.");
    }

    return numerator /
           denominator;
}


// ============================================================================
// 7. LAUNCH CONFIGURATION
// ============================================================================
//
// Visual Studio Code normally stores debugger configuration in:
//
// .vscode/
// ├── launch.json
// └── tasks.json
//
// Common launch.json attributes:
//
// name
//     Human-readable configuration name.
//
// type
//     Specifies the debugger.
//     For C#/.NET:
//     "coreclr"
//
// request
//     "launch" -> start a new application.
//     "attach" -> attach to an already running application.
//
// preLaunchTask
//     Specifies a task that runs before debugging.
//
// program
//     Path to the application DLL or executable.
//
// cwd
//     Working directory.
//
// args
//     Command-line arguments supplied to the application.
//
// console
//     internalConsole
//     integratedTerminal
//     externalTerminal
//
// stopAtEntry
//     true  -> pause at application entry.
//     false -> begin normal execution.
//
// IMPORTANT:
//
// DEBUG CONSOLE does not support Console.ReadLine() input.
//
// Applications that require user input should normally use:
//
// "console": "integratedTerminal"
//
// or:
//
// "console": "externalTerminal"
//
// A workspace containing multiple applications can define multiple launch
// configurations and separate build tasks.
//
// ============================================================================


// ============================================================================
// 8. PASS-BY-VALUE DEBUGGER CHALLENGE
// ============================================================================

static void DemonstratePassByValueChallenge()
{
    Console.WriteLine("7. PASS-BY-VALUE DEBUGGER CHALLENGE");
    Console.WriteLine("----------------------------------");

    int originalValue = 5;

    Console.WriteLine(
        $"Before pass-by-value method: {originalValue}");

    ChangeLocalCopy(
        originalValue);

    Console.WriteLine(
        $"After pass-by-value method:  {originalValue}");

    // WHY IS originalValue STILL 5?
    //
    // int is a value type.
    //
    // Calling:
    //
    // ChangeLocalCopy(originalValue)
    //
    // copies the current value into the method parameter.
    //
    // Conceptually:
    //
    // originalValue = 5
    //
    //         COPY
    //          ↓
    //
    // value = 5
    //
    // Changing the parameter affects only that local copy.

    originalValue =
        ChangeValueAndReturn(
            originalValue);

    Console.WriteLine(
        $"After corrected method:      {originalValue}");

    Console.WriteLine();
}


static void ChangeLocalCopy(
    int value)
{
    // Reading the incoming value before changing it makes the pass-by-value
    // behavior visible both in normal output and in the debugger.
    Console.WriteLine(
        $"  Local parameter on entry:  {value}");

    value = 10;

    Console.WriteLine(
        $"  Local parameter after set: {value}");

    // Set a breakpoint here and inspect:
    //
    // value = 10
    //
    // Then Step Out and inspect the caller:
    //
    // originalValue is still 5.
}


static int ChangeValueAndReturn(
    int value)
{
    // Use the incoming parameter before changing it so the method clearly
    // demonstrates both the received value and the returned value.
    Console.WriteLine(
        $"  Return-method input value: {value}");

    value = 10;

    return value;
}