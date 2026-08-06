// ============================================================================
// Module: Write Your First C# Method
// Learning path: Create Methods in C# Console Applications
//
// Purpose:
// Consolidate the principal Microsoft Learn examples into one runnable program.
// The application demonstrates how methods:
// - give a meaningful name to a task;
// - move execution into a reusable block of code;
// - remove duplicated logic;
// - divide a larger problem into smaller validation steps;
// - use `return` to stop a method early;
// - make a solution easier to read, test, and maintain.
//
// Curriculum boundary:
// This module introduces parameterless `void` methods. The examples therefore
// intentionally use methods without parameters or return values. Later modules
// will improve data flow by passing arguments and returning results.
// ============================================================================

// A fixed seed keeps the example output reproducible while still demonstrating
// the Random class. Reproducible output makes repository verification easier.
Random random = new(20260807);

// These variables belong to the top-level program scope. The local methods
// declared later can access them. This is useful for the first method lesson,
// although future modules will replace many shared dependencies with parameters.
int[] medicineTimes = { 800, 1200, 1600, 2000 };
int timeZoneDifference = 0;

string[] currentAddress = Array.Empty<string>();
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

string[] fortunePrefixes =
{
    "You have much to",
    "Today is a day to",
    "Whatever work you do",
    "This is an ideal time to"
};

string[] goodFortunes =
{
    "look forward to.",
    "try new things!",
    "is likely to succeed.",
    "accomplish your dreams!"
};

string[] badFortunes =
{
    "fear.",
    "avoid major decisions.",
    "may have unexpected outcomes.",
    "re-evaluate your life."
};

string[] neutralFortunes =
{
    "appreciate.",
    "enjoy time with friends.",
    "should align with your values.",
    "get in tune with nature."
};

int luck = 0;

// ============================================================================
// TOP-LEVEL PROGRAM FLOW
//
// The top-level statements describe the application at a high level.
// Detailed implementation is delegated to methods with task-oriented names.
// ============================================================================

Console.WriteLine("WRITE YOUR FIRST C# METHOD");
Console.WriteLine(new string('=', 34));
Console.WriteLine();

DemonstrateMethodExecution();
DisplayRandomNumbers();
RunMedicineScheduleExample();
ValidateIpv4Addresses();
RunFortuneChallenge();
DisplayModuleSummary();

// ============================================================================
// METHOD DECLARATIONS
//
// A method declaration contains:
// 1. return type;
// 2. method name;
// 3. parentheses for parameters;
// 4. method body inside braces.
//
// Example:
//
// static void Example()
// {
//     // Statements executed when Example() is called.
// }
//
// `void` means the method performs an action but returns no data.
// Method names use PascalCase and usually begin with an action verb.
// ============================================================================

void DemonstrateMethodExecution()
{
    Console.WriteLine("1. Method declaration, call, and execution flow");
    Console.WriteLine("----------------------------------------------");

    // Execution begins inside DemonstrateMethodExecution().
    Console.WriteLine("Before calling SayHello().");

    // Method invocation:
    // Control temporarily moves from this location into SayHello().
    SayHello();

    // When SayHello() finishes, control returns to the statement immediately
    // following the call.
    Console.WriteLine("After calling SayHello().");
    Console.WriteLine();
}

void SayHello()
{
    // This statement runs only when SayHello() is invoked.
    Console.WriteLine("Hello World!");
}

void DisplayRandomNumbers()
{
    Console.WriteLine("2. Create and call a method");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Generating five random numbers:");

    // The loop is hidden behind a clear method name. A caller can understand
    // the task without reading its implementation first.
    for (int index = 0; index < 5; index++)
    {
        // Random.Next(minValue, maxValue) includes 1 but excludes 100,
        // producing an integer from 1 through 99.
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
    Console.WriteLine();
}

void RunMedicineScheduleExample()
{
    Console.WriteLine("3. Replace duplicated code with reusable methods");
    Console.WriteLine("-----------------------------------------------");

    // Deterministic sample values reproduce the Microsoft Learn verification
    // scenario without requiring interactive input during every repository run.
    const int currentGmt = -6;
    const int destinationGmt = 6;

    Console.WriteLine($"Current GMT: {currentGmt:+#;-#;0}");
    Console.WriteLine("Current Medicine Schedule:");
    DisplayTimes();

    Console.WriteLine($"Destination GMT: {destinationGmt:+#;-#;0}");

    // GMT offsets outside -12 through +12 are rejected before the schedule is
    // modified. `return` ends this method and returns control to its caller.
    if (Math.Abs(currentGmt) > 12 || Math.Abs(destinationGmt) > 12)
    {
        Console.WriteLine("Invalid GMT");
        Console.WriteLine();
        return;
    }

    // The destination offset minus the current offset gives the number of
    // hours that must be applied to every medicine time.
    timeZoneDifference =
        100 * (destinationGmt - currentGmt);

    AdjustTimes();

    Console.WriteLine("New Medicine Schedule:");
    DisplayTimes();
    Console.WriteLine();
}

void DisplayTimes()
{
    // This formatting logic originally appeared twice. Moving it into one
    // method removes duplication and gives one authoritative implementation.
    foreach (int value in medicineTimes)
    {
        string formattedTime = value.ToString();
        int length = formattedTime.Length;

        if (length >= 3)
        {
            // Example: "1200" becomes "12:00".
            formattedTime =
                formattedTime.Insert(length - 2, ":");
        }
        else if (length == 2)
        {
            // Example: "30" becomes "0:30".
            formattedTime =
                formattedTime.Insert(0, "0:");
        }
        else
        {
            // Example: "0" becomes "0:00".
            formattedTime =
                formattedTime.Insert(0, "0:0");
        }

        Console.Write($"{formattedTime} ");
    }

    Console.WriteLine();
}

void AdjustTimes()
{
    // This adjustment logic also appeared more than once in the starter code.
    // The method centralizes the rule so a future correction is made once.
    for (int index = 0; index < medicineTimes.Length; index++)
    {
        int shiftedTime =
            medicineTimes[index] + timeZoneDifference;

        // The first remainder constrains the magnitude. Adding 2400 before the
        // second remainder also converts negative results into 0-2399.
        medicineTimes[index] =
            ((shiftedTime % 2400) + 2400) % 2400;
    }
}

void ValidateIpv4Addresses()
{
    Console.WriteLine("4. Structure a solution with small methods");
    Console.WriteLine("------------------------------------------");

    /*
    PSEUDO-CODE

    if an IPv4 address contains exactly four numbers
    and no number contains an invalid leading zero
    and every number is between 0 and 255

    then the IPv4 address is valid
    otherwise the IPv4 address is invalid
    */

    string[] ipv4Inputs =
    {
        "107.31.1.5",
        "255.0.0.255",
        "555..0.555",
        "255...255",
        "01.2.3.4",
        "192.168.1.256"
    };

    foreach (string ipAddress in ipv4Inputs)
    {
        // Split without RemoveEmptyEntries. Empty segments are meaningful:
        // "255...255" contains missing numbers and must remain invalid.
        currentAddress =
            ipAddress.Split('.');

        // Each method is responsible for one validation rule.
        ValidateLength();
        ValidateZeroes();
        ValidateRange();

        bool isValid =
            validLength &&
            validZeroes &&
            validRange;

        Console.WriteLine(
            $"{ipAddress} is " +
            $"{(isValid ? "a valid" : "an invalid")} IPv4 address");
    }

    Console.WriteLine();
}

void ValidateLength()
{
    // A valid IPv4 address contains exactly four numeric segments.
    validLength =
        currentAddress.Length == 4;
}

void ValidateZeroes()
{
    // Start from the optimistic assumption that the rule is satisfied.
    // The method changes the result and returns immediately after detecting the
    // first invalid segment.
    validZeroes = true;

    foreach (string number in currentAddress)
    {
        bool isEmpty =
            string.IsNullOrEmpty(number);

        bool hasLeadingZero =
            number.Length > 1 &&
            number.StartsWith('0');

        if (isEmpty || hasLeadingZero)
        {
            validZeroes = false;

            // Early return:
            // No remaining segment can make the complete address valid again,
            // so continuing the loop would perform unnecessary work.
            return;
        }
    }
}

void ValidateRange()
{
    validRange = true;

    foreach (string number in currentAddress)
    {
        // TryParse avoids an exception when a segment is empty or malformed.
        bool parsed =
            int.TryParse(
                number,
                out int value);

        bool outsideIpv4Range =
            value < 0 ||
            value > 255;

        if (!parsed || outsideIpv4Range)
        {
            validRange = false;
            return;
        }
    }
}

void RunFortuneChallenge()
{
    Console.WriteLine("5. Challenge: create a reusable TellFortune method");
    Console.WriteLine("-------------------------------------------------");

    // Changing the shared luck value and calling the same method again proves
    // that the fortune-printing logic is reusable.
    luck = 90;
    TellFortune();

    luck = 50;
    TellFortune();

    luck = 10;
    TellFortune();

    Console.WriteLine();
}

void TellFortune()
{
    Console.WriteLine(
        $"Luck score: {luck}");

    Console.WriteLine(
        "A fortune teller whispers the following words:");

    // Select one array according to the current luck score.
    string[] selectedFortune =
        luck > 75
            ? goodFortunes
            : luck < 25
                ? badFortunes
                : neutralFortunes;

    // Use the array length instead of a hardcoded value such as 4.
    // Both arrays are expected to contain corresponding sentence fragments.
    for (int index = 0; index < fortunePrefixes.Length; index++)
    {
        Console.Write(
            $"{fortunePrefixes[index]} " +
            $"{selectedFortune[index]} ");
    }

    Console.WriteLine();
    Console.WriteLine();
}

void DisplayModuleSummary()
{
    Console.WriteLine("MODULE SUMMARY");
    Console.WriteLine("--------------");

    Console.WriteLine(
        "Method declaration -> defines a named task and its implementation.");

    Console.WriteLine(
        "Method invocation  -> transfers control into the method body.");

    Console.WriteLine(
        "void               -> the method performs work without returning data.");

    Console.WriteLine(
        "PascalCase         -> standard naming style for C# methods.");

    Console.WriteLine(
        "return             -> ends the current method immediately.");

    Console.WriteLine(
        "Reusable method    -> replaces duplicated logic with one implementation.");

    Console.WriteLine(
        "Pseudo-code        -> describes the solution before syntax details.");

    Console.WriteLine(
        "Small methods      -> divide one large problem into focused tasks.");
}