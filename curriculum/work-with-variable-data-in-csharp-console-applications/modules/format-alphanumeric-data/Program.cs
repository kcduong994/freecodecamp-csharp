using System.Globalization;
using System.Text;

/*
 * Module:
 * Format Alphanumeric Data for Presentation in C#
 *
 * Purpose:
 * - Format text with escape sequences, Unicode, and verbatim string literals.
 * - Compare composite formatting with string interpolation.
 * - Format currency, numbers, percentages, and decimal precision.
 * - Explain how culture affects displayed values.
 * - Align and pad text for receipts, reports, and fixed-width legacy files.
 * - Complete the personalized investment-marketing letter challenge.
 *
 * Design:
 * The Microsoft Learn lesson contains many independent code fragments that reuse
 * variable names such as first, second, result, price, and formattedLine.
 * This version places each lesson unit in a focused method so that the complete
 * module compiles and runs as one coherent console application.
 *
 * Important principle:
 * Formatting creates a textual representation for presentation. It does not
 * modify the underlying numeric value used by the application.
 */

internal static class Program
{
    private static readonly CultureInfo UsCulture =
        CultureInfo.GetCultureInfo("en-US");

    private static readonly CultureInfo FrenchCulture =
        CultureInfo.GetCultureInfo("fr-FR");

    private static readonly CultureInfo KoreanCulture =
        CultureInfo.GetCultureInfo("ko-KR");

    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        WriteApplicationHeader();

        DemonstrateEscapeSequences();
        DemonstrateVerbatimStringsAndUnicode();
        DemonstrateCompositeFormatting();
        DemonstrateStringInterpolation();
        DemonstrateCurrencyAndCulture();
        DemonstrateNumericAndPercentageFormatting();
        DemonstrateCombinedFormattingApproaches();
        DemonstrateInterpolatedInvoiceReceipt();
        DemonstratePaddingAndAlignment();
        DemonstrateFixedWidthPaymentRecord();
        RunMarketingLetterChallenge();

        WriteModuleSummary();
    }

    /// <summary>
    /// Displays the module title and its principal learning goals.
    /// </summary>
    private static void WriteApplicationHeader()
    {
        Console.WriteLine(
            "FORMAT ALPHANUMERIC DATA FOR PRESENTATION IN C#");
        Console.WriteLine(
            "================================================");
        Console.WriteLine();

        Console.WriteLine("Learning goals:");
        Console.WriteLine("- Format strings with special characters.");
        Console.WriteLine("- Merge text templates with runtime values.");
        Console.WriteLine("- Format currency, numbers, and percentages.");
        Console.WriteLine("- Align text with padding and fixed-width columns.");
        Console.WriteLine("- Build a personalized financial marketing letter.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates common C# character escape sequences.
    /// </summary>
    private static void DemonstrateEscapeSequences()
    {
        WriteSectionHeader("1. Character escape sequences");

        /*
         * Escape sequences begin with a backslash and represent characters that
         * would otherwise be difficult or ambiguous to place in a string literal.
         *
         * \n  → new line
         * \t  → horizontal tab
         * \\  → one backslash
         * \"  → one double-quotation mark
         */
        Console.WriteLine("New-line example:");
        Console.WriteLine("Coastal model\nSimulation report");

        Console.WriteLine();
        Console.WriteLine("Tab example:");
        Console.WriteLine("Station\tWater level\tSalinity");
        Console.WriteLine("Hoa Binh\t1.425 m\t\t15.114 ppt");

        Console.WriteLine();
        Console.WriteLine("Backslash example:");
        Console.WriteLine(
            "Project path: C:\\Projects\\CSharp\\Formatting");

        Console.WriteLine();
        Console.WriteLine("Quotation-mark example:");
        Console.WriteLine(
            "The application printed: \"Build succeeded.\"");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates verbatim string literals and Unicode escape sequences.
    /// </summary>
    private static void DemonstrateVerbatimStringsAndUnicode()
    {
        WriteSectionHeader("2. Verbatim strings and Unicode");

        /*
         * The @ prefix creates a verbatim string literal.
         *
         * Backslashes are treated as ordinary characters, which makes verbatim
         * strings especially useful for Windows file-system paths.
         */
        string repositoryPath =
            @"F:\DarkerThanBack-DKC\My world\Programs\Github\freecodecamp-csharp";

        Console.WriteLine("Verbatim Windows path:");
        Console.WriteLine(repositoryPath);

        /*
         * A quotation mark inside a verbatim string is represented by two
         * quotation marks.
         */
        string verbatimQuotation =
            @"The terminal displayed ""Build succeeded."".";

        Console.WriteLine();
        Console.WriteLine("Quotation inside a verbatim string:");
        Console.WriteLine(verbatimQuotation);

        /*
         * Unicode escape sequences use \u followed by four hexadecimal digits.
         * They make the intended code point explicit in source code.
         */
        string degreeSymbol = "\u00B0";
        string deltaSymbol = "\u0394";
        string greetingInJapanese =
            "\u3053\u3093\u306B\u3061\u306F";

        Console.WriteLine();
        Console.WriteLine($"Temperature: 25{degreeSymbol}C");
        Console.WriteLine($"{deltaSymbol}t = 10 seconds");
        Console.WriteLine($"Unicode greeting: {greetingInJapanese}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates numbered replacement tokens with composite formatting.
    /// </summary>
    private static void DemonstrateCompositeFormatting()
    {
        WriteSectionHeader("3. Composite formatting");

        string firstWord = "Hello";
        string secondWord = "World";

        /*
         * Composite formatting uses numbered replacement tokens.
         *
         * {0} refers to the first value supplied after the template.
         * {1} refers to the second value supplied after the template.
         *
         * Token numbering starts at zero, which is consistent with array and
         * collection indexing in C#.
         */
        string formattedGreeting =
            string.Format(
                CultureInfo.InvariantCulture,
                "{0} {1}!",
                firstWord,
                secondWord);

        Console.WriteLine(formattedGreeting);

        /*
         * Replacement tokens can be reordered.
         */
        Console.WriteLine(
            string.Format(
                CultureInfo.InvariantCulture,
                "{1} {0}!",
                firstWord,
                secondWord));

        /*
         * A token can be reused, and an extra argument can remain unused.
         */
        Console.WriteLine(
            string.Format(
                CultureInfo.InvariantCulture,
                "{0} {0} {0}!",
                firstWord,
                secondWord));

        Console.WriteLine();
        Console.WriteLine(
            "Observation: composite formatting matches arguments by numeric index.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates string interpolation as a more readable alternative to
    /// composite formatting in many common situations.
    /// </summary>
    private static void DemonstrateStringInterpolation()
    {
        WriteSectionHeader("4. String interpolation");

        string firstWord = "Hello";
        string secondWord = "World";

        /*
         * The $ prefix enables interpolation.
         *
         * Variable names and expressions are written directly inside braces,
         * which removes the need to match numbered tokens with a separate list
         * of arguments.
         */
        Console.WriteLine($"{firstWord} {secondWord}!");
        Console.WriteLine($"{secondWord} {firstWord}!");
        Console.WriteLine($"{firstWord} {firstWord} {firstWord}!");

        string stationName = "Hoa Binh";
        decimal waterLevelMeters = 1.425M;
        decimal salinityPpt = 15.114M;

        Console.WriteLine();
        Console.WriteLine(
            $"Station {stationName} measured a water level of " +
            $"{waterLevelMeters} m and salinity of {salinityPpt} ppt.");

        Console.WriteLine();
        Console.WriteLine(
            "Recommendation: prefer interpolation when it improves readability.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates currency formatting and the effect of culture.
    /// </summary>
    private static void DemonstrateCurrencyAndCulture()
    {
        WriteSectionHeader("5. Currency formatting and culture");

        decimal price = 123.45M;
        int discount = 50;

        /*
         * The C format specifier represents currency.
         *
         * The displayed symbol, decimal separator, grouping separator, and symbol
         * position depend on the selected culture. The numeric values themselves
         * are unchanged.
         */
        Console.WriteLine(
            $"Current culture ({CultureInfo.CurrentCulture.Name}):");

        Console.WriteLine(
            $"Price: {price:C} (Save {discount:C})");

        Console.WriteLine();
        Console.WriteLine("Explicit en-US formatting:");
        Console.WriteLine(
            string.Format(
                UsCulture,
                "Price: {0:C2} (Save {1:C2})",
                price,
                discount));

        Console.WriteLine();
        Console.WriteLine("Explicit fr-FR formatting:");
        Console.WriteLine(
            string.Format(
                FrenchCulture,
                "Price: {0:C2} (Save {1:C2})",
                price,
                discount));

        Console.WriteLine();
        Console.WriteLine("Explicit ko-KR formatting:");
        Console.WriteLine(
            string.Format(
                KoreanCulture,
                "Price: {0:C0} (Save {1:C0})",
                price,
                discount));

        Console.WriteLine();
        Console.WriteLine(
            "Observation: culture changes presentation, not the stored values.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates numeric grouping, decimal precision, fixed-point formatting,
    /// and percentage formatting.
    /// </summary>
    private static void DemonstrateNumericAndPercentageFormatting()
    {
        WriteSectionHeader("6. Number and percentage format specifiers");

        decimal measurement = 123456.78912M;
        decimal taxRate = 0.36785M;
        decimal salinityPpt = 15.11427M;
        int computationalCellCount = 1_250_000;

        /*
         * N formats a number with group separators.
         * The number following N controls the displayed decimal places.
         */
        Console.WriteLine(
            $"Measurement with N2: " +
            $"{measurement.ToString("N2", UsCulture)} units");

        Console.WriteLine(
            $"Measurement with N4: " +
            $"{measurement.ToString("N4", UsCulture)} units");

        Console.WriteLine(
            $"Cell count with N0 : " +
            $"{computationalCellCount.ToString("N0", UsCulture)}");

        /*
         * P multiplies the stored fractional value by 100 for display and appends
         * the culture-specific percent symbol.
         *
         * The stored value remains 0.36785M.
         */
        Console.WriteLine(
            $"Tax rate with P2   : " +
            $"{taxRate.ToString("P2", UsCulture)}");

        /*
         * F uses fixed-point notation without thousands separators.
         */
        Console.WriteLine(
            $"Salinity with F2   : " +
            $"{salinityPpt.ToString("F2", UsCulture)} ppt");

        Console.WriteLine();
        Console.WriteLine($"Stored tax value        : {taxRate}");
        Console.WriteLine(
            $"Formatted tax text      : " +
            $"{taxRate.ToString("P2", UsCulture)}");

        Console.WriteLine();
        Console.WriteLine(
            "Observation: formatting creates text and does not change taxRate.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates combining composite formatting and interpolation in one
    /// business message.
    /// </summary>
    private static void DemonstrateCombinedFormattingApproaches()
    {
        WriteSectionHeader("7. Combine formatting approaches");

        decimal regularPrice = 67.55M;
        decimal salePrice = 59.99M;

        decimal amountSaved =
            regularPrice - salePrice;

        decimal discountRate =
            amountSaved / regularPrice;

        /*
         * Composite formatting creates the first part of the message.
         */
        string discountMessage =
            string.Format(
                UsCulture,
                "You saved {0:C2} off the regular {1:C2} price. ",
                amountSaved,
                regularPrice);

        /*
         * Interpolation appends the calculated percentage.
         *
         * Parentheses ensure the complete arithmetic expression is evaluated
         * before P2 formatting is applied.
         */
        discountMessage +=
            $"A discount of " +
            $"{discountRate.ToString("P2", UsCulture)}!";

        Console.WriteLine(discountMessage);

        WriteSectionSeparator();
    }

    /// <summary>
    /// Produces the investment-product receipt from the lesson.
    /// </summary>
    private static void DemonstrateInterpolatedInvoiceReceipt()
    {
        WriteSectionHeader("8. Interpolated investment receipt");

        int invoiceNumber = 1201;
        decimal productShares = 25.4568M;
        decimal subtotal = 2750.00M;
        decimal taxPercentage = 0.15825M;
        decimal total = 3185.19M;

        /*
         * N3 displays shares with one-thousandth precision.
         * C2 displays currency with two decimal places.
         * P2 displays the fractional tax value as a percentage.
         *
         * Explicit en-US formatting is used so this educational output matches
         * the sample regardless of the operating system's regional settings.
         */
        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine(
            $"   Shares: " +
            $"{productShares.ToString("N3", UsCulture)} Product");

        Console.WriteLine(
            $"     Sub Total: " +
            $"{subtotal.ToString("C2", UsCulture)}");

        Console.WriteLine(
            $"           Tax: " +
            $"{taxPercentage.ToString("P2", UsCulture)}");

        Console.WriteLine(
            $"     Total Billed: " +
            $"{total.ToString("C2", UsCulture)}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates PadLeft(), PadRight(), custom padding characters, and
    /// interpolation-based alignment components.
    /// </summary>
    private static void DemonstratePaddingAndAlignment()
    {
        WriteSectionHeader("9. Padding and alignment");

        string input = "Pad this";

        /*
         * PadLeft(totalWidth) adds leading spaces until the total string length
         * reaches totalWidth.
         *
         * PadRight(totalWidth) adds trailing spaces.
         */
        Console.WriteLine(
            "PadLeft(12) : |" +
            input.PadLeft(12) +
            "|");

        Console.WriteLine(
            "PadRight(12): |" +
            input.PadRight(12) +
            "|");

        /*
         * These overloaded versions use '-' instead of a blank space.
         */
        Console.WriteLine(
            $"Custom left    : |{input.PadLeft(12, '-')}|");

        Console.WriteLine(
            $"Custom right   : |{input.PadRight(12, '-')}|");

        Console.WriteLine();
        Console.WriteLine("Interpolation alignment:");

        string stationName = "Hoa Binh";
        decimal waterLevelMeters = 1.425M;
        decimal salinityPpt = 15.114M;

        /*
         * Alignment syntax:
         *
         * {value,positiveWidth} → right-aligned
         * {value,negativeWidth} → left-aligned
         *
         * Format specifiers can be combined with alignment.
         */
        Console.WriteLine(
            $"{"Station",-15}" +
            $"{"Water level",12}" +
            $"{"Salinity",12}");

        Console.WriteLine(
            $"{stationName,-15}" +
            $"{waterLevelMeters,12:F3}" +
            $"{salinityPpt,12:F2}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Builds a fixed-width legacy payment record using PadRight() and PadLeft().
    /// </summary>
    private static void DemonstrateFixedWidthPaymentRecord()
    {
        WriteSectionHeader("10. Fixed-width legacy payment record");

        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        /*
         * Required column layout:
         *
         * Columns  1–6  → Payment ID, left-aligned
         * Columns  7–30 → Payee name, left-aligned
         * Columns 31–40 → Amount, right-aligned
         */
        string formattedLine =
            paymentId.PadRight(6);

        formattedLine +=
            payeeName.PadRight(24);

        formattedLine +=
            paymentAmount.PadLeft(10);

        const string columnGuide =
            "1234567890123456789012345678901234567890";

        Console.WriteLine(columnGuide);
        Console.WriteLine(formattedLine);
        Console.WriteLine(
            $"Record length: {formattedLine.Length} characters");

        Console.WriteLine();
        Console.WriteLine(
            "Observation: fixed-width files depend on exact character positions.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Completes the personalized financial marketing-letter challenge.
    /// </summary>
    private static void RunMarketingLetterChallenge()
    {
        WriteSectionHeader(
            "11. Challenge: personalized investment marketing letter");

        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2_975_000;
        decimal currentReturn = 0.1275M;
        decimal currentProfit = 55_000_000.0M;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125M;
        decimal newProfit = 63_000_000.0M;

        /*
         * Explicit en-US formatting is used because the official expected output
         * contains the dollar symbol, comma grouping, a period decimal separator,
         * and two decimal places.
         */
        Console.WriteLine($"Dear {customerName},");

        Console.WriteLine(
            $"As a customer of our {currentProduct} offering we are excited " +
            "to tell you about a new financial product that would dramatically " +
            "increase your return.");

        Console.WriteLine();

        Console.WriteLine(
            $"Currently, you own " +
            $"{currentShares.ToString("N2", UsCulture)} shares at a return of " +
            $"{currentReturn.ToString("P2", UsCulture)}.");

        Console.WriteLine();

        Console.WriteLine(
            $"Our new product, {newProduct} offers a return of " +
            $"{newReturn.ToString("P2", UsCulture)}.  " +
            "Given your current volume, your potential profit would be " +
            $"{newProfit.ToString("C2", UsCulture)}.");

        Console.WriteLine();
        Console.WriteLine("Here's a quick comparison:");
        Console.WriteLine();

        /*
         * The comparison table is intentionally built step by step to demonstrate:
         *
         * - PadRight()
         * - composite formatting through string.Format()
         * - percentage and currency format specifiers
         * - string concatenation with +=
         */
        string comparisonMessage =
            currentProduct.PadRight(20);

        comparisonMessage +=
            string.Format(
                UsCulture,
                "{0:P2}",
                currentReturn)
            .PadRight(10);

        comparisonMessage +=
            string.Format(
                UsCulture,
                "{0:C2}",
                currentProfit)
            .PadRight(20);

        comparisonMessage += Environment.NewLine;

        comparisonMessage +=
            newProduct.PadRight(20);

        comparisonMessage +=
            string.Format(
                UsCulture,
                "{0:P2}",
                newReturn)
            .PadRight(10);

        comparisonMessage +=
            string.Format(
                UsCulture,
                "{0:C2}",
                newProfit)
            .PadRight(20);

        Console.WriteLine(comparisonMessage);

        WriteSectionSeparator();
    }

    /// <summary>
    /// Prints the final conceptual summary.
    /// </summary>
    private static void WriteModuleSummary()
    {
        Console.WriteLine("MODULE SUMMARY");
        Console.WriteLine("--------------");

        Console.WriteLine(
            "Escape sequences     : represent tabs, new lines, quotes, and " +
            "special characters.");

        Console.WriteLine(
            "Verbatim strings     : preserve backslashes and simplify paths.");

        Console.WriteLine(
            "Composite formatting : uses numbered replacement tokens.");

        Console.WriteLine(
            "String interpolation : places variables and expressions directly " +
            "inside a template.");

        Console.WriteLine(
            "C, N, P, and F        : format currency, grouped numbers, " +
            "percentages, and fixed-point values.");

        Console.WriteLine(
            "PadLeft/PadRight      : align text in fixed-width fields.");

        Console.WriteLine();
        Console.WriteLine(
            "Formatting changes presentation, not the underlying data value.");
        Console.WriteLine(
            "Culture must be selected deliberately when output must be stable.");
    }

    /// <summary>
    /// Writes a consistent heading for each lesson section.
    /// </summary>
    private static void WriteSectionHeader(string title)
    {
        Console.WriteLine(title);
        Console.WriteLine(
            new string(
                '-',
                title.Length));
    }

    /// <summary>
    /// Separates lesson sections in the console output.
    /// </summary>
    private static void WriteSectionSeparator()
    {
        Console.WriteLine();
        Console.WriteLine(
            new string(
                '=',
                64));
        Console.WriteLine();
    }
}