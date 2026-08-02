/*
 * Module:
 * Perform Operations on Arrays Using Helper Methods in C#
 *
 * Learning objectives:
 * - Sort and reverse the order of array elements.
 * - Clear selected elements without changing the array length.
 * - Resize an array to add or remove elements at the end.
 * - Convert a string into char[] or string[] data.
 * - Join array elements into a new string.
 * - Complete the reverse-words and order-ID validation challenges.
 *
 * Context:
 * The lesson uses pallet identifiers and order IDs from a logistics workflow.
 * The original Microsoft Learn material contains separate code fragments that
 * repeatedly declare the same variable names. This version organizes all of
 * those fragments into focused methods so that the complete lesson compiles and
 * runs as one professional console application.
 */

internal static class Program
{
    private static void Main()
    {
        WriteApplicationHeader();

        DemonstrateSortAndReverse();
        DemonstrateClear();
        DemonstrateNullAfterClear();
        DemonstrateSafeNullAccess();
        DemonstrateResizeLargerAndSmaller();
        DemonstrateRemovingNullElements();
        DemonstrateToCharArrayAndReverse();
        DemonstrateJoinAndSplit();
        RunReverseWordsChallenge();
        RunOrderValidationChallenge();

        WriteModuleSummary();
    }

    /// <summary>
    /// Displays the module title and its main learning goals.
    /// </summary>
    private static void WriteApplicationHeader()
    {
        Console.WriteLine(
            "PERFORM OPERATIONS ON ARRAYS USING HELPER METHODS IN C#");
        Console.WriteLine(
            "=====================================================");
        Console.WriteLine();

        Console.WriteLine("Learning goals:");
        Console.WriteLine("- Sort and reverse array elements.");
        Console.WriteLine("- Clear and resize arrays.");
        Console.WriteLine("- Convert strings into arrays.");
        Console.WriteLine("- Join array elements into strings.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates how Array.Sort() and Array.Reverse() mutate the same array.
    /// </summary>
    private static void DemonstrateSortAndReverse()
    {
        WriteSectionHeader("1. Sort and reverse pallet identifiers");

        string[] pallets =
        [
            "B14",
            "A11",
            "B12",
            "A13"
        ];

        Console.WriteLine("Original order:");
        PrintStringArray(pallets);

        /*
         * Array.Sort() sorts the existing array in place.
         *
         * "In place" means that the method does not return a separate sorted
         * array. Instead, it changes the order of the elements stored in pallets.
         *
         * For strings, the default comparison produces an alphanumeric ordering
         * based on the runtime's default string comparer.
         */
        Array.Sort(pallets);

        Console.WriteLine();
        Console.WriteLine("Sorted:");
        PrintStringArray(pallets);

        /*
         * Array.Reverse() also works in place.
         *
         * Reverse() does not perform a descending sort by itself. It only flips
         * the array's current order. Because the array was sorted immediately
         * before this call, reversing it produces the reverse of that sorted order.
         */
        Array.Reverse(pallets);

        Console.WriteLine();
        Console.WriteLine("Reversed after sorting:");
        PrintStringArray(pallets);

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates that Array.Clear() resets selected elements to their default
    /// values but does not change the array length.
    /// </summary>
    private static void DemonstrateClear()
    {
        WriteSectionHeader("2. Clear selected array elements");

        /*
         * string?[] is used because Array.Clear() sets cleared reference-type
         * elements to null. The nullable annotation documents that null is an
         * expected state in this example.
         */
        string?[] pallets =
        [
            "B14",
            "A11",
            "B12",
            "A13"
        ];

        Console.WriteLine($"Before clear — Length: {pallets.Length}");
        PrintNullableStringArray(pallets);

        /*
         * Array.Clear(array, startIndex, length)
         *
         * pallets → array to modify
         * 0       → start at index 0
         * 2       → clear two elements
         *
         * For a reference-type array such as string?[], cleared elements become
         * null. For an int[] array, cleared elements would become 0.
         */
        Array.Clear(
            pallets,
            index: 0,
            length: 2);

        Console.WriteLine();
        Console.WriteLine($"After clear — Length: {pallets.Length}");
        PrintNullableStringArray(pallets);

        Console.WriteLine();
        Console.WriteLine(
            "Observation: Clear() changed values, not the array length.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Proves that a cleared string-array element is null rather than an empty
    /// string.
    /// </summary>
    private static void DemonstrateNullAfterClear()
    {
        WriteSectionHeader("3. A cleared string element becomes null");

        string?[] pallets =
        [
            "B14",
            "A11",
            "B12",
            "A13"
        ];

        Console.WriteLine($"Before: {pallets[0]}");

        Array.Clear(
            pallets,
            index: 0,
            length: 2);

        /*
         * String interpolation displays a null string as no visible characters.
         * Therefore, the output after "After:" can look like an empty string.
         *
         * The explicit null comparison below reveals the actual state.
         */
        Console.WriteLine($"After : {pallets[0]}");
        Console.WriteLine(
            $"Is pallets[0] null? {pallets[0] is null}");

        /*
         * The following intentionally unsafe code is retained as a comment:
         *
         * Console.WriteLine(pallets[0].ToLower());
         *
         * It would throw NullReferenceException because no string object exists at
         * index 0 after Array.Clear().
         */

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates safe access to an array element that may contain null.
    /// </summary>
    private static void DemonstrateSafeNullAccess()
    {
        WriteSectionHeader("4. Safely access a potentially null element");

        string?[] pallets =
        [
            "B14",
            "A11",
            "B12",
            "A13"
        ];

        Array.Clear(
            pallets,
            index: 0,
            length: 2);

        /*
         * A null check prevents a method call on a missing object.
         */
        string? firstPallet = pallets[0];

        /*
         * Copying the array element into a local variable gives nullable flow
         * analysis a stable value to track. Array elements are mutable, so a
         * direct check followed by a second pallets[0] access can still produce
         * warning CS8602 (possible null dereference).
         */
        if (firstPallet is not null)
        {
            Console.WriteLine(
                $"Lowercase pallet ID: {firstPallet.ToLowerInvariant()}");
        }
        else
        {
            Console.WriteLine(
                "pallets[0] is null, so ToLowerInvariant() was not called.");
        }

        /*
         * The null-conditional operator offers a compact alternative.
         *
         * If pallets[1] is null, ?. prevents the method call and returns null.
         * ?? then supplies a readable fallback string.
         */
        string secondPalletDisplay =
            pallets[1]?.ToLowerInvariant() ??
            "<null>";

        Console.WriteLine(
            $"Safe null-conditional result: {secondPalletDisplay}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates growing and shrinking an array with Array.Resize().
    /// </summary>
    private static void DemonstrateResizeLargerAndSmaller()
    {
        WriteSectionHeader("5. Resize an array");

        string?[] pallets =
        [
            "B14",
            "A11",
            "B12",
            "A13"
        ];

        Array.Clear(
            pallets,
            index: 0,
            length: 2);

        Console.WriteLine(
            $"After clearing two elements — Length: {pallets.Length}");
        PrintNullableStringArray(pallets);

        /*
         * Array.Resize(ref array, newSize)
         *
         * The ref keyword is required because Resize() may allocate a new array
         * object and assign that new reference back to the pallets variable.
         *
         * Expanding from four to six elements preserves the existing four
         * positions. The two new string elements are initialized to null.
         */
        Array.Resize(
            ref pallets,
            newSize: 6);

        Console.WriteLine();
        Console.WriteLine(
            $"After resizing to six — Length: {pallets.Length}");
        PrintNullableStringArray(pallets);

        pallets[4] = "C01";
        pallets[5] = "C02";

        Console.WriteLine();
        Console.WriteLine("After assigning the two new elements:");
        PrintNullableStringArray(pallets);

        /*
         * Shrinking keeps only the first newSize elements.
         *
         * Resize() removes elements from the end. It does not search for null
         * positions and it does not compact the array automatically.
         */
        Array.Resize(
            ref pallets,
            newSize: 3);

        Console.WriteLine();
        Console.WriteLine(
            $"After resizing to three — Length: {pallets.Length}");
        PrintNullableStringArray(pallets);

        Console.WriteLine();
        Console.WriteLine(
            "Observation: the first two null positions remain because shrinking " +
            "removes elements only from the end.");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates the manual copy process described in the lesson for removing
    /// null elements from an array.
    /// </summary>
    private static void DemonstrateRemovingNullElements()
    {
        WriteSectionHeader("6. Remove null elements by creating a compact array");

        string?[] sourcePallets =
        [
            null,
            null,
            "B12",
            "A13",
            "C01",
            "C02"
        ];

        Console.WriteLine("Source array:");
        PrintNullableStringArray(sourcePallets);

        /*
         * The lesson explains that Array.Resize() does not automatically remove
         * null elements. One fundamental solution is:
         *
         * 1. Count non-null elements.
         * 2. Create a new array with that exact size.
         * 3. Copy each non-null element into the new array.
         */
        int nonNullCount = 0;

        foreach (string? pallet in sourcePallets)
        {
            if (pallet is not null)
            {
                nonNullCount++;
            }
        }

        string[] compactPallets =
            new string[nonNullCount];

        int destinationIndex = 0;

        foreach (string? pallet in sourcePallets)
        {
            if (pallet is null)
            {
                continue;
            }

            compactPallets[destinationIndex] = pallet;
            destinationIndex++;
        }

        Console.WriteLine();
        Console.WriteLine("Compacted array:");
        PrintStringArray(compactPallets);

        Console.WriteLine();
        Console.WriteLine(
            $"Original length: {sourcePallets.Length}");
        Console.WriteLine(
            $"Compacted length: {compactPallets.Length}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Converts a string to char[], reverses the characters, and constructs a new
    /// string from the reversed character array.
    /// </summary>
    private static void DemonstrateToCharArrayAndReverse()
    {
        WriteSectionHeader("7. Convert a string to char[] and reverse it");

        string value = "abc123";

        /*
         * ToCharArray() creates one char element for each character in the source
         * string.
         */
        char[] valueArray =
            value.ToCharArray();

        Console.WriteLine($"Original string : {value}");
        Console.WriteLine(
            $"Character count : {valueArray.Length}");

        Array.Reverse(valueArray);

        /*
         * new string(char[]) constructs a new string containing the characters in
         * their current array order.
         */
        string reversedValue =
            new(valueArray);

        Console.WriteLine($"Reversed string : {reversedValue}");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Demonstrates converting an array to delimited text with Join() and parsing
    /// that text back into an array with Split().
    /// </summary>
    private static void DemonstrateJoinAndSplit()
    {
        WriteSectionHeader("8. Join array elements and split a string");

        string value = "abc123";
        char[] characters = value.ToCharArray();

        Array.Reverse(characters);

        /*
         * string.Join(separator, values) combines the array elements into one
         * string and inserts the separator between adjacent elements.
         */
        string commaSeparatedValue =
            string.Join(
                ",",
                characters);

        Console.WriteLine(
            $"Comma-separated value: {commaSeparatedValue}");

        /*
         * Split(',') divides the source string whenever a comma is encountered.
         * The result is a string[] because each segment is a string.
         */
        string[] items =
            commaSeparatedValue.Split(',');

        Console.WriteLine("Split items:");

        foreach (string item in items)
        {
            Console.WriteLine($"-- {item}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "Transformation: string → char[] → joined string → string[]");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Challenge 1:
    /// Reverses the letters inside each word while preserving word order.
    /// </summary>
    private static void RunReverseWordsChallenge()
    {
        WriteSectionHeader("9. Challenge: reverse every word in place");

        string pangram =
            "The quick brown fox jumps over the lazy dog";

        /*
         * Step 1:
         * Split the sentence at spaces. The word order is now represented by the
         * array indexes.
         */
        string[] words =
            pangram.Split(' ');

        /*
         * Step 2:
         * Allocate a result array with the same number of words.
         */
        string[] reversedWords =
            new string[words.Length];

        /*
         * Step 3:
         * Reverse only the letters within each word.
         *
         * The loop preserves each word's original array index, so the sentence's
         * word order remains unchanged.
         */
        for (int index = 0;
             index < words.Length;
             index++)
        {
            char[] letters =
                words[index].ToCharArray();

            Array.Reverse(letters);

            reversedWords[index] =
                new string(letters);
        }

        /*
         * Step 4:
         * Join the transformed words with a single space.
         */
        string result =
            string.Join(
                " ",
                reversedWords);

        Console.WriteLine($"Original: {pangram}");
        Console.WriteLine($"Result  : {result}");

        Console.WriteLine();
        Console.WriteLine("Expected:");
        Console.WriteLine(
            "ehT kciuq nworb xof spmuj revo eht yzal god");

        WriteSectionSeparator();
    }

    /// <summary>
    /// Challenge 2:
    /// Parses, sorts, and validates order identifiers.
    /// </summary>
    private static void RunOrderValidationChallenge()
    {
        WriteSectionHeader(
            "10. Challenge: sort order IDs and tag possible errors");

        string orderStream =
            "B123,C234,A345,C15,B177,G3003,C235,B179";

        /*
         * Split the incoming comma-separated stream into individual order IDs.
         */
        string[] orderIds =
            orderStream.Split(',');

        /*
         * Sort the order IDs alphanumerically in place.
         */
        Array.Sort(orderIds);

        Console.WriteLine("Sorted order validation:");

        foreach (string orderId in orderIds)
        {
            /*
             * The business rule requires every valid order ID to contain exactly
             * four characters. Any other length is tagged as a possible error.
             */
            if (orderId.Length == 4)
            {
                Console.WriteLine(orderId);
            }
            else
            {
                Console.WriteLine(
                    $"{orderId}\t- Error");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Expected invalid IDs:");
        Console.WriteLine("C15   - three characters");
        Console.WriteLine("G3003 - five characters");

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
            "Array.Sort()    : sorts elements in the existing array.");
        Console.WriteLine(
            "Array.Reverse() : reverses the array's current order.");
        Console.WriteLine(
            "Array.Clear()   : resets selected elements to default values.");
        Console.WriteLine(
            "Array.Resize()  : changes the length from the end of the array.");
        Console.WriteLine(
            "ToCharArray()   : converts a string into char elements.");
        Console.WriteLine(
            "Split()         : converts delimited text into string elements.");
        Console.WriteLine(
            "Join()          : combines array elements into one string.");

        Console.WriteLine();
        Console.WriteLine(
            "Clear() changes element values; Resize() changes array length.");
        Console.WriteLine(
            "Always check for null before calling instance methods on cleared " +
            "reference-type elements.");
    }

    /// <summary>
    /// Prints each non-null string in a non-nullable string array.
    /// </summary>
    private static void PrintStringArray(string[] values)
    {
        foreach (string value in values)
        {
            Console.WriteLine($"-- {value}");
        }
    }

    /// <summary>
    /// Prints nullable string elements while making null positions visible.
    /// </summary>
    private static void PrintNullableStringArray(string?[] values)
    {
        for (int index = 0;
             index < values.Length;
             index++)
        {
            string displayValue =
                values[index] ??
                "<null>";

            Console.WriteLine(
                $"-- [{index}] {displayValue}");
        }
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
                62));
        Console.WriteLine();
    }
}