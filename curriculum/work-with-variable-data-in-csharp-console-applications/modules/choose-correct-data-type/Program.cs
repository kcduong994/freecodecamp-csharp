/*
 * Module: Choose the Correct Data Type in Your C# Code
 * Section: Work with Variable Data in C# Console Applications
 *
 * Purpose:
 * - Explain how computers represent data with bits and bytes.
 * - Compare value types with reference types.
 * - Inspect the ranges of integral and floating-point types.
 * - Demonstrate the effect of assigning value types and reference types.
 * - Apply practical rules for choosing an appropriate C# data type.
 *
 * This file preserves the complete instructional flow in one runnable program.
 * The comments explain intent and design decisions rather than repeating every
 * statement in plain English.
 */

Console.WriteLine("CHOOSE THE CORRECT DATA TYPE IN YOUR C# CODE");
Console.WriteLine("============================================");
Console.WriteLine();

/*
 * SECTION 1 — DATA, BITS, BYTES, AND TEXT
 * ----------------------------------------
 * A bit stores one binary state: 0 or 1.
 * Eight bits form one byte, which can represent 256 combinations:
 * 00000000 through 11111111.
 *
 * The decimal number 195 is represented by the binary value 11000011:
 *
 * Position value: 128  64  32  16   8   4   2   1
 * Stored bit:       1   1   0   0   0   0   1   1
 *
 * 128 + 64 + 2 + 1 = 195
 */

Console.WriteLine("1. Data represented as bits");
Console.WriteLine("---------------------------");

const byte decimalNumber = 195;
string binaryNumber = Convert
    .ToString(decimalNumber, 2)
    .PadLeft(8, '0');

Console.WriteLine(
    $"Decimal {decimalNumber} is binary {binaryNumber}.");

/*
 * Text is also stored numerically.
 *
 * The lowercase character 'a' has the decimal code 97 in ASCII.
 * Its eight-bit binary representation is 01100001.
 *
 * C# char values use Unicode, which includes the ASCII character range.
 */
const char lowercaseLetter = 'a';
int characterCode = lowercaseLetter;

string binaryCharacterCode = Convert
    .ToString(characterCode, 2)
    .PadLeft(8, '0');

Console.WriteLine(
    $"Character '{lowercaseLetter}' has code {characterCode} " +
    $"and binary representation {binaryCharacterCode}.");

Console.WriteLine();

/*
 * SECTION 2 — SIMPLE VALUE TYPES
 * ------------------------------
 * A C# keyword such as int is an alias for a type in the .NET type system.
 * For example:
 *
 * int  -> System.Int32
 * bool -> System.Boolean
 * char -> System.Char
 *
 * A value-type variable directly contains its value. Assigning one value-type
 * variable to another copies that value.
 */

Console.WriteLine("2. C# aliases for .NET value types");
Console.WriteLine("----------------------------------");

bool intAliasMatchesSystemType =
    typeof(int) == typeof(System.Int32);

bool boolAliasMatchesSystemType =
    typeof(bool) == typeof(System.Boolean);

bool charAliasMatchesSystemType =
    typeof(char) == typeof(System.Char);

Console.WriteLine(
    $"int  is System.Int32   : {intAliasMatchesSystemType}");
Console.WriteLine(
    $"bool is System.Boolean : {boolAliasMatchesSystemType}");
Console.WriteLine(
    $"char is System.Char    : {charAliasMatchesSystemType}");

Console.WriteLine();

/*
 * SECTION 3 — SIGNED INTEGRAL TYPES
 * ---------------------------------
 * Integral types represent whole numbers without a fractional part.
 *
 * Signed integral types reserve part of their range for negative values.
 * MinValue and MaxValue expose the exact boundaries supported by each type.
 */

Console.WriteLine("3. Signed integral types");
Console.WriteLine("------------------------");

Console.WriteLine(
    $"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine(
    $"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine(
    $"int   : {int.MinValue} to {int.MaxValue}");
Console.WriteLine(
    $"long  : {long.MinValue} to {long.MaxValue}");

Console.WriteLine();

/*
 * SECTION 4 — UNSIGNED INTEGRAL TYPES
 * -----------------------------------
 * Unsigned types do not represent negative values. All available bit patterns
 * are therefore used for zero and positive values.
 *
 * byte is especially common for raw binary data, encoded files, network data,
 * images, and other information exchanged as sequences of bytes.
 */

Console.WriteLine("4. Unsigned integral types");
Console.WriteLine("--------------------------");

Console.WriteLine(
    $"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine(
    $"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine(
    $"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine(
    $"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

byte[] fileHeader =
{
    0x45, // E
    0x46, // F
    0x44, // D
    0x43  // C
};

string decodedHeader = System.Text.Encoding.ASCII
    .GetString(fileHeader);

Console.WriteLine();
Console.WriteLine(
    $"Example byte array decoded as ASCII: {decodedHeader}");

Console.WriteLine();

/*
 * SECTION 5 — FLOATING-POINT TYPES
 * --------------------------------
 * float, double, and decimal represent values with fractional components.
 *
 * The correct choice depends on more than minimum and maximum range:
 *
 * float:
 * - approximately 6–9 significant decimal digits;
 * - small memory footprint;
 * - useful when lower precision is acceptable.
 *
 * double:
 * - approximately 15–17 significant decimal digits;
 * - the common default for scientific, geometric, and engineering values;
 * - uses binary floating-point representation.
 *
 * decimal:
 * - approximately 28–29 significant decimal digits;
 * - uses a decimal-oriented representation;
 * - well suited to financial calculations and other base-10 quantities where
 *   predictable decimal arithmetic is important.
 *
 * Neither double nor decimal has unlimited precision. The important question is
 * whether the representation and precision match the application's domain.
 */

Console.WriteLine("5. Floating-point types");
Console.WriteLine("-----------------------");

Console.WriteLine(
    $"float   : {float.MinValue} to {float.MaxValue}");
Console.WriteLine(
    "          approximately 6-9 significant digits");

Console.WriteLine(
    $"double  : {double.MinValue} to {double.MaxValue}");
Console.WriteLine(
    "          approximately 15-17 significant digits");

Console.WriteLine(
    $"decimal : {decimal.MinValue} to {decimal.MaxValue}");
Console.WriteLine(
    "          approximately 28-29 significant digits");

/*
 * Binary floating-point cannot represent every base-10 fraction exactly.
 * The classic 0.1 + 0.2 example makes that difference visible.
 */
double binaryFloatingPointSum = 0.1 + 0.2;
decimal decimalFloatingPointSum = 0.1M + 0.2M;

Console.WriteLine();
Console.WriteLine(
    $"double  0.1 + 0.2 = {binaryFloatingPointSum:R}");
Console.WriteLine(
    $"decimal 0.1 + 0.2 = {decimalFloatingPointSum}");

/*
 * E notation is scientific notation.
 *
 * 5E+2 means:
 * 5 × 10² = 500
 */
const double scientificNotationValue = 5E+2;

Console.WriteLine(
    $"Scientific notation 5E+2 equals {scientificNotationValue}.");

Console.WriteLine();

/*
 * SECTION 6 — CREATING REFERENCE-TYPE INSTANCES
 * ---------------------------------------------
 * Arrays, strings, and classes are reference types.
 *
 * The new keyword asks the runtime to create a new object instance. The
 * reference variable then identifies that object.
 *
 * The most important beginner-level distinction is assignment behavior:
 * - assigning a value type copies its value;
 * - assigning a reference type copies the reference.
 *
 * Technical clarification:
 * It is useful to learn "value types on the stack and objects on the heap" as
 * an introductory model, but it is not an absolute storage rule. Actual storage
 * depends on context and runtime implementation. Copy semantics are the more
 * reliable language-level distinction.
 */

Console.WriteLine("6. Creating reference-type instances");
Console.WriteLine("------------------------------------");

/*
 * Declaration and object creation can be written as separate operations.
 */
int[] declaredThenCreatedData;
declaredThenCreatedData = new int[3];

/*
 * Every element of a newly created int array starts with int's default value: 0.
 */
Console.WriteLine(
    "New int[3] default values: " +
    $"[{string.Join(", ", declaredThenCreatedData)}]");

/*
 * Declaration and creation are more commonly combined on one line.
 */
int[] singleLineData = new int[3];

singleLineData[0] = 10;
singleLineData[1] = 20;
singleLineData[2] = 30;

Console.WriteLine(
    "Assigned int[3] values   : " +
    $"[{string.Join(", ", singleLineData)}]");

/*
 * string is a reference type, but C# provides convenient literal syntax.
 * Writing a string literal creates the required string object behind the scenes.
 */
string greeting = "Hello World!";

Console.WriteLine($"String value             : {greeting}");

Console.WriteLine();

/*
 * SECTION 7 — VALUE-TYPE ASSIGNMENT
 * ---------------------------------
 * valueB receives a copy of valueA's current value.
 * Changing valueB later does not change valueA.
 */

Console.WriteLine("7. Value-type assignment copies the value");
Console.WriteLine("-----------------------------------------");

int valueA = 2;
int valueB = valueA;

valueB = 5;

Console.WriteLine($"valueA: {valueA}");
Console.WriteLine($"valueB: {valueB}");

Console.WriteLine();

/*
 * SECTION 8 — REFERENCE-TYPE ASSIGNMENT
 * -------------------------------------
 * referenceB receives a copy of referenceA's reference.
 * Both variables therefore identify the same array object.
 *
 * Changing the shared object through referenceB is visible through referenceA.
 */

Console.WriteLine("8. Reference-type assignment copies the reference");
Console.WriteLine("-------------------------------------------------");

int[] referenceA = new int[1];
referenceA[0] = 2;

int[] referenceB = referenceA;
referenceB[0] = 5;

Console.WriteLine($"referenceA[0]: {referenceA[0]}");
Console.WriteLine($"referenceB[0]: {referenceB[0]}");
Console.WriteLine(
    $"Same array object: {ReferenceEquals(referenceA, referenceB)}");

Console.WriteLine();

/*
 * SECTION 9 — CHOOSING THE RIGHT DATA TYPE
 * ----------------------------------------
 * A practical selection process:
 *
 * 1. Identify the meaning of the data.
 * 2. Determine whether fractional values are required.
 * 3. Determine the valid minimum and maximum values.
 * 4. Decide whether negative values are meaningful.
 * 5. Match the types expected by .NET APIs, databases, and external systems.
 * 6. Prefer clarity and domain correctness over premature optimization.
 *
 * Reliable defaults:
 * - int     for most whole numbers;
 * - double  for most scientific and engineering measurements;
 * - decimal for money and base-10 financial calculations;
 * - bool    for true/false state;
 * - string  for text and identifiers that are not used arithmetically;
 * - DateTime for a point in calendar time;
 * - TimeSpan for a duration;
 * - byte[]  for binary data.
 */

Console.WriteLine("9. Practical data-type choices");
Console.WriteLine("------------------------------");

/*
 * Whole-number count:
 * int is simple, widely supported, and easily accepted by .NET APIs.
 */
int computationalCellCount = 15_000;

/*
 * Scientific and engineering measurements:
 * double offers a wide range and about 15–17 significant digits.
 */
double waterLevelMeters = 1.425;
double salinityPpt = 15.114;
double simulationTimeStepSeconds = 10.0;

/*
 * Financial value:
 * decimal is preferred because decimal fractions are central to the domain.
 * The M suffix tells the compiler that the numeric literal is decimal.
 */
decimal projectBudget = 125_000_000.50M;

/*
 * Logical state:
 * bool communicates a two-state condition directly.
 */
bool isCourantConditionSatisfied = true;

/*
 * Text:
 * string is appropriate for names, labels, and identifiers not used in
 * arithmetic calculations.
 */
string monitoringStationName = "Hoa Binh";

/*
 * DateTime represents a specific date and time.
 * TimeSpan represents an elapsed duration rather than a calendar timestamp.
 */
DateTime observationTime =
    new DateTime(2026, 7, 31, 18, 0, 0);

TimeSpan simulationDuration =
    TimeSpan.FromDays(30);

Console.WriteLine(
    $"Computational cells : {computationalCellCount:N0}");
Console.WriteLine(
    $"Water level         : {waterLevelMeters} m");
Console.WriteLine(
    $"Salinity            : {salinityPpt} ppt");
Console.WriteLine(
    $"Time step           : {simulationTimeStepSeconds} s");
Console.WriteLine(
    $"Project budget      : {projectBudget:N2}");
Console.WriteLine(
    $"Courant condition   : {isCourantConditionSatisfied}");
Console.WriteLine(
    $"Monitoring station  : {monitoringStationName}");
Console.WriteLine(
    $"Observation time    : {observationTime:yyyy-MM-dd HH:mm:ss}");
Console.WriteLine(
    $"Simulation duration : {simulationDuration.TotalDays} days");

Console.WriteLine();

/*
 * SECTION 10 — BOUNDARY-BASED SELECTION
 * -------------------------------------
 * Suppose a value is guaranteed to remain between 1 and 10,000.
 *
 * ushort can represent 0 through 65,535, so it can enforce a useful numeric
 * boundary. However, int may still be preferable when surrounding APIs expect
 * int and using ushort would cause repeated conversions.
 *
 * The correct choice therefore depends on both the data boundary and the system
 * in which the value participates.
 */

Console.WriteLine("10. Boundary and interoperability example");
Console.WriteLine("-----------------------------------------");

const ushort boundedRecordNumber = 10_000;
int apiCompatibleRecordNumber = boundedRecordNumber;

Console.WriteLine(
    $"Bounded ushort value : {boundedRecordNumber}");
Console.WriteLine(
    $"Converted for int API: {apiCompatibleRecordNumber}");

Console.WriteLine();

/*
 * FINAL SUMMARY
 * -------------
 * Type selection is a domain-design decision, not merely a search for the
 * smallest possible container.
 *
 * Choose a type that:
 * - represents the meaning of the data clearly;
 * - supports all valid values;
 * - rejects impossible values where practical;
 * - provides sufficient precision;
 * - works cleanly with APIs, databases, and external systems;
 * - remains readable and maintainable.
 */

Console.WriteLine("MODULE SUMMARY");
Console.WriteLine("--------------");
Console.WriteLine(
    "Choose a data type for meaning, range, precision, and interoperability.");
Console.WriteLine(
    "Do not optimize numeric storage before measuring a real performance need.");