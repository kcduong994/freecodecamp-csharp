# Create and Run Simple C# Console Applications

![C#](https://img.shields.io/badge/C%23-Console_Applications-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Modules](https://img.shields.io/badge/Modules_Completed-1-16A34A)
![Pending](https://img.shields.io/badge/Local_Verification-1-F59E0B)

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
Completed modules: 1
Modules awaiting local verification: 1
Latest Microsoft Learn module: Call Methods from the .NET Class Library Using C#
Latest module assessment: Passed
Latest achievement: Earned
Latest Microsoft Learn completion date: July 18, 2026
```

| No. | Module | Status |
| ---: | --- | --- |
| 1 | Install and Configure Visual Studio Code | Completed |
| 2 | Call Methods from the .NET Class Library Using C# | Microsoft Learn completed; local verification pending |

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
│   └── call-methods/
│       ├── Program.cs
│       └── call-methods.csproj
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

The solution now contains seven registered projects.

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
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Microsoft Learn completion date: July 18, 2026
Local project run: Pending verification
Project build: Pending verification
Full solution build: Pending verification
Repository status: Not yet marked Completed
```

The Microsoft Learn content and assessment for this module have been completed.
The repository record remains pending until the local project and the complete
solution produce verified terminal output.

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

The project is registered in the solution, and the solution listing confirms
eight projects.

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
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Created
Project added to solution: Verified
Local run: Pending verification
Module build: Pending verification
Full solution build: Pending verification
Microsoft Learn completion date: July 18, 2026
```

Once local verification succeeds, update this record, the section-status block,
the module table, and the completed-module badge before committing.

---

## Next Step

Verify the new project locally, register it in the solution when necessary, and
build the complete solution. The next official curriculum module should not be
started until the current repository state is green.


---

## Navigation

- [Repository overview](../../README.md)
- [Previous section — Write Your First Code Using C#](../write-your-first-code-using-csharp/README.md)
- [C# review notes](../../CSHARP_REVIEW.md)