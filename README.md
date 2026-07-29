# freeCodeCamp C# Learning Repository

![C#](https://img.shields.io/badge/C%23-Learning-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Curriculum-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Sections](https://img.shields.io/badge/Sections_Completed-2%2F7-16A34A)
![Projects](https://img.shields.io/badge/Solution_Projects-19-2563EB)
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
Curriculum sections completed: 2 / 7
Current section: Add Logic to C# Console Applications
Current section status: In progress
Current section progress: 6 / 7
Completed instructional modules in current section: 5
Completed guided projects in current section: 1
Completed challenge projects in current section: 0
Latest completed item: Guided Project - Develop Conditional Branching and Looping Structures in C#
Latest application: Contoso Pets
Latest item status: Completed
Latest item assessment: Passed
Latest achievement: Earned
Latest completion date: July 29, 2026
Projects currently verified in solution: 19
Latest organized source: Completed
Latest project run: Verified
Latest project build: Verified
Latest project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 8.1 seconds
```

| No. | Curriculum section | Progress | Status |
| ---: | --- | --- | --- |
| 1 | Write Your First Code Using C# | 7 / 7 | Completed |
| 2 | Create and Run Simple C# Console Applications | 7 / 7 | Completed |
| 3 | Add Logic to C# Console Applications | 6 / 7 | In progress |
| 4 | Work with Variable Data in C# Console Applications | Not started | Pending |
| 5 | Create Methods in C# Console Applications | Not started | Pending |
| 6 | Debug C# Console Applications | Not started | Pending |
| 7 | Foundational C# with Microsoft Certification Exam | Not started | Pending |

A curriculum item is marked `Completed` in this repository only after its official
units, assessment, achievement, local run, project registration, and full-solution
build have all been verified.

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

## Current Section

### 3. Add Logic to C# Console Applications

```text
Status: In progress
Progress: 6 / 7
Completed instructional modules: 5
Completed guided projects: 1
Completed challenge projects: 0
Latest completed item: Guided Project - Develop Conditional Branching and Looping Structures in C#
Application: Contoso Pets
Item assessment: Passed
Achievement: Earned
Project registration: Verified
Solution project count: 19
Final organized Program.cs: Completed
Local project run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 8.1 seconds
Latest completion date: July 29, 2026
```

Section 3 develops Boolean evaluation, branching, iteration, and progressively
more structured control flow in C# console applications.

[Open the Section 3 documentation](./curriculum/add-logic-to-csharp-console-applications/README.md)

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
│   │   │   ├── install-and-configure-visual-studio-code/
│   │   │   │   ├── Program.cs
│   │   │   │   └── install-and-configure-visual-studio-code.csproj
│   │   │   ├── call-methods/
│   │   │   │   ├── Program.cs
│   │   │   │   └── call-methods.csproj
│   │   │   ├── decision-logic/
│   │   │   │   ├── Program.cs
│   │   │   │   └── decision-logic.csproj
│   │   │   ├── arrays-foreach/
│   │   │   │   ├── Program.cs
│   │   │   │   └── arrays-foreach.csproj
│   │   │   └── readable-code/
│   │   │       ├── Program.cs
│   │   │       └── readable-code.csproj
│   │   ├── guided-projects/
│   │   │   └── student-grading-application/
│   │   │       ├── Program.cs
│   │   │       └── student-grading-application.csproj
│   │   ├── challenge-projects/
│   │   │   └── student-grading-challenge/
│   │   │       ├── Program.cs
│   │   │       └── student-grading-challenge.csproj
│   │   └── trophy/
│   │       ├── README.md
│   │       └── assets/
│   │           ├── freecodecamp-section2-completion.png
│   │           └── microsoft-learn-section2-achievement.png
│   ├── add-logic-to-csharp-console-applications/
│   │   ├── README.md
│   │   ├── modules/
│   │   │   ├── evaluate-boolean-expressions/
│   │   │   │   ├── Program.cs
│   │   │   │   └── evaluate-boolean-expressions.csproj
│   │   │   ├── code-blocks-variable-scope/
│   │   │   │   ├── Program.cs
│   │   │   │   └── code-blocks-variable-scope.csproj
│   │   │   ├── switch-case-construct/
│   │   │   │   ├── Program.cs
│   │   │   │   └── switch-case-construct.csproj
│   │   │   ├── for-statement/
│   │   │   │   ├── Program.cs
│   │   │   │   └── for-statement.csproj
│   │   │   └── do-while-and-while-statements/
│   │   │       ├── Program.cs
│   │   │       └── do-while-and-while-statements.csproj
│   │   └── guided-projects/
│   │       └── contoso-pets/
│   │           ├── Program.cs
│   │           └── contoso-pets.csproj
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
- `guided-projects/` for guided applied projects;
- `challenge-projects/` for independently completed challenge projects;
- `trophy/` for completion and achievement evidence;
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
19
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
```

Run the latest completed project from the repository root:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\guided-projects\contoso-pets\contoso-pets.csproj"
```

---


## Latest Repository Verification

```text
Latest completed item: Guided Project - Develop Conditional Branching and Looping Structures in C#
Application: Contoso Pets
Module assessment: Passed
Achievement: Earned
Final organized source: Completed
Project registration: Verified
Registered solution projects: 19
Application launch: Succeeded
Menu display: Verified
Exit handling: Verified
Latest project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 8.1 seconds
Verification date: July 29, 2026
```

The latest terminal verification confirms that:

- `contoso-pets` launched successfully;
- the complete eight-option Contoso PetFriends menu was displayed;
- entering `exit` terminated the application normally;
- the guided-project source compiled successfully in 0.9 seconds;
- the complete nineteen-project solution compiled successfully in 8.1 seconds;
- the repository remained buildable after the guided project was registered.

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

---

## Author

**Duong Kim Cuong**

GitHub: [kcduong994](https://github.com/kcduong994)