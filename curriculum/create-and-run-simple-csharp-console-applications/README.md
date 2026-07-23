Create and Run Simple C# Console Applications



This directory documents the second section of theFoundational C# with Microsoft Certification curriculum delivered throughfreeCodeCamp and Microsoft Learn.

The section focuses on creating, building, running, and progressively structuringC# console applications with the .NET SDK and development tools.

← Back to the repository overview

← Review the completed first section

Section Status

Section: Create and Run Simple C# Console Applications
Status: Completed
Completed curriculum items: 7 / 7
Completed instructional modules: 5
Completed guided projects: 1
Completed challenge projects: 1
Latest completed item: Challenge Project — Develop foreach and if-elseif-else Structures to Process Array Data in C#
Latest item assessment: Passed
Latest achievement: Earned
Section Trophy: Earned
Microsoft Learn achievement: Earned
Section completion date: July 23, 2026
Repository validation: Verified

No.

Module

Status

1

Install and Configure Visual Studio Code

Completed

2

Call Methods from the .NET Class Library Using C#

Completed

3

Add Decision Logic to Your Code Using if, else, and else if Statements in C#

Completed

4

Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#

Completed

5

Create Readable Code with Conventions, Whitespace, and Comments in C#

Completed

6

Guided Project — Develop foreach and if-else if-else Structures to Process Array Data in C#

Completed

7

Challenge Project — Develop foreach and if-else if-else Structures to Process Array Data in C#

Completed

A curriculum item is marked Completed only after its Microsoft Learn units,assessment, achievement, local run, project registration, project build, andfull-solution build have all been verified.

Section Structure

create-and-run-simple-csharp-console-applications/
├── README.md
├── modules/
│   ├── install-and-configure-visual-studio-code/
│   │   ├── Program.cs
│   │   └── install-and-configure-visual-studio-code.csproj
│   ├── call-methods/
│   │   ├── Program.cs
│   │   └── call-methods.csproj
│   ├── decision-logic/
│   │   ├── Program.cs
│   │   └── decision-logic.csproj
│   ├── arrays-foreach/
│   │   ├── Program.cs
│   │   └── arrays-foreach.csproj
│   └── readable-code/
│       ├── Program.cs
│       └── readable-code.csproj
├── guided-projects/
│   └── student-grading-application/
│       ├── Program.cs
│       └── student-grading-application.csproj
├── challenge-projects/
│   └── student-grading-challenge/
│       ├── Program.cs
│       └── student-grading-challenge.csproj
└── trophy/
    ├── README.md
    └── assets/
        ├── freecodecamp-section2-completion.png
        └── microsoft-learn-section2-achievement.png

This section uses one central README.md for all module notes. Individual moduledirectories contain source code and project files without separate README files.

Module 1 — Install and Configure Visual Studio Code

Completion Status

Status: Completed
Module assessment: Passed
Achievement: Earned
Completion date: July 17, 2026

The module introduces the development environment and the basic command-lineworkflow used to create, build, and run C# console applications.

It does not introduce substantial new C# syntax. Its primary purpose is toexplain the software-development process, verify the development environment,and establish the core .NET CLI workflow.

Verified Development Environment

Visual Studio Code: 1.129.0
.NET SDK: 10.0.302
Operating system: Windows
Primary repository IDE: Visual Studio

Visual Studio remains the primary IDE used to manage this repository and itssolution. Visual Studio Code is used in this module because the officialMicrosoft Learn content specifically teaches the VS Code workflow.

Software Development Process

Software development is more than writing source code. A typical developmentprocess includes:

writing code;

compiling the application;

debugging errors;

testing expected behavior;

updating and versioning source files;

releasing or distributing the application.

A programming environment supports these activities by combining an editor,terminal, build tools, debugging tools, extension support, and projectnavigation.

Visual Studio Code

Visual Studio Code is a lightweight, cross-platform source-code editor availablefor:

Windows;

macOS;

Linux.

It includes built-in support for JavaScript, TypeScript, and Node.js. Itsextension ecosystem provides support for additional languages and runtimes,including:

C#;

C++;

Java;

Python;

PHP;

Go;

.NET.

C# development support is provided through Microsoft extensions such asC# Dev Kit.

.NET SDK and .NET Runtime

The .NET SDK provides the tools required to:

create projects;

restore dependencies;

compile source code;

run applications;

test applications;

publish applications.

The .NET Runtime provides the environment required to execute compiled .NETapplications.

The SDK includes the runtime and the development tools. Installing only theruntime is sufficient to run compatible applications, but it does not providethe complete toolchain needed to create and build projects.

Create a Console Application

A console application can be created in a specified directory with:

dotnet new console -o ./CsharpProjects/TestProject

The command contains three main parts:

Driver:     dotnet
Command:    new console
Arguments:  -o ./CsharpProjects/TestProject

The -o argument specifies the output directory.

Command arguments are optional parameters that provide additional information.Running the command without an output argument creates the new project in thecurrent directory:

dotnet new console

A newly generated console project normally contains:

TestProject/
├── Program.cs
├── TestProject.csproj
└── obj/

Program.cs contains the C# source code.

TestProject.csproj contains project configuration such as:

output type;

target framework;

implicit using directives;

nullable-reference settings.

The CLI uses the output-directory name when generating the default .csprojfilename.

Build a Console Application

Compile the current project with:

dotnet build

The dotnet build command:

restores dependencies when necessary;

compiles C# source code;

builds project dependencies;

reports compiler warnings and errors;

creates the application binaries.

Compiled .NET code is stored as Intermediate Language in assemblies that commonlyuse the .dll extension.

For a Debug build targeting .NET 10, generated files are normally stored under:

bin/Debug/net10.0/

Example assembly:

TestProject.dll

The bin/ and obj/ directories are generated build artifacts and should notbe edited manually.

Run a Console Application

Run the current project with:

dotnet run

The dotnet run command provides a convenient development workflow because it:

checks whether the project needs to be built;

invokes the build process when required;

launches the compiled application;

displays console output.

It is useful for fast iterative development from the command line.

The basic workflow introduced by the module is:

Create project → Edit source code → Build → Run → Review output

Repository Project

The project created for this module is located at:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── install-and-configure-visual-studio-code/
        ├── Program.cs
        └── install-and-configure-visual-studio-code.csproj

The project was added to:

freecodecamp-csharp.slnx

At the time this module was completed, the solution contained seven registered projects.

List the solution projects from the repository root:

dotnet sln .\freecodecamp-csharp.slnx list

Module Program

This module requires only a minimal C# program because its main learning outcomeis understanding the development environment and .NET CLI commands.

Recommended Program.cs:

// Verifies that the .NET SDK and C# development environment
// are configured correctly.

Console.WriteLine("Hello C#!");

Expected output:

Hello C#!

Run the project from the repository root:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"

Commands Learned

Command

Purpose

code --version

Displays the installed Visual Studio Code version

dotnet --version

Displays the active .NET SDK version

dotnet --list-sdks

Lists all installed .NET SDK versions

dotnet new console

Creates a new console application

dotnet build

Restores and compiles the current project

dotnet run

Builds when necessary and runs the current project

dotnet sln <solution> list

Lists projects registered in a solution

dotnet sln <solution> add <project>

Adds a project to a solution

dotnet restore

Restores project and solution dependencies

Module Validation

Run these commands from the repository root.

Build the module project:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"

Run the module project:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\install-and-configure-visual-studio-code\install-and-configure-visual-studio-code.csproj"

Restore the full solution:

dotnet restore .\freecodecamp-csharp.slnx

Build the full solution:

dotnet build .\freecodecamp-csharp.slnx

Required build result:

Build succeeded.
0 Warning(s)
0 Error(s)

A successful build must be confirmed in the terminal before the curriculumchanges are committed.

Key Learning Outcomes

After completing this module, the following concepts are understood:

software development is a multi-stage process;

Visual Studio Code is a lightweight cross-platform editor;

C# support in VS Code is provided through extensions;

the .NET SDK is required to create and build C# applications;

the .NET Runtime executes compiled .NET applications;

dotnet new console creates a console project;

dotnet build compiles source code and project dependencies;

dotnet run builds when necessary and launches the application;

.csproj files store project configuration;

Program.cs stores the application source code;

bin/ and obj/ contain generated build artifacts;

projects can be registered in a .slnx solution.

Completion Record

Module: Install and Configure Visual Studio Code
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Created
Project added to solution: Yes
Completion date: July 17, 2026

Module 2 — Call Methods from the .NET Class Library Using C#

Completion Status

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 18, 2026

The Microsoft Learn content, local project, solution registration, andfull-solution build have been verified for this module.

The official module introduces the .NET Class Library and explains how C#applications call reusable methods supplied by .NET.

Learning Objectives

After completing the module, the learner should be able to:

locate useful classes and methods in the .NET Class Library;

call methods by using the member-access and method-invocation operators;

distinguish static methods from instance methods;

create an object with the new operator;

store and use method return values;

distinguish parameters from arguments;

call overloaded methods with different signatures;

use IntelliSense and Microsoft Learn documentation to inspect methods;

use Math.Max() to return the larger of two values.

.NET Class Library

The .NET Class Library is a reusable collection of classes, methods, datatypes, and supporting functionality supplied by .NET.

A class groups related members. For example, the Console class providesmethods for console input and output:

Console.WriteLine("Hello, C#!");

The statement contains:

Console        Class name
.              Member-access operator
WriteLine      Method name
(...)          Method-invocation operator
"Hello, C#!"   Argument

The library prevents developers from having to implement common functionalityfrom scratch.

Static and Instance Methods

A static method belongs to its class and can be called directly through theclass name:

Console.WriteLine("Static method call");

An instance method is called through an object created from a class:

Random dice = new();
int roll = dice.Next(1, 7);

In this example:

Random is the class;

dice is an object, or instance, of Random;

new() creates the instance;

Next(1, 7) is an instance-method call;

the returned integer is stored in roll.

The terms stateless and stateful are used in the module to explain whysome methods are called through a class and others through an object. In normalC# terminology, the key distinction is between static and instance members.

Return Values and void

A method may return a value:

int roll = dice.Next(1, 7);

The returned value can also be used directly:

Console.WriteLine(dice.Next(1, 7));

Some methods return no value. Their return type is void.

Console.Clear();

A return value should normally be stored or consumed when it is meaningful tothe program.

Parameters and Arguments

A parameter is a variable declared by the method definition.

An argument is the concrete value supplied by the caller.

int roll = dice.Next(1, 7);

For the selected Random.Next(int minValue, int maxValue) overload:

minValue and maxValue are parameters;

1 and 7 are arguments;

the minimum value is inclusive;

the maximum value is exclusive.

Therefore, Next(1, 7) can produce the integers 1 through 6.

Method Overloads

An overloaded method has multiple valid signatures. Each overload differs bythe number or types of its parameters.

Examples of Random.Next() overloads:

int anyNonNegativeInteger = dice.Next();
int belowOneHundredOne = dice.Next(101);
int betweenFiftyAndOneHundred = dice.Next(50, 101);

Examples of Console.WriteLine() overloads:

Console.WriteLine();
Console.WriteLine(7);
Console.WriteLine("seven");

IntelliSense displays available overloads, parameter types, and return typeswhile code is being written.

Challenge — Math.Max()

The module challenge requires finding and calling a method that returns thelarger of two numbers.

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Expected output:

600

Math.Max() is a static method, so no Math object needs to be created.

Repository Project

The project for this module uses the shorter directory and project names whilethe official module title remains fully documented here:

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── call-methods/
        ├── Program.cs
        └── call-methods.csproj

The project must be registered in:

freecodecamp-csharp.slnx

The project is registered in the solution. At the time this module was completed,the solution contained eight registered projects.

Module Program

The program contains focused executable examples rather than copying the lessonas hundreds of comment lines. It demonstrates:

a static method call;

creation of a Random instance;

an instance method with a return value;

parameters and arguments;

overloaded methods;

direct use of a return value;

the Math.Max() challenge.

Because random-number output changes on each run, only the fixed labels andnumeric ranges are deterministic.

Possible output:

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

The random values will vary, but:

each six-sided die roll must be between 1 and 6;

Next(101) must be between 0 and 100;

Next(50, 101) must be between 50 and 100;

the larger challenge value must be 600.

Build and Run Commands

Run the module project from the repository root:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\call-methods\call-methods.csproj"

Build the module project:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\call-methods\call-methods.csproj"

List all solution projects:

dotnet sln .\freecodecamp-csharp.slnx list

Restore and build the complete solution:

dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx

The module can be marked Completed only after the terminal confirms:

Build succeeded.
0 Warning(s)
0 Error(s)

Key Terms

Term

IPA

Approximate reading

Meaning

method

/ˈmeθ.əd/

“me-thợd”

phương thức

class library

/klɑːs ˈlaɪ.brər.i/

“class lai-brờ-ri”

thư viện lớp

instance

/ˈɪn.stəns/

“in-stầns”

thể hiện/đối tượng được tạo từ lớp

static

/ˈstæt.ɪk/

“sta-tịch”

thành viên thuộc về lớp

parameter

/pəˈræm.ɪ.tər/

“pờ-ra-mi-tờ”

biến trong định nghĩa phương thức

argument

/ˈɑːɡ.jə.mənt/

“a-giu-mần(t)”

giá trị truyền vào khi gọi phương thức

return value

/rɪˈtɜːn ˌvæl.juː/

“ri-tơn va-liu”

giá trị trả về

overload

/ˈəʊ.və.ləʊd/

“âu-vờ-lâuđ”

nhiều chữ ký gọi cho cùng tên phương thức

IntelliSense

/ɪnˈtel.ɪ.sens/

“in-te-li-sens”

hỗ trợ gợi ý và phân tích mã

Knowledge Introduced

This module introduces:

the .NET Class Library;

classes, objects, and methods;

static and instance method calls;

the new operator;

return values and void;

parameters and arguments;

method overloads;

IntelliSense;

documentation lookup;

Random.Next();

Math.Max().

The following topics are intentionally deferred to later modules:

defining custom methods;

defining custom classes;

constructor design;

fields and properties;

dependency injection;

automated unit testing;

cryptographically secure random-number generation.

Completion Record

Module: Call Methods from the .NET Class Library Using C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 18, 2026

Module 3 — Add Decision Logic to Your Code Using if, else, and else if Statements in C#

Completion Status

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 9
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 19, 2026

The official units, assessment, achievement, local project, solutionregistration, project run, and complete solution build have all been verified.

Official Module Structure

The module contains seven units:

Introduction

Exercise — Create decision logic with if statements

Exercise — Create nested decision logic with if, else if, and else

Exercise — Complete a challenge activity to apply business rules

Review the solution to the apply business rules challenge activity

Module assessment

Summary

The module teaches how to branch a program's execution path by evaluatingBoolean expressions.

Learning Objectives

After completing the module, the learner should be able to:

evaluate conditions with if, else if, and else;

build Boolean expressions that return true or false;

compare values with equality and relational operators;

combine Boolean expressions with logical operators;

create mutually exclusive execution branches;

nest one code block inside another;

order conditions according to business-rule precedence;

prevent multiple rewards or messages from being applied incorrectly.

Decision Logic and Branches

Decision logic allows a program to choose which statements should execute.Alternative execution paths are commonly called branches.

if (total >= 15)
{
    Console.WriteLine("You win!");
}

An if statement contains:

if                  Decision keyword
(total >= 15)       Boolean expression
{ ... }             Code block

The code block executes only when the Boolean expression evaluates to true.

Boolean Expressions

A Boolean expression produces either true or false.

string message = "The quick brown fox jumps over the lazy dog.";
bool containsDog = message.Contains("dog");

Console.WriteLine(containsDog);

A method that returns bool can be used directly as a condition:

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

Comparison Operators

Operator

Meaning

Example

==

equal to

roll1 == roll2

!=

not equal to

score != 0

>

greater than

total > 14

<

less than

total < 15

>=

greater than or equal to

total >= 15

<=

less than or equal to

daysUntilExpiration <= 5

== tests equality. A single = performs assignment.

Logical Operators

The logical OR operator, ||, returns true when at least one condition istrue:

bool hasDoubles =
    roll1 == roll2 ||
    roll2 == roll3 ||
    roll1 == roll3;

The logical AND operator, &&, returns true only when both conditions aretrue:

bool hasTriples =
    roll1 == roll2 &&
    roll2 == roll3;

Code Blocks and Nesting

A code block is enclosed by braces:

{
    // Statements belonging to one unit of execution.
}

A block can contain another block:

if (hasDoubles)
{
    if (hasTriples)
    {
        Console.WriteLine("You rolled triples!");
    }
}

This is called nested decision logic. Nesting is useful when an inner decisionshould be evaluated only after an outer condition succeeds.

Dice Game

The exercise generates three six-sided dice:

Random random = new();

int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int roll3 = random.Next(1, 7);

int total = roll1 + roll2 + roll3;

Random.Next(1, 7) can return 1 through 6 because the minimum is inclusiveand the maximum is exclusive.

The bonus rules are:

doubles add two points;

triples add six points;

doubles and triples bonuses must not stack.

The final repository code evaluates triples before doubles:

if (hasTriples)
{
    total += 6;
}
else if (hasDoubles)
{
    total += 2;
}

Every triple also satisfies the doubles condition. An if/else if chain makesthe two bonus branches mutually exclusive.

if, else if, and else

Two opposite outcomes can be represented by if and else:

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

Multiple mutually exclusive outcomes use an if/else if/else chain:

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

Conditions are checked from top to bottom. Only the first matching branch runs,so condition order directly affects program behavior.

Subscription-Renewal Challenge

The challenge begins with:

int daysUntilExpiration = random.Next(12);

Possible values are 0 through 11.

The business-rule precedence is:

0: subscription expired;

1: urgent message and 20% discount;

2–5: expiration message and 10% discount;

6–10: general renewal reminder;

11: display no subscription message.

The conditions must be ordered from the most specific and highest-priority ruleto the broadest rule:

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine(
        $"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine("Renew now and save 10%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine(
        "Your subscription will expire soon. Renew now!");
}

There is intentionally no final else. When the value is 11, the challengerequires no subscription message.

Repository Project

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── decision-logic/
        ├── Program.cs
        └── decision-logic.csproj

The project is registered in:

freecodecamp-csharp.slnx

The solution listing confirms nine registered projects.

Module Program

The final Program.cs consolidates the completed exercises into two focusedexamples:

a dice game demonstrating Boolean expressions, logical operators, bonusprecedence, and mutually exclusive prize branches;

a subscription-renewal challenge demonstrating ordered business rules andone-message-only behavior.

Intermediate versions are documented conceptually rather than retained asduplicate executable code.

Possible Output

Random values change between runs.

=== Dice game ===
Dice roll: 4 + 4 + 2 = 10
You rolled doubles! +2 bonus to total!
Your total including the bonus: 12
You win a new laptop!

Your subscription expires in 4 days.
Renew now and save 10%!

Valid runs may also produce a triples bonus, another prize, an expiredsubscription, a 20% discount, a general reminder, or no subscription message.

Build and Run Commands

Run the module:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\decision-logic\decision-logic.csproj"

Build the module:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\decision-logic\decision-logic.csproj"

List solution projects:

dotnet sln .\freecodecamp-csharp.slnx list

Restore and build the full solution:

dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx

Required result:

Build succeeded.
0 Warning(s)
0 Error(s)

Key Terms

Term

IPA

Approximate reading

Meaning

decision logic

/dɪˈsɪʒ.ən ˈlɒdʒ.ɪk/

“đi-si-zhần lo-jịch”

logic ra quyết định

branch

/brɑːntʃ/

“branch”

nhánh thực thi

Boolean expression

/ˈbuː.li.ən ɪkˈspreʃ.ən/

“bu-li-ần ịch-spre-shần”

biểu thức trả về true hoặc false

condition

/kənˈdɪʃ.ən/

“cần-đi-shần”

điều kiện

code block

/kəʊd blɒk/

“câud block”

khối lệnh

nested

/ˈnes.tɪd/

“nes-tịt”

được lồng bên trong

logical operator

/ˈlɒdʒ.ɪ.kəl ˈɒp.ər.eɪ.tər/

“lo-ji-cồ o-pờ-rây-tờ”

toán tử logic

precedence

/ˈpres.ɪ.dəns/

“pre-si-đầns”

thứ tự ưu tiên

mutually exclusive

/ˌmjuː.tʃu.ə.li ɪkˈskluː.sɪv/

“miu-chu-ờ-li ịch-sclu-siv”

loại trừ lẫn nhau

Knowledge Introduced

This module introduces:

decision logic and code branches;

Boolean expressions;

comparison operators;

logical AND and logical OR;

if, else if, and else;

nested code blocks;

mutually exclusive branches;

condition ordering;

business-rule precedence;

prevention of logic defects.

The following topics are deferred:

switch statements and switch expressions;

the conditional operator ?:;

pattern matching;

guard clauses in custom methods;

automated branch-coverage testing;

domain-specific rule engines.

Completion Record

Module: Add Decision Logic to Your Code Using if, else, and else if Statements in C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 9
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 19, 2026

Module 4 — Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#

Completion Status

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 10
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 20, 2026

The official Microsoft Learn units, assessment, achievement, local project,solution registration, project run, and complete solution build have all beenverified.

Official Module Structure

The module contains seven units:

Introduction

Exercise — Get started with array basics

Exercise — Implement the foreach statement

Exercise — Complete a challenge activity for nested iteration and selection statements

Review the solution for the nested iteration and selection statements challenge activity

Module assessment

Summary

The module focuses on storing related values in arrays and processing everyelement with foreach.

Learning Objectives

After completing the module, the learner should be able to:

create and initialize an array;

store multiple related values of one data type;

assign values to individual array elements;

retrieve values by index;

explain zero-based indexing;

reassign an existing array element;

use the Length property;

iterate through an array with foreach;

maintain a running total while iterating;

combine foreach with an if statement;

use String.StartsWith() to select matching strings.

Arrays

An array stores multiple values of the same data type under one variablename.

string[] fraudulentOrderIds = ["A123", "B456", "C789"];

In this declaration:

string      Element data type
[]          Array type indicator
fraudulentOrderIds
            Array variable name
[ ... ]     Collection expression used to initialize the array

The project uses collection-expression syntax supported by the repository'scurrent C# and .NET configuration.

An older array-initialization form is also valid:

string[] fraudulentOrderIds = { "A123", "B456", "C789" };

The repository program uses one consistent modern syntax rather than retainingmultiple executable versions of the same exercise.

Zero-Based Indexing

Array indexes begin at zero.

Console.WriteLine(fraudulentOrderIds[0]);
Console.WriteLine(fraudulentOrderIds[1]);
Console.WriteLine(fraudulentOrderIds[2]);

The relationship between position and index is:

First element   → index 0
Second element  → index 1
Third element   → index 2

For an array containing three elements, valid indexes are 0, 1, and 2.

Attempting to access index 3 would cause anIndexOutOfRangeException at runtime:

// fraudulentOrderIds[3] = "D000";

The invalid statement is documented but intentionally not executed.

Reading and Reassigning Array Elements

An array element can be read like an individual variable:

Console.WriteLine($"First: {fraudulentOrderIds[0]}");

An existing element can also be reassigned:

fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassigned first: {fraudulentOrderIds[0]}");

The replacement value must be compatible with the array's element type.

The Length Property

The Length property reports the total number of elements in an array:

Console.WriteLine(
    $"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

For the example array:

Length: 3
Last valid index: 2

Length is a count and is therefore not zero-based.

The foreach Statement

The foreach statement processes every element in a sequence.

string[] names = ["Rowena", "Robin", "Bao"];

foreach (string name in names)
{
    Console.WriteLine(name);
}

The statement contains:

foreach     Iteration keyword
string      Type of the current element
name        Temporary iteration variable
in          Separates the variable from the sequence
names       Array being traversed
{ ... }     Code executed once for each element

For an array, foreach processes elements in increasing index order, beginningwith index 0 and ending with index Length - 1.

Inventory Running Total

The inventory exercise stores finished-product counts for five bins:

int[] inventory = [200, 450, 700, 175, 250];

Variables that must retain values between iterations are declared before theloop:

int sum = 0;
int bin = 0;

The loop updates the running total and reports each bin:

foreach (int items in inventory)
{
    sum += items;
    bin++;

    Console.WriteLine(
        $"Bin {bin} = {items} items (Running total: {sum})");
}

The final total is displayed after iteration finishes:

Console.WriteLine($"We have {sum} items in inventory.");

Expected inventory total:

1775

Nested Iteration and Selection Challenge

The challenge stores order IDs in an array:

string[] orderIds =
[
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
];

The application must report only IDs that begin with the letter B.

foreach (string orderId in orderIds)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine(orderId);
    }
}

This combines two control-flow concepts:

foreach   Iterates through every order ID
if        Selects only values satisfying the condition

StartsWith("B") returns a Boolean value:

true      The order ID begins with B
false     The order ID does not begin with B

Expected challenge output:

B123
B177
B179

Repository Project

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── arrays-foreach/
        ├── Program.cs
        └── arrays-foreach.csproj

The project is registered in:

freecodecamp-csharp.slnx

The solution listing confirms ten registered projects.

Module Program

The final Program.cs consolidates the completed exercises into three focusedsections:

array declaration, initialization, indexing, reassignment, and Length;

inventory iteration with a bin counter and running total;

order-ID filtering with foreach, if, and StartsWith().

The source retains explanatory comments but excludes duplicate intermediateversions that would cause repeated declarations or compilation errors.

Verified Output

=== Array basics ===
First: A123
Second: B456
Third: C789
Reassigned first: F000
There are 3 fraudulent orders to process.

=== Inventory report with foreach ===
Bin 1 = 200 items (Running total: 200)
Bin 2 = 450 items (Running total: 650)
Bin 3 = 700 items (Running total: 1350)
Bin 4 = 175 items (Running total: 1525)
Bin 5 = 250 items (Running total: 1775)
We have 1775 items in inventory.

=== Orders requiring investigation ===
B123
B177
B179

The terminal output confirms that indexing, reassignment, iteration, accumulation,and order filtering behave as intended.

Build and Run Commands

Run the module:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\arrays-foreach\arrays-foreach.csproj"

Build the module:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\arrays-foreach\arrays-foreach.csproj"

List all registered projects:

dotnet sln .\freecodecamp-csharp.slnx list

Restore and build the complete solution:

dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx

Verified result:

Build succeeded.

The supplied terminal output shows that all ten projects compiled successfully,including arrays-foreach.

Key Terms

Term

IPA

Approximate reading

Meaning

array

/əˈreɪ/

“ờ-rây”

mảng

sequence

/ˈsiː.kwəns/

“si-quầns”

chuỗi hoặc trình tự dữ liệu

element

/ˈel.ɪ.mənt/

“e-li-mần(t)”

phần tử

index

/ˈɪn.deks/

“in-đeks”

chỉ số

zero-based

/ˈzɪə.rəʊ beɪst/

“zi-râu bâyst”

bắt đầu từ số 0

iterate

/ˈɪt.ə.reɪt/

“i-tờ-râyt”

duyệt lặp

iteration

/ˌɪt.əˈreɪ.ʃən/

“i-tờ-rây-shần”

một quá trình hoặc lần lặp

foreach statement

/ˌfɔːr ˈiːtʃ ˈsteɪt.mənt/

“pho-r ích stâyt-mần(t)”

câu lệnh duyệt từng phần tử

running total

/ˌrʌn.ɪŋ ˈtəʊ.təl/

“rân-ning tââu-tồ”

tổng tích lũy

out of range

/ˌaʊt əv ˈreɪndʒ/

“ao-tờv râynj”

nằm ngoài phạm vi hợp lệ

Knowledge Introduced

This module introduces:

one-dimensional arrays;

array declaration and initialization;

collection expressions;

zero-based indexes;

element retrieval and reassignment;

the Length property;

foreach iteration;

temporary iteration variables;

running totals;

external loop counters;

nested iteration and selection;

String.StartsWith().

The following topics are intentionally deferred:

for and while loops;

modifying a collection during enumeration;

multidimensional and jagged arrays;

List<T> and other generic collections;

array sorting and reversing methods;

LINQ;

custom collection types;

performance analysis of collection traversal.

Completion Record

Module: Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 10
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 20, 2026

Module 5 — Create Readable Code with Conventions, Whitespace, and Comments in C#

Completion Status

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 11
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 21, 2026

The official Microsoft Learn units, assessment, achievement, local project,solution registration, project run, and complete solution build have all beenverified.

The module focuses on communicating program intent clearly to both the C#compiler and other developers by using consistent names, purposeful comments,and meaningful whitespace.

Official Module Structure

The module contains eight units:

Introduction

Choose variable names that follow rules and conventions

Exercise — Create effective code comments

Exercise — Use whitespace to make code easier to read

Exercise — Complete a challenge activity to improve code readability

Review the solution to the code-readability challenge

Module assessment

Summary

Learning Objectives

After completing the module, the learner should be able to:

distinguish compiler-enforced identifier rules from community conventions;

choose descriptive local-variable names;

apply camelCase to local variables;

avoid abbreviations and unnecessary type prefixes;

use single-line and block comments appropriately;

temporarily disable code while testing a change;

explain higher-level intent without narrating obvious syntax;

use blank lines to separate related groups of statements;

place braces and indentation consistently;

improve poorly formatted code without changing its behavior.

Rules and Conventions

A rule is enforced by the C# compiler. Violating a naming rule prevents theprogram from compiling.

A convention is an agreed style used by developers to make code consistentand easier to understand. Conventions are not always compiler errors, but theyimprove maintainability and collaboration.

Examples of valid local-variable declarations:

char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer;

Examples of invalid declarations:

// int 2ndScore;
// string order-id;
// decimal total$;
// int class;

Important identifier rules include:

names may contain letters, digits, and underscores;

a name must begin with a letter or underscore;

a name cannot contain characters such as -, #, or $;

a name cannot be an unescaped C# keyword;

names are case-sensitive.

For example, these are two different identifiers:

string myValue = "First";
string MyValue = "Second";

Although an identifier may begin with _, that style is normally reserved forprivate instance fields rather than local variables.

camelCase for Local Variables

Local variables use camel case: the first word begins with a lowercaseletter, and each following word begins with an uppercase letter.

string originalMessage;
char[] messageCharacters;
int letterOCount;
string reversedMessage;

The name should describe the value's purpose and meaning rather than merely itsdata type.

Prefer:

decimal orderAmount;
bool orderComplete;

Avoid:

decimal odrAmt;
bool value;
string strMessage;

The improved names reduce the amount of explanation required elsewhere in theprogram.

Descriptive Names and Intent

A readable name communicates what a value represents and why it exists.

Poorly named version:

string str = "The quick brown fox jumps over the lazy dog.";
int x = 0;
string new_message;

Improved version:

string originalMessage = "The quick brown fox jumps over the lazy dog.";
int letterOCount = 0;
string reversedMessage;

The final repository program uses messageCharacters instead of the moregeneral name message, because the variable stores an array of individualcharacters.

It also uses letterOCount instead of letterCount, because the program countsone specific character.

Code Comments

A comment is ignored by the compiler and exists for people reading ormaintaining the source code.

Single-line comments begin with //:

// Temporarily disable the old output while testing the revised message.

Block comments begin with /* and end with */:

/*
 * This program reverses a message, counts the number of times
 * the letter 'o' appears, and prints the results.
 */

Comments can temporarily prevent executable statements from being compiled:

// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

This is useful during a short experiment, but obsolete code should be removedafter the replacement has been verified. Version control preserves previousimplementations when they are needed later.

High-Quality and Low-Quality Comments

Comments should explain information that the code cannot express clearly byitself, such as:

the higher-level purpose of a block;

a business requirement;

a non-obvious constraint;

the reason for a particular implementation decision;

why code is temporarily disabled.

A low-quality comment merely translates a clear line of C# into English:

// Convert the message into a character array.
char[] messageCharacters = originalMessage.ToCharArray();

The method call and variable name already communicate that operation, so thecomment adds clutter without adding context.

A useful comment describes the overall goal:

/*
 * Reverse a message and count occurrences of the target character
 * so the transformed text and count can be reported together.
 */

Readable code minimizes comments that explain what each line does andreserves comments for why the code exists or why it is implemented in aparticular way.

Whitespace

In source code, whitespace includes:

spaces;

tabs;

line breaks;

blank lines.

The compiler generally ignores most formatting whitespace, but developers relyon it to understand structure and ownership.

Although the following can compile, it is difficult to read:

string firstWord = "Hello"; string lastWord = "World"; Console.WriteLine(firstWord + " " + lastWord);

A readable version separates complete statements:

string firstWord = "Hello";
string lastWord = "World";

Console.WriteLine($"{firstWord} {lastWord}");

Recommended practices include:

place each complete statement on its own line;

include spaces around assignment and comparison operators;

use blank lines between related phases of an algorithm;

place opening and closing braces consistently;

indent statements inside their owning code block;

avoid arbitrary line breaks that obscure a simple expression.

Vertical Grouping

Blank lines can divide a program into conceptual phases.

string originalMessage =
    "The quick brown fox jumps over the lazy dog.";

char[] messageCharacters = originalMessage.ToCharArray();
Array.Reverse(messageCharacters);

int letterOCount = 0;

The groups represent:

input data;

message transformation;

initialization of the counting state.

Later groups handle iteration, result construction, and output. This structureallows the reader to scan the algorithm before examining individual statements.

Braces and Indentation

Braces define code-block ownership, while indentation makes that ownershipvisible.

foreach (char character in messageCharacters)
{
    if (character == 'o')
    {
        letterOCount++;
    }
}

The indentation shows that:

the if statement belongs to the foreach block;

letterOCount++ belongs to the if block;

the count increases only when the current character is 'o'.

The formatting does not create the ownership—the braces do—but it makes thestructure immediately understandable.

Code-Readability Challenge

The challenge begins with poorly named and poorly formatted code that:

converts a sentence to a character array;

reverses the array;

counts occurrences of the letter o;

creates a reversed string;

prints the reversed message and count.

The original style includes unclear names such as:

string str;
int x;
string new_message;

It also places the foreach and if statements on one line and includescomments that merely repeat the code.

The repository solution preserves the behavior while improving names, comments,spacing, and block formatting.

Repository Project

curriculum/create-and-run-simple-csharp-console-applications/
└── modules/
    └── readable-code/
        ├── Program.cs
        └── readable-code.csproj

The project is registered in:

freecodecamp-csharp.slnx

The solution listing confirms eleven registered projects.

This section continues to use one central README. The readable-code directorycontains only the source and project files required to build and run the module.

Module Program

The final Program.cs is:

/*
 * This program reverses a message, counts the number of times
 * the letter 'o' appears, and prints the results to the console.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] messageCharacters = originalMessage.ToCharArray();
Array.Reverse(messageCharacters);

int letterOCount = 0;

foreach (char character in messageCharacters)
{
    if (character == 'o')
    {
        letterOCount++;
    }
}

string reversedMessage = new string(messageCharacters);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {letterOCount} times.");

The final program contains:

a concise higher-level comment;

descriptive camelCase local-variable names;

blank lines separating logical phases;

conventional brace placement;

clear indentation for nested blocks;

no comments that merely repeat self-explanatory statements.

Expected Output

.god yzal eht revo spmuj xof nworb kciuq ehT
'o' appears 4 times.

The reversed text is deterministic because the input sentence is fixed.

The count is 4 because the original sentence contains four lowercase ocharacters:

brown
fox
over
dog

Build and Run Commands

Run the module:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\readable-code\readable-code.csproj"

Build the module:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\modules\readable-code\readable-code.csproj"

List all registered projects:

dotnet sln .\freecodecamp-csharp.slnx list

Restore and build the complete solution:

dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx

Verified result:

Build succeeded.

The supplied terminal output confirms that the full solution compiledsuccessfully after readable-code was added.

Key Terms

Term

IPA

Approximate reading

Meaning

readable code

/ˈriː.də.bəl kəʊd/

“ri-đờ-bồ côđ”

mã nguồn dễ đọc

convention

/kənˈven.ʃən/

“cần-ven-shần”

quy ước

identifier

/aɪˈden.tɪ.faɪ.ər/

“ai-đen-ti-fai-ờ”

tên định danh

camel case

/ˈkæm.əl keɪs/

“ca-mồ câys”

kiểu tên bắt đầu bằng chữ thường

descriptive

/dɪˈskrɪp.tɪv/

“đi-scrip-tiv”

có tính mô tả

intent

/ɪnˈtent/

“in-tent”

ý định, mục đích

comment

/ˈkɒm.ent/

“com-men(t)”

chú thích mã nguồn

block comment

/blɒk ˈkɒm.ent/

“block com-men(t)”

chú thích nhiều dòng

whitespace

/ˈwaɪt.speɪs/

“quai-t-spâys”

khoảng trắng trong mã

indentation

/ˌɪn.denˈteɪ.ʃən/

“in-đen-tây-shần”

thụt lề

maintainability

/meɪnˌteɪ.nəˈbɪl.ə.ti/

“mâyn-tây-nờ-bi-lờ-ti”

khả năng bảo trì

Knowledge Introduced

This module introduces:

compiler-enforced identifier rules;

community naming conventions;

camelCase local variables;

descriptive and intention-revealing names;

single-line comments;

block comments;

temporary code commenting;

higher-level explanatory comments;

horizontal and vertical whitespace;

logical grouping of statements;

brace placement;

indentation and visible ownership;

readability-focused refactoring without behavior changes.

The following topics are intentionally deferred:

naming conventions for classes, methods, properties, fields, and constants;

XML documentation comments;

.editorconfig;

Roslyn analyzers;

automated code formatting;

refactoring tools;

code-review standards;

architecture-level documentation.

Completion Record

Module: Create Readable Code with Conventions, Whitespace, and Comments in C#
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 11
Local run: Verified
Module build: Verified
Full solution build: Verified
Completion date: July 21, 2026

Guided Project 1 — Develop foreach and if-else if-else Structures to Process Array Data in C#

Completion Status

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 12
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 22, 2026

This guided project combines the concepts introduced throughout Section 2 intoa complete Student Grading Application.

The application stores student names and assignment scores in arrays, processesthe data with nested foreach loops, distinguishes exam scores fromextra-credit scores, calculates numeric grades, assigns letter gradesautomatically, and produces a formatted report.

Project Objectives

The completed application demonstrates how to:

store student names in a string[] array;

store each student's assignment scores in an int[] array;

use an outer foreach loop to process every student;

use an if-else if-else selection structure to select the current student'sscore array;

use an inner foreach loop to process every assignment score;

maintain counters and running totals;

distinguish exam scores from extra-credit scores by array position;

apply a 10% weighting factor to extra-credit assignments;

calculate a final numeric grade using decimal;

assign a letter grade with ordered score thresholds;

format aligned console output;

add additional students with minimal changes to the existing algorithm.

Application Requirements

The grading application follows these rules:

Regular exam assignments: 5
Exam score range: 0–100
Extra-credit weighting: 10% of a regular exam score
Final numeric grade:
    (exam score total + weighted extra-credit points)
    / number of exam assignments

Letter-grade thresholds:

Numeric grade

Letter grade

97–100

A+

93–96

A

90–92

A-

87–89

B+

83–86

B

80–82

B-

77–79

C+

73–76

C

70–72

C-

67–69

D+

63–66

D

60–62

D-

0–59

F

Thresholds are evaluated from highest to lowest. The first matching branchdetermines the student's letter grade.

Repository Project

curriculum/create-and-run-simple-csharp-console-applications/
└── guided-projects/
    └── student-grading-application/
        ├── Program.cs
        └── student-grading-application.csproj

The project is registered in:

freecodecamp-csharp.slnx

The solution listing confirms twelve registered projects.

This section continues to use one central README. The guided-project directorycontains the executable source and project files without an additional README.

Program Structure

The application follows a clear top-to-bottom workflow:

Declare grading constants
        ↓
Create score arrays
        ↓
Create the student-name array
        ↓
Print the report header
        ↓
Outer foreach: process each student
        ↓
Select the current score array
        ↓
Inner foreach: process assignment scores
        ↓
Calculate numeric grade
        ↓
Assign letter grade
        ↓
Print one report row

This organization keeps data initialization, processing, decision logic, andoutput responsibilities visually separated.

Student and Score Arrays

The project includes eight students:

string[] studentNames =
[
    "Sophia",
    "Andrew",
    "Emma",
    "Logan",
    "Becky",
    "Chris",
    "Eric",
    "Gregor"
];

Each score array contains five regular exam scores followed by zero or moreextra-credit scores:

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

Additional score arrays are included for Becky, Chris, Eric, and Gregor.

The first five positions always represent exam assignments. Values after thosepositions are treated as extra-credit assignments.

Outer foreach Loop

The outer loop processes one student per iteration:

foreach (string currentStudent in studentNames)
{
    // Select scores, calculate grades, and print one report row.
}

This eliminates repeated calculation blocks for individual students and ensuresthat the same grading algorithm is applied consistently.

Student Score Selection

The current student's score array is selected with an orderedif-else if-else structure:

if (currentStudent == "Sophia")
{
    studentScores = sophiaScores;
}
else if (currentStudent == "Andrew")
{
    studentScores = andrewScores;
}
else
{
    continue;
}

The final else prevents an unknown student name from accidentally reusing thescore array selected during a previous iteration.

This project intentionally uses selection statements because practicingif-else if-else is one of the guided project's core objectives. More scalabledata structures such as dictionaries are deferred to later learning.

Inner foreach Loop

The inner loop processes every score assigned to the current student:

foreach (int score in studentScores)
{
    gradedAssignmentCount++;

    if (gradedAssignmentCount <= examAssignments)
    {
        assignmentScoreSum += score;
    }
    else
    {
        assignmentScoreSum += score / extraCreditDivisor;
    }
}

The assignment counter identifies whether the current value is:

one of the first five exam scores; or

an extra-credit score stored after the exams.

Regular exam scores contribute their full value. Extra-credit scores contribute10% through integer division, matching the expected Microsoft Learn results.

Numeric Grade Calculation

After all assignments have been processed:

decimal numericGrade =
    (decimal)assignmentScoreSum / examAssignments;

Casting the numerator to decimal preserves the fractional portion of thecalculation.

The denominator remains the number of regular exam assignments. Extra-creditassignments add bonus points but do not increase the number of exams.

Letter-Grade Selection

The application uses an ordered if-else if-else chain:

if (numericGrade >= 97)
{
    letterGrade = "A+";
}
else if (numericGrade >= 93)
{
    letterGrade = "A";
}
else if (numericGrade >= 90)
{
    letterGrade = "A-";
}
else
{
    letterGrade = "F";
}

The complete project includes every threshold from A+ through F.

Conditions must be ordered from highest to lowest. For example, a score of98 also satisfies >= 90, but the A+ branch must be selected first.

Formatted Report

The repository implementation uses alignment components in interpolated strings:

Console.WriteLine(
    $"{"Student",-12}{"Numeric Grade",15}{"Letter Grade",15}");

Console.WriteLine(
    $"{currentStudent,-12}{numericGrade,15:F1}{letterGrade,15}");

Formatting behavior:

-12     Left-align in a 12-character field
15      Right-align in a 15-character field
F1      Display one digit after the decimal point

This produces stable columns even when student names and grade values havedifferent lengths.

Expected Output

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

The report confirms that:

all students were processed;

extra-credit values were weighted;

numeric grades retained decimal precision;

letter grades were assigned automatically;

output columns were aligned.

Readability Improvements

The final repository implementation improves the instructional solution withoutchanging the required grading behavior.

Examples include:

using const for fixed grading rules;

naming examAssignments and extraCreditDivisor explicitly;

declaring studentScores without creating an unused placeholder array;

using braces consistently for every branch;

resetting counters and totals inside the outer loop;

using continue for unknown students;

writing comments that explain intent and constraints;

removing unused using directives;

formatting output with interpolation alignment rather than tab characters.

These changes preserve the guided project's learning goals while producing codethat is easier to review and maintain.

Build and Run Commands

Run the guided project:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\guided-projects\student-grading-application\student-grading-application.csproj"

Build the guided project:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\guided-projects\student-grading-application\student-grading-application.csproj"

List registered solution projects:

dotnet sln .\freecodecamp-csharp.slnx list

Restore and build the complete solution:

dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx

Required result:

Build succeeded.
0 Warning(s)
0 Error(s)

Key Terms

Term

IPA

Approximate reading

Meaning

guided project

/ˈɡaɪ.dɪd ˈprɒdʒ.ekt/

“gai-địt pro-jẹkt”

dự án có hướng dẫn

grading application

/ˈɡreɪ.dɪŋ ˌæp.lɪˈkeɪ.ʃən/

“grây-đing áp-li-kây-shần”

ứng dụng tính và xếp loại điểm

nested loop

/ˈnes.tɪd luːp/

“nes-tịt lu”

vòng lặp lồng nhau

outer loop

/ˈaʊ.tər luːp/

“ao-tờ lu”

vòng lặp bên ngoài

inner loop

/ˈɪn.ər luːp/

“in-nờ lu”

vòng lặp bên trong

extra credit

/ˌek.strə ˈkred.ɪt/

“éc-strờ cre-địt”

điểm cộng

weighting factor

/ˈweɪ.tɪŋ ˌfæk.tər/

“quây-ting fac-tờ”

hệ số trọng số

threshold

/ˈθreʃ.həʊld/

“thresh-hâu-đ”

ngưỡng

formatted output

/ˈfɔː.mæt.ɪd ˈaʊt.pʊt/

“pho-mát-tịt ao-t-put”

đầu ra được định dạng

scalability

/ˌskeɪ.ləˈbɪl.ə.ti/

“scây-lờ-bi-lờ-ti”

khả năng mở rộng

Knowledge Integrated

This guided project integrates:

array declaration and initialization;

collection expressions;

nested foreach loops;

iteration counters;

running totals;

if-else if-else selection;

branch ordering;

integer and decimal arithmetic;

explicit numeric casting;

extra-credit weighting;

automatic grade classification;

interpolated-string alignment;

readability conventions;

extensible data-processing structure.

The following improvements are intentionally deferred:

dictionaries for mapping names to score arrays;

custom Student classes;

custom grading methods;

enums for letter grades;

input validation;

file or database persistence;

automated unit tests;

configurable grading policies;

separation into application and domain layers.

Completion Record

Curriculum item: Guided Project — Develop foreach and if-elseif-else Structures to Process Array Data in C#
Project: Student Grading Application
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 12
Local run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 22, 2026

Challenge Project 1 — Develop foreach and if-else if-else Structures to Process Array Data in C#

Completion Status

Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project: Verified
Project added to solution: Verified
Solution project count: 13
Local project run: Verified
Project build: Verified
Full solution build: Verified
Completion date: July 23, 2026

This challenge project extends the Student Grading Application from the guidedproject. Instead of only reporting a final numeric grade and letter grade, theupdated application separates the regular exam average from the weighted impactof extra-credit work.

The project requires the learner to revise an existing application from afeature specification with less step-by-step guidance.

Updated Report Requirements

The final report contains:

student name;

average exam score;

overall numeric grade;

automatically assigned letter grade;

average extra-credit score;

weighted extra-credit points added to the final grade.

Expected report values:

Student         Exam Score    Overall Grade    Letter            Extra Credit
-----------------------------------------------------------------------------
Sophia                92.2            95.88         A              92 (3.68 pts)
Andrew                89.6            91.38        A-              89 (1.78 pts)
Emma                  85.6            90.94        A-              89 (5.34 pts)
Logan                 91.2            93.12         A              96 (1.92 pts)

Grade Calculations

The regular exam average is calculated from the first five scores:

decimal examScore =
    (decimal)examScoreSum / examAssignments;

The extra-credit average is calculated independently:

decimal averageExtraCreditScore =
    extraCreditAssignmentCount > 0
        ? (decimal)extraCreditScoreSum / extraCreditAssignmentCount
        : 0m;

The weighted extra-credit contribution is:

decimal extraCreditPoints =
    extraCreditScoreSum * extraCreditWeight / examAssignments;

The final grade combines the exam average and weighted bonus:

decimal overallGrade =
    examScore + extraCreditPoints;

This separation makes the report auditable because the reader can see both thebase exam performance and the exact contribution from extra-credit work.

Nested Processing Structure

The application retains the required nested structure:

Outer foreach
    Iterate through student names

    if-else if-else
        Select the current student's score array

    Inner foreach
        Separate exam scores from extra-credit scores
        Maintain counters and running totals

    Calculate report values
    Assign the letter grade
    Print one formatted row

The first five elements of each score array are regular exams. Any remainingelements are treated as extra-credit assignments.

Repository Project

curriculum/create-and-run-simple-csharp-console-applications/
└── challenge-projects/
    └── student-grading-challenge/
        ├── Program.cs
        └── student-grading-challenge.csproj

The project should be registered in:

freecodecamp-csharp.slnx

After registration, the solution should contain thirteen projects.

Readability and Reliability Improvements

The repository implementation improves the starter code by:

removing unused using directives;

declaring fixed rules with const;

using descriptive names for counters, sums, averages, and weighted points;

declaring the current score array without an unused placeholder array;

resetting all per-student values inside the outer loop;

preventing unknown student names from reusing stale score data;

guarding against division by zero when no extra-credit scores exist;

separating the exam average, bonus points, and overall grade calculations;

evaluating letter-grade thresholds from highest to lowest;

formatting stable report columns with interpolation alignment;

retaining comments only for non-obvious rules and implementation intent.

Build and Run Commands

Run the challenge project:

dotnet run --project `
  ".\curriculum\create-and-run-simple-csharp-console-applications\challenge-projects\student-grading-challenge\student-grading-challenge.csproj"

Build the challenge project:

dotnet build `
  ".\curriculum\create-and-run-simple-csharp-console-applications\challenge-projects\student-grading-challenge\student-grading-challenge.csproj"

List registered solution projects:

dotnet sln .\freecodecamp-csharp.slnx list

Restore and build the complete solution:

dotnet restore .\freecodecamp-csharp.slnx
dotnet build .\freecodecamp-csharp.slnx

Required final repository result:

Build succeeded.
0 Warning(s)
0 Error(s)

The terminal output confirms that the challenge project ran successfully,the challenge project build succeeded, and the complete thirteen-projectsolution build succeeded.

Key Terms

Term

IPA

Approximate reading

Meaning

challenge project

/ˈtʃæl.ɪndʒ ˈprɒdʒ.ekt/

“cha-lần-ch pro-jẹkt”

dự án thử thách

feature specification

/ˈfiː.tʃər ˌspes.ɪ.fɪˈkeɪ.ʃən/

“phi-chờ spe-si-fi-kây-shần”

đặc tả tính năng

exam average

/ɪɡˈzæm ˈæv.ər.ɪdʒ/

“ịch-zam a-vờ-rịch”

điểm thi trung bình

weighted contribution

/ˈweɪ.tɪd ˌkɒn.trɪˈbjuː.ʃən/

“quây-tịt con-tri-biu-shần”

phần đóng góp có trọng số

extra-credit points

/ˌek.strə ˈkred.ɪt pɔɪnts/

“éc-strờ cre-địt points”

số điểm cộng được quy đổi

running total

/ˌrʌn.ɪŋ ˈtəʊ.təl/

“rân-ning tô-tồ”

tổng tích lũy

report column

/rɪˈpɔːt ˈkɒl.əm/

“ri-port co-lầm”

cột báo cáo

auditability

/ˌɔː.dɪ.təˈbɪl.ə.ti/

“o-đi-tờ-bi-lờ-ti”

khả năng kiểm tra, truy vết

Knowledge Demonstrated

This challenge project demonstrates:

interpreting and implementing an updated feature specification;

preserving an existing application's core behavior;

revising arrays, counters, and calculations;

nested foreach processing;

if-else if-else selection;

separation of exam and extra-credit data;

guarded decimal calculations;

weighted grade calculation;

automatic letter-grade classification;

stable tabular console formatting;

readability-oriented refactoring.

Completion Record

Curriculum item: Challenge Project — Develop foreach and if-elseif-else Structures to Process Array Data in C#
Project: Student Grading Challenge
Official curriculum status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
freeCodeCamp section completion: Confirmed
Completion date: July 23, 2026
Repository project validation: Verified

Final Repository Verification

Challenge project run: Verified
Challenge project output: Verified
Challenge project build: Verified
Full solution build: Verified
Registered solution projects: 13
Build result: Succeeded
Verification date: July 23, 2026

The verified terminal output confirms the expected student grading report andsuccessful compilation of every project registered in freecodecamp-csharp.slnx.

Section Trophy and Achievements

The official completion evidence for this section is stored under:

trophy/
├── README.md
└── assets/
    ├── freecodecamp-section2-completion.png
    └── microsoft-learn-section2-achievement.png

Evidence captured on July 23, 2026 includes:

freeCodeCamp confirmation that Create and Run Simple C# Console Applicationswas completed;

Microsoft Learn achievement issued to Duong Kim Cuong forCreate and run simple C# console applications (Get started with C#, Part 2).

Open Trophy documentation

View freeCodeCamp completion evidence

View Microsoft Learn achievement

Next Step

Proceed to Section 3:

Add Logic to C# Console Applications

Before starting the next section:

verify the challenge-project output;

verify the challenge-project build;

verify the complete thirteen-project solution build;

store the Trophy evidence under trophy/assets/;

update the root repository README;

review the Git diff before commit and push.

Navigation

Repository overview

Previous section — Write Your First Code Using C#

C# review notes