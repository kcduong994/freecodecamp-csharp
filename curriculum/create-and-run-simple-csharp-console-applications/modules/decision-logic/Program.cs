// Module: Add Decision Logic to Your Code Using if, else,
// and else if Statements in C#
//
// This program consolidates the final exercises from the Microsoft Learn
// module into two executable demonstrations:
//
// 1. A three-dice game that demonstrates Boolean expressions, comparison
//    operators, logical operators, nested decision concepts, and mutually
//    exclusive branches.
// 2. A subscription-renewal challenge that demonstrates how business-rule
//    precedence determines the correct order of if/else-if conditions.
//
// Detailed theory and intermediate exercise versions are documented in the
// section README. Program.cs remains focused on clear, executable examples.

// Create one Random object and reuse it throughout the application.
// Random.Next(minValue, maxValue) includes the minimum value but excludes
// the maximum value.
Random random = new();

Console.WriteLine("=== Dice game ===");

// Generate three values from 1 through 6 to simulate three six-sided dice.
int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int roll3 = random.Next(1, 7);

// The initial score is the sum of the three dice before any bonus is applied.
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// A Boolean expression returns either true or false.
//
// All three dice are equal when:
// - the first die equals the second die, AND
// - the second die equals the third die.
//
// The logical AND operator (&&) requires both comparisons to be true.
bool hasTriples =
    roll1 == roll2 &&
    roll2 == roll3;

// A doubles result exists when any pair of dice has the same value.
//
// The logical OR operator (||) requires at least one comparison to be true.
bool hasDoubles =
    roll1 == roll2 ||
    roll2 == roll3 ||
    roll1 == roll3;

// Evaluate triples before doubles.
//
// Every triple also satisfies the doubles expression. Using an if/else-if
// chain makes the branches mutually exclusive, so the bonuses cannot stack.
if (hasTriples)
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
else if (hasDoubles)
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// Display the adjusted total only when a bonus was applied.
if (hasTriples || hasDoubles)
{
    Console.WriteLine($"Your total including the bonus: {total}");
}

// The runtime evaluates this chain from top to bottom and executes only the
// first matching branch.
//
// The score thresholds are ordered from highest to lowest. This prevents a
// high score from being captured by a broader, lower-value condition.
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

Console.WriteLine();

// -------------------------------------------------------------------------
// Subscription-renewal business-rules challenge
// -------------------------------------------------------------------------

// Next(12) returns an integer from 0 through 11.
int daysUntilExpiration = random.Next(12);

// The discount starts at zero and is changed only by rules that award a
// discount. Keeping the value in a variable makes the output reusable and
// avoids repeating numeric literals in the message text.
int discountPercentage = 0;

// Business rules must be evaluated in priority order:
//
// 1. Expired subscriptions.
// 2. Subscriptions expiring in one day.
// 3. Subscriptions expiring within five days.
// 4. Subscriptions expiring within ten days.
// 5. More than ten days remaining: display no subscription message.
//
// An if/else-if chain ensures that at most one renewal message is displayed.
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;

    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;

    Console.WriteLine(
        $"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine(
        "Your subscription will expire soon. Renew now!");
}

// There is intentionally no final else block.
// When daysUntilExpiration is 11, the challenge requires no subscription
// message to be displayed.