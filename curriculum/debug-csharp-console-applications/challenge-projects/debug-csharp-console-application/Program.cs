// ============================================================================
// Challenge Project: Debug a C# Console Application Using Visual Studio Code
// Learning Path: Debug C# Console Applications
//
// Scenario:
// - Simulate a store cash-register till.
// - Process 100 randomly priced transactions.
// - Use the debugger to identify logic that causes the till to become
//   unbalanced after failed transactions.
// - Preserve the till state when a transaction cannot be completed.
// - Verify that the reported till value always matches the independent
//   expected till value.
//
// Core challenge fix:
// The starter version updated cashTill directly while MakeChange() was still
// deciding whether the transaction could succeed. If the method later threw
// InvalidOperationException, those partial mutations remained in cashTill.
//
// The corrected version stages the transaction in local "available..." values.
// cashTill is updated only after exact change has been produced successfully.
//
// This gives MakeChange() transaction-like behavior:
//
//     start from current till
//          ↓
//     stage customer payment locally
//          ↓
//     calculate and stage change locally
//          ↓
//     transaction succeeds?
//        ┌───────┴───────┐
//       yes              no
//        ↓                ↓
//     commit          throw exception
//     to till         original till remains unchanged
//
// This is the final Challenge Project state.
// ============================================================================


// ============================================================================
// APPLICATION CONFIGURATION
// ============================================================================

// readResult is used at the end of the application to keep the console open
// until a valid Console.ReadLine() result is received.
string? readResult = null;

// false:
//     Use randomly generated transaction costs.
//
// true:
//     Use the small fixed testData array.
//
// The final challenge specification requires random data, so this remains false.
bool useTestData = false;

Console.Clear();


// ============================================================================
// CASH-TILL MODEL
// ============================================================================

// cashTill stores the NUMBER OF BILLS available in the register.
//
// Index mapping:
//
// cashTill[0] -> $1 bills
// cashTill[1] -> $5 bills
// cashTill[2] -> $10 bills
// cashTill[3] -> $20 bills
//
// Keeping this mapping explicit is important because an earlier guided-project
// bug came from mutating the wrong array index.
int[] cashTill =
[
    0,
    0,
    0,
    0
];

// Independent safety-check balance.
//
// This value is maintained outside MakeChange() and therefore acts as a second
// source of truth. If TillAmountSummary(cashTill) differs from this value, the
// transaction logic has corrupted the till state.
int registerCheckTillTotal = 0;


// ============================================================================
// DAILY STARTING CASH
// ============================================================================

// Each row contains:
//
// [ denomination, number of bills ]
//
// $1  x 50 = $ 50
// $5  x 20 = $100
// $10 x 10 = $100
// $20 x  5 = $100
//
// Starting till total = $350.
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

// The small fixed data set is useful for repeatable verification.
//
// The challenge specification, however, requires the final application to use
// 100 randomly generated item costs in the range 2..49.
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
// INITIALIZE THE TILL
// ============================================================================

LoadTillEachMorning(
    registerDailyStartingCash,
    cashTill);

// Independently calculate the expected starting total.
//
// This calculation intentionally does not depend on TillAmountSummary() or
// MakeChange(), so it can expose logic defects in those transaction operations.
registerCheckTillTotal =
    registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] +
    registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] +
    registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] +
    registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];


// Display the number of bills of each denomination currently in the till.
LogTillStatus(
    cashTill);

// Display the actual cash value represented by cashTill.
Console.WriteLine(
    TillAmountSummary(
        cashTill));

// Display the independently calculated expected value.
Console.WriteLine(
    $"Expected till value: {registerCheckTillTotal}");

Console.WriteLine();


// ============================================================================
// RANDOM TRANSACTION GENERATOR
// ============================================================================

// A time-based seed produces a different transaction sequence across runs.
Random valueGenerator =
    new(
        unchecked(
            (int)DateTime.Now.Ticks));

// Final challenge requirement:
// simulate 100 transactions.
int transactions = 100;

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

    // Random.Next(min, max):
    // - includes min
    // - excludes max
    //
    // Therefore this generates costs from $2 through $49.
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


    // ------------------------------------------------------------------------
    // BUILD THE CUSTOMER PAYMENT
    // ------------------------------------------------------------------------
    //
    // The starter application uses a deterministic payment algorithm based on
    // itemCost. The algorithm can intentionally produce transactions that fail,
    // which allows the exception-handling code to be exercised.

    // 1 when itemCost is odd; otherwise 0.
    int paymentOnes =
        itemCost % 2;

    // 1 when the final digit is 8 or 9; otherwise 0.
    int paymentFives =
        itemCost % 10 > 7
            ? 1
            : 0;

    // 1 when the remainder after division by 20 is 14..19; otherwise 0.
    int paymentTens =
        itemCost % 20 > 13
            ? 1
            : 0;

    // One $20 bill for items under $20; otherwise two $20 bills.
    int paymentTwenties =
        itemCost < 20
            ? 1
            : 2;


    // ------------------------------------------------------------------------
    // REPORT THE CURRENT TRANSACTION
    // ------------------------------------------------------------------------

    Console.WriteLine(
        $"Customer is making a ${itemCost} purchase");

    Console.WriteLine(
        $"\t Using {paymentTwenties} twenty dollar bills");

    Console.WriteLine(
        $"\t Using {paymentTens} ten dollar bills");

    Console.WriteLine(
        $"\t Using {paymentFives} five dollar bills");

    Console.WriteLine(
        $"\t Using {paymentOnes} one dollar bills");


    // ------------------------------------------------------------------------
    // TRANSACTION BOUNDARY
    // ------------------------------------------------------------------------
    //
    // MakeChange() either:
    //
    // 1. completes successfully and commits the staged till state; or
    // 2. throws InvalidOperationException and leaves cashTill unchanged.
    //
    // Only successful transactions increase registerCheckTillTotal.

    try
    {
        MakeChange(
            itemCost,
            cashTill,
            paymentTwenties,
            paymentTens,
            paymentFives,
            paymentOnes);

        // If execution reaches this line, MakeChange() committed a valid
        // transaction to cashTill.
        registerCheckTillTotal +=
            itemCost;
    }
    catch (InvalidOperationException exception)
    {
        // Failed transactions do not modify registerCheckTillTotal.
        //
        // Because MakeChange() now uses staged local values, failed
        // transactions also do not leave partial mutations in cashTill.
        Console.WriteLine(
            $"Could not complete transaction: {exception.Message}");
    }


    // ------------------------------------------------------------------------
    // VERIFY THE TILL AFTER EVERY ATTEMPT
    // ------------------------------------------------------------------------
    //
    // The challenge is solved when these two values remain equal:
    //
    // actual till value
    //     =
    // expected till value

    Console.WriteLine(
        TillAmountSummary(
            cashTill));

    Console.WriteLine(
        $"Expected till value: {registerCheckTillTotal}");

    Console.WriteLine();
}


// ============================================================================
// EXIT
// ============================================================================

Console.WriteLine(
    "Press the Enter key to exit");

// Continue reading until Console.ReadLine() returns a non-null value.
do
{
    readResult =
        Console.ReadLine();
}
while (readResult == null);


// ============================================================================
// LoadTillEachMorning
// ============================================================================

static void LoadTillEachMorning(
    int[,] registerDailyStartingCash,
    int[] cashTill)
{
    // Copy the configured bill counts into the working till.
    //
    // registerDailyStartingCash[row, 1] stores the NUMBER OF BILLS.
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
    // ========================================================================
    // CHALLENGE ROOT CAUSE
    // ========================================================================
    //
    // STARTER BEHAVIOR:
    //
    // cashTill[3] += twenties;
    // cashTill[2] += tens;
    // cashTill[1] += fives;
    // cashTill[0] += ones;
    //
    // The starter code immediately deposited the customer's payment into the
    // real till.
    //
    // It then started removing bills while trying to make change.
    //
    // If the method later discovered that:
    //
    // - the customer had not paid enough; or
    // - the till could not make exact change;
    //
    // it threw InvalidOperationException AFTER cashTill had already been
    // partially modified.
    //
    // The caller correctly did NOT increase registerCheckTillTotal for a failed
    // transaction, but cashTill had already changed.
    //
    // Result:
    //
    //     actual till
    //         ≠
    //     expected till
    //
    // FINAL FIX:
    //
    // Stage the complete transaction in local variables first.
    // Commit those values to cashTill only after success is guaranteed.


    // ------------------------------------------------------------------------
    // STAGE CUSTOMER PAYMENT
    // ------------------------------------------------------------------------
    //
    // These local values represent the till state that WOULD exist if the
    // transaction succeeds.
    //
    // The real cashTill remains untouched at this stage.

    int availableTwenties =
        cashTill[3] +
        twenties;

    int availableTens =
        cashTill[2] +
        tens;

    int availableFives =
        cashTill[1] +
        fives;

    int availableOnes =
        cashTill[0] +
        ones;


    // ------------------------------------------------------------------------
    // CALCULATE PAYMENT AND REQUIRED CHANGE
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
    // FAILURE CASE 1: CUSTOMER UNDERPAID
    // ------------------------------------------------------------------------
    //
    // Because cashTill has not yet been changed, throwing here leaves the
    // register in exactly the same state as before the transaction attempt.

    if (changeNeeded < 0)
    {
        throw new InvalidOperationException(
            "InvalidOperationException: Not enough money provided to " +
            "complete the transaction.");
    }


    Console.WriteLine(
        "Cashier prepares the following change:");


    // ------------------------------------------------------------------------
    // STAGE $20 CHANGE
    // ------------------------------------------------------------------------

    while (
        changeNeeded > 19 &&
        availableTwenties > 0)
    {
        availableTwenties--;

        changeNeeded -=
            20;

        Console.WriteLine(
            "\t A twenty");
    }


    // ------------------------------------------------------------------------
    // STAGE $10 CHANGE
    // ------------------------------------------------------------------------

    while (
        changeNeeded > 9 &&
        availableTens > 0)
    {
        availableTens--;

        changeNeeded -=
            10;

        Console.WriteLine(
            "\t A ten");
    }


    // ------------------------------------------------------------------------
    // STAGE $5 CHANGE
    // ------------------------------------------------------------------------
    //
    // The Guided Project already corrected the earlier denomination-index bug:
    //
    // correct index for $5 bills = 1

    while (
        changeNeeded > 4 &&
        availableFives > 0)
    {
        availableFives--;

        changeNeeded -=
            5;

        Console.WriteLine(
            "\t A five");
    }


    // ------------------------------------------------------------------------
    // STAGE $1 CHANGE
    // ------------------------------------------------------------------------

    while (
        changeNeeded > 0 &&
        availableOnes > 0)
    {
        availableOnes--;

        changeNeeded--;

        Console.WriteLine(
            "\t A one");
    }


    // ------------------------------------------------------------------------
    // FAILURE CASE 2: EXACT CHANGE CANNOT BE MADE
    // ------------------------------------------------------------------------
    //
    // If changeNeeded is still positive, the staged bill inventory cannot
    // produce the required exact change.
    //
    // Crucially, cashTill still has NOT been modified.
    //
    // Throwing here therefore performs an implicit rollback simply by
    // discarding the local staged variables.

    if (changeNeeded > 0)
    {
        throw new InvalidOperationException(
            "InvalidOperationException: The till is unable to make change " +
            "for the cash provided.");
    }


    // ------------------------------------------------------------------------
    // COMMIT THE TRANSACTION
    // ------------------------------------------------------------------------
    //
    // Reaching this point means:
    //
    // - payment was sufficient; and
    // - exact change was successfully staged.
    //
    // Only now is the real till updated.
    //
    // This is the key fix that makes the operation atomic from the caller's
    // perspective.

    cashTill[0] =
        availableOnes;

    cashTill[1] =
        availableFives;

    cashTill[2] =
        availableTens;

    cashTill[3] =
        availableTwenties;
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