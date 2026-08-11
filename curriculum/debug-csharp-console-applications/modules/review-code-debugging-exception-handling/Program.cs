// ============================================================================
// Module: Review the Principles of Code Debugging and Exception Handling
// Learning Path: Debug C# Console Applications
//
// Purpose:
// - Review the difference between testing, debugging, and exception handling.
// - Demonstrate a common runtime bug caused by zero-based array indexing.
// - Demonstrate how exception handling protects an application at runtime.
// - Provide small examples whose program state can be inspected with a debugger.
//
// Key concepts:
// 1. Testing verifies whether code behaves as expected.
// 2. Debugging isolates the cause of an issue and helps identify a fix.
// 3. Exception handling manages errors that occur while the application runs.
// ============================================================================

Console.WriteLine("==============================================");
Console.WriteLine(" C# Debugging and Exception Handling Review");
Console.WriteLine("==============================================");
Console.WriteLine();

RunTestingExample();
RunDebuggingExample();
RunDebuggerStateExample();
RunExceptionHandlingExample();

Console.WriteLine();
Console.WriteLine("Review completed.");


// ============================================================================
// TESTING
// ============================================================================

static void RunTestingExample()
{
    Console.WriteLine("1. TESTING");
    Console.WriteLine("----------");

    // Developers are expected to perform some level of testing before
    // handing their code off to another person or team.
    //
    // Formal software testing is a large discipline that includes categories
    // such as:
    //
    // Functional testing:
    // - Unit testing
    // - Integration testing
    // - System testing
    // - Acceptance testing
    //
    // Nonfunctional testing:
    // - Security testing
    // - Performance testing
    // - Usability testing
    // - Compatibility testing
    //
    // The example below performs a simple manual verification.
    // It is NOT a formal unit-testing framework.

    int firstNumber = 10;
    int secondNumber = 5;

    int expectedResult = 15;
    int actualResult = AddNumbers(firstNumber, secondNumber);

    Console.WriteLine($"Expected result: {expectedResult}");
    Console.WriteLine($"Actual result:   {actualResult}");

    if (actualResult == expectedResult)
    {
        Console.WriteLine("Test result: PASS");
    }
    else
    {
        Console.WriteLine("Test result: FAIL");
    }

    Console.WriteLine();
}


static int AddNumbers(int firstNumber, int secondNumber)
{
    // This method represents a small unit of application logic.
    // Keeping logic inside methods makes behavior easier to test and debug.

    return firstNumber + secondNumber;
}


// ============================================================================
// DEBUGGING
// ============================================================================

static void RunDebuggingExample()
{
    Console.WriteLine("2. DEBUGGING");
    Console.WriteLine("------------");

    // Debugging is the process of:
    //
    // 1. Isolating an issue.
    // 2. Identifying its cause.
    // 3. Determining one or more ways to fix it.
    //
    // A syntax error such as a missing semicolon is normally not what
    // developers mean when they talk about debugging.
    //
    // Debugging generally focuses on runtime behavior that is not producing
    // the result that the developer expects.

    string[] students =
    {
        "Sophia",
        "Nicolas",
        "Zahirah",
        "Jeong"
    };

    int studentCount = students.Length;

    Console.WriteLine($"Number of students: {studentCount}");

    // Arrays in C# use ZERO-BASED indexing.
    //
    // For four elements:
    //
    // Value:  Sophia   Nicolas   Zahirah   Jeong
    // Index:     0        1         2         3
    //
    // students.Length is 4, but index 4 does not exist.
    //
    // Therefore this would be incorrect:
    //
    // Console.WriteLine(students[studentCount]);
    //
    // It would cause an IndexOutOfRangeException at runtime.

    int finalStudentIndex = studentCount - 1;

    Console.WriteLine($"Final valid index: {finalStudentIndex}");
    Console.WriteLine($"The final name is: {students[finalStudentIndex]}");

    Console.WriteLine();
}


// ============================================================================
// DEBUGGER
// ============================================================================

static void RunDebuggerStateExample()
{
    Console.WriteLine("3. DEBUGGER STATE");
    Console.WriteLine("-----------------");

    // A debugger is a software tool that allows a developer to observe
    // and control the execution of a program.
    //
    // Two especially important debugger capabilities are:
    //
    // 1. Execution control
    //    - Pause the program.
    //    - Continue execution.
    //    - Execute code one line at a time.
    //
    // 2. State observation
    //    - Inspect variable values.
    //    - Inspect method parameters.
    //    - Observe how values change while the program executes.
    //
    // This small calculation is useful for practicing breakpoints
    // and step-by-step execution.

    decimal productPrice = 120.00m;
    int quantity = 3;

    decimal subtotal = productPrice * quantity;

    decimal taxRate = 0.10m;
    decimal tax = subtotal * taxRate;

    decimal total = subtotal + tax;

    // A breakpoint can be placed on one of the lines above.
    //
    // While execution is paused, inspect:
    //
    // productPrice = 120.00
    // quantity     = 3
    // subtotal     = 360.00
    // taxRate      = 0.10
    // tax          = 36.00
    // total        = 396.00
    //
    // Following these values makes the application's runtime state visible
    // instead of forcing the developer to guess what the program is doing.

    Console.WriteLine($"Product price: {productPrice:C}");
    Console.WriteLine($"Quantity:      {quantity}");
    Console.WriteLine($"Subtotal:      {subtotal:C}");
    Console.WriteLine($"Tax:           {tax:C}");
    Console.WriteLine($"Total:         {total:C}");

    Console.WriteLine();
}


// ============================================================================
// EXCEPTION HANDLING
// ============================================================================

static void RunExceptionHandlingExample()
{
    Console.WriteLine("4. EXCEPTION HANDLING");
    Console.WriteLine("---------------------");

    // Errors that occur while a C# application is running are called
    // exceptions.
    //
    // Exceptions are different from build errors.
    //
    // Build error:
    //     The program cannot be successfully compiled.
    //
    // Runtime exception:
    //     The program compiled successfully, but an error occurred while
    //     the application was executing.
    //
    // If an exception is not handled, it can terminate the application.

    string userInput = "not-a-number";

    try
    {
        // The TRY block contains code that might generate an exception.
        //
        // int.Parse expects text representing a valid integer.
        // "not-a-number" cannot be converted into an integer, so .NET
        // throws a FormatException.

        int parsedNumber = int.Parse(userInput);

        Console.WriteLine($"Parsed number: {parsedNumber}");
    }
    catch (FormatException exception)
    {
        // The CATCH block handles a specific type of exception.
        //
        // The exception object contains information about what happened.
        // This allows the application to respond in a controlled way
        // instead of terminating unexpectedly.

        Console.WriteLine($"Input value: \"{userInput}\"");
        Console.WriteLine("The value could not be converted to an integer.");

        Console.WriteLine($"Exception type: {exception.GetType().Name}");
        Console.WriteLine($"Message: {exception.Message}");
    }

    // Because the exception was caught, program execution continues here.

    Console.WriteLine("The application is still running after the exception.");
}