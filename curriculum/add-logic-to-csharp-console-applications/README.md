# Add Logic to C# Console Applications

![C#](https://img.shields.io/badge/C%23-Section_3-512BD4?logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-In_Progress-F59E0B)
![Progress](https://img.shields.io/badge/Curriculum_Items-2%2F7-16A34A)
![Projects](https://img.shields.io/badge/Solution_Projects-15-2563EB)
![Build](https://img.shields.io/badge/Full_Solution_Build-Passing-16A34A)

Section 3 of the **Foundational C# with Microsoft Certification** curriculum.

This section develops decision-making and control-flow skills for C# console
applications. Every completed curriculum item is stored as a runnable project,
registered in the solution, documented, and verified with both a project build
and a full-solution build.

---

## Section Status

```text
Section: Add Logic to C# Console Applications
Status: In progress
Progress: 2 / 7
Completed instructional modules: 2
Completed guided projects: 0
Completed challenge projects: 0
Latest completed module: Control Variable Scope and Logic Using Code Blocks in C#
Latest module assessment: Passed
Latest achievement: Earned
Latest completion date: July 25, 2026
Projects currently verified in solution: 15
Full solution build: Verified
```

| Curriculum item | Status |
| --- | --- |
| Evaluate Boolean Expressions to Make Decisions in C# | Completed |
| Control Variable Scope and Logic Using Code Blocks in C# | Completed |
| Remaining Section 3 curriculum items | 5 not started |

A curriculum item is marked `Completed` only after its Microsoft Learn units,
assessment, achievement, local run, solution registration, project build, and
full-solution build have all been verified.

---

## Repository Structure

```text
add-logic-to-csharp-console-applications/
├── README.md
├── modules/
│   ├── evaluate-boolean-expressions/
│   │   ├── Program.cs
│   │   └── evaluate-boolean-expressions.csproj
│   └── code-blocks-variable-scope/
│       ├── Program.cs
│       └── code-blocks-variable-scope.csproj
├── guided-projects/
├── challenge-projects/
└── trophy/
```

This section uses one central README. Individual module directories contain the
executable source code and project file without an additional README.

---

# Module 1 — Evaluate Boolean Expressions to Make Decisions in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project added to solution: Verified
Solution project count: 14
Project build: Verified
Full solution build: Verified
Completion date: July 24, 2026
```

The module introduces Boolean expressions and demonstrates how their `true` or
`false` results can be used to evaluate conditions and make decisions.

The final `Program.cs` retains the complete instructional sequence while
removing duplicate declarations, unused directives, incomplete statements, and
invalid intermediate code.

---

## Learning Objectives

The completed project demonstrates how to:

- test equality with `==`;
- test inequality with `!=`;
- compare numeric values using `>`, `<`, `>=`, and `<=`;
- normalize strings before comparing them;
- call `string` methods that return Boolean values;
- reverse Boolean results with logical negation;
- distinguish `!=` from the unary `!` operator;
- return one of two values with the conditional operator;
- simulate a coin flip with `Random`;
- apply nested decision logic to role-based permissions.

---

## Boolean Expressions

A Boolean expression evaluates to one of two values:

```text
True
False
```

Examples:

```csharp
Console.WriteLine("a" == "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
```

Operators covered by the module:

| Operator | Meaning |
| :---: | --- |
| `==` | Equal to |
| `!=` | Not equal to |
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `!` | Logical negation |
| `?:` | Conditional operator |

---

## String Normalization

String comparison is case-sensitive and includes leading and trailing spaces.

```csharp
string value1 = " a";
string value2 = "A ";

Console.WriteLine(
    value1.Trim().ToLower() ==
    value2.Trim().ToLower());
```

Processing sequence:

```text
Original string
    ↓
Trim leading and trailing spaces
    ↓
Convert both strings to the same case
    ↓
Compare the normalized values
```

Expected result:

```text
True
```

---

## Boolean-Returning String Methods

The project uses `Contains()` to determine whether text exists inside another
string:

```csharp
string pangram =
    "The quick brown fox jumps over the lazy dog.";

Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
```

Expected results:

```text
True
False
```

Logical negation reverses those results:

```csharp
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
```

Expected results:

```text
False
True
```

---

## Inequality and Logical Negation

Although both operators contain `!`, they perform different tasks.

```csharp
firstNumber != secondNumber
```

compares two values for inequality.

```csharp
!pangram.Contains("fox")
```

reverses one Boolean value.

For built-in values, these expressions are equivalent:

```csharp
x != y
!(x == y)
```

---

## Conditional Operator

Syntax:

```csharp
condition ? valueWhenTrue : valueWhenFalse
```

The discount exercise implements this rule:

```text
Sale amount greater than 1000 → discount of 100
Sale amount 1000 or lower    → discount of 50
```

```csharp
int saleAmount = 1001;

int discount =
    saleAmount > 1000
        ? 100
        : 50;

Console.WriteLine($"Discount: {discount}");
```

Expected output:

```text
Discount: 100
```

The project also demonstrates using the conditional operator directly inside an
interpolated string.

---

## Conditional Operator Challenge

The challenge simulates a coin flip:

```csharp
Random coin = new Random();

int flip = coin.Next(0, 2);

Console.WriteLine(
    flip == 0
        ? "heads"
        : "tails");
```

`Random.Next(0, 2)` returns either `0` or `1`, so the possible output is:

```text
heads
```

or:

```text
tails
```

---

## Boolean Expressions Challenge

Initial data:

```csharp
string permission = "Admin|Manager";
int level = 53;
```

Business rules:

| Permission and level | Output |
| --- | --- |
| Admin and level greater than `55` | `Welcome, Super Admin user.` |
| Admin and level `55` or lower | `Welcome, Admin user.` |
| Manager and level `20` or greater | `Contact an Admin for access.` |
| Manager and level lower than `20` | `You do not have sufficient privileges.` |
| Neither Admin nor Manager | `You do not have sufficient privileges.` |

Decision structure:

```text
Check Admin permission
    ├── level > 55
    └── level <= 55

Otherwise check Manager permission
    ├── level >= 20
    └── level < 20

Otherwise deny access
```

With the current values, the verified result is:

```text
Welcome, Admin user.
```

---

## Source-Code Cleanup

The original study file contained the full learning sequence, but also included
duplicate declarations and invalid intermediate attempts. The final executable
version corrects:

```text
Duplicate variable declarations
Unused using directives
Missing semicolon after Random.Next()
Invalid if-statement syntax
Incorrect use of the | operator
Semicolon placed after an if condition
Repeated pangram and saleAmount declarations
```

The final code remains complete enough to serve as a learning reference while
also compiling cleanly as one executable project.

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\evaluate-boolean-expressions\evaluate-boolean-expressions.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\evaluate-boolean-expressions\evaluate-boolean-expressions.csproj"
```

Build the full solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded
Full solution build: Succeeded
Solution projects: 14
Verification date: July 24, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| Boolean | `/ˈbuː.li.ən/` | “bu-li-ần” | kiểu logic có `true` hoặc `false` |
| expression | `/ɪkˈspreʃ.ən/` | “ịch-spre-shần” | biểu thức tạo ra một giá trị |
| equality | `/iˈkwɒl.ə.ti/` | “i-quo-lờ-ti” | sự bằng nhau |
| inequality | `/ˌɪn.ɪˈkwɒl.ə.ti/` | “in-i-quo-lờ-ti” | sự không bằng nhau |
| comparison | `/kəmˈpær.ɪ.sən/` | “cờm-pe-rờ-sần” | phép so sánh |
| negation | `/nɪˈɡeɪ.ʃən/` | “ni-gây-shần” | phép phủ định |
| conditional operator | `/kənˈdɪʃ.ən.əl ˈɒp.ər.eɪ.tər/` | “cần-đi-shờ-nồ op-pờ-rây-tờ” | toán tử điều kiện `?:` |
| permission | `/pəˈmɪʃ.ən/` | “pờ-mi-shần” | quyền truy cập |
| privilege | `/ˈprɪv.əl.ɪdʒ/` | “pri-vờ-lịch” | đặc quyền |
| normalize | `/ˈnɔː.mə.laɪz/` | “no-mờ-lai-z” | chuẩn hóa dữ liệu |

---

## Completion Record

```text
Curriculum item: Evaluate Boolean Expressions to Make Decisions in C#
Section: Add Logic to C# Console Applications
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local run: Verified
Project registration: Verified
Project build: Verified
Full solution build: Verified
Solution project count: 14
Completion date: July 24, 2026
```

---

# Module 2 — Control Variable Scope and Logic Using Code Blocks in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project added to solution: Verified
Solution project count: 15
Project build: Verified
Full solution build: Verified
Completion date: July 25, 2026
```

This module explains how code blocks affect execution flow, variable visibility,
definite assignment, and the readability of conditional logic.

The final `Program.cs` preserves the complete instructional sequence while
keeping intentionally invalid examples inside comments. This allows the project
to remain a useful learning reference and still compile cleanly.

---

## Learning Objectives

The completed project demonstrates how to:

- define a code block with curly braces `{ }`;
- understand local variable scope;
- distinguish an inner block from its surrounding block;
- declare variables in a scope shared by multiple statements;
- initialize local variables before reading them;
- recognize compiler errors caused by scope and definite assignment;
- use braces consistently with `if`, `else if`, and `else`;
- improve readability by placing statements on separate lines;
- preserve values created inside a `foreach` loop for use afterward.

---

## Code Blocks and Local Scope

A code block contains one or more statements enclosed by curly braces:

```csharp
{
    // Statements inside the block.
}
```

A variable declared inside a block is visible only inside that block:

```csharp
bool flag = true;

if (flag)
{
    int localValue = 10;
    Console.WriteLine($"Inside the code block: {localValue}");
}
```

Expected output:

```text
Inside the code block: 10
```

Attempting to use `localValue` after the `if` block would produce:

```text
CS0103: The name 'localValue' does not exist in the current context.
```

To access a value both inside and after a block, declare it in the surrounding
scope:

```csharp
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
```

Expected output:

```text
Inside the code block: 0
Outside the code block: 10
```

---

## Definite Assignment

Declaring a local variable does not automatically assign it a value.

```csharp
int value;
Console.WriteLine(value);
```

This would produce:

```text
CS0165: Use of unassigned local variable 'value'.
```

The corrected form initializes the variable before it is read:

```csharp
int value = 0;
```

---

## Braces and Readability

C# permits braces to be omitted when an `if` statement controls exactly one
statement:

```csharp
if (flag)
    Console.WriteLine(flag);
```

Braces are still valid and make block boundaries explicit:

```csharp
if (flag)
{
    Console.WriteLine(flag);
}
```

The final repository code avoids dense single-line formatting such as:

```csharp
if (flag) Console.WriteLine(flag);
```

For larger conditional structures, every branch uses braces consistently:

```csharp
string name = "steve";

if (name == "bob")
{
    Console.WriteLine("Found Bob");
}
else if (name == "steve")
{
    Console.WriteLine("Found Steve");
}
else
{
    Console.WriteLine("Found Chuck");
}
```

Expected output:

```text
Found Steve
```

---

## Variable Scope Challenge

The challenge processes an integer array, calculates the total, and reports
whether the value `42` is present:

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

Expected and verified output:

```text
Set contains 42
Total: 108
```

`total` and `found` are declared before the `foreach` block because their final
values are required after the loop. The iteration variable `number` remains
local to the loop.

---

## Source-Code Cleanup

The original learning notes contained all exercises in one file, including
examples that were intentionally invalid. The final executable version resolves:

```text
Repeated declarations of flag, value, and name
Unused using directive
Access to a variable outside its declaring block
Reading an unassigned local variable
Multiple examples sharing one top-level scope
Dense single-line conditional formatting
Inconsistent use of braces
```

Independent examples are enclosed in separate outer blocks, while compiler-error
examples remain documented inside comments.

---

## Verified Runtime Output

```text
Inside the code block: 10
Inside the code block: 0
Outside the code block: 10
True
True
Found Steve
Set contains 42
Total: 108
```

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\\curriculum\\add-logic-to-csharp-console-applications\\modules\\code-blocks-variable-scope\\code-blocks-variable-scope.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\\curriculum\\add-logic-to-csharp-console-applications\\modules\\code-blocks-variable-scope\\code-blocks-variable-scope.csproj"
```

Build the complete solution:

```powershell
dotnet build .\\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Module build: Succeeded
Full solution build: Succeeded
Solution projects: 15
Verification date: July 25, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| code block | `/kəʊd blɒk/` | “câuđ bloc” | khối gồm một hoặc nhiều câu lệnh |
| variable scope | `/ˈveə.ri.ə.bəl skəʊp/` | “ve-ri-ờ-bồ scốp” | phạm vi truy cập của biến |
| local variable | `/ˈləʊ.kəl ˈveə.ri.ə.bəl/` | “lâu-cồ ve-ri-ờ-bồ” | biến cục bộ |
| visibility | `/ˌvɪz.əˈbɪl.ə.ti/` | “vi-zờ-bi-lờ-ti” | khả năng được truy cập |
| initialization | `/ɪˌnɪʃ.əl.aɪˈzeɪ.ʃən/` | “i-ni-shờ-lai-zây-shần” | việc gán giá trị ban đầu |
| definite assignment | `/ˈdef.ɪ.nət əˈsaɪn.mənt/` | “đe-fi-nịt ờ-sai-n-mần” | bảo đảm biến đã được gán giá trị |
| curly braces | `/ˈkɜː.li ˈbreɪ.sɪz/` | “cơ-li brây-sịt” | dấu ngoặc nhọn `{ }` |
| execution path | `/ˌek.sɪˈkjuː.ʃən pɑːθ/` | “éc-si-kiu-shần path” | đường thực thi |
| readability | `/ˌriː.dəˈbɪl.ə.ti/` | “ri-đờ-bi-lờ-ti” | tính dễ đọc |

---

## Completion Record

```text
Curriculum item: Control Variable Scope and Logic Using Code Blocks in C#
Section: Add Logic to C# Console Applications
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local run: Verified
Project registration: Verified
Project build: Verified
Full solution build: Verified
Solution project count: 15
Completion date: July 25, 2026
```

---

## Next Step

Proceed to the next official curriculum item in:

**Add Logic to C# Console Applications**

Preserve the repository structure, register each project in
`freecodecamp-csharp.slnx`, keep the fifteen-project solution green, and update
this README after completing the next module.
