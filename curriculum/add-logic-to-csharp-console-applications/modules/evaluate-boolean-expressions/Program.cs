/*
 * Evaluate Boolean Expressions to Make Decisions in C#
 *
 * Learning objectives:
 * - Use equality and inequality operators.
 * - Use comparison operators with numeric values.
 * - Normalize strings before comparing them.
 * - Use String methods that return Boolean values.
 * - Use the logical negation operator.
 * - Use the conditional operator.
 * - Apply Boolean expressions in decision logic.
 */

/*
 * An expression is a combination of values, variables,
 * operators, and method calls that returns a single value.
 *
 * A Boolean expression always evaluates to either:
 *
 * true
 * false
 */

// ------------------------------------------------------------
// Equality operator: ==
// ------------------------------------------------------------

// Equal string values return true.
Console.WriteLine("a" == "a");

// String comparisons are case-sensitive.
// Lowercase "a" and uppercase "A" are different values.
Console.WriteLine("a" == "A");

// Different numeric values return false.
Console.WriteLine(1 == 2);

string myValue = "a";

// The variable contains the same value as the string literal.
Console.WriteLine(myValue == "a");

/*
 * Expected output:
 *
 * True
 * False
 * False
 * True
 */

// ------------------------------------------------------------
// Normalize strings before comparing them
// ------------------------------------------------------------

/*
 * User-entered text can contain:
 *
 * - uppercase or lowercase letters;
 * - leading spaces;
 * - trailing spaces.
 *
 * Trim() removes spaces from the beginning and end.
 * ToLower() converts both strings to lowercase.
 */

string value1 = " a";
string value2 = "A ";

Console.WriteLine(
    value1.Trim().ToLower() ==
    value2.Trim().ToLower());

/*
 * Expected output:
 *
 * True
 */

// ------------------------------------------------------------
// Inequality operator: !=
// ------------------------------------------------------------

// Equal values are not unequal, so the result is false.
Console.WriteLine("a" != "a");

// Different capitalization produces different string values.
Console.WriteLine("a" != "A");

// The numbers 1 and 2 are different.
Console.WriteLine(1 != 2);

// myValue contains "a", so it is not different from "a".
Console.WriteLine(myValue != "a");

/*
 * Expected output:
 *
 * False
 * True
 * True
 * False
 */

// ------------------------------------------------------------
// Numeric comparison operators
// ------------------------------------------------------------

/*
 * Comparison operators:
 *
 * >   greater than
 * <   less than
 * >=  greater than or equal to
 * <=  less than or equal to
 */

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

/*
 * Expected output:
 *
 * False
 * True
 * True
 * True
 */

// ------------------------------------------------------------
// String methods that return Boolean values
// ------------------------------------------------------------

/*
 * Contains() returns true when the specified text exists
 * inside the source string. Otherwise, it returns false.
 */

string pangram =
    "The quick brown fox jumps over the lazy dog.";

Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

/*
 * Expected output:
 *
 * True
 * False
 */

// ------------------------------------------------------------
// Logical negation operator: !
// ------------------------------------------------------------

/*
 * Logical negation reverses a Boolean value:
 *
 * true  becomes false
 * false becomes true
 */

// These two expressions produce the same result.
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

// Negate the result returned by Contains().
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

/*
 * Expected output:
 *
 * False
 * False
 * False
 * True
 */

// ------------------------------------------------------------
// Inequality versus logical negation
// ------------------------------------------------------------

/*
 * The inequality operator != compares two values.
 *
 * The logical negation operator ! reverses one Boolean result.
 *
 * For built-in value types:
 *
 * x != y
 *
 * produces the same result as:
 *
 * !(x == y)
 */

int firstNumber = 7;
int secondNumber = 6;

Console.WriteLine(firstNumber != secondNumber);

string firstGreeting = "Hello";
string secondGreeting = "Hello";

Console.WriteLine(firstGreeting != secondGreeting);

/*
 * Expected output:
 *
 * True
 * False
 */

// ------------------------------------------------------------
// Conditional operator: ?:
// ------------------------------------------------------------

/*
 * Syntax:
 *
 * condition ? valueWhenTrue : valueWhenFalse
 *
 * Business rule:
 *
 * - A sale greater than 1000 receives a discount of 100.
 * - A sale of 1000 or less receives a discount of 50.
 */

int saleAmount = 1001;

int discount =
    saleAmount > 1000
        ? 100
        : 50;

Console.WriteLine($"Discount: {discount}");

/*
 * The conditional operator can also be used directly
 * inside an interpolated string.
 */

Console.WriteLine(
    $"Discount: {(saleAmount > 1000 ? 100 : 50)}");

/*
 * Expected output:
 *
 * Discount: 100
 * Discount: 100
 */

// ------------------------------------------------------------
// Conditional operator challenge: coin flip
// ------------------------------------------------------------

/*
 * Random.Next(0, 2) returns either:
 *
 * 0
 * 1
 *
 * The conditional operator converts the generated number
 * into either "heads" or "tails".
 */

Random coin = new Random();

int flip = coin.Next(0, 2);

Console.WriteLine(
    flip == 0
        ? "heads"
        : "tails");

/*
 * Possible output:
 *
 * heads
 *
 * or:
 *
 * tails
 */

// ------------------------------------------------------------
// Boolean expressions challenge: role-based access
// ------------------------------------------------------------

/*
 * The application evaluates:
 *
 * permission:
 * - Admin
 * - Manager
 * - another permission
 *
 * level:
 * - the user's access level
 *
 * Business rules:
 *
 * 1. Admin with level greater than 55:
 *    Welcome, Super Admin user.
 *
 * 2. Admin with level 55 or lower:
 *    Welcome, Admin user.
 *
 * 3. Manager with level 20 or greater:
 *    Contact an Admin for access.
 *
 * 4. Manager with level lower than 20:
 *    You do not have sufficient privileges.
 *
 * 5. User who is not an Admin or Manager:
 *    You do not have sufficient privileges.
 */

string permission = "Admin|Manager";
int level = 53;

/*
 * Admin is checked first because it represents the
 * highest-priority permission in the business rules.
 */
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine(
            "Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine(
            "Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine(
            "Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine(
            "You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine(
        "You do not have sufficient privileges.");
}

/*
 * Expected output with the current values:
 *
 * Welcome, Admin user.
 */