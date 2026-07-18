# freeCodeCamp C# Learning Repository

![C#](https://img.shields.io/badge/C%23-Learning-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Curriculum-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Sections](https://img.shields.io/badge/Sections_Completed-1%2F7-16A34A)
![Projects](https://img.shields.io/badge/Solution_Projects-8-2563EB)

This repository documents my progress through the
**Foundational C# with Microsoft Certification** curriculum delivered through
freeCodeCamp and Microsoft Learn.

It is maintained as a structured learning curriculum containing:

- Microsoft Learn modules;
- C# console applications;
- guided projects;
- section Trophy evidence;
- independently written technical notes;
- buildable source code;
- progress and completion records.

---

## Current Progress

```text
Certification status: In progress
Curriculum sections completed: 1 / 7
Current section: Create and Run Simple C# Console Applications
Current section status: In progress
Completed modules in current section: 2
Latest completed module: Call Methods from the .NET Class Library Using C#
Latest module status: Completed
Latest module assessment: Passed
Latest achievement: Earned
Latest module completion date: July 18, 2026
Completed section: Write Your First Code Using C#
Projects currently verified in solution: 8
```

| No. | Curriculum section | Progress | Status |
| ---: | --- | --- | --- |
| 1 | Write Your First Code Using C# | 7 / 7 | Completed |
| 2 | Create and Run Simple C# Console Applications | 2 modules completed | In progress |
| 3 | Add Logic to C# Console Applications | Not started | Pending |
| 4 | Work with Variable Data in C# Console Applications | Not started | Pending |
| 5 | Create Methods in C# Console Applications | Not started | Pending |
| 6 | Debug C# Console Applications | Not started | Pending |
| 7 | Foundational C# with Microsoft Certification Exam | Not started | Pending |

A module is marked `Completed` in this repository only after its official units,
assessment, achievement, local run, project registration, and solution build have
all been verified.

---

## Completed Section

### 1. Write Your First Code Using C#

```text
Status: Completed
Progress: 7 / 7
Instructional modules: 4
Guided projects: 2
Trophy: Verified
Completion date: July 17, 2026
```

This section covers:

- basic C# syntax;
- console output;
- literals and variables;
- foundational data types;
- string formatting;
- arithmetic operators;
- integer and decimal division;
- explicit casting;
- compound assignment;
- student-grade calculations;
- weighted GPA calculations;
- formatted console reports.

[Open the complete section documentation](./curriculum/write-your-first-code-using-csharp/README.md)

[View Trophy achievement and verification evidence](./curriculum/write-your-first-code-using-csharp/trophy/README.md)

---

## Current Section

### 2. Create and Run Simple C# Console Applications

```text
Status: In progress
Completed modules: 2
Latest completed module: Call Methods from the .NET Class Library Using C#
Latest module status: Completed
Module assessment: Passed
Achievement: Earned
Completion date: July 18, 2026
```

[Open the current section documentation](./curriculum/create-and-run-simple-csharp-console-applications/README.md)

### Module 1 — Install and Configure Visual Studio Code

```text
Status: Completed
Module assessment: Passed
Achievement: Earned
Completion date: July 17, 2026
```

This module focuses on the development environment and the basic .NET CLI
workflow rather than introducing substantial new C# syntax.

Learning outcomes include:

- understanding the role of a programming environment;
- verifying Visual Studio Code;
- verifying the installed .NET SDK;
- understanding the difference between the .NET SDK and .NET Runtime;
- creating a console application with the .NET CLI;
- building a C# project;
- running a C# project;
- understanding the generated `Program.cs` and `.csproj` files;
- understanding where compiled binaries are created;
- adding a project to a solution.

Key commands introduced:

| Command | Purpose |
| --- | --- |
| `code --version` | Displays the installed Visual Studio Code version |
| `dotnet --version` | Displays the active .NET SDK version |
| `dotnet --list-sdks` | Lists installed .NET SDK versions |
| `dotnet new console` | Creates a new console application |
| `dotnet build` | Restores and compiles a project |
| `dotnet run` | Builds when necessary and runs a project |
| `dotnet sln list` | Lists projects registered in a solution |
| `dotnet sln add` | Adds a project to a solution |

Verified local environment:

```text
Visual Studio Code: 1.129.0
.NET SDK: 10.0.302
Operating system: Windows
Primary repository IDE: Visual Studio
```

Project:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── install-and-configure-visual-studio-code/
        ├── Program.cs
        └── install-and-configure-visual-studio-code.csproj
```

---

### Module 2 — Call Methods from the .NET Class Library Using C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 18, 2026
```

This module introduces reusable functionality from the .NET Class Library and
explains how C# applications call methods supplied by .NET.

Learning outcomes include:

- understanding the purpose of the .NET Class Library;
- calling static methods;
- creating objects and calling instance methods;
- using the `new` operator;
- working with return values;
- distinguishing parameters from arguments;
- using overloaded methods;
- inspecting methods with IntelliSense;
- consulting Microsoft Learn documentation;
- using `Random.Next()`;
- completing the `Math.Max()` challenge.

Project location:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── call-methods/
        ├── Program.cs
        └── call-methods.csproj
```

The shorter project and directory name are used for repository convenience. The
official Microsoft Learn module title remains fully documented in the section
README.

The project runs locally, is registered in the solution, and has been verified
through the full-solution build.

---

## Repository Structure

```text
freecodecamp-csharp/
├── curriculum/
│   ├── write-your-first-code-using-csharp/
│   │   ├── README.md
│   │   ├── modules/
│   │   ├── guided-projects/
│   │   └── trophy/
│   │       ├── README.md
│   │       └── assets/
│   ├── create-and-run-simple-csharp-console-applications/
│   │   ├── README.md
│   │   ├── modules/
│   │   │   ├── install-and-configure-visual-studio-code/
│   │   │   │   ├── Program.cs
│   │   │   │   └── install-and-configure-visual-studio-code.csproj
│   │   │   └── call-methods/
│   │   │       ├── Program.cs
│   │   │       └── call-methods.csproj
│   │   ├── guided-projects/
│   │   └── trophy/
│   ├── add-logic-to-csharp-console-applications/
│   ├── work-with-variable-data-in-csharp-console-applications/
│   ├── create-methods-in-csharp-console-applications/
│   ├── debug-csharp-console-applications/
│   └── foundational-csharp-with-microsoft-certification-exam/
├── CSHARP_REVIEW.md
├── freecodecamp-csharp.slnx
├── .gitignore
└── README.md
```

Each curriculum section may contain:

- `README.md` for section-level curriculum documentation;
- `modules/` for Microsoft Learn instructional projects;
- `guided-projects/` for applied projects;
- `trophy/` for completion evidence;
- project-specific source files and notes.

---

## Development Environment

- Visual Studio
- Visual Studio Code
- C#
- .NET 10
- Windows
- Developer PowerShell
- Git
- GitHub

Visual Studio is the primary repository IDE. Visual Studio Code is also used
when a Microsoft Learn module specifically teaches the VS Code workflow.

---

## Solution

Solution file:

```text
freecodecamp-csharp.slnx
```

Projects currently verified as registered:

```text
8
```

List all projects registered in the solution:

```powershell
dotnet sln .\freecodecamp-csharp.slnx list
```

Restore dependencies:

```powershell
dotnet restore .\freecodecamp-csharp.slnx
```

Build all projects:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Expected result:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

The full solution must build successfully before curriculum changes are
committed.

---

## Solution Projects

### Completed projects from Section 1

The completed first section contributes six executable projects:

```text
curriculum/write-your-first-code-using-csharp/modules/first-csharp-code/first-csharp-code.csproj

curriculum/write-your-first-code-using-csharp/modules/literals-and-variables/literals-and-variables.csproj

curriculum/write-your-first-code-using-csharp/modules/string-formatting/string-formatting.csproj

curriculum/write-your-first-code-using-csharp/modules/number-operations/number-operations.csproj

curriculum/write-your-first-code-using-csharp/guided-projects/calculate-student-grades/calculate-student-grades.csproj

curriculum/write-your-first-code-using-csharp/guided-projects/calculate-final-gpa/calculate-final-gpa.csproj
```

### Completed module projects from Section 2

```text
curriculum/create-and-run-simple-csharp-console-applications/modules/install-and-configure-visual-studio-code/install-and-configure-visual-studio-code.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/call-methods/call-methods.csproj
```

Run the completed module project from the repository root:

```powershell
dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"
```

---

## Review Notes

Independent review notes are maintained in:

[CSHARP_REVIEW.md](./CSHARP_REVIEW.md)

These notes may include:

- syntax summaries;
- compiler errors;
- invalid examples used for learning;
- corrected code;
- implementation reasoning;
- comparisons between beginner and later refactored solutions.

---

## Documentation Standard

A curriculum item is considered complete in this repository only when:

1. the official lesson units have been completed;
2. the associated assessment has been passed;
3. the achievement has been earned when applicable;
4. the local project runs successfully;
5. the project is included in the solution when applicable;
6. the full solution builds without errors;
7. section documentation has been updated;
8. progress in this root README has been updated;
9. relevant evidence has been stored;
10. the Git diff has been reviewed before commit.

This structure keeps the repository useful for:

- certification preparation;
- long-term review;
- relearning;
- debugging practice;
- portfolio evidence;
- progressive refactoring;
- tracking conceptual development.

---

## Curriculum Sources

- [freeCodeCamp — Foundational C# with Microsoft](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/)
- [Microsoft Learn — Get Started with C#, Part 1](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-1/)
- [Microsoft Learn — Get Started with C#, Part 2](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-2/)

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)