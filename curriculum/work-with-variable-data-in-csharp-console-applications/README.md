# Work with Variable Data in C# Console Applications

Section 4 of the **Foundational C# with Microsoft Certification** curriculum.

This section develops practical skills for choosing, converting, formatting,
searching, and manipulating data in C# console applications. Every completed
curriculum item is preserved as a runnable project, registered in the solution,
documented, and verified with both a project build and a full-solution build.

---

## Section Status

```text
Section: Work with Variable Data in C# Console Applications
Status: In progress
Curriculum progress: 3 / 7
Completed instructional modules: 3
Completed guided projects: 0
Completed challenge projects: 0
Latest completed item: Perform Operations on Arrays Using Helper Methods in C#
Microsoft Learn module completion: Completed
Microsoft Learn achievement page: Displayed
Achievement saved to account: Not verified in the signed-out browser session
Latest completion date: August 2, 2026
Projects registered in solution: 23
Latest project run: Verified
Latest project build: Verified
Latest project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 4.4 seconds
Compiler errors: 0
Compiler warnings: 0
Nullable warning CS8602: Resolved
IDE style suggestions IDE0300 and IDE0090: Addressed in final source
Next curriculum item: Format Alphanumeric Data for Presentation in C#
```

| No. | Curriculum item | Status |
| ---: | --- | --- |
| 1 | Choose the Correct Data Type in Your C# Code | Completed |
| 2 | Convert Data Types Using Casting and Conversion Techniques in C# | Completed |
| 3 | Perform Operations on Arrays Using Helper Methods in C# | Completed |
| 4 | Format Alphanumeric Data for Presentation in C# | Pending |
| 5 | Modify the Content of Strings Using Built-In String Data Type Methods in C# | Pending |
| 6 | Guided Project — Work with Variable Data in C# | Pending |
| 7 | Challenge Project — Work with Variable Data in C# | Pending |

A curriculum item is marked `Completed` only after its Microsoft Learn units,
local implementation, solution registration, project build, and full-solution
build have been verified.

For Module 3, Microsoft Learn displayed the achievement completion page, but the
browser session also displayed `Sign in/Create profile`. The repository records
the module as completed while keeping account-level achievement persistence
explicitly unverified until the Microsoft Learn session is signed in.

---

## Repository Structure

```text
work-with-variable-data-in-csharp-console-applications/
├── README.md
└── modules/
    ├── choose-correct-data-type/
    │   ├── Program.cs
    │   └── choose-correct-data-type.csproj
    ├── convert-data-types/
    │   ├── Program.cs
    │   └── convert-data-types.csproj
    └── array-helper-methods/
        ├── Program.cs
        └── array-helper-methods.csproj
```

This section uses one central README for curriculum documentation. Individual
module directories contain executable source code and project files without an
additional README.

A `trophy/` directory will be added after the complete Section 4 learning path
has been finished and the corresponding completion evidence has been earned.

---

# Module 1 — Choose the Correct Data Type in Your C# Code

## Completion Status

```text
Status: Completed
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project added to solution: Verified
Solution project count: 21
Target framework: net10.0
Project build: Succeeded
Project build time: 0.9 seconds
Full solution build: Succeeded
Full solution build time: 3.5 seconds
IDE diagnostics: No issues found
Completion date: July 31, 2026
```

This module explains how C# represents data, how value types differ from
reference types, what ranges and precision are provided by common numeric
types, and how to select a type that matches the meaning and constraints of an
application.

The final `Program.cs` preserves the complete instructional sequence as one
runnable learning reference. It also adds engineering examples that connect
data-type selection to numerical modelling and coastal-engineering workflows.

---

## Learning Objectives

The completed project demonstrates how to:

- explain how bits and bytes represent numeric and textual data;
- distinguish value types from reference types;
- relate C# keywords to their .NET type aliases;
- inspect `MinValue` and `MaxValue` for numeric types;
- compare signed and unsigned integral types;
- compare `float`, `double`, and `decimal`;
- explain numeric range separately from numeric precision;
- use scientific notation in numeric literals;
- create reference-type instances with `new`;
- compare value-type assignment with reference-type assignment;
- select types using meaning, range, precision, and interoperability;
- apply data-type decisions to scientific, engineering, and financial data.

---

## What Is Data?

At the lowest level, computer data is represented by bits.

```text
bit  → one binary state: 0 or 1
byte → eight bits
```

Eight bits provide:

```text
2⁸ = 256 possible combinations
```

The completed project converts the decimal number `195` into binary:

```text
Decimal value: 195
Binary value : 11000011
```

The binary representation can be verified by its positional values:

| Position value | 128 | 64 | 32 | 16 | 8 | 4 | 2 | 1 |
| ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| Stored bit | 1 | 1 | 0 | 0 | 0 | 0 | 1 | 1 |

```text
128 + 64 + 2 + 1 = 195
```

Code:

```csharp
const byte decimalNumber = 195;

string binaryNumber = Convert
    .ToString(decimalNumber, 2)
    .PadLeft(8, '0');

Console.WriteLine(
    $"Decimal {decimalNumber} is binary {binaryNumber}.");
```

---

## Text Is Also Numeric Data

Computers store characters as numeric codes.

The lowercase character `a` corresponds to decimal code `97` in ASCII:

```text
Character: a
Decimal  : 97
Binary   : 01100001
```

Code:

```csharp
const char lowercaseLetter = 'a';
int characterCode = lowercaseLetter;

string binaryCharacterCode = Convert
    .ToString(characterCode, 2)
    .PadLeft(8, '0');
```

The example demonstrates that numbers, letters, symbols, and other forms of
data are ultimately encoded into binary representations.

---

## What Is a Data Type?

A data type defines how a value is represented and what operations are valid for
that value.

A useful data-type decision considers:

```text
Meaning
Range
Precision
Valid operations
Interoperability
Memory and performance requirements
```

A type is not selected merely because it is the smallest available container.
It must represent the domain correctly and work cleanly with the surrounding
application.

---

## C# Keywords and .NET Types

Many C# type keywords are aliases for types in the .NET type system.

| C# keyword | .NET type |
| --- | --- |
| `sbyte` | `System.SByte` |
| `byte` | `System.Byte` |
| `short` | `System.Int16` |
| `ushort` | `System.UInt16` |
| `int` | `System.Int32` |
| `uint` | `System.UInt32` |
| `long` | `System.Int64` |
| `ulong` | `System.UInt64` |
| `float` | `System.Single` |
| `double` | `System.Double` |
| `decimal` | `System.Decimal` |
| `bool` | `System.Boolean` |
| `char` | `System.Char` |

The project verifies selected aliases directly:

```csharp
bool intAliasMatchesSystemType =
    typeof(int) == typeof(System.Int32);

bool boolAliasMatchesSystemType =
    typeof(bool) == typeof(System.Boolean);

bool charAliasMatchesSystemType =
    typeof(char) == typeof(System.Char);
```

Expected output:

```text
int  is System.Int32   : True
bool is System.Boolean : True
char is System.Char    : True
```

---

## Value Types and Reference Types

The most reliable beginner-level distinction is based on assignment semantics.

```text
Value-type assignment
→ copies the value

Reference-type assignment
→ copies the reference to an object
```

### Value-Type Assignment

```csharp
int valueA = 2;
int valueB = valueA;

valueB = 5;
```

Verified result:

```text
valueA: 2
valueB: 5
```

`valueB` received an independent copy of the integer value. Changing `valueB`
does not change `valueA`.

### Reference-Type Assignment

```csharp
int[] referenceA = new int[1];
referenceA[0] = 2;

int[] referenceB = referenceA;
referenceB[0] = 5;
```

Verified result:

```text
referenceA[0]: 5
referenceB[0]: 5
Same array object: True
```

Both variables identify the same array object. Mutating that object through one
reference is visible through the other reference.

### Important Technical Clarification

The simplified explanation that value types are always stored on the stack and
reference-type objects are always stored on the heap is useful only as an
introductory model.

Actual storage depends on context and runtime implementation. Assignment and
copy behaviour provide a more dependable language-level distinction:

```text
Value type     → value copied
Reference type → reference copied
```

---

## Signed Integral Types

Integral types represent whole numbers without a fractional component.

Signed types support negative and positive values.

| Type | Minimum | Maximum |
| --- | ---: | ---: |
| `sbyte` | -128 | 127 |
| `short` | -32,768 | 32,767 |
| `int` | -2,147,483,648 | 2,147,483,647 |
| `long` | -9,223,372,036,854,775,808 | 9,223,372,036,854,775,807 |

The executable project obtains these values from the framework:

```csharp
Console.WriteLine(
    $"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");

Console.WriteLine(
    $"short : {short.MinValue} to {short.MaxValue}");

Console.WriteLine(
    $"int   : {int.MinValue} to {int.MaxValue}");

Console.WriteLine(
    $"long  : {long.MinValue} to {long.MaxValue}");
```

Using `MinValue` and `MaxValue` is safer and clearer than manually memorizing or
retyping type boundaries.

---

## Unsigned Integral Types

Unsigned types represent zero and positive values.

| Type | Minimum | Maximum |
| --- | ---: | ---: |
| `byte` | 0 | 255 |
| `ushort` | 0 | 65,535 |
| `uint` | 0 | 4,294,967,295 |
| `ulong` | 0 | 18,446,744,073,709,551,615 |

Unsigned types use all available bit patterns for non-negative values.

```csharp
Console.WriteLine(
    $"byte   : {byte.MinValue} to {byte.MaxValue}");

Console.WriteLine(
    $"ushort : {ushort.MinValue} to {ushort.MaxValue}");

Console.WriteLine(
    $"uint   : {uint.MinValue} to {uint.MaxValue}");

Console.WriteLine(
    $"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
```

### Binary Data with `byte[]`

`byte` is commonly used for raw binary content, files, encoded data, and network
payloads.

```csharp
byte[] fileHeader =
{
    0x45, // E
    0x46, // F
    0x44, // D
    0x43  // C
};

string decodedHeader = System.Text.Encoding.ASCII
    .GetString(fileHeader);
```

Verified output:

```text
EFDC
```

This example connects the abstract `byte` type to a practical engineering-data
format.

---

## Floating-Point Types

C# provides three common types for values with fractional components.

| Type | Approximate precision | Typical use |
| --- | --- | --- |
| `float` | 6–9 significant decimal digits | graphics, lower-precision data, memory-sensitive arrays |
| `double` | 15–17 significant decimal digits | scientific, geometric, and engineering calculations |
| `decimal` | 28–29 significant decimal digits | money and base-10 financial calculations |

### Range Is Not the Same as Precision

`MinValue` and `MaxValue` describe the representable range. They do not describe
how many significant digits can be represented accurately.

```csharp
Console.WriteLine(
    $"float   : {float.MinValue} to {float.MaxValue}");

Console.WriteLine(
    $"double  : {double.MinValue} to {double.MaxValue}");

Console.WriteLine(
    $"decimal : {decimal.MinValue} to {decimal.MaxValue}");
```

A type can support an enormous range while still being unable to represent every
number inside that range exactly.

---

## Binary Floating-Point and Decimal Arithmetic

`float` and `double` use binary floating-point representation. Many simple
base-10 fractions cannot be represented exactly in binary.

```csharp
double binaryFloatingPointSum = 0.1 + 0.2;
decimal decimalFloatingPointSum = 0.1M + 0.2M;
```

Verified output:

```text
double  0.1 + 0.2 = 0.30000000000000004
decimal 0.1 + 0.2 = 0.3
```

This does not mean that `decimal` is universally better.

```text
double
→ scientific and engineering measurements
→ geometry and numerical modelling
→ broad framework and library compatibility

decimal
→ currency and accounting
→ base-10 financial quantities
→ predictable decimal arithmetic
```

The correct choice depends on the domain.

---

## Numeric Literal Suffixes

Some numeric literals require a suffix to select the intended type.

| Suffix | Type | Example |
| --- | --- | --- |
| `F` or `f` | `float` | `1.25F` |
| `D` or `d` | `double` | `1.25D` |
| `M` or `m` | `decimal` | `1.25M` |
| `L` or `l` | `long` | `125L` |
| `U` or `u` | unsigned integral type | `125U` |
| `UL` or `ul` | `ulong` | `125UL` |

The financial example uses the `M` suffix:

```csharp
decimal projectBudget = 125_000_000.50M;
```

Without the suffix, a literal containing a decimal point is treated as `double`
by default and cannot be assigned implicitly to `decimal`.

---

## Scientific Notation

C# supports scientific notation with `E` or `e`.

```csharp
const double scientificNotationValue = 5E+2;
```

Meaning:

```text
5E+2
= 5 × 10²
= 500
```

Scientific notation is useful for very large and very small physical values.

Examples from scientific computing may include:

```csharp
double gravitationalConstant = 6.67430E-11;
double largeDomainArea = 2.50E+8;
```

---

## Creating Reference Types with `new`

The `new` keyword creates a new object instance.

Declaration and creation can be written separately:

```csharp
int[] declaredThenCreatedData;
declaredThenCreatedData = new int[3];
```

They are more commonly combined:

```csharp
int[] singleLineData = new int[3];
```

A new integer array is initialized with the default value of `int`:

```text
[0, 0, 0]
```

The project then assigns explicit values:

```csharp
singleLineData[0] = 10;
singleLineData[1] = 20;
singleLineData[2] = 30;
```

Result:

```text
[10, 20, 30]
```

`string` is also a reference type, but C# provides convenient literal syntax:

```csharp
string greeting = "Hello World!";
```

The runtime creates and manages the required string object.

---

## Choosing the Correct Type

The completed project uses the following decision process:

```text
1. Identify the meaning of the data
2. Determine whether fractions are required
3. Determine the valid minimum and maximum
4. Determine whether negative values are meaningful
5. Determine the required precision
6. Check API, database, and external-system compatibility
7. Optimize storage only after measuring a real need
```

### Practical Defaults

| Requirement | Common choice |
| --- | --- |
| Most whole numbers | `int` |
| Very large whole numbers | `long` |
| Scientific and engineering values | `double` |
| Financial values | `decimal` |
| True/false state | `bool` |
| One character | `char` |
| Text | `string` |
| Calendar date and time | `DateTime` |
| Duration | `TimeSpan` |
| Raw binary data | `byte[]` |

These are defaults, not absolute rules. Domain constraints and system boundaries
can justify a different choice.

---

## Coastal-Engineering and Numerical-Modelling Examples

The final project applies type selection to realistic engineering data.

```csharp
int computationalCellCount = 15_000;

double waterLevelMeters = 1.425;
double salinityPpt = 15.114;
double simulationTimeStepSeconds = 10.0;

decimal projectBudget = 125_000_000.50M;

bool isCourantConditionSatisfied = true;

string monitoringStationName = "Hoa Binh";

DateTime observationTime =
    new DateTime(2026, 7, 31, 18, 0, 0);

TimeSpan simulationDuration =
    TimeSpan.FromDays(30);
```

| Variable | Type | Reason |
| --- | --- | --- |
| `computationalCellCount` | `int` | whole-number count with broad API compatibility |
| `waterLevelMeters` | `double` | fractional scientific measurement |
| `salinityPpt` | `double` | measured and modelled physical quantity |
| `simulationTimeStepSeconds` | `double` | may require sub-second values |
| `projectBudget` | `decimal` | financial base-10 quantity |
| `isCourantConditionSatisfied` | `bool` | two-state condition |
| `monitoringStationName` | `string` | textual label |
| `observationTime` | `DateTime` | specific timestamp |
| `simulationDuration` | `TimeSpan` | elapsed duration |

Verified output includes:

```text
Computational cells : 15,000
Water level         : 1.425 m
Salinity            : 15.114 ppt
Time step           : 10 s
Project budget      : 125,000,000.50
Courant condition   : True
Monitoring station  : Hoa Binh
Observation time    : 2026-07-31 18:00:00
Simulation duration : 30 days
```

---

## Boundary and Interoperability Example

A numeric boundary does not automatically determine the best type.

Suppose a record number is guaranteed to remain between `1` and `10,000`.

```csharp
const ushort boundedRecordNumber = 10_000;
```

`ushort` can represent this range:

```text
0 through 65,535
```

However, an API may expect `int`:

```csharp
int apiCompatibleRecordNumber = boundedRecordNumber;
```

This demonstrates the difference between two valid concerns:

```text
Domain boundary
→ ushort can enforce a smaller non-negative range

Interoperability
→ int may avoid repeated conversions across .NET APIs
```

The best choice depends on how the value participates in the complete system.

---

## Why `int` Is Usually the Default Whole-Number Type

A smaller type is not automatically a better type.

Using `byte`, `short`, or `ushort` for every small number can introduce:

- repeated conversions;
- less consistent API usage;
- additional cognitive overhead;
- arithmetic promotion back to `int`;
- minimal or unmeasured memory benefit.

For most general whole-number variables:

```csharp
int value = 10_000;
```

is clear, conventional, and widely compatible.

Smaller integral types are most useful when:

- a binary format requires an exact width;
- a file or network protocol defines the representation;
- a large array creates a measured memory constraint;
- domain validation benefits from the smaller range;
- external hardware or unmanaged code requires the type.

---

## Source-Code Organisation

The completed `Program.cs` is divided into ten executable learning sections:

```text
1. Data represented as bits
2. C# aliases for .NET value types
3. Signed integral types
4. Unsigned integral types
5. Floating-point types
6. Creating reference-type instances
7. Value-type assignment
8. Reference-type assignment
9. Practical data-type choices
10. Boundary and interoperability example
```

Each section uses comments to explain:

- the purpose of the example;
- the relevant C# language rule;
- the reason for choosing a type;
- the expected assignment behaviour;
- the distinction between range and precision;
- the effect of interoperability on design decisions.

The source intentionally avoids comments that merely repeat syntax without
adding technical meaning.

---

## Source-Code Cleanup

The original study notes preserved the complete Microsoft Learn sequence, but
they also contained material that could not compile as one executable file.

The final version corrects or reorganises:

```text
Unused using directives
Repeated variable names in the same top-level scope
Multiple declarations of int[] data
Instructional fragments that were not complete statements
Separate examples that needed unique variable names
Narrative learning notes mixed directly with executable code
A simplified stack-versus-heap explanation
Missing practical distinction between numeric range and precision
```

The final source remains faithful to the module while compiling cleanly as one
coherent console application.

---

## Verified Runtime Behaviour

The program ran successfully from beginning to end.

The verified output demonstrated:

```text
Decimal-to-binary conversion
Character-code conversion
C# and .NET alias equivalence
Signed integral ranges
Unsigned integral ranges
byte[] decoding
Floating-point ranges and precision
double versus decimal arithmetic
Scientific notation
new array initialization
Value-type copy behaviour
Reference-type shared-object behaviour
Engineering data-type choices
Boundary and API interoperability
Final module summary
```

Final console summary:

```text
MODULE SUMMARY
--------------

Choose a data type for meaning, range, precision, and interoperability.
Do not optimize numeric storage before measuring a real performance need.
```

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\choose-correct-data-type\choose-correct-data-type.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\choose-correct-data-type\choose-correct-data-type.csproj"
```

Build the full solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded
Module build time: 0.9 seconds
Full solution build: Succeeded
Full solution build time: 3.5 seconds
Solution projects: 21
Target framework: net10.0
IDE diagnostics: No issues found
Verification date: July 31, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| data type | `/ˈdeɪ.tə taɪp/` | “đây-tờ tai-p” | kiểu dữ liệu |
| value type | `/ˈvæl.juː taɪp/` | “va-liu tai-p” | kiểu giá trị |
| reference type | `/ˈref.ər.əns taɪp/` | “ré-phờ-rần-x tai-p” | kiểu tham chiếu |
| integral type | `/ˈɪn.tɪ.ɡrəl taɪp/` | “in-ti-grồ tai-p” | kiểu số nguyên |
| floating-point | `/ˌfləʊ.tɪŋ ˈpɔɪnt/` | “phlâu-ting poi-nt” | số dấu phẩy động |
| precision | `/prɪˈsɪʒ.ən/` | “prì-si-giần” | số chữ số có nghĩa được biểu diễn đáng tin cậy |
| range | `/reɪndʒ/` | “râyn-ch” | miền giá trị |
| signed | `/saɪnd/` | “sai-nd” | có miền số âm và số dương |
| unsigned | `/ʌnˈsaɪnd/` | “ần-sai-nd” | chỉ có zero và số dương |
| alias | `/ˈeɪ.li.əs/` | “ây-li-ợt” | tên thay thế cho một kiểu khác |
| instance | `/ˈɪn.stəns/` | “in-stần-x” | một đối tượng cụ thể được tạo từ một kiểu |
| binary | `/ˈbaɪ.nər.i/` | “bai-nờ-ri” | hệ nhị phân dùng `0` và `1` |
| interoperability | `/ˌɪn.tərˌɒp.ər.əˈbɪl.ə.ti/` | “in-tờ-róp-pờ-rờ-bi-lờ-ti” | khả năng tương tác giữa các hệ thống |
| significant digit | `/sɪɡˌnɪf.ɪ.kənt ˈdɪdʒ.ɪt/` | “sig-ni-fi-cần-t đi-jịt” | chữ số có nghĩa |
| scientific notation | `/ˌsaɪənˈtɪf.ɪk nəʊˈteɪ.ʃən/` | “sai-ần-ti-fịch nâu-tây-shần” | ký hiệu khoa học dùng lũy thừa của 10 |

---

## Completion Record

```text
Curriculum item: Choose the Correct Data Type in Your C# Code
Section: Work with Variable Data in C# Console Applications
Module position: 1 / 7
Module units: 8 / 8
Status: Completed
Module assessment: Passed
Achievement: Earned
Local run: Verified
Project registration: Verified
Project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 3.5 seconds
Solution project count: 21
Target framework: net10.0
IDE diagnostics: No issues found
Completion date: July 31, 2026
```

---

# Module 2 — Convert Data Types Using Casting and Conversion Techniques in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: 9 / 9
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project added to solution: Verified
Solution project count: 22
Target framework: net10.0
Project build: Succeeded
Project build time: 1.0 seconds
Full solution build: Succeeded
Full solution build time: 4.0 seconds
IDE diagnostics: No issues found
Completion date: August 1, 2026
```

This module explains how to convert values between C# data types while
controlling two principal risks:

```text
Runtime exception risk
Information-loss risk
```

The final `Program.cs` preserves the complete Microsoft Learn sequence as one
runnable console application. Intentionally invalid examples are retained in
comments, while each executable example is isolated in a focused method.

---

## Learning Objectives

The completed project demonstrates how to:

- distinguish string concatenation from numeric addition;
- explain why the compiler permits some conversions but rejects others;
- perform implicit widening conversions;
- perform explicit casts for narrowing conversions;
- identify range and precision loss;
- convert values to text with `ToString()`;
- convert known-valid numeric text with `Parse()`;
- use methods on the `Convert` class;
- distinguish truncation from rounding;
- convert untrusted text safely with `TryParse()`;
- use `out` parameters;
- process mixed numeric and alphabetic strings;
- produce arithmetic results in required numeric types;
- preserve culture-independent decimal parsing and output.

---

## Two Questions Before Any Conversion

Before converting a value, the completed application displays two questions:

```text
1. Could this conversion throw an exception at run time?
2. Could this conversion lose range, precision, or other information?
```

These questions determine whether a conversion can be:

```text
Implicit
Explicit
Method-based
Exception-safe
Potentially lossy
```

A conversion technique should not be chosen only because it compiles. The
developer must also evaluate whether the result preserves the intended meaning
of the data.

---

## Compiler Conversion Rules

The following code is intentionally invalid:

```csharp
int first = 2;
string second = "4";
int result = first + second;
```

Compiler result:

```text
CS0029:
Cannot implicitly convert type 'string' to 'int'
```

The compiler cannot assume that every `string` contains numeric text. The value
could later be:

```text
"hello"
```

which cannot be converted to an integer.

The opposite expression is valid:

```csharp
int firstNumber = 2;
string secondText = "4";

string concatenatedResult =
    firstNumber + secondText;
```

Output:

```text
24
```

This is not the mathematical sum `6`. Because one operand is a `string`, the `+`
operator performs string concatenation.

```text
2 + "4"
→ "2" + "4"
→ "24"
```

The final source retains the invalid example in comments so the compiler rule
remains documented without breaking the project.

---

## Implicit Widening Conversion

A widening conversion moves a value from a type with a narrower representation
to a type that can safely hold the source value.

```csharp
int integerValue = 3;
decimal decimalValue = integerValue;
```

Output:

```text
int value     : 3
decimal value : 3
```

The compiler performs the conversion implicitly because every `int` value can
be represented by `decimal`.

```text
Source      : int
Destination : decimal
Information loss: no
Explicit cast required: no
```

**Implicit conversion**  
/ɪmˈplɪs.ɪt kənˈvɜː.ʃən/ — chuyển đổi ngầm định.

**Widening conversion**  
/ˈwaɪ.dən.ɪŋ kənˈvɜː.ʃən/ — chuyển đổi mở rộng.

---

## Explicit Casting and Narrowing Conversion

A narrowing conversion moves a value into a type that may not preserve all
source information.

```csharp
decimal decimalValue = 3.14M;
int integerValue = (int)decimalValue;
```

Output:

```text
Original decimal : 3.14
Casted int       : 3
```

The cast operator:

```csharp
(int)
```

communicates that the possible information loss is understood and intentional.

```text
Source      : decimal
Destination : int
Possible loss: fractional component
Explicit cast required: yes
```

**Explicit cast**  
/ɪkˈsplɪs.ɪt kɑːst/ — ép kiểu tường minh.

**Narrowing conversion**  
/ˈnær.əʊ.ɪŋ kənˈvɜː.ʃən/ — chuyển đổi thu hẹp.

---

## Precision Loss Between Fractional Types

Information can be lost even when both types support fractional values.

```csharp
decimal highPrecisionValue = 1.23456789M;

float reducedPrecisionValue =
    (float)highPrecisionValue;
```

Typical output:

```text
decimal : 1.23456789
float   : 1.2345679
```

`float` preserves fewer significant digits than `decimal`, so the final digits
change during conversion.

This demonstrates that narrowing conversion is not limited to converting a
fractional type into an integer type. It can also occur when converting between
fractional types with different precision.

---

## Convert Values to Text with `ToString()`

Every .NET type derives a textual representation through `ToString()`.

```csharp
int firstNumber = 5;
int secondNumber = 7;

string message =
    firstNumber.ToString() +
    secondNumber.ToString();
```

Output:

```text
57
```

The operation is:

```text
5
→ "5"

7
→ "7"

"5" + "7"
→ "57"
```

`ToString()` is useful when values must be:

- displayed;
- written to a text file;
- included in a message;
- serialized into a textual format;
- combined with other text.

The final source uses `CultureInfo.InvariantCulture` where stable
culture-independent text is required.

---

## Convert Known-Valid Text with `Parse()`

Numeric types provide a `Parse()` method.

```csharp
string firstText = "5";
string secondText = "7";

int sum =
    int.Parse(firstText) +
    int.Parse(secondText);
```

Output:

```text
12
```

`Parse()` is appropriate when:

```text
The input is guaranteed to be valid
or
The application deliberately handles conversion exceptions
```

The following code is intentionally retained in comments:

```csharp
string invalidText = "Bob";
int invalidNumber = int.Parse(invalidText);
```

Runtime result:

```text
FormatException
```

For user input, files, imported datasets, and external services, `TryParse()` is
usually safer.

---

## Convert Values with the `Convert` Class

The .NET `Convert` class provides conversion methods such as:

```text
Convert.ToInt32()
Convert.ToDouble()
Convert.ToDecimal()
Convert.ToString()
Convert.ToBoolean()
```

Example:

```csharp
string firstText = "5";
string secondText = "7";

int product =
    Convert.ToInt32(firstText) *
    Convert.ToInt32(secondText);
```

Output:

```text
35
```

The method is named `ToInt32()` because:

```text
C# keyword : int
.NET type   : System.Int32
```

The `Convert` class belongs to the .NET Class Library and therefore uses the
.NET type name.

For strings that may be invalid, the project still recommends `TryParse()`
because it reports failure without throwing a formatting exception.

---

## Casting Truncates

Casting a fractional value to an integer removes the fractional component.

```csharp
decimal sourceValue = 1.5M;
int castResult = (int)sourceValue;
```

Output:

```text
1
```

The same rule applies to:

```csharp
(int)1.999M
```

Result:

```text
1
```

Casting does not round. It truncates toward zero.

Examples:

| Source | Cast to `int` |
| ---: | ---: |
| `1.9M` | `1` |
| `1.1M` | `1` |
| `-1.9M` | `-1` |
| `-1.1M` | `-1` |

**Truncation**  
/trʌŋˈkeɪ.ʃən/ — cắt bỏ phần thập phân.

---

## `Convert.ToInt32()` Rounds

```csharp
decimal sourceValue = 1.5M;

int convertedResult =
    Convert.ToInt32(sourceValue);
```

Output:

```text
2
```

Unlike a cast, `Convert.ToInt32()` rounds to the nearest integer.

The final source records an important technical detail:

```text
Convert.ToInt32() does not simply "round up."
```

For exact midpoint values it uses midpoint-to-even rounding:

```text
2.5 → 2
3.5 → 4
```

This behaviour is also known as banker's rounding and reduces cumulative bias
across many rounding operations.

Comparison:

| Operation | `1.5M` result | Behaviour |
| --- | ---: | --- |
| `(int)1.5M` | `1` | truncates |
| `Convert.ToInt32(1.5M)` | `2` | rounds |
| `(int)1.999M` | `1` | truncates |
| `Convert.ToInt32(1.499M)` | `1` | rounds |

---

## Safely Convert Strings with `TryParse()`

`TryParse()` performs three related operations:

```text
1. Attempts the conversion
2. Stores the converted value in an out parameter
3. Returns true or false
```

Example:

```csharp
string validText = "102";
int parsedMeasurement;

bool conversionSucceeded =
    int.TryParse(
        validText,
        out parsedMeasurement);
```

Successful result:

```text
conversionSucceeded = true
parsedMeasurement   = 102
```

The parsed value can be used inside the condition:

```csharp
if (conversionSucceeded)
{
    Console.WriteLine(
        $"Measurement: {parsedMeasurement}");
}
```

It can also be used later because the variable was declared outside the
conditional block:

```csharp
if (parsedMeasurement > 0)
{
    Console.WriteLine(
        $"Measurement with offset: {50 + parsedMeasurement}");
}
```

Verified output:

```text
Measurement: 102
Measurement with offset: 152
```

---

## Failed `TryParse()` Conversion

```csharp
string invalidText = "bad";

bool succeeded =
    int.TryParse(
        invalidText,
        out int result);
```

Result:

```text
succeeded = false
result    = 0
```

The program does not throw `FormatException`.

However, `result == 0` must not be used alone to determine failure because:

```text
"0"
```

is valid numeric text and also produces `0`.

Correct logic:

```csharp
if (succeeded)
{
    // Use result.
}
else
{
    // Handle invalid input.
}
```

The Boolean return value is the authoritative success indicator.

---

## `out` Parameters

An `out` parameter allows a method to communicate an additional result through
one of its parameters.

```csharp
int.TryParse(
    validText,
    out parsedMeasurement);
```

The method communicates:

```text
Primary return value:
bool success status

out parameter:
converted integer
```

This differs from an ordinary input parameter because the called method is
responsible for assigning the `out` value before returning.

**Out parameter**  
/aʊt pəˈræm.ɪ.tər/ — tham số đầu ra.

---

## Culture-Independent Numeric Conversion

The final project uses:

```csharp
CultureInfo.InvariantCulture
```

for stable numeric parsing and formatting.

Example:

```csharp
decimal.TryParse(
    value,
    NumberStyles.Number,
    CultureInfo.InvariantCulture,
    out decimal numericValue);
```

This ensures that:

```text
"12.3"
```

uses the period as its decimal separator regardless of the Windows regional
settings.

This is important when processing:

- engineering datasets;
- configuration files;
- machine-readable formats;
- network messages;
- test data;
- data exchanged between countries.

User-facing input may instead need an explicitly selected local culture.

---

## Challenge 1 — Combine String Values as Text and Numbers

Starter data:

```csharp
string[] values =
{
    "12.3",
    "45",
    "ABC",
    "11",
    "DEF"
};
```

Business rules:

```text
Numeric value
→ add to total

Non-numeric value
→ append to message
```

Implementation:

```csharp
decimal numericTotal = 0M;
string textMessage = string.Empty;

foreach (string value in values)
{
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
```

Verified output:

```text
Message: ABCDEF
Total: 68.3
```

Calculation:

```text
12.3 + 45 + 11 = 68.3
ABC + DEF       = ABCDEF
```

This challenge demonstrates how `TryParse()` can also be used for data
classification:

```text
Parse succeeds
→ numeric branch

Parse fails
→ text branch
```

---

## Challenge 2 — Output Operations as Specific Number Types

Starter values:

```csharp
int value1 = 11;
decimal value2 = 6.2M;
float value3 = 4.3F;
```

Required outputs:

```text
result1 → int
result2 → decimal
result3 → float
```

### Result 1 — Rounded `int`

```csharp
int result1 =
    Convert.ToInt32(value1 / value2);
```

`value1 / value2` produces a `decimal`. `Convert.ToInt32()` is used because the
result must be rounded rather than truncated.

Verified output:

```text
2
```

A cast would produce the wrong result:

```csharp
(int)(value1 / value2)
```

because the fractional result would be truncated to `1`.

### Result 2 — `decimal`

```csharp
decimal result2 =
    value2 / (decimal)value3;
```

C# does not allow direct arithmetic between `decimal` and `float`. Casting
`value3` to `decimal` gives both operands a compatible type.

Verified output:

```text
1.4418604651162790697674418605
```

### Result 3 — `float`

```csharp
float result3 =
    value3 / value1;
```

The `int` operand is converted implicitly to `float`.

Verified output:

```text
0.3909091
```

Complete verified output:

```text
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3909091
```

---

## Conversion Decision Guide

| Situation | Preferred technique |
| --- | --- |
| Destination safely represents all source values | Implicit conversion |
| Information may be lost and the loss is intentional | Explicit cast |
| Convert a value to text | `ToString()` |
| Numeric text is guaranteed to be valid | `Parse()` |
| Text may be invalid | `TryParse()` |
| Use a .NET conversion helper | `Convert` |
| Fractional to integer with truncation | Explicit cast |
| Fractional to integer with rounding | `Convert.ToInt32()` |

Practical decision sequence:

```text
Can the conversion throw?
    ↓
Can the conversion lose information?
    ↓
Is truncation or rounding required?
    ↓
Is the source trusted?
    ↓
What culture defines the text format?
    ↓
Which output type is required?
```

---

## Source-Code Organisation

The final application uses focused methods:

```text
Main()
├── WriteApplicationHeader()
├── DemonstrateCompilerConversionRules()
├── DemonstrateWideningConversion()
├── DemonstrateExplicitCasting()
├── DemonstratePrecisionLoss()
├── DemonstrateToString()
├── DemonstrateParse()
├── DemonstrateConvertClass()
├── CompareCastingAndConvert()
├── DemonstrateTryParse()
├── RunMixedStringArrayChallenge()
├── RunSpecificNumberTypeChallenge()
└── WriteModuleSummary()
```

This structure provides:

- isolated variable scope;
- no duplicate top-level declarations;
- independently reviewable examples;
- consistent output headings;
- reusable formatting helpers;
- comments that explain intent and risk;
- one executable file containing the complete lesson.

The source uses:

```csharp
internal static class Program
```

and a conventional:

```csharp
private static void Main()
```

entry point rather than accumulating all lesson fragments as top-level
statements.

---

## Source-Code Cleanup

The original lesson notes contained many intentionally separate fragments. When
combined into one file, those fragments included:

```text
Repeated variable declarations
Unused using directives
An intentionally invalid int-plus-string assignment
An intentionally failing Parse("Bob") example
Repeated names such as first, second, value, and result
Multiple complete challenge solutions in one top-level scope
Narrative text mixed with executable code
Single-line if statements without braces
Culture-dependent decimal parsing
An oversimplified description of Convert.ToInt32() as always rounding up
```

The final source:

- keeps invalid examples in comments;
- gives each executable example its own method;
- uses descriptive variable names;
- uses braces consistently;
- uses `CultureInfo.InvariantCulture` for stable examples;
- documents midpoint-to-even rounding;
- separates conversion success from the parsed numeric value;
- preserves both official challenges;
- compiles and runs as a single coherent application.

---

## Verified Runtime Behaviour

The project ran successfully from beginning to end.

Verified behaviour includes:

```text
String concatenation versus numeric addition
Implicit int-to-decimal conversion
Explicit decimal-to-int casting
decimal-to-float precision loss
ToString() conversion
Parse() conversion
Convert.ToInt32() conversion
Casting truncation
Convert rounding
Successful TryParse()
Failed TryParse()
out-parameter behaviour
Mixed string-array challenge
Specific-number-type challenge
Final conversion decision summary
```

Final console summary:

```text
MODULE SUMMARY
--------------

Implicit conversion : use when the destination safely represents the source value.
Explicit cast       : use when information may be lost and that loss is intentional.
ToString()           : convert a value to its textual representation.
Parse()              : use for numeric text known to be valid.
TryParse()           : use for user, file, or external text that may be invalid.
Convert              : use a .NET conversion helper, especially when rounding is required.

Always consider both exception risk and information loss.
```

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\convert-data-types\convert-data-types.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\convert-data-types\convert-data-types.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded
Module build time: 1.0 seconds
Full solution build: Succeeded
Full solution build time: 4.0 seconds
Solution projects: 22
Target framework: net10.0
IDE diagnostics: No issues found
Verification date: August 1, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| convert | `/kənˈvɜːt/` | “cần-vớt” | chuyển đổi |
| conversion | `/kənˈvɜː.ʃən/` | “cần-vơ-shần” | sự chuyển đổi |
| cast | `/kɑːst/` | “ca-st” | ép kiểu |
| implicit | `/ɪmˈplɪs.ɪt/` | “im-pli-xịt” | ngầm định |
| explicit | `/ɪkˈsplɪs.ɪt/` | “ịch-spli-xịt” | tường minh |
| widening conversion | `/ˈwaɪ.dən.ɪŋ kənˈvɜː.ʃən/` | “wai-đờ-ning cần-vơ-shần” | chuyển đổi mở rộng |
| narrowing conversion | `/ˈnær.əʊ.ɪŋ kənˈvɜː.ʃən/` | “na-râu-ing cần-vơ-shần” | chuyển đổi thu hẹp |
| truncation | `/trʌŋˈkeɪ.ʃən/` | “trâng-kây-shần” | cắt bỏ phần dư |
| rounding | `/ˈraʊn.dɪŋ/` | “rao-đing” | làm tròn |
| exception | `/ɪkˈsep.ʃən/` | “ịch-xép-shần” | ngoại lệ runtime |
| parse | `/pɑːz/` | “pa-z” | phân tích và chuyển chuỗi |
| out parameter | `/aʊt pəˈræm.ɪ.tər/` | “ao-t pờ-ra-mi-tờ” | tham số đầu ra |
| information loss | `/ˌɪn.fəˈmeɪ.ʃən lɒs/` | “in-phờ-mây-shần lót” | mất thông tin |
| culture | `/ˈkʌl.tʃər/` | “câl-chờ” | quy ước vùng/ngôn ngữ |
| invariant culture | `/ɪnˈveə.ri.ənt ˈkʌl.tʃər/` | “in-ve-ri-ần-t câl-chờ” | quy ước định dạng ổn định, không phụ thuộc vùng |

---

## Completion Record

```text
Curriculum item: Convert Data Types Using Casting and Conversion Techniques in C#
Section: Work with Variable Data in C# Console Applications
Module position: 2 / 7
Module units: 9 / 9
Status: Completed
Module assessment: Passed
Achievement: Earned
Local run: Verified
Project registration: Verified
Project build: Succeeded in 1.0 seconds
Full solution build: Succeeded in 4.0 seconds
Solution project count: 22
Target framework: net10.0
IDE diagnostics: No issues found
Completion date: August 1, 2026
```

---

# Module 3 — Perform Operations on Arrays Using Helper Methods in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: 10 / 10
Microsoft Learn completion page: Displayed
Achievement saved to account: Not verified in signed-out session
Local project run: Verified
Project added to solution: Verified
Solution project count: 23
Target framework: net10.0
Project build: Succeeded
Project build time: 0.9 seconds
Full solution build: Succeeded
Full solution build time: 4.4 seconds
Compiler errors: 0
Compiler warnings: 0
Nullable warning CS8602: Resolved
IDE style suggestions: Addressed in final source
Completion date: August 2, 2026
```

This module demonstrates how arrays and strings can be transformed with helper
methods from the .NET class library.

The lesson uses pallet identifiers and order IDs from a logistics workflow. The
final `Program.cs` preserves the complete Microsoft Learn sequence as one
runnable console application with focused methods, nullable annotations, safe
null handling, and both official challenges.

---

## Learning Objectives

The completed project demonstrates how to:

- sort array elements with `Array.Sort()`;
- reverse the current order with `Array.Reverse()`;
- reset selected elements with `Array.Clear()`;
- distinguish a cleared `null` reference from an empty string;
- avoid `NullReferenceException`;
- resolve nullable warning `CS8602`;
- expand and shrink an array with `Array.Resize()`;
- explain why `Resize()` requires `ref`;
- remove `null` elements by creating a compact array;
- convert a string into `char[]` with `ToCharArray()`;
- construct a string from `char[]`;
- combine array elements with `string.Join()`;
- parse delimited text with `string.Split()`;
- reverse every word while preserving word order;
- parse, sort, and validate order identifiers.

---

## Source-Code Structure

The final application uses a conventional `Program` class and focused methods:

```text
Main()
├── WriteApplicationHeader()
├── DemonstrateSortAndReverse()
├── DemonstrateClear()
├── DemonstrateNullAfterClear()
├── DemonstrateSafeNullAccess()
├── DemonstrateResizeLargerAndSmaller()
├── DemonstrateRemovingNullElements()
├── DemonstrateToCharArrayAndReverse()
├── DemonstrateJoinAndSplit()
├── RunReverseWordsChallenge()
├── RunOrderValidationChallenge()
└── WriteModuleSummary()
```

Reusable output helpers:

```text
PrintStringArray()
PrintNullableStringArray()
WriteSectionHeader()
WriteSectionSeparator()
```

This organisation provides:

- isolated variable scope;
- no duplicate top-level declarations;
- one executable file containing the complete lesson;
- independently reviewable examples;
- comments that explain intent and runtime behaviour;
- explicit handling of nullable array elements;
- consistent console output.

---

## `Array.Sort()`

`Array.Sort()` changes the order of elements in the existing array.

```csharp
string[] pallets =
[
    "B14",
    "A11",
    "B12",
    "A13"
];

Array.Sort(pallets);
```

Result:

```text
A11
A13
B12
B14
```

The operation is performed **in place**:

```text
Input variable:
pallets

Method call:
Array.Sort(pallets)

Result:
the same array object now contains its elements in sorted order
```

The method does not return a second sorted array.

---

## `Array.Reverse()`

`Array.Reverse()` flips the current element order.

```csharp
Array.Reverse(pallets);
```

After sorting, the result is:

```text
B14
B12
A13
A11
```

Important distinction:

```text
Reverse()
→ reverses the current order

Descending sort
→ requires an ordering operation followed by reversal,
  or another explicit descending comparison
```

For an unsorted array:

```text
B14, A11, B12, A13
```

calling only `Reverse()` produces:

```text
A13, B12, A11, B14
```

It does not automatically produce alphanumeric descending order.

---

## `Array.Clear()`

`Array.Clear()` resets a selected range to the element type's default value.

```csharp
Array.Clear(
    pallets,
    index: 0,
    length: 2);
```

Parameters:

```text
pallets  → array to modify
index    → first element to clear
length   → number of elements to clear
```

For a nullable string array:

```csharp
string?[] pallets =
[
    "B14",
    "A11",
    "B12",
    "A13"
];
```

the result is:

```text
[null, null, "B12", "A13"]
```

For an `int[]`, cleared elements become:

```text
0
```

`Array.Clear()` does not change the array length:

```text
Length before Clear(): 4
Length after Clear() : 4
```

---

## `null` Is Not an Empty String

After clearing a string element, this output:

```csharp
Console.WriteLine($"After: {pallets[0]}");
```

may appear as:

```text
After:
```

The absence of visible text can look like an empty string. The actual value is
`null`.

The completed application verifies it explicitly:

```csharp
Console.WriteLine(
    $"Is pallets[0] null? {pallets[0] is null}");
```

Result:

```text
True
```

The following method call is unsafe:

```csharp
pallets[0].ToLowerInvariant();
```

because there is no `string` object at that array position.

Runtime result without a guard:

```text
NullReferenceException
```

The unsafe example remains in comments so the lesson is preserved without
causing the complete application to terminate.

---

## Nullable Array Declaration

The final code uses:

```csharp
string?[] pallets
```

instead of:

```csharp
string[] pallets
```

for examples where `Array.Clear()` intentionally creates `null` elements.

The nullable annotation communicates the actual data state:

```text
string[]
→ elements are expected to contain non-null string references

string?[]
→ each element may contain a string reference or null
```

This improves compiler analysis and accurately documents the example.

---

## Resolve Warning `CS8602`

The first implementation used this pattern:

```csharp
if (pallets[0] is not null)
{
    Console.WriteLine(
        pallets[0].ToLowerInvariant());
}
```

Visual Studio reported:

```text
CS8602:
Dereference of a possibly null reference
```

### Why the warning occurs

An array element is a mutable storage location. Nullable flow analysis does not
treat repeated reads from that location as one permanently stable value.

Conceptually:

```text
Check pallets[0]
    ↓
Read pallets[0] again
```

The second access is analysed separately.

### Final correction

The array element is copied into a local variable:

```csharp
string? firstPallet = pallets[0];

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
```

The local variable gives nullable flow analysis one stable value to track.

Result:

```text
Compiler warning CS8602: resolved
Project build: 0 warnings
```

This is preferable to suppressing the warning with the null-forgiving operator:

```csharp
pallets[0]!
```

because the local-variable solution proves safety rather than merely instructing
the compiler to trust the developer.

---

## Null-Conditional and Null-Coalescing Operators

The project also demonstrates a compact safe-access pattern:

```csharp
string secondPalletDisplay =
    pallets[1]?.ToLowerInvariant() ??
    "<null>";
```

Processing:

```text
pallets[1] contains a string
→ call ToLowerInvariant()
→ use the returned string

pallets[1] is null
→ ?. returns null
→ ?? supplies "<null>"
```

Operators:

| Operator | Name | Purpose |
| --- | --- | --- |
| `?.` | null-conditional | call a member only when the receiver is non-null |
| `??` | null-coalescing | provide a fallback when the left side is null |

---

## `Array.Resize()`

`Array.Resize()` changes the array length.

```csharp
Array.Resize(
    ref pallets,
    newSize: 6);
```

Growing an array from four to six elements:

```text
Before:
[null, null, "B12", "A13"]

After:
[null, null, "B12", "A13", null, null]
```

The new elements receive the default value for the array element type.

The project then assigns:

```csharp
pallets[4] = "C01";
pallets[5] = "C02";
```

Result:

```text
[null, null, "B12", "A13", "C01", "C02"]
```

---

## Why `Array.Resize()` Uses `ref`

Arrays are reference types, but `Array.Resize()` may allocate a new array object.

The process can be understood as:

```text
1. Allocate an array with the requested size
2. Copy the retained elements
3. Assign the new array reference back to the caller's variable
```

The `ref` keyword allows the method to update the variable itself:

```csharp
Array.Resize(
    ref pallets,
    newSize: 6);
```

Without `ref`, a method would receive only a copy of the original reference and
could not replace the caller's variable with the new array reference.

---

## Shrinking an Array

```csharp
Array.Resize(
    ref pallets,
    newSize: 3);
```

Starting from:

```text
[null, null, "B12", "A13", "C01", "C02"]
```

the result is:

```text
[null, null, "B12"]
```

`Resize()` removes elements from the end. It does not search for `null` values
and compact the array automatically.

Therefore:

```text
Clear()
→ changes selected values to defaults

Resize()
→ changes the number of positions from the end
```

---

## Remove `null` Elements Manually

The lesson explains a fundamental compaction algorithm:

```text
1. Count non-null elements
2. Allocate a new array of that size
3. Copy each non-null element into the new array
```

Source:

```csharp
string?[] sourcePallets =
[
    null,
    null,
    "B12",
    "A13",
    "C01",
    "C02"
];
```

Count:

```csharp
int nonNullCount = 0;

foreach (string? pallet in sourcePallets)
{
    if (pallet is not null)
    {
        nonNullCount++;
    }
}
```

Allocate:

```csharp
string[] compactPallets =
    new string[nonNullCount];
```

Copy:

```csharp
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
```

Result:

```text
Source length   : 6
Compacted length: 4

B12
A13
C01
C02
```

The example deliberately uses loops rather than LINQ so the array-processing
algorithm remains explicit.

---

## `ToCharArray()`

`ToCharArray()` converts a string into an array of characters.

```csharp
string value = "abc123";

char[] valueArray =
    value.ToCharArray();
```

Result:

```text
['a', 'b', 'c', '1', '2', '3']
```

The project reverses that array:

```csharp
Array.Reverse(valueArray);
```

Result:

```text
['3', '2', '1', 'c', 'b', 'a']
```

A new string is constructed from the character array:

```csharp
string reversedValue =
    new(valueArray);
```

Output:

```text
321cba
```

---

## `string.Join()`

`string.Join()` combines array elements and inserts a separator between adjacent
elements.

```csharp
string commaSeparatedValue =
    string.Join(
        ",",
        characters);
```

Result:

```text
3,2,1,c,b,a
```

General transformation:

```text
array elements
    ↓
separator inserted
    ↓
one string
```

---

## `string.Split()`

`Split()` divides a string at each delimiter occurrence.

```csharp
string[] items =
    commaSeparatedValue.Split(',');
```

Source:

```text
3,2,1,c,b,a
```

Result:

```text
"3"
"2"
"1"
"c"
"b"
"a"
```

Core transformations:

```text
ToCharArray()
string → char[]

new string(char[])
char[] → string

Split()
string → string[]

Join()
array → string
```

---

## Challenge 1 — Reverse Every Word in Place

Input:

```text
The quick brown fox jumps over the lazy dog
```

Required output:

```text
ehT kciuq nworb xof spmuj revo eht yzal god
```

The word order must remain unchanged. Only the letters inside each word are
reversed.

### Step 1 — Split the sentence

```csharp
string[] words =
    pangram.Split(' ');
```

### Step 2 — Allocate the result array

```csharp
string[] reversedWords =
    new string[words.Length];
```

### Step 3 — Reverse each word

```csharp
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
```

### Step 4 — Join the words

```csharp
string result =
    string.Join(
        " ",
        reversedWords);
```

Verified transformation:

```text
The   → ehT
quick → kciuq
brown → nworb
fox   → xof
```

Final result:

```text
ehT kciuq nworb xof spmuj revo eht yzal god
```

---

## Challenge 2 — Parse and Validate Order IDs

Input stream:

```csharp
string orderStream =
    "B123,C234,A345,C15,B177,G3003,C235,B179";
```

### Parse

```csharp
string[] orderIds =
    orderStream.Split(',');
```

### Sort

```csharp
Array.Sort(orderIds);
```

### Validate

```csharp
foreach (string orderId in orderIds)
{
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
```

Business rule:

```text
Valid order ID
→ exactly four characters

Possible error
→ any other length
```

Verified output:

```text
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
```

Validation details:

```text
C15
→ length 3
→ Error

G3003
→ length 5
→ Error
```

---

## Compiler Warning and IDE Message Cleanup

The initial Visual Studio diagnostics contained:

```text
1 compiler warning
7 IDE suggestions
```

### Compiler warning

```text
CS8602:
Dereference of a possibly null reference
```

Resolution:

```text
Copy the mutable array element into a local nullable variable
Check the local variable
Call the method only in the non-null branch
```

### IDE0300 messages

```text
IDE0300:
Collection initialization can be simplified
```

Classic array initializers:

```csharp
string[] pallets =
{
    "B14",
    "A11"
};
```

were modernised to collection expressions:

```csharp
string[] pallets =
[
    "B14",
    "A11"
];
```

### IDE0090 message

```text
IDE0090:
'new' expression can be simplified
```

Original:

```csharp
string reversedValue =
    new string(valueArray);
```

Final:

```csharp
string reversedValue =
    new(valueArray);
```

These IDE codes are style suggestions rather than build failures. They were
still addressed so the final source matches the active Visual Studio code-style
rules.

Final diagnostic target:

```text
Errors  : 0
Warnings: 0
Messages: 0 for the addressed rules
```

---

## Source-Code Cleanup

The original lesson notes contained independent fragments with repeated
declarations such as:

```text
string[] pallets
string value
char[] valueArray
string result
string[] items
```

Combining them directly in one top-level file would cause duplicate-variable
errors.

The final source:

- places every lesson unit in a focused method;
- uses `string?[]` where `null` is an expected value;
- preserves the unsafe null example in comments;
- fixes nullable warning `CS8602`;
- uses modern collection expressions;
- uses target-typed `new`;
- prints `null` positions explicitly as `<null>`;
- separates reusable output helpers;
- implements array compaction without hiding the algorithm;
- preserves both official challenges;
- compiles as one coherent application.

---

## Verified Runtime Behaviour

The final application demonstrates:

```text
Original pallet order
Sorted pallet order
Reversed pallet order
Array.Clear() behavior
Array length preservation after Clear()
Explicit null verification
Safe nullable access
Array expansion
Assignment of new elements
Array shrinking
Manual null compaction
String-to-char[] conversion
Character reversal
char[]-to-string construction
Join() transformation
Split() transformation
Reverse-each-word challenge
Order-ID parsing
Order-ID sorting
Order-ID length validation
Final module summary
```

Final console summary:

```text
MODULE SUMMARY
--------------

Array.Sort()    : sorts elements in the existing array.
Array.Reverse() : reverses the array's current order.
Array.Clear()   : resets selected elements to default values.
Array.Resize()  : changes the length from the end of the array.
ToCharArray()   : converts a string into char elements.
Split()         : converts delimited text into string elements.
Join()          : combines array elements into one string.

Clear() changes element values; Resize() changes array length.
Always check for null before calling instance methods on cleared
reference-type elements.
```

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\array-helper-methods\array-helper-methods.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\array-helper-methods\array-helper-methods.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results after warning correction:

```text
Module build: Succeeded
Module build time: 0.9 seconds
Module compiler warnings: 0
Full solution build: Succeeded
Full solution build time: 4.4 seconds
Solution projects: 23
Target framework: net10.0
Compiler errors: 0
Compiler warnings: 0
Verification date: August 2, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| array | `/əˈreɪ/` | “ờ-rây” | mảng |
| helper method | `/ˈhelp.ər ˈmeθ.əd/` | “heo-pờ me-thợd” | phương thức hỗ trợ |
| sort | `/sɔːt/` | “soọt” | sắp xếp |
| reverse | `/rɪˈvɜːs/` | “rì-vớs” | đảo ngược |
| clear | `/klɪər/` | “kli-ờ” | làm trống hoặc đặt về mặc định |
| resize | `/ˌriːˈsaɪz/` | “ri-sai-z” | thay đổi kích thước |
| nullable | `/ˈnʌl.ə.bəl/` | “nal-lờ-bồ” | có thể nhận giá trị null |
| dereference | `/ˌdiːˈref.ər.əns/` | “đi-ré-phờ-rần-x” | truy cập đối tượng qua tham chiếu |
| delimiter | `/dɪˈlɪm.ɪ.tər/` | “đì-li-mi-tờ” | ký tự phân cách |
| separator | `/ˈsep.ər.eɪ.tər/` | “sép-pờ-rây-tờ” | phần tử phân cách |
| split | `/splɪt/` | “sờ-plit” | tách |
| join | `/dʒɔɪn/` | “joi-n” | ghép |
| compact | `/kəmˈpækt/` | “cầm-páct” | làm gọn |
| mutate | `/mjuːˈteɪt/` | “miu-tâyt” | thay đổi dữ liệu hiện có |
| in place | `/ɪn pleɪs/` | “in plâys” | thay đổi trực tiếp tại chỗ |
| collection expression | `/kəˈlek.ʃən ɪkˈspreʃ.ən/` | “cờ-léc-shần ịch-spré-shần” | biểu thức tạo collection bằng cú pháp `[]` |
| null-conditional | `/nʌl kənˈdɪʃ.ən.əl/` | “nal cần-đi-shờ-nồ” | toán tử chỉ truy cập khi khác null |
| null-coalescing | `/nʌl ˌkəʊ.əˈles.ɪŋ/` | “nal cô-ờ-lét-sing” | toán tử cung cấp giá trị thay thế cho null |

---

## Completion Record

```text
Curriculum item: Perform Operations on Arrays Using Helper Methods in C#
Section: Work with Variable Data in C# Console Applications
Module position: 3 / 7
Module units: 10 / 10
Status: Completed
Microsoft Learn completion page: Displayed
Achievement saved to account: Not verified in signed-out session
Local run: Verified
Project registration: Verified
Project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 4.4 seconds
Solution project count: 23
Target framework: net10.0
Compiler errors: 0
Compiler warnings: 0
Completion date: August 2, 2026
```

---

## Next Module

### Format Alphanumeric Data for Presentation in C#

The next module will focus on formatting textual and numeric values for readable
console output.

Expected topics include:

```text
Composite formatting
String interpolation
Numeric format specifiers
Currency formatting
Percentage formatting
Decimal precision
Padding and alignment
String concatenation
Formatting values for reports
Locale-sensitive presentation
```

A new project should be created under:

```text
work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── format-alphanumeric-data/
        ├── Program.cs
        └── format-alphanumeric-data.csproj
```

The new project must be registered in `freecodecamp-csharp.slnx`, run
successfully, build independently, and preserve a passing full-solution build.

---

## Official Curriculum References

- [Microsoft Learn — Work with Variable Data in C# Console Applications](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-4/)
- [Microsoft Learn — Choose the Correct Data Type in Your C# Code](https://learn.microsoft.com/training/modules/csharp-choose-data-type/)
- [Microsoft Learn — Convert Data Types Using Casting and Conversion Techniques in C#](https://learn.microsoft.com/training/modules/csharp-convert-cast/)
- [Microsoft Learn — Perform Operations on Arrays Using Helper Methods in C#](https://learn.microsoft.com/training/modules/csharp-arrays-operations/)
- [freeCodeCamp — Foundational C# with Microsoft Certification](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/)

---

## Navigation

- [Repository overview](../../README.md)
- [Previous section — Add Logic to C# Console Applications](../add-logic-to-csharp-console-applications/README.md)
- [Module 1 source](./modules/choose-correct-data-type/)
- [Module 2 source](./modules/convert-data-types/)
- [Module 3 source](./modules/array-helper-methods/)
