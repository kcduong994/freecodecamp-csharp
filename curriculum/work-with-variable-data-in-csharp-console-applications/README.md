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
Curriculum learning progress: 6 / 7
Repository-verified progress: 6 / 7
Completed instructional modules on Microsoft Learn: 5
Fully repository-verified instructional modules: 5
Completed guided projects: 1
Completed challenge projects: 0
Latest completed learning item: Guided Project — Work with Variable Data in C#
Latest Microsoft Learn units: 7 / 7
Latest completion date: August 5, 2026
Projects registered in solution: 26
Latest project: contoso-petfriends
Latest final source: Completed
Latest professional source comments: Completed
Latest guided-project run: Verified
Latest application startup and normal exit: Verified
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Latest project build: Verified
Latest full solution build: Verified
Latest project compiler errors: 0
Latest project compiler warnings: 0
Latest IDE diagnostics: No issues found
Next curriculum item: Challenge Project — Work with Variable Data in C#
```

| No. | Curriculum item | Learning status | Repository verification |
| ---: | --- | --- | --- |
| 1 | Choose the Correct Data Type in Your C# Code | Completed | Verified |
| 2 | Convert Data Types Using Casting and Conversion Techniques in C# | Completed | Verified |
| 3 | Perform Operations on Arrays Using Helper Methods in C# | Completed | Verified |
| 4 | Format Alphanumeric Data for Presentation in C# | Completed | Verified |
| 5 | Modify the Content of Strings Using Built-In String Data Type Methods in C# | Completed | Verified |
| 6 | Guided Project — Work with Variable Data in C# | Completed | Verified |
| 7 | Challenge Project — Work with Variable Data in C# | Pending | Pending |

A curriculum item reaches learning completion after its official Microsoft Learn
units have been completed. It reaches full repository verification after the
final source has run successfully, its project has built successfully, and the
complete solution has built successfully.

The guided project is fully repository-verified. The final Contoso PetFriends
source is registered as the twenty-sixth solution project, starts successfully,
supports normal menu exit, implements suggested-donation formatting and dog
characteristic search, builds independently, and preserves a passing
twenty-six-project full-solution build.
---

## Repository Structure

```text
work-with-variable-data-in-csharp-console-applications/
├── README.md
├── modules/
│   ├── choose-correct-data-type/
│   │   ├── Program.cs
│   │   └── choose-correct-data-type.csproj
│   ├── convert-data-types/
│   │   ├── Program.cs
│   │   └── convert-data-types.csproj
│   ├── array-helper-methods/
│   │   ├── Program.cs
│   │   └── array-helper-methods.csproj
│   ├── format-alphanumeric-data/
│   │   ├── Program.cs
│   │   └── format-alphanumeric-data.csproj
│   └── modify-string-content/
│       ├── Program.cs
│       └── modify-string-content.csproj
└── guided-projects/
    └── contoso-petfriends/
        ├── Program.cs
        └── contoso-petfriends.csproj
```

This section uses one central README for curriculum documentation. Module and
guided-project directories contain executable source code and project files
without an additional README.

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

# Module 4 — Format Alphanumeric Data for Presentation in C#

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
Solution project count: 24
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Corrected module run: Succeeded
Module output: Verified
Corrected project build: Succeeded
Corrected project build time: 1.5 seconds
Full solution build: Succeeded
Full solution build time: 3.1 seconds
Compiler errors after correction: 0
Compiler warnings after correction: 0
IDE diagnostics after correction: No issues found
Resolved compiler error: CS1503
Addressed IDE suggestion: IDE0071
Final module run after correction: Succeeded
Full solution build after correction: Succeeded in 3.1 seconds
Completion date: August 3, 2026
```

This module explains how to transform numeric and textual values into readable,
culture-aware presentation strings without changing the underlying application
data.

The final `Program.cs` preserves the complete learning sequence as one
structured console application. It covers escape sequences, verbatim literals,
Unicode, composite formatting, string interpolation, culture-specific numeric
formats, fixed-width output, alignment, and the official personalized marketing
letter challenge.

---

## Learning Objectives

The completed project demonstrates how to:

- represent new lines, tabs, backslashes, and quotation marks with escape
  sequences;
- create readable Windows paths with verbatim string literals;
- place quotation marks inside verbatim strings;
- represent Unicode characters with `\\uXXXX`;
- compare composite formatting with string interpolation;
- reuse and reorder composite-format placeholders;
- format currency values with `C`;
- format grouped numbers with `N`;
- format percentages with `P`;
- format fixed-point values with `F`;
- select an explicit `CultureInfo`;
- explain why formatting does not modify stored values;
- combine interpolation, expressions, and format specifiers;
- align columns with interpolation width components;
- pad text with `PadLeft()` and `PadRight()`;
- construct a 40-character fixed-width payment record;
- create a personalized investment-marketing letter;
- diagnose and repair an invalid `Console.WriteLine()` overload call.

---

## Source-Code Structure

The final application is organised into focused methods:

```text
Main()
├── WriteApplicationHeader()
├── DemonstrateEscapeSequences()
├── DemonstrateVerbatimStringsAndUnicode()
├── DemonstrateCompositeFormatting()
├── DemonstrateStringInterpolation()
├── DemonstrateCurrencyAndCulture()
├── DemonstrateNumericAndPercentageFormatting()
├── DemonstrateCombinedFormattingApproaches()
├── DemonstrateInterpolatedInvoiceReceipt()
├── DemonstratePaddingAndAlignment()
├── DemonstrateFixedWidthPaymentRecord()
├── RunMarketingLetterChallenge()
└── WriteModuleSummary()
```

Reusable output helpers:

```text
WriteSectionHeader()
WriteSectionSeparator()
```

Culture definitions:

```csharp
private static readonly CultureInfo UsCulture =
    CultureInfo.GetCultureInfo("en-US");

private static readonly CultureInfo FrenchCulture =
    CultureInfo.GetCultureInfo("fr-FR");

private static readonly CultureInfo KoreanCulture =
    CultureInfo.GetCultureInfo("ko-KR");
```

This organisation provides:

- isolated variable scope;
- independently reviewable lesson units;
- explicit culture selection;
- comments that explain presentation semantics;
- one executable application instead of disconnected fragments;
- preservation of the official challenge;
- a conventional `Main()` entry point.

---

## Formatting Does Not Change Stored Data

The central distinction in this module is:

```text
Stored value
→ used for calculation and business logic

Formatted string
→ used for display, reports, exports, and messages
```

Example:

```csharp
decimal taxRate = 0.36785M;

string formattedTax =
    taxRate.ToString(
        "P2",
        UsCulture);
```

Result:

```text
Stored decimal:
0.36785

Formatted text:
36.79%
```

The value in `taxRate` remains `0.36785M`. Formatting creates a new textual
representation.

---

## Escape Sequences

Escape sequences begin with a backslash and represent special characters inside
ordinary string literals.

```csharp
Console.WriteLine(
    "Coastal model\nSimulation report");

Console.WriteLine(
    "Station\tWater level\tSalinity");

Console.WriteLine(
    "Project path: C:\\Projects\\CSharp\\Formatting");

Console.WriteLine(
    "The application printed: \"Build succeeded.\"");
```

Common escape sequences:

| Sequence | Meaning |
| --- | --- |
| `\\n` | new line |
| `\\t` | horizontal tab |
| `\\\\` | one backslash |
| `\\"` | one quotation mark |
| `\\r` | carriage return |
| `\\uXXXX` | Unicode code point |

**Escape sequence**  
/ɪˈskeɪp ˈsiː.kwəns/ — chuỗi ký tự thoát.

---

## Verbatim String Literals

The `@` prefix creates a verbatim string literal:

```csharp
string repositoryPath =
    @"F:\DarkerThanBack-DKC\My world\Programs\Github\freecodecamp-csharp";
```

Backslashes remain ordinary characters, making this form useful for Windows
paths.

Without a verbatim literal, every backslash would require escaping:

```csharp
string repositoryPath =
    "F:\\DarkerThanBack-DKC\\My world\\Programs\\Github\\freecodecamp-csharp";
```

A quotation mark inside a verbatim string is represented by two quotation marks:

```csharp
string message =
    @"The terminal displayed ""Build succeeded."".";
```

---

## Unicode Escape Sequences

Unicode escape sequences use `\\u` followed by four hexadecimal digits.

```csharp
string degreeSymbol = "\u00B0";
string deltaSymbol = "\u0394";

Console.WriteLine(
    $"Temperature: 25{degreeSymbol}C");

Console.WriteLine(
    $"{deltaSymbol}t = 10 seconds");
```

Output:

```text
Temperature: 25°C
Δt = 10 seconds
```

The project also includes:

```csharp
string greetingInJapanese =
    "\u3053\u3093\u306B\u3061\u306F";
```

which produces:

```text
こんにちは
```

---

## Composite Formatting

Composite formatting uses numbered replacement tokens.

```csharp
string formattedGreeting =
    string.Format(
        CultureInfo.InvariantCulture,
        "{0} {1}!",
        firstWord,
        secondWord);
```

Token mapping:

```text
{0} → firstWord
{1} → secondWord
```

Tokens may be reordered:

```csharp
string.Format(
    CultureInfo.InvariantCulture,
    "{1} {0}!",
    firstWord,
    secondWord);
```

Tokens may also be reused:

```csharp
string.Format(
    CultureInfo.InvariantCulture,
    "{0} {0} {0}!",
    firstWord,
    secondWord);
```

Composite-format indexes begin at zero.

---

## Resolved Compiler Error `CS1503`

The initial implementation attempted to call:

```csharp
Console.WriteLine(
    CultureInfo.InvariantCulture,
    "{1} {0}!",
    firstWord,
    secondWord);
```

The compiler reported:

```text
CS1503:
Argument 1 cannot convert from
System.Globalization.CultureInfo to string
```

### Root cause

`Console.WriteLine()` does not provide an overload whose first parameter is an
`IFormatProvider`.

The compiler therefore attempted to match the call against another overload and
could not convert the `CultureInfo` object into the required `string`.

### Correct implementation

The value must first be formatted by `string.Format()`:

```csharp
Console.WriteLine(
    string.Format(
        CultureInfo.InvariantCulture,
        "{1} {0}!",
        firstWord,
        secondWord));
```

The repeated-token example was corrected in the same way:

```csharp
Console.WriteLine(
    string.Format(
        CultureInfo.InvariantCulture,
        "{0} {0} {0}!",
        firstWord,
        secondWord));
```

Verification shown after correction:

```text
dotnet clean: Succeeded in 0.5 seconds
Project restore: Completed
Project build: Succeeded in 1.5 seconds
Compiler errors: 0
IDE diagnostics: No issues found
```

---

## String Interpolation

String interpolation uses the `$` prefix and places expressions directly inside
braces.

```csharp
Console.WriteLine(
    $"{firstWord} {secondWord}!");
```

Engineering example:

```csharp
Console.WriteLine(
    $"Station {stationName} measured a water level of " +
    $"{waterLevelMeters} m and salinity of {salinityPpt} ppt.");
```

Comparison:

```text
Composite formatting
→ placeholder indexes are separate from arguments

String interpolation
→ variable names and expressions appear directly in the template
```

Interpolation is generally preferable when it makes the message easier to read.

---

## Currency Formatting

The `C` standard numeric format specifier produces a culture-sensitive currency
representation.

```csharp
decimal price = 123.45M;

string formattedPrice =
    price.ToString(
        "C2",
        UsCulture);
```

Possible culture-dependent results:

```text
en-US → $123.45
fr-FR → 123,45 €
ko-KR → ₩123
```

The symbol, decimal separator, group separator, and symbol position depend on
the culture.

The numeric value remains `123.45M`.

---

## Explicit Culture Selection

The application compares multiple cultures explicitly:

```csharp
CultureInfo.GetCultureInfo("en-US");
CultureInfo.GetCultureInfo("fr-FR");
CultureInfo.GetCultureInfo("ko-KR");
```

Explicit culture selection is important when output must be:

- stable across development machines;
- validated by automated tests;
- exchanged between systems;
- displayed according to a contractual locale;
- written into machine-readable reports.

For user-facing output, the current UI culture may be more appropriate.

---

## Number Formatting with `N`

The `N` format specifier adds group separators.

```csharp
decimal measurement = 123456.78912M;

measurement.ToString(
    "N2",
    UsCulture);
```

Result:

```text
123,456.79
```

Examples:

| Format | Result |
| --- | ---: |
| `N0` | `123,457` |
| `N1` | `123,456.8` |
| `N2` | `123,456.79` |
| `N4` | `123,456.7891` |

The number after `N` controls the displayed decimal places.

---

## Percentage Formatting with `P`

The `P` format specifier multiplies a fractional value by `100` for
presentation.

```csharp
decimal taxRate = 0.36785M;

taxRate.ToString(
    "P2",
    UsCulture);
```

Result:

```text
36.79%
```

Correct stored representation:

```text
36.79% displayed
→ 0.3679 approximately stored
```

A stored value of `36.79` would be displayed as approximately `3,679%`.

---

## Fixed-Point Formatting with `F`

`F` produces fixed-point output without group separators.

```csharp
decimal salinityPpt = 15.11427M;

salinityPpt.ToString(
    "F2",
    UsCulture);
```

Result:

```text
15.11
```

This is useful for engineering values that require a controlled number of
decimal places without thousands grouping.

---

## Combined Formatting

The application calculates a discount:

```csharp
decimal regularPrice = 67.55M;
decimal salePrice = 59.99M;

decimal amountSaved =
    regularPrice - salePrice;

decimal discountRate =
    amountSaved / regularPrice;
```

It then combines composite formatting and interpolation:

```csharp
string discountMessage =
    string.Format(
        UsCulture,
        "You saved {0:C2} off the regular {1:C2} price. ",
        amountSaved,
        regularPrice);

discountMessage +=
    $"A discount of " +
    $"{discountRate.ToString("P2", UsCulture)}!";
```

This demonstrates that formatting techniques can be combined when their
responsibilities are clear.

---

## Interpolated Investment Receipt

The module includes a formatted investment receipt:

```csharp
int invoiceNumber = 1201;
decimal productShares = 25.4568M;
decimal subtotal = 2750.00M;
decimal taxPercentage = 0.15825M;
decimal total = 3185.19M;
```

Formatted output:

```text
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19
```

Applied formats:

```text
N3 → three decimal places with grouping
C2 → currency with two decimal places
P2 → percentage with two decimal places
```

The project explicitly selects `en-US` so this sample remains stable on a Korean
or Vietnamese Windows installation.

---

## `PadLeft()` and `PadRight()`

`PadLeft(totalWidth)` adds characters before the existing text.

`PadRight(totalWidth)` adds characters after the existing text.

```csharp
string input = "Pad this";

string leftPadded =
    input.PadLeft(12);

string rightPadded =
    input.PadRight(12);
```

Custom padding characters are also supported:

```csharp
input.PadLeft(
    12,
    '-');

input.PadRight(
    12,
    '-');
```

Results:

```text
|    Pad this|
|Pad this    |
|----Pad this|
|Pad this----|
```

The final source avoids unnecessary interpolation on these two simple output
lines, addressing the `IDE0071` informational suggestion.

---

## Interpolation Alignment Components

Interpolation supports an alignment component:

```text
{value,width}
```

Rules:

```text
Positive width
→ right alignment

Negative width
→ left alignment
```

Example:

```csharp
Console.WriteLine(
    $"{"Station",-15}" +
    $"{"Water level",12}" +
    $"{"Salinity",12}");

Console.WriteLine(
    $"{stationName,-15}" +
    $"{waterLevelMeters,12:F3}" +
    $"{salinityPpt,12:F2}");
```

Output:

```text
Station         Water level    Salinity
Hoa Binh              1.425       15.11
```

Alignment and format specifiers can be applied together.

---

## Fixed-Width Payment Record

The project creates a 40-character legacy payment record.

Field layout:

```text
Columns  1–6  → payment ID, left-aligned
Columns  7–30 → payee name, left-aligned
Columns 31–40 → payment amount, right-aligned
```

Implementation:

```csharp
string formattedLine =
    paymentId.PadRight(6);

formattedLine +=
    payeeName.PadRight(24);

formattedLine +=
    paymentAmount.PadLeft(10);
```

Verification guide:

```text
1234567890123456789012345678901234567890
769C  Mr. Stephen Ortega       $5,000.00
```

The application also prints:

```text
Record length: 40 characters
```

Fixed-width files depend on exact character positions rather than delimiters.

---

## Challenge — Personalized Investment Marketing Letter

The final challenge uses:

```csharp
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2_975_000;
decimal currentReturn = 0.1275M;
decimal currentProfit = 55_000_000.0M;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125M;
decimal newProfit = 63_000_000.0M;
```

The letter combines:

- string interpolation;
- currency formatting;
- percentage formatting;
- numeric grouping;
- paragraph spacing;
- `PadRight()`;
- composite formatting;
- line separators;
- fixed-width comparison columns.

Expected principal output:

```text
Dear Ms. Barros,

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.
Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%    $55,000,000.00
Glorious Future     13.13%    $63,000,000.00
```

The comparison table is deliberately built step by step to preserve the
module's learning objectives.

---

## Compiler and IDE Diagnostic Cleanup

The final correction addressed:

```text
CS1503
→ invalid Console.WriteLine() overload usage

IDE0071
→ interpolation can be simplified
```

### `CS1503`

Incorrect:

```csharp
Console.WriteLine(
    CultureInfo.InvariantCulture,
    "{1} {0}!",
    firstWord,
    secondWord);
```

Correct:

```csharp
Console.WriteLine(
    string.Format(
        CultureInfo.InvariantCulture,
        "{1} {0}!",
        firstWord,
        secondWord));
```

### `IDE0071`

The padding display originally used interpolation for a simple single-value
composition. The final source uses direct concatenation for those lines.

Final visible diagnostic state:

```text
Compiler errors: 0
IDE diagnostics: No issues found
Project build: Succeeded
```

---

## Source-Code Cleanup

The original lesson material contained independent fragments with repeated
variable declarations:

```text
first
second
result
price
discount
measurement
tax
formattedLine
```

Combining those fragments directly at top level would create naming conflicts
and an unreadable execution flow.

The final source:

- uses one focused method per learning unit;
- selects cultures explicitly;
- preserves the complete official challenge;
- distinguishes data values from presentation strings;
- isolates fixed-width formatting logic;
- retains technical explanations in comments;
- fixes the invalid `Console.WriteLine()` calls;
- addresses `IDE0071`;
- compiles successfully as one application.

---

## Current Verification Evidence

Verified from the supplied Visual Studio terminal:

```text
dotnet clean:
Succeeded in 0.5 seconds

Project restore:
Completed

format-alphanumeric-data module run:
Succeeded

Module output:
Verified through the final MODULE SUMMARY

format-alphanumeric-data project build:
Succeeded in 1.5 seconds

Full solution build:
Succeeded in 3.1 seconds

Registered solution projects:
24

Compiler errors:
0 after correction

Compiler warnings:
0 after correction

IDE status:
No issues found
```

Run the final module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\format-alphanumeric-data\format-alphanumeric-data.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Final repository verification:

```text
Module run: Succeeded
Module output: Verified
Project build: Succeeded in 1.5 seconds
Full solution build: Succeeded in 3.1 seconds
Solution projects: 24
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| format | `/ˈfɔː.mæt/` | “pho-mát” | định dạng |
| alphanumeric | `/ˌæl.fə.njuːˈmer.ɪk/` | “an-phờ-niu-me-rịch” | gồm chữ và số |
| presentation | `/ˌprez.ənˈteɪ.ʃən/` | “pre-zần-tây-shần” | sự trình bày |
| escape sequence | `/ɪˈskeɪp ˈsiː.kwəns/` | “ịch-skâyp si-quần-x” | chuỗi ký tự thoát |
| verbatim | `/vɜːˈbeɪ.tɪm/` | “vờ-bây-tìm” | giữ nguyên ký tự |
| Unicode | `/ˈjuː.nɪ.kəʊd/` | “niu-ni-câu-đ” | tiêu chuẩn mã ký tự |
| composite formatting | `/ˈkɒm.pə.zɪt ˈfɔː.mæt.ɪŋ/` | “com-pờ-zịt pho-mát-ting” | định dạng bằng placeholder |
| interpolation | `/ɪnˌtɜː.pəˈleɪ.ʃən/` | “in-tơ-pờ-lây-shần” | nội suy |
| format specifier | `/ˈfɔː.mæt ˈspes.ɪ.faɪ.ər/` | “pho-mát spé-si-fai-ờ” | ký hiệu định dạng |
| currency | `/ˈkʌr.ən.si/` | “câ-rần-xi” | tiền tệ |
| percentage | `/pəˈsen.tɪdʒ/` | “pờ-xen-tịch” | tỷ lệ phần trăm |
| fixed-point | `/ˌfɪkst ˈpɔɪnt/` | “phích-t poi-nt” | định dạng số thập phân cố định |
| culture | `/ˈkʌl.tʃər/` | “câl-chờ” | quy ước vùng và ngôn ngữ |
| alignment | `/əˈlaɪn.mənt/` | “ờ-lai-n-mần-t” | căn chỉnh |
| padding | `/ˈpæd.ɪŋ/` | “pát-đing” | ký tự đệm |
| fixed-width | `/ˌfɪkst ˈwɪdθ/` | “phích-t uýt-th” | độ rộng cố định |
| placeholder | `/ˈpleɪsˌhəʊl.dər/` | “plâys-hâu-đờ” | vị trí thay thế |
| overload | `/ˈəʊ.və.ləʊd/` | “âu-vờ-lâu-đ” | phiên bản phương thức theo tham số |

---

## Completion Record

```text
Curriculum item: Format Alphanumeric Data for Presentation in C#
Section: Work with Variable Data in C# Console Applications
Module position: 4 / 7
Microsoft Learn units: 8 / 8
Learning status: Completed
Module assessment: Passed
Achievement: Earned
Project registration: Verified
Solution project count: 24
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Corrected module run: Succeeded
Module output: Verified
Corrected project build: Succeeded in 1.5 seconds
Full solution build: Succeeded in 3.1 seconds
Compiler errors after correction: 0
Compiler warnings after correction: 0
IDE diagnostics after correction: No issues found
Completion date: August 3, 2026
```

---

---

# Module 5 — Modify the Content of Strings Using Built-In String Data Type Methods in C#

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
Solution project count: 25
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Module run: Succeeded
Module output: Verified
Project build: Succeeded
Project build time: 0.4 seconds
Full solution build: Succeeded
Full solution build time: 4.0 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 4, 2026
```

This module explains how to locate, extract, remove, and replace content inside
structured strings.

The final `Program.cs` preserves the principal Microsoft Learn examples as one
runnable console application. It also strengthens the original fragments with
clear method boundaries, descriptive names, not-found checks, delimiter-pair
validation, and comments that explain index calculations and string
immutability.

---

## Learning Objectives

The completed project demonstrates how to:

- locate the first occurrence of a character or substring with `IndexOf()`;
- recognize `-1` as the not-found result;
- locate the final occurrence with `LastIndexOf()`;
- locate the first occurrence of any character in a set with `IndexOfAny()`;
- use the starting-position overloads of `IndexOf()` and `IndexOfAny()`;
- extract text with both `Substring()` overloads;
- calculate a substring's start position and length;
- avoid including opening and closing delimiters in extracted content;
- avoid fragile magic strings and magic numbers with `const` and `Length`;
- extract multiple parenthesized values with a `while` loop;
- match parentheses, square brackets, and braces;
- remove fixed-position fields with `Remove()`;
- replace every matching occurrence with `Replace()`;
- remove text by replacing it with `string.Empty`;
- explain why `string` is immutable;
- extract, replace, and remove data from an HTML fragment;
- validate search results before using them as indexes.

---

## Source-Code Structure

The final application is organised into focused methods:

```text
Top-level execution
├── PrintApplicationHeader()
├── DemonstrateIndexOfAndSubstring()
├── DemonstrateLastIndexOfAndRepeatedExtraction()
├── DemonstrateIndexOfAny()
├── DemonstrateRemoveAndReplace()
├── CompleteHtmlChallenge()
└── PrintModuleSummary()
```

Reusable output helper:

```text
PrintSectionHeader()
```

This organisation provides:

- isolated variable scope;
- no duplicate top-level declarations;
- one executable file containing the complete lesson;
- independently reviewable examples;
- descriptive variables for positions, lengths, and delimiters;
- safe handling of failed searches;
- comments that explain intent rather than merely repeating syntax.

---

## String Immutability

A C# `string` is immutable.

```text
Immutable
→ the content of an existing string object cannot be changed after creation
```

Methods such as:

```text
Substring()
Remove()
Replace()
```

return new strings. They do not modify the original string object.

Example:

```csharp
string message =
    "This--is--ex-amp-le--da-ta";

string normalizedMessage =
    message.Replace("--", " ");

normalizedMessage =
    normalizedMessage.Replace(
        "-",
        string.Empty);
```

After these operations:

```text
message
→ still contains "This--is--ex-amp-le--da-ta"

normalizedMessage
→ contains "This is example data"
```

The returned value must be assigned, passed to another method, or otherwise
used. Calling a string helper method without using its return value does not
change the original variable.

---

## Zero-Based Indexes

String character positions are zero-based.

```text
First character  → index 0
Second character → index 1
Third character  → index 2
```

Example:

```csharp
const string message =
    "Find what is (inside the parentheses)";

int openingPosition =
    message.IndexOf('(');

int closingPosition =
    message.IndexOf(')');
```

Verified positions:

```text
Opening parenthesis index: 13
Closing parenthesis index: 36
```

The opening parenthesis is the fourteenth visible character but has index `13`
because counting begins at zero.

---

## `IndexOf()`

`IndexOf()` returns the zero-based position of the first matching character or
substring.

```csharp
int openingPosition =
    message.IndexOf('(');
```

It can also search for a longer string:

```csharp
const string openSpan = "<span>";

int openingTagPosition =
    taggedMessage.IndexOf(openSpan);
```

If no match exists, the method returns:

```text
-1
```

The final application checks for `-1` before using a result as a substring
boundary:

```csharp
if (openingPosition == -1 ||
    closingPosition == -1 ||
    closingPosition <= openingPosition)
{
    Console.WriteLine(
        "A valid parenthesis pair was not found.");

    return;
}
```

This prevents invalid indexes and negative substring lengths.

---

## `Substring(startIndex, length)`

The two-parameter overload returns a specified number of characters beginning
at a specified index.

```csharp
string extractedValue =
    message.Substring(
        startIndex,
        length);
```

For the parenthesis example:

```csharp
int contentStart =
    openingPosition + 1;

int contentLength =
    closingPosition - contentStart;

string parenthesizedContent =
    message.Substring(
        contentStart,
        contentLength);
```

Verified output:

```text
inside the parentheses
```

### Why `openingPosition + 1` Is Required

Starting at `openingPosition` includes the opening delimiter:

```text
(inside the parentheses
```

Adding `1` advances past the single opening-parenthesis character.

```text
openingPosition
→ index of '('

openingPosition + 1
→ index of the first content character
```

This is a common boundary calculation in text parsing.

---

## Avoid Magic Strings and Magic Numbers

A hardcoded value with unexplained structural meaning is often called a magic
value.

Fragile example:

```csharp
openingPosition += 6;
```

The number `6` is correct only while the opening tag remains:

```text
<span>
```

Safer implementation:

```csharp
const string openSpan = "<span>";
const string closeSpan = "</span>";

int contentStart =
    openingTagPosition +
    openSpan.Length;
```

Benefits:

```text
The tag is defined once
Misspelled constant names are caught by the compiler
Changing the tag automatically updates the required offset
The purpose of the calculation is visible in the code
```

The final source uses constants for all structural tags and HTML entities in the
challenge.

---

## Extract Text Between Tags

Input:

```csharp
const string taggedMessage =
    "What is the value <span>between the tags</span>?";
```

Delimiters:

```csharp
const string openSpan = "<span>";
const string closeSpan = "</span>";
```

Boundary calculation:

```csharp
int openingTagPosition =
    taggedMessage.IndexOf(openSpan);

int closingTagPosition =
    taggedMessage.IndexOf(closeSpan);

int taggedContentStart =
    openingTagPosition +
    openSpan.Length;

int taggedContentLength =
    closingTagPosition -
    taggedContentStart;
```

Extraction:

```csharp
string taggedContent =
    taggedMessage.Substring(
        taggedContentStart,
        taggedContentLength);
```

Verified output:

```text
between the tags
```

---

## `LastIndexOf()`

`LastIndexOf()` returns the position of the final matching character or
substring.

```csharp
const string greeting =
    "hello there!";

int firstHPosition =
    greeting.IndexOf('h');

int lastHPosition =
    greeting.LastIndexOf('h');
```

Verified output:

```text
For the message 'hello there!', the first 'h' is at position 0
and the last 'h' is at position 7.
```

This method is useful when the required content is associated with the final
occurrence rather than the first.

---

## Extract the Final Parenthesis Pair

Input:

```csharp
const string lastPairMessage =
    "(What if) I am (only interested) in the last " +
    "(set of parentheses)?";
```

Locate the final delimiters:

```csharp
int lastOpeningPosition =
    lastPairMessage.LastIndexOf('(');

int lastClosingPosition =
    lastPairMessage.LastIndexOf(')');
```

Extract the content:

```csharp
int lastContentStart =
    lastOpeningPosition + 1;

int lastContentLength =
    lastClosingPosition -
    lastContentStart;

string lastParenthesizedContent =
    lastPairMessage.Substring(
        lastContentStart,
        lastContentLength);
```

Verified output:

```text
set of parentheses
```

The final source validates that both delimiters exist and that the closing
delimiter follows the opening delimiter.

---

## `Substring(startIndex)`

The one-parameter overload returns every character from the supplied starting
index through the end of the string.

```csharp
remainingMessage =
    remainingMessage.Substring(
        closingPosition + 1);
```

This overload is used while extracting every parenthesized value.

After one pair is processed, the application assigns the unprocessed remainder
to `remainingMessage`. The next loop iteration searches only that remaining
text.

---

## Extract Every Parenthesized Value

Input:

```csharp
string remainingMessage =
    "(What if) there are (more than) one " +
    "(set of parentheses)?";
```

Core loop:

```csharp
while (true)
{
    int openingPosition =
        remainingMessage.IndexOf('(');

    if (openingPosition == -1)
    {
        break;
    }

    int closingPosition =
        remainingMessage.IndexOf(
            ')',
            openingPosition + 1);

    if (closingPosition == -1)
    {
        break;
    }

    int contentStart =
        openingPosition + 1;

    int contentLength =
        closingPosition - contentStart;

    Console.WriteLine(
        remainingMessage.Substring(
            contentStart,
            contentLength));

    remainingMessage =
        remainingMessage.Substring(
            closingPosition + 1);
}
```

Verified output:

```text
What if
more than
set of parentheses
```

### Loop Termination

The loop ends when:

```text
No opening parenthesis remains
or
An opening parenthesis has no matching closing parenthesis
```

This avoids treating `-1` as a valid string index.

---

## `IndexOfAny()`

`IndexOfAny()` searches for any character contained in a supplied `char[]`.

```csharp
const string message =
    "Hello, world!";

char[] vowelsToFind =
[
    'a',
    'e',
    'i'
];

int vowelPosition =
    message.IndexOfAny(
        vowelsToFind);
```

Verified output:

```text
Found 'e' in 'Hello, world!' at index 1.
```

The method returns the position of the earliest matching character in the
string, not the position of the character inside the search array.

If none of the supplied characters occurs, it returns `-1`.

---

## Starting-Position Overload

`IndexOfAny()` can begin searching at a specified index.

```csharp
int openingAfterStartPosition =
    openingSymbolMessage.IndexOfAny(
        openingSymbols,
        startPosition);
```

Input:

```text
Help (find) the {opening symbols}
```

Search characters:

```csharp
char[] openingSymbols =
[
    '[',
    '{',
    '('
];
```

The overload is useful when part of the string has already been processed and
the next search must begin later.

---

## Match Different Delimiter Types

Input:

```csharp
const string mixedSymbolMessage =
    "(What if) I have [different symbols] but every " +
    "{open symbol} needs a [matching closing symbol]?";
```

Opening characters:

```csharp
char[] openingSymbols =
[
    '[',
    '{',
    '('
];
```

The application uses `IndexOfAny()` to locate the next opening symbol and a
`switch` statement to select its matching closing symbol:

```csharp
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
}
```

It then searches for the corresponding close:

```csharp
int closingPosition =
    mixedSymbolMessage.IndexOf(
        matchingClosingSymbol,
        contentStart);
```

Verified output:

```text
What if
different symbols
open symbol
matching closing symbol
```

The loop continues after the matched closing symbol:

```csharp
searchPosition =
    closingPosition + 1;
```

This prevents already processed content from being searched again.

---

## `Remove()`

`Remove(startIndex, count)` returns a new string without the specified range.

Input:

```csharp
const string fixedWidthData =
    "12345John Smith          5000  3  ";
```

Field layout:

```text
Indexes 0–4   → customer identifier
Indexes 5–24  → customer name, 20 characters
Remaining     → invoice amount and item count
```

Removal:

```csharp
string dataWithoutCustomerName =
    fixedWidthData.Remove(
        5,
        20);
```

Verified output:

```text
Original fixed-width data: '12345John Smith          5000  3  '
After removing the name:   '123455000  3  '
```

`Remove()` is appropriate when the starting position and field width are known
and stable.

---

## `Replace()`

`Replace()` returns a new string in which every matching occurrence has been
replaced.

```csharp
string hyphenatedMessage =
    "This--is--ex-amp-le--da-ta";

string normalizedMessage =
    hyphenatedMessage.Replace(
        "--",
        " ");

normalizedMessage =
    normalizedMessage.Replace(
        "-",
        string.Empty);
```

Processing:

```text
First Replace()
→ every "--" becomes one space

Second Replace()
→ every remaining "-" becomes an empty string
```

Verified output:

```text
Original: This--is--ex-amp-le--da-ta
Updated : This is example data
```

Unlike `IndexOf()`, `Replace()` does not stop after the first match.

---

## Challenge — Extract, Replace, and Remove HTML Data

Input:

```csharp
const string input =
    "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
```

Required output:

```text
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
```

The challenge requires three transformations:

```text
1. Extract the text between <span> and </span>
2. Replace &trade; with &reg;
3. Remove the opening and closing <div> tags
```

### Structural Constants

```csharp
const string openSpan = "<span>";
const string closeSpan = "</span>";
const string openDiv = "<div>";
const string closeDiv = "</div>";
const string tradeSymbol = "&trade;";
const string registeredSymbol = "&reg;";
```

### Extract Quantity

```csharp
int spanOpeningPosition =
    input.IndexOf(openSpan);

int spanClosingPosition =
    input.IndexOf(closeSpan);

int quantityStart =
    spanOpeningPosition +
    openSpan.Length;

int quantityLength =
    spanClosingPosition -
    quantityStart;

string quantity =
    input.Substring(
        quantityStart,
        quantityLength);
```

### Replace the HTML Entity

```csharp
string output =
    input.Replace(
        tradeSymbol,
        registeredSymbol);
```

### Remove the Outer `<div>` Tags

```csharp
int openingDivPosition =
    output.IndexOf(openDiv);

if (openingDivPosition != -1)
{
    output =
        output.Remove(
            openingDivPosition,
            openDiv.Length);
}

int closingDivPosition =
    output.IndexOf(closeDiv);

if (closingDivPosition != -1)
{
    output =
        output.Remove(
            closingDivPosition,
            closeDiv.Length);
}
```

Verified result:

```text
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
```

The source checks every search result before passing it to `Substring()` or
`Remove()`.

---

## Boundary Validation

Text-processing code becomes fragile when it assumes delimiters always exist.

Potential failures include:

```text
Opening delimiter not found
Closing delimiter not found
Closing delimiter appears before the opening delimiter
Opening delimiter has no matching close
A search result of -1 is used as an index
A calculated length becomes negative
```

The final source uses checks such as:

```csharp
if (openingPosition == -1 ||
    closingPosition == -1 ||
    closingPosition <= openingPosition)
{
    // Handle invalid structure safely.
}
```

For repeated extraction, the closing search begins after the opening delimiter:

```csharp
int closingPosition =
    remainingMessage.IndexOf(
        ')',
        openingPosition + 1);
```

These checks make the learning examples safer while preserving the original
module concepts.

---

## Common Indexing Errors

### Off-by-One Error

An off-by-one error occurs when a boundary is shifted by one character.

```text
Start at opening delimiter
→ delimiter is included accidentally

Start one character too far
→ first content character is lost
```

Correct pattern for a one-character opening delimiter:

```csharp
int contentStart =
    openingPosition + 1;
```

Correct pattern for a multi-character opening delimiter:

```csharp
int contentStart =
    openingPosition +
    openingDelimiter.Length;
```

### Incorrect Length

`Substring(startIndex, length)` expects a character count, not an ending index.

Correct calculation:

```csharp
int length =
    endingPosition -
    startingPosition;
```

The ending delimiter itself is excluded because the count stops immediately
before its index.

---

## Source-Code Cleanup

The original study notes contained independent instructional fragments that
could not be compiled directly as one top-level program.

They included:

```text
Repeated declarations of message
Repeated openingPosition and closingPosition variables
Repeated length and output variables
Narrative text mixed with executable statements
A large set of unrelated unused using directives
Multiple complete examples in the same top-level scope
Examples that assumed delimiters always existed
Hardcoded tag lengths
The complete challenge and solution duplicated in one scope
```

The final source:

- removes unrelated `using` directives;
- gives every learning group its own method;
- uses descriptive names for each boundary;
- replaces magic offsets with constant lengths;
- retains the complete challenge;
- checks `IndexOf()` and related results for `-1`;
- checks delimiter ordering;
- avoids negative substring lengths;
- explains string immutability;
- preserves the official output;
- compiles and runs as one coherent application.

---

## Verified Runtime Behaviour

The organised application ran successfully from beginning to end.

Verified behaviour includes:

```text
First opening and closing parenthesis positions
Extraction including the opening parenthesis
Extraction excluding both delimiters
Extraction between <span> tags
First and last occurrence of a character
Extraction from the final parenthesis pair
Extraction of every parenthesized value
IndexOfAny() vowel search
IndexOfAny() start-position overload
Matching parentheses, brackets, and braces
Fixed-width field removal
Repeated separator replacement
HTML quantity extraction
HTML entity replacement
Outer <div> removal
Final module summary
```

Verified challenge output:

```text
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
```

Final console summary:

```text
MODULE SUMMARY
--------------

IndexOf()     -> returns the first matching position or -1.
LastIndexOf() -> returns the final matching position or -1.
IndexOfAny()  -> finds the first occurrence of any supplied char.
Substring()   -> returns a selected portion of a string.
Remove()      -> returns a string without a selected range.
Replace()     -> replaces every matching occurrence.
const/Length  -> avoid fragile magic strings and magic numbers.
string        -> immutable; helper methods return new strings.
```

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\modify-string-content\modify-string-content.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\modify-string-content\modify-string-content.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results from the supplied Visual Studio evidence:

```text
Module run: Succeeded
Module output: Verified
Project build: Succeeded
Project build time: 0.4 seconds
Full solution build: Succeeded
Full solution build time: 4.0 seconds
Solution projects: 25
Target framework: net10.0
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 4, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| modify | `/ˈmɒd.ɪ.faɪ/` | “mo-đi-fai” | sửa đổi |
| content | `/ˈkɒn.tent/` | “con-ten-t” | nội dung |
| string | `/strɪŋ/` | “x-trinh” | chuỗi ký tự |
| built-in | `/ˌbɪltˈɪn/` | “bilt-in” | được tích hợp sẵn |
| method | `/ˈmeθ.əd/` | “mé-thợd” | phương thức |
| index | `/ˈɪn.deks/` | “in-đéc-x” | chỉ số vị trí |
| zero-based | `/ˌzɪə.rəʊˈbeɪst/` | “zi-râu-bâyst” | bắt đầu đếm từ zero |
| occurrence | `/əˈkʌr.əns/` | “ờ-câ-rần-x” | lần xuất hiện |
| substring | `/ˈsʌb.strɪŋ/` | “sấp-xtrinh” | chuỗi con |
| delimiter | `/dɪˈlɪm.ɪ.tər/` | “đì-li-mi-tờ” | ký tự hoặc chuỗi phân cách |
| opening delimiter | `/ˈəʊ.pən.ɪŋ dɪˈlɪm.ɪ.tər/` | “âu-pờ-ning đì-li-mi-tờ” | dấu phân cách mở |
| closing delimiter | `/ˈkləʊ.zɪŋ dɪˈlɪm.ɪ.tər/` | “clâu-zing đì-li-mi-tờ” | dấu phân cách đóng |
| immutable | `/ɪˈmjuː.tə.bəl/` | “i-miu-tờ-bồ” | không thể thay đổi nội dung sau khi tạo |
| replace | `/rɪˈpleɪs/` | “rì-plâys” | thay thế |
| remove | `/rɪˈmuːv/` | “rì-muuv” | loại bỏ |
| magic number | `/ˈmædʒ.ɪk ˈnʌm.bər/` | “ma-jịch năm-bờ” | số hardcode có ý nghĩa ẩn |
| magic string | `/ˈmædʒ.ɪk strɪŋ/` | “ma-jịch xtrinh” | chuỗi hardcode có ý nghĩa ẩn |
| boundary | `/ˈbaʊn.dər.i/` | “bao-n-đờ-ri” | ranh giới |
| off-by-one error | `/ˌɒf baɪ ˈwʌn ˈer.ər/` | “óp-bai-oăn e-rờ” | lỗi lệch một vị trí |
| fixed-width | `/ˌfɪkst ˈwɪdθ/` | “phích-t uýt-th” | có độ rộng cố định |
| HTML entity | `/ˌeɪtʃ tiː em ˈel ˈen.tɪ.ti/` | “âych-ti-em-el en-ti-ti” | mã biểu diễn ký tự trong HTML |

---

## Completion Record

```text
Curriculum item: Modify the Content of Strings Using Built-In String Data Type Methods in C#
Section: Work with Variable Data in C# Console Applications
Module position: 5 / 7
Microsoft Learn units: 8 / 8
Learning status: Completed
Module assessment: Passed
Achievement: Earned
Project registration: Verified
Solution project count: 25
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Module run: Succeeded
Module output: Verified
Project build: Succeeded in 0.4 seconds
Full solution build: Succeeded in 4.0 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 4, 2026
```

---

# Guided Project — Work with Variable Data in C#

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 7 / 7
Application: Contoso PetFriends
Project added to solution: Verified
Solution project count: 26
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Application run: Succeeded
Application startup: Verified
Normal exit behavior: Verified
Project build: Succeeded
Full solution build: Succeeded
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 5, 2026
```

This guided project integrates the first five Section 4 modules into one
interactive **Contoso PetFriends** console application.

The completed application:

- stores adoptable-pet records in a two-dimensional array;
- lists every populated pet record;
- adds a suggested-donation field;
- parses donation text safely with `decimal.TryParse()`;
- assigns a default donation when source data is missing or invalid;
- formats donation values with an explicit currency culture;
- requests one dog characteristic from the user;
- searches physical and personality descriptions;
- compares text without case sensitivity;
- reports every matching dog;
- reports clearly when no match exists;
- validates menu and search input;
- runs until the user enters `exit`.

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── guided-projects/
    └── contoso-petfriends/
        ├── Program.cs
        └── contoso-petfriends.csproj
```

---

## Project Requirements

The starter application contained two menu options:

```text
1. List all of our current pet information
2. Display all dogs with a specified characteristic
```

The guided project completes two principal requirements:

```text
Feature 1
→ add and display a suggested donation for each populated pet record

Feature 2
→ search dogs by a requested physical or personality characteristic
```

---

## Expanded Pet Data Table

The starter table contained six fields. The completed application expands it to
seven:

```csharp
const int MaxPets = 8;
const int PetFieldCount = 7;

string[,] ourAnimals =
    new string[MaxPets, PetFieldCount];
```

Named constants document the field positions:

```csharp
const int IdIndex = 0;
const int SpeciesIndex = 1;
const int AgeIndex = 2;
const int NicknameIndex = 3;
const int PhysicalDescriptionIndex = 4;
const int PersonalityDescriptionIndex = 5;
const int SuggestedDonationIndex = 6;
```

| Index | Field |
| ---: | --- |
| `0` | ID |
| `1` | Species |
| `2` | Age |
| `3` | Nickname |
| `4` | Physical description |
| `5` | Personality description |
| `6` | Suggested donation |

The first array dimension identifies a pet row. The second dimension identifies
a field inside that record.

---

## Suggested Donation

The sample donation text is converted to `decimal`:

```csharp
bool donationWasParsed =
    decimal.TryParse(
        suggestedDonation,
        NumberStyles.Number,
        CultureInfo.InvariantCulture,
        out decimal decimalDonation);
```

When conversion fails:

```csharp
const decimal DefaultSuggestedDonation =
    45.00M;

if (!donationWasParsed)
{
    decimalDonation =
        DefaultSuggestedDonation;
}
```

`decimal` is used because the values represent money. `TryParse()` avoids a
`FormatException` when the source string is empty or invalid.

---

## Stable Currency Formatting

The final source separates parsing culture from display culture.

```csharp
CultureInfo currencyCulture =
    CultureInfo.GetCultureInfo("en-US");
```

The formatted donation is stored as:

```csharp
ourAnimals[
    petIndex,
    SuggestedDonationIndex] =
        SuggestedDonationLabel +
        decimalDonation.ToString(
            "C2",
            currencyCulture);
```

Stable results include:

```text
85.00  → $85.00
49.99  → $49.99
40.00  → $40.00
invalid → $45.00
```

This prevents the output from changing to Korean won merely because the
application is run on a Korean Windows installation.

---

## List Populated Pet Records

Menu option `1` uses nested loops:

```text
Outer loop
→ inspect each pet row

Inner loop
→ display all seven fields in a populated row
```

Unused rows are detected through the ID field and skipped with `continue`.

Using `PetFieldCount` rather than a hardcoded `7` keeps the display logic aligned
with the table definition.

---

## Validate the Search Term

Menu option `2` requires one non-empty characteristic:

```csharp
while (
    string.IsNullOrWhiteSpace(
        dogCharacteristic))
{
    readResult =
        Console.ReadLine();

    dogCharacteristic =
        (readResult ?? string.Empty)
            .Trim();
}
```

This rejects `null`, empty, and whitespace-only input.

---

## Search Dog Records

Only dog rows are searched:

```csharp
bool isDog =
    ourAnimals[
        petIndex,
        SpeciesIndex]
    .Contains(
        "dog",
        StringComparison.OrdinalIgnoreCase);
```

The physical and personality descriptions are combined:

```csharp
string dogDescription =
    ourAnimals[
        petIndex,
        PhysicalDescriptionIndex] +
    Environment.NewLine +
    ourAnimals[
        petIndex,
        PersonalityDescriptionIndex];
```

The requested characteristic is searched without case sensitivity:

```csharp
bool descriptionContainsCharacteristic =
    dogDescription.Contains(
        dogCharacteristic,
        StringComparison.OrdinalIgnoreCase);
```

Examples:

```text
cream  → matches lola
kisses → matches lola
hugs   → matches gus
```

---

## Display Matches

The stored nickname field includes the label:

```text
Nickname: lola
```

The label is removed using the exact label length:

```csharp
string dogNickname =
    ourAnimals[
        petIndex,
        NicknameIndex]
    .Substring(
        NicknameLabel.Length);
```

Output:

```text
Our dog lola is a match!
```

This applies the `Substring()` and `Length` techniques from Module 5 without a
magic numeric offset.

A Boolean flag records whether any dog matched. When no match is found, the
application displays an explicit no-match message.

---

## Input Normalization

Menu input is normalized safely:

```csharp
menuSelection =
    (readResult ?? string.Empty)
        .Trim()
        .ToLowerInvariant();
```

The following inputs therefore behave identically:

```text
exit
Exit
EXIT
  exit
```

Unsupported selections display:

```text
Invalid selection. Enter 1, 2, or Exit.
```

---

## Source-Code Organisation

The final source remains a top-level program because custom methods are taught
in the next curriculum section.

The file is organised into seven documented stages:

```text
1. Define dimensions and field indexes
2. Declare working variables
3. Create the pet-data table
4. Populate sample records and format donations
5. Display and process the menu
6. Search dog records
7. Display matches or the no-match result
```

Engineering improvements include:

- named constants instead of hardcoded field indexes;
- explicit parsing and display cultures;
- null-safe console input;
- case-insensitive comparison;
- a named default donation;
- safe `Console.Clear()` handling;
- descriptive variable names;
- comments that explain intent and data flow;
- no premature use of custom methods.

---

## Concepts Integrated

| Previous module | Guided-project use |
| --- | --- |
| Choose the Correct Data Type | `decimal` donation values and Boolean state |
| Convert Data Types | `decimal.TryParse()` and an `out` parameter |
| Work with Arrays | two-dimensional pet-record storage |
| Format Alphanumeric Data | `C2` currency formatting and explicit culture |
| Modify String Content | trimming, searching, and extracting nickname text |

---

## Verification

Run the project:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\guided-projects\contoso-petfriends\contoso-petfriends.csproj"
```

Build the project:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\guided-projects\contoso-petfriends\contoso-petfriends.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified repository evidence:

```text
Application launch: Succeeded
Menu display: Verified
Normal exit with "exit": Verified
Suggested-donation implementation: Present
Dog-search implementation: Present
Project registration: Verified
Registered solution projects: 26
Project build: Succeeded
Full solution build: Succeeded
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 5, 2026
```

Recommended interactive checks:

```text
Menu 1
→ all four populated records include Suggested Donation

Menu 2, search "cream"
→ lola is reported as a match

Menu 2, search "hugs"
→ gus is reported as a match

Menu 2, search an absent characteristic
→ the no-match message is displayed

exit
→ the application terminates normally
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| guided project | `/ˈɡaɪ.dɪd ˈprɒdʒ.ekt/` | “gai-địt pro-jẹct” | dự án có hướng dẫn |
| variable data | `/ˈveə.ri.ə.bəl ˈdeɪ.tə/` | “ve-ri-ờ-bồ đây-tờ” | dữ liệu có thể thay đổi |
| suggested donation | `/səˈdʒes.tɪd dəʊˈneɪ.ʃən/` | “sờ-jét-tịt đô-nây-shần” | khoản quyên góp đề xuất |
| characteristic | `/ˌkær.ək.təˈrɪs.tɪk/` | “ke-rặc-tờ-rít-tịch” | đặc điểm |
| two-dimensional array | `/ˌtuː daɪˈmen.ʃən.əl əˈreɪ/` | “tu-đai-men-shờ-nồ ờ-rây” | mảng hai chiều |
| fallback value | `/ˈfɔːl.bæk ˈvæl.juː/` | “pho-l-béc va-liu” | giá trị thay thế |
| case-insensitive | `/ˌkeɪs ɪnˈsen.sɪ.tɪv/` | “kâys in-sen-si-tịv” | không phân biệt hoa thường |
| search term | `/sɜːtʃ tɜːm/` | “sớt-ch tơm” | từ khóa tìm kiếm |
| normalization | `/ˌnɔː.mə.laɪˈzeɪ.ʃən/` | “no-mờ-lai-zây-shần” | chuẩn hóa dữ liệu |
| populated row | `/ˈpɒp.jə.leɪ.tɪd rəʊ/` | “póp-piu-lây-tịt râu” | hàng có dữ liệu |

---

## Completion Record

```text
Curriculum item: Guided Project — Work with Variable Data in C#
Section: Work with Variable Data in C# Console Applications
Project position: 6 / 7
Microsoft Learn units: 7 / 7
Learning status: Completed
Repository verification status: Fully verified
Application: Contoso PetFriends
Project registration: Verified
Solution project count: 26
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Application run: Succeeded
Project build: Succeeded
Full solution build: Succeeded
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 5, 2026
```

---

## Next Curriculum Item

### Challenge Project — Work with Variable Data in C#

The final Section 4 item will independently apply data selection, conversion,
array processing, formatting, and string-manipulation requirements.

Expected repository verification:

```text
Complete the official challenge requirements
Organize and comment the final source
Run the challenge successfully
Verify the required behavior and output
Build the challenge independently
Build the full solution
Update this section README
Update the repository root README
Review the Git diff
Commit and push to main
```
---

## Official Curriculum References

- [Microsoft Learn — Work with Variable Data in C# Console Applications](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-4/)
- [Microsoft Learn — Choose the Correct Data Type in Your C# Code](https://learn.microsoft.com/training/modules/csharp-choose-data-type/)
- [Microsoft Learn — Convert Data Types Using Casting and Conversion Techniques in C#](https://learn.microsoft.com/training/modules/csharp-convert-cast/)
- [Microsoft Learn — Perform Operations on Arrays Using Helper Methods in C#](https://learn.microsoft.com/training/modules/csharp-arrays-operations/)
- [Microsoft Learn — Format Alphanumeric Data for Presentation in C#](https://learn.microsoft.com/training/modules/csharp-format-strings/)
- [Microsoft Learn — Modify the Content of Strings Using Built-In String Data Type Methods in C#](https://learn.microsoft.com/training/modules/csharp-modify-content/)
- [Microsoft Learn — Guided Project: Work with Variable Data in C#](https://learn.microsoft.com/training/modules/guided-project-work-variable-data-c-sharp/)
- [freeCodeCamp — Foundational C# with Microsoft Certification](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/)

---

## Navigation

- [Repository overview](../../README.md)
- [Previous section — Add Logic to C# Console Applications](../add-logic-to-csharp-console-applications/README.md)
- [Module 1 source](./modules/choose-correct-data-type/)
- [Module 2 source](./modules/convert-data-types/)
- [Module 3 source](./modules/array-helper-methods/)
- [Module 4 source](./modules/format-alphanumeric-data/)
- [Module 5 source](./modules/modify-string-content/)
- [Guided Project source](./guided-projects/contoso-petfriends/)
