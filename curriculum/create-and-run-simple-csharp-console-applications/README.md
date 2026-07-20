# Create and Run Simple C# Console Applications

![C#](https://img.shields.io/badge/C%23-Console_Applications-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Modules](https://img.shields.io/badge/Modules_Completed-4-16A34A)

This directory documents the second section of the
**Foundational C# with Microsoft Certification** curriculum delivered through
freeCodeCamp and Microsoft Learn.

The section focuses on creating, building, running, and progressively structuring
C# console applications with the .NET SDK and development tools.

[← Back to the repository overview](../../README.md)

[← Review the completed first section](../write-your-first-code-using-csharp/README.md)

---

## Section Status

```text
Section: Create and Run Simple C# Console Applications
Status: In progress
Completed modules: 4
Latest completed module: Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
Latest module assessment: Passed
Latest achievement: Earned
Latest module completion date: July 20, 2026
```

| No. | Module | Status |
| ---: | --- | --- |
| 1 | Install and Configure Visual Studio Code | Completed |
| 2 | Call Methods from the .NET Class Library Using C# | Completed |
| 3 | Add Decision Logic to Your Code Using `if`, `else`, and `else if` Statements in C# | Completed |
| 4 | Store and Iterate Through Sequences of Data Using Arrays and the `foreach` Statement in C# | Completed |

A module is marked `Completed` only after its Microsoft Learn units, assessment,
achievement, local run, project build, and full-solution build have all been
verified.

---

## Section Structure

```text
create-and-run-simple-csharp-console-applications/
├── README.md
├── modules/
│   ├── install-and-configure-visual-studio-code/
│   │   ├── Program.cs
│   │   └── install-and-configure-visual-studio-code.csproj
│   ├── call-methods/
│   │   ├── Program.cs
│   │   └── call-methods.csproj
│   ├── decision-logic/
│   │   ├── Program.cs
│   │   └── decision-logic.csproj
│   └── arrays-foreach/
│       ├── Program.cs
│       └── arrays-foreach.csproj
├── guided-projects/
└── trophy/
```

This section uses one central `README.md` for all module notes. Individual module
directories contain source code and project files without separate README files.

---

## Module 1 — Install and Configure Visual Studio Code

### Completion Status

```text
Status: Completed
Module assessment: Passed
Achievement: Earned
Completion date: July 17, 2026
```

The module introduces the development environment and the basic command-line
workflow used to create, build, and run C# console applications.

It does not introduce substantial new C# syntax. Its primary purpose is to
explain the software-development process, verify the development environment,
and establish the core .NET CLI workflow.

---

### Verified Development Environment

```text
Visual Studio Code: 1.129.0
.NET SDK: 10.0.302
Operating system: Windows
Primary repository IDE: Visual Studio
```

Visual Studio remains the primary IDE used to manage this repository and its
solution. Visual Studio Code is used in this module because the official
Microsoft Learn content specifically teaches the VS Code workflow.

---

### Software Development Process

Software development is more than writing source code. A typical development
process includes:

1. writing code;
2. compiling the application;
3. debugging errors;
4. testing expected behavior;
5. updating and versioning source files;
6. releasing or distributing the application.

A programming environment supports these activities by combining an editor,
terminal, build tools, debugging tools, extension support, and project
navigation.

---

### Visual Studio Code

Visual Studio Code is a lightweight, cross-platform source-code editor available
for:

- Windows;
- macOS;
- Linux.

It includes built-in support for JavaScript, TypeScript, and Node.js. Its
extension ecosystem provides support for additional languages and runtimes,
including:

- C#;
- C++;
- Java;
- Python;
- PHP;
- Go;
- .NET.

C# development support is provided through Microsoft extensions such as
**C# Dev Kit**.

---

### .NET SDK and .NET Runtime

The **.NET SDK** provides the tools required to:

- create projects;
- restore dependencies;
- compile source code;
- run applications;
- test applications;
- publish applications.

The **.NET Runtime** provides the environment required to execute compiled .NET
applications.

The SDK includes the runtime and the development tools. Installing only the
runtime is sufficient to run compatible applications, but it does not provide
the complete toolchain needed to create and build projects.

---

## Create a Console Application

A console application can be created in a specified directory with:

```powershell
dotnet new console -o ./CsharpProjects/TestProject
```

The command contains three main parts:

```text
Driver:     dotnet
Command:    new console
Arguments:  -o ./CsharpProjects/TestProject
```

The `-o` argument specifies the output directory.

Command arguments are optional parameters that provide additional information.
Running the command without an output argument creates the new project in the
current directory:

```powershell
dotnet new console
```

A newly generated console project normally contains:

```text
TestProject/
├── Program.cs
├── TestProject.csproj
└── obj/
```

`Program.cs` contains the C# source code.

`TestProject.csproj` contains project configuration such as:

- output type;
- target framework;
- implicit using directives;
- nullable-reference settings.

The CLI uses the output-directory name when generating the default `.csproj`
filename.

---

## Build a Console Application

Compile the current project with:

```powershell
dotnet build
```

The `dotnet build` command:

- restores dependencies when necessary;
- compiles C# source code;
- builds project dependencies;
- reports compiler warnings and errors;
- creates the application binaries.

Compiled .NET code is stored as Intermediate Language in assemblies that commonly
use the `.dll` extension.

For a Debug build targeting .NET 10, generated files are normally stored under:

```text
bin/Debug/net10.0/
```

Example assembly:

```text
TestProject.dll
```

The `bin/` and `obj/` directories are generated build artifacts and should not
be edited manually.

---

## Run a Console Application

Run the current project with:

```powershell
dotnet run
```

The `dotnet run` command provides a convenient development workflow because it:

1. checks whether the project needs to be built;
2. invokes the build process when required;
3. launches the compiled application;
4. displays console output.

It is useful for fast iterative development from the command line.

The basic workflow introduced by the module is:

```text
Create project → Edit source code → Build → Run → Review output
```

---

## Repository Project

The project created for this module is located at:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── install-and-configure-visual-studio-code/
        ├── Program.cs
        └── install-and-configure-visual-studio-code.csproj
```

The project was added to:

```text
freecodecamp-csharp.slnx
```

At the time this module was completed, the solution contained seven registered projects.

List the solution projects from the repository root:

```powershell
dotnet sln .\freecodecamp-csharp.slnx list
```

---

## Module Program

This module requires only a minimal C# program because its main learning outcome
is understanding the development environment and .NET CLI commands.

Recommended `Program.cs`:

```csharp
// Verifies that the .NET SDK and C# development environment
// are configured correctly.

Console.WriteLine("Hello C#!");
```

Expected output:

```text
Hello C#!
```

Run the project from the repository root:

```powershell
dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"
```

---

## Commands Learned

| Command | Purpose |
| --- | --- |
| `code --version` | Displays the installed Visual Studio Code version |
| `dotnet --version` | Displays the active .NET SDK version |
| `dotnet --list-sdks` | Lists all installed .NET SDK versions |
| `dotnet new console` | Creates a new console application |
| `dotnet build` | Restores and compiles the current project |
| `dotnet run` | Builds when necessary and runs the current project |
| `dotnet sln <solution> list` | Lists projects registered in a solution |
| `dotnet sln <solution> add <project>` | Adds a project to a solution |
| `dotnet restore` | Restores project and solution dependencies |

---

## Module Validation

Run these commands from the repository root.

Build the module project:

```powershell
dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"
```

Run the module project:

```powershell
dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"
```

Restore the full solution:

```powershell
dotnet restore .\freecodecamp-csharp.slnx
```

Build the full solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Required build result:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

A successful build must be confirmed in the terminal before the curriculum
changes are committed.

---

## Key Learning Outcomes

After completing this module, the following concepts are understood:

- software development is a multi-stage process;
- Visual Studio Code is a lightweight cross-platform editor;
- C# support in VS Code is provided through extensions;
- the .NET SDK is required to create and build C# applications;
- the .NET Runtime executes compiled .NET applications;
- `dotnet new console` creates a console project;
- `dotnet build` compiles source code and project dependencies;
- `dotnet run` builds when necessary and launches the application;
- `.csproj` files store project configuration;
- `Program.cs` stores the application source code;
- `bin/` and `obj/` contain generated build artifacts;
- projects can be registered in a `.slnx` solution.

---

## Completion Record

```text
Module: Install and Configure Visual Studio Code
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Created
Project added to solution: Yes
Completion date: July 17, 2026
```

---

## Module 2 — Call Methods from the .NET Class Library Using C#

### Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 18, 2026
```

The Microsoft Learn content, local project, solution registration, and
full-solution build have been verified for this module.

The official module introduces the .NET Class Library and explains how C#
applications call reusable methods supplied by .NET.

---

### Learning Objectives

After completing the module, the learner should be able to:

- locate useful classes and methods in the .NET Class Library;
- call methods by using the member-access and method-invocation operators;
- distinguish static methods from instance methods;
- create an object with the `new` operator;
- store and use method return values;
- distinguish parameters from arguments;
- call overloaded methods with different signatures;
- use IntelliSense and Microsoft Learn documentation to inspect methods;
- use `Math.Max()` to return the larger of two values.

---

### .NET Class Library

The **.NET Class Library** is a reusable collection of classes, methods, data
types, and supporting functionality supplied by .NET.

A class groups related members. For example, the `Console` class provides
methods for console input and output:

```csharp
Console.WriteLine("Hello, C#!");
```

The statement contains:

```text
Console        Class name
.              Member-access operator
WriteLine      Method name
(...)          Method-invocation operator
"Hello, C#!"   Argument
```

The library prevents developers from having to implement common functionality
from scratch.

---

### Static and Instance Methods

A **static method** belongs to its class and can be called directly through the
class name:

```csharp
Console.WriteLine("Static method call");
```

An **instance method** is called through an object created from a class:

```csharp
Random dice = new();
int roll = dice.Next(1, 7);
```

In this example:

- `Random` is the class;
- `dice` is an object, or instance, of `Random`;
- `new()` creates the instance;
- `Next(1, 7)` is an instance-method call;
- the returned integer is stored in `roll`.

The terms **stateless** and **stateful** are used in the module to explain why
some methods are called through a class and others through an object. In normal
C# terminology, the key distinction is between static and instance members.

---

### Return Values and `void`

A method may return a value:

```csharp
int roll = dice.Next(1, 7);
```

The returned value can also be used directly:

```csharp
Console.WriteLine(dice.Next(1, 7));
```

Some methods return no value. Their return type is `void`.

```csharp
Console.Clear();
```

A return value should normally be stored or consumed when it is meaningful to
the program.

---

### Parameters and Arguments

A **parameter** is a variable declared by the method definition.

An **argument** is the concrete value supplied by the caller.

```csharp
int roll = dice.Next(1, 7);
```

For the selected `Random.Next(int minValue, int maxValue)` overload:

- `minValue` and `maxValue` are parameters;
- `1` and `7` are arguments;
- the minimum value is inclusive;
- the maximum value is exclusive.

Therefore, `Next(1, 7)` can produce the integers `1` through `6`.

---

### Method Overloads

An overloaded method has multiple valid signatures. Each overload differs by
the number or types of its parameters.

Examples of `Random.Next()` overloads:

```csharp
int anyNonNegativeInteger = dice.Next();
int belowOneHundredOne = dice.Next(101);
int betweenFiftyAndOneHundred = dice.Next(50, 101);
```

Examples of `Console.WriteLine()` overloads:

```csharp
Console.WriteLine();
Console.WriteLine(7);
Console.WriteLine("seven");
```

IntelliSense displays available overloads, parameter types, and return types
while code is being written.

---

### Challenge — `Math.Max()`

The module challenge requires finding and calling a method that returns the
larger of two numbers.

```csharp
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
```

Expected output:

```text
600
```

`Math.Max()` is a static method, so no `Math` object needs to be created.

---

### Repository Project

The project for this module uses the shorter directory and project names while
the official module title remains fully documented here:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── call-methods/
        ├── Program.cs
        └── call-methods.csproj
```

The project must be registered in:

```text
freecodecamp-csharp.slnx
```

The project is registered in the solution. At the time this module was completed,
the solution contained eight registered projects.

---

### Module Program

The program contains focused executable examples rather than copying the lesson
as hundreds of comment lines. It demonstrates:

1. a static method call;
2. creation of a `Random` instance;
3. an instance method with a return value;
4. parameters and arguments;
5. overloaded methods;
6. direct use of a return value;
7. the `Math.Max()` challenge.

Because random-number output changes on each run, only the fixed labels and
numeric ranges are deterministic.

Possible output:

```text
=== Static and instance methods ===
A six-sided die roll: 4

=== Method overloads ===
Next(): 342585470
Next(101): 43
Next(50, 101): 89

=== Directly use a return value ===
Another six-sided die roll: 2

=== Math.Max challenge ===
The larger value between 500 and 600 is 600.
```

The random values will vary, but:

- each six-sided die roll must be between `1` and `6`;
- `Next(101)` must be between `0` and `100`;
- `Next(50, 101)` must be between `50` and `100`;
- the larger challenge value must be `600`.

---

### Build and Run Commands

Run the module project from the repository root:

```powershell
dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\call-methods\call-methods.csproj"
```

Build the module project:

```powershell
dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\call-methods\call-methods.csproj"
```

List all solution projects:

```powershell
dotnet sln .\freecodecamp-csharp.slnx list
```

Restore and build the complete solution:

```powershell
dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx
```

The module can be marked `Completed` only after the terminal confirms:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

---

### Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| method | `/ˈmeθ.əd/` | “me-thợd” | phương thức |
| class library | `/klɑːs ˈlaɪ.brər.i/` | “class lai-brờ-ri” | thư viện lớp |
| instance | `/ˈɪn.stəns/` | “in-stầns” | thể hiện/đối tượng được tạo từ lớp |
| static | `/ˈstæt.ɪk/` | “sta-tịch” | thành viên thuộc về lớp |
| parameter | `/pəˈræm.ɪ.tər/` | “pờ-ra-mi-tờ” | biến trong định nghĩa phương thức |
| argument | `/ˈɑːɡ.jə.mənt/` | “a-giu-mần(t)” | giá trị truyền vào khi gọi phương thức |
| return value | `/rɪˈtɜːn ˌvæl.juː/` | “ri-tơn va-liu” | giá trị trả về |
| overload | `/ˈəʊ.və.ləʊd/` | “âu-vờ-lâuđ” | nhiều chữ ký gọi cho cùng tên phương thức |
| IntelliSense | `/ɪnˈtel.ɪ.sens/` | “in-te-li-sens” | hỗ trợ gợi ý và phân tích mã |

---

### Knowledge Introduced

This module introduces:

- the .NET Class Library;
- classes, objects, and methods;
- static and instance method calls;
- the `new` operator;
- return values and `void`;
- parameters and arguments;
- method overloads;
- IntelliSense;
- documentation lookup;
- `Random.Next()`;
- `Math.Max()`.

The following topics are intentionally deferred to later modules:

- defining custom methods;
- defining custom classes;
- constructor design;
- fields and properties;
- dependency injection;
- automated unit testing;
- cryptographically secure random-number generation.

---

### Completion Record

```text
Module: Call Methods from the .NET Class Library Using C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 18, 2026
```

---

## Module 3 — Add Decision Logic to Your Code Using `if`, `else`, and `else if` Statements in C#

### Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 9
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 19, 2026
```

The official units, assessment, achievement, local project, solution
registration, project run, and complete solution build have all been verified.

---


### Official Module Structure

The module contains seven units:

1. Introduction
2. Exercise — Create decision logic with `if` statements
3. Exercise — Create nested decision logic with `if`, `else if`, and `else`
4. Exercise — Complete a challenge activity to apply business rules
5. Review the solution to the apply business rules challenge activity
6. Module assessment
7. Summary

The module teaches how to branch a program's execution path by evaluating
Boolean expressions.

---

### Learning Objectives

After completing the module, the learner should be able to:

- evaluate conditions with `if`, `else if`, and `else`;
- build Boolean expressions that return `true` or `false`;
- compare values with equality and relational operators;
- combine Boolean expressions with logical operators;
- create mutually exclusive execution branches;
- nest one code block inside another;
- order conditions according to business-rule precedence;
- prevent multiple rewards or messages from being applied incorrectly.

---

### Decision Logic and Branches

Decision logic allows a program to choose which statements should execute.
Alternative execution paths are commonly called **branches**.

```csharp
if (total >= 15)
{
    Console.WriteLine("You win!");
}
```

An `if` statement contains:

```text
if                  Decision keyword
(total >= 15)       Boolean expression
{ ... }             Code block
```

The code block executes only when the Boolean expression evaluates to `true`.

---

### Boolean Expressions

A Boolean expression produces either `true` or `false`.

```csharp
string message = "The quick brown fox jumps over the lazy dog.";
bool containsDog = message.Contains("dog");

Console.WriteLine(containsDog);
```

A method that returns `bool` can be used directly as a condition:

```csharp
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
```

---

### Comparison Operators

| Operator | Meaning | Example |
| --- | --- | --- |
| `==` | equal to | `roll1 == roll2` |
| `!=` | not equal to | `score != 0` |
| `>` | greater than | `total > 14` |
| `<` | less than | `total < 15` |
| `>=` | greater than or equal to | `total >= 15` |
| `<=` | less than or equal to | `daysUntilExpiration <= 5` |

`==` tests equality. A single `=` performs assignment.

---

### Logical Operators

The logical OR operator, `||`, returns `true` when at least one condition is
true:

```csharp
bool hasDoubles =
    roll1 == roll2 ||
    roll2 == roll3 ||
    roll1 == roll3;
```

The logical AND operator, `&&`, returns `true` only when both conditions are
true:

```csharp
bool hasTriples =
    roll1 == roll2 &&
    roll2 == roll3;
```

---

### Code Blocks and Nesting

A code block is enclosed by braces:

```csharp
{
    // Statements belonging to one unit of execution.
}
```

A block can contain another block:

```csharp
if (hasDoubles)
{
    if (hasTriples)
    {
        Console.WriteLine("You rolled triples!");
    }
}
```

This is called nested decision logic. Nesting is useful when an inner decision
should be evaluated only after an outer condition succeeds.

---

### Dice Game

The exercise generates three six-sided dice:

```csharp
Random random = new();

int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int roll3 = random.Next(1, 7);

int total = roll1 + roll2 + roll3;
```

`Random.Next(1, 7)` can return `1` through `6` because the minimum is inclusive
and the maximum is exclusive.

The bonus rules are:

- doubles add two points;
- triples add six points;
- doubles and triples bonuses must not stack.

The final repository code evaluates triples before doubles:

```csharp
if (hasTriples)
{
    total += 6;
}
else if (hasDoubles)
{
    total += 2;
}
```

Every triple also satisfies the doubles condition. An `if`/`else if` chain makes
the two bonus branches mutually exclusive.

---

### `if`, `else if`, and `else`

Two opposite outcomes can be represented by `if` and `else`:

```csharp
if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}
```

Multiple mutually exclusive outcomes use an `if`/`else if`/`else` chain:

```csharp
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
```

Conditions are checked from top to bottom. Only the first matching branch runs,
so condition order directly affects program behavior.

---

### Subscription-Renewal Challenge

The challenge begins with:

```csharp
int daysUntilExpiration = random.Next(12);
```

Possible values are `0` through `11`.

The business-rule precedence is:

1. `0`: subscription expired;
2. `1`: urgent message and 20% discount;
3. `2–5`: expiration message and 10% discount;
4. `6–10`: general renewal reminder;
5. `11`: display no subscription message.

The conditions must be ordered from the most specific and highest-priority rule
to the broadest rule:

```csharp
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine(
        $"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine("Renew now and save 10%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine(
        "Your subscription will expire soon. Renew now!");
}
```

There is intentionally no final `else`. When the value is `11`, the challenge
requires no subscription message.

---

### Repository Project

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── decision-logic/
        ├── Program.cs
        └── decision-logic.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

The solution listing confirms nine registered projects.

---

### Module Program

The final `Program.cs` consolidates the completed exercises into two focused
examples:

1. a dice game demonstrating Boolean expressions, logical operators, bonus
   precedence, and mutually exclusive prize branches;
2. a subscription-renewal challenge demonstrating ordered business rules and
   one-message-only behavior.

Intermediate versions are documented conceptually rather than retained as
duplicate executable code.

---

### Possible Output

Random values change between runs.

```text
=== Dice game ===
Dice roll: 4 + 4 + 2 = 10
You rolled doubles! +2 bonus to total!
Your total including the bonus: 12
You win a new laptop!

Your subscription expires in 4 days.
Renew now and save 10%!
```

Valid runs may also produce a triples bonus, another prize, an expired
subscription, a 20% discount, a general reminder, or no subscription message.

---

### Build and Run Commands

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\decision-logic\decision-logic.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\decision-logic\decision-logic.csproj"
```

List solution projects:

```powershell
dotnet sln .\freecodecamp-csharp.slnx list
```

Restore and build the full solution:

```powershell
dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx
```

Required result:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

---

### Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| decision logic | `/dɪˈsɪʒ.ən ˈlɒdʒ.ɪk/` | “đi-si-zhần lo-jịch” | logic ra quyết định |
| branch | `/brɑːntʃ/` | “branch” | nhánh thực thi |
| Boolean expression | `/ˈbuː.li.ən ɪkˈspreʃ.ən/` | “bu-li-ần ịch-spre-shần” | biểu thức trả về `true` hoặc `false` |
| condition | `/kənˈdɪʃ.ən/` | “cần-đi-shần” | điều kiện |
| code block | `/kəʊd blɒk/` | “câud block” | khối lệnh |
| nested | `/ˈnes.tɪd/` | “nes-tịt” | được lồng bên trong |
| logical operator | `/ˈlɒdʒ.ɪ.kəl ˈɒp.ər.eɪ.tər/` | “lo-ji-cồ o-pờ-rây-tờ” | toán tử logic |
| precedence | `/ˈpres.ɪ.dəns/` | “pre-si-đầns” | thứ tự ưu tiên |
| mutually exclusive | `/ˌmjuː.tʃu.ə.li ɪkˈskluː.sɪv/` | “miu-chu-ờ-li ịch-sclu-siv” | loại trừ lẫn nhau |

---

### Knowledge Introduced

This module introduces:

- decision logic and code branches;
- Boolean expressions;
- comparison operators;
- logical `AND` and logical `OR`;
- `if`, `else if`, and `else`;
- nested code blocks;
- mutually exclusive branches;
- condition ordering;
- business-rule precedence;
- prevention of logic defects.

The following topics are deferred:

- `switch` statements and switch expressions;
- the conditional operator `?:`;
- pattern matching;
- guard clauses in custom methods;
- automated branch-coverage testing;
- domain-specific rule engines.

---

### Completion Record

```text
Module: Add Decision Logic to Your Code Using if, else, and else if Statements in C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 9
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 19, 2026
```

---

## Module 4 — Store and Iterate Through Sequences of Data Using Arrays and the `foreach` Statement in C#

### Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 10
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 20, 2026
```

The official Microsoft Learn units, assessment, achievement, local project,
solution registration, project run, and complete solution build have all been
verified.

---

### Official Module Structure

The module contains seven units:

1. Introduction
2. Exercise — Get started with array basics
3. Exercise — Implement the `foreach` statement
4. Exercise — Complete a challenge activity for nested iteration and selection statements
5. Review the solution for the nested iteration and selection statements challenge activity
6. Module assessment
7. Summary

The module focuses on storing related values in arrays and processing every
element with `foreach`.

---

### Learning Objectives

After completing the module, the learner should be able to:

- create and initialize an array;
- store multiple related values of one data type;
- assign values to individual array elements;
- retrieve values by index;
- explain zero-based indexing;
- reassign an existing array element;
- use the `Length` property;
- iterate through an array with `foreach`;
- maintain a running total while iterating;
- combine `foreach` with an `if` statement;
- use `String.StartsWith()` to select matching strings.

---

### Arrays

An **array** stores multiple values of the same data type under one variable
name.

```csharp
string[] fraudulentOrderIds = ["A123", "B456", "C789"];
```

In this declaration:

```text
string      Element data type
[]          Array type indicator
fraudulentOrderIds
            Array variable name
[ ... ]     Collection expression used to initialize the array
```

The project uses collection-expression syntax supported by the repository's
current C# and .NET configuration.

An older array-initialization form is also valid:

```csharp
string[] fraudulentOrderIds = { "A123", "B456", "C789" };
```

The repository program uses one consistent modern syntax rather than retaining
multiple executable versions of the same exercise.

---

### Zero-Based Indexing

Array indexes begin at zero.

```csharp
Console.WriteLine(fraudulentOrderIds[0]);
Console.WriteLine(fraudulentOrderIds[1]);
Console.WriteLine(fraudulentOrderIds[2]);
```

The relationship between position and index is:

```text
First element   → index 0
Second element  → index 1
Third element   → index 2
```

For an array containing three elements, valid indexes are `0`, `1`, and `2`.

Attempting to access index `3` would cause an
`IndexOutOfRangeException` at runtime:

```csharp
// fraudulentOrderIds[3] = "D000";
```

The invalid statement is documented but intentionally not executed.

---

### Reading and Reassigning Array Elements

An array element can be read like an individual variable:

```csharp
Console.WriteLine($"First: {fraudulentOrderIds[0]}");
```

An existing element can also be reassigned:

```csharp
fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassigned first: {fraudulentOrderIds[0]}");
```

The replacement value must be compatible with the array's element type.

---

### The `Length` Property

The `Length` property reports the total number of elements in an array:

```csharp
Console.WriteLine(
    $"There are {fraudulentOrderIds.Length} fraudulent orders to process.");
```

For the example array:

```text
Length: 3
Last valid index: 2
```

`Length` is a count and is therefore not zero-based.

---

### The `foreach` Statement

The `foreach` statement processes every element in a sequence.

```csharp
string[] names = ["Rowena", "Robin", "Bao"];

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

The statement contains:

```text
foreach     Iteration keyword
string      Type of the current element
name        Temporary iteration variable
in          Separates the variable from the sequence
names       Array being traversed
{ ... }     Code executed once for each element
```

For an array, `foreach` processes elements in increasing index order, beginning
with index `0` and ending with index `Length - 1`.

---

### Inventory Running Total

The inventory exercise stores finished-product counts for five bins:

```csharp
int[] inventory = [200, 450, 700, 175, 250];
```

Variables that must retain values between iterations are declared before the
loop:

```csharp
int sum = 0;
int bin = 0;
```

The loop updates the running total and reports each bin:

```csharp
foreach (int items in inventory)
{
    sum += items;
    bin++;

    Console.WriteLine(
        $"Bin {bin} = {items} items (Running total: {sum})");
}
```

The final total is displayed after iteration finishes:

```csharp
Console.WriteLine($"We have {sum} items in inventory.");
```

Expected inventory total:

```text
1775
```

---

### Nested Iteration and Selection Challenge

The challenge stores order IDs in an array:

```csharp
string[] orderIds =
[
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
];
```

The application must report only IDs that begin with the letter `B`.

```csharp
foreach (string orderId in orderIds)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine(orderId);
    }
}
```

This combines two control-flow concepts:

```text
foreach   Iterates through every order ID
if        Selects only values satisfying the condition
```

`StartsWith("B")` returns a Boolean value:

```text
true      The order ID begins with B
false     The order ID does not begin with B
```

Expected challenge output:

```text
B123
B177
B179
```

---

### Repository Project

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── arrays-foreach/
        ├── Program.cs
        └── arrays-foreach.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

The solution listing confirms ten registered projects.

---

### Module Program

The final `Program.cs` consolidates the completed exercises into three focused
sections:

1. array declaration, initialization, indexing, reassignment, and `Length`;
2. inventory iteration with a bin counter and running total;
3. order-ID filtering with `foreach`, `if`, and `StartsWith()`.

The source retains explanatory comments but excludes duplicate intermediate
versions that would cause repeated declarations or compilation errors.

---

### Verified Output

```text
=== Array basics ===
First: A123
Second: B456
Third: C789
Reassigned first: F000
There are 3 fraudulent orders to process.

=== Inventory report with foreach ===
Bin 1 = 200 items (Running total: 200)
Bin 2 = 450 items (Running total: 650)
Bin 3 = 700 items (Running total: 1350)
Bin 4 = 175 items (Running total: 1525)
Bin 5 = 250 items (Running total: 1775)
We have 1775 items in inventory.

=== Orders requiring investigation ===
B123
B177
B179
```

The terminal output confirms that indexing, reassignment, iteration, accumulation,
and order filtering behave as intended.

---

### Build and Run Commands

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\arrays-foreach\arrays-foreach.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\arrays-foreach\arrays-foreach.csproj"
```

List all registered projects:

```powershell
dotnet sln .\freecodecamp-csharp.slnx list
```

Restore and build the complete solution:

```powershell
dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx
```

Verified result:

```text
Build succeeded.
```

The supplied terminal output shows that all ten projects compiled successfully,
including `arrays-foreach`.

---

### Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| array | `/əˈreɪ/` | “ờ-rây” | mảng |
| sequence | `/ˈsiː.kwəns/` | “si-quầns” | chuỗi hoặc trình tự dữ liệu |
| element | `/ˈel.ɪ.mənt/` | “e-li-mần(t)” | phần tử |
| index | `/ˈɪn.deks/` | “in-đeks” | chỉ số |
| zero-based | `/ˈzɪə.rəʊ beɪst/` | “zi-râu bâyst” | bắt đầu từ số 0 |
| iterate | `/ˈɪt.ə.reɪt/` | “i-tờ-râyt” | duyệt lặp |
| iteration | `/ˌɪt.əˈreɪ.ʃən/` | “i-tờ-rây-shần” | một quá trình hoặc lần lặp |
| `foreach` statement | `/ˌfɔːr ˈiːtʃ ˈsteɪt.mənt/` | “pho-r ích stâyt-mần(t)” | câu lệnh duyệt từng phần tử |
| running total | `/ˌrʌn.ɪŋ ˈtəʊ.təl/` | “rân-ning tââu-tồ” | tổng tích lũy |
| out of range | `/ˌaʊt əv ˈreɪndʒ/` | “ao-tờv râynj” | nằm ngoài phạm vi hợp lệ |

---

### Knowledge Introduced

This module introduces:

- one-dimensional arrays;
- array declaration and initialization;
- collection expressions;
- zero-based indexes;
- element retrieval and reassignment;
- the `Length` property;
- `foreach` iteration;
- temporary iteration variables;
- running totals;
- external loop counters;
- nested iteration and selection;
- `String.StartsWith()`.

The following topics are intentionally deferred:

- `for` and `while` loops;
- modifying a collection during enumeration;
- multidimensional and jagged arrays;
- `List<T>` and other generic collections;
- array sorting and reversing methods;
- LINQ;
- custom collection types;
- performance analysis of collection traversal.

---

### Completion Record

```text
Module: Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 10
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 20, 2026
```

---

## Next Step

Proceed to the next official module in
**Create and Run Simple C# Console Applications** while preserving the existing
repository structure, keeping the solution green, and updating this section
README continuously.


---

## Navigation

- [Repository overview](../../README.md)
- [Previous section — Write Your First Code Using C#](../write-your-first-code-using-csharp/README.md)
- [C# review notes](../../CSHARP_REVIEW.md)