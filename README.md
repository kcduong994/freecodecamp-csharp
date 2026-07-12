# freeCodeCamp C# Learning Repository

![C#](https://img.shields.io/badge/C%23-Learning-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Curriculum-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)

This repository documents my progress through the
**Foundational C# with Microsoft Certification**
curriculum delivered through freeCodeCamp and Microsoft Learn.

It contains guided learning modules, console applications, guided projects,
certification work, and independently written study notes created while learning
C# and the .NET platform.

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

## Curriculum Structure

The repository follows the major sections shown in the freeCodeCamp curriculum.

```text
freecodecamp-csharp/
├── curriculum/
│   ├── write-your-first-code-using-csharp/
│   │   ├── modules/
│   │   │   ├── write-your-first-c-sharp-code/
│   │   │   │   ├── Program.cs
│   │   │   │   └── write-your-first-c-sharp-code.csproj
│   │   │   └── store-and-retrieve-data-using-literal-and-variable-values/
│   │   │       ├── Program.cs
│   │   │       └── store-and-retrieve-data-using-literal-and-variable-values.csproj
│   │   ├── guided-projects/
│   │   └── trophy/
│   ├── create-and-run-simple-csharp-console-applications/
│   ├── add-logic-to-csharp-console-applications/
│   ├── work-with-variable-data-in-csharp-console-applications/
│   ├── create-methods-in-csharp-console-applications/
│   ├── debug-csharp-console-applications/
│   └── foundational-csharp-with-microsoft-certification-exam/
├── labs/
├── CSHARP_REVIEW.md
├── freecodecamp-csharp.slnx
├── .gitignore
└── README.md
```

Each major curriculum section may contain:

- `modules/` for normal Microsoft Learn modules linked from freeCodeCamp;
- `guided-projects/` for guided projects included in that section;
- `trophy/` for section completion evidence or related notes.

The curriculum section title and the Microsoft Learn module title are not always
the same. Directory names follow the freeCodeCamp section hierarchy, while
individual project names follow the corresponding module or guided-project title.

---

## Curriculum Sections

### 1. Write Your First Code Using C#

Current progress:

```text
2 / 7 completed
```

Completed:

- Write Your First C# Code
- Store and Retrieve Data Using Literal and Variable Values in C#

Remaining:

- Perform Basic String Formatting in C#
- Perform Basic Operations on Numbers in C#
- Guided Project - Calculate and Print Student Grades
- Guided Project - Calculate Final GPA
- Trophy - Write Your First Code Using C#

### 2. Create and Run Simple C# Console Applications

Status: Not started

### 3. Add Logic to C# Console Applications

Status: Not started

### 4. Work with Variable Data in C# Console Applications

Status: Not started

### 5. Create Methods in C# Console Applications

Status: Not started

### 6. Debug C# Console Applications

Status: Not started

### 7. Foundational C# with Microsoft Certification Exam

Status: Not started

---

## Completed Modules

### Write Your First C# Code

Location:

```text
curriculum/write-your-first-code-using-csharp/modules/write-your-first-c-sharp-code/
```

This module demonstrates the difference between:

- `Console.WriteLine()`, which prints content and moves the cursor to a new line;
- `Console.Write()`, which prints content without automatically moving the cursor.

Key concepts:

- C# console applications
- top-level statements
- `Console.WriteLine()`
- `Console.Write()`
- string literals
- method calls
- semicolons
- whitespace inside string literals
- Visual Studio solutions and projects
- `.slnx` solution files
- `.csproj` project files
- implicit global using directives

Microsoft Learn confirmed completion of the module and its assessment.

---

### Store and Retrieve Data Using Literal and Variable Values in C#

Location:

```text
curriculum/write-your-first-code-using-csharp/modules/store-and-retrieve-data-using-literal-and-variable-values/
```

This module introduces literal values, variables, foundational data types, and
the rules used by C# to store and retrieve values.

Topics covered:

- character literals
- string literals
- integer literals
- floating-point literals
- Boolean literals
- variable declaration
- assignment
- initialization
- reassignment
- retrieving stored values
- type compatibility
- variable naming rules and conventions
- implicitly typed local variables using `var`
- compiler type inference
- intentional compiler errors

#### Literal Types

| C# type | Purpose | Example |
| --- | --- | --- |
| `char` | Stores a single character | `'b'` |
| `string` | Stores text | `"Hello World!"` |
| `int` | Stores a whole number | `123` |
| `float` | Stores a floating-point number | `0.25F` |
| `double` | Stores a double-precision floating-point number | `2.625` |
| `decimal` | Stores a high-precision decimal number | `12.39816m` |
| `bool` | Stores a logical value | `true` |

#### Intentional Compiler Errors

Some Microsoft Learn exercises intentionally introduce invalid code so that
compiler diagnostics can be observed and understood.

These examples are preserved as comments or study notes rather than active
statements. This keeps the final project buildable while retaining their
learning value.

| Error | Meaning |
| --- | --- |
| `CS1012` | Too many characters in a character literal |
| `CS0131` | The left side of an assignment is not assignable |
| `CS0029` | A value cannot be implicitly converted to the target type |
| `CS0165` | A local variable is used before assignment |
| `CS0818` | An implicitly typed variable is declared without initialization |

#### Module Challenge

```csharp
string name = "Bob";
int messageCount = 3;
decimal temperatureCelsius = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messageCount);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperatureCelsius);
Console.WriteLine(" celsius.");
```

Expected output:

```text
Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
```

Microsoft Learn and freeCodeCamp both show this module as completed.

---

## Learning Workflow

The curriculum is completed across two learning platforms:

1. Open the current lesson on freeCodeCamp.
2. Follow the Microsoft Learn link provided by freeCodeCamp.
3. Complete all units in the corresponding Microsoft Learn module.
4. Complete the Microsoft Learn module assessment.
5. Return to freeCodeCamp.
6. Confirm assignment completion.
7. Answer the freeCodeCamp checkpoint question.
8. Continue to the next curriculum item.

Only the Microsoft Learn module linked directly by the current freeCodeCamp
lesson is treated as required.

The GitHub repository stores selected exercises, guided projects, review notes,
and portfolio work. freeCodeCamp does not automatically evaluate code stored in
this repository.

---

## Repository Organization

### Curriculum

The `curriculum` directory mirrors the major freeCodeCamp curriculum sections.

Each section may contain normal modules, guided projects, and trophy evidence.

### Labs

The `labs` directory is reserved for independent exercises completed from
requirements or problem descriptions outside the guided curriculum modules.

### Review Notes

The [`CSHARP_REVIEW.md`](CSHARP_REVIEW.md) file contains independently written
notes covering the concepts learned throughout the curriculum.

Compiler errors intentionally introduced by Microsoft Learn may be documented
with:

- the invalid example;
- the compiler error code;
- the reason for the error;
- the corrected code.

---

## Learning Objectives

- Learn foundational C# syntax
- Understand static typing
- Work with literals, variables, and data types
- Use assignment and initialization
- Understand compiler type inference
- Read and interpret compiler errors
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

## Progress

| Category | Completed | Status |
| --- | ---: | --- |
| Curriculum items | 2 | In progress |
| Guided projects | 0 | Not started |
| Labs | 0 | Not started |
| Trophies | 0 | Not started |
| Certification exam | 0 | Not started |

Current section progress:

```text
Write Your First Code Using C#: 2 / 7
```

---

## Solution

Solution file:

```text
freecodecamp-csharp.slnx
```

Projects currently included after migration:

```text
curriculum/write-your-first-code-using-csharp/modules/write-your-first-c-sharp-code/write-your-first-c-sharp-code.csproj
curriculum/write-your-first-code-using-csharp/modules/store-and-retrieve-data-using-literal-and-variable-values/store-and-retrieve-data-using-literal-and-variable-values.csproj
```

Build command:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

The full solution build must be verified before each curriculum commit.

---

## Next Module

### Perform Basic String Formatting in C#

This is the next freeCodeCamp item in the
**Write Your First Code Using C#** section.

A separate project should only be created after confirming that the module
contains enough code to provide useful review or portfolio value.

---

## Curriculum Links

Foundational C# with Microsoft Certification:

https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/

Microsoft Learn C# training:

https://learn.microsoft.com/training/paths/get-started-c-sharp-part-1/

---

## Author

**Duong Kim Cuong**

GitHub: https://github.com/kcduong994