// ============================================================================
// Module: Implement Exception Handling in C# Console Applications
// Learning Path: Debug C# Console Applications
//
// Purpose:
// - Review common runtime exception categories.
// - Demonstrate try, catch, and finally.
// - Demonstrate call stack unwinding.
// - Catch specific exception types.
// - Inspect exception object properties.
// - Show why independent failures may need separate try-catch blocks.
//
// Important:
// - Several methods intentionally trigger runtime exceptions for study.
// - Every intentional exception is handled so this project runs to completion.
// ============================================================================

Console.WriteLine("========================================================");
Console.WriteLine(" C# Exception Handling Review");
Console.WriteLine("========================================================");
Console.WriteLine();

DemonstrateExceptionHandlingPatterns();
DemonstrateCommonRuntimeExceptions();
DemonstrateCallStackUnwinding();
DemonstrateNearestCatchHandler();
DemonstrateExceptionProperties();
DemonstrateSpecificCatchClauses();
DemonstrateIndependentTryCatchBlocks();
DemonstrateFinallyCleanup();

Console.WriteLine();
Console.WriteLine("Exception handling review completed.");


// ============================================================================
// 1. EXCEPTION-HANDLING PATTERNS
// ============================================================================

static void DemonstrateExceptionHandlingPatterns()
{
    WriteSectionHeader("1. EXCEPTION-HANDLING PATTERNS");

    // try:
    //     Guard code that may fail.
    //
    // catch:
    //     Handle an exception the current layer understands.
    //
    // finally:
    //     Run cleanup when control leaves the try statement, whether the
    //     guarded code succeeds or fails.
    //
    // Common patterns:
    //     try-catch
    //     try-finally
    //     try-catch-finally

    Console.WriteLine("try-catch:");

    try
    {
        int numerator = 3000;
        int denominator = 0;

        Console.WriteLine(numerator / denominator);
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine($"Handled: {exception.GetType().Name}");
    }

    Console.WriteLine();

    Console.WriteLine("try-finally:");

    bool cleanupCompleted = false;

    try
    {
        Console.WriteLine("Protected operation completed.");
    }
    finally
    {
        cleanupCompleted = true;
        Console.WriteLine("Cleanup executed in finally.");
    }

    Console.WriteLine($"Cleanup completed: {cleanupCompleted}");
    Console.WriteLine();

    Console.WriteLine("try-catch-finally:");

    bool finalizationCompleted = false;

    try
    {
        _ = int.Parse("not-a-number");
    }
    catch (FormatException exception)
    {
        Console.WriteLine($"Handled: {exception.GetType().Name}");
    }
    finally
    {
        finalizationCompleted = true;
        Console.WriteLine("Finalization executed.");
    }

    Console.WriteLine($"Finalization completed: {finalizationCompleted}");
    Console.WriteLine();
}


// ============================================================================
// 2. COMMON RUNTIME EXCEPTIONS
// ============================================================================

static void DemonstrateCommonRuntimeExceptions()
{
    WriteSectionHeader("2. COMMON RUNTIME EXCEPTIONS");

    // The module reviews these runtime exception types:
    //
    // ArrayTypeMismatchException
    // DivideByZeroException
    // FormatException
    // IndexOutOfRangeException
    // InvalidCastException
    // NullReferenceException
    // OverflowException

    DemonstrateArrayTypeMismatchException();
    DemonstrateDivideByZeroException();
    DemonstrateFormatException();
    DemonstrateIndexOutOfRangeException();
    DemonstrateInvalidCastException();
    DemonstrateNullReferenceException();
    DemonstrateOverflowException();

    Console.WriteLine();
}


static void DemonstrateArrayTypeMismatchException()
{
    try
    {
        string[] names =
        [
            "Dog",
            "Cat",
            "Fish"
        ];

        // string[] can be referenced as object[] because reference-type arrays
        // are covariant. The runtime still knows the actual array is string[].
        // Writing an int into it therefore causes ArrayTypeMismatchException.

        object[] objects = names;
        objects[2] = 13;
    }
    catch (ArrayTypeMismatchException exception)
    {
        PrintCaughtException(exception);
    }
}


static void DemonstrateDivideByZeroException()
{
    double floatingPointNumerator = 3000.0;
    double floatingPointDenominator = 0.0;

    // IEEE 754 floating-point division by zero produces Infinity/NaN instead
    // of DivideByZeroException.

    double floatingPointResult =
        floatingPointNumerator /
        floatingPointDenominator;

    Console.WriteLine($"double division by zero: {floatingPointResult}");

    try
    {
        int integerNumerator = 3000;
        int integerDenominator = 0;

        _ = integerNumerator / integerDenominator;
    }
    catch (DivideByZeroException exception)
    {
        PrintCaughtException(exception);
    }
}


static void DemonstrateFormatException()
{
    try
    {
        string userValue = "two";
        _ = int.Parse(userValue);
    }
    catch (FormatException exception)
    {
        PrintCaughtException(exception);
    }
}


static void DemonstrateIndexOutOfRangeException()
{
    try
    {
        int[] values =
        [
            3,
            6,
            9,
            12,
            15,
            18,
            21
        ];

        // Valid indexes are 0 through 6.
        // values.Length is 7, so values[7] is outside the bounds.

        _ = values[values.Length];
    }
    catch (IndexOutOfRangeException exception)
    {
        PrintCaughtException(exception);
    }
}


static void DemonstrateInvalidCastException()
{
    try
    {
        object value = "This is a string";
        _ = (int)value;
    }
    catch (InvalidCastException exception)
    {
        PrintCaughtException(exception);
    }
}


static void DemonstrateNullReferenceException()
{
    try
    {
        string? text = null;

        // The null-forgiving operator (!) only suppresses nullable static
        // analysis here. It does not prevent the intentional runtime failure.

        _ = text!.Length;
    }
    catch (NullReferenceException exception)
    {
        PrintCaughtException(exception);
    }
}


static void DemonstrateOverflowException()
{
    try
    {
        int first = int.MaxValue;
        int second = int.MaxValue;

        // checked forces integral overflow to be reported as OverflowException.

        _ = checked(first + second);
    }
    catch (OverflowException exception)
    {
        PrintCaughtException(exception);
    }
}


// ============================================================================
// 3. CALL STACK UNWINDING
// ============================================================================

static void DemonstrateCallStackUnwinding()
{
    WriteSectionHeader("3. CALL STACK UNWINDING");

    // Throw location:
    //
    // WriteMessageForPropagation()
    //
    // Call path:
    //
    // top-level statements
    //        ↓
    // DemonstrateCallStackUnwinding()
    //        ↓
    // ProcessForPropagation()
    //        ↓
    // WriteMessageForPropagation()
    //
    // The two inner methods do not catch the exception.
    // The CLR unwinds the stack until it finds this compatible catch clause.

    try
    {
        ProcessForPropagation();
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine("Exception propagated to the outer handler.");
        Console.WriteLine($"Message: {exception.Message}");
    }

    Console.WriteLine("Execution continues after the propagated exception.");
    Console.WriteLine();
}


static void ProcessForPropagation()
{
    WriteMessageForPropagation();
}


static void WriteMessageForPropagation()
{
    double floatingPointNumerator = 3000.0;
    double floatingPointDenominator = 0.0;

    int integerNumerator = 3000;
    int integerDenominator = 0;

    Console.WriteLine(
        $"Floating-point result: " +
        $"{floatingPointNumerator / floatingPointDenominator}");

    Console.WriteLine(integerNumerator / integerDenominator);
}


// ============================================================================
// 4. NEAREST COMPATIBLE CATCH HANDLER
// ============================================================================

static void DemonstrateNearestCatchHandler()
{
    WriteSectionHeader("4. NEAREST COMPATIBLE CATCH HANDLER");

    // The outer handler exists, but ProcessWithLocalHandler() catches the
    // DivideByZeroException first. Once handled, the CLR stops searching for
    // another handler for that same exception.

    try
    {
        ProcessWithLocalHandler();
    }
    catch (DivideByZeroException)
    {
        // This handler should not execute in this example.
        Console.WriteLine("Outer handler executed.");
    }

    Console.WriteLine("Exit local-handler demonstration.");
    Console.WriteLine();
}


static void ProcessWithLocalHandler()
{
    try
    {
        WriteMessageForLocalHandler();
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine("Exception caught in ProcessWithLocalHandler.");
        Console.WriteLine($"Message: {exception.Message}");
    }
}


static void WriteMessageForLocalHandler()
{
    double floatingPointNumerator = 3000.0;
    double floatingPointDenominator = 0.0;

    int integerNumerator = 3000;
    int integerDenominator = 0;

    Console.WriteLine(
        $"Floating-point result: " +
        $"{floatingPointNumerator / floatingPointDenominator}");

    _ = integerNumerator / integerDenominator;
}


// ============================================================================
// 5. EXCEPTION OBJECT PROPERTIES
// ============================================================================

static void DemonstrateExceptionProperties()
{
    WriteSectionHeader("5. EXCEPTION OBJECT PROPERTIES");

    // System.Exception is the base class for .NET exception types.
    //
    // Common properties:
    //
    // Data
    // HelpLink
    // HResult
    // InnerException
    // Message
    // Source
    // StackTrace
    // TargetSite
    //
    // This module focuses especially on Message.

    try
    {
        int numerator = 100;
        int denominator = 0;

        _ = numerator / denominator;
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine($"Type: {exception.GetType().FullName}");
        Console.WriteLine($"Message: {exception.Message}");
        Console.WriteLine($"HResult: {exception.HResult}");
        Console.WriteLine(
            $"TargetSite: {exception.TargetSite?.Name ?? "<unknown>"}");
        Console.WriteLine(
            $"StackTrace available: {exception.StackTrace is not null}");
    }

    Console.WriteLine();
}


// ============================================================================
// 6. SPECIFIC CATCH CLAUSES
// ============================================================================

static void DemonstrateSpecificCatchClauses()
{
    WriteSectionHeader("6. SPECIFIC CATCH CLAUSES");

    string[] inputValues =
    [
        "three",
        "9999999999",
        "0",
        "2"
    ];

    foreach (string inputValue in inputValues)
    {
        try
        {
            int number = int.Parse(inputValue);
            Console.WriteLine($"Parsed value: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine(
                $"Input \"{inputValue}\": invalid numeric format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine(
                $"Input \"{inputValue}\": value is outside Int32 range.");
        }
        catch (Exception exception)
        {
            // A general base-class handler belongs last.
            // Prefer specific exception types whenever the current layer knows
            // how to recover from them meaningfully.

            Console.WriteLine($"Unexpected error: {exception.Message}");
        }
    }

    Console.WriteLine();
}


// ============================================================================
// 7. INDEPENDENT TRY-CATCH BLOCKS
// ============================================================================

static void DemonstrateIndependentTryCatchBlocks()
{
    WriteSectionHeader("7. INDEPENDENT TRY-CATCH BLOCKS");

    // If several independent operations are placed in one try block, the first
    // exception immediately transfers control out of that try block. Later
    // statements in the same try block are therefore never reached.
    //
    // The challenge expects all four error scenarios to be shown, so each
    // independent operation gets its own try-catch block.

    DemonstrateCheckedOverflowChallenge();
    DemonstrateNullReferenceChallenge();
    DemonstrateIndexOutOfRangeChallenge();
    DemonstrateDivideByZeroChallenge();

    Console.WriteLine("Exiting independent-exception demonstration.");
    Console.WriteLine();
}


static void DemonstrateCheckedOverflowChallenge()
{
    try
    {
        int first = int.MaxValue;
        int second = int.MaxValue;

        int result = checked(first + second);

        Console.WriteLine($"Result: {result}");
    }
    catch (OverflowException exception)
    {
        Console.WriteLine(
            "Error: The number is too large to be represented as an integer. " +
            exception.Message);
    }
}


static void DemonstrateNullReferenceChallenge()
{
    try
    {
        string? text = null;

        int length = text!.Length;

        Console.WriteLine($"String Length: {length}");
    }
    catch (NullReferenceException exception)
    {
        Console.WriteLine(
            "Error: The reference is null. " +
            exception.Message);
    }
}


static void DemonstrateIndexOutOfRangeChallenge()
{
    try
    {
        int[] numbers = new int[5];

        numbers[5] = 10;

        Console.WriteLine($"Number at index 5: {numbers[5]}");
    }
    catch (IndexOutOfRangeException exception)
    {
        Console.WriteLine(
            "Error: Index out of range. " +
            exception.Message);
    }
}


static void DemonstrateDivideByZeroChallenge()
{
    try
    {
        int numerator = 10;
        int denominator = 0;

        int result = numerator / denominator;

        Console.WriteLine($"Result: {result}");
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine(
            "Error: Cannot divide by zero. " +
            exception.Message);
    }
}


// ============================================================================
// 8. FINALLY AND CLEANUP
// ============================================================================

static void DemonstrateFinallyCleanup()
{
    WriteSectionHeader("8. FINALLY AND CLEANUP");

    // finally executes whether the guarded operation succeeds or fails.
    //
    // Real applications use guaranteed cleanup for resources and required
    // state. Modern .NET also provides using/await using for disposable
    // resources, but finally remains fundamental to understanding cleanup.

    bool resourceIsOpen = false;

    try
    {
        resourceIsOpen = true;

        Console.WriteLine($"Resource open: {resourceIsOpen}");

        _ = int.Parse("invalid");
    }
    catch (FormatException exception)
    {
        Console.WriteLine($"Handled processing error: {exception.Message}");
    }
    finally
    {
        resourceIsOpen = false;
        Console.WriteLine("finally: resource state was cleaned up.");
    }

    Console.WriteLine(
        $"Resource open after try statement: {resourceIsOpen}");

    Console.WriteLine();
}


// ============================================================================
// SHARED DISPLAY HELPERS
// ============================================================================

static void WriteSectionHeader(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
}


static void PrintCaughtException(Exception exception)
{
    Console.WriteLine(
        $"{exception.GetType().Name}: {exception.Message}");
}