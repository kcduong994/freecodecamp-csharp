using System.Globalization;

// ============================================================================
// Module: Create C# Methods that Return Values
// Learning path: Create Methods in C# Console Applications
//
// Purpose:
// Consolidate the Microsoft Learn examples from this module into one runnable
// Program.cs file while preserving the lesson's core progression:
//
//     arguments
//         ↓
//     parameters
//         ↓
//     method processing
//         ↓
//     return statement
//         ↓
//     return value
//         ↓
//     caller
//
// Topics demonstrated:
// - declaring return types;
// - returning literals, variables, and expressions;
// - capturing return values in variables;
// - using returned values inside arithmetic and conditions;
// - returning int and double values;
// - returning string values;
// - returning bool values;
// - returning one-dimensional and two-dimensional arrays;
// - returning early when a result is found;
// - composing methods by using one method's result inside another method;
// - completing the dice mini-game challenge with correctly typed methods.
//
// Source note:
// The examples follow the structure and terminology of the supplied Microsoft
// Learn module. Small repository-oriented refinements are clearly identified in
// comments where they differ from the minimal lesson code.
// ============================================================================

Console.WriteLine("CREATE C# METHODS THAT RETURN VALUES");
Console.WriteLine(new string('=', 43));
Console.WriteLine();

RunShoppingCenterExample();
RunCurrencyConversionExample();
RunStringReturnExample();
RunBooleanReturnExample();
RunArrayReturnExample();
RunDiceMiniGameChallenge();
DisplayModuleSummary();

// ============================================================================
// 1. UNDERSTAND RETURN TYPE SYNTAX
// ============================================================================

void RunShoppingCenterExample()
{
    Console.WriteLine("1. Return types and captured return values");
    Console.WriteLine("------------------------------------------");

    double total = 0;
    double minimumSpend = 30.00;

    double[] items =
    {
        15.97,
        3.50,
        12.25,
        22.99,
        10.98
    };

    double[] discounts =
    {
        0.30,
        0.00,
        0.10,
        0.20,
        0.50
    };

    // GetDiscountedPrice() returns a double.
    // Because the returned value is also a double, the caller can add it
    // directly to another double variable.
    for (int index = 0; index < items.Length; index++)
    {
        total += GetDiscountedPrice(index);
    }

    // TotalMeetsMinimum() returns a bool.
    // A bool-returning method can be used anywhere a Boolean expression is
    // valid, including directly inside a ternary expression.
    total -=
        TotalMeetsMinimum()
            ? 5.00
            : 0.00;

    // FormatDecimal() returns a string.
    // The return value is evaluated first and then becomes part of the
    // interpolated string passed to Console.WriteLine().
    Console.WriteLine(
        $"Total: ${FormatDecimal(total)}");

    Console.WriteLine();

    double GetDiscountedPrice(int itemIndex)
    {
        // Return type:
        // double
        //
        // Return expression:
        // items[itemIndex] * (1 - discounts[itemIndex])
        //
        // The expression evaluates to double, matching the declared return type.
        return
            items[itemIndex] *
            (1 - discounts[itemIndex]);
    }

    bool TotalMeetsMinimum()
    {
        // A comparison already produces a bool, so there is no need to create
        // a temporary variable before returning it.
        return total >= minimumSpend;
    }

    string FormatDecimal(double input)
    {
        // This keeps the exact learning technique used by the supplied module:
        // convert the number to text and return the first five characters.
        //
        // For production software, a numeric format string such as "0.00" is
        // usually safer than Substring because it handles a wider range of
        // numeric values and cultures.
        return
            input
                .ToString(CultureInfo.InvariantCulture)
                .Substring(0, 5);
    }
}

// ============================================================================
// 2. RETURN NUMBERS FROM METHODS
// ============================================================================

void RunCurrencyConversionExample()
{
    Console.WriteLine("2. Return numeric values");
    Console.WriteLine("------------------------");

    double usd = 23.73;

    // UsdToVnd() returns int, so its result can initialize an int variable.
    int vnd =
        UsdToVnd(usd);

    Console.WriteLine(
        $"${usd} USD = ${vnd} VND");

    // VndToUsd() returns double, so decimal precision is preserved.
    Console.WriteLine(
        $"${vnd} VND = ${VndToUsd(vnd)} USD");

    Console.WriteLine();

    int UsdToVnd(double usdAmount)
    {
        int rate = 23500;

        // rate * usdAmount produces double because one operand is double.
        // The method promises to return int, so an explicit cast is required.
        //
        // This intentionally demonstrates the module's point:
        // return expressions must be compatible with the declared return type.
        return
            (int)(rate * usdAmount);
    }

    double VndToUsd(int vndAmount)
    {
        // rate is double so vndAmount / rate uses floating-point division.
        //
        // If both operands were int, integer division would discard the
        // fractional portion before the result was converted to double.
        double rate = 23500;

        return
            vndAmount / rate;
    }
}

// ============================================================================
// 3. RETURN STRINGS FROM METHODS
// ============================================================================

void RunStringReturnExample()
{
    Console.WriteLine("3. Return strings from methods");
    Console.WriteLine("------------------------------");

    string input =
        "there are snakes at the zoo";

    Console.WriteLine(input);

    // ReverseSentence() returns a string that the caller passes directly to
    // Console.WriteLine().
    Console.WriteLine(
        ReverseSentence(input));

    Console.WriteLine();

    string ReverseSentence(string sentence)
    {
        string result = string.Empty;

        string[] words =
            sentence.Split(" ");

        foreach (string word in words)
        {
            // ReverseWord() itself returns string.
            //
            // This demonstrates method composition:
            // one method can call another method, capture its return value, and
            // use that result while building a larger return value.
            result +=
                ReverseWord(word) +
                " ";
        }

        // Trim() is evaluated first, then its string result is returned to the
        // original caller of ReverseSentence().
        return result.Trim();
    }

    string ReverseWord(string word)
    {
        string result =
            string.Empty;

        // Start at the final valid index.
        // word.Length - 1 is required because string indexes are zero-based.
        for (
            int index = word.Length - 1;
            index >= 0;
            index--)
        {
            result +=
                word[index];
        }

        return result;
    }
}

// ============================================================================
// 4. RETURN BOOLEANS FROM METHODS
// ============================================================================

void RunBooleanReturnExample()
{
    Console.WriteLine("4. Return Boolean values");
    Console.WriteLine("------------------------");

    string[] words =
    {
        "racecar",
        "talented",
        "deified",
        "tent",
        "tenet"
    };

    Console.WriteLine(
        "Is it a palindrome?");

    foreach (string word in words)
    {
        // IsPalindrome() returns bool.
        // The bool result is embedded directly into the output string.
        Console.WriteLine(
            $"{word}: {IsPalindrome(word)}");
    }

    Console.WriteLine();

    bool IsPalindrome(string word)
    {
        int start = 0;
        int end =
            word.Length - 1;

        while (start < end)
        {
            // The first mismatch proves the word cannot be a palindrome.
            // Returning here ends the method immediately and avoids needless
            // comparisons.
            if (word[start] != word[end])
            {
                return false;
            }

            start++;
            end--;
        }

        // Reaching this point means every mirrored pair matched.
        return true;
    }
}

// ============================================================================
// 5. RETURN ARRAYS FROM METHODS
// ============================================================================

void RunArrayReturnExample()
{
    Console.WriteLine("5. Return arrays from methods");
    Console.WriteLine("-----------------------------");

    int[] coins =
    {
        5,
        5,
        50,
        25,
        25,
        10,
        5
    };

    // First verification case from the supplied lesson.
    int target = 30;

    int[,] result =
        TwoCoins(
            coins,
            target);

    DisplayCoinPairs(
        result,
        target);

    Console.WriteLine();

    // Second verification case from the supplied lesson.
    target = 80;

    result =
        TwoCoins(
            coins,
            target);

    DisplayCoinPairs(
        result,
        target);

    Console.WriteLine();

    int[,] TwoCoins(
        int[] availableCoins,
        int targetValue)
    {
        // The lesson requires support for at most five matching pairs.
        //
        // -1 is a sentinel value. It marks an unused row so the caller knows
        // where the valid results stop.
        int[,] matches =
        {
            { -1, -1 },
            { -1, -1 },
            { -1, -1 },
            { -1, -1 },
            { -1, -1 }
        };

        int count = 0;

        for (
            int current = 0;
            current < availableCoins.Length;
            current++)
        {
            // Start at current + 1 so:
            // 1. the same coin is never paired with itself;
            // 2. reversed duplicates such as (0,3) and (3,0) are avoided.
            for (
                int next = current + 1;
                next < availableCoins.Length;
                next++)
            {
                bool makesTarget =
                    availableCoins[current] +
                    availableCoins[next] ==
                    targetValue;

                if (makesTarget)
                {
                    matches[count, 0] =
                        current;

                    matches[count, 1] =
                        next;

                    count++;
                }

                // The result array can store only five pairs.
                // Once it is full, return immediately rather than risking an
                // index-out-of-range write on the next match.
                if (count == matches.GetLength(0))
                {
                    return matches;
                }
            }
        }

        // A method can construct and return a value directly.
        //
        // No match:
        // return an empty 2D array.
        //
        // One to four matches:
        // return the partially filled array whose remaining rows still contain
        // the -1 sentinel values.
        return
            count == 0
                ? new int[0, 0]
                : matches;
    }

    void DisplayCoinPairs(
        int[,] pairs,
        int targetValue)
    {
        Console.WriteLine(
            $"Target: {targetValue}");

        if (pairs.Length == 0)
        {
            Console.WriteLine(
                "No two coins make change");

            return;
        }

        Console.WriteLine(
            "Change found at positions:");

        for (
            int row = 0;
            row < pairs.GetLength(0);
            row++)
        {
            // -1 marks the first unused result row.
            if (pairs[row, 0] == -1)
            {
                break;
            }

            Console.WriteLine(
                $"{pairs[row, 0]},{pairs[row, 1]}");
        }
    }
}

// ============================================================================
// 6. CHALLENGE: COMPLETE THE DICE MINI-GAME
// ============================================================================

void RunDiceMiniGameChallenge()
{
    Console.WriteLine("6. Challenge: dice mini-game");
    Console.WriteLine("----------------------------");

    Random random =
        new();

    Console.WriteLine(
        "Would you like to play? (Y/N)");

    if (ShouldPlay())
    {
        PlayGame();
    }

    Console.WriteLine();

    bool ShouldPlay()
    {
        // The supplied solution calls Console.ReadLine() and checks whether the
        // response is "y".
        //
        // Repository refinement:
        // null-coalescing and Trim() make the method safe when no input is
        // available and tolerant of surrounding whitespace.
        string response =
            Console.ReadLine() ??
            string.Empty;

        return
            response
                .Trim()
                .Equals(
                    "y",
                    StringComparison.OrdinalIgnoreCase);
    }

    void PlayGame()
    {
        bool play =
            true;

        while (play)
        {
            // GetTarget() and RollDice() are int-returning methods.
            //
            // Their return values initialize variables in the caller.
            int target =
                GetTarget();

            int roll =
                RollDice();

            Console.WriteLine(
                $"Roll a number greater than {target} to win!");

            Console.WriteLine(
                $"You rolled a {roll}");

            // WinOrLose() returns string, and its result is supplied directly to
            // Console.WriteLine().
            Console.WriteLine(
                WinOrLose(
                    roll,
                    target));

            Console.WriteLine();
            Console.WriteLine(
                "Play again? (Y/N)");

            // ShouldPlay() returns bool and directly controls the loop state.
            play =
                ShouldPlay();
        }
    }

    int GetTarget()
    {
        // Random.Next(min, max) includes min and excludes max.
        //
        // This therefore returns 1 through 5 inclusive.
        return
            random.Next(
                1,
                6);
    }

    int RollDice()
    {
        // This returns 1 through 6 inclusive, representing one six-sided die.
        return
            random.Next(
                1,
                7);
    }

    string WinOrLose(
        int roll,
        int target)
    {
        // The challenge rule says the roll must be GREATER than the target.
        if (roll > target)
        {
            return "You win!";
        }

        return "You lose!";
    }
}

// ============================================================================
// MODULE SUMMARY
// ============================================================================

void DisplayModuleSummary()
{
    Console.WriteLine("MODULE SUMMARY");
    Console.WriteLine("--------------");

    Console.WriteLine(
        "Return type      -> declares the type a method sends back to its caller.");

    Console.WriteLine(
        "return           -> ends the method and optionally provides its result.");

    Console.WriteLine(
        "Return value     -> data produced by the method for the caller.");

    Console.WriteLine(
        "Captured value   -> returned data stored or immediately used by the caller.");

    Console.WriteLine(
        "int / double     -> methods can return numeric results.");

    Console.WriteLine(
        "string           -> methods can return generated or transformed text.");

    Console.WriteLine(
        "bool             -> methods can return decisions for conditions and logic.");

    Console.WriteLine(
        "array            -> methods can construct and return complete data sets.");

    Console.WriteLine(
        "Method composition -> one method can consume another method's return value.");

    Console.WriteLine(
        "Explicit data flow -> parameters carry input; return values carry output.");
}