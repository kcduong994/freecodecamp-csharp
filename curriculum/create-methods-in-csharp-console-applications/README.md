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
Curriculum learning progress: 2 / 5
Repository-verified progress: 2 / 5
Completed instructional modules: 2
Fully repository-verified instructional modules: 2
Completed guided projects: 0
Completed challenge projects: 0
Latest completed learning item: Create C# Methods with Parameters
Latest Microsoft Learn units: 9 / 9
Latest module assessment: Passed
Latest achievement: Earned
Latest completion date: August 8, 2026
Projects registered in solution: 29
Latest project: create-csharp-methods-parameters
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Final application run: Verified
Final output: Verified
Email challenge output: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 3.9 seconds
Latest compiler errors: 0
Latest compiler warnings: 0
Latest IDE diagnostics: No issues found
Next curriculum item: Create C# Methods That Return Values
```

| No. | Curriculum item | Learning status | Repository verification |
| ---: | --- | --- | --- |
| 1 | Write Your First C# Method | Completed | Verified |
| 2 | Create C# Methods with Parameters | Completed | Verified |
| 3 | Create C# Methods That Return Values | Pending | Pending |
| 4 | Guided Project — Plan a Petting Zoo Visit | Pending | Pending |
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

Modules 1 and 2 are fully repository-verified. The latest parameter module
executes its complete lesson flow, verifies the employee email-address
challenge, compiles as part of the twenty-nine-project solution, and preserves
a passing full-solution build.

---

## Repository Structure

```text
create-methods-in-csharp-console-applications/
├── README.md
└── modules/
    ├── write-first-csharp-method/
    │   ├── Program.cs
    │   └── write-first-csharp-method.csproj
    └── create-csharp-methods-parameters/
        ├── Program.cs
        └── create-csharp-methods-parameters.csproj
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

## Next Curriculum Item

### Create C# Methods That Return Values

Module 2 made method inputs explicit.

Current pattern:

```csharp
void DisplayEmail(
    string first,
    string last,
    string domain = "contoso.com")
{
    Console.WriteLine(...);
}
```

The method receives input, performs work, and writes output directly.

The next module introduces methods that send data back to the caller:

```csharp
string BuildEmail(
    string first,
    string last,
    string domain = "contoso.com")
{
    return ...;
}
```

The progression becomes:

```text
argument
   ↓
parameter
   ↓
method processing
   ↓
return value
   ↓
caller
```

Expected repository verification remains:

```text
Complete all official module units
Pass the module assessment
Organize and comment the final source
Run the completed source
Verify required behavior and output
Build the module
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

---

## Navigation

- [Module 1 source](./modules/write-first-csharp-method/)
- [Module 2 source](./modules/create-csharp-methods-parameters/)
- [Repository overview](../../README.md)

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)

