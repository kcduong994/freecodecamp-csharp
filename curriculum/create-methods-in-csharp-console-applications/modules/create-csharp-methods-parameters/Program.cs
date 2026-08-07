// ============================================================================
// Module: Create C# Methods with Parameters
// Learning path: Create Methods in C# Console Applications
//
// Purpose:
// Consolidate the principal Microsoft Learn examples into one runnable program.
// This module develops explicit data flow between a caller and a method by using
// parameters and arguments.
//
// Topics demonstrated:
// - declaring method parameters;
// - supplying positional and named arguments;
// - understanding method scope;
// - observing value-type behavior;
// - observing reference-type behavior with arrays;
// - understanding string immutability;
// - declaring optional parameters with default values;
// - combining required, optional, positional, and named arguments;
// - completing the employee email-address challenge.
//
// Important terminology:
// parameter -> variable declared in a method signature.
// argument  -> value supplied by the caller when the method is invoked.
//
// Curriculum boundary:
// This module still focuses on `void` methods. Methods that return values are
// introduced in the next module.
// ============================================================================

Console.WriteLine("CREATE C# METHODS WITH PARAMETERS");
Console.WriteLine(new string('=', 40));
Console.WriteLine();

DemonstrateBasicParameters();
DemonstrateMethodScope();
DemonstrateValueAndReferenceBehavior();
RunRsvpApplication();
RunEmailChallenge();
DisplayModuleSummary();

// ============================================================================
// 1. USE PARAMETERS IN METHODS
// ============================================================================

void DemonstrateBasicParameters()
{
    Console.WriteLine("1. Parameters and arguments");
    Console.WriteLine("---------------------------");

    int[] schedule = { 800, 1200, 1600, 2000 };

    // schedule, 6, and -6 are arguments.
    // They are received by times, currentGmt, and newGmt respectively.
    DisplayAdjustedTimes(schedule, 6, -6);

    Console.WriteLine();
}

void DisplayAdjustedTimes(int[] times, int currentGmt, int newGmt)
{
    // `times`, `currentGmt`, and `newGmt` are parameters. Their values come
    // from the caller instead of being initialized inside this method.
    if (Math.Abs(newGmt) > 12 || Math.Abs(currentGmt) > 12)
    {
        Console.WriteLine("Invalid GMT");
        return;
    }

    int difference;

    if ((newGmt <= 0 && currentGmt <= 0) ||
        (newGmt >= 0 && currentGmt >= 0))
    {
        // Same side of GMT -> subtract the absolute offsets.
        difference = 100 * (Math.Abs(newGmt) - Math.Abs(currentGmt));
    }
    else
    {
        // Opposite sides of GMT -> add the absolute offsets.
        difference = 100 * (Math.Abs(newGmt) + Math.Abs(currentGmt));
    }

    for (int index = 0; index < times.Length; index++)
    {
        int adjustedTime = (times[index] + difference) % 2400;

        // C# remainder can be negative, so normalize to the 0-2399 range.
        if (adjustedTime < 0)
        {
            adjustedTime += 2400;
        }

        Console.WriteLine($"{times[index]} -> {adjustedTime}");
    }
}

// ============================================================================
// 2. UNDERSTAND METHOD SCOPE
// ============================================================================

void DemonstrateMethodScope()
{
    Console.WriteLine("2. Method scope");
    Console.WriteLine("---------------");

    string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

    // The method parameter is also named `students`. Inside DisplayStudents(),
    // that parameter is the name visible to the method body.
    DisplayStudents(students);
    DisplayStudents(new[] { "Robert", "Vanya" });

    Console.WriteLine();

    const double pi = 3.14159;

    PrintCircleInfo(radius: 12, pi: pi);
    PrintCircleInfo(radius: 24, pi: pi);

    Console.WriteLine();
}

void DisplayStudents(string[] students)
{
    // This parameter exists only inside this method. It can have the same name
    // as a variable used by the caller because the two belong to different
    // scopes.
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }

    Console.WriteLine();
}

void PrintCircleInfo(int radius, double pi)
{
    Console.WriteLine($"Circle with radius {radius}");

    // Methods can call other methods and pass parameters farther down the flow.
    PrintCircleArea(radius, pi);
    PrintCircleCircumference(radius, pi);
}

void PrintCircleArea(int radius, double pi)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius, double pi)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

// ============================================================================
// 3. VALUE TYPES, REFERENCE TYPES, AND STRING IMMUTABILITY
// ============================================================================

void DemonstrateValueAndReferenceBehavior()
{
    Console.WriteLine("3. Value and reference type behavior");
    Console.WriteLine("------------------------------------");

    DemonstrateValueTypeCopy();
    DemonstrateArrayMutation();
    DemonstrateStringImmutability();

    Console.WriteLine();
}

void DemonstrateValueTypeCopy()
{
    int a = 3;
    int b = 4;
    int c = 0;

    Multiply(a, b, c);
    Console.WriteLine($"global statement: {a} x {b} = {c}");
    Console.WriteLine();
}

void Multiply(int a, int b, int c)
{
    // int is a value type. The method receives its own copies of a, b, and c.
    // Reassigning c therefore changes only the local parameter copy.
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

void DemonstrateArrayMutation()
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Array before Clear():");
    PrintArray(numbers);

    Clear(numbers);

    Console.WriteLine("Array after Clear():");
    PrintArray(numbers);
    Console.WriteLine();
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }

    Console.WriteLine();
}

void Clear(int[] numbers)
{
    // Arrays are reference types. In an ordinary C# method call, the parameter
    // is still passed by value, but the copied value refers to the same array
    // object. Mutating its elements is therefore visible to the caller.
    for (int index = 0; index < numbers.Length; index++)
    {
        numbers[index] = 0;
    }
}

void DemonstrateStringImmutability()
{
    string status = "Healthy";

    Console.WriteLine($"Start: {status}");
    SetHealthCopy(status, false);
    Console.WriteLine($"End after SetHealthCopy(): {status}");

    // A string is a reference type, but strings are immutable. Reassigning the
    // parameter inside SetHealthCopy() does not reassign the caller variable.
    // To demonstrate a visible mutation without using return values yet, an
    // array is used as a small mutable holder.
    string[] statusHolder = { status };

    SetHealthInArray(statusHolder, false);
    Console.WriteLine($"End after SetHealthInArray(): {statusHolder[0]}");
}

void SetHealthCopy(string status, bool isHealthy)
{
    status = isHealthy ? "Healthy" : "Unhealthy";
    Console.WriteLine($"Middle: {status}");
}

void SetHealthInArray(string[] statusHolder, bool isHealthy)
{
    statusHolder[0] = isHealthy ? "Healthy" : "Unhealthy";
}

// ============================================================================
// 4. OPTIONAL PARAMETERS AND NAMED ARGUMENTS
// ============================================================================

void RunRsvpApplication()
{
    Console.WriteLine("4. Optional parameters and named arguments");
    Console.WriteLine("------------------------------------------");

    string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
    string[] rsvps = new string[10];
    int count = 0;

    // Only the required name is supplied. The remaining values use defaults.
    RSVP("Rebecca");

    // Positional arguments can still be used.
    RSVP("Nadia", 2, "Nuts");

    // Named arguments improve readability and allow selected optional values to
    // be omitted.
    RSVP(name: "Linh", partySize: 2, inviteOnly: false);

    // Named arguments can be supplied out of their declaration order.
    RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);

    RSVP("Noor", 4, inviteOnly: false);
    RSVP("Jonte", 2, "Stone fruit", false);

    ShowRsvps();
    Console.WriteLine();

    void RSVP(
        string name,
        int partySize = 1,
        string allergies = "none",
        bool inviteOnly = true)
    {
        // Optional parameters are created by assigning default values in the
        // method signature. Required parameters should appear before them.
        if (inviteOnly)
        {
            bool found = false;

            foreach (string guest in guestList)
            {
                if (guest.Equals(name, StringComparison.Ordinal))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Sorry, {name} is not on the guest list");
                return;
            }
        }

        // Protect the fixed-size array used by this learning exercise.
        if (count >= rsvps.Length)
        {
            Console.WriteLine("RSVP storage is full.");
            return;
        }

        rsvps[count] =
            $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";

        count++;
    }

    void ShowRsvps()
    {
        Console.WriteLine();
        Console.WriteLine("Total RSVPs:");

        for (int index = 0; index < count; index++)
        {
            Console.WriteLine(rsvps[index]);
        }
    }
}

// ============================================================================
// 5. CHALLENGE: DISPLAY EMPLOYEE EMAIL ADDRESSES
// ============================================================================

void RunEmailChallenge()
{
    Console.WriteLine("5. Challenge: display email addresses");
    Console.WriteLine("-------------------------------------");

    string[,] corporate =
    {
        { "Robert", "Bavin" },
        { "Simon", "Bright" },
        { "Kim", "Sinclair" },
        { "Aashrita", "Kamath" },
        { "Sarah", "Delucchi" },
        { "Sinan", "Ali" }
    };

    string[,] external =
    {
        { "Vinnie", "Ashton" },
        { "Cody", "Dysart" },
        { "Shay", "Lawrence" },
        { "Daren", "Valdes" }
    };

    const string externalDomain = "hayworth.com";

    for (int row = 0; row < corporate.GetLength(0); row++)
    {
        // Internal employees omit the optional domain argument and therefore
        // use the default value "contoso.com".
        DisplayEmail(
            first: corporate[row, 0],
            last: corporate[row, 1]);
    }

    for (int row = 0; row < external.GetLength(0); row++)
    {
        // External employees override the optional domain parameter.
        DisplayEmail(
            first: external[row, 0],
            last: external[row, 1],
            domain: externalDomain);
    }

    Console.WriteLine();
}

void DisplayEmail(
    string first,
    string last,
    string domain = "contoso.com")
{
    // Username rule from the challenge:
    // first two characters of the first name + complete last name.
    // The provided data satisfies the two-character assumption. Math.Min keeps
    // the method safe if future input contains a shorter first name.
    int prefixLength = Math.Min(2, first.Length);

    string emailUserName =
        first[..prefixLength] +
        last;

    emailUserName = emailUserName.ToLowerInvariant();

    Console.WriteLine($"{emailUserName}@{domain}");
}

// ============================================================================
// MODULE SUMMARY
// ============================================================================

void DisplayModuleSummary()
{
    Console.WriteLine("MODULE SUMMARY");
    Console.WriteLine("--------------");

    Console.WriteLine(
        "Parameter          -> variable declared in a method signature.");

    Console.WriteLine(
        "Argument           -> value supplied when the method is called.");

    Console.WriteLine(
        "Method scope       -> region where method-local data is accessible.");

    Console.WriteLine(
        "Value type         -> the method receives its own value copy.");

    Console.WriteLine(
        "Reference type     -> a copied reference can point to the same object.");

    Console.WriteLine(
        "String             -> reference type whose value is immutable.");

    Console.WriteLine(
        "Named argument     -> identifies a supplied value by parameter name.");

    Console.WriteLine(
        "Optional parameter -> supplies a default value when omitted.");

    Console.WriteLine(
        "Explicit input     -> makes method dependencies easier to see and reuse.");
}