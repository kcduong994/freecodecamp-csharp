# freeCodeCamp C# Learning Repository

![C#](https://img.shields.io/badge/C%23-Learning-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Curriculum-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Sections](https://img.shields.io/badge/Sections_Completed-1%2F7-16A34A)

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
Completed section: Write Your First Code Using C#
Last completed milestone: Verified Trophy
```

| No. | Curriculum section | Progress | Status |
| ---: | --- | ---: | --- |
| 1 | Write Your First Code Using C# | 7 / 7 | Completed |
| 2 | Create and Run Simple C# Console Applications | Not started | Next |
| 3 | Add Logic to C# Console Applications | Not started | Pending |
| 4 | Work with Variable Data in C# Console Applications | Not started | Pending |
| 5 | Create Methods in C# Console Applications | Not started | Pending |
| 6 | Debug C# Console Applications | Not started | Pending |
| 7 | Foundational C# with Microsoft Certification Exam | Not started | Pending |

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

## Next Section

### 2. Create and Run Simple C# Console Applications

```text
Status: Next
Progress: Not started
```

This section will be documented when study begins. Its source code, notes,
project structure, build validation, and completion evidence will be maintained
inside:

```text
curriculum/create-and-run-simple-csharp-console-applications/
```

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
- C#
- .NET 10
- Windows
- Developer PowerShell
- Git
- GitHub

Visual Studio is the primary development environment for this repository.

---

## Solution

Solution file:

```text
freecodecamp-csharp.slnx
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

## Completed Projects

The first completed section currently contributes six executable projects:

```text
curriculum/write-your-first-code-using-csharp/modules/first-csharp-code/first-csharp-code.csproj

curriculum/write-your-first-code-using-csharp/modules/literals-and-variables/literals-and-variables.csproj

curriculum/write-your-first-code-using-csharp/modules/string-formatting/string-formatting.csproj

curriculum/write-your-first-code-using-csharp/modules/number-operations/number-operations.csproj

curriculum/write-your-first-code-using-csharp/guided-projects/calculate-student-grades/calculate-student-grades.csproj

curriculum/write-your-first-code-using-csharp/guided-projects/calculate-final-gpa/calculate-final-gpa.csproj
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
3. the local project runs successfully;
4. the project is included in the solution when applicable;
5. the full solution builds without errors;
6. section documentation has been updated;
7. progress in this root README has been updated;
8. relevant evidence has been stored;
9. the Git diff has been reviewed before commit.

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

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)