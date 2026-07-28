/*
 * Module:
 * Add Looping Logic to Your Code Using the do-while and while Statements in C#
 *
 * Learning objectives:
 * - Use do-while when the loop body must execute at least once.
 * - Use while when the Boolean condition must be checked before the loop body.
 * - Use continue to skip the remainder of the current iteration.
 * - Distinguish continue from break.
 * - Validate nullable console input safely.
 * - Convert text input to integers with int.TryParse().
 * - Combine for, while, do-while, if, and string-processing methods.
 *
 * Loop selection:
 * - for: known or controlled iteration count.
 * - foreach: read each element in a collection.
 * - do-while: condition checked after the body; executes one or more times.
 * - while: condition checked before the body; executes zero or more times.
 */

Console.WriteLine("ADD LOOPING LOGIC USING DO-WHILE AND WHILE STATEMENTS");
Console.WriteLine("=====================================================");
Console.WriteLine();

DisplayLoopComparison();
RunDoWhileRandomExample();
RunWhileRandomExample();
RunContinueExample();
RunBattleChallenge();
RunIntegerInputChallenge();
RunRoleInputChallenge();
RunSentenceProcessingChallenge();


/// <summary>
/// Displays the purpose of each C# iteration statement covered so far.
/// </summary>
static void DisplayLoopComparison()
{
    WriteSectionHeader("Loop comparison");

    Console.WriteLine("for      : initializer + condition + iterator.");
    Console.WriteLine("foreach  : processes each collection element.");
    Console.WriteLine("do-while : executes the body one or more times.");
    Console.WriteLine("while    : executes the body zero or more times.");
    Console.WriteLine();
}


/// <summary>
/// Demonstrates that do-while executes its body before evaluating its
/// continuation condition.
/// </summary>
static void RunDoWhileRandomExample()
{
    WriteSectionHeader(
        "Example 1: do-while generates numbers until 7 appears");

    Random random = new();
    int current = 0;

    do
    {
        /*
         * Random.Next(1, 11) can generate 1 through 10.
         * The lower bound is inclusive and the upper bound is exclusive.
         */
        current = random.Next(1, 11);
        Console.WriteLine(current);

        /*
         * The value produced inside the loop controls whether another
         * iteration is required.
         */
    }
    while (current != 7);

    /*
     * The semicolon after the while condition is required in do-while syntax.
     * The final printed value is always 7 because that value makes
     * current != 7 evaluate to false.
     */
    Console.WriteLine("The loop stopped because 7 was generated.");
    Console.WriteLine();
}


/// <summary>
/// Demonstrates that while evaluates its condition before entering the body.
/// </summary>
static void RunWhileRandomExample()
{
    WriteSectionHeader(
        "Example 2: while runs only while the number is at least 3");

    Random random = new();
    int current = random.Next(1, 11);

    /*
     * If current starts as 1 or 2, the condition is false and this body runs
     * zero times. If it starts as 3 through 10, the loop continues until a
     * newly generated value is below 3.
     */
    while (current >= 3)
    {
        Console.WriteLine(current);
        current = random.Next(1, 11);
    }

    /*
     * This statement is outside the loop, so it always executes.
     * The final value is 1 or 2 because that value ended the loop.
     */
    Console.WriteLine($"Last number: {current}");
    Console.WriteLine();
}


/// <summary>
/// Demonstrates how continue skips the remaining statements in the current
/// iteration without terminating the loop.
/// </summary>
static void RunContinueExample()
{
    WriteSectionHeader(
        "Example 3: continue skips values greater than or equal to 8");

    Random random = new();
    int current = 0;

    do
    {
        current = random.Next(1, 11);

        /*
         * Values 8, 9, and 10 transfer control directly to the loop condition.
         * Console.WriteLine() is skipped only for the current iteration.
         */
        if (current >= 8)
        {
            continue;
        }

        Console.WriteLine(current);
    }
    while (current != 7);

    /*
     * continue differs from break:
     * - continue ends only the current iteration;
     * - break terminates the entire loop.
     */
    Console.WriteLine(
        "Values 8, 9, and 10 were skipped; 7 ended the loop.");
    Console.WriteLine();
}


/// <summary>
/// Implements the hero-versus-monster battle challenge.
/// </summary>
static void RunBattleChallenge()
{
    WriteSectionHeader("Challenge 1: Hero versus monster");

    const int StartingHealth = 10;
    const int MinimumAttack = 1;
    const int AttackUpperBoundExclusive = 11;

    int heroHealth = StartingHealth;
    int monsterHealth = StartingHealth;
    Random dice = new();

    /*
     * do-while is suitable because the hero must attack first.
     * The battle therefore requires at least one pass through the body.
     */
    do
    {
        int damage = dice.Next(
            MinimumAttack,
            AttackUpperBoundExclusive);

        monsterHealth -= damage;

        Console.WriteLine(
            $"Monster was damaged and lost {damage} health " +
            $"and now has {monsterHealth} health.");

        /*
         * A defeated monster cannot attack.
         * continue transfers control to the condition, which then becomes
         * false because monsterHealth is zero or less.
         */
        if (monsterHealth <= 0)
        {
            continue;
        }

        damage = dice.Next(
            MinimumAttack,
            AttackUpperBoundExclusive);

        heroHealth -= damage;

        Console.WriteLine(
            $"Hero was damaged and lost {damage} health " +
            $"and now has {heroHealth} health.");
    }
    while (heroHealth > 0 && monsterHealth > 0);

    Console.WriteLine(
        monsterHealth <= 0
            ? "Hero wins!"
            : "Monster wins!");

    Console.WriteLine();
}


/// <summary>
/// Validates an integer from 5 through 10, inclusive.
/// </summary>
static void RunIntegerInputChallenge()
{
    WriteSectionHeader(
        "Challenge 2: Validate an integer from 5 through 10");

    int acceptedValue = 0;
    bool isValidNumber;

    Console.WriteLine(
        "Enter an integer value between 5 and 10:");

    do
    {
        /*
         * Console.ReadLine() returns string?.
         * It can return entered text or null when no input is available.
         */
        string? readResult = Console.ReadLine();

        /*
         * TryParse avoids conversion exceptions.
         *
         * Success:
         * - acceptedValue receives the integer;
         * - isValidNumber becomes true.
         *
         * Failure:
         * - acceptedValue receives 0;
         * - isValidNumber becomes false.
         */
        isValidNumber = int.TryParse(
            readResult,
            out acceptedValue);

        if (!isValidNumber)
        {
            Console.WriteLine(
                "Sorry, you entered an invalid number. " +
                "Please try again.");
            continue;
        }

        /*
         * The range is inclusive, so 5 and 10 are valid.
         * Only values below 5 or above 10 are rejected.
         */
        if (acceptedValue < 5 || acceptedValue > 10)
        {
            isValidNumber = false;

            Console.WriteLine(
                $"You entered {acceptedValue}. " +
                "Please enter a number between 5 and 10.");
        }
    }
    while (!isValidNumber);

    Console.WriteLine(
        $"Your input value ({acceptedValue}) has been accepted.");
    Console.WriteLine();
}


/// <summary>
/// Validates Administrator, Manager, or User while ignoring outer spaces and
/// letter casing.
/// </summary>
static void RunRoleInputChallenge()
{
    WriteSectionHeader("Challenge 3: Validate a role name");

    string roleName = string.Empty;
    bool isValidRole;

    do
    {
        Console.WriteLine(
            "Enter your role name " +
            "(Administrator, Manager, or User):");

        string? readResult = Console.ReadLine();

        /*
         * ?? supplies an empty string when the input is null.
         * Trim() removes leading and trailing whitespace.
         */
        roleName = (readResult ?? string.Empty).Trim();

        /*
         * Normalize once rather than calling ToLower() repeatedly.
         * ToLowerInvariant() avoids culture-dependent keyword matching.
         */
        string normalizedRole = roleName.ToLowerInvariant();

        isValidRole =
            normalizedRole == "administrator" ||
            normalizedRole == "manager" ||
            normalizedRole == "user";

        if (!isValidRole)
        {
            Console.WriteLine(
                $"The role name that you entered, \"{roleName}\", " +
                "is not valid.");
        }
    }
    while (!isValidRole);

    Console.WriteLine(
        $"Your input value ({roleName}) has been accepted.");
    Console.WriteLine();
}


/// <summary>
/// Extracts individual sentences from each string in an array.
/// </summary>
static void RunSentenceProcessingChallenge()
{
    WriteSectionHeader(
        "Challenge 4: Extract sentences from a string array");

    string[] myStrings =
    {
        "I like pizza. I like roast chicken. I like salad",
        "I like all three of the menu choices"
    };

    /*
     * The outer for loop selects each array element by index.
     * myString is a modifiable working copy; the original array is unchanged.
     */
    for (int index = 0; index < myStrings.Length; index++)
    {
        string myString = myStrings[index];

        /*
         * IndexOf(".") returns the first period location or -1 when there is
         * no period.
         */
        int periodLocation = myString.IndexOf(".");

        /*
         * while is correct because a string may contain no period.
         * In that case, the body should execute zero times.
         */
        while (periodLocation != -1)
        {
            /*
             * Remove(periodLocation) returns the text before the period and
             * excludes the period itself.
             */
            string mySentence = myString.Remove(periodLocation);

            /*
             * Substring(periodLocation + 1) keeps the remaining text after
             * the period. Adding 1 moves past the period character.
             */
            myString = myString.Substring(periodLocation + 1);

            /*
             * TrimStart() removes spaces before the next sentence.
             */
            myString = myString.TrimStart();

            /*
             * Search the shortened string again before the next condition
             * evaluation.
             */
            periodLocation = myString.IndexOf(".");

            Console.WriteLine(mySentence);
        }

        /*
         * When no periods remain, myString contains the final sentence.
         * If the original string had no period, it contains the full string.
         */
        string finalSentence = myString.Trim();

        if (finalSentence.Length > 0)
        {
            Console.WriteLine(finalSentence);
        }
    }

    Console.WriteLine();
}


/// <summary>
/// Writes a consistent heading before each example.
/// </summary>
/// <param name="title">The heading displayed in the console.</param>
static void WriteSectionHeader(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
}