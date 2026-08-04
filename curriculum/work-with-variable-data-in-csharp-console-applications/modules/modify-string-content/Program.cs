// ============================================================================
// Module: Modify the Content of Strings Using Built-In String Data Type Methods
// Section: Work with Variable Data in C# Console Applications
//
// Purpose:
// Preserve the principal Microsoft Learn examples as one runnable application.
// The examples demonstrate how to locate, extract, remove, and replace content
// in strings by using IndexOf(), LastIndexOf(), IndexOfAny(), Substring(),
// Remove(), and Replace().
//
// Important:
// System.String is immutable. None of these helper methods changes the existing
// string object. Each operation returns a new string, which must be stored or
// used by the application.
// ============================================================================

PrintApplicationHeader();

DemonstrateIndexOfAndSubstring();
DemonstrateLastIndexOfAndRepeatedExtraction();
DemonstrateIndexOfAny();
DemonstrateRemoveAndReplace();
CompleteHtmlChallenge();

PrintModuleSummary();

static void PrintApplicationHeader()
{
    Console.WriteLine(
        "MODIFY THE CONTENT OF STRINGS USING BUILT-IN STRING METHODS");
    Console.WriteLine(new string('=', 62));
    Console.WriteLine();
}

static void DemonstrateIndexOfAndSubstring()
{
    PrintSectionHeader("1. IndexOf() and Substring()");

    const string message = "Find what is (inside the parentheses)";

    // IndexOf() returns a zero-based character position.
    // The first character is at index 0, not index 1.
    int openingPosition = message.IndexOf('(');
    int closingPosition = message.IndexOf(')');

    Console.WriteLine($"Message: {message}");
    Console.WriteLine($"Opening parenthesis index: {openingPosition}");
    Console.WriteLine($"Closing parenthesis index: {closingPosition}");

    // Always verify search results before using them as Substring() boundaries.
    // IndexOf() returns -1 when the requested character or text is not found.
    if (openingPosition == -1 ||
        closingPosition == -1 ||
        closingPosition <= openingPosition)
    {
        Console.WriteLine("A valid parenthesis pair was not found.");
        Console.WriteLine();
        return;
    }

    // Starting at openingPosition includes the opening parenthesis.
    // The calculated length stops immediately before the closing parenthesis.
    int lengthIncludingOpeningParenthesis =
        closingPosition - openingPosition;

    string textIncludingOpeningParenthesis = message.Substring(
        openingPosition,
        lengthIncludingOpeningParenthesis);

    Console.WriteLine(
        $"Including the opening parenthesis: " +
        $"{textIncludingOpeningParenthesis}");

    // Move one character beyond '(' to exclude the delimiter itself.
    int contentStart = openingPosition + 1;
    int contentLength = closingPosition - contentStart;

    string parenthesizedContent = message.Substring(
        contentStart,
        contentLength);

    Console.WriteLine(
        $"Content between parentheses: {parenthesizedContent}");

    Console.WriteLine();
    Console.WriteLine("Extract text between HTML-style tags");

    const string taggedMessage =
        "What is the value <span>between the tags</span>?";

    // Constants prevent repeated "magic strings". Using openSpan.Length also
    // prevents an incorrect hardcoded offset if the opening tag later changes.
    const string openSpan = "<span>";
    const string closeSpan = "</span>";

    int openingTagPosition = taggedMessage.IndexOf(openSpan);
    int closingTagPosition = taggedMessage.IndexOf(closeSpan);

    if (openingTagPosition == -1 ||
        closingTagPosition == -1 ||
        closingTagPosition <= openingTagPosition)
    {
        Console.WriteLine("A valid <span> element was not found.");
        Console.WriteLine();
        return;
    }

    int taggedContentStart = openingTagPosition + openSpan.Length;
    int taggedContentLength = closingTagPosition - taggedContentStart;

    string taggedContent = taggedMessage.Substring(
        taggedContentStart,
        taggedContentLength);

    Console.WriteLine($"Message: {taggedMessage}");
    Console.WriteLine($"Extracted value: {taggedContent}");
    Console.WriteLine();
}

static void DemonstrateLastIndexOfAndRepeatedExtraction()
{
    PrintSectionHeader("2. LastIndexOf() and repeated extraction");

    const string greeting = "hello there!";

    int firstHPosition = greeting.IndexOf('h');
    int lastHPosition = greeting.LastIndexOf('h');

    Console.WriteLine(
        $"For the message '{greeting}', the first 'h' is at position " +
        $"{firstHPosition} and the last 'h' is at position {lastHPosition}.");

    Console.WriteLine();
    Console.WriteLine("Extract the content from the last parenthesis pair");

    const string lastPairMessage =
        "(What if) I am (only interested) in the last " +
        "(set of parentheses)?";

    int lastOpeningPosition = lastPairMessage.LastIndexOf('(');
    int lastClosingPosition = lastPairMessage.LastIndexOf(')');

    if (lastOpeningPosition == -1 ||
        lastClosingPosition == -1 ||
        lastClosingPosition <= lastOpeningPosition)
    {
        Console.WriteLine("A valid final parenthesis pair was not found.");
    }
    else
    {
        int lastContentStart = lastOpeningPosition + 1;
        int lastContentLength = lastClosingPosition - lastContentStart;

        string lastParenthesizedContent = lastPairMessage.Substring(
            lastContentStart,
            lastContentLength);

        Console.WriteLine(lastParenthesizedContent);
    }

    Console.WriteLine();
    Console.WriteLine("Extract every parenthesized value");

    string remainingMessage =
        "(What if) there are (more than) one (set of parentheses)?";

    while (true)
    {
        int openingPosition = remainingMessage.IndexOf('(');

        // No opening delimiter remains, so all available pairs were processed.
        if (openingPosition == -1)
        {
            break;
        }

        // Begin searching for ')' after the located '('.
        // This avoids accidentally selecting an earlier closing delimiter.
        int closingPosition = remainingMessage.IndexOf(
            ')',
            openingPosition + 1);

        // Stop safely when an opening delimiter has no matching close.
        if (closingPosition == -1)
        {
            Console.WriteLine(
                "Stopped: an opening parenthesis has no matching close.");
            break;
        }

        int contentStart = openingPosition + 1;
        int contentLength = closingPosition - contentStart;

        Console.WriteLine(
            remainingMessage.Substring(contentStart, contentLength));

        // Substring(startIndex) returns all remaining characters from the
        // supplied index. The original string is not modified; a new string is
        // assigned to remainingMessage for the next iteration.
        remainingMessage = remainingMessage.Substring(closingPosition + 1);
    }

    Console.WriteLine();
}

static void DemonstrateIndexOfAny()
{
    PrintSectionHeader("3. IndexOfAny()");

    const string vowelMessage = "Hello, world!";
    char[] vowelsToFind = { 'a', 'e', 'i' };

    // IndexOfAny() returns the position of the first occurrence of any
    // character contained in the supplied char array.
    int vowelPosition = vowelMessage.IndexOfAny(vowelsToFind);

    if (vowelPosition == -1)
    {
        Console.WriteLine("None of the requested characters was found.");
    }
    else
    {
        Console.WriteLine(
            $"Found '{vowelMessage[vowelPosition]}' in '{vowelMessage}' " +
            $"at index {vowelPosition}.");
    }

    Console.WriteLine();
    Console.WriteLine("Use the start-position overload");

    const string openingSymbolMessage =
        "Help (find) the {opening symbols}";

    char[] openingSymbols = { '[', '{', '(' };
    const int startPosition = 5;

    int firstOpeningPosition =
        openingSymbolMessage.IndexOfAny(openingSymbols);

    int openingAfterStartPosition =
        openingSymbolMessage.IndexOfAny(openingSymbols, startPosition);

    Console.WriteLine($"Message: {openingSymbolMessage}");

    if (firstOpeningPosition != -1)
    {
        Console.WriteLine(
            "Without a start position: " +
            openingSymbolMessage.Substring(firstOpeningPosition));
    }

    if (openingAfterStartPosition != -1)
    {
        Console.WriteLine(
            $"Starting at index {startPosition}: " +
            openingSymbolMessage.Substring(openingAfterStartPosition));
    }

    Console.WriteLine();
    Console.WriteLine("Match several opening and closing symbol types");

    const string mixedSymbolMessage =
        "(What if) I have [different symbols] but every {open symbol} " +
        "needs a [matching closing symbol]?";

    int searchPosition = 0;

    while (true)
    {
        int openingPosition = mixedSymbolMessage.IndexOfAny(
            openingSymbols,
            searchPosition);

        if (openingPosition == -1)
        {
            break;
        }

        // Substring(openingPosition, 1) creates a one-character string that can
        // be evaluated by the switch statement used in the original lesson.
        string currentOpeningSymbol = mixedSymbolMessage.Substring(
            openingPosition,
            1);

        char matchingClosingSymbol;

        switch (currentOpeningSymbol)
        {
            case "[":
                matchingClosingSymbol = ']';
                break;

            case "{":
                matchingClosingSymbol = '}';
                break;

            case "(":
                matchingClosingSymbol = ')';
                break;

            default:
                // This branch should not execute because IndexOfAny() searches
                // only for the three known opening symbols.
                Console.WriteLine(
                    $"Unsupported opening symbol: {currentOpeningSymbol}");
                searchPosition = openingPosition + 1;
                continue;
        }

        int contentStart = openingPosition + 1;

        int closingPosition = mixedSymbolMessage.IndexOf(
            matchingClosingSymbol,
            contentStart);

        if (closingPosition == -1)
        {
            Console.WriteLine(
                $"No matching '{matchingClosingSymbol}' was found for " +
                $"'{currentOpeningSymbol}' at index {openingPosition}.");
            break;
        }

        int contentLength = closingPosition - contentStart;

        Console.WriteLine(
            mixedSymbolMessage.Substring(contentStart, contentLength));

        // Continue after the matched closing symbol so the next iteration does
        // not examine an already processed segment.
        searchPosition = closingPosition + 1;
    }

    Console.WriteLine();
}

static void DemonstrateRemoveAndReplace()
{
    PrintSectionHeader("4. Remove() and Replace()");

    const string fixedWidthData =
        "12345John Smith          5000  3  ";

    // The legacy record uses fixed-width fields:
    // indexes 0-4   : customer identifier
    // indexes 5-24  : customer name (20 characters)
    // remaining data: invoice amount and item count
    //
    // Remove(startIndex, count) returns a new string without the selected
    // character range.
    string dataWithoutCustomerName = fixedWidthData.Remove(5, 20);

    Console.WriteLine($"Original fixed-width data: '{fixedWidthData}'");
    Console.WriteLine(
        $"After removing the name:   '{dataWithoutCustomerName}'");

    Console.WriteLine();
    Console.WriteLine("Replace repeated separators");

    string hyphenatedMessage = "This--is--ex-amp-le--da-ta";

    // Replace() changes every occurrence, not merely the first occurrence.
    // First convert double hyphens into spaces, then remove remaining single
    // hyphens by replacing them with String.Empty.
    string normalizedMessage = hyphenatedMessage.Replace("--", " ");
    normalizedMessage = normalizedMessage.Replace("-", string.Empty);

    Console.WriteLine($"Original: {hyphenatedMessage}");
    Console.WriteLine($"Updated : {normalizedMessage}");
    Console.WriteLine();
}

static void CompleteHtmlChallenge()
{
    PrintSectionHeader("5. Challenge: extract, replace, and remove HTML data");

    const string input =
        "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

    const string openSpan = "<span>";
    const string closeSpan = "</span>";
    const string openDiv = "<div>";
    const string closeDiv = "</div>";
    const string tradeSymbol = "&trade;";
    const string registeredSymbol = "&reg;";

    int spanOpeningPosition = input.IndexOf(openSpan);
    int spanClosingPosition = input.IndexOf(closeSpan);

    if (spanOpeningPosition == -1 ||
        spanClosingPosition == -1 ||
        spanClosingPosition <= spanOpeningPosition)
    {
        Console.WriteLine("Quantity: unavailable");
        Console.WriteLine("Output: unavailable");
        Console.WriteLine();
        return;
    }

    // Add openSpan.Length so extraction begins immediately after <span>.
    int quantityStart = spanOpeningPosition + openSpan.Length;
    int quantityLength = spanClosingPosition - quantityStart;
    string quantity = input.Substring(quantityStart, quantityLength);

    // Replace the entity first. Replace() returns a new string because strings
    // are immutable.
    string output = input.Replace(tradeSymbol, registeredSymbol);

    int openingDivPosition = output.IndexOf(openDiv);

    if (openingDivPosition != -1)
    {
        output = output.Remove(openingDivPosition, openDiv.Length);
    }

    int closingDivPosition = output.IndexOf(closeDiv);

    if (closingDivPosition != -1)
    {
        output = output.Remove(closingDivPosition, closeDiv.Length);
    }

    Console.WriteLine($"Quantity: {quantity}");
    Console.WriteLine($"Output: {output}");
    Console.WriteLine();
}

static void PrintModuleSummary()
{
    PrintSectionHeader("MODULE SUMMARY");

    Console.WriteLine(
        "IndexOf()     -> returns the first matching position or -1.");
    Console.WriteLine(
        "LastIndexOf() -> returns the final matching position or -1.");
    Console.WriteLine(
        "IndexOfAny()  -> finds the first occurrence of any supplied char.");
    Console.WriteLine(
        "Substring()   -> returns a selected portion of a string.");
    Console.WriteLine(
        "Remove()      -> returns a string without a selected range.");
    Console.WriteLine(
        "Replace()     -> replaces every matching occurrence.");
    Console.WriteLine(
        "const/Length  -> avoid fragile magic strings and magic numbers.");
    Console.WriteLine(
        "string        -> immutable; helper methods return new strings.");
}

static void PrintSectionHeader(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
}