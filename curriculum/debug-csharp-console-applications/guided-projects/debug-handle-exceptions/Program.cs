// ============================================================================
// Guided Project: Debug and Handle Exceptions in a C# Console Application
// Learning Path: Debug C# Console Applications
//
// Purpose:
// - Simulate cash-register transactions.
// - Use debugger evidence to identify a till-balance logic bug.
// - Correct the five-dollar bill indexing bug.
// - Add try-catch around MakeChange().
// - Throw InvalidOperationException for transaction failures.
// - Convert MakeChange() from status-string returns to void.
// - Use Exception.Message to report failure details.
//
// IMPORTANT:
// Microsoft Learn explicitly notes that additional logic bugs remain after this
// guided project. Those remaining behaviors are intentionally preserved for the
// following challenge project.
// ============================================================================

bool useTestData = false;

Console.Clear();


// ============================================================================
// CASH-TILL MODEL
// ============================================================================

// cashTill stores the NUMBER OF BILLS:
//
// cashTill[0] -> $1 bills
// cashTill[1] -> $5 bills
// cashTill[2] -> $10 bills
// cashTill[3] -> $20 bills
int[] cashTill =
[
    0,
    0,
    0,
    0
];

// Independent safety-check balance maintained by the calling application.
int registerCheckTillTotal = 0;


// ============================================================================
// DAILY STARTING CASH
// ============================================================================

// [ denomination, number of bills ]
//
// $1  x 50 = $ 50
// $5  x 20 = $100
// $10 x 10 = $100
// $20 x  5 = $100
//
// Starting total = $350.
int[,] registerDailyStartingCash =
{
    { 1, 50 },
    { 5, 20 },
    { 10, 10 },
    { 20, 5 }
};


// ============================================================================
// FIXED TEST DATA
// ============================================================================

int[] testData =
[
    6,
    10,
    17,
    20,
    31,
    36,
    40,
    41
];

int testCounter = 0;


// ============================================================================
// INITIALIZE TILL
// ============================================================================

LoadTillEachMorning(
    registerDailyStartingCash,
    cashTill);

registerCheckTillTotal =
    registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] +
    registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] +
    registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] +
    registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

LogTillStatus(
    cashTill);

Console.WriteLine(
    TillAmountSummary(
        cashTill));

Console.WriteLine(
    $"Expected till value: {registerCheckTillTotal}\n");


// ============================================================================
// TRANSACTION GENERATOR
// ============================================================================

// The guided project uses random transactions to expose logic paths that the
// small fixed sample does not always reveal.
Random valueGenerator =
    new(
        unchecked(
            (int)DateTime.Now.Ticks));

// The exception-handling verification step expands the simulation to 40.
int transactions = 40;

if (useTestData)
{
    transactions =
        testData.Length;
}


// ============================================================================
// PROCESS TRANSACTIONS
// ============================================================================

while (transactions > 0)
{
    transactions--;

    // Random.Next(2, 50) generates values from 2 through 49.
    int itemCost =
        valueGenerator.Next(
            2,
            50);

    if (useTestData)
    {
        itemCost =
            testData[testCounter];

        testCounter++;
    }

    // Construct the customer's cash payment.
    int paymentOnes =
        itemCost % 2;

    int paymentFives =
        itemCost % 10 > 7
            ? 1
            : 0;

    int paymentTens =
        itemCost % 20 > 13
            ? 1
            : 0;

    int paymentTwenties =
        itemCost < 20
            ? 1
            : 2;

    Console.WriteLine(
        $"Customer is making a ${itemCost} purchase");

    Console.WriteLine(
        $"\tUsing {paymentTwenties} twenty dollar bills");

    Console.WriteLine(
        $"\tUsing {paymentTens} ten dollar bills");

    Console.WriteLine(
        $"\tUsing {paymentFives} five dollar bills");

    Console.WriteLine(
        $"\tUsing {paymentOnes} one dollar bills");


    // ------------------------------------------------------------------------
    // EXCEPTION-HANDLING FLOW
    // ------------------------------------------------------------------------
    //
    // Before this exercise, MakeChange() returned status strings.
    //
    // After the refactor:
    //
    // success -> MakeChange() returns normally
    // failure -> MakeChange() throws InvalidOperationException
    //
    // This separates normal control flow from failure control flow.

    try
    {
        MakeChange(
            itemCost,
            cashTill,
            paymentTwenties,
            paymentTens,
            paymentFives,
            paymentOnes);

        Console.WriteLine(
            "Transaction successfully completed.");

        // A successful purchase should increase the independent expected till
        // balance by exactly the item cost.
        registerCheckTillTotal +=
            itemCost;
    }
    catch (InvalidOperationException exception)
    {
        // Catch only the failure type this caller is prepared to handle.
        Console.WriteLine(
            $"Could not complete transaction: {exception.Message}");
    }


    // Independent safety check after each transaction.
    Console.WriteLine(
        TillAmountSummary(
            cashTill));

    Console.WriteLine(
        $"Expected till value: {registerCheckTillTotal}\n");

    Console.WriteLine();
}


// ============================================================================
// EXIT
// ============================================================================

Console.WriteLine(
    "Press the Enter key to exit");

// In Visual Studio Code, the guided project uses:
//
// "console": "integratedTerminal"
//
// because Console.Clear() and Console.ReadLine() require a console that
// supports interactive input/output.
Console.ReadLine();


// ============================================================================
// LoadTillEachMorning
// ============================================================================

static void LoadTillEachMorning(
    int[,] registerDailyStartingCash,
    int[] cashTill)
{
    cashTill[0] =
        registerDailyStartingCash[0, 1];

    cashTill[1] =
        registerDailyStartingCash[1, 1];

    cashTill[2] =
        registerDailyStartingCash[2, 1];

    cashTill[3] =
        registerDailyStartingCash[3, 1];
}


// ============================================================================
// MakeChange
// ============================================================================

static void MakeChange(
    int cost,
    int[] cashTill,
    int twenties,
    int tens = 0,
    int fives = 0,
    int ones = 0)
{
    // ------------------------------------------------------------------------
    // ACCEPT CUSTOMER PAYMENT
    // ------------------------------------------------------------------------
    //
    // The guided-project source adds the customer's bills to the till before
    // preparing change.
    //
    // IMPORTANT:
    // The module explicitly states that additional logic bugs still remain for
    // the later challenge project. Therefore this implementation preserves the
    // guided-project stage instead of silently redesigning transaction rollback.

    cashTill[3] +=
        twenties;

    cashTill[2] +=
        tens;

    cashTill[1] +=
        fives;

    cashTill[0] +=
        ones;


    // ------------------------------------------------------------------------
    // CALCULATE PAYMENT AND CHANGE
    // ------------------------------------------------------------------------

    int amountPaid =
        twenties * 20 +
        tens * 10 +
        fives * 5 +
        ones;

    int changeNeeded =
        amountPaid -
        cost;


    // ------------------------------------------------------------------------
    // UNDERPAYMENT
    // ------------------------------------------------------------------------

    if (changeNeeded < 0)
    {
        throw new InvalidOperationException(
            "InvalidOperationException: Not enough money provided to " +
            "complete the transaction.");
    }

    Console.WriteLine(
        "Cashier Returns:");


    // ------------------------------------------------------------------------
    // RETURN $20 BILLS
    // ------------------------------------------------------------------------

    while (
        changeNeeded > 19 &&
        cashTill[3] > 0)
    {
        cashTill[3]--;

        changeNeeded -=
            20;

        Console.WriteLine(
            "\tA twenty");
    }


    // ------------------------------------------------------------------------
    // RETURN $10 BILLS
    // ------------------------------------------------------------------------

    while (
        changeNeeded > 9 &&
        cashTill[2] > 0)
    {
        cashTill[2]--;

        changeNeeded -=
            10;

        Console.WriteLine(
            "\tA ten");
    }


    // ------------------------------------------------------------------------
    // RETURN $5 BILLS
    // ------------------------------------------------------------------------
    //
    // ORIGINAL BUG:
    //
    // cashTill[2]--;
    //
    // The condition checked cashTill[1] ($5 bills), but the loop body removed
    // cashTill[2] ($10 bills). The console output looked like a $5 bill was
    // returned, while the internal till actually lost $10.
    //
    // The debugger exposed the symptom:
    //
    // actual till balance   -> short by $5
    // expected till balance -> higher by $5
    //
    // CORRECTION:
    //
    // decrement cashTill[1].

    while (
        changeNeeded > 4 &&
        cashTill[1] > 0)
    {
        cashTill[1]--;

        changeNeeded -=
            5;

        Console.WriteLine(
            "\tA five");
    }


    // ------------------------------------------------------------------------
    // RETURN $1 BILLS
    // ------------------------------------------------------------------------

    while (
        changeNeeded > 0 &&
        cashTill[0] > 0)
    {
        cashTill[0]--;

        changeNeeded--;

        Console.WriteLine(
            "\tA one");
    }


    // ------------------------------------------------------------------------
    // INSUFFICIENT TILL
    // ------------------------------------------------------------------------

    if (changeNeeded > 0)
    {
        throw new InvalidOperationException(
            "InvalidOperationException: The till is unable to make the " +
            "correct change.");
    }

    // Successful completion is represented by normal return.
    // Failure is represented by an exception.
}


// ============================================================================
// LogTillStatus
// ============================================================================

static void LogTillStatus(
    int[] cashTill)
{
    Console.WriteLine(
        "The till currently has:");

    Console.WriteLine(
        $"{cashTill[3] * 20} in twenties");

    Console.WriteLine(
        $"{cashTill[2] * 10} in tens");

    Console.WriteLine(
        $"{cashTill[1] * 5} in fives");

    Console.WriteLine(
        $"{cashTill[0]} in ones");

    Console.WriteLine();
}


// ============================================================================
// TillAmountSummary
// ============================================================================

static string TillAmountSummary(
    int[] cashTill)
{
    int total =
        cashTill[3] * 20 +
        cashTill[2] * 10 +
        cashTill[1] * 5 +
        cashTill[0];

    return
        $"The till has {total} dollars";
}