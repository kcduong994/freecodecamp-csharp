# Create and Run Simple C# Console Applications

![C#](https://img.shields.io/badge/C%23-Console_Applications-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Modules](https://img.shields.io/badge/Modules_Completed-1-16A34A)

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
Latest completed module: Install and Configure Visual Studio Code
Latest module assessment: Passed
Latest achievement: Earned
Latest module completion date: July 17, 2026
```

| No. | Module | Status |
| ---: | --- | --- |
| 1 | Install and Configure Visual Studio Code | Completed |

Additional modules will be added to this table as study continues.

---

## Section Structure

```text
create-and-run-simple-csharp-console-applications/
├── README.md
├── modules/
│   └── install-and-configure-visual-studio-code/
│       ├── Program.cs
│       └── install-and-configure-visual-studio-code.csproj
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

## Navigation

- [Repository overview](../../README.md)
- [Previous section — Write Your First Code Using C#](../write-your-first-code-using-csharp/README.md)
- [C# review notes](../../CSHARP_REVIEW.md)

---

## Next Step

The section remains in progress. The next official module will be added after it
is started on freeCodeCamp and Microsoft Learn.