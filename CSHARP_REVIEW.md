# C# Complete Review

> **From zero programming knowledge to confident C# foundations**
>
> A beginner-first review handbook for the **Foundational C# with Microsoft** curriculum, organized by concept rather than by lesson order.

<p align="center">
  <img alt="C#" src="https://img.shields.io/badge/C%23-Complete_Review-512BD4">
  <img alt="Level" src="https://img.shields.io/badge/Level-Beginner_Friendly-16A34A">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-Foundations-512BD4">
  <img alt="Style" src="https://img.shields.io/badge/Style-Learn_by_Reasoning-2563EB">
</p>

---

## Why This File Exists

The repository README files answer questions such as:

```text
Which course section is this?
Which module was completed?
Which project belongs to the lesson?
Did the project build successfully?
Where is the source code?
```

This file answers a different set of questions:

```text
What does this C# concept mean?
Why does it exist?
How do I write it?
How do I read it?
What mistakes should I avoid?
How do the concepts connect?
```

So this is **not another progress log** and it is **not a copy of the curriculum README files**.

It is a **concept handbook**.

The goal is that someone who has never programmed before can start at the top, run the examples, and gradually build a correct mental model of C#.

---

# Start Here — What Is Programming?

A computer is extremely fast, but it does not understand intention.

It follows instructions.

A **program** is a set of instructions that tells the computer:

```text
what data exists
        ↓
what should happen to that data
        ↓
what decisions should be made
        ↓
what result should be produced
```

A tiny C# program can be only one line:

```csharp
Console.WriteLine("Hello, World!");
```

Read it from left to right:

```text
Console
→ something provided by .NET for console input/output

.

WriteLine
→ a method that writes a line of text

("Hello, World!")
→ the value passed to that method

;
→ the statement ends here
```

That one line already contains several ideas that appear throughout programming:

- a library type;
- a method;
- an argument;
- a string;
- a statement;
- syntax rules.

Do not try to memorize everything at once.

Programming becomes easier when each new idea is attached to an idea you already understand.

---

# How to Use This Review

A good learning cycle is:

```text
READ
  ↓
TYPE THE EXAMPLE YOURSELF
  ↓
RUN IT
  ↓
CHANGE ONE THING
  ↓
PREDICT WHAT WILL HAPPEN
  ↓
RUN IT AGAIN
  ↓
EXPLAIN THE RESULT IN YOUR OWN WORDS
```

Use three passes:

### Pass 1 — Understand

Focus on the plain-language explanation.

### Pass 2 — Reproduce

Type the examples without copy/paste.

### Pass 3 — Recall

Close the file and try to recreate the idea from memory.

You do **not** need to remember every method name.

You do need to understand:

```text
what problem a feature solves
when to use it
what can go wrong
how to verify the result
```

---

# Learning Map

| Stage | Main question |
| --- | --- |
| 1. Program Structure | Where does execution begin? |
| 2. Variables and Literals | How do I store values? |
| 3. Data Types | What kind of value is this? |
| 4. Strings and Formatting | How do I work with text? |
| 5. Arithmetic and Operators | How do I calculate? |
| 6. Type Conversion | How do I move values between types? |
| 7. Boolean Expressions | How does a program decide true or false? |
| 8. `if` / `else` / `switch` | How does a program choose a path? |
| 9. Arrays | How do I store many related values? |
| 10. `foreach` | How do I process every item? |
| 11. `for` / `while` / `do-while` | How do I repeat work? |
| 12. Variable Scope | Where can a variable be used? |
| 13. Methods | How do I package reusable behavior? |
| 14. Parameters and Arguments | How do methods receive input? |
| 15. Return Values | How do methods send results back? |
| 16. Optional Parameters | How do I provide sensible defaults? |
| 17. Arrays as Method Arguments | What happens when methods receive arrays? |
| 18. String Methods | How do I search and modify text? |
| 19. Array Helper Methods | How do I sort, reverse, and inspect arrays? |
| 20. Debugging | How do I find why code behaves incorrectly? |
| 21. Exceptions | How does C# represent runtime failures? |
| 22. `try` / `catch` / `finally` | How do I handle expected runtime failures? |
| 23. `throw` / rethrow | How do I report failures deliberately? |
| 24. Common Compiler Errors | How do I read compile-time failures? |
| 25. Common Logic Bugs | Why can valid code still be wrong? |
| 26. .NET CLI | How do I create, build, and run projects? |
| 27. Patterns Worth Remembering | Which reusable solutions appear repeatedly? |
| 28. Quick Reference | What syntax do I need at a glance? |

---

# Pronunciation Guide for Core Terms

| English term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| program | `/ˈprəʊ.ɡræm/` | “prâu-gram” | chương trình |
| programming | `/ˈprəʊ.ɡræm.ɪŋ/` | “prâu-gra-ming” | lập trình |
| variable | `/ˈveə.ri.ə.bəl/` | “ve-ri-ờ-bồ” | biến |
| literal | `/ˈlɪt.ər.əl/` | “li-tờ-rồ” | giá trị viết trực tiếp trong code |
| data type | `/ˈdeɪ.tə taɪp/` | “đây-tờ taip” | kiểu dữ liệu |
| string | `/strɪŋ/` | “string” | chuỗi văn bản |
| operator | `/ˈɒp.ər.eɪ.tər/` | “o-pờ-rây-tờ” | toán tử |
| conversion | `/kənˈvɜː.ʃən/` | “cần-vơ-shần” | chuyển đổi |
| Boolean | `/ˈbuː.li.ən/` | “bu-li-ần” | kiểu/biểu thức đúng-sai |
| condition | `/kənˈdɪʃ.ən/` | “cần-đi-shần” | điều kiện |
| array | `/əˈreɪ/` | “ờ-rây” | mảng |
| loop | `/luːp/` | “lúp” | vòng lặp |
| scope | `/skəʊp/` | “skâu-p” | phạm vi |
| method | `/ˈmeθ.əd/` | “me-thợd” | phương thức |
| parameter | `/pəˈræm.ɪ.tər/` | “pờ-ra-mi-tờ” | tham số khai báo |
| argument | `/ˈɑːɡ.jə.mənt/` | “a-giu-mần-t” | giá trị truyền vào |
| return value | `/rɪˈtɜːn ˈvæl.juː/` | “ri-tơn va-liu” | giá trị trả về |
| debugging | `/ˌdiːˈbʌɡ.ɪŋ/` | “đi-bấ-ging” | gỡ lỗi |
| debugger | `/ˌdiːˈbʌɡ.ər/` | “đi-bấ-gờ” | công cụ gỡ lỗi |
| exception | `/ɪkˈsep.ʃən/` | “ịch-sep-shần” | ngoại lệ |
| compiler | `/kəmˈpaɪ.lər/` | “cầm-pai-lờ” | trình biên dịch |
| logic bug | `/ˈlɒdʒ.ɪk bʌɡ/` | “lo-jik bấg” | lỗi logic |
| command line | `/kəˈmɑːnd laɪn/` | “cờ-mand lain” | dòng lệnh |
| pattern | `/ˈpæt.ən/` | “pa-tần” | mẫu giải pháp lặp lại |
| cheat sheet | `/ˈtʃiːt ʃiːt/` | “chít shít” | bảng tra cứu nhanh |

---

# Table of Contents

1. [C# Program Structure](#1-c-program-structure)
2. [Variables and Literals](#2-variables-and-literals)
3. [Data Types](#3-data-types)
4. [Strings and Formatting](#4-strings-and-formatting)
5. [Arithmetic and Operators](#5-arithmetic-and-operators)
6. [Type Conversion](#6-type-conversion)
7. [Boolean Expressions](#7-boolean-expressions)
8. [`if` / `else` / `switch`](#8-if--else--switch)
9. [Arrays](#9-arrays)
10. [`foreach`](#10-foreach)
11. [`for` / `while` / `do-while`](#11-for--while--do-while)
12. [Variable Scope](#12-variable-scope)
13. [Methods](#13-methods)
14. [Parameters and Arguments](#14-parameters-and-arguments)
15. [Return Values](#15-return-values)
16. [Optional Parameters](#16-optional-parameters)
17. [Arrays as Method Arguments](#17-arrays-as-method-arguments)
18. [String Methods](#18-string-methods)
19. [Array Helper Methods](#19-array-helper-methods)
20. [Debugging](#20-debugging)
21. [Exceptions](#21-exceptions)
22. [`try` / `catch` / `finally`](#22-try--catch--finally)
23. [`throw` / rethrow](#23-throw--rethrow)
24. [Common Compiler Errors](#24-common-compiler-errors)
25. [Common Logic Bugs](#25-common-logic-bugs)
26. [.NET CLI Quick Reference](#26-net-cli-quick-reference)
27. [Patterns Worth Remembering](#27-patterns-worth-remembering)
28. [C# Quick Reference / Cheat Sheet](#28-c-quick-reference--cheat-sheet)

---

# 1. C# Program Structure

## The idea in one sentence

A C# program is a sequence of statements organized into code blocks, methods, types, and projects.

For beginner console applications, the simplest form uses **top-level statements**:

```csharp
Console.WriteLine("Hello, World!");
```

Execution starts at the first top-level statement and proceeds downward unless control flow changes that path.

## Statements and blocks

A statement is an instruction:

```csharp
int age = 20;
age = age + 1;
Console.WriteLine(age);
```

Most simple statements end with `;`.

Curly braces create a block:

```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
```

Blocks appear in decisions, loops, methods, and exception handling.

## Comments

```csharp
// Single-line comment

/*
Multi-line
comment
*/
```

Use comments to explain **why**, assumptions, business rules, or non-obvious reasoning.

Avoid comments that merely repeat the code.

## Traditional `Main`

You may also see:

```csharp
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

For beginners:

```text
top-level statements
≈
a simpler way to write entry-point logic
```

## C# and .NET

C# is the language.

.NET provides the runtime, libraries, project tooling, and APIs such as `Console`, `Math`, `Random`, `Array`, and `String`.

```text
C# source code
      ↓
compiler
      ↓
.NET application
      ↓
.NET runtime
      ↓
operating system
```

## First complete example

```csharp
string name = "Ada";
int age = 20;

Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"Next year you will be {age + 1}.");
```

This already contains variables, types, literals, arithmetic, interpolation, method calls, and output.

### Beginner rule

When code feels confusing, ask:

```text
1. What data exists?
2. What line runs next?
3. What value does each variable have now?
4. What condition changes the path?
5. What method am I entering or leaving?
```

---

# 2. Variables and Literals

## Variable = a named place for a value

```csharp
int score = 95;
```

Read it as:

```text
int   → store an integer
score → variable name
=     → assign
95    → value
```

### Declaration

```csharp
int score;
```

### Assignment

```csharp
score = 95;
```

### Initialization

```csharp
int score = 95;
```

### Reassignment

```csharp
score = 100;
```

The previous value is replaced.

## Literal

A literal is a value written directly in code:

```csharp
42
"Hello"
'A'
true
12.5m
```

## Naming

Prefer meaning:

```csharp
int customerAge;
decimal accountBalance;
string firstName;
bool isActive;
```

Local variables normally use `camelCase`.

## `var`

```csharp
var name = "Ada";
var age = 20;
var price = 12.50m;
```

C# infers:

```text
name  → string
age   → int
price → decimal
```

`var` does **not** make C# dynamically typed. The inferred type is still fixed.

## Mini challenge

Predict:

```csharp
int points = 10;

points = points + 5;
points += 2;
points++;

Console.WriteLine(points);
```

Answer:

```text
18
```

---

# 3. Data Types

## Why types exist

Compare:

```text
10 + 20       → 30
"10" + "20"   → "1020"
```

The type changes what the operation means.

## Core types

| Type | Example | Typical use |
| --- | --- | --- |
| `int` | `42` | whole numbers |
| `decimal` | `19.95m` | money / base-10 precision |
| `double` | `3.14159` | general floating-point calculations |
| `float` | `3.14f` | lower-precision floating point |
| `bool` | `true` | true/false state |
| `char` | `'A'` | one character |
| `string` | `"Hello"` | text |

### `int`

```csharp
int people = 25;
int temperature = -5;
```

### `decimal`

```csharp
decimal price = 19.95m;
decimal taxRate = 0.10m;
```

The `m` suffix identifies a decimal literal.

### `double`

```csharp
double distance = 12.75;
```

Floating-point values are binary approximations, so not every decimal fraction can be represented exactly.

### `bool`

```csharp
bool isLoggedIn = true;
bool isFinished = false;
```

### `char` versus `string`

```csharp
char grade = 'A';
string gradeText = "A";
```

```text
'A' → char
"A" → string
```

## Choosing a type

Ask:

```text
What values are possible?
Will there be decimals?
Is this money?
Is this text?
Is this only true/false?
Could the range become very large?
```

Type choice should reflect the **meaning of the data**.

---

# 4. Strings and Formatting

## String = text

```csharp
string message = "Hello";
```

## Concatenation

```csharp
string firstName = "Ada";
string lastName = "Lovelace";

string fullName =
    firstName +
    " " +
    lastName;
```

## String interpolation

```csharp
string name = "Ada";
int age = 20;

Console.WriteLine(
    $"Name: {name}, Age: {age}");

Console.WriteLine(
    $"Next year: {age + 1}");
```

The `$` activates interpolation. Expressions inside `{ ... }` are evaluated as C#.

## Escape sequences

| Sequence | Meaning |
| --- | --- |
| `\n` | new line |
| `\t` | tab |
| `\"` | double quote |
| `\\` | backslash |

```csharp
Console.WriteLine(
    "Name:\tAda\nRole:\tDeveloper");
```

## Verbatim strings

```csharp
string path =
    @"C:\Users\Ada\Documents";
```

Interpolated verbatim:

```csharp
string user = "Ada";

string path =
    $@"C:\Users\{user}\Documents";
```

## Numeric formatting

```csharp
decimal price = 1234.5m;

Console.WriteLine($"{price:C}");
Console.WriteLine($"{price:N2}");
```

Common formats:

| Format | Purpose |
| --- | --- |
| `C` | currency |
| `N` | number with separators |
| `N2` | two decimal places |
| `P` | percentage |

The exact display can depend on the current culture.

## Alignment

```csharp
string item = "Book";
decimal price = 12.5m;

Console.WriteLine(
    $"{item,-10}{price,10:C}");
```

```text
negative alignment → left
positive alignment → right
```

## Strings are immutable

```csharp
string original = "hello";
string upper = original.ToUpper();

Console.WriteLine(original);
Console.WriteLine(upper);
```

Most string methods return a **new string** rather than modifying the original.

---

# 5. Arithmetic and Operators

## Core operators

| Operator | Meaning |
| --- | --- |
| `+` | addition |
| `-` | subtraction |
| `*` | multiplication |
| `/` | division |
| `%` | remainder |

```csharp
int a = 10;
int b = 3;

Console.WriteLine(a + b); // 13
Console.WriteLine(a - b); // 7
Console.WriteLine(a * b); // 30
Console.WriteLine(a / b); // 3
Console.WriteLine(a % b); // 1
```

## Integer division

```csharp
int result = 5 / 2;
```

Result:

```text
2
```

The fractional part is discarded.

To keep it:

```csharp
decimal result =
    5m / 2m;
```

Result:

```text
2.5
```

## Precedence

```csharp
int result =
    2 + 3 * 4;
```

Result:

```text
14
```

Use parentheses to communicate intention:

```csharp
int result =
    (2 + 3) * 4;
```

Result:

```text
20
```

## Increment / decrement

```csharp
count++;
count--;
```

## Compound assignment

```csharp
score += 5;
score -= 2;
score *= 3;
score /= 2;
```

## Remainder `%`

```csharp
if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
```

```text
even % 2 → 0
odd  % 2 → 1
```

---

# 6. Type Conversion

## Why conversion exists

Programs often receive data in one type but need another:

```text
user types "42"
        ↓
program needs int 42

decimal calculation
        ↓
program needs text for display
```

Different conversion techniques exist because the risks differ.

## Implicit conversion

Safe enough for C# to do automatically:

```csharp
int count = 10;
long largeCount = count;
```

Mental model:

```text
smaller compatible range
        ↓
larger compatible range
```

## Explicit cast

```csharp
decimal value =
    12.9m;

int whole =
    (int)value;
```

Result:

```text
12
```

Important:

```text
decimal → int cast
does not round
it discards the fractional part
```

## `Convert`

```csharp
string text = "42";

int number =
    Convert.ToInt32(text);
```

Invalid input can throw an exception.

## `Parse`

```csharp
int number =
    int.Parse("42");
```

Read it as:

```text
interpret this text as an integer
```

Invalid text such as `"hello"` throws.

## `TryParse`

Use when input may be invalid:

```csharp
string input = "42";

bool success =
    int.TryParse(
        input,
        out int number);
```

If successful:

```text
success → true
number  → converted value
```

If not:

```text
success → false
```

## Beginner-safe input pattern

```csharp
Console.Write(
    "Enter an integer: ");

string? input =
    Console.ReadLine();

if (
    int.TryParse(
        input,
        out int number))
{
    Console.WriteLine(
        $"You entered {number}.");
}
else
{
    Console.WriteLine(
        "That was not a valid integer.");
}
```

## To string

```csharp
int age = 20;

string text =
    age.ToString();
```

For display, interpolation is often clearer:

```csharp
Console.WriteLine(
    $"Age: {age}");
```

## Conversion chooser

| Situation | Prefer |
| --- | --- |
| safe automatic widening | implicit conversion |
| intentional narrowing | explicit cast |
| trusted text | `Parse` / `Convert` |
| possibly invalid text | `TryParse` |
| display as text | interpolation / `ToString()` |

Before converting, ask:

```text
Can information be lost?
Can the input be invalid?
Should failure be expected?
```

---

# 7. Boolean Expressions

## Boolean = true or false

```csharp
bool isReady =
    true;
```

Comparisons also produce Boolean values:

```csharp
int age = 20;

bool isAdult =
    age >= 18;
```

## Comparison operators

| Operator | Meaning |
| --- | --- |
| `==` | equal |
| `!=` | not equal |
| `>` | greater than |
| `<` | less than |
| `>=` | greater than or equal |
| `<=` | less than or equal |

## Logical AND `&&`

Both sides must be true:

```csharp
int age = 25;
bool hasTicket = true;

bool canEnter =
    age >= 18 &&
    hasTicket;
```

```text
true  && true  → true
true  && false → false
false && true  → false
false && false → false
```

## Logical OR `||`

At least one side must be true:

```csharp
bool isAdmin = false;
bool isOwner = true;

bool canEdit =
    isAdmin ||
    isOwner;
```

## Logical NOT `!`

Reverse a Boolean:

```csharp
bool isLocked = false;

if (!isLocked)
{
    Console.WriteLine(
        "Available");
}
```

## Short-circuit behavior

For:

```csharp
conditionA &&
conditionB
```

if `conditionA` is false, C# does not need `conditionB`.

For:

```csharp
conditionA ||
conditionB
```

if `conditionA` is true, C# does not need `conditionB`.

This can prevent unnecessary or unsafe evaluation.

## Conditional operator `?:`

```csharp
string result =
    score >= 60
        ? "Pass"
        : "Fail";
```

Read:

```text
condition
?
value if true
:
value if false
```

Use it only when readability remains good.

---

# 8. `if` / `else` / `switch`

## `if`

```csharp
int temperature = 30;

if (temperature > 25)
{
    Console.WriteLine(
        "It is warm.");
}
```

## `if` / `else`

```csharp
int score = 55;

if (score >= 60)
{
    Console.WriteLine(
        "Pass");
}
else
{
    Console.WriteLine(
        "Fail");
}
```

Exactly one branch runs.

## `else if`

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else if (score >= 70)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine(
        "Needs improvement");
}
```

## Order matters

Correct threshold order:

```text
highest / most specific
        ↓
lower
        ↓
lower
        ↓
default
```

Wrong:

```csharp
if (score >= 70)
{
    Console.WriteLine("Bronze");
}
else if (score >= 90)
{
    Console.WriteLine("Gold");
}
```

A score of `95` already matches `>= 70`, so the `Gold` branch never gets used.

## `switch`

Use for several discrete cases of one value:

```csharp
string command =
    "start";

switch (command)
{
    case "start":
        Console.WriteLine(
            "Starting...");
        break;

    case "stop":
        Console.WriteLine(
            "Stopping...");
        break;

    case "pause":
        Console.WriteLine(
            "Pausing...");
        break;

    default:
        Console.WriteLine(
            "Unknown command");
        break;
}
```

## Decision chooser

| Situation | Good choice |
| --- | --- |
| one condition | `if` |
| two alternatives | `if` / `else` |
| ordered ranges | `if` / `else if` |
| one value with many discrete cases | `switch` |

---

# 9. Arrays

## Array = many values of the same type

```csharp
int[] scores =
{
    90,
    85,
    72
};
```

Mental model:

```text
scores
┌──────┬──────┬──────┐
│  90  │  85  │  72  │
└──────┴──────┴──────┘
   0      1      2
```

Indexes start at:

```text
0
```

## Read an element

```csharp
Console.WriteLine(
    scores[0]);
```

## Change an element

```csharp
scores[1] =
    100;
```

## Length

```csharp
Console.WriteLine(
    scores.Length);
```

The last valid index is:

```text
Length - 1
```

## Create a fixed-size array

```csharp
string[] names =
    new string[3];

names[0] = "Ada";
names[1] = "Grace";
names[2] = "Linus";
```

Array length is fixed after creation.

## Default values

```csharp
int[] values =
    new int[3];
```

starts conceptually as:

```text
0, 0, 0
```

A `bool[]` starts with:

```text
false, false, false
```

## Index safety

This is invalid at runtime:

```csharp
int[] values =
{
    10,
    20,
    30
};

Console.WriteLine(
    values[3]);
```

Valid:

```text
0
1
2
```

Checklist:

```text
What is array.Length?
What is index right now?
Is 0 <= index < array.Length?
```

---

# 10. `foreach`

## Purpose

Use `foreach` when you want every item and do not need manual index control.

```csharp
string[] names =
{
    "Ada",
    "Grace",
    "Linus"
};

foreach (
    string name
    in names)
{
    Console.WriteLine(name);
}
```

Read:

```text
for each string called name in names
    run this block
```

## Running total

```csharp
int[] scores =
{
    10,
    20,
    30
};

int total = 0;

foreach (
    int score
    in scores)
{
    total += score;
}

Console.WriteLine(total);
```

Result:

```text
60
```

## Mental model

```text
collection
    ↓
first item
    ↓
run block
    ↓
next item
    ↓
run block
    ↓
...
    ↓
no items left
```

## Use `foreach` when

```text
I want every element
I do not need the index
I care more about the element value than its position
```

Use `for` when precise index control matters.

---

# 11. `for` / `while` / `do-while`

All three repeat code.

The question is:

```text
What controls repetition?
```

## `for`

Best when the counter pattern is known:

```csharp
for (
    int i = 0;
    i < 5;
    i++)
{
    Console.WriteLine(i);
}
```

Parts:

```text
int i = 0
→ initialize once

i < 5
→ continue while true

i++
→ update after each iteration
```

Output:

```text
0
1
2
3
4
```

## Array with `for`

```csharp
string[] names =
{
    "Ada",
    "Grace",
    "Linus"
};

for (
    int i = 0;
    i < names.Length;
    i++)
{
    Console.WriteLine(
        $"{i}: {names[i]}");
}
```

## `while`

Best when the number of repetitions is not known in advance:

```csharp
int count = 0;

while (count < 3)
{
    Console.WriteLine(count);
    count++;
}
```

The condition is checked **before** each iteration.

## `do-while`

Runs the block at least once:

```csharp
int count = 0;

do
{
    Console.WriteLine(count);
    count++;
}
while (count < 3);
```

The condition is checked **after** the block.

## Input-validation loop

```csharp
int number;

do
{
    Console.Write(
        "Enter a number from 1 to 10: ");

    string? input =
        Console.ReadLine();

    if (
        int.TryParse(
            input,
            out number) &&
        number >= 1 &&
        number <= 10)
    {
        break;
    }

    Console.WriteLine(
        "Invalid input.");
}
while (true);
```

## Infinite loop

Wrong:

```csharp
int count = 0;

while (count < 3)
{
    Console.WriteLine(count);

    // count never changes
}
```

Always ask:

```text
What eventually makes this loop stop?
```

## Off-by-one bug

Wrong:

```csharp
for (
    int i = 0;
    i <= names.Length;
    i++)
```

Correct:

```csharp
i < names.Length
```

Remember:

```text
valid index
0 <= i < Length
```

---

# 12. Variable Scope

## Scope = where a name is visible

```csharp
int outer =
    10;

if (outer > 0)
{
    int inner =
        20;

    Console.WriteLine(outer);
    Console.WriteLine(inner);
}

Console.WriteLine(outer);
```

`inner` is not available outside its block.

## Mental model

```text
outer scope
┌───────────────────────────────┐
│ outer variable                │
│                               │
│   inner scope                 │
│   ┌───────────────────────┐   │
│   │ inner variable        │   │
│   │ outer is visible too  │   │
│   └───────────────────────┘   │
│                               │
│ inner no longer exists here   │
└───────────────────────────────┘
```

## Why narrow scope helps

```text
fewer accidental changes
less mental load
clearer ownership
easier debugging
```

Declare variables close to where they are needed.

## Definite assignment

Wrong:

```csharp
int result;

Console.WriteLine(result);
```

A local variable must receive a value before being read.

Correct:

```csharp
int result = 0;
```

## Scope question to ask

When the compiler says a name does not exist:

```text
Is it spelled correctly?
Was it declared?
Is it still inside scope?
```

---

# 13. Methods

## Method = a named unit of behavior

Without methods, a program can become one long sequence of instructions.

Methods let us:

```text
name a task
reuse a task
reason about a task separately
hide implementation details
reduce repetition
```

## First method

```csharp
SayHello();

static void SayHello()
{
    Console.WriteLine(
        "Hello!");
}
```

Read:

```text
static
→ method belongs to the containing program/type

void
→ returns no value

SayHello
→ method name

()
→ no parameters

{ ... }
→ method body
```

## Method call

```csharp
SayHello();
```

Execution:

```text
caller
  ↓
enter method
  ↓
run method body
  ↓
method ends
  ↓
return to caller
```

## Good method names

Weak:

```csharp
static void DoStuff()
```

Better:

```csharp
static void PrintReceipt()
```

The name should answer:

```text
What does this method do?
```

## One clear responsibility

Instead of one huge method that:

```text
reads input
validates input
calculates total
formats output
prints report
```

consider meaningful pieces:

```text
ReadInput()
ValidateInput()
CalculateTotal()
FormatReport()
PrintReport()
```

Do not split code mechanically. Split when the boundary makes the program easier to understand.

## .NET methods and your methods

.NET gives you methods:

```csharp
Console.WriteLine(
    Math.Max(10, 20));
```

You can create your own:

```csharp
static int MaxScore(
    int a,
    int b)
{
    return a > b
        ? a
        : b;
}
```

Same idea:

```text
method
=
named behavior with a contract
```

---

# 14. Parameters and Arguments

These two terms are often confused.

## Parameter

Declared by the method:

```csharp
static void Greet(
    string name)
{
    Console.WriteLine(
        $"Hello, {name}");
}
```

`name` is the **parameter**.

## Argument

Supplied at the call site:

```csharp
Greet("Ada");
```

`"Ada"` is the **argument**.

## Mental model

```text
method definition
Greet(string name)
             ↑
         parameter


method call
Greet("Ada")
      ↑
   argument
```

## Multiple parameters

```csharp
static void PrintPerson(
    string name,
    int age)
{
    Console.WriteLine(
        $"{name} is {age} years old.");
}

PrintPerson(
    "Ada",
    20);
```

Arguments normally match by position.

## Named arguments

```csharp
PrintPerson(
    age: 20,
    name: "Ada");
```

Named arguments can make meaning clearer and allow intentional reordering.

## Parameter types are contracts

```csharp
static void PrintAge(
    int age)
```

means:

```text
this method expects an int
```

Calling with incompatible data is rejected by the compiler.

## Pass-by-value for simple values

```csharp
int number =
    5;

ChangeNumber(number);

Console.WriteLine(number);

static void ChangeNumber(
    int value)
{
    value =
        100;
}
```

Output:

```text
5
```

The method received its own parameter value.

Arrays have an important reference-type behavior covered in Section 17.

---

# 15. Return Values

## Return = send a result back

```csharp
int result =
    Add(10, 20);

Console.WriteLine(result);

static int Add(
    int a,
    int b)
{
    return a + b;
}
```

Method contract:

```text
inputs:
int a
int b

output:
int
```

## Return type

```csharp
static int Add(...)
```

promises an `int` result.

Every required path must satisfy that promise.

## `void`

```csharp
static void PrintMessage(
    string message)
{
    Console.WriteLine(message);
}
```

`void` means:

```text
no value is returned
```

The method may still have side effects such as console output.

## Early return

```csharp
static void PrintPositive(
    int number)
{
    if (number <= 0)
    {
        Console.WriteLine(
            "Number must be positive.");

        return;
    }

    Console.WriteLine(number);
}
```

This is a simple **guard clause**.

## Returning Boolean values

```csharp
static bool IsPassing(
    int score)
{
    return score >= 60;
}
```

Then:

```csharp
if (IsPassing(75))
{
    Console.WriteLine(
        "Pass");
}
```

Readable method names can make conditions read like sentences.

## Method-contract questions

Before writing a method, ask:

```text
What input does it need?
What does it return?
What inputs are invalid?
What state does it change?
Can it fail?
```

---

# 16. Optional Parameters

## Default values

```csharp
static void Greet(
    string name,
    string greeting = "Hello")
{
    Console.WriteLine(
        $"{greeting}, {name}!");
}
```

Call with the default:

```csharp
Greet("Ada");
```

Output:

```text
Hello, Ada!
```

Override it:

```csharp
Greet(
    "Ada",
    "Welcome");
```

## Optional parameters usually come last

Clear:

```csharp
static void PrintReport(
    string title,
    bool showDetails = false)
```

Required information appears first.

## Named + optional arguments

```csharp
PrintReport(
    "Sales",
    showDetails: true);
```

This is often clearer than:

```csharp
PrintReport(
    "Sales",
    true);
```

because the Boolean's meaning is visible.

## Avoid too many flags

Hard to read:

```csharp
CreateReport(
    true,
    false,
    true,
    false);
```

Named arguments help, but many unrelated options may indicate that the method needs a clearer design.

---

# 17. Arrays as Method Arguments

Arrays are reference types.

A beginner-friendly mental model is:

```text
the method receives access to the same array object
```

## Mutating an element

```csharp
int[] values =
{
    1,
    2,
    3
};

SetFirstToZero(values);

Console.WriteLine(
    values[0]);

static void SetFirstToZero(
    int[] numbers)
{
    numbers[0] =
        0;
}
```

Output:

```text
0
```

The method modified the same array object.

## Reassigning the parameter

```csharp
int[] values =
{
    1,
    2,
    3
};

ReplaceArray(values);

Console.WriteLine(
    values[0]);

static void ReplaceArray(
    int[] numbers)
{
    numbers =
        new int[]
        {
            100,
            200
        };
}
```

The caller's `values` still points to its original array.

Simplified model:

```text
caller reference
      ───────┐
             ↓
          [1,2,3]
             ↑
      ───────┘
method receives a copy of that reference
```

Both references initially point at the same object.

Changing an element changes that shared object.

Reassigning the local parameter only changes the method's copied reference.

## Why this matters

If a method mutates an array too early and later fails, the caller may be left with partially modified state.

This motivates:

```text
stage
  ↓
validate
  ↓
commit only on success
```

---

# 18. String Methods

Remember:

```text
strings are immutable
```

Most string operations return a new string.

## `Trim`

```csharp
string raw =
    "   hello   ";

string clean =
    raw.Trim();
```

Related:

```csharp
TrimStart()
TrimEnd()
```

## `ToUpper` / `ToLower`

```csharp
string word =
    "CSharp";

Console.WriteLine(
    word.ToUpper());

Console.WriteLine(
    word.ToLower());
```

## `Contains`

```csharp
string sentence =
    "C# is a programming language.";

bool found =
    sentence.Contains("C#");
```

## `StartsWith` / `EndsWith`

```csharp
string fileName =
    "report.txt";

if (fileName.EndsWith(".txt"))
{
    Console.WriteLine(
        "Text file");
}
```

## `IndexOf`

```csharp
string text =
    "hello world";

int index =
    text.IndexOf("world");
```

If found, it returns the starting index.

If not found:

```text
-1
```

Always account for that possibility.

## `Substring`

```csharp
string text =
    "ABCDE";

string part =
    text.Substring(
        1,
        3);
```

Result:

```text
BCD
```

Read:

```text
start at index 1
take 3 characters
```

## `Remove`

```csharp
string text =
    "ABC123DEF";

string result =
    text.Remove(
        3,
        3);
```

Result:

```text
ABCDEF
```

## `Replace`

```csharp
string text =
    "red car";

string updated =
    text.Replace(
        "red",
        "blue");
```

Result:

```text
blue car
```

## `Split`

```csharp
string csv =
    "Ada,Grace,Linus";

string[] names =
    csv.Split(',');
```

Conceptually:

```text
names[0] → Ada
names[1] → Grace
names[2] → Linus
```

## Search-before-slice pattern

Safer:

```csharp
string text =
    "name: Ada";

int colonIndex =
    text.IndexOf(':');

if (colonIndex != -1)
{
    string value =
        text.Substring(
            colonIndex + 1)
        .Trim();

    Console.WriteLine(value);
}
```

Pattern:

```text
search
  ↓
verify found
  ↓
extract
  ↓
clean
```

---

# 19. Array Helper Methods

## Sort

```csharp
int[] numbers =
{
    5,
    2,
    9,
    1
};

Array.Sort(numbers);
```

Now:

```text
1, 2, 5, 9
```

Important:

```text
Array.Sort mutates the array
```

## Reverse

```csharp
Array.Reverse(numbers);
```

If sorted first:

```text
9, 5, 2, 1
```

## Search index

```csharp
string[] names =
{
    "Ada",
    "Grace",
    "Linus"
};

int index =
    Array.IndexOf(
        names,
        "Grace");
```

Result:

```text
1
```

Not found:

```text
-1
```

## Clear

```csharp
int[] numbers =
{
    1,
    2,
    3
};

Array.Clear(
    numbers,
    0,
    numbers.Length);
```

Elements become their default values.

For `int`:

```text
0
```

## Join

```csharp
string[] names =
{
    "Ada",
    "Grace",
    "Linus"
};

string result =
    string.Join(
        ", ",
        names);
```

Output:

```text
Ada, Grace, Linus
```

Natural pair:

```text
string
  ↓ Split
array
  ↓ process
array
  ↓ Join
string
```

## Be careful with order

If array position carries meaning:

```text
index 0 = January
index 1 = February
index 2 = March
```

then sorting the values may destroy that relationship.

Ask before mutation:

```text
Does element order carry meaning?
```

---

# 20. Debugging

## Testing versus debugging

Testing asks:

```text
Does the program behave as expected?
```

Debugging asks:

```text
Why is the program behaving incorrectly?
```

A failing test or wrong output gives evidence.

The debugger helps locate the cause.

## Disciplined workflow

```text
1. Reproduce the problem
2. Write down expected behavior
3. Write down actual behavior
4. Find the first point where they diverge
5. Inspect state there
6. Form one hypothesis
7. Test the hypothesis
8. Fix the root cause
9. Rerun the original case
10. Test nearby and boundary cases
```

## Breakpoint

A breakpoint pauses execution at a selected line.

Inspect:

```text
variable values
branch conditions
loop counters
array contents
method parameters
current call path
```

## Step Over

```text
execute this line
stay at the current abstraction level
```

## Step Into

```text
enter the called method
```

Use it when the suspected bug may be inside that method.

## Step Out

```text
finish current method
return to caller
```

## Continue

Resume until another breakpoint, exception, or program completion.

## Variables / Locals

Inspect values such as:

```text
itemCost
changeNeeded
cashTill
index
count
result
```

Look for relationships, not only isolated numbers.

Example:

```text
expected till = 833
actual till   = 838
difference    = 5
```

The difference itself is a clue.

## Watch expressions

Useful examples:

```text
cashTill[0] + cashTill[1] * 5 + cashTill[2] * 10 + cashTill[3] * 20
```

```text
index < array.Length
```

```text
amountPaid - cost
```

A watch should answer a question.

## Call stack

The call stack tells you how execution reached the current line:

```text
top-level code
      ↓
ProcessOrder()
      ↓
CalculateTotal()
      ↓
current line
```

## Debugger questions

At a pause:

```text
What did I expect?
What is the value actually?
Which earlier line could have changed it?
Which condition brought execution here?
```

## Logic bug example: wrong array index

Suppose:

```text
cashTill[1] = $5 bills
cashTill[2] = $10 bills
```

Condition:

```csharp
cashTill[1] > 0
```

but mutation:

```csharp
cashTill[2]--;
```

The program can compile and run.

Only the runtime state is wrong.

Therefore:

```text
compiles
≠
correct
```

---

# 21. Exceptions

## Exception = an object representing a runtime failure

Examples:

```text
invalid input format
array index outside valid range
division by zero
operation not allowed in the current state
missing or invalid argument
```

C# and .NET represent many runtime failures with exception objects.

## Exception is not the same as a logic bug

A logic bug may silently produce a wrong result:

```text
expected: 100
actual:    95
```

No exception is required.

An exception interrupts normal execution unless it is handled.

## Common exception types

| Exception | Typical meaning |
| --- | --- |
| `FormatException` | text has the wrong format |
| `DivideByZeroException` | integer/decimal division by zero |
| `IndexOutOfRangeException` | invalid array index |
| `ArgumentException` | argument is invalid |
| `ArgumentOutOfRangeException` | argument is outside an allowed range |
| `InvalidOperationException` | operation is not valid in the current state |

Do not memorize every .NET exception type.

Learn to choose the most specific meaningful type you understand.

## Useful properties

```csharp
exception.Message
```

A human-readable description.

```csharp
exception.StackTrace
```

Diagnostic information about the call path.

```csharp
exception.InnerException
```

A lower-level exception that was wrapped by another exception.

## Exception propagation

If a method throws and does not catch:

```text
current method
      ↓
caller
      ↓
caller
      ↓
...
```

The runtime looks for a compatible `catch`.

If no handler is found, the application can terminate.

---

# 22. `try` / `catch` / `finally`

## `try`

Place code that may throw:

```csharp
try
{
    int number =
        int.Parse("42");

    Console.WriteLine(number);
}
```

## `catch`

Handle a specific failure:

```csharp
try
{
    int number =
        int.Parse("hello");

    Console.WriteLine(number);
}
catch (FormatException exception)
{
    Console.WriteLine(
        $"Invalid number: {exception.Message}");
}
```

Flow:

```text
try
 ↓
exception?
 ├─ no  → continue
 └─ yes
      ↓
matching catch
      ↓
continue after handler
```

## Multiple catches

Specific handlers should appear before broader handlers:

```csharp
try
{
    // risky operation
}
catch (FormatException)
{
    Console.WriteLine(
        "The input format is invalid.");
}
catch (ArgumentException)
{
    Console.WriteLine(
        "An argument is invalid.");
}
catch (Exception)
{
    Console.WriteLine(
        "An unexpected error occurred.");
}
```

Do not catch `Exception` everywhere just to hide failures.

Catch what you can meaningfully handle.

## `finally`

A `finally` block is intended for cleanup that should happen after the `try` path, whether execution succeeds normally or a handled exception occurs.

```csharp
try
{
    Console.WriteLine(
        "Trying...");
}
catch (Exception)
{
    Console.WriteLine(
        "Handling...");
}
finally
{
    Console.WriteLine(
        "Cleanup step");
}
```

Mental model:

```text
try
 ├─ success ─────────┐
 └─ exception → catch│
                    ↓
                 finally
                    ↓
                 continue
```

## When `TryParse` is better

If invalid text input is normal and expected, this is often clearer:

```csharp
int.TryParse(...)
```

than relying on repeated exceptions.

Rule of thumb:

```text
expected invalid input
→ prefer validation / TryParse when available

exceptional inability to complete
→ exceptions may be appropriate
```

---

# 23. `throw` / rethrow

## Throw an exception deliberately

A method should report when it cannot honor its contract.

```csharp
static decimal CalculateDiscount(
    decimal price)
{
    if (price < 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(price),
            "Price cannot be negative.");
    }

    return price * 0.10m;
}
```

Meaning:

```text
negative price
→ invalid input for this method
```

## `InvalidOperationException`

Use when the data may be valid, but the operation cannot be performed in the current state.

Example:

```text
customer payment exists
but
till cannot make exact change
        ↓
operation cannot complete
        ↓
InvalidOperationException
```

## Rethrow

Inside a `catch`:

```csharp
catch (Exception)
{
    // Optional local logging/context.

    throw;
}
```

`throw;` rethrows the current exception while preserving the original exception flow for diagnostics.

Avoid casually writing:

```csharp
throw exception;
```

when your only goal is to rethrow the same exception, because it can make diagnostic stack information less useful.

## Wrap an exception

Sometimes you need higher-level context:

```csharp
try
{
    // Lower-level parsing operation.
}
catch (FormatException exception)
{
    throw new InvalidOperationException(
        "The configuration could not be loaded.",
        exception);
}
```

Model:

```text
outer exception
→ higher-level meaning

InnerException
→ original cause
```

## Do not use exceptions as normal branching

Prefer:

```text
ordinary condition
→ if / else / TryParse

operation cannot satisfy its contract
→ throw / catch
```

---

# 24. Common Compiler Errors

## Compiler errors are feedback

The compiler is not saying:

```text
you are bad at programming
```

It is saying:

```text
this source code violates a language, type, scope, or method-contract rule
```

Treat error messages as evidence.

## Reliable reading method

When a build fails:

```text
1. Read the first relevant error
2. Note the file
3. Note the line number
4. Read the exact message
5. Inspect that line and nearby declarations
6. Fix one likely root cause
7. Build again
```

One mistake can create many secondary errors.

## Missing semicolon

Wrong:

```csharp
int age = 20
Console.WriteLine(age);
```

Correct:

```csharp
int age = 20;
Console.WriteLine(age);
```

## Unknown name

Wrong:

```csharp
int score = 100;

Console.WriteLine(
    scor);
```

Check:

```text
spelling
declaration
scope
```

## Type mismatch

Wrong:

```csharp
int age =
    "20";
```

Correct:

```csharp
int age =
    20;
```

or convert text intentionally:

```csharp
int age =
    int.Parse("20");
```

## Wrong argument type

Method:

```csharp
static void PrintAge(
    int age)
```

Wrong call:

```csharp
PrintAge(
    "twenty");
```

Ask:

```text
What type does the parameter require?
What type is the argument?
```

## Missing required argument

Method:

```csharp
static void PrintPerson(
    string name,
    int age)
```

Wrong:

```csharp
PrintPerson(
    "Ada");
```

`age` is missing.

## Named argument does not match a parameter

Suppose:

```csharp
static void SetValue(
    int value)
```

Wrong:

```csharp
SetValue(
    number: 10);
```

Named arguments must match actual parameter names.

## Unassigned local variable

Wrong:

```csharp
int total;

if (condition)
{
    total = 10;
}

Console.WriteLine(total);
```

There is a possible path where `total` has no value.

Fix the control flow or initialize intentionally.

## Missing return

Wrong:

```csharp
static int GetValue(
    bool useDefault)
{
    if (useDefault)
    {
        return 10;
    }

    // No int is returned here.
}
```

A value-returning method must satisfy its return contract on all required paths.

## No matching overload

If the compiler says no overload matches, check:

```text
method name
number of arguments
argument order
argument types
named argument spelling
```

Do not change random code before reading the method signature.

## Error classification

Most beginner compile errors fit one of these groups:

```text
syntax
name
scope
type
method contract
argument mismatch
return contract
```

Classification reduces guessing.

---

# 25. Common Logic Bugs

Logic bugs are harder because the program may:

```text
compile
run
finish
produce the wrong result
```

## 1. Integer division

Bug:

```csharp
decimal average =
    5 / 2;
```

The division happens as integer division first.

Better:

```csharp
decimal average =
    5m / 2m;
```

## 2. Off-by-one index

Wrong:

```csharp
for (
    int i = 0;
    i <= values.Length;
    i++)
```

Correct:

```csharp
i < values.Length
```

## 3. Wrong array index

You intended one logical bucket but mutated another.

Types remain valid, so the compiler cannot know your meaning.

## 4. Wrong condition order

Wrong:

```csharp
if (score >= 60)
{
    Console.WriteLine("Pass");
}
else if (score >= 90)
{
    Console.WriteLine("Excellent");
}
```

The `>= 90` branch cannot produce its intended distinct result.

## 5. Infinite loop

```csharp
while (count < 10)
{
    Console.WriteLine(count);

    // Forgot count++
}
```

Ask:

```text
What variable controls termination?
Where does it change?
```

## 6. Assignment inside a Boolean condition

This can compile:

```csharp
bool isReady =
    false;

if (isReady = true)
{
    Console.WriteLine(
        "Ready");
}
```

Usually you intended:

```csharp
if (isReady)
```

## 7. Mutating shared state before success is known

Dangerous:

```text
modify real state
      ↓
perform more validation
      ↓
operation fails
      ↓
partial changes remain
```

Safer:

```text
stage temporary state
      ↓
validate complete operation
      ↓
success?
 ┌────┴────┐
yes        no
 ↓          ↓
commit    discard
```

## 8. Trusting one random test

```text
one random run passed
≠
algorithm is proven correct
```

Use:

```text
known fixed cases
boundary cases
invalid cases
randomized cases
```

## 9. Trusting plausible output

A program can print reasonable text while modifying incorrect internal state.

Independent verification is powerful:

```text
actual result
      vs
independently calculated expected result
```

## Logic-bug checklist

```text
□ Are indexes correct?
□ Are loop bounds correct?
□ Is integer division happening?
□ Are conditions ordered correctly?
□ Is the right variable updated?
□ Is state updated too early?
□ Does a failed path leave partial changes?
□ Did a conversion lose information?
□ Did I test boundary values?
□ Is expected behavior calculated independently?
```

---

# 26. .NET CLI Quick Reference

The **.NET CLI** is the command-line interface used to work with .NET projects.

Basic cycle:

```text
create
  ↓
edit
  ↓
build
  ↓
run
  ↓
debug / fix
  ↓
build again
```

## Check the active SDK

```powershell
dotnet --version
```

## List installed SDKs

```powershell
dotnet --list-sdks
```

## Create a console project

```powershell
dotnet new console
```

Create with an explicit directory:

```powershell
dotnet new console `
    --framework net10.0 `
    --name sample-app `
    --output .\sample-app
```

## Run a project

Inside the project directory:

```powershell
dotnet run
```

From another directory:

```powershell
dotnet run --project `
    ".\sample-app\sample-app.csproj"
```

## Build a project

```powershell
dotnet build
```

Specific project:

```powershell
dotnet build `
    ".\sample-app\sample-app.csproj"
```

## Restore dependencies

```powershell
dotnet restore
```

`dotnet build` normally restores when needed, but understanding restore helps with dependency troubleshooting.

## Clean build outputs

```powershell
dotnet clean
```

Then rebuild:

```powershell
dotnet build
```

## Create a solution

```powershell
dotnet new sln
```

Modern .NET tooling may use solution formats such as `.sln` or `.slnx`, depending on the tooling version and workflow.

## Add a project to a solution

```powershell
dotnet sln `
    .\my-solution.slnx `
    add `
    .\sample-app\sample-app.csproj
```

## List projects

```powershell
dotnet sln `
    .\my-solution.slnx `
    list
```

## Remove a project

```powershell
dotnet sln `
    .\my-solution.slnx `
    remove `
    .\sample-app\sample-app.csproj
```

## Verification cycle

```powershell
dotnet build `
    ".\path\project.csproj"

dotnet build `
    ".\solution.slnx"
```

Mental model:

```text
project build succeeds
        +
full solution succeeds
        =
better integration confidence
```

## Troubleshooting questions

```text
Am I in the directory I think I am?
Does this path exist?
Is the .csproj name correct?
Is the project registered in the solution?
Which SDK is active?
What is the first relevant error?
```

---

# 27. Patterns Worth Remembering

These are recurring solution shapes, not magic formulas.

## Pattern 1 — Validate, then use

```csharp
if (
    int.TryParse(
        input,
        out int number))
{
    Console.WriteLine(
        number * 2);
}
else
{
    Console.WriteLine(
        "Invalid input.");
}
```

```text
raw input
   ↓
validate
   ↓
valid?
 ┌─┴─┐
yes  no
 ↓    ↓
use  report/retry
```

## Pattern 2 — Guard clause

```csharp
static void PrintAge(
    int age)
{
    if (age < 0)
    {
        Console.WriteLine(
            "Invalid age.");

        return;
    }

    Console.WriteLine(
        $"Age: {age}");
}
```

Mental model:

```text
reject invalid case early
        ↓
main path stays simple
```

## Pattern 3 — Accumulator

```csharp
int total =
    0;

foreach (
    int value
    in values)
{
    total += value;
}
```

Common for:

```text
sum
count
score
balance
```

## Pattern 4 — Search, verify, extract

```csharp
int index =
    text.IndexOf(':');

if (index != -1)
{
    string value =
        text.Substring(
            index + 1)
        .Trim();
}
```

Never assume a search succeeded.

## Pattern 5 — Split, process, join

```text
text
 ↓
Split
 ↓
array
 ↓
transform / sort / inspect
 ↓
Join
 ↓
text
```

## Pattern 6 — Branch by precedence

```text
highest / most specific
        ↓
next
        ↓
next
        ↓
default
```

## Pattern 7 — Loop over valid indexes

```csharp
for (
    int i = 0;
    i < values.Length;
    i++)
{
    Console.WriteLine(
        values[i]);
}
```

Remember:

```text
0 <= i < Length
```

## Pattern 8 — Define a method contract first

```text
Name:
What does the method do?

Inputs:
What does it need?

Output:
What does it return?

Invalid input:
What should happen?

Side effects:
What external state changes?

Failure:
Can it throw?
```

## Pattern 9 — Specific exception boundary

```csharp
try
{
    PerformOperation();
}
catch (InvalidOperationException exception)
{
    Console.WriteLine(
        exception.Message);
}
```

Catch what you can actually handle.

## Pattern 10 — Stage, validate, commit

This is one of the strongest patterns in this review.

Dangerous:

```text
mutate shared state
        ↓
discover failure
```

Safer:

```text
copy / stage local state
        ↓
perform full operation
        ↓
validate final result
        ↓
success?
 ┌──────┴──────┐
yes            no
 ↓              ↓
commit        discard
```

Simplified example:

```csharp
int stagedBalance =
    balance;

stagedBalance +=
    deposit;

stagedBalance -=
    withdrawal;

if (stagedBalance < 0)
{
    throw new InvalidOperationException(
        "The operation cannot complete.");
}

balance =
    stagedBalance;
```

The shared state changes only after success is known.

## Pattern 11 — Independent verification

Do not verify an algorithm with an identical copy of the same potentially flawed logic.

Prefer:

```text
system result
      vs
independently derived expected result
```

## Pattern 12 — Fixed + boundary + invalid + random

```text
fixed cases
→ reproducible

boundary cases
→ expose edges

invalid cases
→ verify failure paths

random cases
→ explore wider input space
```

Use them together.

## Pattern 13 — Readability before cleverness

Prefer:

```csharp
bool isEligible =
    age >= 18 &&
    hasPermission;

if (isEligible)
{
    ...
}
```

over compressed logic that takes longer to understand.

Optimize first for:

```text
correctness
clarity
maintainability
```

---

# 28. C# Quick Reference / Cheat Sheet

This section is intentionally compact.

Use it after you understand the concepts and only need syntax.

## Console

```csharp
Console.WriteLine("Hello");
Console.Write("Same line");

string? input =
    Console.ReadLine();
```

## Variables

```csharp
int age = 20;
decimal price = 19.95m;
double distance = 12.5;
bool isReady = true;
char grade = 'A';
string name = "Ada";
```

## Type inference

```csharp
var count = 10;
var message = "Hello";
```

## String interpolation

```csharp
Console.WriteLine(
    $"Hello, {name}");
```

## Escapes

```csharp
"\n"   // newline
"\t"   // tab
"\""   // quote
"\\"   // backslash
```

## Verbatim string

```csharp
string path =
    @"C:\Data\file.txt";
```

## Arithmetic

```csharp
a + b
a - b
a * b
a / b
a % b
```

## Compound assignment

```csharp
count += 1;
count -= 1;
count *= 2;
count /= 2;
```

## Increment / decrement

```csharp
count++;
count--;
```

## Comparisons

```csharp
a == b
a != b
a > b
a < b
a >= b
a <= b
```

## Logical operators

```csharp
a && b
a || b
!a
```

## Conditional operator

```csharp
string result =
    score >= 60
        ? "Pass"
        : "Fail";
```

## `if`

```csharp
if (condition)
{
}
```

## `if` / `else`

```csharp
if (condition)
{
}
else
{
}
```

## `else if`

```csharp
if (conditionA)
{
}
else if (conditionB)
{
}
else
{
}
```

## `switch`

```csharp
switch (value)
{
    case "A":
        break;

    case "B":
        break;

    default:
        break;
}
```

## Array

```csharp
int[] values =
{
    10,
    20,
    30
};
```

## Array access

```csharp
values[0]
values.Length
values[values.Length - 1]
```

## `foreach`

```csharp
foreach (
    int value
    in values)
{
    Console.WriteLine(value);
}
```

## `for`

```csharp
for (
    int i = 0;
    i < values.Length;
    i++)
{
    Console.WriteLine(
        values[i]);
}
```

## `while`

```csharp
while (condition)
{
}
```

## `do-while`

```csharp
do
{
}
while (condition);
```

## `void` method

```csharp
static void PrintMessage(
    string message)
{
    Console.WriteLine(message);
}
```

## Returning method

```csharp
static int Add(
    int a,
    int b)
{
    return a + b;
}
```

## Optional parameter

```csharp
static void Greet(
    string name,
    string greeting = "Hello")
{
}
```

## Named argument

```csharp
Greet(
    name: "Ada",
    greeting: "Welcome");
```

## Cast

```csharp
int whole =
    (int)12.9m;
```

## Parse

```csharp
int number =
    int.Parse("42");
```

## TryParse

```csharp
if (
    int.TryParse(
        input,
        out int number))
{
}
```

## Convert

```csharp
int number =
    Convert.ToInt32(
        "42");
```

## String helpers

```csharp
text.Trim()
text.ToUpper()
text.ToLower()
text.Contains("x")
text.StartsWith("x")
text.EndsWith("x")
text.IndexOf("x")
text.Substring(start)
text.Substring(start, length)
text.Remove(start, count)
text.Replace("old", "new")
text.Split(',')
```

## Array helpers

```csharp
Array.Sort(values);
Array.Reverse(values);
Array.IndexOf(values, target);
Array.Clear(values, 0, values.Length);
```

## Join

```csharp
string text =
    string.Join(
        ", ",
        values);
```

## Random integer

```csharp
Random random =
    new();

int value =
    random.Next(
        2,
        50);
```

Important:

```text
2 is included
50 is excluded

possible values:
2 through 49
```

## `try-catch`

```csharp
try
{
}
catch (InvalidOperationException exception)
{
    Console.WriteLine(
        exception.Message);
}
```

## `finally`

```csharp
try
{
}
catch (Exception)
{
}
finally
{
}
```

## Throw

```csharp
throw new InvalidOperationException(
    "The operation cannot complete.");
```

## Rethrow

```csharp
catch (Exception)
{
    throw;
}
```

## Quick loop chooser

```text
every item, no index
→ foreach

known counter/index pattern
→ for

repeat while condition is true
→ while

must run once before checking
→ do-while
```

## Quick decision chooser

```text
one condition
→ if

two alternatives
→ if / else

ordered ranges
→ if / else if

one value, discrete cases
→ switch
```

## Quick conversion chooser

```text
safe numeric widening
→ implicit

intentional narrowing
→ cast

trusted text
→ Parse / Convert

possibly invalid text
→ TryParse

display
→ interpolation / ToString()
```

## Quick debugging checklist

```text
□ Reproduce the bug
□ Write expected result
□ Write actual result
□ Set breakpoint near divergence
□ Inspect variable values
□ Check array indexes
□ Check loop bounds
□ Check condition order
□ Check conversions
□ Check state mutations
□ Check failed paths
□ Fix root cause
□ Rerun the original case
□ Test boundaries
```

## Quick method checklist

```text
□ Does the name describe one task?
□ Are parameter types correct?
□ Is the return type correct?
□ Are invalid inputs handled?
□ Are side effects intentional?
□ Can failure leave partial state?
```

## Quick array checklist

```text
first index:
0

last index:
Length - 1

valid:
0 <= index && index < Length
```

## Quick error classification

```text
compile-time problem?
→ syntax / name / scope / type / method contract

runtime exception?
→ exception type + message + call stack

wrong result without exception?
→ logic bug + debugger + independent verification
```

---

# The Big Picture

At first, C# can look like hundreds of unrelated symbols.

It becomes much simpler when you see the system underneath.

```text
DATA
variables
types
strings
arrays
    ↓
OPERATIONS
arithmetic
methods
conversions
    ↓
DECISIONS
Boolean expressions
if / else
switch
    ↓
REPETITION
foreach
for
while
do-while
    ↓
STRUCTURE
scope
parameters
return values
    ↓
RELIABILITY
validation
debugging
exceptions
state consistency
```

A useful summary:

```text
A program stores data,
transforms data,
makes decisions,
repeats work,
packages behavior,
and protects valid state.
```

If you understand those six ideas, the syntax stops feeling random.

---

# Suggested Practice Projects

## 1. Number Analyzer

Practice:

```text
Console input
TryParse
if / else
%
methods
```

Features:

```text
even / odd
positive / negative
range check
```

## 2. Student Grade Calculator

Practice:

```text
arrays
foreach
arithmetic
formatting
methods
```

## 3. Text Search Tool

Practice:

```text
string methods
Split
IndexOf
Substring
arrays
loops
```

## 4. Menu Application

Practice:

```text
while
switch
input validation
methods
```

## 5. Cash Register Simulator

Practice:

```text
arrays
methods
exceptions
debugging
state consistency
stage / validate / commit
```

A practice project does not need to be large.

It needs to make one concept reliable.

---

# Final Review Questions

If you can explain these without looking, your foundations are strong.

1. What is the difference between a variable and a literal?
2. Why does C# need data types?
3. What is the difference between `int` division and `decimal` division?
4. What does `%` calculate?
5. When should `TryParse` be preferred over `Parse`?
6. What does a Boolean expression produce?
7. Why does `else if` order matter?
8. Why do array indexes start at `0`?
9. What is the final valid array index?
10. When would you choose `foreach` instead of `for`?
11. What makes a `while` loop terminate?
12. What does variable scope control?
13. What problem do methods solve?
14. What is the difference between a parameter and an argument?
15. What does a return type promise?
16. What is an optional parameter?
17. Why can a method modify array elements supplied by its caller?
18. Why are strings called immutable?
19. What does `Array.Sort()` do to the original array?
20. What is the difference between testing and debugging?
21. What is a breakpoint?
22. What does the call stack tell you?
23. What is an exception?
24. When should you use `try-catch`?
25. What is the difference between `throw new ...` and `throw;`?
26. Why can code compile successfully and still be wrong?
27. Why is independent verification useful?
28. Why is `stage → validate → commit` safer than mutating shared state early?

---

# Sources and Learning Basis

This review is an independently organized synthesis of the concepts practiced in this repository and the official Microsoft Learn beginner C# learning paths.

Primary references:

- [Microsoft Learn — Write your first code using C# (Get started with C#, Part 1)](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-1/)
- [Microsoft Learn — Create and run simple C# console applications (Get started with C#, Part 2)](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-2/)
- [Microsoft Learn — Add logic to C# console applications (Get started with C#, Part 3)](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-3/)
- [Microsoft Learn — Work with variable data in C# console applications (Get started with C#, Part 4)](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-4/)
- [Microsoft Learn — Create methods in C# console applications (Get started with C#, Part 5)](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-5/)
- [Microsoft Learn — Debug C# console applications (Get started with C#, Part 6)](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-6/)
- [Microsoft Learn — C# Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Repository curriculum and project documentation](https://github.com/kcduong994/freecodecamp-csharp)

The organization is intentionally **concept-based**, so this handbook complements rather than duplicates the repository's module-by-module README documentation.

---

# One-Page Memory Map

```text
C# PROGRAM
│
├── DATA
│   ├── variables
│   ├── literals
│   ├── data types
│   ├── strings
│   └── arrays
│
├── OPERATIONS
│   ├── arithmetic
│   ├── conversions
│   ├── string methods
│   └── array helpers
│
├── CONTROL FLOW
│   ├── Boolean expressions
│   ├── if / else
│   ├── switch
│   ├── foreach
│   ├── for
│   ├── while
│   └── do-while
│
├── STRUCTURE
│   ├── scope
│   ├── methods
│   ├── parameters
│   ├── arguments
│   ├── optional parameters
│   └── return values
│
├── RELIABILITY
│   ├── validation
│   ├── compiler feedback
│   ├── debugging
│   ├── exceptions
│   ├── try / catch / finally
│   ├── throw / rethrow
│   └── state consistency
│
└── TOOLING
    ├── dotnet new
    ├── dotnet run
    ├── dotnet build
    ├── dotnet restore
    └── dotnet sln
```

---

> **The goal is not to memorize C#.**
>
> The goal is to understand the rules well enough that, when you forget syntax, you know what to look for and why the code should work.
