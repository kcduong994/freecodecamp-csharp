# Write Your First Code Using C#

![C#](https://img.shields.io/badge/C%23-Foundations-512BD4?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![freeCodeCamp](https://img.shields.io/badge/freeCodeCamp-Section_1-0A0A23?logo=freecodecamp)
![Status](https://img.shields.io/badge/Status-Completed-16A34A)
![Trophy](https://img.shields.io/badge/Trophy-Verified-16A34A)

This directory documents the complete first section of the
**Foundational C# with Microsoft Certification** curriculum delivered through
freeCodeCamp and Microsoft Learn.

The section contains four instructional modules, two guided projects, executable
C# console applications, detailed study notes, build instructions, and verified
completion evidence.

## Section Status

```text
Section: Write Your First Code Using C#
Status: Completed
Progress: 7 / 7
Instructional modules completed: 4
Guided projects completed: 2
Trophy completed: 1
Microsoft Learn achievement: Earned
freeCodeCamp trophy verification: Passed
Section completion date: July 17, 2026
Next section: Create and Run Simple C# Console Applications
Certification status: In progress
```

[← Back to the repository overview](../../README.md)

[View the Trophy achievement and verification evidence](./trophy/README.md)

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

## Section Structure

```text
write-your-first-code-using-csharp/
├── README.md
├── modules/
│   ├── first-csharp-code/
│   │   ├── Program.cs
│   │   └── first-csharp-code.csproj
│   ├── literals-and-variables/
│   │   ├── Program.cs
│   │   └── literals-and-variables.csproj
│   ├── string-formatting/
│   │   ├── Program.cs
│   │   └── string-formatting.csproj
│   └── number-operations/
│       ├── Program.cs
│       └── number-operations.csproj
├── guided-projects/
│   ├── calculate-student-grades/
│   │   ├── Program.cs
│   │   └── calculate-student-grades.csproj
│   └── calculate-final-gpa/
│       ├── Program.cs
│       └── calculate-final-gpa.csproj
└── trophy/
    ├── README.md
    └── assets/
        ├── microsoft-learn-achievement-write-your-first-csharp-code-2026-07-12.png
        └── trophy-verified-2026-07-17.png
```

The directories have distinct responsibilities:

- `modules/` contains the four Microsoft Learn instructional projects;
- `guided-projects/` contains the two applied console projects;
- `trophy/` contains completion evidence and verification notes;
- this `README.md` is the main curriculum record for the entire section.

---

## Section Curriculum Items

Final progress:

```text
7 / 7 — Completed
```

| No. | Curriculum item | Type | Status |
| ---: | --- | --- | --- |
| 1 | Write Your First C# Code | Instructional module | Completed |
| 2 | Store and Retrieve Data Using Literal and Variable Values in C# | Instructional module | Completed |
| 3 | Perform Basic String Formatting in C# | Instructional module | Completed |
| 4 | Perform Basic Operations on Numbers in C# | Instructional module | Completed |
| 5 | Guided Project — Calculate and Print Student Grades | Guided project | Completed |
| 6 | Guided Project — Calculate Final GPA | Guided project | Completed |
| 7 | Trophy — Write Your First Code Using C# | Verified Trophy | Completed |

The Microsoft Learn achievement was earned and the section Trophy was
successfully verified by freeCodeCamp.

[Open the completion evidence](./trophy/README.md)

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

### Perform Basic Operations on Numbers in C#

Location:

```text
curriculum/write-your-first-code-using-csharp/modules/number-operations/
```

This module introduces arithmetic expressions, numeric division behavior,
explicit casting, remainder calculations, operator precedence, and concise ways
to update numeric variables.

Topics covered:

- addition with integer values;
- string concatenation with numeric values;
- overloaded behavior of the `+` operator;
- left-to-right expression evaluation;
- parentheses and explicit evaluation order;
- addition, subtraction, multiplication, and division;
- integer division and truncation toward zero;
- decimal division using the `m` suffix;
- implicit numeric conversion;
- explicit casting from `int` to `decimal`;
- the remainder operator `%`;
- divisibility checks;
- operator precedence;
- compound assignment operators such as `+=` and `-=`;
- increment and decrement operators;
- prefix and postfix increment behavior;
- numeric formatting with `F1`;
- Fahrenheit-to-Celsius conversion.

#### Addition and String Concatenation

```csharp
int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine(firstNumber + secondNumber);
```

Expected output:

```text
19
```

The `+` operator performs numeric addition when both operands are numeric.
However, when one operand is a string, the same operator performs string
concatenation.

```csharp
string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
```

Expected output:

```text
Bob sold 7 widgets.
```

Because operators of equal precedence are evaluated from left to right, the
following expression concatenates the values as text:

```csharp
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
```

Expected output:

```text
Bob sold 77 widgets.
```

Parentheses force the numeric addition to occur first:

```csharp
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
```

Expected output:

```text
Bob sold 14 widgets.
```

#### Integer and Decimal Division

```csharp
int integerQuotient = 7 / 5;
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine(integerQuotient);
Console.WriteLine(decimalQuotient);
```

Expected output:

```text
1
1.4
```

When both operands are `int`, C# performs integer division and discards the
fractional part. To preserve the decimal result, at least one operand must use a
floating-point type such as `decimal`.

The `m` suffix marks a numeric literal as `decimal`.

#### Explicit Casting

```csharp
int dividend = 7;
int divisor = 5;

decimal quotient = (decimal)dividend / divisor;

Console.WriteLine(quotient);
```

Expected output:

```text
1.4
```

Casting one operand to `decimal` causes the other integer operand to be
implicitly converted for the division operation.

#### Remainder Operator

```csharp
Console.WriteLine(200 % 5);
Console.WriteLine(7 % 5);
```

Expected output:

```text
0
2
```

The `%` operator returns the remainder after division. A remainder of zero means
that the dividend is evenly divisible by the divisor.

#### Operator Precedence

```csharp
int valueWithoutParentheses = 3 + 4 * 5;
int valueWithParentheses = (3 + 4) * 5;

Console.WriteLine(valueWithoutParentheses);
Console.WriteLine(valueWithParentheses);
```

Expected output:

```text
23
35
```

Multiplication is evaluated before addition unless parentheses explicitly change
the order.

#### Increment and Decrement

```csharp
int counter = 1;

counter++;
Console.WriteLine(counter);

counter--;
Console.WriteLine(counter);
```

Expected output:

```text
2
1
```

The `++` operator increases a variable by one, while `--` decreases it by one.

Prefix and postfix forms differ when the expression value is used:

```csharp
int value = 1;

Console.WriteLine(value++);
Console.WriteLine(value);
Console.WriteLine(++value);
```

Expected output:

```text
1
2
3
```

Postfix increment returns the current value before incrementing. Prefix
increment updates the variable first and then returns the new value.

#### Module Challenge

```csharp
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * 5m / 9m;

Console.WriteLine($"The temperature is {celsius:F1} Celsius.");
```

Expected output:

```text
The temperature is 34.4 Celsius.
```

The `F1` format specifier displays exactly one digit after the decimal point.

Intentional invalid examples from the module are preserved as comments or study
notes so that the final project remains buildable.

Microsoft Learn confirmed completion of the module and its assessment.

---

## Completed Guided Projects

### Calculate and Print Student Grades

Location:

```text
curriculum/write-your-first-code-using-csharp/guided-projects/calculate-student-grades/
```

This guided project applies the foundational C# concepts introduced in the first
four modules to a small student-grading application.

The application:

- stores five assignment scores for each of four students;
- calculates the total assignment score for each student;
- calculates each student's average score;
- preserves fractional results by casting an integer value to `decimal`;
- displays student names, numeric grades, and manually assigned letter grades;
- formats the final report with tab and new-line escape sequences.

#### Input Data

| Student | Assignment scores |
| --- | --- |
| Sophia | 93, 87, 98, 95, 100 |
| Nicolas | 80, 83, 82, 88, 85 |
| Zahirah | 84, 96, 73, 85, 79 |
| Jeong | 90, 92, 98, 100, 97 |

#### Calculating Totals

```csharp
int sophiaSum =
    sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
```

The expected totals are:

| Student | Total |
| --- | ---: |
| Sophia | 473 |
| Nicolas | 418 |
| Zahirah | 417 |
| Jeong | 477 |

#### Calculating Averages

```csharp
decimal sophiaScore =
    (decimal)sophiaSum / currentAssignments;
```

Casting the sum to `decimal` before division prevents integer division from
discarding the fractional part.

For example:

```text
473 / 5 = 94
(decimal)473 / 5 = 94.6
```

Only one operand needs to be cast because C# implicitly converts the other
integer operand for the decimal calculation.

#### Formatting the Report

```csharp
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"{sophiaName}:\t\t{sophiaScore}\tA");
Console.WriteLine($"{nicolasName}:\t{nicolasScore}\tB");
Console.WriteLine($"{zahirahName}:\t{zahirahScore}\tB");
Console.WriteLine($"{jeongName}:\t\t{jeongScore}\tA");
```

Expected output:

```text
Student         Grade

Sophia:         94.6    A
Nicolas:        83.6    B
Zahirah:        83.4    B
Jeong:          95.4    A
```

The letter grades are assigned directly in this guided project because
conditional statements such as `if` and `else` have not yet been introduced.

Key concepts reinforced:

- problem decomposition;
- variable declaration and initialization;
- integer and decimal data types;
- arithmetic expressions;
- integer division;
- explicit casting;
- string interpolation;
- `\t` and `\n` escape sequences;
- incremental development and output verification.

Microsoft Learn confirmed completion of the guided project and its assessment.

---

### Calculate Final GPA

Location:

```text
curriculum/write-your-first-code-using-csharp/guided-projects/calculate-final-gpa/
```

This guided project develops a console-based GPA calculator for one student.
It reinforces the arithmetic, data-type, casting, string-formatting, and
problem-decomposition skills introduced throughout the first curriculum section.

The application:

- stores the student's name;
- stores five course names;
- stores the numeric grade assigned to each course;
- stores the credit-hour value of each course;
- calculates the total number of credit hours;
- calculates weighted grade points for every course;
- divides the total grade points by the total credit hours;
- preserves the decimal portion of the GPA using explicit casting;
- extracts the required digits for the course-specified output format;
- displays a tabular course report and the final GPA.

#### Student and Course Data

| Course | Numeric grade | Credit hours | Grade points |
| --- | ---: | ---: | ---: |
| English 101 | 4 | 3 | 12 |
| Algebra 101 | 3 | 3 | 9 |
| Biology 101 | 3 | 4 | 12 |
| Computer Science I | 3 | 4 | 12 |
| Psychology 101 | 4 | 3 | 12 |
| **Total** |  | **17** | **57** |

The grade-point value for one course is calculated as:

```text
course grade points = numeric grade × credit hours
```

For example:

```text
English 101 grade points = 4 × 3 = 12
```

The final GPA is a weighted average rather than a simple arithmetic mean:

```text
GPA = total grade points / total credit hours
GPA = 57 / 17
GPA = 3.352941...
```

#### Preventing Integer Division

Both totals are stored as `int` values. Dividing one integer by another would
perform integer division and discard the fractional part.

Incorrect for GPA calculation:

```csharp
decimal gradePointAverage = totalGradePoints / totalCreditHours;
```

The project therefore casts one operand to `decimal` before division:

```csharp
decimal gradePointAverage =
    (decimal)totalGradePoints / totalCreditHours;
```

Once one operand is converted to `decimal`, C# performs decimal division and
preserves the fractional result.

#### Accumulating Totals

The `+=` compound-assignment operator is used to increment the running totals:

```csharp
int totalCreditHours = 0;

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;
```

The weighted grade points are accumulated in the same way:

```csharp
int totalGradePoints = 0;

totalGradePoints += course1Grade * course1Credit;
totalGradePoints += course2Grade * course2Credit;
totalGradePoints += course3Grade * course3Credit;
totalGradePoints += course4Grade * course4Credit;
totalGradePoints += course5Grade * course5Credit;
```

This incremental structure makes the calculation easier to verify course by
course and demonstrates how a larger task can be decomposed into smaller steps.

#### Extracting the Display Digits

The Microsoft Learn exercise formats the GPA by extracting the leading digit and
the first two digits after the decimal point:

```csharp
int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;
```

For a GPA of `3.352941...`:

```text
leadingDigit = 3
firstDigit   = 3
secondDigit  = 5
```

The values are then combined as:

```csharp
Console.WriteLine(
    $"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
```

This exercise intentionally demonstrates casting and the remainder operator.
It truncates the output to two decimal places rather than applying mathematical
rounding.

In production code, numeric formatting would normally be clearer:

```csharp
Console.WriteLine($"Final GPA: {gradePointAverage:F2}");
```

However, the curriculum implementation is preserved because its purpose is to
teach casting, multiplication by powers of ten, and `%`.

#### Console Formatting

The report uses:

- string interpolation with `$"..."`;
- `\n` to create a new line;
- `\t` to create tab stops;
- separate tab counts to align course names of different lengths.

Core output statements:

```csharp
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine(
    $"{course1Name}\t\t{course1Grade}\t{course1Credit}");

Console.WriteLine(
    $"{course4Name}\t{course4Grade}\t{course4Credit}");

Console.WriteLine(
    $"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
```

Expected output:

```text
Student: Sophia Johnson

Course                  Grade   Credit Hours
English 101             4       3
Algebra 101             3       3
Biology 101             3       4
Computer Science I      3       4
Psychology 101          4       3

Final GPA:              3.35
```

Key concepts reinforced:

- breaking a larger application into smaller tasks;
- choosing `string`, `int`, and `decimal` data types;
- declaring and initializing variables;
- mapping letter grades to numeric grade values;
- weighted-average calculations;
- compound assignment with `+=`;
- multiplication and division;
- integer division;
- explicit casting;
- truncation through casting;
- remainder calculations with `%`;
- string interpolation;
- escape sequences;
- aligned console output;
- validating intermediate totals;
- comparing calculated output with a specification.

Microsoft Learn shows the guided-project assessment as passed.

The completed project also provides a foundation for later refactoring with:

- arrays or lists for course data;
- loops for repeated calculations;
- classes or records for course models;
- reusable methods;
- validation of user input;
- mathematically rounded GPA output.

These improvements are intentionally deferred until the corresponding C#
concepts are introduced by the curriculum.


## Section Trophy

The Microsoft Learn achievement associated with this curriculum was earned, and
freeCodeCamp successfully verified the Trophy after all required modules and
guided projects were completed.

```text
Trophy: Write Your First Code Using C#
Microsoft Learn achievement: Earned
freeCodeCamp verification: Passed
Section progress: 7 / 7
Verification date: July 17, 2026
```

Evidence is maintained separately so that this curriculum README remains focused
on learning content:

[View Microsoft Learn achievement and freeCodeCamp verification evidence](./trophy/README.md)

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

## Curriculum Documentation Standard

This repository is maintained as a structured learning curriculum rather than a
collection of disconnected code samples.

Every completed module or guided project should document:

- the official curriculum title;
- its location in the repository;
- the learning objectives;
- the C# concepts introduced or reinforced;
- representative code examples;
- expected output;
- important compiler behavior;
- intentional errors used for learning;
- the reason behind important implementation choices;
- completion status on Microsoft Learn or freeCodeCamp;
- any concepts intentionally deferred to later curriculum sections.

A curriculum item is considered complete in this repository only when:

1. the official lesson units have been completed;
2. the corresponding assessment has been passed;
3. the local project runs successfully;
4. the project is included in `freecodecamp-csharp.slnx`;
5. the full solution builds without errors;
6. the README progress and project list are updated;
7. relevant review notes are preserved;
8. the Git diff has been reviewed before commit.

This standard keeps the repository useful for:

- certification review;
- future relearning;
- code portfolio evidence;
- debugging practice;
- tracking conceptual progression;
- comparing beginner implementations with later refactors.

---

## Repository Organization

### Curriculum

The `curriculum` directory mirrors the major freeCodeCamp curriculum sections.

Each section may contain normal modules, guided projects, and trophy evidence.

### Review Notes

The [`CSHARP_REVIEW.md`](../../CSHARP_REVIEW.md) file contains independently written
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

## Section Progress

| Category | Completed | Status |
| --- | ---: | --- |
| Curriculum items | 7 | Completed |
| Instructional modules | 4 | Completed |
| Guided projects | 2 | Completed |
| Trophies | 1 | Completed |

Final section progress:

```text
Write Your First Code Using C#: 7 / 7 — Completed
```

The overall certification remains in progress because the later curriculum
sections and the certification exam have not yet been completed.

---

## Solution

Run the commands in this section from the repository root:

```text
freecodecamp-csharp/
```

Solution file:

```text
freecodecamp-csharp.slnx
```

Projects currently included after migration:

```text
curriculum/write-your-first-code-using-csharp/modules/first-csharp-code/first-csharp-code.csproj
curriculum/write-your-first-code-using-csharp/modules/literals-and-variables/literals-and-variables.csproj
curriculum/write-your-first-code-using-csharp/modules/string-formatting/string-formatting.csproj
curriculum/write-your-first-code-using-csharp/modules/number-operations/number-operations.csproj
curriculum/write-your-first-code-using-csharp/guided-projects/calculate-student-grades/calculate-student-grades.csproj
curriculum/write-your-first-code-using-csharp/guided-projects/calculate-final-gpa/calculate-final-gpa.csproj
```

Build command:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Run the completed student-grades project:

```powershell
dotnet run --project `
  ".\curriculum\write-your-first-code-using-csharp\guided-projects\calculate-student-grades\calculate-student-grades.csproj"
```

Run the completed final-GPA project:

```powershell
dotnet run --project `
  ".\curriculum\write-your-first-code-using-csharp\guided-projects\calculate-final-gpa\calculate-final-gpa.csproj"
```

The full solution build must be verified before each curriculum commit.

---

## Next Curriculum Section

### Create and Run Simple C# Console Applications

The first section is now complete. The repository will continue with:

```text
Create and Run Simple C# Console Applications
```

The next section will build on the foundations established here and introduce
more structured console-application development using the .NET class library,
arrays, decisions, iteration, and increasingly maintainable program logic.

No content from the next section is counted as complete until its official
freeCodeCamp and Microsoft Learn activities have been completed and its local
projects have been validated.

---

## Curriculum Links

Foundational C# with Microsoft Certification:

https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/

Microsoft Learn C# training:

https://learn.microsoft.com/training/paths/get-started-c-sharp-part-1/

---

## Navigation

- [Repository overview](../../README.md)
- [Trophy evidence](./trophy/README.md)
- [C# review notes](../../CSHARP_REVIEW.md)

---

## Author

**Duong Kim Cuong**

GitHub: https://github.com/kcduong994