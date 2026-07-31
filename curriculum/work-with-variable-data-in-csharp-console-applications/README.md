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
Curriculum progress: 1 / 7
Completed instructional modules: 1
Completed guided projects: 0
Completed challenge projects: 0
Latest completed item: Choose the Correct Data Type in Your C# Code
Latest item assessment: Passed
Microsoft Learn achievement: Earned
Latest completion date: July 31, 2026
Projects registered in solution: 21
Latest project run: Verified
Latest project build: Verified
Latest project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 3.5 seconds
IDE diagnostics: No issues found
Next curriculum item: Convert Data Types Using Casting and Conversion Techniques in C#
```

| No. | Curriculum item | Status |
| ---: | --- | --- |
| 1 | Choose the Correct Data Type in Your C# Code | Completed |
| 2 | Convert Data Types Using Casting and Conversion Techniques in C# | Pending |
| 3 | Perform Operations on Arrays Using Helper Methods in C# | Pending |
| 4 | Format Alphanumeric Data for Presentation in C# | Pending |
| 5 | Modify the Content of Strings Using Built-In String Data Type Methods in C# | Pending |
| 6 | Guided Project — Work with Variable Data in C# | Pending |
| 7 | Challenge Project — Work with Variable Data in C# | Pending |

A curriculum item is marked `Completed` only after its Microsoft Learn units,
assessment, achievement, local run, solution registration, project build, and
full-solution build have all been verified.

---

## Repository Structure

```text
work-with-variable-data-in-csharp-console-applications/
├── README.md
└── modules/
    └── choose-correct-data-type/
        ├── Program.cs
        └── choose-correct-data-type.csproj
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

## Next Module

### Convert Data Types Using Casting and Conversion Techniques in C#

The next module will examine how to change data from one type to another safely.

Expected topics include:

```text
Implicit conversion
Explicit casting
Narrowing and widening conversions
ToString()
Convert
Parse()
TryParse()
Data-loss risks
Checked numeric conversion
```

A new project should be created under:

```text
work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── convert-data-types/
        ├── Program.cs
        └── convert-data-types.csproj
```

The new project must be registered in `freecodecamp-csharp.slnx`, run
successfully, build independently, and preserve a passing full-solution build.

---

## Official Curriculum References

- [Microsoft Learn — Work with Variable Data in C# Console Applications](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-4/)
- [Microsoft Learn — Choose the Correct Data Type in Your C# Code](https://learn.microsoft.com/training/modules/csharp-choose-data-type/)
- [freeCodeCamp — Foundational C# with Microsoft Certification](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/)

---

## Navigation

- [Repository overview](../../README.md)
- [Previous section — Add Logic to C# Console Applications](../add-logic-to-csharp-console-applications/README.md)
- [Completed module source](./modules/choose-correct-data-type/)
