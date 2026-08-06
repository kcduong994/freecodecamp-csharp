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
Curriculum learning progress: 1 / 5
Repository-verified progress: 1 / 5
Completed instructional modules: 1
Fully repository-verified instructional modules: 1
Completed guided projects: 0
Completed challenge projects: 0
Latest completed learning item: Write Your First C# Method
Latest Microsoft Learn units: 9 / 9
Latest module assessment: Passed
Latest achievement: Earned
Latest completion date: August 7, 2026
Projects registered in solution: 28
Latest project: write-first-csharp-method
Target framework: net10.0
Final organized Program.cs: Completed
Professional source comments: Completed
Final application run: Verified
Final output: Verified
Project compilation in full solution: Succeeded
Full solution build: Succeeded in 4.2 seconds
Latest compiler errors: 0
Latest compiler warnings: 0
Latest IDE diagnostics: No issues found
Next curriculum item: Create C# Methods with Parameters
```

| No. | Curriculum item | Learning status | Repository verification |
| ---: | --- | --- | --- |
| 1 | Write Your First C# Method | Completed | Verified |
| 2 | Create C# Methods with Parameters | Pending | Pending |
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

Module 1 is fully repository-verified. Its final application executes all major
lesson examples, produces the expected method-flow and challenge output, and
preserves a passing twenty-eight-project solution build.

---

## Repository Structure

```text
create-methods-in-csharp-console-applications/
├── README.md
└── modules/
    └── write-first-csharp-method/
        ├── Program.cs
        └── write-first-csharp-method.csproj
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

## Next Curriculum Item

### Create C# Methods with Parameters

The next module makes method inputs explicit.

Current pattern:

```csharp
void TellFortune()
{
    // Reads luck from shared outer scope.
}
```

Next-stage pattern:

```csharp
void TellFortune(int luck)
{
    // Uses the supplied parameter.
}
```

Expected topics:

- parameter declaration;
- method arguments;
- parameter data types;
- passing values into methods;
- passing arrays into methods;
- value and reference behavior;
- named arguments;
- optional arguments.

The project should remain registered in `freecodecamp-csharp.slnx`, run
successfully, build independently, preserve a passing full-solution build, and
receive the same source-organization and documentation treatment.

---

## Official Curriculum References

- [Microsoft Learn — Create Methods in C# Console Applications](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-5/)
- [Microsoft Learn — Write Your First C# Method](https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/)

---

## Navigation

- [Module 1 source](./modules/write-first-csharp-method/)
- [Repository overview](../../README.md)

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)

