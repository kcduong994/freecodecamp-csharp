// ============================================================================
// Module: Perform Basic Operations on Numbers in C#
// Learning path: Write Your First Code Using C#
//
// This module demonstrates:
// 1. Addition and string concatenation.
// 2. Implicit numeric type conversion.
// 3. Addition, subtraction, multiplication, and division.
// 4. Integer division and decimal division.
// 5. Explicit type casting.
// 6. The remainder (modulus) operator.
// 7. Operator precedence.
// 8. Compound assignment, increment, and decrement operators.
// 9. Prefix and postfix increment behavior.
// 10. Converting Fahrenheit to Celsius.
// ============================================================================

Console.WriteLine("==================================================");
Console.WriteLine("PERFORM BASIC OPERATIONS ON NUMBERS IN C#");
Console.WriteLine("==================================================");
Console.WriteLine();


// ============================================================================
// SECTION 1: ADDITION AND IMPLICIT DATA CONVERSION
// ============================================================================

Console.WriteLine("1. Addition and implicit data conversion");
Console.WriteLine("-----------------------------------------");


// Add two integer values.
//
// Both operands are of type int, so the result is also an int.
int firstNumber = 12;
int secondNumber = 7;
int additionResult = firstNumber + secondNumber;

Console.WriteLine($"Addition result: {additionResult}");
// Output:
// Addition result: 19

Console.WriteLine();


// Mix string and integer values.
//
// The + operator has more than one purpose in C#:
//
// - It performs numeric addition when both operands are numeric.
// - It performs string concatenation when at least one operand is a string.
//
// When widgetsSold is combined with a string, C# implicitly converts its value
// to its string representation before concatenating the values.
string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// Output:
// Bob sold 7 widgets.

Console.WriteLine();


// Demonstrate left-to-right evaluation during string concatenation.
//
// C# evaluates operators of the same precedence from left to right.
//
// Evaluation occurs as follows:
//
// 1. firstName + " sold " produces a string.
// 2. That string is concatenated with widgetsSold.
// 3. The resulting string is concatenated with the integer literal 7.
//
// Therefore, the two numeric values are not added together. Instead, their
// text representations are placed next to each other, producing "77".
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// Output:
// Bob sold 77 widgets.

Console.WriteLine();


// Use parentheses to explicitly request numeric addition.
//
// Parentheses have the highest priority in this expression. Therefore,
// widgetsSold + 7 is evaluated before the result is concatenated with
// the surrounding strings.
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// Output:
// Bob sold 14 widgets.

Console.WriteLine();


// Important:
// The + operator is overloaded.
//
// Operator overloading means that the same operator can perform different
// operations depending on the data types of its operands.
//
// Examples:
//
// int + int       -> numeric addition
// string + string -> string concatenation
// string + int    -> the int is converted to text, then concatenated


// ============================================================================
// SECTION 2: BASIC ARITHMETIC OPERATIONS
// ============================================================================

Console.WriteLine("2. Basic arithmetic operations");
Console.WriteLine("------------------------------");


// Perform addition, subtraction, multiplication, and integer division.
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int integerQuotient = 7 / 5;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Integer quotient: {integerQuotient}");

// Output:
// Sum: 12
// Difference: 2
// Product: 35
// Integer quotient: 1

Console.WriteLine();


// INTEGER DIVISION
//
// When both operands of the / operator are integers, C# performs integer
// division. Any fractional part of the result is discarded.
//
// The mathematical result of 7 / 5 is 1.4.
// However, int cannot store the fractional part, so the result is 1.
//
// More precisely, integer division truncates the result toward zero.
Console.WriteLine($"7 / 5 using int operands: {7 / 5}");
// Output:
// 7 / 5 using int operands: 1

Console.WriteLine();


// ============================================================================
// SECTION 3: DECIMAL DIVISION
// ============================================================================

Console.WriteLine("3. Decimal division");
Console.WriteLine("-------------------");


// To preserve the fractional part, at least one operand must be a floating-
// point type such as decimal, double, or float.
//
// The suffix m (or M) marks a numeric literal as a decimal value.
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine($"Decimal quotient: {decimalQuotient}");
// Output:
// Decimal quotient: 1.4

Console.WriteLine();


// These expressions all perform decimal division because at least one operand
// is of type decimal.
decimal quotientWithDecimalDividend = 7.0m / 5;
decimal quotientWithDecimalDivisor = 7 / 5.0m;
decimal quotientWithBothDecimalOperands = 7.0m / 5.0m;

Console.WriteLine(
    $"Decimal dividend: {quotientWithDecimalDividend}"
);

Console.WriteLine(
    $"Decimal divisor: {quotientWithDecimalDivisor}"
);

Console.WriteLine(
    $"Both decimal operands: {quotientWithBothDecimalOperands}"
);

// Output:
// Decimal dividend: 1.4
// Decimal divisor: 1.4
// Both decimal operands: 1.4

Console.WriteLine();


// The following examples do not compile because a decimal result cannot be
// implicitly assigned to an int variable.
//
// Converting decimal to int could discard the fractional part, so C# requires
// an explicit conversion.
//
// int invalidQuotientA = 7 / 5.0m;
// int invalidQuotientB = 7.0m / 5;
// int invalidQuotientC = 7.0m / 5.0m;


// This expression compiles, but it does not produce 1.4.
//
// The division is completed before the result is assigned to the decimal
// variable. Because both operands are int, 7 / 5 performs integer division
// and produces 1. That integer is then implicitly converted to decimal.
decimal decimalAfterIntegerDivision = 7 / 5;

Console.WriteLine(
    $"Decimal variable after integer division: {decimalAfterIntegerDivision}"
);
// Output:
// Decimal variable after integer division: 1

Console.WriteLine();


// ============================================================================
// SECTION 4: EXPLICIT TYPE CASTING
// ============================================================================

Console.WriteLine("4. Explicit type casting");
Console.WriteLine("------------------------");


// A cast temporarily instructs the compiler to treat a value as another
// compatible data type.
//
// Here, dividend and divisor are both int variables. Casting one operand to
// decimal is sufficient because the other int operand is then implicitly
// converted to decimal for the division operation.
int dividend = 7;
int divisor = 5;

decimal castQuotient = (decimal)dividend / divisor;

Console.WriteLine($"Quotient after casting: {castQuotient}");
// Output:
// Quotient after casting: 1.4

Console.WriteLine();


// Casting both operands is also valid, although casting one operand is enough.
decimal castBothOperandsQuotient =
    (decimal)dividend / (decimal)divisor;

Console.WriteLine(
    $"Quotient after casting both operands: {castBothOperandsQuotient}"
);
// Output:
// Quotient after casting both operands: 1.4

Console.WriteLine();


// ============================================================================
// SECTION 5: REMAINDER (MODULUS) OPERATOR
// ============================================================================

Console.WriteLine("5. Remainder operator");
Console.WriteLine("---------------------");


// The % operator returns the remainder after division.
//
// It does not return the quotient.
//
// Examples:
//
// 200 / 5 = 40 with a remainder of 0.
// 7 / 5   = 1  with a remainder of 2.
int firstRemainder = 200 % 5;
int secondRemainder = 7 % 5;

Console.WriteLine($"Remainder of 200 / 5: {firstRemainder}");
Console.WriteLine($"Remainder of 7 / 5: {secondRemainder}");

// Output:
// Remainder of 200 / 5: 0
// Remainder of 7 / 5: 2

Console.WriteLine();


// When the remainder is zero, the dividend is evenly divisible by the divisor.
int numberToCheck = 200;
int possibleDivisor = 5;

bool isEvenlyDivisible =
    numberToCheck % possibleDivisor == 0;

Console.WriteLine(
    $"{numberToCheck} is evenly divisible by {possibleDivisor}: " +
    $"{isEvenlyDivisible}"
);
// Output:
// 200 is evenly divisible by 5: True

Console.WriteLine();


// A common practical use of the remainder operator is detecting intervals.
//
// For example, an application processing thousands of records could display
// progress whenever the number of processed records is divisible by 100.
int processedRecords = 500;

bool shouldReportProgress =
    processedRecords % 100 == 0;

Console.WriteLine(
    $"Report progress after {processedRecords} records: " +
    $"{shouldReportProgress}"
);
// Output:
// Report progress after 500 records: True

Console.WriteLine();


// ============================================================================
// SECTION 6: ORDER OF OPERATIONS
// ============================================================================

Console.WriteLine("6. Order of operations");
Console.WriteLine("----------------------");


// C# follows the standard mathematical order of operations:
//
// 1. Parentheses
// 2. Multiplication, division, and remainder, from left to right
// 3. Addition and subtraction, from left to right
//
// PEMDAS is a common mnemonic:
//
// P: Parentheses
// E: Exponents
// M: Multiplication
// D: Division
// A: Addition
// S: Subtraction
//
// Note:
// C# does not use ^ as an exponentiation operator. The ^ operator performs
// bitwise exclusive OR. Exponentiation is normally performed with Math.Pow().


// Multiplication is performed before addition:
//
// 3 + 4 * 5
// 3 + 20
// 23
int valueWithoutParentheses = 3 + 4 * 5;


// Parentheses force addition to occur first:
//
// (3 + 4) * 5
// 7 * 5
// 35
int valueWithParentheses = (3 + 4) * 5;

Console.WriteLine(
    $"Without parentheses: {valueWithoutParentheses}"
);

Console.WriteLine(
    $"With parentheses: {valueWithParentheses}"
);

// Output:
// Without parentheses: 23
// With parentheses: 35

Console.WriteLine();


// ============================================================================
// SECTION 7: COMPOUND ASSIGNMENT OPERATORS
// ============================================================================

Console.WriteLine("7. Compound assignment operators");
Console.WriteLine("--------------------------------");


// A compound assignment operator performs an operation and assigns the result
// back to the same variable.
//
// The following two statements are equivalent:
//
// value = value + 5;
// value += 5;
int accumulatedValue = 0;

Console.WriteLine(
    $"Initial accumulated value: {accumulatedValue}"
);

accumulatedValue = accumulatedValue + 5;

Console.WriteLine(
    $"After value = value + 5: {accumulatedValue}"
);

accumulatedValue += 5;

Console.WriteLine(
    $"After value += 5: {accumulatedValue}"
);

// Output:
// Initial accumulated value: 0
// After value = value + 5: 5
// After value += 5: 10

Console.WriteLine();


// Other common compound assignment operators include:
//
// -=  subtract and assign
// *=  multiply and assign
// /=  divide and assign
// %=  calculate the remainder and assign


// ============================================================================
// SECTION 8: INCREMENT AND DECREMENT
// ============================================================================

Console.WriteLine("8. Increment and decrement");
Console.WriteLine("--------------------------");


// The ++ operator increases a variable by 1.
//
// The following statements are equivalent:
//
// value = value + 1;
// value += 1;
// value++;
//
// The -- operator similarly decreases a variable by 1.
int counter = 1;

counter = counter + 1;
Console.WriteLine($"First increment: {counter}");
// Output:
// First increment: 2

counter += 1;
Console.WriteLine($"Second increment: {counter}");
// Output:
// Second increment: 3

counter++;
Console.WriteLine($"Third increment: {counter}");
// Output:
// Third increment: 4

counter = counter - 1;
Console.WriteLine($"First decrement: {counter}");
// Output:
// First decrement: 3

counter -= 1;
Console.WriteLine($"Second decrement: {counter}");
// Output:
// Second decrement: 2

counter--;
Console.WriteLine($"Third decrement: {counter}");
// Output:
// Third decrement: 1

Console.WriteLine();


// ============================================================================
// SECTION 9: PREFIX AND POSTFIX INCREMENT
// ============================================================================

Console.WriteLine("9. Prefix and postfix increment");
Console.WriteLine("-------------------------------");


// The position of ++ or -- matters when the expression's value is used.
//
// Postfix increment:
//
// value++
//
// 1. Returns the current value.
// 2. Increments the variable afterward.
//
// Prefix increment:
//
// ++value
//
// 1. Increments the variable first.
// 2. Returns the new value.
int positionValue = 1;


// This increment is a standalone statement, so its prefix/postfix position
// does not affect another expression.
positionValue++;

Console.WriteLine($"First: {positionValue}");
// Output:
// First: 2


// Postfix increment returns 2 to Console.WriteLine, then increases the stored
// value to 3.
Console.WriteLine($"Second: {positionValue++}");
// Output:
// Second: 2


// The previous postfix increment has now taken effect.
Console.WriteLine($"Third: {positionValue}");
// Output:
// Third: 3


// Prefix increment increases the stored value to 4 before Console.WriteLine
// receives it.
Console.WriteLine($"Fourth: {++positionValue}");
// Output:
// Fourth: 4

Console.WriteLine();


// ============================================================================
// SECTION 10: CHALLENGE — CONVERT FAHRENHEIT TO CELSIUS
// ============================================================================

Console.WriteLine("10. Fahrenheit-to-Celsius challenge");
Console.WriteLine("-----------------------------------");


// Formula:
//
// Celsius = (Fahrenheit - 32) × 5 / 9
//
// The decimal literals 5m and 9m ensure that the division preserves the
// fractional part.
//
// Using 5 / 9 without decimal operands would perform integer division:
//
// 5 / 9 = 0
//
// That would make the entire Celsius calculation incorrectly equal to zero.
int fahrenheit = 94;

decimal celsius =
    (fahrenheit - 32) * 5m / 9m;


// The $ character enables string interpolation.
//
// The format specifier F1 displays the decimal value with exactly one digit
// after the decimal point.
Console.WriteLine(
    $"The temperature is {celsius:F1} Celsius."
);
// Output:
// The temperature is 34.4 Celsius.

Console.WriteLine();


// ============================================================================
// MODULE SUMMARY
// ============================================================================

Console.WriteLine("==================================================");
Console.WriteLine("MODULE SUMMARY");
Console.WriteLine("==================================================");

Console.WriteLine(
    "1. Use +, -, *, and / for basic arithmetic."
);

Console.WriteLine(
    "2. Integer division discards the fractional part."
);

Console.WriteLine(
    "3. Use decimal operands to preserve decimal precision."
);

Console.WriteLine(
    "4. Use an explicit cast when dividing int variables as decimals."
);

Console.WriteLine(
    "5. Use % to obtain the remainder after division."
);

Console.WriteLine(
    "6. Use parentheses to control the order of operations."
);

Console.WriteLine(
    "7. Use += and -= for compound assignment."
);

Console.WriteLine(
    "8. Use ++ and -- to increment or decrement a value by one."
);

Console.WriteLine(
    "9. Prefix operators modify before returning; postfix operators return " +
    "before modifying."
);