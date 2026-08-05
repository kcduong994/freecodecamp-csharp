# freeCodeCamp C# Learning Repository

![C#](https://img.shields.io/badge/C%23-Learning-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Curriculum-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Sections](https://img.shields.io/badge/Sections_Completed-3%2F7-16A34A)
![Projects](https://img.shields.io/badge/Solution_Projects-26-2563EB)
![Build](https://img.shields.io/badge/Full_Solution_Build-Passing-16A34A)

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
Curriculum sections completed: 3 / 7
Latest fully completed section: Add Logic to C# Console Applications
Latest fully completed section progress: 7 / 7
Current section: Work with Variable Data in C# Console Applications
Current section status: In progress
Current section learning progress: 6 / 7
Current section repository-verified progress: 6 / 7
Instructional modules completed on Microsoft Learn: 5
Instructional modules fully repository-verified: 5
Guided projects completed in current section: 1
Challenge projects completed in current section: 0
Latest completed learning item: Guided Project — Work with Variable Data in C#
Latest project: contoso-petfriends
Latest learning item status: Completed
Microsoft Learn units: 7 / 7
Latest completion date: August 5, 2026
Projects currently registered in solution: 26
Latest organized source: Completed
Professional source comments: Completed
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Latest guided-project run: Verified
Latest application startup and normal exit: Verified
Latest project build: Verified
Latest full solution build: Verified
Latest project compiler errors: 0
Latest project compiler warnings: 0
Latest IDE diagnostics: No issues found
Next curriculum item: Challenge Project — Work with Variable Data in C#
```

| No. | Curriculum section | Learning progress | Repository verification | Status |
| ---: | --- | --- | --- | --- |
| 1 | Write Your First Code Using C# | 7 / 7 | Verified | Completed |
| 2 | Create and Run Simple C# Console Applications | 7 / 7 | Verified | Completed |
| 3 | Add Logic to C# Console Applications | 7 / 7 | Verified | Completed |
| 4 | Work with Variable Data in C# Console Applications | 6 / 7 | 6 / 7 verified | In progress |
| 5 | Create Methods in C# Console Applications | Not started | Pending | Pending |
| 6 | Debug C# Console Applications | Not started | Pending | Pending |
| 7 | Foundational C# with Microsoft Certification Exam | Not started | Pending | Pending |

A curriculum item reaches learning completion after its official Microsoft Learn
units have been completed. It reaches full repository verification after the
final source has run successfully, its project has built successfully, and the
complete solution has built successfully.

The guided project is fully repository-verified. Its final Contoso PetFriends
source is registered as the twenty-sixth solution project, implements the
suggested-donation and dog-characteristic-search requirements, starts and exits
successfully, builds independently, and preserves a passing twenty-six-project
full-solution build.
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

## Completed Section

### 2. Create and Run Simple C# Console Applications

```text
Status: Completed
Progress: 7 / 7
Instructional modules: 5
Guided projects: 1
Challenge projects: 1
Latest completed item: Challenge Project — Develop foreach and if-elseif-else Structures to Process Array Data in C#
Latest item status: Completed
Item assessment: Passed
Achievement: Earned
freeCodeCamp section completion: Confirmed
Microsoft Learn achievement: Earned
Completion date: July 23, 2026
Repository validation: Verified
```

[Open the completed section documentation](./curriculum/create-and-run-simple-csharp-console-applications/README.md)

[View Section 2 Trophy and achievement evidence](./curriculum/create-and-run-simple-csharp-console-applications/trophy/README.md)

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

### Module 3 — Add Decision Logic to Your Code Using `if`, `else`, and `else if` Statements in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 19, 2026
```

This module introduces decision-making logic that changes the execution path of
a C# application by evaluating Boolean expressions.

Learning outcomes include:

- creating branches with `if`, `else if`, and `else`;
- building Boolean expressions;
- comparing values with equality and relational operators;
- combining conditions with logical `AND` (`&&`) and logical `OR` (`||`);
- nesting code blocks;
- creating mutually exclusive branches;
- ordering conditions according to business-rule precedence;
- preventing overlapping rewards and duplicate messages;
- applying decision logic to a dice game;
- implementing a subscription-renewal challenge.

Project location:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── decision-logic/
        ├── Program.cs
        └── decision-logic.csproj
```

The project has been added to `freecodecamp-csharp.slnx`, bringing the solution
to nine registered projects.

The earlier `CS0168` warnings were corrected, the module project ran
successfully, and the complete solution build succeeded.


---

### Module 4 — Store and Iterate Through Sequences of Data Using Arrays and the `foreach` Statement in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 20, 2026
```

This module introduces arrays and sequence iteration in C#.

Learning outcomes include:

- declaring and initializing arrays;
- storing related values of the same data type;
- accessing elements with zero-based indexes;
- reassigning array elements;
- using the `Length` property;
- iterating through arrays with `foreach`;
- calculating a running total;
- combining `foreach` with `if`;
- filtering strings with `String.StartsWith()`.

Project location:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── arrays-foreach/
        ├── Program.cs
        └── arrays-foreach.csproj
```

The project has been added to `freecodecamp-csharp.slnx`, bringing the solution
to ten registered projects. The project run and full-solution build have been
verified successfully.

---


### Module 5 — Create Readable Code with Conventions, Whitespace, and Comments in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 21, 2026
```

This module focuses on expressing program intent clearly so that source code is
easier to read, review, update, debug, and maintain.

Learning outcomes include:

- following C# identifier rules;
- applying `camelCase` to local variables;
- choosing descriptive names that communicate purpose and intent;
- avoiding unclear abbreviations and obsolete type-prefix naming styles;
- distinguishing compiler-enforced rules from community conventions;
- using single-line and block comments;
- temporarily excluding code from compilation while testing changes;
- writing comments that explain higher-level purpose rather than obvious syntax;
- using blank lines to group related statements;
- placing braces on separate lines;
- indenting nested blocks to communicate ownership;
- refactoring poorly formatted code into a readable implementation.

The final challenge reverses a message and counts occurrences of the letter
`o`. The repository implementation uses explicit names such as
`originalMessage`, `messageCharacters`, `letterOCount`, and `reversedMessage`
instead of ambiguous names such as `str`, `x`, and `new_message`.

Project location:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── readable-code/
        ├── Program.cs
        └── readable-code.csproj
```

The project has been added to `freecodecamp-csharp.slnx`, bringing the solution
to eleven registered projects. The module assessment was passed, the local
project ran successfully, and the complete solution build succeeded.

---


### Guided Project 1 — Develop `foreach` and `if-else if-else` Structures to Process Array Data in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 22, 2026
```

This guided project integrates the concepts introduced throughout the current
section into a complete **Student Grading Application**.

The application:

- stores student names in a `string[]` array;
- stores assignment scores in separate `int[]` arrays;
- uses an outer `foreach` loop to process students;
- uses `if-else if-else` to select the current student's score array;
- uses an inner `foreach` loop to process assignment scores;
- distinguishes regular exams from extra-credit assignments;
- applies a 10% weighting factor to extra-credit scores;
- calculates a final numeric grade with `decimal`;
- assigns a letter grade automatically;
- writes an aligned grading report to the console;
- supports additional students with limited changes to the existing structure.

Project rules:

```text
Regular exam assignments: 5
Exam score range: 0–100
Extra-credit weighting: 10%
Final numeric grade:
    (exam total + weighted extra-credit points)
    / number of exam assignments
```

The grade thresholds are evaluated from highest to lowest:

```text
97–100  A+
93–96   A
90–92   A-
87–89   B+
83–86   B
80–82   B-
77–79   C+
73–76   C
70–72   C-
67–69   D+
63–66   D
60–62   D-
0–59    F
```

Project location:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── guided-projects/
    └── student-grading-application/
        ├── Program.cs
        └── student-grading-application.csproj
```

The repository implementation improves the instructional version by:

- using descriptive variable names;
- declaring fixed grading rules with `const`;
- removing unused `using` directives;
- using braces consistently;
- preventing unknown students from reusing a previous score array;
- resetting counters and totals inside the outer loop;
- formatting stable output columns with interpolated-string alignment;
- retaining comments that explain purpose and constraints rather than obvious
  syntax.

Verified output:

```text
STUDENT GRADING REPORT

Student       Numeric Grade   Letter Grade
------------------------------------------
Sophia                 95.8              A
Andrew                 91.2             A-
Emma                   90.4             A-
Logan                  93.0              A
Becky                  94.8              A
Chris                  93.4              A
Eric                   93.4              A
Gregor                 94.6              A
```

The project has been added to `freecodecamp-csharp.slnx`, bringing the solution
to twelve registered projects. The Microsoft Learn assessment was passed, the
achievement was earned, the local project ran successfully, and the complete
solution build was verified.

---


### Challenge Project 1 — Develop `foreach` and `if-else if-else` Structures to Process Array Data in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project registration in solution: Verified
Solution project count: 13
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 23, 2026
```

This challenge project extends the Student Grading Application by separating the
regular exam average from the weighted contribution of extra-credit work.

The updated report includes:

- the student's name;
- average exam score;
- overall numeric grade;
- automatically assigned letter grade;
- average extra-credit score;
- weighted extra-credit points added to the final grade.

Project location:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── challenge-projects/
    └── student-grading-challenge/
        ├── Program.cs
        └── student-grading-challenge.csproj
```

The challenge demonstrates:

- revising an existing application from a feature specification;
- preserving the nested `foreach` and `if-else if-else` structure;
- separating exam and extra-credit totals;
- guarding decimal calculations;
- applying a 10% extra-credit weighting factor;
- formatting a detailed grading report;
- refactoring instructional code for readability and reliability.

Expected report values:

```text
Student         Exam Score    Overall Grade    Letter            Extra Credit
-----------------------------------------------------------------------------
Sophia                92.2            95.88         A              92 (3.68 pts)
Andrew                89.6            91.38        A-              89 (1.78 pts)
Emma                  85.6            90.94        A-              89 (5.34 pts)
Logan                 91.2            93.12         A              96 (1.92 pts)
```

The official challenge assessment was passed, the achievement was earned,
the project ran with the expected grading report, and the complete
thirteen-project solution build succeeded.

---

### Section 2 Trophy and Achievement

The section completion evidence is stored under:

```text
curriculum/create-and-run-simple-csharp-console-applications/
└── trophy/
    ├── README.md
    └── assets/
        ├── freecodecamp-section2-completion.png
        └── microsoft-learn-section2-achievement.png
```

The evidence confirms:

- freeCodeCamp completion of **Create and Run Simple C# Console Applications**;
- Microsoft Learn achievement for
  **Create and run simple C# console applications (Get started with C#, Part 2)**;
- completion date: **July 23, 2026**.

[View Section 2 Trophy documentation](./curriculum/create-and-run-simple-csharp-console-applications/trophy/README.md)

---


### Section 2 Repository Verification

```text
Challenge project run: Verified
Challenge project output: Verified
Challenge project build: Verified
Full solution build: Verified
Registered solution projects: 13
Verification date: July 23, 2026
```

The terminal output confirms that `student-grading-challenge` produced the
expected report and that all thirteen solution projects compiled successfully.

---

## Completed Section

### 3. Add Logic to C# Console Applications

```text
Status: Completed
Progress: 7 / 7
Completed instructional modules: 5
Completed guided projects: 1
Completed challenge projects: 1
Latest completed item: Challenge Project - Develop Branching and Looping Structures in C#
Application: Contoso PetFriends
Item assessment: Passed
Achievement: Earned
Microsoft Learn certificate: Earned
Microsoft Learn Trophy: Verified by freeCodeCamp
Project registration: Verified
Solution project count: 20
Final organized Program.cs: Completed
Professional source comments: Completed
Local project run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 2.6 seconds
Build warnings: 0
Build errors: 0
Completion date: July 30, 2026
```

Section 3 develops Boolean evaluation, branching, iteration, variable scope,
input validation, and progressively more structured control flow in C# console
applications.

[Open the completed Section 3 documentation](./curriculum/add-logic-to-csharp-console-applications/README.md)

[View Section 3 Trophy and certificate evidence](./curriculum/add-logic-to-csharp-console-applications/trophy/README.md)

---


### Module 1 — Evaluate Boolean Expressions to Make Decisions in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 24, 2026
```

This module introduces Boolean expressions and demonstrates how `true` and
`false` results drive decisions in C#.

Learning outcomes include:

- testing equality with `==`;
- testing inequality with `!=`;
- comparing numeric values with `>`, `<`, `>=`, and `<=`;
- normalizing strings with `Trim()` and `ToLower()` before comparison;
- using `String.Contains()` to return Boolean results;
- reversing a Boolean value with logical negation `!`;
- distinguishing the inequality operator `!=` from unary negation `!`;
- returning one of two values with the conditional operator `?:`;
- simulating a coin flip with `Random.Next()`;
- applying nested decision logic to role-based permissions.

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── modules/
    └── evaluate-boolean-expressions/
        ├── Program.cs
        └── evaluate-boolean-expressions.csproj
```

The final project preserves the complete instructional sequence while removing
duplicate declarations, unused directives, incomplete statements, and invalid
intermediate attempts.

Verified challenge behavior:

```text
Conditional operator challenge:
heads
or
tails

Role-based access challenge:
Welcome, Admin user.
```

The project is registered in `freecodecamp-csharp.slnx`, bringing the solution
to fourteen projects. The module run, project build, and complete solution build
all succeeded.

---


### Module 2 — Control Variable Scope and Logic Using Code Blocks in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 25, 2026
```

This module explains how C# code blocks control execution paths, variable
visibility, definite assignment, and the readability of conditional logic.

Learning outcomes include:

- defining code blocks with curly braces `{ }`;
- understanding local variable scope;
- distinguishing variables declared inside a block from variables declared in
  the surrounding scope;
- moving declarations outside a block when values must be reused later;
- initializing local variables before they are read;
- recognizing compiler errors `CS0103` and `CS0165`;
- deciding when braces may technically be omitted from a one-statement `if`;
- using braces consistently in larger `if-else if-else` structures;
- improving readability by placing statements on separate lines;
- preserving values calculated inside a `foreach` loop for later use.

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── modules/
    └── code-blocks-variable-scope/
        ├── Program.cs
        └── code-blocks-variable-scope.csproj
```

The final project keeps all instructional examples while moving intentionally
invalid examples into comments. Independent examples use separate outer blocks,
which allows local variable names to be reused without duplicate-declaration
errors.

Verified challenge:

```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");
```

Verified output:

```text
Set contains 42
Total: 108
```

The project is registered in `freecodecamp-csharp.slnx`, bringing the solution
to fifteen projects. The local run, project build, and complete solution build
all succeeded.

---


### Module 3 — Branch the Flow of Code Using the `switch-case` Construct in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Solution project count: 16
Completion date: July 26, 2026
```

This module introduces the C# `switch` statement as a clear alternative to a
long `if-elseif-else` chain when one value must be compared against several
known matching values.

Learning outcomes include:

- branching execution with a `switch` statement;
- evaluating a switch expression;
- defining matching alternatives with `case` labels;
- providing a fallback branch with `default`;
- terminating a switch section with `break`;
- allowing multiple `case` labels to share one switch section;
- understanding that C# does not allow implicit fall-through between non-empty
  switch sections;
- deciding when `switch` is clearer than `if-elseif-else`;
- converting existing `if-elseif-else` logic into equivalent `switch`
  statements.

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── modules/
    └── switch-case-construct/
        ├── Program.cs
        └── switch-case-construct.csproj
```

The final project preserves three complete instructional examples:

1. matching a fruit name;
2. assigning an employee title from an employee level;
3. decoding a product SKU in the module challenge.

The employee example demonstrates multiple labels sharing one section:

```csharp
case 100:
case 200:
    title = "Senior Associate";
    break;
```

The challenge decodes this SKU:

```text
01-MN-L
```

into:

```text
Product: Large Maroon Sweat shirt
```

The final `Program.cs` separates the examples into methods so that repeated
variable names remain isolated, the complete lesson stays runnable, and the code
is easier to review, test, and maintain.

Verified runtime output:

```text
BRANCH THE FLOW OF CODE USING SWITCH-CASE
=========================================

Example 1: Match a fruit name
-----------------------------
App will display information for apple.

Example 2: Determine an employee title
--------------------------------------
Employee: John Smith, Level: 200, Title: Senior Associate
Employee: John Smith, Level: 201, Title: Associate
Employee: John Smith, Level: 100, Title: Senior Associate

Challenge: Decode a product SKU
-------------------------------
SKU: 01-MN-L
Product: Large Maroon Sweat shirt
```

Verification results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded
Full solution build: Succeeded
Registered solution projects: 16
Verification date: July 26, 2026
```

---


### Module 4 — Iterate Through a Code Block Using the `for` Statement in C#

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Solution project count: 17
Completion date: July 27, 2026
```

This module introduces the C# `for` statement for repeating a code block with
explicit control over the initializer, continuation condition, and iterator.

Learning outcomes include:

- understanding the structure of a `for` statement;
- identifying the initializer, condition, iterator, and loop body;
- counting upward and downward;
- changing the iterator by more than one;
- terminating a loop early with `break`;
- traversing arrays by index;
- iterating through arrays in reverse order;
- distinguishing `for` from `foreach`;
- modifying array elements by index;
- combining `for`, `if`, `%`, and `&&`;
- implementing the FizzBuzz challenge correctly.

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── modules/
    └── for-statement/
        ├── Program.cs
        └── for-statement.csproj
```

The final project preserves seven instructional examples:

1. a basic loop from `0` through `9`;
2. a countdown from `10` through `0`;
3. a custom step using `+= 3`;
4. early termination with `break`;
5. reverse array traversal;
6. modifying `"David"` to `"Sammy"` by index;
7. FizzBuzz from `1` through `100`.

The basic loop demonstrates the three expressions that control iteration:

```csharp
for (int index = 0; index < 10; index++)
{
    Console.WriteLine(index);
}
```

The reverse-array example starts at the last valid index:

```csharp
for (int index = names.Length - 1; index >= 0; index--)
{
    Console.WriteLine(names[index]);
}
```

The FizzBuzz challenge applies these rules:

```text
Divisible by both 3 and 5 → FizzBuzz
Divisible by 3 only       → Fizz
Divisible by 5 only       → Buzz
Otherwise                 → print the number
```

Implementation:

```csharp
for (int number = 1; number <= 100; number++)
{
    if ((number % 3 == 0) && (number % 5 == 0))
    {
        Console.WriteLine($"{number} - FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine($"{number} - Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine($"{number} - Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}
```

The combined divisibility condition must be checked first. Otherwise, a value
such as `15` would match the divisible-by-3 branch before reaching the
`FizzBuzz` branch.

The final `Program.cs` separates each example into a dedicated method, uses
descriptive loop-control variables, retains invalid `foreach` reassignment code
inside comments for reference, and uses XML documentation comments to improve
reviewability and maintenance.

Verified runtime behavior:

```text
Basic loop: 0 through 9
Countdown: 10 through 0
Custom step: 0, 3, 6, 9
Break example: 0 through 7
Reverse array: Michael, David, Eddie, Alex
Updated array: Alex, Eddie, Sammy, Michael
FizzBuzz: 1 through 100 with the required labels
```

Final FizzBuzz lines:

```text
96 - Fizz
97
98
99 - Fizz
100 - Buzz
```

Verification results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded
Full solution build: Succeeded
Registered solution projects: 17
Verification date: July 27, 2026
```

---


### Module 5 — Add Looping Logic to Your Code Using the `do-while` and `while` Statements in C#

```text
Learning status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Project registration in solution: Verified
Solution project count: 18
Bootstrap project run: Verified
Final organized Program.cs: Completed
Final-code run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 6.4 seconds
Completion date: July 28, 2026
```

This module extends C# iteration beyond `for` and `foreach`. It explains how
`do-while` and `while` repeat a block until a Boolean exit condition is reached,
and how values generated or retrieved inside the loop can determine when the
loop stops.

Learning outcomes include:

- choosing between `for`, `foreach`, `do-while`, and `while`;
- understanding that `do-while` executes one or more times;
- understanding that `while` executes zero or more times;
- evaluating a Boolean condition after or before the loop body;
- creating and diagnosing an infinite loop;
- recognizing unreachable code warning `CS0162`;
- using `continue` to skip the remainder of the current iteration;
- distinguishing `continue` from `break`;
- using random values to control an exit condition;
- validating nullable console input;
- converting text with `int.TryParse()`;
- validating numeric ranges and role names;
- combining `for` and `while` to process strings;
- using `IndexOf()`, `Remove()`, `Substring()`, and `TrimStart()`.

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── modules/
    └── do-while-and-while-statements/
        ├── Program.cs
        └── do-while-and-while-statements.csproj
```

The final organized source contains these independent examples and challenges:

```text
DisplayLoopComparison()
RunDoWhileRandomExample()
RunWhileRandomExample()
RunContinueExample()
RunBattleChallenge()
RunIntegerInputChallenge()
RunRoleInputChallenge()
RunSentenceProcessingChallenge()
```

### `do-while`

A `do-while` statement executes its body before evaluating the continuation
condition:

```csharp
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
}
while (current != 7);
```

Execution order:

```text
Execute loop body
    ↓
Evaluate Boolean condition
    ├── true  → repeat
    └── false → exit
```

The body therefore executes at least once. The semicolon following the
condition is required.

### `while`

A `while` statement evaluates its condition before entering the body:

```csharp
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
```

Execution order:

```text
Evaluate Boolean condition
    ├── false → skip the body
    └── true  → execute and evaluate again
```

The body can therefore execute zero times.

### `continue` and `break`

```text
continue → skip the remaining statements in the current iteration
break    → terminate the complete loop
```

The random-number example uses `continue` to prevent `8`, `9`, and `10` from
being displayed while still allowing the loop to continue until `7` is
generated.

### Battle challenge

The Hero-versus-Monster challenge applies these rules:

```text
Hero health: 10
Monster health: 10
Attack damage: 1 through 10
Hero attacks first
Monster attacks only if it survives
Battle ends when either health value is zero or less
```

`do-while` is appropriate because the hero must attack at least once.

### Input-validation challenges

The numeric challenge accepts an integer from `5` through `10`, inclusive:

```csharp
if (acceptedValue < 5 || acceptedValue > 10)
{
    isValidNumber = false;
}
```

The organized version corrects the earlier boundary condition that would have
incorrectly rejected `5` and `10`.

The role challenge accepts:

```text
Administrator
Manager
User
```

while ignoring surrounding spaces and letter casing by using `Trim()` and
`ToLowerInvariant()`.

### String-processing challenge

The final challenge processes:

```csharp
string[] myStrings =
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};
```

Expected output:

```text
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
```

The outer loop uses `for` to obtain a modifiable working copy. The inner loop
uses `while` because a string may contain no period, meaning the body may need
to execute zero times.

The organized source removes duplicate top-level declarations, removes unused
`using` directives, uses descriptive names and constants, preserves detailed
comments, and separates each example into a testable method.

Verified results:

```text
Microsoft Learn completion: Verified
Assessment: Passed
Achievement: Earned
Project registered in solution: Verified
Registered solution projects: 18
Final organized source: Completed
Final-code run: Succeeded
Interactive validation behavior: Verified
Sentence-processing output: Verified
Module build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 6.4 seconds
Verification date: July 28, 2026
```

---


### Guided Project 1 — Develop Conditional Branching and Looping Structures in C#

```text
Status: Completed
Application: Contoso Pets
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Final organized Program.cs: Completed
Project registration in solution: Verified
Solution project count: 19
Local project run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 8.1 seconds
Completion date: July 29, 2026
```

This guided project integrates the Section 3 control-flow concepts into
**Contoso Pets**, a console application for managing cats and dogs awaiting new
homes.

The completed guided-project scope implements:

- predefined sample pet data;
- a persistent menu controlled by `do-while`;
- menu routing with `switch`;
- display of all occupied pet records;
- validated entry of one or more new pets;
- automatic pet-ID generation;
- handling of unknown pet information with `tbd`;
- capacity enforcement for a maximum of eight pets;
- placeholders for features completed in the later challenge project.

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── guided-projects/
    └── contoso-pets/
        ├── Program.cs
        └── contoso-pets.csproj
```

The application stores runtime data in a two-dimensional string array:

```csharp
string[,] ourAnimals =
    new string[MaxPets, CharacteristicCount];
```

Array layout:

| Dimension | Meaning |
| --- | --- |
| First index | Pet row |
| Second index | Pet characteristic |
| Rows | `8` pets |
| Columns | `6` characteristics |

The six characteristics are:

```text
Pet ID
Species
Age
Nickname
Physical description
Personality description
```

Each pet is processed with an outer row loop, while an inner column loop
processes all six characteristics:

```csharp
for (int row = 0; row < animals.GetLength(0); row++)
{
    for (
        int column = 0;
        column < animals.GetLength(1);
        column++)
    {
        Console.WriteLine(animals[row, column]);
    }
}
```

The zero-based relationship is important:

```text
8 rows
Valid indexes: 0 through 7
Last valid index: MaxPets - 1
```

The final source uses named column constants instead of unexplained numeric
indexes and separates the application into focused methods:

```text
Main()
PopulateSampleData(...)
RunApplication(...)
DisplayMainMenu()
ReadMenuSelection()
ListAllPets(...)
AddNewPets(...)
CountPets(...)
HasPetData(...)
ReadAnimalSpecies()
ReadAnimalAge()
ReadOptionalDescription(...)
ReadYesOrNo(...)
SavePet(...)
```

Input validation includes:

```text
Species → dog or cat
Age     → ? or a non-negative integer
Optional blank fields → tbd
Continue adding pets → y or n
```

Automatic IDs combine the first species letter with a one-based pet number:

```text
Fifth dog → d5
Sixth cat → c6
```

The organized implementation removes unused directives, duplicated case labels,
repeated statements, incomplete intermediate code, and null-unsafe input while
preserving the learning rationale through XML documentation and focused inline
comments.

Verification results:

```text
Application launch: Succeeded
Complete menu display: Verified
Exit handling: Verified
Project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 8.1 seconds
Registered solution projects: 19
Verification date: July 29, 2026
```

The complete implementation of menu options 1 and 2 is present in the source.
The recorded terminal verification confirms application startup, menu output,
normal exit handling, the project build, and the full-solution build.

---


### Challenge Project 1 — Develop Branching and Looping Structures in C#

```text
Status: Completed
Application: Contoso PetFriends
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Microsoft Learn certificate: Earned
Microsoft Learn Trophy: Verified by freeCodeCamp
Final organized Program.cs: Completed
Professional source comments: Completed
Project registration in solution: Verified
Solution project count: 20
Local project run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 2.6 seconds
Build warnings: 0
Build errors: 0
Completion date: July 30, 2026
```

This challenge completes Section 3 by extending the **Contoso PetFriends**
application from the guided project.

The starter application already provided:

- a persistent eight-option menu;
- predefined pet records;
- display of all occupied records;
- validated entry of new cats and dogs;
- automatic pet-ID generation;
- an eight-pet capacity limit;
- placeholders for later data-completion features.

The challenge implements the two required workflows:

```text
Menu option 3
→ Ensure animal ages and physical descriptions are complete

Menu option 4
→ Ensure animal nicknames and personality descriptions are complete
```

Project location:

```text
curriculum/add-logic-to-csharp-console-applications/
└── challenge-projects/
    └── contoso-pets-challenge/
        ├── Program.cs
        └── contoso-pets-challenge.csproj
```

The final application demonstrates:

- menu routing with `switch`;
- record traversal with `for`;
- repeated input validation with `while` and `do-while`;
- skipping unused rows with `continue`;
- safe numeric conversion with `int.TryParse()`;
- required-text validation with `string.IsNullOrWhiteSpace()`;
- null-safe console input with `?.` and `??`;
- extraction of field values from display labels;
- normalization of `tbd` and missing values;
- named constants for array-column positions;
- focused methods and narrow variable scope;
- comments that explain intent, constraints, and control flow.

The age workflow rejects values that cannot be converted to an integer. The
description, nickname, and personality workflows reject `null`, empty, and
whitespace-only values. Existing valid records are preserved, while only
incomplete fields require new input.

Menu options `5` through `8` remain explicitly under construction because they
are visible in the starter interface but outside this challenge specification.

Run the completed challenge:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\challenge-projects\contoso-pets-challenge\contoso-pets-challenge.csproj"
```

Build the challenge:

```powershell
dotnet build `
  ".\curriculum\add-logic-to-csharp-console-applications\challenge-projects\contoso-pets-challenge\contoso-pets-challenge.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Challenge project run: Succeeded
Challenge behavior: Verified
Challenge project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 2.6 seconds
Registered solution projects: 20
Build warnings: 0
Build errors: 0
Verification date: July 30, 2026
```

---

### Section 3 Trophy, Certificate, and Verification

Official evidence is stored under:

```text
curriculum/add-logic-to-csharp-console-applications/
└── trophy/
    ├── README.md
    └── assets/
        ├── 1.PNG
        └── 2.PNG
```

The evidence records:

- completion of **Add logic to C# console applications (Get started with C#,
  Part 3)** on Microsoft Learn;
- the Microsoft Learn completion certificate issued to **Duong Kim Cuong** on
  **30 July 2026**;
- successful freeCodeCamp verification of the Microsoft Learn Trophy named
  **Add Logic to C# Console Applications**.

[View Section 3 Trophy documentation](./curriculum/add-logic-to-csharp-console-applications/trophy/README.md)

[View the Microsoft Learn certificate](./curriculum/add-logic-to-csharp-console-applications/trophy/assets/1.PNG)

[View the verified Trophy evidence](./curriculum/add-logic-to-csharp-console-applications/trophy/assets/2.PNG)

---

## Current Section

### 4. Work with Variable Data in C# Console Applications

```text
Status: In progress
Learning progress: 6 / 7
Repository-verified progress: 6 / 7
Completed instructional modules on Microsoft Learn: 5
Fully repository-verified instructional modules: 5
Completed guided projects: 1
Completed challenge projects: 0
Latest completed learning item: Guided Project — Work with Variable Data in C#
Microsoft Learn units: 7 / 7
Application: Contoso PetFriends
Project registration: Verified
Solution project count: 26
Final organized Program.cs: Completed
Professional source comments: Completed
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Application run: Verified
Application startup and normal exit: Verified
Project build: Verified
Full solution build: Verified
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Latest completion date: August 5, 2026
Next curriculum item: Challenge Project — Work with Variable Data in C#
```

Section 4 develops practical skills for selecting, converting, formatting,
searching, and manipulating data in C# console applications.

The section now contains five completed instructional modules, one completed
guided project, and twenty-six registered solution projects. The latest project
integrates data conversion, two-dimensional arrays, currency formatting, input
normalization, and case-insensitive string searching in the Contoso PetFriends
application.

[Open the current Section 4 documentation](./curriculum/work-with-variable-data-in-csharp-console-applications/README.md)

---

### Module 1 — Choose the Correct Data Type in Your C# Code

```text
Status: Completed
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Target framework: net10.0
Project registration in solution: Verified
Solution project count after completion: 21
Final organized Program.cs: Completed
Professional source comments: Completed
Local project run: Verified
Project build: Succeeded
Project build time: 0.9 seconds
Full solution build: Succeeded
Full solution build time: 3.5 seconds
IDE diagnostics: No issues found
Completion date: July 31, 2026
```

This module explains how C# represents data and how a developer selects a type
that matches the meaning, range, precision, and interoperability requirements
of an application.

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── choose-correct-data-type/
        ├── Program.cs
        └── choose-correct-data-type.csproj
```

The final source preserves the complete lesson as one runnable console
application. It is divided into ten learning sections:

```text
1. Data represented as bits
2. C# aliases for .NET value types
3. Signed integral types
4. Unsigned integral types
5. Floating-point types
6. Creating reference-type instances
7. Value-type assignment
8. Reference-type assignment
9. Practical data-type choices
10. Boundary and interoperability example
```

Key outcomes include:

- converting decimal values and characters into binary representations;
- relating C# aliases such as `int` to .NET types such as `System.Int32`;
- inspecting numeric `MinValue` and `MaxValue` boundaries;
- comparing signed and unsigned integral types;
- distinguishing numeric range from numeric precision;
- comparing `float`, `double`, and `decimal`;
- demonstrating binary floating-point behavior with `0.1 + 0.2`;
- creating arrays with `new`;
- showing that value-type assignment copies a value;
- showing that reference-type assignment copies a reference;
- selecting types for engineering, financial, temporal, and binary data.

The final engineering examples use:

```csharp
int computationalCellCount = 15_000;

double waterLevelMeters = 1.425;
double salinityPpt = 15.114;
double simulationTimeStepSeconds = 10.0;

decimal projectBudget = 125_000_000.50M;

bool isCourantConditionSatisfied = true;

string monitoringStationName = "Hoa Binh";

DateTime observationTime =
    new DateTime(2026, 7, 31, 18, 0, 0);

TimeSpan simulationDuration =
    TimeSpan.FromDays(30);
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 3.5 seconds
Registered solution projects after completion: 21
Target framework: net10.0
IDE diagnostics: No issues found
Verification date: July 31, 2026
```

---

### Module 2 — Convert Data Types Using Casting and Conversion Techniques in C#

```text
Status: Completed
Microsoft Learn units: 9 / 9
Module assessment: Passed
Achievement: Earned
Target framework: net10.0
Project registration in solution: Verified
Solution project count: 22
Final organized Program.cs: Completed
Professional source comments: Completed
Local project run: Verified
Project build: Succeeded
Project build time: 1.0 seconds
Full solution build: Succeeded
Full solution build time: 4.0 seconds
IDE diagnostics: No issues found
Completion date: August 1, 2026
```

This module explains how to convert values between C# data types while
controlling two principal risks:

```text
Runtime exception risk
Information-loss risk
```

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── convert-data-types/
        ├── Program.cs
        └── convert-data-types.csproj
```

The final application uses focused methods:

```text
Main()
├── WriteApplicationHeader()
├── DemonstrateCompilerConversionRules()
├── DemonstrateWideningConversion()
├── DemonstrateExplicitCasting()
├── DemonstratePrecisionLoss()
├── DemonstrateToString()
├── DemonstrateParse()
├── DemonstrateConvertClass()
├── CompareCastingAndConvert()
├── DemonstrateTryParse()
├── RunMixedStringArrayChallenge()
├── RunSpecificNumberTypeChallenge()
└── WriteModuleSummary()
```

#### Compiler conversion rules

The module documents why this code is invalid:

```csharp
int first = 2;
string second = "4";
int result = first + second;
```

Compiler result:

```text
CS0029:
Cannot implicitly convert type 'string' to 'int'
```

The compiler cannot assume that every string contains valid numeric text. By
contrast, this code is valid:

```csharp
int firstNumber = 2;
string secondText = "4";

string concatenatedResult =
    firstNumber + secondText;
```

Result:

```text
24
```

This is string concatenation rather than numeric addition.

#### Implicit widening conversion

```csharp
int integerValue = 3;
decimal decimalValue = integerValue;
```

The compiler performs this conversion implicitly because `decimal` can represent
every possible `int` value without losing the original whole-number
information.

#### Explicit casting and narrowing conversion

```csharp
decimal decimalValue = 3.14M;
int integerValue = (int)decimalValue;
```

Result:

```text
3
```

The explicit cast communicates that losing the fractional component is
intentional.

#### Precision loss

```csharp
decimal highPrecisionValue = 1.23456789M;

float reducedPrecisionValue =
    (float)highPrecisionValue;
```

Typical result:

```text
decimal : 1.23456789
float   : 1.2345679
```

This demonstrates that narrowing conversion can lose precision even when both
types support fractional values.

#### `ToString()`, `Parse()`, and `Convert`

```csharp
int firstNumber = 5;
int secondNumber = 7;

string message =
    firstNumber.ToString() +
    secondNumber.ToString();
```

Result:

```text
57
```

```csharp
string firstText = "5";
string secondText = "7";

int sum =
    int.Parse(firstText) +
    int.Parse(secondText);
```

Result:

```text
12
```

`Parse()` is appropriate only when text is guaranteed to be valid or conversion
exceptions are intentionally handled.

The .NET `Convert` class provides helper methods such as:

```text
Convert.ToInt32()
Convert.ToDouble()
Convert.ToDecimal()
Convert.ToString()
Convert.ToBoolean()
```

Example:

```csharp
int product =
    Convert.ToInt32("5") *
    Convert.ToInt32("7");
```

Result:

```text
35
```

#### Casting truncates; `Convert.ToInt32()` rounds

```csharp
decimal sourceValue = 1.5M;

int castResult = (int)sourceValue;
int convertedResult =
    Convert.ToInt32(sourceValue);
```

Results:

```text
castResult      : 1
convertedResult : 2
```

An explicit cast truncates the fractional component toward zero.
`Convert.ToInt32()` rounds to the nearest integer.

The final source also records midpoint-to-even behavior:

```text
2.5 → 2
3.5 → 4
```

This is more precise than describing `Convert.ToInt32()` as always rounding up.

#### Safe conversion with `TryParse()`

```csharp
string validText = "102";
int parsedMeasurement;

bool conversionSucceeded =
    int.TryParse(
        validText,
        out parsedMeasurement);
```

`TryParse()`:

```text
Attempts the conversion
Stores the converted value in an out parameter
Returns true or false
```

Successful result:

```text
Measurement: 102
Measurement with offset: 152
```

For invalid text:

```csharp
string invalidText = "bad";

bool succeeded =
    int.TryParse(
        invalidText,
        out int result);
```

Result:

```text
succeeded = false
result    = 0
```

The Boolean return value must be used to determine success because `"0"` is
valid numeric text and also produces the value `0`.

#### Culture-independent numeric processing

The final source uses:

```csharp
CultureInfo.InvariantCulture
```

when stable machine-readable parsing and formatting are required.

This ensures that:

```text
"12.3"
```

uses a period as the decimal separator regardless of local Windows regional
settings.

#### Challenge 1 — classify mixed string values

Starter data:

```csharp
string[] values =
{
    "12.3",
    "45",
    "ABC",
    "11",
    "DEF"
};
```

Business rules:

```text
Numeric value
→ add to total

Non-numeric value
→ append to message
```

Verified output:

```text
Message: ABCDEF
Total: 68.3
```

#### Challenge 2 — produce required numeric result types

Starter values:

```csharp
int value1 = 11;
decimal value2 = 6.2M;
float value3 = 4.3F;
```

Implementation:

```csharp
int result1 =
    Convert.ToInt32(value1 / value2);

decimal result2 =
    value2 / (decimal)value3;

float result3 =
    value3 / value1;
```

Verified output:

```text
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3909091
```

#### Conversion decision guide

| Situation | Preferred technique |
| --- | --- |
| Destination safely represents all source values | Implicit conversion |
| Information may be lost and the loss is intentional | Explicit cast |
| Convert a value to text | `ToString()` |
| Numeric text is guaranteed to be valid | `Parse()` |
| Text may be invalid | `TryParse()` |
| Use a .NET conversion helper | `Convert` |
| Fractional to integer with truncation | Explicit cast |
| Fractional to integer with rounding | `Convert.ToInt32()` |

The final console summary states:

```text
Implicit conversion : use when the destination safely represents the source value.
Explicit cast       : use when information may be lost and that loss is intentional.
ToString()           : convert a value to its textual representation.
Parse()              : use for numeric text known to be valid.
TryParse()           : use for user, file, or external text that may be invalid.
Convert              : use a .NET conversion helper, especially when rounding is required.

Always consider both exception risk and information loss.
```

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\convert-data-types\convert-data-types.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\convert-data-types\convert-data-types.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded in 1.0 seconds
Full solution build: Succeeded in 4.0 seconds
Registered solution projects: 22
Target framework: net10.0
IDE diagnostics: No issues found
Verification date: August 1, 2026
```

---

### Module 3 — Perform Operations on Arrays Using Helper Methods in C#

```text
Status: Completed
Microsoft Learn units: 10 / 10
Microsoft Learn completion page: Displayed
Achievement saved to account: Not verified in signed-out session
Target framework: net10.0
Project registration in solution: Verified
Solution project count: 23
Final organized Program.cs: Completed
Professional source comments: Completed
Local project run: Verified
Project build: Succeeded
Project build time: 0.9 seconds
Full solution build: Succeeded
Full solution build time: 2.2 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 2, 2026
```

This module demonstrates how arrays and strings can be transformed using helper
methods from the .NET class library.

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── array-helper-methods/
        ├── Program.cs
        └── array-helper-methods.csproj
```

The final application uses focused methods:

```text
Main()
├── WriteApplicationHeader()
├── DemonstrateSortAndReverse()
├── DemonstrateClear()
├── DemonstrateNullAfterClear()
├── DemonstrateSafeNullAccess()
├── DemonstrateResizeLargerAndSmaller()
├── DemonstrateRemovingNullElements()
├── DemonstrateToCharArrayAndReverse()
├── DemonstrateJoinAndSplit()
├── RunReverseWordsChallenge()
├── RunOrderValidationChallenge()
└── WriteModuleSummary()
```

#### Sort and reverse arrays

```csharp
string[] pallets =
[
    "B14",
    "A11",
    "B12",
    "A13"
];

Array.Sort(pallets);
Array.Reverse(pallets);
```

`Array.Sort()` sorts the existing array in place. `Array.Reverse()` reverses the
current order; it is not independently a descending sort.

Verified sorted order:

```text
A11
A13
B12
B14
```

Verified reversed order after sorting:

```text
B14
B12
A13
A11
```

#### Clear selected elements

```csharp
string?[] pallets =
[
    "B14",
    "A11",
    "B12",
    "A13"
];

Array.Clear(
    pallets,
    index: 0,
    length: 2);
```

For `string?[]`, cleared elements become `null`. `Array.Clear()` resets values
but does not change `Length`.

```text
Before: ["B14", "A11", "B12", "A13"]
After : [null, null, "B12", "A13"]
Length: 4
```

#### Safe nullable access and `CS8602`

The initial implementation produced:

```text
CS8602:
Dereference of a possibly null reference
```

The final source copies the mutable array element into a local variable before
checking it:

```csharp
string? firstPallet = pallets[0];

if (firstPallet is not null)
{
    Console.WriteLine(
        firstPallet.ToLowerInvariant());
}
```

This gives nullable flow analysis one stable value to track and resolves the
warning without suppressing it.

The source also demonstrates:

```csharp
string display =
    pallets[1]?.ToLowerInvariant() ??
    "<null>";
```

where `?.` performs a null-conditional access and `??` provides a fallback.

#### Resize arrays

```csharp
Array.Resize(
    ref pallets,
    newSize: 6);
```

`Array.Resize()` may allocate a new array and update the caller's variable,
which is why the array variable is passed with `ref`.

Growing the array creates default-valued positions. Shrinking keeps the first
`newSize` elements and removes elements only from the end.

```text
Array.Clear()
→ changes element values

Array.Resize()
→ changes array length
```

`Resize()` does not automatically search for and remove `null` elements.

#### Compact an array

The project demonstrates a manual compaction algorithm:

```text
1. Count non-null elements
2. Allocate a new array with that exact size
3. Copy non-null elements into the new array
```

Example:

```text
Source:
[null, null, "B12", "A13", "C01", "C02"]

Compacted:
["B12", "A13", "C01", "C02"]
```

#### Convert between strings and arrays

```csharp
string value = "abc123";

char[] characters =
    value.ToCharArray();

Array.Reverse(characters);

string reversedValue =
    new(characters);
```

Result:

```text
321cba
```

`string.Join()` combines elements:

```csharp
string commaSeparatedValue =
    string.Join(
        ",",
        characters);
```

Result:

```text
3,2,1,c,b,a
```

`Split()` converts delimited text back to an array:

```csharp
string[] items =
    commaSeparatedValue.Split(',');
```

Core transformations:

```text
ToCharArray()       string → char[]
new string(char[])  char[] → string
Split()             string → string[]
Join()              array  → string
```

#### Challenge 1 — reverse every word

Input:

```text
The quick brown fox jumps over the lazy dog
```

Verified output:

```text
ehT kciuq nworb xof spmuj revo eht yzal god
```

The implementation preserves word order and reverses only the characters inside
each word.

#### Challenge 2 — validate order identifiers

Input:

```csharp
string orderStream =
    "B123,C234,A345,C15,B177,G3003,C235,B179";
```

Processing:

```text
Split by comma
→ sort the identifiers
→ validate the length
→ append "- Error" when length is not four
```

Verified output:

```text
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
```

#### Diagnostic cleanup

The final source addresses:

```text
CS8602 → nullable dereference warning
IDE0300 → collection initialization suggestion
IDE0090 → target-typed new suggestion
```

Classic array initializers were modernized to collection expressions:

```csharp
string[] values =
[
    "A11",
    "B12"
];
```

Explicit constructor syntax was simplified where the target type is known:

```csharp
string reversedValue =
    new(characters);
```

Final diagnostic result:

```text
Compiler errors: 0
Compiler warnings: 0
Visual Studio: No issues found
```

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\array-helper-methods\array-helper-methods.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\array-helper-methods\array-helper-methods.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 2.2 seconds
Registered solution projects: 23
Target framework: net10.0
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 2, 2026
```

---

### Module 4 — Format Alphanumeric Data for Presentation in C#

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Target framework: net10.0
Project registration in solution: Verified
Solution project count: 24
Final organized Program.cs: Completed
Professional source comments: Completed
Corrected module run: Succeeded
Module output: Verified
Corrected project build: Succeeded
Corrected project build time: 1.5 seconds
Full solution build: Succeeded
Full solution build time: 3.1 seconds
Compiler errors after correction: 0
Compiler warnings after correction: 0
IDE diagnostics after correction: No issues found
Resolved compiler error: CS1503
Addressed IDE suggestion: IDE0071
Final module run after correction: Succeeded
Full solution build after correction: Succeeded in 3.1 seconds
Completion date: August 3, 2026
```

This module explains how to convert numeric and textual values into readable,
culture-aware presentation strings without modifying the underlying data.

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── format-alphanumeric-data/
        ├── Program.cs
        └── format-alphanumeric-data.csproj
```

The final application uses focused methods:

```text
Main()
├── WriteApplicationHeader()
├── DemonstrateEscapeSequences()
├── DemonstrateVerbatimStringsAndUnicode()
├── DemonstrateCompositeFormatting()
├── DemonstrateStringInterpolation()
├── DemonstrateCurrencyAndCulture()
├── DemonstrateNumericAndPercentageFormatting()
├── DemonstrateCombinedFormattingApproaches()
├── DemonstrateInterpolatedInvoiceReceipt()
├── DemonstratePaddingAndAlignment()
├── DemonstrateFixedWidthPaymentRecord()
├── RunMarketingLetterChallenge()
└── WriteModuleSummary()
```

#### Escape sequences, verbatim strings, and Unicode

The project demonstrates:

```text
\\n      → new line
\\t      → tab
\\\\      → one backslash
\\"      → quotation mark
\\uXXXX  → Unicode code point
```

Example:

```csharp
Console.WriteLine(
    "Coastal model\nSimulation report");

string repositoryPath =
    @"F:\DarkerThanBack-DKC\My world\Programs\Github\freecodecamp-csharp";

string degreeSymbol = "\u00B0";
string deltaSymbol = "\u0394";
```

Verbatim string literals simplify Windows paths because backslashes remain
ordinary characters. Unicode escape sequences make the intended code point
explicit in source code.

#### Composite formatting

```csharp
string formattedGreeting =
    string.Format(
        CultureInfo.InvariantCulture,
        "{0} {1}!",
        firstWord,
        secondWord);
```

Composite formatting uses numbered replacement tokens:

```text
{0} → first argument
{1} → second argument
```

Tokens can be reordered or reused.

#### Resolved compiler error `CS1503`

The original implementation attempted to pass `CultureInfo.InvariantCulture`
directly to `Console.WriteLine()`:

```csharp
Console.WriteLine(
    CultureInfo.InvariantCulture,
    "{1} {0}!",
    firstWord,
    secondWord);
```

Compiler result:

```text
CS1503:
Argument 1 cannot convert from
System.Globalization.CultureInfo to string
```

`Console.WriteLine()` has no overload whose first parameter is an
`IFormatProvider`.

The corrected implementation formats the value first:

```csharp
Console.WriteLine(
    string.Format(
        CultureInfo.InvariantCulture,
        "{1} {0}!",
        firstWord,
        secondWord));
```

The repeated-token example was corrected in the same way.

Verified corrected project-build evidence:

```text
dotnet clean: Succeeded in 0.5 seconds
Project restore: Completed
Project build: Succeeded in 1.5 seconds
Compiler errors: 0
IDE diagnostics: No issues found
```

#### String interpolation

```csharp
Console.WriteLine(
    $"Station {stationName} measured a water level of " +
    $"{waterLevelMeters} m and salinity of {salinityPpt} ppt.");
```

Interpolation places variable names and expressions directly inside the string
template, often improving readability compared with numbered placeholders.

#### Culture-aware formatting

The application defines explicit cultures:

```csharp
CultureInfo.GetCultureInfo("en-US");
CultureInfo.GetCultureInfo("fr-FR");
CultureInfo.GetCultureInfo("ko-KR");
```

Explicit culture selection makes output stable across machines and regional
settings.

Examples:

```text
en-US → $123.45
fr-FR → 123,45 €
ko-KR → ₩123
```

Culture changes presentation, not the stored numeric value.

#### Numeric format specifiers

| Specifier | Purpose | Example |
| --- | --- | --- |
| `C2` | currency with two decimals | `$123.45` |
| `N0` | grouped number with no decimals | `1,250,000` |
| `N4` | grouped number with four decimals | `123,456.7891` |
| `P2` | percentage with two decimals | `36.79%` |
| `F2` | fixed-point with two decimals | `15.11` |

Formatting produces a string. It does not mutate the original number.

#### Investment receipt

The module produces:

```text
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19
```

The project explicitly uses `en-US` so the educational output remains stable on
a Korean or Vietnamese Windows installation.

#### Padding and alignment

```csharp
string leftPadded =
    input.PadLeft(12);

string rightPadded =
    input.PadRight(12);
```

Interpolation alignment:

```text
{value,positiveWidth} → right-aligned
{value,negativeWidth} → left-aligned
```

Example:

```csharp
Console.WriteLine(
    $"{"Station",-15}" +
    $"{"Water level",12}" +
    $"{"Salinity",12}");
```

The final source also addresses `IDE0071` by avoiding unnecessary interpolation
in the simplest padding-output lines.

#### Fixed-width payment record

The project creates an exact 40-character record:

```text
Columns  1–6  → payment ID
Columns  7–30 → payee name
Columns 31–40 → payment amount
```

Implementation:

```csharp
string formattedLine =
    paymentId.PadRight(6);

formattedLine +=
    payeeName.PadRight(24);

formattedLine +=
    paymentAmount.PadLeft(10);
```

Verification guide:

```text
1234567890123456789012345678901234567890
769C  Mr. Stephen Ortega       $5,000.00
```

#### Challenge — personalized investment marketing letter

The final challenge combines:

```text
String interpolation
Currency formatting
Percentage formatting
Numeric grouping
Paragraph spacing
PadRight()
Composite formatting
Fixed-width comparison columns
```

Principal output:

```text
Dear Ms. Barros,

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.
Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%    $55,000,000.00
Glorious Future     13.13%    $63,000,000.00
```

Run the corrected module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\format-alphanumeric-data\format-alphanumeric-data.csproj"
```

Build the corrected module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\format-alphanumeric-data\format-alphanumeric-data.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Final verified result:

```text
Corrected module run: Succeeded
Module output: Verified
Corrected project build: Succeeded in 1.5 seconds
Full solution build: Succeeded in 3.1 seconds
Registered solution projects: 24
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
```

---

### Module 5 — Modify the Content of Strings Using Built-In String Data Type Methods in C#

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 8 / 8
Module assessment: Passed
Achievement: Earned
Target framework: net10.0
Project registration in solution: Verified
Solution project count: 25
Final organized Program.cs: Completed
Professional source comments: Completed
Module run: Succeeded
Module output: Verified
Project build: Succeeded
Project build time: 0.4 seconds
Full solution build: Succeeded
Full solution build time: 4.0 seconds
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 4, 2026
```

This module explains how to locate, extract, remove, and replace information
inside structured string data.

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── modules/
    └── modify-string-content/
        ├── Program.cs
        └── modify-string-content.csproj
```

The final application preserves the principal Microsoft Learn examples as one
runnable program:

```text
PrintApplicationHeader()
DemonstrateIndexOfAndSubstring()
DemonstrateLastIndexOfAndRepeatedExtraction()
DemonstrateIndexOfAny()
DemonstrateRemoveAndReplace()
CompleteHtmlChallenge()
PrintModuleSummary()
```

#### Locate and extract content

`IndexOf()` returns the zero-based position of the first matching character or
substring. It returns `-1` when the requested value is not found.

```csharp
const string message =
    "Find what is (inside the parentheses)";

int openingPosition =
    message.IndexOf('(');

int closingPosition =
    message.IndexOf(')');
```

`Substring(startIndex, length)` returns the selected portion of the string:

```csharp
int contentStart =
    openingPosition + 1;

int contentLength =
    closingPosition - contentStart;

string content =
    message.Substring(
        contentStart,
        contentLength);
```

Result:

```text
inside the parentheses
```

Adding `1` skips the opening parenthesis. The source documents this boundary
calculation explicitly to prevent an off-by-one error.

#### Avoid magic strings and magic numbers

The HTML-tag example uses constants:

```csharp
const string openSpan = "<span>";
const string closeSpan = "</span>";
```

The extraction offset is calculated from:

```csharp
openSpan.Length
```

instead of a hardcoded number such as `6`.

This keeps the code valid if the tag value changes and allows the compiler to
detect misspelled constant names.

#### Find the final occurrence

`LastIndexOf()` returns the final matching position.

```csharp
int firstHPosition =
    greeting.IndexOf('h');

int lastHPosition =
    greeting.LastIndexOf('h');
```

It is also used to extract the value inside the last parenthesis pair:

```text
set of parentheses
```

#### Extract repeated values

The project repeatedly extracts parenthesized content with a `while` loop.

```text
What if
more than
set of parentheses
```

Each iteration:

```text
1. Finds the next opening delimiter
2. Finds its closing delimiter
3. Extracts the text between them
4. Continues with the unprocessed remainder
```

The implementation checks both search results before calling `Substring()` so
an absent or unmatched delimiter does not create an invalid range.

#### Search for several symbols with `IndexOfAny()`

`IndexOfAny()` receives a `char[]` and returns the first occurrence of any
character in that set.

```csharp
char[] openingSymbols =
[
    '[',
    '{',
    '('
];
```

The completed example matches each opening symbol with the corresponding closing
symbol:

```text
( → )
[ → ]
{ → }
```

Verified output:

```text
What if
different symbols
open symbol
matching closing symbol
```

#### Remove and replace data

`Remove(startIndex, count)` returns a new string without the selected character
range.

The fixed-width-data example removes the twenty-character customer-name field:

```csharp
string dataWithoutCustomerName =
    fixedWidthData.Remove(
        5,
        20);
```

`Replace(oldValue, newValue)` replaces every occurrence of the supplied value.

```csharp
string normalizedMessage =
    hyphenatedMessage.Replace(
        "--",
        " ");

normalizedMessage =
    normalizedMessage.Replace(
        "-",
        string.Empty);
```

Result:

```text
This is example data
```

#### String immutability

`string` is immutable.

```text
IndexOf()
LastIndexOf()
IndexOfAny()
Substring()
Remove()
Replace()
```

do not modify the existing string object. Methods that transform text return a
new string, which must be stored or used by the application.

#### Challenge — extract, replace, and remove HTML data

Input:

```csharp
const string input =
    "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
```

Required processing:

```text
Extract the text inside <span>...</span>
Replace &trade; with &reg;
Remove the opening and closing <div> tags
```

Verified result:

```text
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
```

The final source also checks the required tag positions before calculating
substring boundaries.

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\modify-string-content\modify-string-content.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\modules\modify-string-content\modify-string-content.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded in 0.4 seconds
Full solution build: Succeeded in 4.0 seconds
Registered solution projects: 25
Target framework: net10.0
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 4, 2026
```

---

### Guided Project — Work with Variable Data in C#

```text
Learning status: Completed
Repository verification status: Fully verified
Microsoft Learn units: 7 / 7
Application: Contoso PetFriends
Target framework: net10.0
Project registration in solution: Verified
Solution project count: 26
Final organized Program.cs: Completed
Professional source comments: Completed
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Application run: Succeeded
Application startup and normal exit: Verified
Project build: Succeeded
Full solution build: Succeeded
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Completion date: August 5, 2026
```

This guided project integrates the five preceding Section 4 modules into a
single interactive console application.

Project location:

```text
curriculum/work-with-variable-data-in-csharp-console-applications/
└── guided-projects/
    └── contoso-petfriends/
        ├── Program.cs
        └── contoso-petfriends.csproj
```

The completed project extends the starter application with two required
features:

```text
1. Add and display a suggested donation for every populated pet record
2. Search dogs by a requested physical or personality characteristic
```

The application expands the two-dimensional pet-data array from six to seven
fields:

```csharp
const int MaxPets = 8;
const int PetFieldCount = 7;

string[,] ourAnimals =
    new string[MaxPets, PetFieldCount];
```

Named constants replace unexplained numeric field indexes:

```csharp
const int IdIndex = 0;
const int SpeciesIndex = 1;
const int AgeIndex = 2;
const int NicknameIndex = 3;
const int PhysicalDescriptionIndex = 4;
const int PersonalityDescriptionIndex = 5;
const int SuggestedDonationIndex = 6;
```

Suggested-donation text is converted safely:

```csharp
bool donationWasParsed =
    decimal.TryParse(
        suggestedDonation,
        NumberStyles.Number,
        CultureInfo.InvariantCulture,
        out decimal decimalDonation);
```

Missing or invalid data receives a defined fallback:

```csharp
const decimal DefaultSuggestedDonation =
    45.00M;
```

The project uses an explicit display culture so its educational currency output
remains stable on Korean, Vietnamese, and other Windows regional settings:

```csharp
CultureInfo currencyCulture =
    CultureInfo.GetCultureInfo("en-US");
```

Example values:

```text
85.00  → $85.00
49.99  → $49.99
40.00  → $40.00
invalid → $45.00
```

The dog-search workflow:

- validates a non-empty characteristic;
- skips non-dog records;
- combines physical and personality descriptions;
- searches with `StringComparison.OrdinalIgnoreCase`;
- removes the stored nickname label with
  `Substring(NicknameLabel.Length)`;
- reports every matching dog;
- displays a no-match message when appropriate.

Examples:

```text
cream  → lola
kisses → lola
hugs   → gus
```

The final source also normalizes menu input with `Trim()` and
`ToLowerInvariant()`, handles `Console.ReadLine()` returning `null`, reports
invalid selections, and treats `Console.Clear()` as an optional presentation
operation.

Run the completed guided project:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\guided-projects\contoso-petfriends\contoso-petfriends.csproj"
```

Build the guided project:

```powershell
dotnet build `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\guided-projects\contoso-petfriends\contoso-petfriends.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified repository evidence:

```text
Application launch: Succeeded
Menu display: Verified
Normal exit with "exit": Verified
Suggested-donation implementation: Present
Dog-search implementation: Present
Project registration: Verified
Registered solution projects: 26
Project build: Succeeded
Full solution build: Succeeded
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Verification date: August 5, 2026
```

---

### Next Curriculum Item — Challenge Project — Work with Variable Data in C#

```text
Status: Not started
Current Section 4 learning progress: 6 / 7
Current repository-verified progress: 6 / 7
Current solution baseline: 26 projects
```

The final Section 4 item will independently apply data selection, conversion,
array processing, formatting, and string-manipulation requirements.

The challenge project must be registered in `freecodecamp-csharp.slnx`, run
successfully, build independently, preserve a passing full-solution build, and
complete the Section 4 documentation and Trophy workflow.
---

## Repository Structure

```text
freecodecamp-csharp/
├── curriculum/
│   ├── write-your-first-code-using-csharp/
│   │   ├── README.md
│   │   ├── modules/
│   │   ├── guided-projects/
│   │   │   ├── calculate-student-grades/
│   │   │   └── calculate-final-gpa/
│   │   └── trophy/
│   │       ├── README.md
│   │       └── assets/
│   ├── create-and-run-simple-csharp-console-applications/
│   │   ├── README.md
│   │   ├── modules/
│   │   ├── guided-projects/
│   │   │   └── student-grading-application/
│   │   ├── challenge-projects/
│   │   │   └── student-grading-challenge/
│   │   └── trophy/
│   │       ├── README.md
│   │       └── assets/
│   ├── add-logic-to-csharp-console-applications/
│   │   ├── README.md
│   │   ├── modules/
│   │   │   ├── evaluate-boolean-expressions/
│   │   │   ├── code-blocks-variable-scope/
│   │   │   ├── switch-case-construct/
│   │   │   ├── for-statement/
│   │   │   └── do-while-and-while-statements/
│   │   ├── guided-projects/
│   │   │   └── contoso-pets/
│   │   │       ├── Program.cs
│   │   │       └── contoso-pets.csproj
│   │   ├── challenge-projects/
│   │   │   └── contoso-pets-challenge/
│   │   │       ├── Program.cs
│   │   │       └── contoso-pets-challenge.csproj
│   │   └── trophy/
│   │       ├── README.md
│   │       └── assets/
│   │           ├── 1.PNG
│   │           └── 2.PNG
│   ├── work-with-variable-data-in-csharp-console-applications/
│   │   ├── README.md
│   │   ├── modules/
│   │   │   ├── choose-correct-data-type/
│   │   │   │   ├── Program.cs
│   │   │   │   └── choose-correct-data-type.csproj
│   │   │   ├── convert-data-types/
│   │   │   │   ├── Program.cs
│   │   │   │   └── convert-data-types.csproj
│   │   │   ├── array-helper-methods/
│   │   │   │   ├── Program.cs
│   │   │   │   └── array-helper-methods.csproj
│   │   │   ├── format-alphanumeric-data/
│   │   │   │   ├── Program.cs
│   │   │   │   └── format-alphanumeric-data.csproj
│   │   │   └── modify-string-content/
│   │   │       ├── Program.cs
│   │   │       └── modify-string-content.csproj
│   │   └── guided-projects/
│   │       └── contoso-petfriends/
│   │           ├── Program.cs
│   │           └── contoso-petfriends.csproj
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
- `guided-projects/` for guided applied projects;
- `challenge-projects/` for independently completed challenge projects;
- `trophy/README.md` for section-completion documentation;
- `trophy/assets/` for official certificate and Trophy evidence;
- project-specific source files and notes.

Section 4 currently contains five completed module projects and one completed
guided project, all fully repository-verified. Its `trophy/` directory will
be added after the final challenge project and official completion evidence
have been completed.

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

Projects currently registered:

```text
26
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

### Completed projects from Section 2

```text
curriculum/create-and-run-simple-csharp-console-applications/modules/install-and-configure-visual-studio-code/install-and-configure-visual-studio-code.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/call-methods/call-methods.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/decision-logic/decision-logic.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/arrays-foreach/arrays-foreach.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/readable-code/readable-code.csproj

curriculum/create-and-run-simple-csharp-console-applications/guided-projects/student-grading-application/student-grading-application.csproj

curriculum/create-and-run-simple-csharp-console-applications/challenge-projects/student-grading-challenge/student-grading-challenge.csproj
```


### Projects from Section 3

```text
curriculum/add-logic-to-csharp-console-applications/modules/evaluate-boolean-expressions/evaluate-boolean-expressions.csproj

curriculum/add-logic-to-csharp-console-applications/modules/code-blocks-variable-scope/code-blocks-variable-scope.csproj

curriculum/add-logic-to-csharp-console-applications/modules/switch-case-construct/switch-case-construct.csproj

curriculum/add-logic-to-csharp-console-applications/modules/for-statement/for-statement.csproj

curriculum/add-logic-to-csharp-console-applications/modules/do-while-and-while-statements/do-while-and-while-statements.csproj

curriculum/add-logic-to-csharp-console-applications/guided-projects/contoso-pets/contoso-pets.csproj

curriculum/add-logic-to-csharp-console-applications/challenge-projects/contoso-pets-challenge/contoso-pets-challenge.csproj
```

### Projects from Section 4

```text
curriculum/work-with-variable-data-in-csharp-console-applications/modules/choose-correct-data-type/choose-correct-data-type.csproj

curriculum/work-with-variable-data-in-csharp-console-applications/modules/convert-data-types/convert-data-types.csproj

curriculum/work-with-variable-data-in-csharp-console-applications/modules/array-helper-methods/array-helper-methods.csproj

curriculum/work-with-variable-data-in-csharp-console-applications/modules/format-alphanumeric-data/format-alphanumeric-data.csproj

curriculum/work-with-variable-data-in-csharp-console-applications/modules/modify-string-content/modify-string-content.csproj

curriculum/work-with-variable-data-in-csharp-console-applications/guided-projects/contoso-petfriends/contoso-petfriends.csproj
```

Run the latest completed learning project from the repository root:

```powershell
dotnet run --project `
  ".\curriculum\work-with-variable-data-in-csharp-console-applications\guided-projects\contoso-petfriends\contoso-petfriends.csproj"
```

---



## Latest Repository Verification

```text
Latest fully completed section: Add Logic to C# Console Applications
Latest fully completed section progress: 7 / 7
Current section: Work with Variable Data in C# Console Applications
Current section learning progress: 6 / 7
Current section repository-verified progress: 6 / 7
Latest completed learning item: Guided Project — Work with Variable Data in C#
Latest project: contoso-petfriends
Microsoft Learn units: 7 / 7
Application: Contoso PetFriends
Final organized source: Completed
Professional source comments: Completed
Project registration: Verified
Registered solution projects: 26
Suggested-donation feature: Implemented
Dog-characteristic search: Implemented
Application run: Succeeded
Application startup and normal exit: Verified
Project build: Succeeded
Compiler errors: 0
Compiler warnings: 0
IDE diagnostics: No issues found
Full-solution build: Succeeded
Verification date: August 5, 2026
```

The latest evidence confirms that:

- `contoso-petfriends` is registered as the twenty-sixth solution project;
- the guided project has reached `7 / 7` Microsoft Learn units;
- the final source is organized and professionally commented;
- the pet-data table contains seven fields;
- donation text is converted with `decimal.TryParse()`;
- invalid donation data receives the defined `$45.00` fallback;
- currency output uses an explicit `en-US` culture;
- menu option `1` displays the new Suggested Donation field;
- menu option `2` searches dog physical and personality descriptions;
- text matching uses `StringComparison.OrdinalIgnoreCase`;
- empty and whitespace-only search terms are rejected;
- menu input is null-safe and normalized;
- the application starts successfully and exits normally with `exit`;
- the guided-project build succeeds;
- the complete twenty-six-project solution build succeeds;
- the project has zero compiler errors and zero compiler warnings;
- Visual Studio reports no issues.

The guided project is therefore fully repository-verified. Section 4 now stands
at `6 / 7`; only the final challenge project remains.

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
- [Microsoft Learn — Get Started with C#, Part 3](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-3/)
- [Microsoft Learn — Get Started with C#, Part 4](https://learn.microsoft.com/training/paths/get-started-c-sharp-part-4/)
- [Microsoft Learn — Choose the Correct Data Type in Your C# Code](https://learn.microsoft.com/training/modules/csharp-choose-data-type/)
- [Microsoft Learn — Convert Data Types Using Casting and Conversion Techniques in C#](https://learn.microsoft.com/training/modules/csharp-convert-cast/)
- [Microsoft Learn — Perform Operations on Arrays Using Helper Methods in C#](https://learn.microsoft.com/training/modules/csharp-arrays-operations/)
- [Microsoft Learn — Format Alphanumeric Data for Presentation in C#](https://learn.microsoft.com/training/modules/csharp-format-strings/)
- [Microsoft Learn — Modify the Content of Strings Using Built-In String Data Type Methods in C#](https://learn.microsoft.com/training/modules/csharp-modify-content/)
- [Microsoft Learn — Guided Project: Work with Variable Data in C#](https://learn.microsoft.com/training/modules/guided-project-work-variable-data-c-sharp/)

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)