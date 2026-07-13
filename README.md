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
|-- curriculum/
|   |-- write-your-first-code-using-csharp/
|   |   |-- modules/
|   |   |   |-- first-csharp-code/
|   |   |   |   |-- Program.cs
|   |   |   |   `-- first-csharp-code.csproj
|   |   |   |-- literals-and-variables/
|   |   |   |   |-- Program.cs
|   |   |   |   `-- literals-and-variables.csproj
|   |   |   `-- string-formatting/
|   |   |       |-- Program.cs
|   |   |       `-- string-formatting.csproj
|   |   |-- guided-projects/
|   |   `-- trophy/
|   |-- create-and-run-simple-csharp-console-applications/
|   |-- add-logic-to-csharp-console-applications/
|   |-- work-with-variable-data-in-csharp-console-applications/
|   |-- create-methods-in-csharp-console-applications/
|   |-- debug-csharp-console-applications/
|   `-- foundational-csharp-with-microsoft-certification-exam/
|-- CSHARP_REVIEW.md
|-- freecodecamp-csharp.slnx
|-- .gitignore
`-- README.md
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
3 / 7 completed
```

Completed:

- Write Your First C# Code
- Store and Retrieve Data Using Literal and Variable Values in C#
- Perform Basic String Formatting in C#

Remaining:

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
curriculum/write-your-first-code-using-csharp/modules/first-csharp-code/
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
curriculum/write-your-first-code-using-csharp/modules/literals-and-variables/
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

### Perform Basic String Formatting in C#

Location:

```text
curriculum/write-your-first-code-using-csharp/modules/string-formatting/
```

This module introduces the main techniques used to format and combine string
values in C#.

Topics covered:

- character escape sequences;
- new-line and tab formatting with `\n` and `\t`;
- escaped quotation marks with `\"`;
- escaped backslashes with `\\`;
- verbatim string literals with `@`;
- Unicode escape sequences with `\u`;
- string concatenation with `+`;
- string interpolation with `$`;
- combined interpolated verbatim strings with `$@"..."`;
- formatting output with a limited number of console instructions.

#### Escape Sequences

```csharp
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
```

#### Verbatim String Literals

```csharp
Console.WriteLine(@"c:\source\repos");
```

The `@` prefix preserves backslashes and whitespace, which is useful for Windows
file paths and multi-line text.

#### Unicode Escape Sequences

```csharp
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```

The `\u` sequence followed by four hexadecimal digits represents a UTF-16 code
unit.

#### String Concatenation

```csharp
string firstName = "Bob";
string greeting = "Hello";

Console.WriteLine(greeting + " " + firstName + "!");
```

#### String Interpolation

```csharp
string firstName = "Bob";

Console.WriteLine($"Hello {firstName}!");
```

Interpolation reduces the punctuation required when combining multiple literals
and variables.

#### Interpolated Verbatim Strings

```csharp
string projectName = "First-Project";

Console.WriteLine($@"C:\Output\{projectName}\Data");
```

The `$` prefix enables interpolation, while `@` preserves backslashes.

#### Intentional Compiler Errors

The module includes invalid examples to demonstrate why quotation marks and
backslashes must be escaped correctly.

| Error | Meaning |
| --- | --- |
| `CS1003` | A syntax element such as a comma is expected |
| `CS0103` | A name does not exist in the current context |
| `CS1009` | An unrecognized escape sequence was used |

These examples are preserved as comments or review notes so the final project
continues to build successfully.

#### Module Challenge

```csharp
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

string russianMessage =
    "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c " +
    "\u0440\u0443\u0441\u0441\u043a\u0438\u0439 " +
    "\u0432\u044b\u0432\u043e\u0434";

string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

Console.WriteLine($"View English output:\n\t{englishLocation}\n");
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}");
```

Expected output:

```text
View English output:
    c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
    c:\Exercise\ACME\ru-RU\data.txt
```

Microsoft Learn confirmed completion of the module and its assessment.


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
| Curriculum items | 3 | In progress |
| Guided projects | 0 | Not started |
| Trophies | 0 | Not started |
| Certification exam | 0 | Not started |

Current section progress:

```text
Write Your First Code Using C#: 3 / 7
```

---

## Solution

Solution file:

```text
freecodecamp-csharp.slnx
```

Projects currently included after migration:

```text
curriculum/write-your-first-code-using-csharp/modules/first-csharp-code/first-csharp-code.csproj
curriculum/write-your-first-code-using-csharp/modules/literals-and-variables/literals-and-variables.csproj
curriculum/write-your-first-code-using-csharp/modules/string-formatting/string-formatting.csproj
```

Build command:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

The full solution build must be verified before each curriculum commit.

---

## Next Module

### Perform Basic Operations on Numbers in C#

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