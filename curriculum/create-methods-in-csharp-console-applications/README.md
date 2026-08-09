# Create Methods in C# Console Applications

> Section 5 of the **Foundational C# with Microsoft Certification** curriculum.

This section introduces reusable C# methods and develops the ability to divide
larger programs into small, named tasks with explicit inputs and outputs.

The learning path contains five curriculum items:

1. Write Your First C# Method
2. Create C# Methods with Parameters
3. Create C# Methods That Return Values
4. Guided Project — Plan a Petting Zoo Visit
5. Challenge Project — Create a Mini-Game

---

## Section Status

```text
Section: Create Methods in C# Console Applications
Section position: 5 / 7
Status: In progress
Curriculum learning progress: 4 / 5
Repository-verified progress: 4 / 5
Completed instructional modules: 3
Fully repository-verified instructional modules: 3
Completed guided projects: 1
Fully repository-verified guided projects: 1
Completed challenge projects: 0
Latest completed learning item: Guided Project — Plan a Petting Zoo Visit
Latest Microsoft Learn units: 8 / 8
Latest module assessment: Passed
Latest achievement: Earned
Latest completion date: August 10, 2026
Projects registered in solution: 31
Latest project: plan-petting-zoo-visit
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Final application run: Verified
Final output: Verified
School A — 6 groups: Verified
School B — 3 groups: Verified
School C — 2 groups: Verified
Randomized animal assignments: Verified
Optional group parameter: Verified
2D group assignment return value: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.4 seconds
Latest compiler errors: 0
Latest compiler warnings: 0
Latest IDE diagnostics: No issues found
Next curriculum item: Challenge Project — Create a Mini-Game
```

| No. | Curriculum item | Learning status | Repository verification |
| ---: | --- | --- | --- |
| 1 | Write Your First C# Method | Completed | Verified |
| 2 | Create C# Methods with Parameters | Completed | Verified |
| 3 | Create C# Methods That Return Values | Completed | Verified |
| 4 | Guided Project — Plan a Petting Zoo Visit | Completed | Verified |
| 5 | Challenge Project — Create a Mini-Game | Pending | Pending |

A curriculum item reaches **learning completion** after its official Microsoft
Learn units and assessment have been completed.

It reaches **full repository verification** after:

- the final source has been organized and documented;
- the project has run successfully;
- the required behavior and output have been verified;
- the project has compiled successfully;
- the complete solution has built successfully;
- the repository documentation has been updated.

The three instructional modules and the guided project are now fully
repository-verified. The latest project combines method decomposition,
parameters, optional parameters, return values, one-dimensional and
two-dimensional arrays, randomized assignment, and a reusable orchestration
method in one complete application workflow.

---

## Repository Structure

```text
create-methods-in-csharp-console-applications/
├── README.md
├── modules/
│   ├── write-first-csharp-method/
│   │   ├── Program.cs
│   │   └── write-first-csharp-method.csproj
│   ├── create-csharp-methods-parameters/
│   │   ├── Program.cs
│   │   └── create-csharp-methods-parameters.csproj
│   └── create-csharp-methods-return-values/
│       ├── Program.cs
│       └── create-csharp-methods-return-values.csproj
└── guided-projects/
    └── plan-petting-zoo-visit/
        ├── Program.cs
        └── plan-petting-zoo-visit.csproj
```

This section uses one central README for curriculum documentation. Individual
module, guided-project, and challenge-project directories contain executable
source code and project files without an additional README unless a future
project requires dedicated documentation.

---

# Module 1 — Write Your First C# Method

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 9 / 9
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
Solution project count: 28
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Application run: Succeeded
Expected output: Verified
Project compilation: Succeeded
Full solution build: Succeeded in 4.2 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 7, 2026
```

The first module introduces the syntax, execution model, and design purpose of
C# methods.

The final project demonstrates:

- method declarations;
- method calls and invocations;
- execution control entering and leaving a method;
- parameterless `void` methods;
- PascalCase method naming;
- task-oriented method names;
- removal of duplicated code;
- reusable methods;
- early method termination with `return`;
- pseudo-code-driven program design;
- decomposition of a large problem into focused methods;
- top-level variables shared with local methods;
- method-based medicine-schedule formatting;
- method-based IPv4 validation;
- a reusable fortune-teller challenge.

Project location:

```text
curriculum/create-methods-in-csharp-console-applications/
└── modules/
    └── write-first-csharp-method/
        ├── Program.cs
        └── write-first-csharp-method.csproj
```

---

## Why Methods Matter

As a console application grows, a long sequence of statements becomes difficult
to read, verify, and maintain.

A method gives a meaningful name to one task.

Without a method:

```csharp
Console.WriteLine("Before task");

// Several implementation statements appear here.

Console.WriteLine("After task");
```

With a method:

```csharp
Console.WriteLine("Before task");

PerformTask();

Console.WriteLine("After task");
```

The caller can understand the program's intention before reading the detailed
implementation.

Methods support three important engineering goals:

```text
Organization
→ related statements are grouped under one task name

Reuse
→ the same implementation can be called multiple times

Maintainability
→ one correction updates every call site
```

---

## Method Declaration

A method declaration defines a named unit of behavior.

```csharp
void SayHello()
{
    Console.WriteLine("Hello World!");
}
```

The declaration contains four principal elements:

```text
void
→ return type

SayHello
→ method name

()
→ parameter list

{ ... }
→ method body
```

### Return type

```csharp
void
```

`void` means that the method performs work but does not return a value to its
caller.

Later modules introduce methods that return values such as:

```text
bool
int
double
string
arrays
```

### Method name

```csharp
SayHello
```

C# method names normally use **PascalCase**.

Good method names usually begin with a verb:

```text
DisplayRandomNumbers
DisplayTimes
AdjustTimes
ValidateLength
ValidateRange
TellFortune
```

A strong method name describes the task rather than its implementation details.

### Parameter list

```csharp
()
```

The empty parentheses indicate that the method currently accepts no input
parameters.

Parameters are introduced in the next curriculum module.

### Method body

```csharp
{
    Console.WriteLine("Hello World!");
}
```

The braces contain the statements executed when the method is called.

---

## Method Call and Invocation

A method is executed by calling its name with parentheses:

```csharp
SayHello();
```

The terms **method call** and **method invocation** refer to this action.

Execution flow:

```text
Caller reaches SayHello()
        ↓
Control enters SayHello()
        ↓
Statements in the method body execute
        ↓
The method reaches its end
        ↓
Control returns to the caller
        ↓
Execution continues after SayHello()
```

Example:

```csharp
Console.WriteLine("Before calling SayHello().");

SayHello();

Console.WriteLine("After calling SayHello().");
```

Output:

```text
Before calling SayHello().
Hello World!
After calling SayHello().
```

The method does not run merely because it has been declared. It runs only when
the program invokes it.

---

## Method Declaration Order

In a top-level C# program, a local method may be called before its declaration:

```csharp
SayHello();

void SayHello()
{
    Console.WriteLine("Hello World!");
}
```

This allows the high-level application flow to remain near the top of
`Program.cs`, while detailed method implementations appear later.

The final source uses this organization:

```text
Top-level application flow
→ describes what the program does

Method declarations
→ describe how each task is performed
```

---

## Top-Level Program Flow

The final source begins with a readable sequence of task names:

```csharp
DemonstrateMethodExecution();
DisplayRandomNumbers();
RunMedicineScheduleExample();
ValidateIpv4Addresses();
RunFortuneChallenge();
DisplayModuleSummary();
```

This sequence acts as a high-level table of contents for the program.

A reader can understand the overall flow without first examining hundreds of
implementation lines.

---

## Create and Call a Method

The random-number example demonstrates a self-contained action:

```csharp
void DisplayRandomNumbers()
{
    for (int index = 0; index < 5; index++)
    {
        Console.Write(
            $"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
```

The method:

- generates five random integers;
- displays each integer;
- adds one final line break;
- returns control to its caller.

The caller only needs:

```csharp
DisplayRandomNumbers();
```

This is easier to understand than embedding the entire loop in the top-level
program.

---

## Deterministic Repository Output

The lesson originally creates `Random` without a seed:

```csharp
Random random = new Random();
```

The repository version uses a fixed seed:

```csharp
Random random = new(20260807);
```

This still demonstrates `Random`, but repeated verification runs generate the
same sequence.

Deterministic output improves:

- regression verification;
- screenshot comparison;
- troubleshooting;
- future automated testing.

This is a repository-level engineering refinement, not a new curriculum
requirement.

---

## Identify Duplicated Code

The medicine-schedule exercise initially repeats two kinds of logic:

```text
Repeated foreach blocks
→ format and display medicine times

Repeated for loops
→ adjust every medicine time
```

Duplicated logic creates several risks:

- corrections must be repeated;
- copies can diverge;
- the top-level flow becomes difficult to read;
- future changes can update one copy but miss another.

The repeated blocks are replaced by:

```csharp
DisplayTimes();
AdjustTimes();
```

---

## Reusable `DisplayTimes()` Method

```csharp
void DisplayTimes()
{
    foreach (int value in medicineTimes)
    {
        // Format one medicine time.
    }

    Console.WriteLine();
}
```

The same method displays both schedules:

```csharp
Console.WriteLine(
    "Current Medicine Schedule:");

DisplayTimes();

// Adjust the schedule.

Console.WriteLine(
    "New Medicine Schedule:");

DisplayTimes();
```

The formatting rule therefore has one authoritative implementation.

---

## Reusable `AdjustTimes()` Method

```csharp
void AdjustTimes()
{
    for (
        int index = 0;
        index < medicineTimes.Length;
        index++)
    {
        int shiftedTime =
            medicineTimes[index] +
            timeZoneDifference;

        medicineTimes[index] =
            ((shiftedTime % 2400) + 2400) % 2400;
    }
}
```

The method applies one time-zone difference to every scheduled value.

The expression:

```csharp
((shiftedTime % 2400) + 2400) % 2400
```

keeps the result in the range:

```text
0 through 2399
```

The additional normalization also handles negative values safely.

---

## Shared State in the First Method Module

The module intentionally uses parameterless methods.

Variables such as:

```csharp
int[] medicineTimes;
int timeZoneDifference;
string[] currentAddress;
int luck;
```

are declared in the top-level program scope.

Local methods can access those variables.

Example:

```csharp
void AdjustTimes()
{
    medicineTimes[index] =
        medicineTimes[index] +
        timeZoneDifference;
}
```

This design is useful for introducing method syntax, but it creates hidden
dependencies:

```text
AdjustTimes()
→ depends on medicineTimes
→ depends on timeZoneDifference
```

A caller cannot see those dependencies from:

```csharp
AdjustTimes();
```

The next module improves this design by passing values through parameters.

---

## Early Return

The `return` keyword immediately ends the current method.

Example:

```csharp
if (
    Math.Abs(currentGmt) > 12 ||
    Math.Abs(destinationGmt) > 12)
{
    Console.WriteLine("Invalid GMT");
    return;
}
```

When `return` executes:

```text
The current method stops
→ remaining statements are skipped
→ control returns to the caller
```

This pattern prevents invalid data from reaching later processing steps.

---

## Pseudo-Code

**Pseudo-code** describes a solution in ordinary language before all syntax
details are implemented.

IPv4 validation begins with:

```text
if an IPv4 address contains exactly four numbers
and no number contains an invalid leading zero
and every number is between 0 and 255

then the address is valid
otherwise the address is invalid
```

Each rule becomes one method:

```csharp
ValidateLength();
ValidateZeroes();
ValidateRange();
```

This creates a direct mapping:

| Requirement | Method |
| --- | --- |
| exactly four segments | `ValidateLength()` |
| no invalid leading zero | `ValidateZeroes()` |
| values from 0 through 255 | `ValidateRange()` |

Methods therefore act as executable pieces of the original plan.

---

## Build Code with Methods

The IPv4 example demonstrates a top-down design process:

```text
1. Write the validation rules in pseudo-code
2. Name one method for each rule
3. Call the methods from the high-level flow
4. Implement each method separately
5. Test several valid and invalid inputs
```

High-level flow:

```csharp
ValidateLength();
ValidateZeroes();
ValidateRange();

bool isValid =
    validLength &&
    validZeroes &&
    validRange;
```

The conditional reads like a direct statement of the specification.

---

## Validate IPv4 Length

```csharp
void ValidateLength()
{
    validLength =
        currentAddress.Length == 4;
}
```

A valid IPv4 address must contain exactly four segments.

Example:

```text
107.31.1.5
→ four segments
→ valid length
```

---

## Validate Leading Zeroes

```csharp
void ValidateZeroes()
{
    validZeroes = true;

    foreach (string number in currentAddress)
    {
        bool isEmpty =
            string.IsNullOrEmpty(number);

        bool hasLeadingZero =
            number.Length > 1 &&
            number.StartsWith('0');

        if (isEmpty || hasLeadingZero)
        {
            validZeroes = false;
            return;
        }
    }
}
```

The method begins with the assumption that the address satisfies the rule.

It stops after the first invalid segment because no later segment can restore
the complete address to a valid state.

Examples:

```text
0
→ valid

01
→ invalid leading zero

255...255
→ contains empty segments
→ invalid
```

---

## Validate Numeric Range

```csharp
void ValidateRange()
{
    validRange = true;

    foreach (string number in currentAddress)
    {
        bool parsed =
            int.TryParse(
                number,
                out int value);

        bool outsideIpv4Range =
            value < 0 ||
            value > 255;

        if (!parsed || outsideIpv4Range)
        {
            validRange = false;
            return;
        }
    }
}
```

`int.TryParse()` is used instead of `int.Parse()`.

This prevents malformed or empty data from throwing an exception.

Examples:

```text
192
→ parsed successfully
→ within range

256
→ parsed successfully
→ outside range

empty string
→ parse fails
→ invalid
```

---

## Preserve Empty IPv4 Segments

The final source uses:

```csharp
currentAddress =
    ipAddress.Split('.');
```

It deliberately does not use:

```csharp
StringSplitOptions.RemoveEmptyEntries
```

for validation.

For:

```text
255...255
```

empty segments are part of the invalid input and must remain visible to the
validation logic.

Removing them too early would discard evidence of missing numbers.

---

## IPv4 Verification Cases

The final repository source checks:

```text
107.31.1.5
255.0.0.255
555..0.555
255...255
01.2.3.4
192.168.1.256
```

Expected classifications:

| Input | Expected result | Reason |
| --- | --- | --- |
| `107.31.1.5` | Valid | four values, no leading zero, valid range |
| `255.0.0.255` | Valid | boundary values are allowed |
| `555..0.555` | Invalid | empty segment and values above 255 |
| `255...255` | Invalid | missing segments |
| `01.2.3.4` | Invalid | leading zero |
| `192.168.1.256` | Invalid | final value exceeds 255 |

The two additional repository cases strengthen verification beyond the minimum
lesson output.

---

## Challenge — Reusable `TellFortune()` Method

The challenge begins with inline fortune-generation logic.

The repeated task is moved into:

```csharp
void TellFortune()
{
    // Select and display the fortune.
}
```

The same method is called with different luck values:

```csharp
luck = 90;
TellFortune();

luck = 50;
TellFortune();

luck = 10;
TellFortune();
```

This proves that the method is reusable.

---

## Select a Fortune Category

```csharp
string[] selectedFortune =
    luck > 75
        ? goodFortunes
        : luck < 25
            ? badFortunes
            : neutralFortunes;
```

Selection rules:

```text
luck greater than 75
→ good fortune

luck less than 25
→ bad fortune

otherwise
→ neutral fortune
```

The method then joins each sentence prefix with the corresponding fortune text.

---

## Avoid Hardcoded Loop Length

The lesson solution uses:

```csharp
for (int index = 0; index < 4; index++)
```

The repository version uses:

```csharp
for (
    int index = 0;
    index < fortunePrefixes.Length;
    index++)
```

Using the array length keeps the loop synchronized with the source data.

This avoids a **magic number** whose meaning is not explicit at the call site.

---

## Module Summary Output

The final application ends with a compact summary:

```text
Method declaration -> defines a named task and its implementation.
Method invocation  -> transfers control into the method body.
void               -> the method performs work without returning data.
PascalCase         -> standard naming style for C# methods.
return             -> ends the current method immediately.
Reusable method    -> replaces duplicated logic with one implementation.
Pseudo-code        -> describes the solution before syntax details.
Small methods      -> divide one large problem into focused tasks.
```

This provides a visible verification that the complete module flow reached its
final stage.

---

## Source-Code Organization

The final `Program.cs` is organized into:

```text
1. Module documentation
2. Shared top-level data
3. High-level application flow
4. Method declarations
5. Execution-flow demonstration
6. Random-number method
7. Medicine-schedule methods
8. IPv4 validation methods
9. Fortune challenge method
10. Module summary
```

Method names describe actions:

```text
DemonstrateMethodExecution
DisplayRandomNumbers
RunMedicineScheduleExample
DisplayTimes
AdjustTimes
ValidateIpv4Addresses
ValidateLength
ValidateZeroes
ValidateRange
RunFortuneChallenge
TellFortune
DisplayModuleSummary
```

This is the first repository project whose primary structure is based on
user-defined methods rather than one long top-level statement sequence.

---

## Commenting Standard Introduced in Section 5

Comments in this module focus on design and execution behavior.

Useful comments explain:

- why logic belongs in a method;
- where execution control moves;
- why duplicate code was removed;
- what hidden state a parameterless method depends on;
- why `return` is safe and useful;
- why a parsing API was selected;
- why an edge case must be preserved;
- why a deterministic seed helps verification.

Comments avoid merely restating syntax.

Weak comment:

```csharp
// Create an integer named index.
int index = 0;
```

Stronger comment:

```csharp
// Use the array length instead of a hardcoded count so the loop remains
// synchronized with the source data.
```

This standard will continue throughout the methods learning path.

---

## Important Design Limitation

The current methods access shared top-level variables.

Example:

```csharp
void TellFortune()
{
    // Reads luck and several arrays from outer scope.
}
```

This makes the first lesson easier to understand, but the method is not yet
fully independent.

A more reusable method should make its required data explicit:

```text
Current module
→ parameterless methods
→ shared outer variables

Next module
→ parameters
→ explicit input data

Later module
→ return values
→ explicit output data
```

This progression is central to Section 5.

---

## Verification

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\create-methods-in-csharp-console-applications\modules\write-first-csharp-method\write-first-csharp-method.csproj"
```

Build the module independently:

```powershell
dotnet build `
  ".\curriculum\create-methods-in-csharp-console-applications\modules\write-first-csharp-method\write-first-csharp-method.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified evidence:

```text
Final application run: Succeeded
Method-flow output: Verified
Random-number section: Verified
Medicine-schedule section: Verified
IPv4 validation section: Verified
Fortune challenge: Verified
Module summary reached: Verified
Project registration: Verified
Registered solution projects: 28
Project compilation in solution: Succeeded
Full solution build: Succeeded in 4.2 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 7, 2026
```

Git state before commit:

```text
Modified:
freecodecamp-csharp.slnx

Untracked:
curriculum/create-methods-in-csharp-console-applications/modules/
```

The module has not yet been recorded as committed or pushed in this README
checkpoint.

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| method | `/ˈmeθ.əd/` | “me-thợd” | phương thức |
| method declaration | `/ˈmeθ.əd ˌdek.ləˈreɪ.ʃən/` | “me-thợd đe-cờ-lờ-rây-shần” | khai báo phương thức |
| method invocation | `/ˈmeθ.əd ˌɪn.vəˈkeɪ.ʃən/` | “me-thợd in-vờ-kây-shần” | lời gọi phương thức |
| method body | `/ˈmeθ.əd ˈbɒd.i/` | “me-thợd bo-đi” | thân phương thức |
| return type | `/rɪˈtɜːn taɪp/` | “ri-tơn tai-p” | kiểu dữ liệu trả về |
| parameter | `/pəˈræm.ɪ.tər/` | “pờ-ram-mi-tờ” | tham số |
| argument | `/ˈɑːɡ.jə.mənt/` | “a-giu-mần-t” | đối số |
| execution control | `/ˌek.sɪˈkjuː.ʃən kənˈtrəʊl/` | “éc-xi-kiu-shần cần-trâu-l” | quyền điều khiển luồng thực thi |
| reusable | `/ˌriːˈjuː.zə.bəl/` | “ri-iu-zờ-bồ” | có thể tái sử dụng |
| duplicated code | `/ˈdjuː.plɪ.keɪ.tɪd kəʊd/` | “điu-pli-kây-tịt côud” | mã nguồn bị lặp |
| pseudo-code | `/ˈsuː.dəʊ kəʊd/` | “su-đô côud” | mã giả |
| early return | `/ˈɜː.li rɪˈtɜːn/` | “ơ-li ri-tơn” | kết thúc phương thức sớm |
| scope | `/skəʊp/` | “scốup” | phạm vi truy cập |
| shared state | `/ʃeəd steɪt/` | “she-ờđ stâyt” | trạng thái dùng chung |
| PascalCase | `/ˈpæs.kəl keɪs/` | “pát-cồ câys” | quy tắc viết hoa đầu mỗi từ |
| modularization | `/ˌmɒd.jə.lə.raɪˈzeɪ.ʃən/` | “mo-điu-lờ-rai-zây-shần” | chia chương trình thành các mô-đun nhỏ |

---

## Completion Record

```text
Curriculum item: Write Your First C# Method
Section: Create Methods in C# Console Applications
Module position: 1 / 5
Microsoft Learn units: 9 / 9
Learning status: Completed
Module assessment: Passed
Achievement: Earned
Repository verification status: Fully verified
Project registration: Verified
Solution project count: 28
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Final application run: Succeeded
Expected output: Verified
Project compilation: Succeeded
Full solution build: Succeeded in 4.2 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 7, 2026
```

---

# Module 2 — Create C# Methods with Parameters

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 9 / 9
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
Solution project count: 29
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Application run: Succeeded
Expected output: Verified
Employee email challenge: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 8, 2026
```

The second module makes method inputs explicit by introducing **parameters** and
**arguments**.

The final project demonstrates:

- declaring one or more method parameters;
- supplying literal and variable arguments;
- distinguishing parameters from arguments;
- method scope;
- variables with the same name in different scopes;
- methods calling other methods;
- value-type argument behavior;
- reference-type argument behavior;
- array mutation through a method parameter;
- string immutability;
- required parameters;
- optional parameters with default values;
- positional arguments;
- named arguments;
- mixing positional and named arguments correctly;
- an RSVP application;
- the employee email-address challenge.

Project location:

```text
curriculum/create-methods-in-csharp-console-applications/
└── modules/
    └── create-csharp-methods-parameters/
        ├── Program.cs
        └── create-csharp-methods-parameters.csproj
```

---

## Parameters and Arguments

A parameter is a variable declared in a method signature.

```csharp
void CountTo(int max)
{
    for (int index = 0; index < max; index++)
    {
        Console.Write($"{index}, ");
    }
}
```

Here:

```text
int max
→ parameter
```

The caller supplies an argument:

```csharp
CountTo(5);
```

Here:

```text
5
→ argument
```

The data flow is:

```text
caller
  ↓
argument
  ↓
parameter
  ↓
method body
```

This makes a method's required input visible directly in its signature.

---

## Multiple Parameters

Methods can accept multiple parameters separated by commas:

```csharp
void DisplayAdjustedTimes(
    int[] times,
    int currentGmt,
    int newGmt)
{
    // Method implementation.
}
```

A matching call supplies three arguments:

```csharp
DisplayAdjustedTimes(
    schedule,
    6,
    -6);
```

Argument-to-parameter mapping:

```text
schedule → times
6        → currentGmt
-6       → newGmt
```

The caller can supply:

- variables;
- literals;
- expressions;
- arrays;
- objects whose types are compatible with the declared parameters.

---

## Parameterized Medicine-Schedule Example

The previous module relied on shared top-level variables.

The parameterized version makes its dependencies explicit:

```csharp
void DisplayAdjustedTimes(
    int[] times,
    int currentGmt,
    int newGmt)
```

The method:

1. validates GMT offsets;
2. calculates the difference;
3. adjusts every scheduled time;
4. displays the original and adjusted values.

Example call:

```csharp
DisplayAdjustedTimes(
    schedule,
    6,
    -6);
```

Expected lesson output:

```text
800 -> 2000
1200 -> 0
1600 -> 400
2000 -> 800
```

The repository version also normalizes negative remainders so displayed times
remain in the `0000` through `2399` range.

---

## Why Parameters Improve Method Design

Compare the two designs.

Hidden dependency:

```csharp
void AdjustTimes()
{
    // Reads shared variables from outer scope.
}
```

Explicit dependency:

```csharp
void DisplayAdjustedTimes(
    int[] times,
    int currentGmt,
    int newGmt)
{
}
```

The second signature tells the reader exactly what the method requires.

Benefits:

```text
Readability
→ dependencies are visible

Reuse
→ the same method can receive different data

Testing
→ a caller can supply controlled test inputs

Maintenance
→ data flow is easier to trace

Isolation
→ fewer unrelated outer variables are required
```

---

## Method Scope

**Scope** is the region where a variable can be accessed.

A parameter exists inside the method that declares it:

```csharp
void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
}
```

The `students` parameter is available inside `DisplayStudents()`.

A variable declared inside one method is not automatically available inside a
different method.

---

## Same Name, Different Scope

A caller can have a variable named `students`:

```csharp
string[] students =
{
    "Jenna",
    "Ayesha",
    "Carlos",
    "Viktor"
};
```

and call:

```csharp
DisplayStudents(students);
```

The method may also declare:

```csharp
void DisplayStudents(string[] students)
```

These are separate variables in different scopes.

The caller's `students` variable supplies the argument.

The method's `students` parameter receives the argument value.

---

## Methods Calling Other Methods

Methods can delegate work to other methods.

```csharp
void PrintCircleInfo(
    int radius,
    double pi)
{
    PrintCircleArea(
        radius,
        pi);

    PrintCircleCircumference(
        radius,
        pi);
}
```

Data can therefore flow through several levels:

```text
top-level caller
    ↓
PrintCircleInfo(radius, pi)
    ↓
PrintCircleArea(radius, pi)
    ↓
PrintCircleCircumference(radius, pi)
```

This supports modular program organization.

---

## Value-Type Arguments

Types such as:

```text
int
bool
float
double
char
```

are value types.

Example:

```csharp
int a = 3;
int b = 4;
int c = 0;

Multiply(
    a,
    b,
    c);
```

Method:

```csharp
void Multiply(
    int a,
    int b,
    int c)
{
    c = a * b;
}
```

`c` inside the method is a separate parameter variable.

Expected behavior:

```text
inside Multiply method: 3 x 4 = 12
global statement: 3 x 4 = 0
```

Changing the method's `c` parameter does not modify the caller's `c` variable.

---

## Reference-Type Arguments

Arrays are reference types.

Example:

```csharp
int[] numbers =
{
    1,
    2,
    3,
    4,
    5
};

Clear(numbers);
```

Method:

```csharp
void Clear(int[] numbers)
{
    for (
        int index = 0;
        index < numbers.Length;
        index++)
    {
        numbers[index] = 0;
    }
}
```

After the method returns:

```text
0 0 0 0 0
```

The important distinction is:

```text
The parameter is still passed by value by default.
The copied value is a reference to the same array object.
Mutating that shared object is therefore visible to the caller.
```

This is more precise than saying that an array is automatically "passed by
reference."

---

## String Immutability

`string` is a reference type, but strings are **immutable**.

A method can receive:

```csharp
string status = "Healthy";

SetHealthCopy(
    status,
    false);
```

Method:

```csharp
void SetHealthCopy(
    string status,
    bool isHealthy)
{
    status =
        isHealthy
            ? "Healthy"
            : "Unhealthy";
}
```

Reassigning the method parameter does not rewrite the original string object.

Expected flow:

```text
Start: Healthy
Middle: Unhealthy
End: Healthy
```

The parameter is rebound to another string inside the method scope.

The caller's variable remains unchanged.

---

## Mutable Reference Objects

The repository source also demonstrates the contrasting behavior using an
array:

```csharp
string[] statusHolder =
{
    "Healthy"
};

SetHealthInArray(
    statusHolder,
    false);
```

Because the array object is mutable:

```csharp
statusHolder[0] = "Unhealthy";
```

changes the shared array object.

This example separates two different ideas:

```text
reference type
≠ automatically mutable

string
→ reference type
→ immutable

array
→ reference type
→ mutable elements
```

---

## Optional Parameters

A parameter becomes optional when its declaration includes a default value:

```csharp
void RSVP(
    string name,
    int partySize = 1,
    string allergies = "none",
    bool inviteOnly = true)
```

Here:

```text
name
→ required

partySize
→ optional
→ default: 1

allergies
→ optional
→ default: "none"

inviteOnly
→ optional
→ default: true
```

Required parameters must be supplied.

Optional parameters may be omitted.

---

## Optional Parameter Calls

The same method can be called in several forms:

```csharp
RSVP("Rebecca");
```

uses all defaults.

```csharp
RSVP(
    "Nadia",
    2,
    "Nuts");
```

supplies the first three arguments and uses the default `inviteOnly`.

```csharp
RSVP(
    name: "Linh",
    partySize: 2,
    inviteOnly: false);
```

omits `allergies`, so `"none"` is used.

---

## Named Arguments

A named argument identifies the target parameter explicitly:

```csharp
RSVP(
    name: "Linh",
    partySize: 2,
    inviteOnly: false);
```

Syntax:

```text
parameterName: argumentValue
```

Named arguments improve readability when several parameters have similar types.

Example:

```csharp
RSVP(
    "Tony",
    allergies: "Jackfruit",
    inviteOnly: true);
```

The call clearly states what each non-positional value means.

---

## Positional and Named Arguments

Positional arguments are matched by their position.

Named arguments are matched by parameter name.

A valid mixed call:

```csharp
RSVP(
    "Tony",
    allergies: "Jackfruit",
    inviteOnly: true);
```

The first argument remains positional because it corresponds to the first
parameter.

Named arguments can then select later parameters.

The principal design rule is to avoid ambiguous ordering and make the intended
parameter mapping obvious.

---

## RSVP Application

The module uses an RSVP application to integrate:

- required parameters;
- optional parameters;
- named arguments;
- positional arguments;
- early `return`;
- array storage;
- invite-only validation.

Guest list:

```text
Rebecca
Nadia
Noor
Jonte
```

Tony is rejected because the call uses:

```csharp
inviteOnly: true
```

and his name is absent from the guest list.

Expected message:

```text
Sorry, Tony is not on the guest list
```

Valid RSVP entries are then displayed.

---

## Challenge — Display Employee Email Addresses

The final challenge creates email addresses for internal and external employees.

Two employee groups are stored in two-dimensional arrays:

```text
corporate
external
```

Internal domain:

```text
contoso.com
```

External domain:

```text
hayworth.com
```

Username rule:

```text
first two characters of first name
+
full last name
+
lowercase
```

Example:

```text
Robert Bavin
→ Ro + Bavin
→ RoBavin
→ robavin
→ robavin@contoso.com
```

---

## Optional Domain Parameter

The challenge method is:

```csharp
void DisplayEmail(
    string first,
    string last,
    string domain = "contoso.com")
```

For internal employees:

```csharp
DisplayEmail(
    first: corporate[row, 0],
    last: corporate[row, 1]);
```

The domain argument is omitted.

Result:

```text
contoso.com
```

For external employees:

```csharp
DisplayEmail(
    first: external[row, 0],
    last: external[row, 1],
    domain: externalDomain);
```

The default is overridden.

Result:

```text
hayworth.com
```

---

## Verified Email Output

The completed application produces:

```text
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
```

This verifies:

- optional parameter behavior;
- named argument behavior;
- two-dimensional array indexing;
- username construction;
- lowercase normalization;
- internal and external domains.

---

## Safer Username Prefix Handling

The lesson data guarantees first names of at least two characters.

The repository source nevertheless calculates:

```csharp
int prefixLength =
    Math.Min(
        2,
        first.Length);
```

and then uses:

```csharp
first[..prefixLength]
```

This preserves the required challenge behavior while avoiding an out-of-range
substring operation if future test data contains a one-character first name.

---

## Source-Code Organization

The final `Program.cs` is organized into:

```text
1. Module documentation
2. High-level application flow
3. Parameter and argument example
4. Method-scope examples
5. Value-type behavior
6. Array reference behavior
7. String immutability
8. RSVP application
9. Employee email challenge
10. Module summary
```

Top-level flow:

```csharp
DemonstrateBasicParameters();
DemonstrateMethodScope();
DemonstrateValueAndReferenceBehavior();
RunRsvpApplication();
RunEmailChallenge();
DisplayModuleSummary();
```

A reader can first understand **what** the program does, then inspect each method
to understand **how** that task is implemented.

---

## Commenting Standard for Parameterized Methods

Comments now document data-flow responsibilities in addition to method intent.

Important questions include:

```text
What data enters this method?
Which name is the parameter?
Which value is the argument?
Does the method mutate a shared object?
Does reassignment affect only the local parameter?
Is a parameter required or optional?
What default is used when an argument is omitted?
Why is a named argument clearer here?
```

This is a higher-level commenting standard than merely describing syntax.

---

## Module Progression

Section 5 now has a clear progression:

```text
Module 1
parameterless methods
→ organize behavior

Module 2
parameters
→ explicit input data

Module 3
return values
→ explicit output data
```

After Module 2, a reusable method can clearly declare what it needs from its
caller.

The next module completes the basic method data-flow model by returning a result
to the caller.

---

## Verification

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\create-methods-in-csharp-console-applications\modules\create-csharp-methods-parameters\create-csharp-methods-parameters.csproj"
```

Build the module independently:

```powershell
dotnet build `
  ".\curriculum\create-methods-in-csharp-console-applications\modules\create-csharp-methods-parameters\create-csharp-methods-parameters.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified repository evidence:

```text
Final application run: Succeeded
Parameter and argument examples: Verified
Method-scope examples: Verified
Value-type behavior: Verified
Array mutation behavior: Verified
String immutability behavior: Verified
RSVP application: Verified
Employee email challenge: Verified
Module summary reached: Verified
Project registration: Verified
Registered solution projects: 29
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 8, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| parameter | `/pəˈræm.ɪ.tər/` | “pờ-ram-mi-tờ” | tham số được khai báo trong method |
| argument | `/ˈɑːɡ.jə.mənt/` | “a-giu-mần-t” | đối số truyền vào khi gọi method |
| method signature | `/ˈmeθ.əd ˈsɪɡ.nə.tʃər/` | “me-thợd síc-nờ-chờ” | chữ ký phương thức |
| scope | `/skəʊp/` | “scốup” | phạm vi truy cập |
| value type | `/ˈvæl.juː taɪp/` | “va-liu tai-p” | kiểu giá trị |
| reference type | `/ˈref.ər.əns taɪp/` | “re-phờ-rần-x tai-p” | kiểu tham chiếu |
| immutable | `/ɪˈmjuː.tə.bəl/` | “i-miu-tờ-bồ” | bất biến, không thể sửa tại chỗ |
| mutable | `/ˈmjuː.tə.bəl/` | “miu-tờ-bồ” | có thể thay đổi |
| positional argument | `/pəˈzɪʃ.ən.əl ˈɑːɡ.jə.mənt/` | “pờ-zi-shờ-nồ a-giu-mần-t” | đối số theo vị trí |
| named argument | `/neɪmd ˈɑːɡ.jə.mənt/` | “nâymđ a-giu-mần-t” | đối số có tên |
| optional parameter | `/ˈɒp.ʃən.əl pəˈræm.ɪ.tər/` | “óp-shờ-nồ pờ-ram-mi-tờ” | tham số tùy chọn |
| default value | `/dɪˈfɔːlt ˈvæl.juː/` | “đi-pho-lt va-liu” | giá trị mặc định |
| explicit input | `/ɪkˈsplɪs.ɪt ˈɪn.pʊt/` | “ích-spli-sịt in-pút” | dữ liệu vào được khai báo rõ |
| data flow | `/ˈdeɪ.tə fləʊ/` | “đây-tờ flâu” | luồng dữ liệu |
| caller | `/ˈkɔː.lər/` | “co-lờ” | nơi gọi method |
| callee | `/kɔːˈliː/` | “co-li” | method được gọi |

---

## Completion Record

```text
Curriculum item: Create C# Methods with Parameters
Section: Create Methods in C# Console Applications
Module position: 2 / 5
Microsoft Learn units: 9 / 9
Learning status: Completed
Module assessment: Passed
Achievement: Earned
Repository verification status: Fully verified
Project registration: Verified
Solution project count: 29
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Final application run: Succeeded
Expected output: Verified
Employee email challenge: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 8, 2026
```

---

# Module 3 — Create C# Methods That Return Values

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 10 / 10
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
Solution project count: 30
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Application run: Succeeded
Expected output: Verified
Shopping-center example: Verified
Numeric return examples: Verified
String return examples: Verified
Boolean return examples: Verified
Array return examples: Verified
Dice mini-game challenge: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 9, 2026
```

The third instructional module completes the fundamental method data-flow model.

Modules 1 and 2 established:

```text
named behavior
→ method

explicit input
→ parameters and arguments
```

Module 3 adds:

```text
explicit output
→ return values
```

The complete model is now:

```text
caller
  ↓
argument
  ↓
parameter
  ↓
method processing
  ↓
return statement
  ↓
return value
  ↓
caller
```

The final project demonstrates:

- declaring method return types;
- distinguishing `void` from value-returning methods;
- returning literals, variables, and expressions;
- capturing returned values in variables;
- using returned values directly inside arithmetic expressions;
- using `bool` return values directly in conditions and ternary expressions;
- returning `int` and `double`;
- numeric casting and integer-division concerns;
- returning `string`;
- composing methods by consuming one method's return value inside another;
- returning `bool` with early termination;
- returning one-dimensional and two-dimensional arrays;
- returning newly constructed arrays directly;
- using sentinel values in partially populated results;
- completing the dice mini-game challenge with correctly typed methods.

Project location:

```text
curriculum/create-methods-in-csharp-console-applications/
└── modules/
    └── create-csharp-methods-return-values/
        ├── Program.cs
        └── create-csharp-methods-return-values.csproj
```

---

## Return Type Syntax

A method's return type appears before its name.

A `void` method performs work without returning data:

```csharp
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
```

A value-returning method declares the type it sends back:

```csharp
int Add(int first, int second)
{
    return first + second;
}
```

The return type is part of the method's contract.

```text
int
→ the caller receives an int

double
→ the caller receives a double

string
→ the caller receives a string

bool
→ the caller receives true or false

int[,]
→ the caller receives a two-dimensional integer array
```

Every normal execution path in a non-`void` method must provide a value
compatible with the declared return type.

---

## The `return` Keyword

For a value-returning method:

```csharp
return expression;
```

does two jobs:

```text
1. evaluate the expression
2. immediately end the current method and send the value to the caller
```

Example:

```csharp
double GetDiscountedPrice(int itemIndex)
{
    return
        items[itemIndex] *
        (1 - discounts[itemIndex]);
}
```

The returned expression evaluates to `double`, which matches the method's
declared return type.

A `return` statement can provide:

```text
a literal
a variable
an arithmetic expression
a comparison
a method-call result
a newly created object or array
```

as long as the resulting type matches the method contract.

---

## Capturing Return Values

A caller can store a returned value:

```csharp
int vnd =
    UsdToVnd(usd);
```

Data flow:

```text
usd
 ↓ argument

UsdToVnd(double usdAmount)
 ↓ processing

return int
 ↓

vnd
```

The caller can then reuse the captured value in later statements.

Returned values do not need to be stored first. They can also be consumed
directly:

```csharp
Console.WriteLine(
    ReverseSentence(input));
```

or:

```csharp
total -=
    TotalMeetsMinimum()
        ? 5.00
        : 0.00;
```

The method call acts like an expression whose value is the method's returned
result.

---

## Shopping-Center Example

The Contoso Shopping Center example combines three different return types:

```csharp
double GetDiscountedPrice(int itemIndex)
bool TotalMeetsMinimum()
string FormatDecimal(double input)
```

Each method answers a different question:

```text
GetDiscountedPrice(...)
→ What is this item's discounted price?
→ double

TotalMeetsMinimum()
→ Has the current total reached the spending threshold?
→ bool

FormatDecimal(...)
→ What text should be displayed for this number?
→ string
```

The caller combines all three results:

```csharp
for (int index = 0; index < items.Length; index++)
{
    total += GetDiscountedPrice(index);
}

total -=
    TotalMeetsMinimum()
        ? 5.00
        : 0.00;

Console.WriteLine(
    $"Total: ${FormatDecimal(total)}");
```

Verified lesson result:

```text
Total: $44.58
```

---

## Return an Expression Directly

A temporary variable is not required when the desired value can be expressed
clearly in the `return` statement.

Longer form:

```csharp
double result =
    items[itemIndex] *
    (1 - discounts[itemIndex]);

return result;
```

Equivalent direct form:

```csharp
return
    items[itemIndex] *
    (1 - discounts[itemIndex]);
```

Direct returns are useful when the expression remains readable and the
intermediate variable would not add meaningful domain information.

---

## Return Boolean Expressions

Comparisons already evaluate to `bool`.

Instead of:

```csharp
bool result =
    total >= minimumSpend;

return result;
```

the method can simply return:

```csharp
return
    total >= minimumSpend;
```

The caller may then use the method anywhere a Boolean expression is valid:

```csharp
if (TotalMeetsMinimum())
{
    // ...
}
```

or:

```csharp
total -=
    TotalMeetsMinimum()
        ? 5.00
        : 0.00;
```

A well-named Boolean method can make the caller read almost like a sentence.

---

## Return Numeric Values

The currency-conversion example demonstrates that numeric return types must be
chosen together with the arithmetic performed inside the method.

### Return `int`

```csharp
int UsdToVnd(double usdAmount)
{
    int rate = 23500;

    return
        (int)(rate * usdAmount);
}
```

`rate * usdAmount` evaluates to `double`.

Because the method promises to return `int`, the example performs an explicit
cast:

```csharp
(int)
```

The cast acknowledges that the fractional part, if any, will be discarded.

Verified result:

```text
$23.73 USD = $557655 VND
```

### Return `double`

```csharp
double VndToUsd(int vndAmount)
{
    double rate = 23500;

    return
        vndAmount / rate;
}
```

Using a `double` rate ensures floating-point division.

If both operands were integers:

```text
integer / integer
→ integer division first
→ fractional part discarded
→ conversion to double happens afterward
```

The method therefore chooses its internal data types deliberately.

Verified result:

```text
$557655 VND = $23.73 USD
```

---

## Return Strings

The string exercise separates two reusable transformations:

```csharp
string ReverseWord(string word)
string ReverseSentence(string sentence)
```

`ReverseWord()` returns one reversed word.

`ReverseSentence()` splits the sentence and reuses `ReverseWord()` for every
word.

Example:

```text
there are snakes at the zoo
```

becomes:

```text
ereht era sekans ta eht ooz
```

---

## Method Composition

One of the strongest ideas in this module is **method composition**.

**Method composition** means using the result produced by one method as part of
another operation or method.

Example:

```csharp
result +=
    ReverseWord(word) +
    " ";
```

Execution flow:

```text
ReverseSentence()
    ↓
calls ReverseWord(word)
    ↓
ReverseWord returns string
    ↓
returned string is appended to result
```

This allows complex behavior to be assembled from small, focused methods.

---

## Return Values Inside Return Statements

A return expression may itself call another method:

```csharp
return result.Trim();
```

Execution order:

```text
result.Trim()
    ↓
Trim() returns string
    ↓
that string becomes the return value of the current method
    ↓
caller receives the final string
```

The important requirement is type compatibility.

---

## Return Boolean Values

The palindrome example uses:

```csharp
bool IsPalindrome(string word)
```

The algorithm compares characters from both ends:

```text
start → first character
end   → last character

compare
 ↓
move both pointers inward
 ↓
repeat until they meet or cross
```

If any mirrored characters differ:

```csharp
if (word[start] != word[end])
{
    return false;
}
```

The method ends immediately.

If every comparison succeeds:

```csharp
return true;
```

Verified output:

```text
racecar: True
talented: False
deified: True
tent: False
tenet: True
```

---

## Multiple Return Paths

`IsPalindrome()` demonstrates that a method may contain multiple `return`
statements:

```text
mismatch found
→ return false immediately

no mismatch found
→ return true at the end
```

The key requirement is not "one return statement."

The real requirement is:

```text
Every reachable completion path in a value-returning method
must produce a compatible return value.
```

---

## Return Arrays

Methods can return complete data structures.

A one-dimensional version can return:

```csharp
return new int[]
{
    current,
    next
};
```

The extended lesson returns a two-dimensional array:

```csharp
int[,] TwoCoins(
    int[] availableCoins,
    int targetValue)
```

The method searches for pairs of coin indices whose values sum to the target.

---

## Two-Coin Search Strategy

For each current coin:

```text
choose current index
    ↓
compare with each later index
    ↓
if values sum to target
    ↓
store the pair
```

The inner loop starts at:

```csharp
current + 1
```

This prevents:

```text
pairing one coin with itself
duplicate reversed pairs such as 0,3 and 3,0
```

---

## Return a Newly Constructed Array

When no matching pair exists, the method can create and return an empty array
directly:

```csharp
return new int[0, 0];
```

No temporary variable is required.

This is another example of the flexibility of the `return` expression.

---

## Sentinel Values

The two-dimensional result array is initialized with:

```text
-1, -1
```

for unused rows.

`-1` acts as a **sentinel value**:

```text
valid index
→ 0 or greater

-1
→ no result stored in this row
```

The caller stops displaying rows when it encounters the sentinel.

This lets one fixed-size array represent between one and five valid pairs.

---

## Early Return When the Result Buffer Is Full

The result array stores at most five pairs.

After the fifth match:

```csharp
if (count == matches.GetLength(0))
{
    return matches;
}
```

The method returns immediately.

This prevents the next match from trying to write beyond the array boundary.

---

## Verified Array Results

For:

```text
coins  = 5, 5, 50, 25, 25, 10, 5
target = 30
```

the expected result is:

```text
Change found at positions:
0,3
0,4
1,3
1,4
3,6
```

For:

```text
target = 80
```

the expected result is:

```text
No two coins make change
```

The final repository source executes both verification cases.

---

## Dice Mini-Game Challenge

The final challenge integrates parameters and return values into a small
interactive program.

Required methods:

```csharp
bool ShouldPlay()
int GetTarget()
int RollDice()
string WinOrLose(int roll, int target)
void PlayGame()
```

The signatures communicate each method's responsibility.

### `ShouldPlay()`

```text
input source
→ Console.ReadLine()

processing
→ compare response with "y"

output
→ bool
```

The returned value decides whether the game starts or continues.

### `GetTarget()`

```csharp
int GetTarget()
```

returns a random integer from:

```text
1 through 5 inclusive
```

### `RollDice()`

```csharp
int RollDice()
```

returns a random integer from:

```text
1 through 6 inclusive
```

### `WinOrLose(...)`

```csharp
string WinOrLose(
    int roll,
    int target)
```

receives explicit input and returns explicit output:

```text
roll > target
→ "You win!"

otherwise
→ "You lose!"
```

### `PlayGame()`

`PlayGame()` coordinates the returned values:

```text
GetTarget()
→ target

RollDice()
→ roll

WinOrLose(roll, target)
→ result message

ShouldPlay()
→ continue or stop
```

This challenge demonstrates how a larger workflow can be built by composing
small methods with clear contracts.

---

## Repository Refinements

The final organized source preserves the lesson concepts while adding a few
small robustness improvements.

### Culture-stable decimal conversion

The shopping example uses invariant culture before applying the lesson's
substring technique:

```csharp
input
    .ToString(CultureInfo.InvariantCulture)
    .Substring(0, 5);
```

This makes repository verification less dependent on the machine's decimal
separator.

For production software, numeric formatting such as:

```csharp
input.ToString("0.00")
```

would normally be preferable to `Substring()`.

### Safer interactive input

The dice challenge protects against a missing input line:

```csharp
string response =
    Console.ReadLine() ??
    string.Empty;
```

and compares using:

```csharp
StringComparison.OrdinalIgnoreCase
```

This preserves the lesson behavior while making the method safer and clearer.

---

## Source-Code Organization

The final `Program.cs` is organized into:

```text
1. Module documentation
2. High-level application flow
3. Shopping-center return-type example
4. Numeric return values
5. String return values
6. Boolean return values
7. Array return values
8. Dice mini-game challenge
9. Module summary
```

Top-level flow:

```csharp
RunShoppingCenterExample();
RunCurrencyConversionExample();
RunStringReturnExample();
RunBooleanReturnExample();
RunArrayReturnExample();
RunDiceMiniGameChallenge();
DisplayModuleSummary();
```

The high-level program therefore describes **what** happens, while the method
bodies explain **how** each task is performed.

---

## Commenting Standard for Return-Value Methods

Comments in this module document both control flow and data flow.

Important questions include:

```text
What return type does this method promise?
What expression is returned?
Where does the returned value go?
Is the caller storing the value or consuming it immediately?
Does the return type preserve the needed precision?
Can an early return end the search safely?
Does every reachable completion path return a compatible value?
Is one method consuming the result of another?
```

This makes comments useful for understanding behavior rather than merely
restating syntax.

---

## Completed Method Progression

The first three modules now form one complete conceptual progression:

```text
Module 1
void Method()
→ named behavior

Module 2
void Method(parameters)
→ explicit input

Module 3
returnType Method(parameters)
→ explicit input
→ processing
→ explicit output
```

A reusable method can now expose both sides of its contract:

```text
What does the method need?
→ parameters

What does the method produce?
→ return type
```

This is the core method model used throughout later C# application design.

---

## Verification

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\create-methods-in-csharp-console-applications\modules\create-csharp-methods-return-values\create-csharp-methods-return-values.csproj"
```

The application is interactive in the final dice challenge.

At:

```text
Would you like to play? (Y/N)
```

enter:

```text
Y
```

to exercise the mini-game, or:

```text
N
```

to terminate that section.

Build the module:

```powershell
dotnet build `
  ".\curriculum\create-methods-in-csharp-console-applications\modules\create-csharp-methods-return-values\create-csharp-methods-return-values.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified repository evidence:

```text
Final application run: Succeeded
Module summary reached: Verified
Shopping-center example: Verified
Numeric return examples: Verified
String return examples: Verified
Boolean return examples: Verified
Array-return example, target 30: Verified
Array-return example, target 80: Verified
Dice mini-game challenge: Verified
Project registration: Verified
Registered solution projects: 30
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 9, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| return type | `/rɪˈtɜːn taɪp/` | “ri-tơn tai-p” | kiểu dữ liệu method trả về |
| return value | `/rɪˈtɜːn ˈvæl.juː/` | “ri-tơn va-liu” | giá trị được trả cho caller |
| return statement | `/rɪˈtɜːn ˈsteɪt.mənt/` | “ri-tơn stâyt-mần-t” | câu lệnh trả kết quả và kết thúc method |
| caller | `/ˈkɔː.lər/` | “co-lờ” | nơi gọi method |
| capture | `/ˈkæp.tʃər/` | “cáp-chờ” | nhận/lưu giá trị trả về |
| expression | `/ɪkˈspreʃ.ən/` | “ích-spre-shần” | biểu thức tạo ra một giá trị |
| numeric | `/njuːˈmer.ɪk/` | “niu-me-rịch” | thuộc dữ liệu số |
| cast | `/kɑːst/` | “ca-st” | ép kiểu |
| integer division | `/ˈɪn.tɪ.dʒər dɪˈvɪʒ.ən/` | “in-ti-jờ đi-vi-zhần” | phép chia số nguyên |
| palindrome | `/ˈpæl.ɪn.droʊm/` | “pa-lin-đrôm” | chuỗi đọc xuôi và ngược giống nhau |
| method composition | `/ˈmeθ.əd ˌkɒm.pəˈzɪʃ.ən/` | “me-thợd com-pờ-zi-shần” | kết hợp nhiều method qua kết quả trả về |
| sentinel value | `/ˈsen.tɪ.nəl ˈvæl.juː/` | “sen-ti-nồ va-liu” | giá trị đánh dấu trạng thái đặc biệt |
| early return | `/ˈɜː.li rɪˈtɜːn/` | “ơ-li ri-tơn” | trả về và kết thúc method sớm |
| explicit output | `/ɪkˈsplɪs.ɪt ˈaʊt.pʊt/` | “ích-spli-sịt ao-pút” | dữ liệu đầu ra được khai báo rõ |

---

## Completion Record

```text
Curriculum item: Create C# Methods That Return Values
Section: Create Methods in C# Console Applications
Module position: 3 / 5
Microsoft Learn units: 10 / 10
Learning status: Completed
Module assessment: Passed
Achievement: Earned
Repository verification status: Fully verified
Project registration: Verified
Solution project count: 30
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Final application run: Succeeded
Expected output: Verified
Shopping-center example: Verified
Numeric return examples: Verified
String return examples: Verified
Boolean return examples: Verified
Array return examples: Verified
Dice mini-game challenge: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 9, 2026
```

---

# Guided Project — Plan a Petting Zoo Visit

## Completion Status

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
Solution project count: 31
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Application run: Succeeded
Expected output: Verified
School A — 6 groups: Verified
School B — 3 groups: Verified
School C — 2 groups: Verified
Randomized animal assignments: Verified
Optional group parameter: Verified
2D group assignment return value: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.4 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 10, 2026
```

This guided project is the first Section 5 application that combines the three
method modules into one complete workflow.

The scenario is the **Contoso Petting Zoo**.

The zoo contains 18 animal species, and three schools are scheduled to visit:

```text
School A
→ 6 groups

School B
→ 3 groups

School C
→ 2 groups
```

For every school, the application must:

```text
randomize the animals
→ assign animals to the requested number of groups
→ print the school name
→ print every animal group
```

Project location:

```text
curriculum/create-methods-in-csharp-console-applications/
└── guided-projects/
    └── plan-petting-zoo-visit/
        ├── Program.cs
        └── plan-petting-zoo-visit.csproj
```

---

## From Pseudo-Code to Methods

The project begins by translating the specification into pseudo-code.

Initial plan:

```csharp
// RandomizeAnimals();
// string[,] group = AssignGroup();

Console.WriteLine("School A");

// PrintGroup(group);
```

This planning step separates the application into distinct tasks before syntax
details are implemented.

The mapping is direct:

| Requirement | Method |
| --- | --- |
| randomize animal order | `RandomizeAnimals()` |
| assign animals to groups | `AssignGroup(...)` |
| print one group assignment | `PrintGroup(...)` |
| coordinate one complete school visit | `PlanSchoolVisit(...)` |

This is an important transition from writing one long statement sequence to
designing an application from named responsibilities.

---

## Application Data

The project uses one array containing 18 animal species:

```csharp
string[] pettingZoo =
{
    "alpacas",
    "capybaras",
    "chickens",
    "ducks",
    "emus",
    "geese",
    "goats",
    "iguanas",
    "kangaroos",
    "lemurs",
    "llamas",
    "macaws",
    "ostriches",
    "pigs",
    "ponies",
    "rabbits",
    "sheep",
    "tortoises",
};
```

The same array participates in two stages:

```text
RandomizeAnimals()
→ changes the order in-place

AssignGroup(...)
→ reads the randomized order
→ produces a new 2D assignment array
```

---

## `RandomizeAnimals()`

The randomization method has no explicit parameters:

```csharp
void RandomizeAnimals()
```

It operates on the shared `pettingZoo` array.

Its responsibility is:

```text
INPUT
shared pettingZoo array

PROCESSING
shuffle the array in-place

OUTPUT
no return value
but the shared array order changes
```

---

## Swapping Two Array Values

The shuffle algorithm depends on a safe swap.

Incorrect idea:

```csharp
pettingZoo[i] = pettingZoo[r];
pettingZoo[r] = pettingZoo[i];
```

The first assignment would destroy the original value at index `i`.

The correct pattern uses temporary storage:

```csharp
string temp =
    pettingZoo[r];

pettingZoo[r] =
    pettingZoo[i];

pettingZoo[i] =
    temp;
```

Data movement:

```text
pettingZoo[r]
→ temp

pettingZoo[i]
→ pettingZoo[r]

temp
→ pettingZoo[i]
```

No animal value is lost during the exchange.

---

## Random Index Range

The final shuffle chooses:

```csharp
int r =
    random.Next(
        i,
        pettingZoo.Length);
```

`Random.Next(minValue, maxValue)`:

```text
includes minValue
excludes maxValue
```

Therefore:

```text
r
→ i through pettingZoo.Length - 1
```

The lower bound increases as the loop advances.

Conceptually:

```text
iteration 0
→ choose from the complete remaining array

iteration 1
→ index 0 is already finalized
→ choose from index 1 onward

iteration 2
→ indexes 0 and 1 are already finalized
→ choose from index 2 onward
```

This prevents previously finalized positions from being repeatedly included in
later selection ranges.

---

## `AssignGroup(...)`

The group-assignment method returns a two-dimensional string array:

```csharp
string[,] AssignGroup(int groups = 6)
```

Its method contract is:

```text
INPUT
groups

PROCESSING
divide the 18 randomized animals
across the requested number of groups

OUTPUT
string[,]
```

The `groups` parameter is optional.

Default:

```text
6
```

So this call:

```csharp
AssignGroup();
```

is equivalent to:

```csharp
AssignGroup(6);
```

---

## Optional Parameter

The optional parameter is declared by assigning a default value:

```csharp
int groups = 6
```

This allows School A to use the standard configuration without explicitly
supplying the number:

```csharp
PlanSchoolVisit("School A");
```

while the other schools override it:

```csharp
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);
```

The same method therefore supports multiple visit configurations.

---

## Two-Dimensional Array Dimensions

The group result is created with:

```csharp
string[,] result =
    new string[
        groups,
        pettingZoo.Length / groups];
```

Dimension 0:

```text
number of groups
```

Dimension 1:

```text
animals per group
```

The three required configurations are:

```text
School A
18 / 6
→ 3 animals per group
→ string[6,3]

School B
18 / 3
→ 6 animals per group
→ string[3,6]

School C
18 / 2
→ 9 animals per group
→ string[2,9]
```

The guided-project requirements use group counts that divide 18 exactly.

---

## Why a 2D Array Fits the Problem

The data naturally has two coordinates:

```text
row
→ student group

column
→ animal position inside that group
```

Example:

```text
groups[0,0]
→ first animal in Group 1

groups[0,1]
→ second animal in Group 1

groups[1,0]
→ first animal in Group 2
```

This makes the 2D array a direct representation of the planning table.

---

## The `start` Index

`AssignGroup(...)` uses:

```csharp
int start = 0;
```

The source array is one-dimensional:

```text
pettingZoo[start]
```

but the destination is two-dimensional:

```text
result[i,j]
```

The `start` variable connects those two structures.

Core assignment:

```csharp
result[i, j] =
    pettingZoo[start++];
```

`start++` means:

```text
1. use the current value of start
2. perform the assignment
3. increment start
```

The sequence is therefore:

```text
pettingZoo[0] → result[0,0]
pettingZoo[1] → result[0,1]
pettingZoo[2] → result[0,2]
...
```

until all 18 animals have been assigned.

---

## Nested Loops in `AssignGroup(...)`

The outer loop traverses rows:

```csharp
for (
    int i = 0;
    i < groups;
    i++)
```

The inner loop traverses columns:

```csharp
for (
    int j = 0;
    j < result.GetLength(1);
    j++)
```

Meaning:

```text
outer loop
→ choose one group

inner loop
→ fill every animal slot in that group
```

This is the standard traversal pattern for rectangular two-dimensional arrays.

---

## Returning the Group Assignment

At the end of `AssignGroup(...)`:

```csharp
return result;
```

The complete 2D array is sent back to the caller.

The caller captures it:

```csharp
string[,] group =
    AssignGroup(groups);
```

Data flow:

```text
groups
  ↓
AssignGroup(groups)
  ↓
create + fill string[,]
  ↓
return result
  ↓
group
```

This directly applies the return-value concepts from Module 3.

---

## `PrintGroup(...)`

The display method accepts:

```csharp
void PrintGroup(string[,] groups)
```

It does not need to know:

```text
which school produced the data
how the array was randomized
how many groups were requested originally
```

It only needs one input:

```text
the completed 2D assignment array
```

This is a good example of a focused method responsibility.

---

## `GetLength(0)` and `GetLength(1)`

For a rectangular 2D array:

```csharp
groups.GetLength(0)
```

returns the number of rows.

In this project:

```text
rows
→ groups
```

While:

```csharp
groups.GetLength(1)
```

returns the number of columns.

In this project:

```text
columns
→ animals per group
```

`PrintGroup(...)` therefore works for all three schools without hardcoding array
dimensions.

---

## Human-Readable Group Numbers

Array indexes begin at zero:

```text
0
1
2
...
```

But the console output should show:

```text
Group 1
Group 2
Group 3
...
```

So the method prints:

```csharp
$"Group {i + 1}: "
```

The internal index remains zero-based while the user-facing label becomes
one-based.

---

## `PlanSchoolVisit(...)`

The orchestration method is:

```csharp
void PlanSchoolVisit(
    string schoolName,
    int groups = 6)
```

This method contains the complete workflow for one school:

```csharp
RandomizeAnimals();

string[,] group =
    AssignGroup(groups);

Console.WriteLine(schoolName);

PrintGroup(group);
```

Instead of duplicating the same four operations three times, the application
calls one reusable method with different arguments.

---

## Method Composition in the Guided Project

`PlanSchoolVisit(...)` composes three lower-level methods:

```text
PlanSchoolVisit(...)
    ↓
RandomizeAnimals()
    ↓
AssignGroup(...)
    ↓
PrintGroup(...)
```

This demonstrates an important application-design principle:

```text
high-level method
→ coordinates the workflow

lower-level methods
→ perform focused tasks
```

The caller can therefore express the entire requirement with:

```csharp
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);
```

The top-level program now reads like the business specification.

---

## Full Data Flow for School B

Call:

```csharp
PlanSchoolVisit("School B", 3);
```

Data flow:

```text
"School B"
→ schoolName

3
→ groups
```

Then:

```text
PlanSchoolVisit(...)
      ↓
RandomizeAnimals()
      ↓
pettingZoo order changes
      ↓
AssignGroup(3)
      ↓
18 / 3 = 6 animals per group
      ↓
return string[3,6]
      ↓
group
      ↓
PrintGroup(group)
      ↓
3 displayed groups
```

This is the complete **input → processing → output** model applied across
multiple methods.

---

## Verified School Configurations

The final application run verifies:

```text
School A
→ 6 groups
→ 3 animals per group

School B
→ 3 groups
→ 6 animals per group

School C
→ 2 groups
→ 9 animals per group
```

The displayed animal order is randomized, so exact animal sequences may differ
between runs.

The structural requirements remain stable:

```text
18 animals total for each school
correct group count
correct animals-per-group count
all assignments displayed
```

---

## Verified Output Shape

A successful run has the following shape:

```text
School A
Group 1: ...
Group 2: ...
Group 3: ...
Group 4: ...
Group 5: ...
Group 6: ...

School B
Group 1: ...
Group 2: ...
Group 3: ...

School C
Group 1: ...
Group 2: ...
```

The actual animal order is intentionally nondeterministic.

Repository verification therefore checks the structure and group counts rather
than expecting one fixed animal sequence.

---

## Source-Code Organization

The final `Program.cs` is organized into:

```text
1. Guided-project documentation
2. Application data
3. Top-level application flow
4. PlanSchoolVisit(...)
5. RandomizeAnimals()
6. AssignGroup(...)
7. PrintGroup(...)
8. Guided-project summary
```

The top-level flow remains intentionally short:

```csharp
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);
```

A reader can understand the complete application requirement before examining
the implementation details.

---

## Method Contracts in the Guided Project

The completed source comments explicitly describe each method using:

```text
INPUT
PROCESSING
OUTPUT
```

### `RandomizeAnimals()`

```text
INPUT
shared pettingZoo array

PROCESSING
shuffle in-place

OUTPUT
changed shared array state
```

### `AssignGroup(...)`

```text
INPUT
group count

PROCESSING
build and populate 2D array

OUTPUT
string[,]
```

### `PrintGroup(...)`

```text
INPUT
string[,] group assignment

PROCESSING
traverse rows and columns

OUTPUT
console text
```

### `PlanSchoolVisit(...)`

```text
INPUT
school name
group count

PROCESSING
coordinate the complete workflow

OUTPUT
complete school visit plan on the console
```

This is the clearest application so far of method contracts and data flow.

---

## Guided-Project Progression

The Section 5 progression is now:

```text
Module 1
method
→ named behavior

Module 2
parameters
→ explicit input

Module 3
return values
→ explicit output

Guided Project
method composition
→ complete application workflow
```

The guided project demonstrates that methods are not isolated syntax features.

They are a way to design an application as cooperating components.

---

## Verification

Run the guided project:

```powershell
dotnet run --project `
  ".\curriculum\create-methods-in-csharp-console-applications\guided-projects\plan-petting-zoo-visit\plan-petting-zoo-visit.csproj"
```

Build the project independently:

```powershell
dotnet build `
  ".\curriculum\create-methods-in-csharp-console-applications\guided-projects\plan-petting-zoo-visit\plan-petting-zoo-visit.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified repository evidence:

```text
Final application run: Succeeded
School A — 6 groups: Verified
School B — 3 groups: Verified
School C — 2 groups: Verified
Randomized animal assignments: Verified
Optional group parameter: Verified
2D group assignment return value: Verified
Project registration: Verified
Registered solution projects: 31
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.4 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 10, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| guided project | `/ˈɡaɪ.dɪd ˈprɒdʒ.ekt/` | “gai-địt pro-jéct” | dự án có hướng dẫn |
| petting zoo | `/ˈpet.ɪŋ zuː/` | “pe-ting zuu” | sở thú cho phép tiếp xúc với động vật |
| shuffle | `/ˈʃʌf.əl/` | “shấ-phồ” | xáo trộn thứ tự |
| swap | `/swɒp/` | “swo-p” | hoán đổi |
| temporary variable | `/ˈtem.pər.ər.i ˈveə.ri.ə.bəl/` | “tem-pờ-rờ-ri ve-ri-ờ-bồ” | biến tạm |
| assign | `/əˈsaɪn/` | “ờ-xain” | gán / phân bổ |
| group | `/ɡruːp/` | “gruup” | nhóm |
| two-dimensional array | `/ˌtuː daɪˈmen.ʃən.əl əˈreɪ/` | “tu đai-men-shờ-nồ ờ-rây” | mảng hai chiều |
| dimension | `/daɪˈmen.ʃən/` | “đai-men-shần” | chiều của mảng |
| row | `/rəʊ/` | “râu” | hàng |
| column | `/ˈkɒl.əm/` | “co-lầm” | cột |
| optional parameter | `/ˈɒp.ʃən.əl pəˈræm.ɪ.tər/` | “óp-shờ-nồ pờ-ram-mi-tờ” | tham số tùy chọn |
| orchestration | `/ˌɔː.kɪˈstreɪ.ʃən/` | “o-ki-strây-shần” | điều phối nhiều bước |
| method composition | `/ˈmeθ.əd ˌkɒm.pəˈzɪʃ.ən/` | “me-thợd com-pờ-zi-shần” | kết hợp các method thành workflow |
| in-place | `/ˌɪn ˈpleɪs/` | “in plâys” | thay đổi trực tiếp trên dữ liệu hiện có |
| data flow | `/ˈdeɪ.tə fləʊ/` | “đây-tờ flâu” | luồng dữ liệu |

---

## Completion Record

```text
Curriculum item: Guided Project — Plan a Petting Zoo Visit
Section: Create Methods in C# Console Applications
Module position: 4 / 5
Microsoft Learn units: 8 / 8
Learning status: Completed
Module assessment: Passed
Achievement: Earned
Repository verification status: Fully verified
Project registration: Verified
Solution project count: 31
Target framework: net10.0
Final organized source: Completed
Professional source comments: Completed
Final application run: Succeeded
Expected output: Verified
School A — 6 groups: Verified
School B — 3 groups: Verified
School C — 2 groups: Verified
Randomized animal assignments: Verified
Optional group parameter: Verified
2D group assignment return value: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.4 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 10, 2026
```

---

## Next Curriculum Item

### Challenge Project — Create a Mini-Game

Section 5 has now completed:

```text
3 instructional modules
+
1 guided project
=
4 / 5 curriculum items
```

The final Section 5 challenge is expected to apply the method concepts with less
step-by-step guidance.

The preparation from the first four items is:

```text
decompose the problem
→ identify method responsibilities
→ define inputs with parameters
→ define outputs with return types
→ compose methods into a complete workflow
→ verify behavior at the application level
```

Expected repository verification remains:

```text
Complete the official challenge project
Organize and comment the final source
Run the completed application
Verify required behavior and output
Build the project
Build the complete solution
Update this section README
Update the repository root README
Review the Git diff
Commit and push
```

---

## Official Curriculum References

- [Microsoft Learn — Create Methods in C# Console Applications](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-5/)
- [Microsoft Learn — Write Your First C# Method](https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/)
- [Microsoft Learn — Create C# Methods with Parameters](https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/)
- [Microsoft Learn — Create C# Methods That Return Values](https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/)
- [Microsoft Learn — Guided Project: Plan a Petting Zoo Visit](https://learn.microsoft.com/en-us/training/modules/guided-project-visit-petting-zoo/)

---

## Navigation

- [Module 1 source](./modules/write-first-csharp-method/)
- [Module 2 source](./modules/create-csharp-methods-parameters/)
- [Module 3 source](./modules/create-csharp-methods-return-values/)
- [Guided project source](./guided-projects/plan-petting-zoo-visit/)
- [Repository overview](../../README.md)

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)

