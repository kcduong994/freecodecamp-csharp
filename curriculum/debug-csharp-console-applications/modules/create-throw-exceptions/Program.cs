// ============================================================================
// Module: Create and Throw Exceptions in C# Console Applications
// Learning Path: Debug C# Console Applications
//
// Purpose:
// - Create exception objects that match the detected failure condition.
// - Add useful, non-sensitive context to exception objects.
// - Throw exceptions when a method cannot complete its intended purpose.
// - Catch exceptions at the call-stack level where they can be resolved.
// - Re-throw the original exception with `throw;`.
// - Wrap an original exception when adding higher-level context.
// - Replace status-string error flow with structured exceptions.
//
// Repository design:
// - All intentional failures are handled.
// - The program runs to completion.
// - Interactive lesson examples are converted to deterministic examples that
//   are easy to rerun, debug, and maintain.
// ============================================================================

using System.Diagnostics;

Console.WriteLine("========================================================");
Console.WriteLine(" C# Create and Throw Exceptions Review");
Console.WriteLine("========================================================");
Console.WriteLine();

ReviewExceptionSelection();
DemonstrateCustomizedExceptionObject();
DemonstrateArgumentOutOfRangeValidation();
DemonstrateBusinessProcessFormatException();
DemonstrateRethrow();
DemonstrateWrappedException();
DemonstrateChallengeWorkflow();
ReviewThrowingPractices();
DemonstrateDebugAssert();

Console.WriteLine();
Console.WriteLine("Create and throw exceptions review completed.");


// ============================================================================
// 1. CHOOSE THE EXCEPTION TYPE THAT BEST MATCHES THE FAILURE
// ============================================================================

static void ReviewExceptionSelection()
{
    WriteSectionHeader(
        "1. CHOOSE THE MOST SPECIFIC EXCEPTION TYPE");

    // Common exception types reviewed in this module:
    //
    // ArgumentException
    //     An argument value is invalid.
    //
    // ArgumentNullException
    //     A required argument is null.
    //
    // ArgumentOutOfRangeException
    //     An argument is outside the range accepted by the method.
    //
    // InvalidOperationException
    //     Current operating conditions don't support the operation.
    //
    // NotSupportedException
    //     The requested operation or feature isn't supported.
    //
    // IOException
    //     An input/output operation fails.
    //
    // FormatException
    //     Input data has an invalid format.
    //
    // Core design rule:
    //
    // invalid condition
    //       ↓
    // choose the narrowest useful exception type
    //       ↓
    // create exception object
    //       ↓
    // throw
    //       ↓
    // caller decides whether it can resolve the problem

    Console.WriteLine(
        "Rule: throw the most specific exception that matches the failure.");

    Console.WriteLine();
}


// ============================================================================
// 2. CREATE AND CUSTOMIZE AN EXCEPTION OBJECT
// ============================================================================

static void DemonstrateCustomizedExceptionObject()
{
    WriteSectionHeader(
        "2. CREATE AND CUSTOMIZE AN EXCEPTION OBJECT");

    int[] graphData =
    [
        10,
        25,
        150,
        40
    ];

    try
    {
        GraphData(
            graphData);
    }
    catch (ArgumentException exception)
    {
        Console.WriteLine(
            $"Caught: {exception.GetType().Name}");

        Console.WriteLine(
            $"Message: {exception.Message}");

        Console.WriteLine(
            $"Parameter: {exception.ParamName}");

        Console.WriteLine(
            $"Method metadata: {exception.Data["Method"]}");

        Console.WriteLine(
            $"Expected range: {exception.Data["ExpectedRange"]}");

        Console.WriteLine(
            $"Invalid value: {exception.Data["InvalidValue"]}");

        Console.WriteLine(
            $"Stack trace available: {exception.StackTrace is not null}");
    }

    Console.WriteLine();
}


static void GraphData(
    int[] data)
{
    ArgumentNullException.ThrowIfNull(
        data);

    const int minimum = 0;
    const int maximum = 100;

    foreach (int value in data)
    {
        if (value < minimum || value > maximum)
        {
            // Message is supplied through the constructor because
            // Exception.Message is read-only after construction.
            //
            // Data can carry extra non-sensitive diagnostic context.

            ArgumentException invalidArgumentException =
                new(
                    "GraphData received data outside the expected range.",
                    nameof(data));

            invalidArgumentException.Data["Method"] =
                nameof(GraphData);

            invalidArgumentException.Data["ExpectedRange"] =
                $"{minimum}..{maximum}";

            invalidArgumentException.Data["InvalidValue"] =
                value;

            throw invalidArgumentException;
        }
    }

    Console.WriteLine(
        "GraphData completed successfully.");
}


// ============================================================================
// 3. VALIDATE ARGUMENTS AND THROW ARGUMENTOUTOFRANGEEXCEPTION
// ============================================================================

static void DemonstrateArgumentOutOfRangeValidation()
{
    WriteSectionHeader(
        "3. VALIDATE ARGUMENTS BEFORE CALCULATION");

    const int lowerBound = 3;

    int[] candidateUpperBounds =
    [
        3,
        11
    ];

    // Microsoft Learn uses Console.ReadLine() and a do loop.
    //
    // This repository version uses deterministic values:
    //
    // upperBound = 3
    //     → invalid
    //     → ArgumentOutOfRangeException
    //
    // upperBound = 11
    //     → valid
    //     → average of 4, 6, 8, 10 = 7

    foreach (int upperBound in candidateUpperBounds)
    {
        try
        {
            decimal average =
                AverageOfEvenNumbers(
                    lowerBound,
                    upperBound);

            Console.WriteLine(
                $"The average of even numbers between " +
                $"{lowerBound} and {upperBound} is {average}.");

            break;
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(
                "An error has occurred.");

            Console.WriteLine(
                exception.Message);

            Console.WriteLine(
                $"The upper bound must be greater than {lowerBound}.");
        }
    }

    Console.WriteLine();
}


static decimal AverageOfEvenNumbers(
    int lowerBound,
    int upperBound)
{
    // Validate the method contract before starting the calculation.
    //
    // This is better than waiting for a later arithmetic failure.

    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException(
            nameof(upperBound),
            "Upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;

    for (
        int value = lowerBound;
        value <= upperBound;
        value++)
    {
        if (value % 2 == 0)
        {
            sum +=
                value;

            count++;
        }
    }

    return (decimal)sum /
           count;
}


// ============================================================================
// 4. THROW A CUSTOMIZED FORMATEXCEPTION FROM A BUSINESS PROCESS
// ============================================================================

static void DemonstrateBusinessProcessFormatException()
{
    WriteSectionHeader(
        "4. THROW A CUSTOMIZED FORMATEXCEPTION");

    string[][] userEnteredValues =
    [
        [
            "1",
            "two",
            "3"
        ],
        [
            "4",
            "5",
            "6"
        ]
    ];

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(
                userEntries);

            Console.WriteLine(
                "BusinessProcess1 completed successfully.");
        }
        catch (FormatException exception)
        {
            bool stackTraceIdentifiesSource =
                exception.StackTrace?.Contains(
                    nameof(BusinessProcess1),
                    StringComparison.Ordinal) == true;

            Console.WriteLine(
                exception.Message);

            Console.WriteLine(
                $"Stack trace identifies {nameof(BusinessProcess1)}: " +
                $"{stackTraceIdentifiesSource}");
        }
    }

    Console.WriteLine();
}


static void BusinessProcess1(
    string[] userEntries)
{
    ArgumentNullException.ThrowIfNull(
        userEntries);

    foreach (string userValue in userEntries)
    {
        try
        {
            _ =
                int.Parse(
                    userValue);

            // Business calculations would continue here.
        }
        catch (FormatException)
        {
            // The parsing error is translated into business-specific language
            // expected by this application.

            throw new FormatException(
                "FormatException: User input values in " +
                "'BusinessProcess1' must be valid integers.");
        }
    }
}


// ============================================================================
// 5. RE-THROW THE ORIGINAL EXCEPTION WITH `throw;`
// ============================================================================

static void DemonstrateRethrow()
{
    WriteSectionHeader(
        "5. RE-THROW THE ORIGINAL EXCEPTION");

    try
    {
        OperatingProcedureForRethrow();
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine(
            "Top-level handler received the re-thrown exception.");

        Console.WriteLine(
            exception.Message);

        Console.WriteLine(
            $"Original exception type preserved: " +
            $"{exception.GetType().Name}");
    }

    Console.WriteLine();
}


static void OperatingProcedureForRethrow()
{
    string[] userEntries =
    [
        "0",
        "1",
        "2"
    ];

    try
    {
        BusinessProcessForRethrow(
            userEntries);
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine(
            exception.Message);

        Console.WriteLine(
            "Partial correction in operating procedure; " +
            "further action is required.");

        // `throw;` re-throws the original exception object and preserves the
        // original diagnostic information.
        //
        // This is different from `throw exception;`, which changes the apparent
        // throw point in the stack trace.

        throw;
    }
}


static void BusinessProcessForRethrow(
    string[] userEntries)
{
    foreach (string userValue in userEntries)
    {
        int valueEntered =
            int.Parse(
                userValue);

        try
        {
            _ =
                4 /
                valueEntered;
        }
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException(
                "DivideByZeroException: Calculation in " +
                "'BusinessProcessForRethrow' encountered an unexpected " +
                "divide by zero.");
        }
    }
}


// ============================================================================
// 6. WRAP AN ORIGINAL EXCEPTION INSIDE A NEW EXCEPTION
// ============================================================================

static void DemonstrateWrappedException()
{
    WriteSectionHeader(
        "6. WRAP AN ORIGINAL EXCEPTION");

    try
    {
        OperatingProcedureForWrapping();
    }
    catch (ApplicationException exception)
    {
        Console.WriteLine(
            exception.Message);

        Console.WriteLine(
            $"Outer exception: {exception.GetType().Name}");

        Console.WriteLine(
            $"Inner exception: " +
            $"{exception.InnerException?.GetType().Name ?? "<none>"}");

        Console.WriteLine(
            $"Inner message: " +
            $"{exception.InnerException?.Message ?? "<none>"}");
    }

    Console.WriteLine();
}


static void OperatingProcedureForWrapping()
{
    try
    {
        object value =
            "not-an-integer";

        _ =
            (int)value;
    }
    catch (InvalidCastException exception)
    {
        // The module demonstrates wrapping the original exception by passing
        // it to the constructor of a higher-level exception.
        //
        // The original exception is then available through InnerException.

        throw new ApplicationException(
            "An error occurred in OperatingProcedureForWrapping.",
            exception);
    }
}


// ============================================================================
// 7. CHALLENGE: REPLACE STATUS-STRING ERROR FLOW WITH EXCEPTIONS
// ============================================================================

static void DemonstrateChallengeWorkflow()
{
    WriteSectionHeader(
        "7. CHALLENGE WORKFLOW");

    string[][] userEnteredValues =
    [
        [
            "1",
            "2",
            "3"
        ],
        [
            "1",
            "two",
            "3"
        ],
        [
            "0",
            "1",
            "2"
        ]
    ];

    // Challenge requirements:
    //
    // - Methods are void instead of returning error-status strings.
    // - Process1 throws exceptions for detected problems.
    // - Workflow1 catches FormatException.
    // - The top-level caller catches DivideByZeroException.
    // - Exception.Message is used to notify the user.

    try
    {
        Workflow1(
            userEnteredValues);

        Console.WriteLine(
            "'Workflow1' completed successfully.");
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine(
            "An error occurred during 'Workflow1'.");

        Console.WriteLine(
            exception.Message);
    }

    Console.WriteLine();
}


static void Workflow1(
    string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(
                userEntries);

            Console.WriteLine(
                "'Process1' completed successfully.");

            Console.WriteLine();
        }
        catch (FormatException exception)
        {
            // This layer can resolve/report format errors and then continue to
            // the next independent set of input values.

            Console.WriteLine(
                "'Process1' encountered an issue, process aborted.");

            Console.WriteLine(
                exception.Message);

            Console.WriteLine();
        }
    }
}


static void Process1(
    string[] userEntries)
{
    foreach (string userValue in userEntries)
    {
        bool integerFormat =
            int.TryParse(
                userValue,
                out int valueEntered);

        if (!integerFormat)
        {
            throw new FormatException(
                "Invalid data. User input values must be valid integers.");
        }

        if (valueEntered == 0)
        {
            // Workflow1 doesn't handle this exception.
            // It propagates to the top-level caller.

            throw new DivideByZeroException(
                "Invalid data. User input values must be non-zero values.");
        }

        checked
        {
            _ =
                4 /
                valueEntered;
        }
    }
}


// ============================================================================
// 8. PRACTICES TO AVOID WHEN THROWING EXCEPTIONS
// ============================================================================

static void ReviewThrowingPractices()
{
    WriteSectionHeader(
        "8. PRACTICES TO AVOID");

    // Avoid using exceptions as normal branching logic.
    //
    // Avoid returning Exception objects instead of throwing them.
    //
    // The module specifically warns against intentionally throwing these
    // general/runtime-generated exception types from application code merely
    // to signal your own validation failures:
    //
    // System.Exception
    // System.SystemException
    // System.NullReferenceException
    // System.IndexOutOfRangeException
    //
    // Choose an exception type whose purpose matches the detected condition.
    //
    // Don't place sensitive or security-relevant information in exception
    // messages that may be shown or logged.
    //
    // Don't create logic that throws only in Debug builds and silently
    // disappears in Release builds.
    //
    // Debug.Assert and runtime exceptions solve different problems.

    Console.WriteLine(
        "Exceptions report exceptional failures; " +
        "they are not ordinary branching tools.");

    Console.WriteLine();
}


// ============================================================================
// 9. DEBUG.ASSERT VS RUNTIME EXCEPTIONS
// ============================================================================

static void DemonstrateDebugAssert()
{
    WriteSectionHeader(
        "9. DEBUG.ASSERT VS RUNTIME EXCEPTIONS");

    int inventoryCount =
        5;

    // Debug.Assert is useful during development for states that should never
    // occur if the program logic is correct.
    //
    // The assertion is intentionally true so this repository project can run
    // normally.
    //
    // Exceptions are for exceptional situations that can occur during normal
    // execution and require runtime handling.

    Debug.Assert(
        inventoryCount >= 0,
        "Inventory count should never be negative.");

    Console.WriteLine(
        "Debug.Assert checked a development invariant.");

    Console.WriteLine(
        "Runtime exceptions remain the mechanism for operational failures.");

    Console.WriteLine();
}


// ============================================================================
// SHARED DISPLAY HELPER
// ============================================================================

static void WriteSectionHeader(
    string title)
{
    Console.WriteLine(title);

    Console.WriteLine(
        new string(
            '-',
            title.Length));
}