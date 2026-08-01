using System.Globalization;
using System.Text;

/*
 * Module:
 * Convert Data Types Using Casting and Conversion Techniques in C#
 *
 * Purpose:
 * - Distinguish implicit conversion, explicit casting, and helper-method conversion.
 * - Recognize conversions that can throw exceptions or lose information.
 * - Compare truncation with rounding.
 * - Convert values to and from strings.
 * - Use TryParse() and out parameters for safe numeric conversion.
 * - Complete both Microsoft Learn coding challenges.
 *
 * The original lesson contains many separate code fragments that reuse the same
 * variable names. This version organizes those fragments into focused methods so
 * that the entire lesson remains executable as one coherent console application.
 */

internal static class Program
{
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        WriteApplicationHeader();

        DemonstrateCompilerConversionRules();
        DemonstrateWideningConversion();
        DemonstrateExplicitCasting();
        DemonstratePrecisionLoss();
        DemonstrateToString();
        DemonstrateParse();
        DemonstrateConvertClass();
        CompareCastingAndConvert();
        DemonstrateTryParse();
        RunMixedStringArrayChallenge();
        RunSpecificNumberTypeChallenge();

        WriteModuleSummary();
    }

    /// <summary>
    /// Displays the module title and the two questions that should be considered
    /// before choosing a conversion technique.
    /// </summary>
    private static void WriteApplicationHeader()
    {
        Console.WriteLine(
            "CONVERT DATA TYPES USING CASTING AND CONVERSION TECHNIQUES IN C#");
        Console.WriteLine(
            "==============================================================");
        Console.WriteLine();

        Console.WriteLine("Before converting a value, ask:");
        Console.WriteLine(
            "1. Could this conversion throw an exception at run time?");
        Console.WriteLine(
            "2. Could this conversion lose range, precision, or other information?");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Shows why the compiler allows number-to-string concatenation but does not
    /// automatically interpret an arbitrary string as a number.
    /// </summary>
    private static void DemonstrateCompilerConversionRules()
    {
        WriteSectionHeader(
            "1. Compiler conversion rules: concatenation is not addition");

        /*
         * This intentionally invalid example is retained as a comment because it
         * demonstrates compiler error CS0029 without breaking the executable file.
         *
         * int first = 2;
         * string second = "4";
         * int result = first + second;
         *
         * Error:
         * Cannot implicitly convert type 'string' to 'int'.
         *
         * The compiler cannot assume that every string contains valid numeric text.
         * The value might later be "hello", which cannot be converted to an int.
         */

        int firstNumber = 2;
        string secondText = "4";

        /*
         * When one operand of + is a string, C# performs string concatenation.
         * The number 2 is represented as text and joined with "4".
         *
         * This operation is valid, but the result "24" is text rather than the
         * mathematical sum 6.
         */
        string concatenatedResult = firstNumber + secondText;

        Console.WriteLine($"Number value            : {firstNumber}");
        Console.WriteLine($"String value            : \"{secondText}\"");
        Console.WriteLine($"Concatenated result     : \"{concatenatedResult}\"");
        Console.WriteLine(
            "Important               : \"24\" is text, not numeric addition.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates an implicit widening conversion from int to decimal.
    /// </summary>
    private static void DemonstrateWideningConversion()
    {
        WriteSectionHeader("2. Implicit widening conversion");

        int integerValue = 3;

        /*
         * decimal can represent every possible int value, so this conversion does
         * not lose the original whole-number information.
         *
         * Because the conversion is safe, the compiler performs it implicitly.
         */
        decimal decimalValue = integerValue;

        Console.WriteLine($"int value               : {integerValue}");
        Console.WriteLine($"decimal value           : {decimalValue}");
        Console.WriteLine(
            "Conversion              : implicit because information is preserved");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates explicit casting from decimal to int.
    /// </summary>
    private static void DemonstrateExplicitCasting()
    {
        WriteSectionHeader("3. Explicit cast and narrowing conversion");

        decimal decimalValue = 3.14M;

        /*
         * int cannot store a fractional component. The conversion may therefore
         * lose information, so the compiler requires an explicit cast.
         *
         * Writing (int) communicates that the loss is understood and intentional.
         */
        int integerValue = (int)decimalValue;

        Console.WriteLine($"Original decimal        : {decimalValue}");
        Console.WriteLine($"Casted int              : {integerValue}");
        Console.WriteLine(
            "Fractional information  : removed by the cast");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Shows that narrowing conversion can lose precision even when both source
    /// and destination types support fractional values.
    /// </summary>
    private static void DemonstratePrecisionLoss()
    {
        WriteSectionHeader("4. Precision loss: decimal to float");

        decimal highPrecisionValue = 1.23456789M;

        /*
         * float generally preserves fewer significant digits than decimal.
         * The explicit cast is required because the destination type cannot retain
         * all information represented by the source type.
         */
        float reducedPrecisionValue = (float)highPrecisionValue;

        Console.WriteLine($"decimal                 : {highPrecisionValue}");
        Console.WriteLine($"float                   : {reducedPrecisionValue:R}");
        Console.WriteLine(
            "Observation             : the final digits are not preserved exactly");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Uses ToString() to intentionally create textual representations of numbers.
    /// </summary>
    private static void DemonstrateToString()
    {
        WriteSectionHeader("5. Convert numbers to text with ToString()");

        int firstNumber = 5;
        int secondNumber = 7;

        /*
         * ToString() returns a string representation of each integer.
         * The + operator then joins the strings, producing "57".
         */
        string message =
            firstNumber.ToString(CultureInfo.InvariantCulture) +
            secondNumber.ToString(CultureInfo.InvariantCulture);

        Console.WriteLine($"First number             : {firstNumber}");
        Console.WriteLine($"Second number            : {secondNumber}");
        Console.WriteLine($"Text result              : \"{message}\"");
        Console.WriteLine(
            "Operation               : string concatenation");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Uses Parse() when the source strings are known to be valid numeric text.
    /// </summary>
    private static void DemonstrateParse()
    {
        WriteSectionHeader("6. Convert valid numeric text with Parse()");

        string firstText = "5";
        string secondText = "7";

        /*
         * Parse() returns the requested numeric type.
         *
         * It is appropriate only when invalid input is impossible or when the
         * application deliberately handles the possible exception.
         */
        int sum =
            int.Parse(firstText, CultureInfo.InvariantCulture) +
            int.Parse(secondText, CultureInfo.InvariantCulture);

        Console.WriteLine($"Parsed expression       : {firstText} + {secondText}");
        Console.WriteLine($"Numeric result          : {sum}");

        /*
         * The following code is intentionally not executed:
         *
         * string invalidText = "Bob";
         * int invalidNumber = int.Parse(invalidText);
         *
         * It would throw FormatException because "Bob" is not a valid integer.
         * For user input, file data, or external data, TryParse() is usually safer.
         */

        WriteSectionSeparator();
    }

    /// <summary>
    /// Uses methods on System.Convert to convert values between common types.
    /// </summary>
    private static void DemonstrateConvertClass()
    {
        WriteSectionHeader("7. Convert values with the Convert class");

        string firstText = "5";
        string secondText = "7";

        /*
         * Convert.ToInt32() uses the .NET type name Int32 because Convert belongs to
         * the .NET Class Library. The C# keyword int is an alias for System.Int32.
         */
        int product =
            Convert.ToInt32(firstText, CultureInfo.InvariantCulture) *
            Convert.ToInt32(secondText, CultureInfo.InvariantCulture);

        Console.WriteLine($"Converted expression    : {firstText} × {secondText}");
        Console.WriteLine($"Numeric result          : {product}");
        Console.WriteLine(
            "Recommendation          : prefer TryParse() for untrusted string input");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Compares the truncation performed by an explicit cast with the rounding
    /// performed by Convert.ToInt32().
    /// </summary>
    private static void CompareCastingAndConvert()
    {
        WriteSectionHeader("8. Casting truncates; Convert.ToInt32() rounds");

        decimal sourceValue = 1.5M;

        /*
         * Casting from decimal to int discards the fractional component.
         * It does not round to the nearest integer.
         */
        int castResult = (int)sourceValue;

        /*
         * Convert.ToInt32(decimal) rounds to the nearest integer.
         *
         * Technical detail:
         * exact midpoint values use midpoint-to-even rounding. For example,
         * 2.5 becomes 2 and 3.5 becomes 4. This behavior reduces systematic bias
         * across many rounding operations.
         */
        int convertedResult = Convert.ToInt32(sourceValue);

        Console.WriteLine($"Source decimal          : {sourceValue}");
        Console.WriteLine($"Explicit cast result    : {castResult}");
        Console.WriteLine($"Convert.ToInt32 result  : {convertedResult}");

        decimal largerFraction = 1.999M;
        decimal smallerFraction = 1.499M;

        Console.WriteLine();
        Console.WriteLine(
            $"(int){largerFraction}              : {(int)largerFraction}");
        Console.WriteLine(
            $"Convert.ToInt32({smallerFraction}) : " +
            $"{Convert.ToInt32(smallerFraction)}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates successful and unsuccessful TryParse() operations, including
    /// the use of an out parameter and the parsed value outside the if statement.
    /// </summary>
    private static void DemonstrateTryParse()
    {
        WriteSectionHeader("9. Safely convert strings with TryParse()");

        const int measurementOffset = 50;

        string validText = "102";
        int parsedMeasurement;

        /*
         * TryParse() performs three related actions:
         * 1. Attempts the conversion.
         * 2. Stores the converted value in the out parameter when successful.
         * 3. Returns true or false to report success or failure.
         *
         * parsedMeasurement is declared outside the if statement because the value
         * is also needed after the conditional block.
         */
        bool conversionSucceeded =
            int.TryParse(
                validText,
                NumberStyles.Integer,
                CultureInfo.InvariantCulture,
                out parsedMeasurement);

        if (conversionSucceeded)
        {
            Console.WriteLine($"Measurement             : {parsedMeasurement}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        if (parsedMeasurement > 0)
        {
            Console.WriteLine(
                $"Measurement with offset : " +
                $"{measurementOffset + parsedMeasurement}");
        }

        Console.WriteLine();

        string invalidText = "bad";

        bool invalidConversionSucceeded =
            int.TryParse(
                invalidText,
                NumberStyles.Integer,
                CultureInfo.InvariantCulture,
                out int invalidResult);

        if (invalidConversionSucceeded)
        {
            Console.WriteLine($"Measurement             : {invalidResult}");
        }
        else
        {
            Console.WriteLine(
                $"Input \"{invalidText}\"          : unable to parse as int");
        }

        /*
         * invalidResult receives int's default value, 0, when parsing fails.
         * Business logic should still rely on the returned bool rather than treating
         * 0 alone as proof that conversion failed, because "0" is valid numeric text.
         */
        Console.WriteLine($"Failure out value       : {invalidResult}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Challenge 1:
    /// Adds numeric array values and concatenates non-numeric values.
    /// </summary>
    private static void RunMixedStringArrayChallenge()
    {
        WriteSectionHeader(
            "10. Challenge: combine string values as text and numbers");

        string[] values =
        {
            "12.3",
            "45",
            "ABC",
            "11",
            "DEF"
        };

        decimal numericTotal = 0M;
        string textMessage = string.Empty;

        foreach (string value in values)
        {
            /*
             * Each array item begins as a string.
             *
             * If it can be parsed as decimal, add it to the numeric total.
             * Otherwise, treat it as alphabetic text and append it to the message.
             */
            bool isNumeric =
                decimal.TryParse(
                    value,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out decimal numericValue);

            if (isNumeric)
            {
                numericTotal += numericValue;
            }
            else
            {
                textMessage += value;
            }
        }

        Console.WriteLine($"Message                 : {textMessage}");
        Console.WriteLine(
            $"Total                   : " +
            $"{numericTotal.ToString(CultureInfo.InvariantCulture)}");

        Console.WriteLine();
        Console.WriteLine("Expected:");
        Console.WriteLine("Message: ABCDEF");
        Console.WriteLine("Total: 68.3");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Challenge 2:
    /// Produces division results using the specific output types required by the
    /// exercise.
    /// </summary>
    private static void RunSpecificNumberTypeChallenge()
    {
        WriteSectionHeader(
            "11. Challenge: output operations as specific number types");

        int value1 = 11;
        decimal value2 = 6.2M;
        float value3 = 4.3F;

        /*
         * result1 must be int and must be rounded rather than truncated.
         *
         * value1 / value2 produces decimal because decimal participates in the
         * expression. Convert.ToInt32() then rounds the decimal result.
         */
        int result1 = Convert.ToInt32(value1 / value2);

        /*
         * C# does not allow decimal and float to be divided directly.
         * Casting value3 to decimal gives both operands a compatible type and keeps
         * result2 as decimal.
         */
        decimal result2 = value2 / (decimal)value3;

        /*
         * value3 is float. The int operand can be converted to float implicitly, so
         * the result of this division is float.
         */
        float result3 = value3 / value1;

        Console.WriteLine(
            "Divide value1 by value2, display the result as an int: " +
            result1);

        Console.WriteLine(
            "Divide value2 by value3, display the result as a decimal: " +
            result2.ToString(CultureInfo.InvariantCulture));

        Console.WriteLine(
            "Divide value3 by value1, display the result as a float: " +
            result3.ToString(CultureInfo.InvariantCulture));

        WriteSectionSeparator();
    }

    /// <summary>
    /// Prints the final decision guide for selecting a conversion technique.
    /// </summary>
    private static void WriteModuleSummary()
    {
        Console.WriteLine("MODULE SUMMARY");
        Console.WriteLine("--------------");

        Console.WriteLine(
            "Implicit conversion : use when the destination safely represents " +
            "the source value.");

        Console.WriteLine(
            "Explicit cast       : use when information may be lost and that " +
            "loss is intentional.");

        Console.WriteLine(
            "ToString()           : convert a value to its textual representation.");

        Console.WriteLine(
            "Parse()              : use for numeric text known to be valid.");

        Console.WriteLine(
            "TryParse()           : use for user, file, or external text that may " +
            "be invalid.");

        Console.WriteLine(
            "Convert              : use a .NET conversion helper, especially when " +
            "rounding is required.");

        Console.WriteLine();
        Console.WriteLine(
            "Always consider both exception risk and information loss.");
    }

    /// <summary>
    /// Writes a consistent heading for each executable lesson section.
    /// </summary>
    private static void WriteSectionHeader(string title)
    {
        Console.WriteLine(title);
        Console.WriteLine(new string('-', title.Length));
    }

    /// <summary>
    /// Separates lesson sections in the console output.
    /// </summary>
    private static void WriteSectionSeparator()
    {
        Console.WriteLine();
        Console.WriteLine(new string('=', 62));
        Console.WriteLine();
    }
}