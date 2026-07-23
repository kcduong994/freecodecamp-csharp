freeCodeCamp C# Learning Repository



This repository documents my progress through theFoundational C# with Microsoft Certification curriculum delivered throughfreeCodeCamp and Microsoft Learn.

It is maintained as a structured learning curriculum containing:

Microsoft Learn modules;

C# console applications;

guided projects;

section Trophy evidence;

independently written technical notes;

buildable source code;

progress and completion records.

Current Progress

Certification status: In progress
Curriculum sections completed: 2 / 7
Current section: Add Logic to C# Console Applications
Current section status: Not started
Latest completed section: Create and Run Simple C# Console Applications
Latest completed section progress: 7 / 7
Completed instructional modules in latest section: 5
Completed guided projects in latest section: 1
Completed challenge projects in latest section: 1
Latest completed item: Challenge Project — Develop foreach and if-elseif-else Structures to Process Array Data in C#
Latest item status: Completed
Latest item assessment: Passed
Latest achievement: Earned
Latest completion date: July 23, 2026
Projects currently verified in solution: 13
Repository validation: Verified

No.

Curriculum section

Progress

Status

1

Write Your First Code Using C#

7 / 7

Completed

2

Create and Run Simple C# Console Applications

7 / 7

Completed

3

Add Logic to C# Console Applications

Not started

Pending

4

Work with Variable Data in C# Console Applications

Not started

Pending

5

Create Methods in C# Console Applications

Not started

Pending

6

Debug C# Console Applications

Not started

Pending

7

Foundational C# with Microsoft Certification Exam

Not started

Pending

A curriculum item is marked Completed in this repository only after its officialunits, assessment, achievement, local run, project registration, and full-solutionbuild have all been verified.

Completed Section

1. Write Your First Code Using C#

Status: Completed
Progress: 7 / 7
Instructional modules: 4
Guided projects: 2
Trophy: Verified
Completion date: July 17, 2026

This section covers:

basic C# syntax;

console output;

literals and variables;

foundational data types;

string formatting;

arithmetic operators;

integer and decimal division;

explicit casting;

compound assignment;

student-grade calculations;

weighted GPA calculations;

formatted console reports.

Open the complete section documentation

View Trophy achievement and verification evidence

Completed Section

2. Create and Run Simple C# Console Applications

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

Open the completed section documentation

View Section 2 Trophy and achievement evidence

Module 1 — Install and Configure Visual Studio Code

Status: Completed
Module assessment: Passed
Achievement: Earned
Completion date: July 17, 2026

This module focuses on the development environment and the basic .NET CLIworkflow rather than introducing substantial new C# syntax.

Learning outcomes include:

understanding the role of a programming environment;

verifying Visual Studio Code;

verifying the installed .NET SDK;

understanding the difference between the .NET SDK and .NET Runtime;

creating a console application with the .NET CLI;

building a C# project;

running a C# project;

understanding the generated Program.cs and .csproj files;

understanding where compiled binaries are created;

adding a project to a solution.

Key commands introduced:

Command

Purpose

code --version

Displays the installed Visual Studio Code version

dotnet --version

Displays the active .NET SDK version

dotnet --list-sdks

Lists installed .NET SDK versions

dotnet new console

Creates a new console application

dotnet build

Restores and compiles a project

dotnet run

Builds when necessary and runs a project

dotnet sln list

Lists projects registered in a solution

dotnet sln add

Adds a project to a solution

Verified local environment:

Visual Studio Code: 1.129.0
.NET SDK: 10.0.302
Operating system: Windows
Primary repository IDE: Visual Studio

Project:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── install-and-configure-visual-studio-code/
        ├── Program.cs
        └── install-and-configure-visual-studio-code.csproj

Module 2 — Call Methods from the .NET Class Library Using C#

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 18, 2026

This module introduces reusable functionality from the .NET Class Library andexplains how C# applications call methods supplied by .NET.

Learning outcomes include:

understanding the purpose of the .NET Class Library;

calling static methods;

creating objects and calling instance methods;

using the new operator;

working with return values;

distinguishing parameters from arguments;

using overloaded methods;

inspecting methods with IntelliSense;

consulting Microsoft Learn documentation;

using Random.Next();

completing the Math.Max() challenge.

Project location:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── call-methods/
        ├── Program.cs
        └── call-methods.csproj

The shorter project and directory name are used for repository convenience. Theofficial Microsoft Learn module title remains fully documented in the sectionREADME.

The project runs locally, is registered in the solution, and has been verifiedthrough the full-solution build.

Module 3 — Add Decision Logic to Your Code Using if, else, and else if Statements in C#

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 19, 2026

This module introduces decision-making logic that changes the execution path ofa C# application by evaluating Boolean expressions.

Learning outcomes include:

creating branches with if, else if, and else;

building Boolean expressions;

comparing values with equality and relational operators;

combining conditions with logical AND (&&) and logical OR (||);

nesting code blocks;

creating mutually exclusive branches;

ordering conditions according to business-rule precedence;

preventing overlapping rewards and duplicate messages;

applying decision logic to a dice game;

implementing a subscription-renewal challenge.

Project location:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── decision-logic/
        ├── Program.cs
        └── decision-logic.csproj

The project has been added to freecodecamp-csharp.slnx, bringing the solutionto nine registered projects.

The earlier CS0168 warnings were corrected, the module project ransuccessfully, and the complete solution build succeeded.

Module 4 — Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 20, 2026

This module introduces arrays and sequence iteration in C#.

Learning outcomes include:

declaring and initializing arrays;

storing related values of the same data type;

accessing elements with zero-based indexes;

reassigning array elements;

using the Length property;

iterating through arrays with foreach;

calculating a running total;

combining foreach with if;

filtering strings with String.StartsWith().

Project location:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── arrays-foreach/
        ├── Program.cs
        └── arrays-foreach.csproj

The project has been added to freecodecamp-csharp.slnx, bringing the solutionto ten registered projects. The project run and full-solution build have beenverified successfully.

Module 5 — Create Readable Code with Conventions, Whitespace, and Comments in C#

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 21, 2026

This module focuses on expressing program intent clearly so that source code iseasier to read, review, update, debug, and maintain.

Learning outcomes include:

following C# identifier rules;

applying camelCase to local variables;

choosing descriptive names that communicate purpose and intent;

avoiding unclear abbreviations and obsolete type-prefix naming styles;

distinguishing compiler-enforced rules from community conventions;

using single-line and block comments;

temporarily excluding code from compilation while testing changes;

writing comments that explain higher-level purpose rather than obvious syntax;

using blank lines to group related statements;

placing braces on separate lines;

indenting nested blocks to communicate ownership;

refactoring poorly formatted code into a readable implementation.

The final challenge reverses a message and counts occurrences of the lettero. The repository implementation uses explicit names such asoriginalMessage, messageCharacters, letterOCount, and reversedMessageinstead of ambiguous names such as str, x, and new_message.

Project location:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── readable-code/
        ├── Program.cs
        └── readable-code.csproj

The project has been added to freecodecamp-csharp.slnx, bringing the solutionto eleven registered projects. The module assessment was passed, the localproject ran successfully, and the complete solution build succeeded.

Guided Project 1 — Develop foreach and if-else if-else Structures to Process Array Data in C#

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project registration in solution: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 22, 2026

This guided project integrates the concepts introduced throughout the currentsection into a complete Student Grading Application.

The application:

stores student names in a string[] array;

stores assignment scores in separate int[] arrays;

uses an outer foreach loop to process students;

uses if-else if-else to select the current student's score array;

uses an inner foreach loop to process assignment scores;

distinguishes regular exams from extra-credit assignments;

applies a 10% weighting factor to extra-credit scores;

calculates a final numeric grade with decimal;

assigns a letter grade automatically;

writes an aligned grading report to the console;

supports additional students with limited changes to the existing structure.

Project rules:

Regular exam assignments: 5
Exam score range: 0–100
Extra-credit weighting: 10%
Final numeric grade:
    (exam total + weighted extra-credit points)
    / number of exam assignments

The grade thresholds are evaluated from highest to lowest:

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

Project location:

curriculum/create-and-run-simple-csharp-console-applications/
└── guided-projects/
    └── student-grading-application/
        ├── Program.cs
        └── student-grading-application.csproj

The repository implementation improves the instructional version by:

using descriptive variable names;

declaring fixed grading rules with const;

removing unused using directives;

using braces consistently;

preventing unknown students from reusing a previous score array;

resetting counters and totals inside the outer loop;

formatting stable output columns with interpolated-string alignment;

retaining comments that explain purpose and constraints rather than obvioussyntax.

Verified output:

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

The project has been added to freecodecamp-csharp.slnx, bringing the solutionto twelve registered projects. The Microsoft Learn assessment was passed, theachievement was earned, the local project ran successfully, and the completesolution build was verified.

Challenge Project 1 — Develop foreach and if-else if-else Structures to Process Array Data in C#

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

This challenge project extends the Student Grading Application by separating theregular exam average from the weighted contribution of extra-credit work.

The updated report includes:

the student's name;

average exam score;

overall numeric grade;

automatically assigned letter grade;

average extra-credit score;

weighted extra-credit points added to the final grade.

Project location:

curriculum/create-and-run-simple-csharp-console-applications/
└── challenge-projects/
    └── student-grading-challenge/
        ├── Program.cs
        └── student-grading-challenge.csproj

The challenge demonstrates:

revising an existing application from a feature specification;

preserving the nested foreach and if-else if-else structure;

separating exam and extra-credit totals;

guarding decimal calculations;

applying a 10% extra-credit weighting factor;

formatting a detailed grading report;

refactoring instructional code for readability and reliability.

Expected report values:

Student         Exam Score    Overall Grade    Letter            Extra Credit
-----------------------------------------------------------------------------
Sophia                92.2            95.88         A              92 (3.68 pts)
Andrew                89.6            91.38        A-              89 (1.78 pts)
Emma                  85.6            90.94        A-              89 (5.34 pts)
Logan                 91.2            93.12         A              96 (1.92 pts)

The official challenge assessment was passed, the achievement was earned,the project ran with the expected grading report, and the completethirteen-project solution build succeeded.

Section 2 Trophy and Achievement

The section completion evidence is stored under:

curriculum/create-and-run-simple-csharp-console-applications/
└── trophy/
    ├── README.md
    └── assets/
        ├── freecodecamp-section2-completion.png
        └── microsoft-learn-section2-achievement.png

The evidence confirms:

freeCodeCamp completion of Create and Run Simple C# Console Applications;

Microsoft Learn achievement forCreate and run simple C# console applications (Get started with C#, Part 2);

completion date: July 23, 2026.

View Section 2 Trophy documentation

Section 2 Repository Verification

Challenge project run: Verified
Challenge project output: Verified
Challenge project build: Verified
Full solution build: Verified
Registered solution projects: 13
Verification date: July 23, 2026

The terminal output confirms that student-grading-challenge produced theexpected report and that all thirteen solution projects compiled successfully.

Current Section

3. Add Logic to C# Console Applications

Status: Not started
Progress: 0
Previous section: Create and Run Simple C# Console Applications
Previous section completion date: July 23, 2026

Section 2 repository validation is complete. Section 3 can begin after theverified Section 2 changes are reviewed, committed, and pushed.

Open the Section 3 directory

Repository Structure

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
│   ├── work-with-variable-data-in-csharp-console-applications/
│   ├── create-methods-in-csharp-console-applications/
│   ├── debug-csharp-console-applications/
│   └── foundational-csharp-with-microsoft-certification-exam/
├── CSHARP_REVIEW.md
├── freecodecamp-csharp.slnx
├── .gitignore
└── README.md

Each curriculum section may contain:

README.md for section-level curriculum documentation;

modules/ for Microsoft Learn instructional projects;

guided-projects/ for guided applied projects;

challenge-projects/ for independently completed challenge projects;

trophy/ for completion and achievement evidence;

project-specific source files and notes.

Development Environment

Visual Studio

Visual Studio Code

C#

.NET 10

Windows

Developer PowerShell

Git

GitHub

Visual Studio is the primary repository IDE. Visual Studio Code is also usedwhen a Microsoft Learn module specifically teaches the VS Code workflow.

Solution

Solution file:

freecodecamp-csharp.slnx

Projects currently verified as registered:

13

List all projects registered in the solution:

dotnet sln .\freecodecamp-csharp.slnx list

Restore dependencies:

dotnet restore .\freecodecamp-csharp.slnx

Build all projects:

dotnet build .\freecodecamp-csharp.slnx

Expected result:

Build succeeded.
0 Warning(s)
0 Error(s)

The full solution must build successfully before curriculum changes arecommitted.

Solution Projects

Completed projects from Section 1

The completed first section contributes six executable projects:

curriculum/write-your-first-code-using-csharp/modules/first-csharp-code/first-csharp-code.csproj

curriculum/write-your-first-code-using-csharp/modules/literals-and-variables/literals-and-variables.csproj

curriculum/write-your-first-code-using-csharp/modules/string-formatting/string-formatting.csproj

curriculum/write-your-first-code-using-csharp/modules/number-operations/number-operations.csproj

curriculum/write-your-first-code-using-csharp/guided-projects/calculate-student-grades/calculate-student-grades.csproj

curriculum/write-your-first-code-using-csharp/guided-projects/calculate-final-gpa/calculate-final-gpa.csproj

Completed projects from Section 2

curriculum/create-and-run-simple-csharp-console-applications/modules/install-and-configure-visual-studio-code/install-and-configure-visual-studio-code.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/call-methods/call-methods.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/decision-logic/decision-logic.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/arrays-foreach/arrays-foreach.csproj

curriculum/create-and-run-simple-csharp-console-applications/modules/readable-code/readable-code.csproj

curriculum/create-and-run-simple-csharp-console-applications/guided-projects/student-grading-application/student-grading-application.csproj

curriculum/create-and-run-simple-csharp-console-applications/challenge-projects/student-grading-challenge/student-grading-challenge.csproj

Run the latest completed challenge project from the repository root:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\challenge-projects\student-grading-challenge\student-grading-challenge.csproj"

Review Notes

Independent review notes are maintained in:

CSHARP_REVIEW.md

These notes may include:

syntax summaries;

compiler errors;

invalid examples used for learning;

corrected code;

implementation reasoning;

comparisons between beginner and later refactored solutions.

Documentation Standard

A curriculum item is considered complete in this repository only when:

the official lesson units have been completed;

the associated assessment has been passed;

the achievement has been earned when applicable;

the local project runs successfully;

the project is included in the solution when applicable;

the full solution builds without errors;

section documentation has been updated;

progress in this root README has been updated;

relevant evidence has been stored;

the Git diff has been reviewed before commit.

This structure keeps the repository useful for:

certification preparation;

long-term review;

relearning;

debugging practice;

portfolio evidence;

progressive refactoring;

tracking conceptual development.

Curriculum Sources

freeCodeCamp — Foundational C# with Microsoft

Microsoft Learn — Get Started with C#, Part 1

Microsoft Learn — Get Started with C#, Part 2

Author

Duong Kim Cuong

GitHub: kcduong994