# freeCodeCamp C# Learning Repository

![C#](https://img.shields.io/badge/C%23-Learning-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-Foundational-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Curriculum-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)

This repository documents my progress through the
**Foundational C# with Microsoft Certification**
curriculum on freeCodeCamp and Microsoft Learn.

It contains guided exercises, console applications, certification work, and
independently written study notes created while learning C# and the .NET platform.

---

## Development Environment

- Visual Studio
- C#
- .NET
- Git
- GitHub

---

## Repository Structure

```text
freecodecamp-csharp/
├── workshops/
│   └── write-your-first-c-sharp-code/
│       ├── Program.cs
│       └── write-your-first-c-sharp-code.csproj
├── labs/
├── certification-projects/
├── CSHARP_REVIEW.md
├── freecodecamp-csharp.slnx
├── .gitignore
└── README.md
```

---

## Current Module

### Write Your First C# Code

This introductory module demonstrates how a C# console application writes text
to the terminal.

It focuses on the difference between:

- `Console.WriteLine()`, which prints content and then moves the cursor to a new line;
- `Console.Write()`, which prints content without automatically moving the cursor to a new line.

Current implementation:

```csharp
// Program.cs
// Module: Write Your First C# Code
//
// Purpose:
// Demonstrate the difference between Console.WriteLine() and Console.Write()
// in a simple C# console application.
//
// Learning points:
// - Console.WriteLine() prints text and then moves the cursor to a new line.
// - Console.Write() prints text without automatically starting a new line.
// - Text enclosed in double quotation marks is a string literal.
// - Each C# statement ends with a semicolon.
//
// Console belongs to the System namespace.
// Modern .NET console project templates enable implicit global usings,
// so an explicit "using System;" directive is not required here.

// Print the first sentence and move the cursor to the next line.
Console.WriteLine("This is the first line.");

// Print the second sentence in three separate parts.
//
// Console.Write() keeps the cursor on the same line after each call.
// The spaces at the ends of the first two string literals prevent the
// words from being joined together.
Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");
```

Expected output:

```text
This is the first line.
This is the second line.
```

### Concepts Introduced

- C# console applications
- top-level statements
- `Console.WriteLine()`
- `Console.Write()`
- string literals
- method calls
- semicolons
- whitespace inside string literals
- compiling and running a .NET project
- Visual Studio solutions and projects
- `.slnx` solution files
- `.csproj` project files
- implicit global using directives

---

## Learning Workflow

The curriculum is completed across two learning platforms:

1. Open the current challenge on freeCodeCamp.
2. Follow its link to the corresponding Microsoft Learn module.
3. Complete all units and the module assessment on Microsoft Learn.
4. Return to freeCodeCamp.
5. Confirm completion and answer the checkpoint question.
6. Continue to the next module.

The repository stores selected code exercises and projects produced during this
learning process.

---

## Learning Objectives

- Learn foundational C# syntax
- Understand static typing
- Work with variables and data types
- Use operators and expressions
- Format strings and console output
- Write conditional logic
- Use loops
- Work with arrays and collections
- Create reusable methods
- Handle exceptions
- Debug applications in Visual Studio
- Understand classes and objects
- Learn encapsulation
- Learn inheritance and polymorphism
- Work with interfaces and generics
- Understand the structure of .NET solutions and projects
- Complete the freeCodeCamp certification requirements

---

## Repository Organization

### Workshops

The `workshops` directory contains guided modules, code-along exercises, and
small console applications based on the curriculum.

### Labs

The `labs` directory is reserved for independent coding exercises completed from
requirements or problem descriptions.

### Certification Projects

The `certification-projects` directory is reserved for larger projects or final
assessment work associated with the certification.

### Review Notes

The [`CSHARP_REVIEW.md`](CSHARP_REVIEW.md) file contains independently written
notes covering the concepts learned throughout the curriculum.

---

## Curriculum

Foundational C# with Microsoft Certification:

https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/

Microsoft Learn C# training:

https://learn.microsoft.com/training/paths/get-started-c-sharp-part-1/

---

## Progress

| Category | Completed | Status |
| --- | ---: | --- |
| Curriculum modules | 1 | In progress |
| Labs | 0 | Not started |
| Certification projects | 0 | Not started |

---

## Current Project

### `write-your-first-c-sharp-code`

Location:

```text
workshops/write-your-first-c-sharp-code/
```

Primary source file:

```text
workshops/write-your-first-c-sharp-code/Program.cs
```

Build status:

```text
Build succeeded
0 failed
```

---

## Author

**Duong Kim Cuong**

GitHub: https://github.com/kcduong994