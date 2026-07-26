/*
 * Module:
 * Branch the Flow of Code Using the switch-case Construct in C#
 *
 * Learning objectives:
 * - Use a switch statement to compare one value with several known values.
 * - Use the case keyword to define possible matching values.
 * - Use the default keyword when no case label matches.
 * - Use break to terminate a switch section.
 * - Allow multiple case labels to execute the same section of code.
 * - Convert if-elseif-else constructs into switch statements.
 */

Console.WriteLine("BRANCH THE FLOW OF CODE USING SWITCH-CASE");
Console.WriteLine("=========================================");
Console.WriteLine();

// Run each example separately so that the complete module can be
// preserved in one Program.cs file without duplicate variable declarations.
RunFruitExample();
RunEmployeeLevelExample();
RunSkuChallenge();


/// <summary>
/// Demonstrates the basic structure of a switch statement by matching
/// a fruit name against several known values.
/// </summary>
static void RunFruitExample()
{
    Console.WriteLine("Example 1: Match a fruit name");
    Console.WriteLine("-----------------------------");

    // The value assigned to fruit is the switch expression.
    string fruit = "apple";

    // The switch statement evaluates fruit against each case label.
    switch (fruit)
    {
        // This section executes when fruit is equal to "apple".
        case "apple":
            Console.WriteLine("App will display information for apple.");
            break;

        // This section executes when fruit is equal to "banana".
        case "banana":
            Console.WriteLine("App will display information for banana.");
            break;

        // This section executes when fruit is equal to "cherry".
        case "cherry":
            Console.WriteLine("App will display information for cherry.");
            break;

        // The default section executes when none of the case labels match.
        default:
            Console.WriteLine("The selected fruit is not currently supported.");
            break;
    }

    Console.WriteLine();
}


/// <summary>
/// Demonstrates how a switch statement can assign an employee title
/// based on an employee level.
/// </summary>
static void RunEmployeeLevelExample()
{
    Console.WriteLine("Example 2: Determine an employee title");
    Console.WriteLine("--------------------------------------");

    string employeeName = "John Smith";

    // Test several employee levels to demonstrate:
    // - a normal case match;
    // - the default section;
    // - multiple case labels sharing one switch section.
    DisplayEmployeeTitle(employeeName, 200);
    DisplayEmployeeTitle(employeeName, 201);
    DisplayEmployeeTitle(employeeName, 100);

    Console.WriteLine();
}


/// <summary>
/// Determines and displays an employee title based on the employee level.
/// </summary>
/// <param name="employeeName">The employee's name.</param>
/// <param name="employeeLevel">The employee's numeric level.</param>
static void DisplayEmployeeTitle(string employeeName, int employeeLevel)
{
    // Start with an empty value.
    // The switch statement will assign the appropriate title.
    string title = "";

    switch (employeeLevel)
    {
        // Multiple case labels can share the same switch section.
        // Levels 100 and 200 receive the same employee title.
        case 100:
        case 200:
            title = "Senior Associate";
            break;

        case 300:
            title = "Manager";
            break;

        case 400:
            title = "Senior Manager";
            break;

        // The default section handles every level that is not listed above.
        default:
            title = "Associate";
            break;
    }

    Console.WriteLine(
        $"Employee: {employeeName}, Level: {employeeLevel}, Title: {title}");
}


/// <summary>
/// Completes the module challenge by converting three if-elseif-else
/// constructs into switch statements.
/// </summary>
static void RunSkuChallenge()
{
    Console.WriteLine("Challenge: Decode a product SKU");
    Console.WriteLine("-------------------------------");

    /*
     * SKU means Stock Keeping Unit.
     *
     * Expected format:
     * <product number>-<two-letter color code>-<size code>
     *
     * Example:
     * 01-MN-L
     *
     * 01 = Sweat shirt
     * MN = Maroon
     * L  = Large
     */

    string sku = "01-MN-L";

    // Split the SKU wherever a hyphen appears.
    //
    // For "01-MN-L", the resulting array contains:
    // productParts[0] = "01"
    // productParts[1] = "MN"
    // productParts[2] = "L"
    string[] productParts = sku.Split('-');

    string type = "";
    string color = "";
    string size = "";

    // Determine the product type from the first SKU component.
    switch (productParts[0])
    {
        case "01":
            type = "Sweat shirt";
            break;

        case "02":
            type = "T-Shirt";
            break;

        case "03":
            type = "Sweat pants";
            break;

        default:
            type = "Other";
            break;
    }

    // Determine the product color from the second SKU component.
    switch (productParts[1])
    {
        case "BL":
            color = "Black";
            break;

        case "MN":
            color = "Maroon";
            break;

        default:
            color = "White";
            break;
    }

    // Determine the product size from the third SKU component.
    switch (productParts[2])
    {
        case "S":
            size = "Small";
            break;

        case "M":
            size = "Medium";
            break;

        case "L":
            size = "Large";
            break;

        default:
            size = "One Size Fits All";
            break;
    }

    // Combine the decoded values into the final product description.
    Console.WriteLine($"SKU: {sku}");
    Console.WriteLine($"Product: {size} {color} {type}");
}