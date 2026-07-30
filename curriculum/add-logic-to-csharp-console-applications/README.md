# Add Logic to C# Console Applications

![C#](https://img.shields.io/badge/C%23-Section_3-512BD4?logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Completed-16A34A)
![Progress](https://img.shields.io/badge/Curriculum_Items-7%2F7-16A34A)
![Projects](https://img.shields.io/badge/Solution_Projects-20-2563EB)
![Build](https://img.shields.io/badge/Full_Solution_Build-Passing-16A34A)
![Trophy](https://img.shields.io/badge/Microsoft_Learn_Trophy-Verified-512BD4)
![Certificate](https://img.shields.io/badge/Certificate-Earned-0EA5E9)

Section 3 of the **Foundational C# with Microsoft Certification** curriculum.

This section develops decision-making and control-flow skills for C# console
applications. Every completed curriculum item is stored as a runnable project,
registered in the solution, documented, and verified with both a project build
and a full-solution build.

---

## Section Status

```text
Section: Add Logic to C# Console Applications
Status: Completed
Curriculum progress: 7 / 7
Completed instructional modules: 5
Completed guided projects: 1
Completed challenge projects: 1
Latest completed item: Challenge Project - Develop Branching and Looping Structures in C#
Latest item assessment: Passed
Microsoft Learn achievement: Earned
Microsoft Learn trophy: Verified
Microsoft Learn certificate: Earned
freeCodeCamp section completion: Verified
Latest completion date: July 30, 2026
Projects registered in solution: 20
Latest project run: Verified
Latest project build: Verified
Latest project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 2.6 seconds
```

| Curriculum item | Status |
| --- | --- |
| Evaluate Boolean Expressions to Make Decisions in C# | Completed |
| Control Variable Scope and Logic Using Code Blocks in C# | Completed |
| Branch the Flow of Code Using the switch-case Construct in C# | Completed |
| Iterate Through a Code Block Using the for Statement in C# | Completed |
| Add Looping Logic to Your Code Using the do-while and while Statements in C# | Completed |
| Guided Project - Develop Conditional Branching and Looping Structures in C# | Completed |
| Challenge Project - Develop Branching and Looping Structures in C# | Completed |

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
│   ├── code-blocks-variable-scope/
│   │   ├── Program.cs
│   │   └── code-blocks-variable-scope.csproj
│   ├── switch-case-construct/
│   │   ├── Program.cs
│   │   └── switch-case-construct.csproj
│   ├── for-statement/
│   │   ├── Program.cs
│   │   └── for-statement.csproj
│   └── do-while-and-while-statements/
│       ├── Program.cs
│       └── do-while-and-while-statements.csproj
├── guided-projects/
│   └── contoso-pets/
│       ├── Program.cs
│       └── contoso-pets.csproj
├── challenge-projects/
│   └── contoso-pets-challenge/
│       ├── Program.cs
│       └── contoso-pets-challenge.csproj
└── trophy/
    ├── README.md
    └── assets/
        ├── 1.PNG
        └── 2.PNG
```

This section uses one central README for curriculum notes. Individual module
directories contain executable source code and project files without an
additional README. The `trophy/README.md` file documents the two official
completion-evidence images stored under `trophy/assets/`.

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


# Module 3 — Branch the Flow of Code Using the `switch-case` Construct in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project added to solution: Verified
Solution project count: 16
Project build: Verified
Full solution build: Verified
Completion date: July 26, 2026
```

This module introduces the C# `switch` statement as an alternative to an
`if-elseif-else` chain when one value must be compared against several known
matching values.

The final `Program.cs` preserves the module's instructional sequence in three
runnable examples:

1. matching a fruit name;
2. assigning an employee title from an employee level;
3. decoding a product SKU in the module challenge.

Separate methods keep the examples independent, avoid duplicate top-level
variable declarations, and make the project easier to test and maintain.

---

## Learning Objectives

The completed project demonstrates how to:

- branch execution with a `switch` statement;
- use a switch expression as the value being evaluated;
- define matching alternatives with `case` labels;
- provide a fallback branch with `default`;
- terminate a switch section with `break`;
- combine multiple `case` labels into one switch section;
- recognize that C# does not allow implicit fall-through between non-empty
  switch sections;
- decide when `switch` is clearer than `if-elseif-else`;
- convert an existing `if-elseif-else` chain into equivalent `switch`
  statements.

---

## Basic `switch` Structure

A switch statement evaluates one expression and selects one matching section:

```csharp
string fruit = "apple";

switch (fruit)
{
    case "apple":
        Console.WriteLine(
            "App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine(
            "App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine(
            "App will display information for cherry.");
        break;

    default:
        Console.WriteLine(
            "The selected fruit is not currently supported.");
        break;
}
```

Execution sequence:

```text
Evaluate the switch expression
    ↓
Compare it with each case label
    ↓
Execute the first matching switch section
    ↓
Stop that section with break
    ↓
Continue after the switch statement
```

With the current value, the verified output is:

```text
App will display information for apple.
```

---

## When to Use `switch`

A `switch` statement is especially suitable when:

- one variable or expression is being evaluated;
- the possible matching values are known;
- each match requires only a small branch of code;
- a long `if-elseif-else` chain would be harder to scan.

Example decision:

```text
One value + many exact matches → switch
Different unrelated conditions → if / else if / else
Range comparisons             → usually if / else if / else
```

The module uses equality-style matching rather than numeric ranges or multiple
independent Boolean expressions.

---

## Employee-Level Example

The employee example evaluates one integer value and assigns a title:

```csharp
switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;

    case 300:
        title = "Manager";
        break;

    case 400:
        title = "Senior Manager";
        break;

    default:
        title = "Associate";
        break;
}
```

Multiple labels can share one switch section:

```csharp
case 100:
case 200:
    title = "Senior Associate";
    break;
```

Both level `100` and level `200` therefore produce:

```text
Senior Associate
```

The final project tests three values:

| Employee level | Selected branch | Result |
| ---: | --- | --- |
| `200` | `case 200` | `Senior Associate` |
| `201` | `default` | `Associate` |
| `100` | shared `case 100` / `case 200` section | `Senior Associate` |

Verified output:

```text
Employee: John Smith, Level: 200, Title: Senior Associate
Employee: John Smith, Level: 201, Title: Associate
Employee: John Smith, Level: 100, Title: Senior Associate
```

---

## `case`, `default`, and `break`

### `case`

A `case` label defines a value that may match the switch expression:

```csharp
case 300:
    title = "Manager";
    break;
```

### `default`

The optional `default` section handles values that do not match any explicit
`case` label:

```csharp
default:
    title = "Associate";
    break;
```

Although `default` can appear elsewhere, placing it last usually makes the
control flow easier to read.

### `break`

`break` terminates the current switch section:

```csharp
break;
```

C# does not permit a non-empty switch section to continue implicitly into the
next non-empty section. Omitting the required terminating statement results in
a compiler error.

---

## SKU Challenge

`SKU` means **Stock Keeping Unit**.

The challenge uses this format:

```text
<product number>-<two-letter color code>-<size code>
```

Current value:

```csharp
string sku = "01-MN-L";
```

The string is split into three components:

```csharp
string[] productParts = sku.Split('-');
```

Result:

```text
productParts[0] = "01"
productParts[1] = "MN"
productParts[2] = "L"
```

Each component is decoded by a separate switch statement.

### Product type

```csharp
switch (productParts[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}
```

### Product color

```csharp
switch (productParts[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}
```

### Product size

```csharp
switch (productParts[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One Size Fits All";
        break;
}
```

Final composition:

```csharp
Console.WriteLine($"SKU: {sku}");
Console.WriteLine($"Product: {size} {color} {type}");
```

Verified output:

```text
SKU: 01-MN-L
Product: Large Maroon Sweat shirt
```

---

## Converting `if-elseif-else` to `switch`

The original challenge contained three `if-elseif-else` chains:

```text
Product code → type
Color code   → color
Size code    → size
```

Each chain evaluated one array element against several exact string values.
That structure maps directly to a `switch` statement.

Conceptual conversion:

```csharp
if (value == "A")
{
    // Branch A
}
else if (value == "B")
{
    // Branch B
}
else
{
    // Fallback
}
```

becomes:

```csharp
switch (value)
{
    case "A":
        // Branch A
        break;

    case "B":
        // Branch B
        break;

    default:
        // Fallback
        break;
}
```

The converted code produces the same result while making the list of possible
matches easier to scan.

---

## Source-Code Organization

The original study notes contained several independent examples with repeated
variable names. Placing every example directly in one top-level scope would
cause duplicate local-variable declarations.

The final executable code organizes the module into methods:

```text
RunFruitExample()
RunEmployeeLevelExample()
DisplayEmployeeTitle(...)
RunSkuChallenge()
```

This structure provides:

- isolated local scopes;
- no duplicate top-level declarations;
- clear example boundaries;
- reusable employee-title logic;
- readable console output;
- easier future testing and maintenance.

The project also documents each method using XML documentation comments and
adds focused inline comments around the control-flow decisions.

---

## Verified Runtime Output

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

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\switch-case-construct\switch-case-construct.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\switch-case-construct\switch-case-construct.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Project registered in solution: Verified
Solution projects: 16
Module build: Succeeded
Full solution build: Succeeded
Verification date: July 26, 2026
```


---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| branch | `/brɑːntʃ/` | “bran-ch” | phân nhánh luồng thực thi |
| flow | `/fləʊ/` | “flâu” | luồng thực thi |
| switch statement | `/swɪtʃ ˈsteɪt.mənt/` | “suých stây-t-mần” | câu lệnh lựa chọn nhiều nhánh |
| switch expression | `/swɪtʃ ɪkˈspreʃ.ən/` | “suých ịch-spre-shần” | giá trị được `switch` đánh giá |
| case label | `/keɪs ˈleɪ.bəl/` | “kâys lây-bồ” | nhãn biểu diễn một giá trị khớp |
| switch section | `/swɪtʃ ˈsek.ʃən/` | “suých sék-shần” | phần mã thuộc một hoặc nhiều nhãn |
| default | `/dɪˈfɔːlt/` | “đi-folt” | nhánh dự phòng |
| break | `/breɪk/` | “brâyk” | kết thúc switch section hiện tại |
| pattern match | `/ˈpæt.ən mætʃ/` | “pát-tần mát-ch” | đối sánh mẫu |
| fall-through | `/ˈfɔːl.θruː/` | “fol-thru” | tiếp tục sang nhánh kế tiếp |
| Stock Keeping Unit | `/stɒk ˈkiː.pɪŋ ˈjuː.nɪt/` | “stok ki-ping diu-nịt” | mã đơn vị lưu kho |

---

## Completion Record

```text
Curriculum item: Branch the Flow of Code Using the switch-case Construct in C#
Section: Add Logic to C# Console Applications
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local run: Verified
Project registration: Verified
Project build: Verified
Full solution build: Verified
Solution project count: 16
Completion date: July 26, 2026
```

---

---

# Module 4 — Iterate Through a Code Block Using the `for` Statement in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local project run: Verified
Project added to solution: Verified
Solution project count: 17
Project build: Verified
Full solution build: Verified
Completion date: July 27, 2026
```

This module introduces the C# `for` iteration statement and demonstrates how it
provides explicit control over initialization, continuation, and update rules.

The final `Program.cs` preserves the complete learning sequence in seven
independent examples:

1. a basic count-up loop;
2. a countdown loop;
3. a loop with a custom step;
4. early termination with `break`;
5. reverse array traversal;
6. array modification by index;
7. the FizzBuzz challenge.

Each example is placed in a dedicated method so that the module remains
runnable, readable, testable, and maintainable.

---

## Learning Objectives

The completed project demonstrates how to:

- repeat a code block a known number of times;
- identify the initializer, condition, iterator, and loop body;
- count upward or downward;
- change the iterator by more than one;
- terminate a loop early with `break`;
- traverse an array by index;
- iterate through an array in reverse order;
- distinguish index-based `for` iteration from value-based `foreach` iteration;
- modify array elements by using their indexes;
- combine `for`, `if`, `%`, and `&&`;
- order conditional branches correctly in the FizzBuzz challenge.

---

## Anatomy of a `for` Statement

General syntax:

```csharp
for (initializer; condition; iterator)
{
    // Loop body
}
```

Basic example:

```csharp
for (int index = 0; index < 10; index++)
{
    Console.WriteLine(index);
}
```

| Part | Example | Purpose |
| --- | --- | --- |
| Initializer | `int index = 0` | Creates and initializes the loop-control variable |
| Condition | `index < 10` | Determines whether another iteration may run |
| Iterator | `index++` | Updates the loop-control variable after each iteration |
| Body | `{ ... }` | Contains the statements executed during each iteration |

Execution sequence:

```text
Run initializer once
    ↓
Evaluate condition
    ├── false → exit the loop
    └── true
          ↓
       Execute loop body
          ↓
       Execute iterator
          ↓
       Evaluate condition again
```

Verified values:

```text
0
1
2
3
4
5
6
7
8
9
```

The loop stops when `index` reaches `10`, because `10 < 10` is `false`.

---

## Counting Downward

```csharp
for (int counter = 10; counter >= 0; counter--)
{
    Console.WriteLine(counter);
}
```

Configuration:

```text
Initializer: counter starts at 10
Condition:   continue while counter is at least 0
Iterator:    subtract 1 after every iteration
```

Verified sequence:

```text
10
9
8
7
6
5
4
3
2
1
0
```

---

## Changing the Iteration Step

```csharp
for (int counter = 0; counter < 10; counter += 3)
{
    Console.WriteLine(counter);
}
```

Verified output:

```text
0
3
6
9
```

`counter += 3` advances the iterator by three after each iteration.

---

## Stopping a Loop with `break`

```csharp
for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine(counter);

    if (counter == 7)
    {
        break;
    }
}
```

Verified output:

```text
0
1
2
3
4
5
6
7
```

The normal condition would allow values through `9`, but `break` terminates the
loop immediately after `7` is printed.

---

## Traversing an Array in Reverse

```csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int index = names.Length - 1; index >= 0; index--)
{
    Console.WriteLine(names[index]);
}
```

For this array:

```text
names.Length = 4
last valid index = 3
```

Verified output:

```text
Michael
David
Eddie
Alex
```

---

## `for` Compared with `foreach`

`foreach` is concise when each element only needs to be read:

```csharp
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

However, the iteration variable cannot be reassigned:

```csharp
foreach (string name in names)
{
    // Invalid:
    // name = "Sammy";
}
```

A `for` statement provides an index, so the array element can be changed:

```csharp
for (int index = 0; index < names.Length; index++)
{
    if (names[index] == "David")
    {
        names[index] = "Sammy";
    }
}
```

Verified updated array:

```text
Alex
Eddie
Sammy
Michael
```

Practical distinction:

```text
Read every value simply                 → foreach
Need the index                          → for
Need reverse or custom-order traversal  → for
Need to replace an array element        → for
```

---

## FizzBuzz Challenge

Rules:

| Condition | Output suffix |
| --- | --- |
| Divisible by both `3` and `5` | `FizzBuzz` |
| Divisible by `3` only | `Fizz` |
| Divisible by `5` only | `Buzz` |
| None of the above | No suffix |

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

The remainder operator `%` checks whether division leaves a remainder:

```text
number % divisor == 0
```

The logical AND operator `&&` requires both divisibility conditions to be true.

Representative output:

```text
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
...
15 - FizzBuzz
...
96 - Fizz
97
98
99 - Fizz
100 - Buzz
```

---

## Why the Combined Condition Comes First

For `15`:

```text
15 % 3 == 0 → true
15 % 5 == 0 → true
```

If divisibility by `3` were checked first, the program would print only:

```text
15 - Fizz
```

Correct branch precedence:

```text
Divisible by both 3 and 5
    ↓ otherwise
Divisible by 3
    ↓ otherwise
Divisible by 5
    ↓ otherwise
Print the number
```

---

## Source-Code Organization

The final executable project organizes the module into:

```text
RunBasicForLoop()
RunCountdownLoop()
RunCustomStepLoop()
RunBreakExample()
RunReverseArrayExample()
RunArrayUpdateExample()
RunFizzBuzzChallenge()
WriteSectionHeader(...)
```

This structure provides:

- independent local scopes;
- descriptive variable names;
- reusable heading output;
- consistent braces;
- XML documentation comments;
- preservation of intentionally invalid `foreach` code inside comments;
- easier testing, review, and future maintenance.

---

## Verified Runtime Output

The project run confirms:

```text
Basic loop: 0 through 9
Countdown: 10 through 0
Custom step: 0, 3, 6, 9
Break example: 0 through 7
Reverse array: Michael, David, Eddie, Alex
Updated array: Alex, Eddie, Sammy, Michael
FizzBuzz: 1 through 100 with the required labels
```

The final lines are:

```text
96 - Fizz
97
98
99 - Fizz
100 - Buzz
```

---

## Build Verification

Run the module:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\for-statement\for-statement.csproj"
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\for-statement\for-statement.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Module run: Succeeded
Module output: Verified
Project registered in solution: Verified
Solution projects: 17
Module build: Succeeded
Full solution build: Succeeded
Verification date: July 27, 2026
```

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| iterate | `/ˈɪt.ə.reɪt/` | “ít-tờ-râyt” | lặp lại hoặc duyệt qua |
| iteration | `/ˌɪt.əˈreɪ.ʃən/` | “ít-tờ-rây-shần” | một lần thực hiện vòng lặp |
| for statement | `/fɔː ˈsteɪt.mənt/` | “fo stây-t-mần” | câu lệnh lặp `for` |
| initializer | `/ɪˈnɪʃ.əl.aɪ.zər/` | “i-ni-shờ-lai-zờ” | biểu thức khởi tạo |
| condition | `/kənˈdɪʃ.ən/` | “cần-đi-shần” | điều kiện tiếp tục |
| iterator | `/ˈɪt.ə.reɪ.tər/` | “ít-tờ-rây-tờ” | biểu thức cập nhật sau mỗi lần lặp |
| loop body | `/luːp ˈbɒd.i/` | “lúp bo-đi” | khối mã được lặp |
| increment | `/ˈɪŋ.krə.mənt/` | “in-crờ-mần” | tăng giá trị |
| decrement | `/ˈdek.rə.mənt/` | “đe-crờ-mần” | giảm giá trị |
| remainder operator | `/rɪˈmeɪn.dər ˈɒp.ər.eɪ.tər/` | “ri-mây-nđờ op-pờ-rây-tờ” | toán tử lấy số dư `%` |
| divisible | `/dɪˈvɪz.ə.bəl/` | “đi-vi-zờ-bồ” | chia hết |
| zero-based index | `/ˈzɪə.rəʊ beɪst ˈɪn.deks/` | “zi-râu bâyst in-đéc” | chỉ số bắt đầu từ `0` |
| FizzBuzz | `/fɪz bʌz/` | “fiz-bâz” | bài luyện vòng lặp và điều kiện |

---

## Completion Record

```text
Curriculum item: Iterate Through a Code Block Using the for Statement in C#
Section: Add Logic to C# Console Applications
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Local run: Verified
Project registration: Verified
Project build: Verified
Full solution build: Verified
Solution project count: 17
Completion date: July 27, 2026
```

---

# Module 5 — Add Looping Logic to Your Code Using the `do-while` and `while` Statements in C#

## Completion Status

```text
Learning content: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Project added to solution: Verified
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

This module extends C# iteration logic beyond `for` and `foreach`. It explains
how `do-while` and `while` repeat a code block until a Boolean exit condition is
reached, and how values generated or retrieved inside the loop can determine
when iteration stops.

The final organized `Program.cs` preserves the complete learning sequence in
eight independent methods:

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

The source is organized this way to avoid duplicate top-level declarations,
separate interactive challenges from random-number examples, and make each form
of iteration easier to understand, test, and maintain.

---

## Learning Objectives

The completed learning content demonstrates how to:

- use `do-while` when the loop body must execute at least once;
- use `while` when the condition must be checked before the loop body;
- recognize that `do-while` executes one or more times;
- recognize that `while` executes zero or more times;
- build loop exit conditions from values produced inside the loop;
- create an intentional infinite loop and understand why it requires an exit;
- use `continue` to skip the remainder of the current iteration;
- distinguish `continue` from `break`;
- validate nullable console input;
- convert text input safely with `int.TryParse()`;
- normalize role input with `Trim()` and case normalization;
- combine `for` and `while` for string-array processing;
- use `IndexOf()`, `Remove()`, `Substring()`, and `TrimStart()`;
- select the appropriate iteration statement for a specific problem.

---

## Comparing the Four Iteration Statements

C# iteration statements differ primarily in how they determine the number of
iterations and when their conditions are evaluated.

| Statement | Typical use | Minimum executions |
| --- | --- | ---: |
| `for` | A known or controlled number of iterations | `0` |
| `foreach` | Process each element in a collection | `0` |
| `do-while` | Execute first, then evaluate the condition | `1` |
| `while` | Evaluate the condition before executing | `0` |

Practical selection guide:

```text
Known counter or index progression       → for
Read every item in a collection          → foreach
Must request/process something once      → do-while
May not need to execute at all            → while
```

The important distinction is not only syntax. It is the position of the Boolean
evaluation relative to the loop body.

---

## `do-while`: Execute Before Evaluating

General syntax:

```csharp
do
{
    // Loop body
}
while (condition);
```

Execution sequence:

```text
Execute the loop body
        ↓
Evaluate the Boolean condition
    ├── true  → execute the body again
    └── false → leave the loop
```

Because the condition is evaluated afterward, the body runs at least once.

A required syntax detail is the semicolon after the condition:

```csharp
while (condition);
                 ^
```

### Infinite-loop form

```csharp
do
{
    // Repeated work
}
while (true);
```

Hard-coding the condition to `true` creates an infinite loop unless a statement
inside the body can terminate it, such as:

```csharp
break;
```

Code placed after a provably infinite loop without an exit becomes unreachable,
which Visual Studio displays in a faded style and reports with warning
`CS0162`.

---

## Random-Number `do-while` Example

The first example generates values from `1` through `10` until `7` appears:

```csharp
Random random = new();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
}
while (current != 7);
```

`Random.Next(1, 11)` uses:

```text
Inclusive lower bound: 1
Exclusive upper bound: 11
Possible results: 1 through 10
```

The continuation rule is:

```text
current != 7 → true  → repeat
current != 7 → false → stop
```

The last displayed random value is therefore always:

```text
7
```

The number of iterations is unknown in advance. The loop may stop immediately
or may require many generated values.

---

## `while`: Evaluate Before Executing

General syntax:

```csharp
while (condition)
{
    // Loop body
}
```

Execution sequence:

```text
Evaluate the Boolean condition
    ├── false → skip the body
    └── true
          ↓
       Execute the body
          ↓
       Evaluate the condition again
```

The body can execute zero times.

Example:

```csharp
Random random = new();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");
```

Two initial cases are possible:

```text
current is 1 or 2   → condition is false; body executes zero times
current is 3 to 10  → body executes and generates another value
```

The value printed as `Last number` is the value that caused the loop condition
to become false.

---

## `continue` Compared with `break`

`continue` ends only the current iteration:

```csharp
if (current >= 8)
{
    continue;
}
```

Control transfers directly to the next condition evaluation.

`break` ends the entire loop:

```csharp
if (shouldStop)
{
    break;
}
```

Comparison:

```text
continue → skip the remaining code in this iteration
break    → terminate the complete loop
```

Example:

```csharp
do
{
    current = random.Next(1, 11);

    if (current >= 8)
    {
        continue;
    }

    Console.WriteLine(current);
}
while (current != 7);
```

Values `8`, `9`, and `10` are not displayed because `continue` skips the
`Console.WriteLine()` statement. The value `7` is displayed and then ends the
loop.

---

## Battle Challenge

The role-playing challenge uses these rules:

```text
Hero health: 10
Monster health: 10
Attack damage: 1 through 10
Hero attacks first
Monster attacks only if still alive
Battle continues while both have health above 0
```

Core implementation:

```csharp
do
{
    int damage = dice.Next(1, 11);
    monsterHealth -= damage;

    Console.WriteLine(
        $"Monster was damaged and lost {damage} health " +
        $"and now has {monsterHealth} health.");

    if (monsterHealth <= 0)
    {
        continue;
    }

    damage = dice.Next(1, 11);
    heroHealth -= damage;

    Console.WriteLine(
        $"Hero was damaged and lost {damage} health " +
        $"and now has {heroHealth} health.");
}
while (heroHealth > 0 && monsterHealth > 0);
```

`do-while` is appropriate because the game rules require the hero to attack
first. The battle body must therefore execute at least once.

The monster-defeat check appears before the monster attack:

```csharp
if (monsterHealth <= 0)
{
    continue;
}
```

This prevents a defeated monster from taking another turn.

Winner selection:

```csharp
Console.WriteLine(
    monsterHealth <= 0
        ? "Hero wins!"
        : "Monster wins!");
```

---

## Nullable Console Input

`Console.ReadLine()` returns:

```csharp
string?
```

The question mark means that the result may be either:

```text
A string entered by the user
null when no input is available
```

A basic null-checking input loop is:

```csharp
string? readResult;

do
{
    readResult = Console.ReadLine();
}
while (readResult == null);
```

This demonstrates a common use of `do-while`: the program must attempt to read
input at least once.

---

## Numeric Conversion with `int.TryParse()`

Console input is text. Numeric validation therefore requires conversion.

```csharp
bool isValidNumber = int.TryParse(
    readResult,
    out acceptedValue);
```

When conversion succeeds:

```text
Return value: true
out variable: converted integer
```

When conversion fails:

```text
Return value: false
out variable: 0
No conversion exception is thrown
```

This is safer for validation than `int.Parse()` because invalid user input is an
expected condition rather than an exceptional program failure.

---

## Integer-Input Challenge

Requirement:

```text
Accept an integer from 5 through 10, inclusive.
```

Correct range rejection:

```csharp
if (acceptedValue < 5 || acceptedValue > 10)
{
    isValidNumber = false;
}
```

Accepted values:

```text
5, 6, 7, 8, 9, 10
```

The original learning notes used:

```csharp
numValue <= 5 || numValue >= 10
```

That condition would reject both boundary values and accept only `6` through
`9`. The organized final code uses the inclusive range required by the
challenge.

Validation sequence:

```text
Read string input
        ↓
TryParse succeeds?
    ├── no  → print invalid-number message and continue
    └── yes
          ↓
       Value within 5..10?
          ├── no  → reject and repeat
          └── yes → leave the loop
```

Representative interaction:

```text
Enter an integer value between 5 and 10:
two
Sorry, you entered an invalid number. Please try again.
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
```

---

## Role-Input Challenge

Accepted role names:

```text
Administrator
Manager
User
```

The program ignores leading/trailing whitespace and letter casing:

```csharp
roleName = (readResult ?? string.Empty).Trim();
string normalizedRole = roleName.ToLowerInvariant();
```

Validation:

```csharp
isValidRole =
    normalizedRole == "administrator" ||
    normalizedRole == "manager" ||
    normalizedRole == "user";
```

Examples that should be accepted:

```text
Administrator
administrator
   Administrator
MANAGER
user
```

`ToLowerInvariant()` is used because these are fixed program keywords whose
comparison should not change with the operating system's current culture.

Representative interaction:

```text
Enter your role name (Administrator, Manager, or User):
Admin
The role name that you entered, "Admin", is not valid.
Enter your role name (Administrator, Manager, or User):
   Administrator
Your input value (Administrator) has been accepted.
```

---

## String-Array Processing Challenge

Input:

```csharp
string[] myStrings =
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices"
};
```

Required output:

```text
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
```

The outer loop uses `for`:

```csharp
for (int index = 0; index < myStrings.Length; index++)
{
    string myString = myStrings[index];
}
```

This creates a modifiable working copy of each array element.

The inner loop uses `while`:

```csharp
while (periodLocation != -1)
{
    // Extract one sentence.
}
```

`while` is appropriate because a string may contain no period. In that case,
`IndexOf(".")` returns `-1`, and the body must execute zero times.

A `do-while` loop would incorrectly force one execution even when no period
exists.

---

## String-Processing Methods

### `IndexOf()`

```csharp
int periodLocation = myString.IndexOf(".");
```

Returns:

```text
The zero-based location of the first period
-1 when no period exists
```

### `Remove()`

```csharp
string mySentence = myString.Remove(periodLocation);
```

Returns the text before the period and excludes the period itself.

### `Substring()`

```csharp
myString = myString.Substring(periodLocation + 1);
```

Returns the remaining text after the period.

Adding `1` moves the starting position beyond the period character.

### `TrimStart()`

```csharp
myString = myString.TrimStart();
```

Removes leading whitespace before the next sentence.

Processing sequence:

```text
Find the first period
        ↓
Extract text before it
        ↓
Remove the extracted sentence and period
        ↓
Remove leading whitespace
        ↓
Search the shortened string again
```

The final sentence is displayed after no periods remain.

---

## Source-Code Organization and Cleanup

The original study notes contain every instructional step in one top-level
file. Keeping them unchanged would produce compilation errors because several
variables are declared repeatedly:

```text
random
current
readResult
validNumber
myStrings
```

The original notes also contain unused `using` directives.

The final organized `Program.cs` resolves this by:

- placing each example in a dedicated method;
- using descriptive names such as `heroHealth`, `monsterHealth`,
  `acceptedValue`, and `normalizedRole`;
- extracting repeated section-heading output into `WriteSectionHeader()`;
- using XML documentation comments;
- retaining detailed inline explanations of loop control;
- removing unused `using` directives;
- using constants for battle configuration;
- handling nullable input explicitly;
- normalizing role text only once;
- correcting the inclusive numeric range;
- preventing empty final sentences from being printed.

---

## Build and Runtime Verification

Run the completed module:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\do-while-and-while-statements\do-while-and-while-statements.csproj"
```

Suggested interactive test input:

```text
two
2
7
Admin
   Administrator
```

Build the module:

```powershell
dotnet build `
  ".\curriculum\add-logic-to-csharp-console-applications\modules\do-while-and-while-statements\do-while-and-while-statements.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Microsoft Learn completion: Verified
Module assessment: Passed
Achievement: Earned
Project registration: Verified
Solution project count: 18
Bootstrap Hello World run: Succeeded
Final organized Program.cs: Completed
Final-code run: Succeeded
Interactive validation behavior: Verified
Sentence-processing output: Verified
Module build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 6.4 seconds
Registered solution projects: 18
Verification date: July 28, 2026
```

The completed source ran through all random, battle, numeric-input, role-input,
and sentence-processing stages. The module project and the complete
eighteen-project solution then compiled successfully.

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| looping logic | `/ˈluː.pɪŋ ˈlɒdʒ.ɪk/` | “lu-ping lo-jịch” | logic điều khiển sự lặp |
| do-while statement | `/ˌduː ˈwaɪl ˈsteɪt.mənt/` | “đu-oai-l stây-t-mần” | chạy thân trước, kiểm tra điều kiện sau |
| while statement | `/waɪl ˈsteɪt.mənt/` | “oai-l stây-t-mần” | kiểm tra điều kiện trước khi chạy |
| Boolean expression | `/ˈbuː.li.ən ɪkˈspreʃ.ən/` | “bu-li-ần ịch-spre-shần” | biểu thức cho kết quả `true` hoặc `false` |
| iteration | `/ˌɪt.əˈreɪ.ʃən/` | “ít-tờ-rây-shần” | một lần thực hiện vòng lặp |
| infinite loop | `/ˈɪn.fɪ.nət luːp/` | “in-fi-nịt lúp” | vòng lặp không có điểm kết thúc |
| exit condition | `/ˈek.sɪt kənˈdɪʃ.ən/` | “éc-xịt cần-đi-shần” | điều kiện làm vòng lặp dừng |
| continue | `/kənˈtɪn.juː/` | “cần-tin-diu” | bỏ phần còn lại của lần lặp hiện tại |
| break | `/breɪk/` | “brâyk” | kết thúc toàn bộ vòng lặp |
| nullable | `/ˈnʌl.ə.bəl/` | “nâl-lờ-bồ” | kiểu có thể nhận giá trị `null` |
| parse | `/pɑːz/` | “pa-z” | phân tích và chuyển đổi văn bản |
| validation | `/ˌvæl.ɪˈdeɪ.ʃən/` | “va-li-đây-shần” | kiểm tra dữ liệu hợp lệ |
| short-circuit | `/ˌʃɔːt ˈsɜː.kɪt/` | “shot sơ-kịt” | dừng sớm việc xử lý hoặc đánh giá |
| substring | `/ˈsʌb.strɪŋ/` | “sâb-string” | chuỗi con |
| role-playing game | `/ˈrəʊl ˌpleɪ.ɪŋ ɡeɪm/` | “râul plây-ing gâym” | trò chơi nhập vai |

---

## Completion Record

```text
Curriculum item: Add Looping Logic to Your Code Using the do-while and while Statements in C#
Section: Add Logic to C# Console Applications
Learning status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Project registration: Verified
Solution project count: 18
Bootstrap run: Verified
Final organized source: Completed
Final-code run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 6.4 seconds
Completion date: July 28, 2026
```

---

# Guided Project 1 — Develop Conditional Branching and Looping Structures in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Final organized Program.cs: Completed
Project added to solution: Verified
Solution project count: 19
Local project run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 8.1 seconds
Completion date: July 29, 2026
```

This guided project develops **Contoso Pets**, a C# console application that
helps an animal-rescue team manage cats and dogs waiting for new homes.

The project combines the control-flow concepts introduced throughout Section 3:

```text
Boolean expressions
if / else logic
switch statements
for loops
while loops
do-while loops
continue
nullable console input
two-dimensional arrays
variable scope
input validation
```

The completed guided-project scope implements:

1. generation of predefined sample pet data;
2. a persistent top-level application menu;
3. menu selection with `switch`;
4. display of all stored pet records;
5. entry and validation of one or more new pets;
6. automatic pet-ID generation;
7. capacity management for a maximum of eight pets;
8. placeholders for features completed in the later challenge project.

---

## Project Location

```text
curriculum/add-logic-to-csharp-console-applications/
└── guided-projects/
    └── contoso-pets/
        ├── Program.cs
        └── contoso-pets.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

The solution now contains:

```text
19 projects
```

---

## Application Data Model

The runtime data store is a rectangular two-dimensional string array:

```csharp
string[,] ourAnimals =
    new string[MaxPets, CharacteristicCount];
```

Configured dimensions:

```text
Rows:    8 pets
Columns: 6 characteristics per pet
Total:   48 string elements
```

Each row represents one pet. Each column represents one characteristic:

| Column | Constant | Stored value |
| ---: | --- | --- |
| `0` | `PetIdColumn` | Pet ID |
| `1` | `SpeciesColumn` | Species |
| `2` | `AgeColumn` | Age |
| `3` | `NicknameColumn` | Nickname |
| `4` | `PhysicalDescriptionColumn` | Physical description |
| `5` | `PersonalityDescriptionColumn` | Personality description |

Example access:

```csharp
animals[row, PetIdColumn]
```

The first index selects the pet row. The second index selects one characteristic
within that row.

---

## Zero-Based Array Indexing

The application can manage eight pets:

```csharp
private const int MaxPets = 8;
```

The valid row indexes are:

```text
0, 1, 2, 3, 4, 5, 6, 7
```

The array has eight rows, but the last valid index is:

```text
MaxPets - 1 = 7
```

The outer iteration therefore begins at `0` and continues while the index is
less than the row count:

```csharp
for (int row = 0; row < animals.GetLength(0); row++)
{
    // Process one pet row.
}
```

Starting at `1` would skip the first row. Using `row <= MaxPets` would eventually
attempt to access index `8`, which is outside the array.

---

## Why Nested `for` Loops Are Used

Displaying all records requires two levels of iteration:

```csharp
for (int row = 0; row < animals.GetLength(0); row++)
{
    if (!HasPetData(animals, row))
    {
        continue;
    }

    for (
        int column = 0;
        column < animals.GetLength(1);
        column++)
    {
        Console.WriteLine(animals[row, column]);
    }
}
```

Responsibilities:

```text
Outer loop → select one pet
Inner loop → display all six characteristics for that pet
```

A single `foreach` over a rectangular two-dimensional array would process the
48 strings as one flattened sequence. It would not directly preserve the
required relationship of one row representing one pet.

A jagged array could support nested `foreach` loops because each outer element
would itself be a string array, but this project intentionally uses a
rectangular two-dimensional array.

---

## Sample Data Generation

`PopulateSampleData()` fills the first four rows with sample pets and initializes
the remaining rows as empty records.

A `switch` statement selects the sample data by row:

```csharp
switch (row)
{
    case 0:
        // Lola
        break;

    case 1:
        // Loki
        break;

    case 2:
        // Puss
        break;

    case 3:
        // Pet with incomplete information
        break;

    default:
        // Empty record
        break;
}
```

This replaces a longer `if-elseif-else` chain and makes each sample record easier
to identify and maintain.

The initial sample pets are:

```text
d1 → dog → lola
d2 → dog → loki
c3 → cat → puss
c4 → cat → incomplete information
```

---

## Main Application Loop

The menu must appear at least once, so the application uses a `do-while` loop:

```csharp
do
{
    DisplayMainMenu();
    menuSelection = ReadMenuSelection();

    switch (menuSelection)
    {
        // Menu branches
    }
}
while (menuSelection != "exit");
```

Execution sequence:

```text
Display menu
    ↓
Read selection
    ↓
Execute matching switch branch
    ↓
Return to menu
    ↓
Stop only when selection is "exit"
```

Input is normalized with:

```csharp
return (Console.ReadLine() ?? "exit")
    .Trim()
    .ToLowerInvariant();
```

This allows the following values to behave identically:

```text
exit
Exit
EXIT
   exit
```

A null console result is treated as `exit`, which allows the program to
terminate safely when no further input is available.

---

## Menu Selection with `switch`

The menu selection is text, so each case label is also text:

```csharp
switch (menuSelection)
{
    case "1":
        ListAllPets(animals);
        break;

    case "2":
        AddNewPets(animals);
        break;

    case "exit":
        Console.WriteLine(
            "Thank you for using Contoso PetFriends.");
        break;

    default:
        Console.WriteLine(
            $"\"{menuSelection}\" is not a valid menu option.");
        break;
}
```

This differs from switching on an integer:

```csharp
case 1:
```

The remaining menu options contain explicit placeholders so the user receives
feedback rather than encountering a silent branch.

---

## Menu Option 1 — List All Pet Information

A row is considered occupied when its pet-ID field differs from the empty
record marker:

```csharp
private const string EmptyPetId = "ID #: ";
```

Check:

```csharp
private static bool HasPetData(
    string[,] animals,
    int row)
{
    return animals[row, PetIdColumn] != EmptyPetId;
}
```

The list operation:

1. iterates through every pet row;
2. skips unused rows with `continue`;
3. iterates through all six columns of each occupied row;
4. writes every characteristic on a separate line;
5. adds spacing between pet records.

Expected sample structure:

```text
ID #: d1
Species: dog
Age: 2
Nickname: lola
Physical description: ...
Personality: ...

ID #: d2
Species: dog
Age: 9
Nickname: loki
Physical description: ...
Personality: ...
```

---

## Menu Option 2 — Add New Pets

Before accepting new data, the application counts occupied rows:

```csharp
int petCount = CountPets(animals);
```

The value of `petCount` has two related meanings before a new record is stored:

```text
Number of currently stored pets
Zero-based index of the next empty row
```

Example:

```text
Occupied rows: 0, 1, 2, 3
Stored pets:   4
petCount:      4
Next row:      animals[4, ...]
```

The entry loop continues while both conditions are true:

```csharp
while (
    anotherPet == "y" &&
    petCount < animals.GetLength(0))
{
    // Read, validate, and store one pet.
}
```

The loop stops when:

```text
The user enters n
or
The array reaches its eight-pet capacity
```

---

## Species Validation

Species is required and accepts only:

```text
dog
cat
```

Validation loop:

```csharp
do
{
    animalSpecies = (Console.ReadLine() ?? string.Empty)
        .Trim()
        .ToLowerInvariant();

    validEntry =
        animalSpecies == "dog" ||
        animalSpecies == "cat";
}
while (!validEntry);
```

Invalid input produces a clear retry message.

Normalization ensures that inputs such as these are accepted:

```text
Dog
DOG
 cat
```

---

## Automatic Pet-ID Generation

The ID is built from:

```text
First letter of species
+
One-based pet number
```

Implementation:

```csharp
string animalId =
    animalSpecies[..1] +
    (petCount + 1).ToString();
```

Examples:

```text
Fifth stored dog → d5
Sixth stored cat → c6
```

`petCount + 1` converts the zero-based array position into a human-readable
one-based pet number.

---

## Age Validation

The application accepts:

```text
?
or
a non-negative whole number
```

Validation:

```csharp
validEntry =
    animalAge == "?" ||
    (
        int.TryParse(animalAge, out int petAge) &&
        petAge >= 0
    );
```

Examples:

```text
?  → accepted as unknown
0  → accepted
3  → accepted
-1 → rejected
abc → rejected
```

`int.TryParse()` handles invalid text without throwing a conversion exception.

---

## Optional Pet Information

The following fields may be unknown when a pet first arrives:

```text
Physical description
Personality description
Nickname
```

Blank input is stored as:

```text
tbd
```

Implementation:

```csharp
return value.Length == 0
    ? "tbd"
    : value;
```

`tbd` means:

```text
to be determined
```

This guarantees that every newly stored pet has a complete six-column record,
even when the rescue team has not yet collected all information.

---

## Saving a Pet Record

The new record is written before `petCount` is incremented:

```csharp
SavePet(
    animals,
    petCount,
    animalId,
    animalSpecies,
    animalAge,
    animalNickname,
    animalPhysicalDescription,
    animalPersonalityDescription);

petCount++;
```

This order is essential:

```text
petCount before saving → next empty zero-based row
Save record
Increment petCount     → updated number of stored pets
```

Stored format:

```csharp
animals[row, PetIdColumn] =
    $"ID #: {animalId}";

animals[row, SpeciesColumn] =
    $"Species: {animalSpecies}";

animals[row, AgeColumn] =
    $"Age: {animalAge}";
```

The remaining columns store nickname, physical description, and personality.

---

## Capacity Management

When the application is full:

```csharp
if (petCount >= animals.GetLength(0))
{
    Console.WriteLine(
        "We have reached our limit on the number of pets " +
        "that we can manage.");
}
```

The maximum capacity is:

```text
8 pets
```

The entry loop cannot write beyond the last valid row, preventing an
`IndexOutOfRangeException`.

---

## Source-Code Architecture

The original guided-project notes contain the complete learning sequence but
also include intermediate code, duplicated `case` labels, repeated
declarations, unused `using` directives, and an accidental character after a
statement.

The final executable source is organized into focused methods:

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
ShowChallengeProjectPlaceholder(...)
ShowUnderConstructionPlaceholder(...)
PauseBeforeReturningToMenu()
```

This organization provides:

- narrow variable scope;
- descriptive method and variable names;
- no duplicate top-level declarations;
- named column indexes instead of unexplained numeric literals;
- isolated input-validation routines;
- reusable pause and placeholder behavior;
- XML documentation comments;
- detailed inline explanations;
- easier testing and maintenance.

---

## Cleanup Applied to the Learning Notes

The final source resolves or removes:

```text
Unused using directives
Repeated case "3" labels
Repeated petCount increment statements
The accidental character after petCount + 1
Intermediate incomplete loops
Duplicate variable declarations
Commented starter-code fragments
Unreachable or structurally invalid examples
Unexplained array-column numbers
Null-unsafe console input
```

The educational reasoning remains documented in comments without leaving
non-compiling intermediate code active.

---

## Runtime and Build Verification

Run the guided project:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\guided-projects\contoso-pets\contoso-pets.csproj"
```

Build the guided project:

```powershell
dotnet build `
  ".\curriculum\add-logic-to-csharp-console-applications\guided-projects\contoso-pets\contoso-pets.csproj"
```

Build the complete solution:

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified results:

```text
Microsoft Learn completion: Verified
Module assessment: Passed
Achievement: Earned
Project registration: Verified
Solution project count: 19
Application launch: Succeeded
Menu display: Verified
Exit handling: Verified
Project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 8.1 seconds
Verification date: July 29, 2026
```

The terminal verification confirms that the final application starts, displays
the complete Contoso PetFriends menu, accepts `exit`, and terminates normally.
The project and complete nineteen-project solution compile successfully.

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| guided project | `/ˈɡaɪ.dɪd ˈprɒdʒ.ekt/` | “gai-địt pro-jẹct” | dự án thực hành có hướng dẫn |
| conditional branching | `/kənˈdɪʃ.ən.əl ˈbrɑːn.tʃɪŋ/` | “cần-đi-shờ-nồ bran-ching” | phân nhánh có điều kiện |
| looping structure | `/ˈluː.pɪŋ ˈstrʌk.tʃər/` | “lu-ping strắc-chờ” | cấu trúc lặp |
| multidimensional array | `/ˌmʌl.ti.daɪˈmen.ʃən.əl əˈreɪ/` | “mân-ti đai-men-shờ-nồ ờ-rây” | mảng có từ hai chiều trở lên |
| rectangular array | `/rekˈtæŋ.ɡjə.lər əˈreɪ/` | “rẹc-tang-giu-lờ ờ-rây” | mảng nhiều chiều dạng chữ nhật |
| row | `/rəʊ/` | “râu” | hàng |
| column | `/ˈkɒl.əm/` | “co-lầm” | cột |
| zero-based indexing | `/ˈzɪə.rəʊ beɪst ˈɪn.dek.sɪŋ/` | “zi-râu bâyst in-đéc-sing” | đánh chỉ số bắt đầu từ `0` |
| nested loop | `/ˈnes.tɪd luːp/` | “nes-tịt lúp” | vòng lặp nằm trong vòng lặp khác |
| capacity | `/kəˈpæs.ə.ti/` | “cờ-pá-xờ-ti” | sức chứa tối đa |
| persisted data | `/pəˈsɪs.tɪd ˈdeɪ.tə/` | “pờ-sít-tịt đây-tờ” | dữ liệu được lưu qua nhiều phiên |
| validation | `/ˌvæl.ɪˈdeɪ.ʃən/` | “va-li-đây-shần” | kiểm tra dữ liệu hợp lệ |
| placeholder | `/ˈpleɪsˌhəʊl.dər/` | “plâys-hâu-lđờ” | nội dung tạm giữ chỗ |
| to be determined | `/tə biː dɪˈtɜː.mɪnd/` | “tờ bi đi-tơ-mìnhđ” | sẽ được xác định sau |

---

## Completion Record

```text
Curriculum item: Guided Project - Develop Conditional Branching and Looping Structures in C#
Application: Contoso Pets
Section: Add Logic to C# Console Applications
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Final organized source: Completed
Project registration: Verified
Solution project count: 19
Local run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 8.1 seconds
Completion date: July 29, 2026
```

---

---

# Challenge Project — Develop Branching and Looping Structures in C#

## Completion Status

```text
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Microsoft Learn trophy: Verified
Microsoft Learn certificate: Earned
freeCodeCamp section completion: Verified
Final organized Program.cs: Completed
Professional code comments: Completed
Project added to solution: Verified
Solution project count: 20
Local project run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 2.6 seconds
Completion date: July 30, 2026
```

This challenge project completes Section 3 by extending the **Contoso
PetFriends** console application. The starter application already provided the
main menu, sample records, record display, and new-pet entry logic. The challenge
required implementation of the two data-completion workflows represented by
menu options `3` and `4`.

The completed application now ensures that every occupied row in the
`ourAnimals` array contains valid values for:

```text
Age
Physical description
Nickname
Personality description
```

The final `Program.cs` is organized as a complete application rather than as two
isolated `case` patches. The source includes named constants, focused methods,
shared validation helpers, null-safe console input, professional comments, and
clear separation between menu routing, business rules, array access, and user
interaction.

---

## Project Location

```text
curriculum/add-logic-to-csharp-console-applications/
└── challenge-projects/
    └── contoso-pets-challenge/
        ├── Program.cs
        └── contoso-pets-challenge.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

The completed solution contains:

```text
20 projects
```

Target framework:

```xml
<TargetFramework>net10.0</TargetFramework>
```

---

## Challenge Scope

The completed application contains all eight menu entries from the starter
project:

```text
1. List all current pet information
2. Add a new animal friend
3. Ensure ages and physical descriptions are complete
4. Ensure nicknames and personality descriptions are complete
5. Edit an animal's age
6. Edit an animal's personality description
7. Display cats with a specified characteristic
8. Display dogs with a specified characteristic
```

Implementation status:

| Menu option | Feature | Status in this project |
| :---: | --- | --- |
| `1` | List existing pet records | Implemented |
| `2` | Add new pet records | Implemented |
| `3` | Complete age and physical description | Implemented by this challenge |
| `4` | Complete nickname and personality description | Implemented by this challenge |
| `5`–`8` | Later Contoso Pets extensions | Explicitly retained as under construction |

Menu options `5` through `8` remain visible because they are part of the starter
application's interface, but they are outside the required scope of this
challenge. Their placeholders provide clear feedback rather than silently doing
nothing.

---

## Final Application Architecture

The final source is organized into focused methods:

```text
Main()
├── InitializeAnimalRecords()
├── RunMainMenu()
│   ├── DisplayMainMenu()
│   ├── DisplayAllAnimals()
│   ├── AddNewAnimals()
│   ├── EnsureAgesAndPhysicalDescriptionsAreComplete()
│   ├── EnsureNicknamesAndPersonalitiesAreComplete()
│   └── ShowUnderConstruction(...)
├── StoreAnimalRecord(...)
├── PromptForSpecies()
├── PromptForAgeOrUnknown()
├── PromptForOptionalText(...)
├── PromptForRequiredText(...)
├── PromptForYesOrNo(...)
├── ExtractValue(...)
├── IsIncompleteText(...)
├── IsOccupiedRow(...)
├── CountOccupiedRows()
├── FindFirstEmptyRow()
└── Pause()
```

This structure replaces one large top-level block with methods whose names
express their responsibilities. The result is easier to read, test, debug, and
extend.

---

## Application Data Model

The application uses one fixed-size rectangular array:

```csharp
private static readonly string[,] OurAnimals =
    new string[MaxPets, FieldCount];
```

Configuration:

```text
Maximum pet records: 8
Fields per record:    6
Total array cells:    48
```

Named constants document every column:

| Column | Constant | Stored data |
| ---: | --- | --- |
| `0` | `PetIdColumn` | Pet ID |
| `1` | `SpeciesColumn` | Species |
| `2` | `AgeColumn` | Age |
| `3` | `NicknameColumn` | Nickname |
| `4` | `PhysicalDescriptionColumn` | Physical description |
| `5` | `PersonalityDescriptionColumn` | Personality description |

Instead of relying on unexplained indexes:

```csharp
OurAnimals[i, 4]
```

the final source uses:

```csharp
OurAnimals[i, PhysicalDescriptionColumn]
```

This reduces ambiguity and lowers the risk of writing data to the wrong column.

---

## Stored Labels and Data Extraction

Each array field stores both a display label and its value:

```text
ID #: c4
Age: ?
Nickname: 
Physical description: 
Personality: 
```

Validation must operate on the actual value rather than the complete display
string. The shared helper removes the expected label:

```csharp
private static string ExtractValue(
    string storedField,
    string label)
{
    if (storedField.StartsWith(
        label,
        StringComparison.Ordinal))
    {
        return storedField[label.Length..].Trim();
    }

    return storedField.Trim();
}
```

Example:

```text
Stored field:  "Age: 2"
Label:         "Age: "
Extracted data: "2"
```

The range expression:

```csharp
storedField[label.Length..]
```

returns the substring beginning immediately after the label.

`StringComparison.Ordinal` is appropriate because the labels are fixed internal
program tokens, not natural-language text requiring culture-sensitive rules.

---

## Empty-Row Detection

Unused array rows are initialized with empty values such as:

```text
ID #: 
```

The completed application determines whether a row is occupied by extracting
the data portion of the pet ID:

```csharp
private static bool IsOccupiedRow(int rowIndex)
{
    string petId = ExtractValue(
        OurAnimals[rowIndex, PetIdColumn],
        PetIdLabel);

    return !string.IsNullOrWhiteSpace(petId);
}
```

Each validation workflow skips unused rows:

```csharp
if (!IsOccupiedRow(i))
{
    continue;
}
```

`continue` skips the remainder of the current iteration while preserving the
outer `for` loop, allowing later records to be inspected.

---

## Menu Option 3 — Complete Age and Physical Description

### Specification implemented

For every occupied pet record, the feature must:

```text
Skip unused rows
Display the pet ID when data is missing
Require an age that can be converted to a numeric type
Require a physical description that is not null or empty
Store the validated values
Report when all records are complete
Pause before returning to the main menu
```

### Age validation

The current age is extracted from the stored field:

```csharp
string currentAge = ExtractValue(
    OurAnimals[i, AgeColumn],
    AgeLabel);
```

The application uses `int.TryParse()`:

```csharp
if (!int.TryParse(currentAge, out _))
{
    // Prompt until a valid integer is entered.
}
```

Why `TryParse()` is appropriate:

```text
Valid numeric input   → returns true
Invalid text input    → returns false
Conversion exception  → not thrown
```

Representative results:

| Input | `TryParse()` result | Accepted |
| --- | :---: | :---: |
| `1` | `true` | Yes |
| `12` | `true` | Yes |
| `one` | `false` | No |
| `?` | `false` | No |
| empty input | `false` | No |

Once incomplete data has been identified, a `do-while` loop ensures that the
prompt executes at least once and repeats until validation succeeds:

```csharp
do
{
    Console.WriteLine($"Enter an age for {petId}:");
    enteredAge =
        (Console.ReadLine() ?? string.Empty).Trim();

    validAge = int.TryParse(enteredAge, out _);
}
while (!validAge);
```

The valid value is stored in the same display format used throughout the
application:

```csharp
OurAnimals[i, AgeColumn] = AgeLabel + enteredAge;
```

### Physical-description validation

The application rejects:

```text
null
an empty string
whitespace-only input
"tbd"
```

The starter project uses `tbd` for information that has not yet been collected.
The final challenge treats it as incomplete so the record receives real data:

```csharp
private static bool IsIncompleteText(string value)
{
    return
        string.IsNullOrWhiteSpace(value) ||
        value.Equals(
            ToBeDetermined,
            StringComparison.OrdinalIgnoreCase);
}
```

A shared required-text prompt guarantees that the returned string contains at
least one non-whitespace character.

### Completion message

After all occupied rows pass both checks:

```text
Age and physical description fields are complete for all of our friends.
Press the Enter key to continue.
```

The pause prevents the confirmation from disappearing immediately when the main
menu is redrawn.

---

## Menu Option 4 — Complete Nickname and Personality Description

### Specification implemented

For every occupied pet record, the feature must:

```text
Skip unused rows
Display the pet ID when data is missing
Require a non-null, non-empty nickname
Require a non-null, non-empty personality description
Store the validated values
Report when all records are complete
Pause before returning to the main menu
```

### Nickname validation

The application extracts the stored data:

```csharp
string currentNickname = ExtractValue(
    OurAnimals[i, NicknameColumn],
    NicknameLabel);
```

If the result is incomplete, it calls:

```csharp
string enteredNickname = PromptForRequiredText(
    $"Enter a nickname for {petId}:");
```

The validated value is stored with its display label:

```csharp
OurAnimals[i, NicknameColumn] =
    NicknameLabel + enteredNickname;
```

### Personality-description validation

The same reusable validation rule is applied to the personality field:

```csharp
string enteredPersonalityDescription =
    PromptForRequiredText(
        $"Enter a personality description for {petId} " +
        "(likes or dislikes, tricks, energy level):");
```

The completed value is normalized and saved:

```csharp
OurAnimals[i, PersonalityDescriptionColumn] =
    PersonalityDescriptionLabel +
    enteredPersonalityDescription.ToLowerInvariant();
```

### Completion message

```text
Nickname and personality description fields are complete for all of our friends.
Press the Enter key to continue.
```

Selecting menu option `4` again after completion does not ask for the same data
because every occupied record already passes validation.

---

## Shared Required-Text Validation

The final application avoids duplicating the same null and empty-input checks:

```csharp
private static string PromptForRequiredText(string prompt)
{
    string value;

    do
    {
        Console.WriteLine();
        Console.WriteLine(prompt);

        value = (Console.ReadLine() ?? string.Empty).Trim();

        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine(
                "The value cannot be empty. " +
                "Please enter valid text.");
        }
    }
    while (string.IsNullOrWhiteSpace(value));

    return value;
}
```

This method establishes a clear contract:

```text
Input:  any console result, including null or whitespace
Output: a trimmed string containing at least one real character
```

Centralizing this rule makes the application more consistent and reduces future
maintenance work.

---

## Null-Safe Console Input

`Console.ReadLine()` returns `string?`, so a null result must be handled.

The completed source repeatedly uses:

```csharp
(Console.ReadLine() ?? string.Empty).Trim()
```

Processing sequence:

```text
Read console input
    ↓
Replace null with string.Empty
    ↓
Remove leading and trailing whitespace
    ↓
Validate the normalized value
```

Operators involved:

| Operator or method | Purpose |
| --- | --- |
| `??` | Provide a fallback when the left value is `null` |
| `Trim()` | Remove leading and trailing whitespace |
| `IsNullOrWhiteSpace()` | Reject null, empty, and whitespace-only strings |

---

## Branching and Looping Decisions

The challenge demonstrates how control-flow structures are selected according
to the problem rather than used interchangeably.

| Construct | Role in the application |
| --- | --- |
| `switch` | Route the user's menu selection and initialize sample records |
| `if` | Perform validation decisions and defensive checks |
| `for` | Inspect every fixed array row or field |
| `while` | Continue adding pets while the user agrees and capacity remains |
| `do-while` | Prompt at least once and repeat until input is valid |
| `continue` | Skip unused array rows or skip the remainder of one iteration |
| `break` | End a switch section or stop a loop when no valid row remains |
| `return` | Leave a method early when no more records can be added |

Overall validation flow:

```text
Read menu selection
        ↓
Route through switch
        ↓
Iterate through fixed array rows
        ↓
Skip unused rows
        ↓
Extract the stored value
        ↓
Evaluate completeness
    ├── complete   → continue to the next field or row
    └── incomplete
            ↓
         Prompt in a validation loop
            ↓
         Store the normalized value
        ↓
Report completion and pause
```

---

## Variable Scope and Maintainability

The final source scopes values at the narrowest practical level:

```text
Application-wide configuration → private constants
Runtime data store              → private static readonly array
One menu operation              → local variables inside its method
One iteration                   → loop-local variables
Reusable input                  → method parameters and return values
```

Examples of application-wide constants:

```csharp
private const int MaxPets = 8;
private const int PetIdColumn = 0;
private const string AgeLabel = "Age: ";
private const string ToBeDetermined = "tbd";
```

Benefits:

- one authoritative definition for each program rule;
- no repeated magic numbers or label strings;
- reduced accidental variable reuse;
- clearer method contracts;
- easier future refactoring.

---

## Professional Commenting Strategy

The final `Program.cs` uses comments to explain:

```text
Why a control-flow construct was selected
What each array column represents
Why an unused row is skipped
Why TryParse is used instead of Parse
Why tbd is considered incomplete
How null console input is normalized
What a helper method guarantees to its caller
Which menu options are outside the challenge scope
```

Comments do not merely repeat syntax. They document intent, invariants,
validation contracts, and design decisions that are not obvious from an
individual statement.

---

## Runtime Verification

Run the challenge project:

```powershell
dotnet run --project `
  ".\curriculum\add-logic-to-csharp-console-applications\challenge-projects\contoso-pets-challenge\contoso-pets-challenge.csproj"
```

### Menu option 3 verification

Suggested input sequence:

```text
3
one
1
<press Enter without entering a physical description>
small white Siamese cat weighing about 8 pounds. litter box trained.
```

Expected behavior:

```text
The nonnumeric age is rejected.
The prompt repeats.
The numeric age is accepted.
The empty physical description is rejected.
The prompt repeats.
The valid physical description is stored.
A completion message is displayed.
```

### Menu option 4 verification

Suggested input sequence:

```text
4
<press Enter without entering a nickname>
snowflake
<press Enter without entering a personality description>
loves to curl up in a warm spot
```

Expected behavior:

```text
The empty nickname is rejected.
The prompt repeats.
The valid nickname is stored.
The empty personality description is rejected.
The prompt repeats.
The valid personality description is stored.
A completion message is displayed.
```

Afterward, menu option `1` displays the completed `c4` record. Running menu
options `3` or `4` again does not request information that has already passed
validation.

---

## Build Verification

Build the challenge project:

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
Challenge project: contoso-pets-challenge
Target framework: net10.0
Project registration: Verified
Solution project count: 20
Project build: Succeeded in 0.9 seconds
Full solution build: Succeeded in 2.6 seconds
Build warnings: 0
Build errors: 0
Verification date: July 30, 2026
```

---

## Section Trophy and Achievement Evidence

Official completion evidence is documented separately under:

```text
trophy/
├── README.md
└── assets/
    ├── 1.PNG
    └── 2.PNG
```

The two evidence files record:

- the Microsoft Learn completion certificate for **Add logic to C# console
  applications (Get started with C#, Part 3)**;
- freeCodeCamp verification of the Microsoft Learn Trophy for **Add Logic to
  C# Console Applications**.

Open the dedicated evidence record:

- [Section 3 Trophy documentation](./trophy/README.md)
- [Microsoft Learn completion certificate](./trophy/assets/1.PNG)
- [Verified freeCodeCamp Trophy evidence](./trophy/assets/2.PNG)

The local build evidence remains recorded in the challenge-project
**Build Verification** section above rather than being stored as a third Trophy
image.

---

## Key Terms

| Term | IPA | Approximate reading | Meaning |
| --- | --- | --- | --- |
| challenge project | `/ˈtʃæl.ɪndʒ ˈprɒdʒ.ekt/` | “cha-lừnh pro-jẹct” | dự án thử thách yêu cầu tự hoàn thiện theo đặc tả |
| specification | `/ˌspes.ɪ.fɪˈkeɪ.ʃən/` | “spe-xi-fi-cây-shần” | đặc tả yêu cầu của chương trình |
| branching | `/ˈbrɑːn.tʃɪŋ/` | “bran-ching” | phân nhánh luồng thực thi |
| looping | `/ˈluː.pɪŋ/` | “lu-ping” | lặp lại một khối mã |
| validation | `/ˌvæl.ɪˈdeɪ.ʃən/` | “va-li-đây-shần” | kiểm tra dữ liệu hợp lệ |
| invariant | `/ɪnˈveə.ri.ənt/` | “in-ve-ri-ần-t” | điều kiện luôn phải đúng trong một phạm vi xử lý |
| helper method | `/ˈhel.pər ˈmeθ.əd/` | “hel-pờ me-thợt” | phương thức hỗ trợ dùng chung |
| null-coalescing operator | `/nʌl ˌkəʊ.əˈles.ɪŋ ˈɒp.ər.eɪ.tər/` | “nâl câu-ờ-le-xing op-pờ-rây-tờ” | toán tử `??` cung cấp giá trị thay thế cho `null` |
| range operator | `/reɪndʒ ˈɒp.ər.eɪ.tər/` | “râyn-ch op-pờ-rây-tờ” | toán tử `..` chọn một phạm vi phần tử |
| ordinal comparison | `/ˈɔː.dɪ.nəl kəmˈpær.ɪ.sən/` | “o-đi-nồ cờm-pe-rờ-sần” | so sánh theo giá trị ký tự chính xác |
| whitespace | `/ˈwaɪt.speɪs/` | “oai-t-spâys” | ký tự khoảng trắng như dấu cách hoặc tab |
| defensive guard | `/dɪˈfen.sɪv ɡɑːd/` | “đi-fen-xịv ga-đ” | kiểm tra phòng vệ trước trạng thái không mong đợi |
| code maintainability | `/kəʊd ˌmeɪn.teɪ.nəˈbɪl.ə.ti/` | “câuđ mâyn-tây-nờ-bi-lờ-ti” | khả năng bảo trì và mở rộng mã nguồn |

---

## Completion Record

```text
Curriculum item: Challenge Project - Develop Branching and Looping Structures in C#
Application: Contoso PetFriends
Section: Add Logic to C# Console Applications
Status: Completed
Microsoft Learn units: Completed
Module assessment: Passed
Achievement: Earned
Microsoft Learn trophy: Verified
Microsoft Learn certificate: Earned
freeCodeCamp section completion: Verified
Final organized source: Completed
Professional comments: Completed
Project registration: Verified
Solution project count: 20
Local run: Verified
Project build: Verified
Project build time: 0.9 seconds
Full solution build: Verified
Full solution build time: 2.6 seconds
Completion date: July 30, 2026
```

---

# Section 3 Completion

Section 3 is now complete.

```text
Section: Add Logic to C# Console Applications
Final status: Completed
Curriculum progress: 7 / 7
Instructional modules: 5 / 5 completed
Guided projects: 1 / 1 completed
Challenge projects: 1 / 1 completed
Registered solution projects: 20
Microsoft Learn trophy: Verified
Microsoft Learn certificate: Earned
freeCodeCamp completion: Verified
Latest project build: Passing
Full solution build: Passing
Completion date: July 30, 2026
```

The completed section demonstrates an integrated understanding of:

```text
Boolean expressions
Conditional operators
if / else branching
switch-case branching
Variable scope and code blocks
for iteration
while iteration
do-while iteration
continue and break
Console-input validation
Null-safe string handling
Two-dimensional arrays
Method extraction
Maintainable program structure
```

Repository closeout sequence:

```text
Review git status
Run the challenge project
Build the challenge project
Build the full solution
Update the root repository README
Commit the completed Section 3 work
Push the feature branch
Open and merge the pull request
Synchronize local main
Proceed to the next curriculum section
```
---

## Navigation

- [Repository overview](../../README.md)
- [Section 3 Trophy documentation](./trophy/README.md)
- [Challenge project source](./challenge-projects/contoso-pets-challenge/)
- [Previous section — Create and Run Simple C# Console Applications](../create-and-run-simple-csharp-console-applications/README.md)
- [Next section — Work with Variable Data in C# Console Applications](../work-with-variable-data-in-csharp-console-applications/README.md)

