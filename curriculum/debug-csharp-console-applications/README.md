# Debug C# Console Applications

> Foundational C# with Microsoft Certification
> Get Started with C#, Part 6

## Section Status

**Status:** In Progress
**Modules completed:** 2 / 6
**Current solution project count:** 34
**Target framework:** .NET 10.0
**Primary development environment:** Visual Studio
**Section started:** 2026-08-12

This section focuses on identifying runtime issues, using debugger tools to inspect application execution, and implementing exception handling in C# console applications.

The official Microsoft Learn learning path introduces debugging with Visual Studio Code and the C# debugger tools, then progresses into exception handling, creating and throwing exceptions, and practical debugging projects.

---

## Learning Path Progress

| # | Module | Status |
|---|---|---|
| 1 | Review the Principles of Code Debugging and Exception Handling | ✅ Completed |
| 2 | Implement the Visual Studio Code Debugging Tools for C# | ✅ Completed |
| 3 | Implement Exception Handling in C# Console Applications | ⏳ Not started |
| 4 | Create and Throw Exceptions in C# Console Applications | ⏳ Not started |
| 5 | Guided Project - Debug and Handle Exceptions in a C# Console Application Using Visual Studio Code | ⏳ Not started |
| 6 | Challenge Project - Debug a C# Console Application Using Visual Studio Code | ⏳ Not started |

---

# Module 1 — Review the Principles of Code Debugging and Exception Handling

## Completion

**Status:** ✅ Completed
**Completed:** 2026-08-12
**Units:** 6 / 6
**Assessment:** Passed
**Microsoft Learn Achievement:** Earned
**XP:** 1000

### Project

```text
modules/review-code-debugging-exception-handling/
├── Program.cs
└── review-code-debugging-exception-handling.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

After adding this module, the solution increased from:

```text
32 projects
```

to:

```text
33 projects
```

---

## Module Learning Objectives

This module reviews three related responsibilities of a software developer:

1. Software testing.
2. Code debugging.
3. Exception handling.

The module also introduces:

- the code debugging process;
- the purpose and benefits of debugger tools;
- runtime application state;
- exceptions in C#;
- thrown and caught exceptions;
- the developer's responsibility for managing runtime errors.

---

# 1. Testing, Debugging, and Exception Handling

Although these concepts are related, they solve different problems.

```text
TESTING
   ↓
Does the program behave as expected?

DEBUGGING
   ↓
Why is the program behaving incorrectly?

EXCEPTION HANDLING
   ↓
What should the program do when a runtime error occurs?
```

## Testing

Software testing verifies whether an application behaves as expected.

Testing can be divided into broad categories such as:

### Functional testing

- Unit testing
- Integration testing
- System testing
- Acceptance testing

### Nonfunctional testing

- Security testing
- Performance testing
- Usability testing
- Compatibility testing

Software testing is a large professional discipline, but developers are still expected to perform some level of testing before handing off their work.

Developers are commonly involved in **unit testing**, where individual pieces of application logic are verified independently.

Example from the module project:

```csharp
int expectedResult = 15;
int actualResult = AddNumbers(10, 5);

if (actualResult == expectedResult)
{
    Console.WriteLine("Test result: PASS");
}
else
{
    Console.WriteLine("Test result: FAIL");
}
```

This is a simple manual verification rather than a formal automated unit test.

---

# 2. Code Debugging

## Definition

Debugging is the process of:

1. isolating an issue;
2. identifying its cause;
3. determining one or more ways to fix it.

Debugging is normally associated with runtime problems that aren't immediately obvious.

Simple compiler or syntax problems, such as a missing semicolon, aren't normally what developers mean when they refer to debugging.

---

## Zero-Based Array Example

The module demonstrates a common runtime problem using an array:

```csharp
string[] students =
{
    "Sophia",
    "Nicolas",
    "Zahirah",
    "Jeong"
};

int studentCount = students.Length;
```

The array contains four elements:

```text
Value:   Sophia   Nicolas   Zahirah   Jeong
Index:      0        1         2         3
```

Therefore:

```csharp
studentCount
```

contains:

```text
4
```

but:

```csharp
students[4]
```

does not exist.

The following code is incorrect:

```csharp
Console.WriteLine(students[studentCount]);
```

It attempts to access index `4`, producing an:

```text
IndexOutOfRangeException
```

The correct final index is:

```csharp
studentCount - 1
```

Therefore:

```csharp
Console.WriteLine(students[studentCount - 1]);
```

accesses:

```text
students[3]
```

which contains:

```text
Jeong
```

This example demonstrates an important distinction:

```text
Length = number of elements

Index = position of an element
```

For a zero-based collection:

```text
last valid index = Length - 1
```

---

# 3. The Debugger Approach

A debugger is a software tool that allows a developer to observe and control program execution.

Instead of repeatedly guessing where a problem exists, a debugger allows the developer to inspect what the application is actually doing at runtime.

Two fundamental debugger capabilities are:

## Execution Control

A debugger can:

- pause execution;
- continue execution;
- execute code one statement at a time;
- observe the execution path through the program.

Conceptually:

```text
START
  ↓
execute
  ↓
BREAKPOINT
  ↓
pause
  ↓
inspect
  ↓
step
  ↓
inspect again
  ↓
continue
```

---

## Program State Observation

A debugger can also inspect the current state of the application.

For example:

```csharp
decimal productPrice = 120.00m;
int quantity = 3;

decimal subtotal = productPrice * quantity;

decimal taxRate = 0.10m;
decimal tax = subtotal * taxRate;

decimal total = subtotal + tax;
```

During debugging, the developer can inspect values such as:

```text
productPrice = 120.00
quantity     = 3
subtotal     = 360.00
taxRate      = 0.10
tax          = 36.00
total        = 396.00
```

This provides direct evidence of how data changes as the application executes.

---

## Why Use a Debugger?

Without a debugger, developers may rely too heavily on approaches such as:

- repeatedly rereading source code;
- inserting temporary `Console.WriteLine()` statements;
- repeatedly changing input data;
- guessing which statement contains the problem.

Those techniques can occasionally help, but a debugger provides a much more systematic approach.

A debugger allows the developer to examine:

```text
CONTROL FLOW
     +
PROGRAM STATE
```

together.

This makes it possible to determine not only **where** the application is executing, but also **what data exists at that point in time**.

---

# 4. Exceptions

## What Is an Exception?

An exception represents an error that occurs while an application is running.

The distinction between build-time errors and runtime exceptions is important.

```text
BUILD ERROR
    ↓
Detected while compiling/building
    ↓
Application cannot successfully start
```

versus:

```text
RUNTIME EXCEPTION
    ↓
Application built successfully
    ↓
Application begins running
    ↓
An error occurs during execution
```

Exceptions in C# are represented by objects whose types derive from the `Exception` class.

An exception object contains information about the runtime problem that occurred.

Examples of exception information include:

- exception type;
- error message;
- details that help identify the failure.

---

# 5. Throwing and Catching Exceptions

Two important terms introduced in this module are:

## Throw

When code or the .NET runtime detects an error, an exception can be:

```text
THROWN
```

The exception carries information describing the problem.

## Catch

Application code can be written to:

```text
CATCH
```

the exception.

The application can then respond to the problem in a controlled way.

Conceptually:

```text
Normal execution
      ↓
An error occurs
      ↓
Exception is thrown
      ↓
Is the exception handled?
      │
   ┌──┴──┐
  Yes    No
   ↓      ↓
catch   Unhandled
   ↓    exception
respond  ↓
   ↓    application may terminate
continue
```

---

# 6. Exception Handling with `try` and `catch`

C# provides the `try` and `catch` statements for handling exceptions.

Example from the module project:

```csharp
string userInput = "not-a-number";

try
{
    int parsedNumber = int.Parse(userInput);

    Console.WriteLine($"Parsed number: {parsedNumber}");
}
catch (FormatException exception)
{
    Console.WriteLine($"Input value: \"{userInput}\"");
    Console.WriteLine("The value could not be converted to an integer.");

    Console.WriteLine($"Exception type: {exception.GetType().Name}");
    Console.WriteLine($"Message: {exception.Message}");
}
```

The execution flow is:

```text
try
 ↓
int.Parse(userInput)
 ↓
"not-a-number" cannot become int
 ↓
FormatException is thrown
 ↓
catch (FormatException exception)
 ↓
inspect exception
 ↓
controlled response
 ↓
program continues
```

The important point is that exception handling doesn't mean pretending that an error never happened.

Instead, exception handling gives the application an intentional and controlled way to respond to an abnormal runtime condition.

---

# 7. Bug vs. Exception

A bug and an exception aren't the same concept.

## Bug

A bug is a defect in program behavior or logic.

A program can contain a bug without generating an exception.

For example:

```csharp
int length = 10;
int width = 5;

int area = length + width;
```

The application runs successfully, but the logic is incorrect.

The intended calculation is:

```csharp
int area = length * width;
```

---

## Exception

An exception represents a runtime error condition.

For example:

```csharp
int[] numbers = { 10, 20, 30 };

Console.WriteLine(numbers[10]);
```

The application tries to access an array element that doesn't exist and generates an exception.

Therefore:

```text
BUG
│
├── may produce an exception
│
└── may produce incorrect behavior without an exception


EXCEPTION
│
└── runtime error represented by an exception object
```

---

# 8. Core Mental Model

The main mental model from this module is:

```text
                    CODE VERIFICATION
                           │
           ┌───────────────┼───────────────┐
           ↓               ↓               ↓
        TESTING         DEBUGGING       EXCEPTION
                                         HANDLING
           │               │               │
           ↓               ↓               ↓
     Is behavior       Why is the      How should the
       correct?         behavior       application react
                        incorrect?     to runtime failure?
```

Debugging then follows the application itself:

```text
INPUT
  ↓
PROCESSING
  ↓
STATE CHANGES
  ↓
OUTPUT
```

When the output or behavior is incorrect, the debugger helps trace the program through that flow and inspect where the state begins to differ from what was expected.

---

# 9. Important Terminology

## Debug

**debug**
`/ˌdiːˈbʌɡ/`

To locate and fix defects in a program.

## Debugging

**debugging**
`/ˌdiːˈbʌɡ.ɪŋ/`

The process of isolating and diagnosing software problems.

## Debugger

**debugger**
`/ˌdiːˈbʌɡ.ər/`

A software tool used to observe and control program execution.

## Breakpoint

**breakpoint**
`/ˈbreɪk.pɔɪnt/`

A deliberate point where debugger-controlled execution pauses.

## Runtime

**runtime**
`/ˈrʌn.taɪm/`

The period during which an application is executing.

## Exception

**exception**
`/ɪkˈsep.ʃən/`

An object representing an abnormal condition or error that occurs during program execution.

## Throw

**throw**
`/θrəʊ/`

To propagate an exception from code that encounters an error.

## Catch

**catch**
`/kætʃ/`

To receive and handle an exception that has been thrown.

## Exception Handling

**exception handling**
`/ɪkˈsep.ʃən ˌhæn.dəl.ɪŋ/`

The process of managing runtime exceptions in application code.

---

# 10. Runtime Verification

The module project was executed successfully after replacing the default `Hello, World!` source with the completed study implementation.

Project:

```text
modules/review-code-debugging-exception-handling/
review-code-debugging-exception-handling.csproj
```

Run command:

```powershell
dotnet run --project `
    ".\curriculum\debug-csharp-console-applications\modules\review-code-debugging-exception-handling\review-code-debugging-exception-handling.csproj"
```

Expected behavior includes:

```text
C# Debugging and Exception Handling Review

1. TESTING
Test result: PASS

2. DEBUGGING
The final name is: Jeong

3. DEBUGGER STATE
Subtotal: ...
Tax: ...
Total: ...

4. EXCEPTION HANDLING
Exception type: FormatException
The application is still running after the exception.

Review completed.
```

Exact currency formatting can depend on the current operating-system culture.

---

# 11. Build Verification

## Module Project

```powershell
dotnet build `
    ".\curriculum\debug-csharp-console-applications\modules\review-code-debugging-exception-handling\review-code-debugging-exception-handling.csproj"
```

Result:

```text
Build succeeded
```

## Full Solution

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified on:

```text
2026-08-12
```

Result:

```text
Build succeeded
```

Solution project count:

```text
33 / 33 projects
```

---

# 12. Module Assessment and Achievement

Microsoft Learn module:

**Review the Principles of Code Debugging and Exception Handling**

Assessment result:

```text
Module assessment passed
```

Microsoft Learn Achievement:

```text
Earned
```

Completion date:

```text
2026-08-12
```

---

# Key Takeaways

1. Writing code is only the first part of software development.
2. Testing checks whether software behaves as expected.
3. Debugging isolates the cause of unexpected runtime behavior.
4. A debugger allows developers to control execution and inspect application state.
5. Arrays in C# are zero-based.
6. `Length` represents the number of array elements, not the last valid index.
7. Runtime errors in C# can be represented as exceptions.
8. Exceptions can be thrown by .NET or by application code.
9. Application code can catch exceptions and respond to them.
10. `try` and `catch` provide a structured exception-handling mechanism.
11. A bug doesn't necessarily generate an exception.
12. Effective debugging reduces guessing by exposing the actual runtime state of the application.

---

# Module 2 — Implement the Visual Studio Code Debugging Tools for C#

## Completion

**Status:** ✅ Completed
**Completed:** 2026-08-13
**Units:** 12 / 12
**Assessment:** Passed
**Microsoft Learn Achievement:** Earned
**Target framework:** .NET 10.0
**Project registration in solution:** Verified
**Solution project count:** 34
**Final organized Program.cs:** Completed
**Professional source comments:** Completed
**Local project run:** Verified
**Project build:** Succeeded in 0.9 seconds
**Full solution build:** Succeeded in 2.7 seconds
**Compiler errors:** 0
**Compiler warnings:** 0
**IDE diagnostics:** No issues found

### Project

```text
modules/implement-vscode-debugging-tools/
├── Program.cs
└── implement-vscode-debugging-tools.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

After adding this module, the solution increased from:

```text
33 projects
```

to:

```text
34 projects
```

---

## Module Learning Objectives

This module moves from debugging theory to practical debugger operation.

The completed learning objectives include:

1. configuring the Visual Studio Code debugger for a C# program;
2. creating breakpoints and stepping through code to isolate issues;
3. inspecting application state at any execution step;
4. using the call stack to locate the source of an exception.

The repository implementation also preserves debugger-oriented examples that can
be reopened later for repeated breakpoint and state-inspection practice.

---

# 1. Visual Studio Code Debugger Interface

The Visual Studio Code debugging workflow is centered around the **RUN AND DEBUG**
view and the Debug toolbar.

The principal runtime inspection areas are:

```text
RUN AND DEBUG
├── VARIABLES
├── WATCH
├── CALL STACK
└── BREAKPOINTS
```

## VARIABLES

The `VARIABLES` section displays the current application state for the active
scope.

It can be used to inspect values such as:

```text
name
messageText
index
status
numerator
denominator
sum
```

The debugger can also modify some variable values while the program is paused.
This is useful when a developer wants to create a particular runtime state
without editing the source solely to reproduce that state.

## WATCH

The `WATCH` section tracks a variable or expression while execution progresses.

Example:

```text
(double)numerator / denominator > 5
```

A watch expression is especially useful when the issue being investigated is
related to a condition rather than one isolated variable.

## CALL STACK

The `CALL STACK` section displays the method-call path that led to the current
execution point.

Conceptually:

```text
top-level statements
        ↓
DemonstrateCallStack()
        ↓
StartCalculation()
        ↓
CalculateRatio()
        ↓
DivideValues()
```

This provides two important pieces of information:

```text
WHERE is execution now?
HOW did execution arrive here?
```

## BREAKPOINTS

The `BREAKPOINTS` section provides a central place to review, enable, disable,
and manage configured breakpoints.

---

# 2. Debug Toolbar and Execution Control

The debugger provides several commands for controlling application execution.

## Continue

```text
Continue
   ↓
Resume execution
   ↓
Run until another breakpoint or termination
```

## Step Over

`Step Over` executes the current statement without entering the internal
statements of a called method.

Conceptually:

```csharp
messageText = SophiaMessage();
```

With `Step Over`, the method call is treated as one operation from the current
debugging perspective.

## Step Into

`Step Into` follows the next executable statement.

If the next statement calls a method:

```csharp
messageText = SophiaMessage();
```

the debugger can enter:

```csharp
static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}
```

This allows the developer to inspect the method line by line.

## Step Out

`Step Out` completes the remainder of the current method and returns debugging
control to the caller.

```text
Caller
  ↓
Method
  ↓
Step Out
  ↓
Return to caller
```

## Restart and Stop

`Restart` terminates the current run and begins another debug session with the
current configuration.

`Stop` terminates the running debug session.

---

# 3. Standard Breakpoints

A breakpoint specifies a source location where execution should pause during a
debugging session.

A standard breakpoint is useful when the developer wants to inspect the program
every time a particular statement is reached.

Example breakpoint location:

```csharp
if (name == "Sophia")
{
    messageText = SophiaMessage();
}
```

When execution pauses, the developer can inspect:

```text
name
messageText
current execution line
current method
call stack
```

The debugger then makes it possible to follow the actual execution path rather
than infer the path from source formatting.

---

# 4. Debugging the Greeting Logic Bug

The Microsoft Learn exercise demonstrates a logic bug caused by code structure
that visually suggests one behavior while C# executes another.

The problematic structure is conceptually equivalent to:

```csharp
if (name == "Sophia")
    messageText = SophiaMessage();
else if (name == "Andrew")
    messageText = AndrewMessage();
else if (name == "AllGreetings")
    messageText = SophiaMessage();

messageText =
    messageText +
    Environment.NewLine +
    AndrewMessage();
```

The final assignment is **not** part of the final `else if` branch.

Without braces, only the immediately following statement belongs to each
conditional branch.

Therefore:

```text
AndrewMessage()
```

is appended during every loop iteration.

The organized repository implementation corrects the structure with explicit
braces:

```csharp
if (name == "Sophia")
{
    messageText = SophiaMessage();
}
else if (name == "Andrew")
{
    messageText = AndrewMessage();
}
else
{
    messageText =
        SophiaMessage() +
        Environment.NewLine +
        AndrewMessage();
}
```

The key debugging lesson is:

```text
Indentation suggests intent.
Execution flow proves behavior.
```

---

# 5. Conditional Breakpoints

A conditional breakpoint pauses only when a specified Boolean expression
evaluates to `true`.

The module demonstrates this with a simulated product-processing data set.

Repository example:

```csharp
const int productCount = 2000;

string[,] products =
    new string[productCount, 2];
```

A useful conditional breakpoint expression is:

```csharp
products[index, 1] == "new"
```

Execution behavior:

```text
Breakpoint reached
       ↓
Evaluate condition
   ┌───┴───┐
 false    true
   ↓        ↓
continue   pause
```

This is much more efficient than manually stepping through hundreds or
thousands of unrelated records.

---

# 6. Hit Count Breakpoints and Logpoints

The debugger also supports specialized breakpoint behavior.

## Hit Count Breakpoint

A hit count breakpoint pauses only after the breakpoint has been encountered a
configured number of times.

Conceptually:

```text
Hit 1 → continue
Hit 2 → continue
Hit 3 → continue
...
Configured hit count reached
        ↓
       pause
```

## Logpoint

A Logpoint writes diagnostic information without pausing execution.

Example message:

```text
index = {index}, status = {products[index, 1]}
```

A Logpoint is useful when the developer wants runtime evidence without inserting
temporary `Console.WriteLine()` statements into application code.

---

# 7. Launch Configuration

Visual Studio Code debugger configuration is commonly stored under:

```text
.vscode/
├── launch.json
└── tasks.json
```

## `launch.json`

Important launch configuration attributes include:

| Attribute | Purpose |
| --- | --- |
| `name` | Human-readable launch configuration name |
| `type` | Debugger type |
| `request` | Launch a process or attach to an existing process |
| `preLaunchTask` | Task that runs before debugging |
| `program` | DLL or executable to debug |
| `cwd` | Working directory |
| `args` | Command-line arguments |
| `console` | Console used by the application |
| `stopAtEntry` | Whether execution pauses at application entry |

Typical C# debugger type:

```json
"type": "coreclr"
```

Supported request scenarios include:

```text
launch
attach
```

## Console Configuration

A key lesson from the module is that the `DEBUG CONSOLE` does not provide
interactive `Console.ReadLine()` input.

An application that requires user input should use a launch configuration such
as:

```json
"console": "integratedTerminal"
```

or:

```json
"console": "externalTerminal"
```

This distinction matters because debugger configuration is part of the runtime
environment, not merely an editor preference.

---

# 8. Multiple Applications in One Workspace

A workspace can contain more than one launchable application.

In that situation, `launch.json` can contain a separate configuration for each
application, while `tasks.json` can contain separate build tasks.

Conceptually:

```text
Workspace
├── Project123
├── Project456
└── .vscode
    ├── launch.json
    └── tasks.json
```

The debugger can then expose multiple launch choices in the RUN AND DEBUG
interface.

Each configuration identifies the correct:

```text
name
preLaunchTask
program
working directory
```

for the selected application.

---

# 9. Monitoring Variable State

The module demonstrates how incorrect output can be traced through variable
state.

Example array:

```csharp
int[] numbers =
[
    1,
    2,
    3,
    4,
    5
];
```

A user interface might describe the data in one-based positions:

```text
Position: 1  2  3  4  5
Value:    1  2  3  4  5
```

C# accesses the same array with zero-based indexes:

```text
Index:    0  1  2  3  4
Value:    1  2  3  4  5
```

If the user enters:

```text
3
```

and the code directly treats that input as an array index, processing begins at:

```text
numbers[3] = 4
```

rather than at the third user-visible element:

```text
numbers[2] = 3
```

The corrected mapping is:

```csharp
int arrayStartIndex =
    userVisibleStartingPosition - 1;
```

For position `3`:

```text
3 → index 2
```

The corrected sum becomes:

```text
3 + 4 + 5 = 12
```

instead of:

```text
4 + 5 = 9
```

This example demonstrates why debugger state is often more useful than simply
rereading the source.

---

# 10. WATCH Expressions

The repository implementation includes a repeatable numeric example:

```csharp
double ratio =
    (double)numerator /
    denominator;
```

A useful WATCH expression is:

```csharp
(double)numerator / denominator > 5
```

The explicit cast is important when an exact ratio is intended because:

```csharp
numerator / denominator
```

performs integer division when both operands are `int`.

The debugger can therefore monitor both:

```text
individual variable state
```

and:

```text
derived conditions based on multiple variables
```

without adding temporary application logic.

---

# 11. CALL STACK and Exception Origin

The repository project includes a controlled `DivideByZeroException`
demonstration.

Method chain:

```text
DemonstrateCallStack()
        ↓
StartCalculation()
        ↓
CalculateRatio()
        ↓
DivideValues()
```

Inside the final method:

```csharp
if (denominator == 0)
{
    throw new DivideByZeroException(
        "The denominator cannot be zero.");
}
```

A breakpoint inside `DivideValues()` allows the developer to inspect the CALL
STACK and reconstruct the execution path.

The exception is then handled by the demonstration code so the repository
application can continue running:

```csharp
catch (DivideByZeroException exception)
{
    Console.WriteLine(
        $"Handled exception: {exception.GetType().Name}");
}
```

This preserves the debugging lesson while keeping the study project safe to run
normally.

---

# 12. Pass-by-Value Debugger Challenge

The final challenge demonstrates a method that receives an `int`.

Initial value:

```csharp
int originalValue = 5;
```

Method call:

```csharp
ChangeLocalCopy(
    originalValue);
```

The parameter receives a copy:

```text
originalValue = 5
        │
        │ copy value
        ↓
    value = 5
```

Inside the method:

```csharp
value = 10;
```

changes only the local parameter:

```text
Caller:
originalValue = 5

Callee:
value = 10
```

After returning:

```text
originalValue = 5
```

The corrected approach explicitly returns the new value:

```csharp
originalValue =
    ChangeValueAndReturn(
        originalValue);
```

and:

```csharp
static int ChangeValueAndReturn(
    int value)
{
    value = 10;

    return value;
}
```

The final caller state becomes:

```text
originalValue = 10
```

This challenge is especially useful with `Step Into`, `VARIABLES`, and `Step
Out` because the debugger makes the copied parameter state visible.

---

# 13. Repository Code Quality Corrections

The first organized version exposed two compiler errors:

```text
CS1739
The best overload for 'Random' does not have a parameter named 'seed'
```

The invalid constructor calls were:

```csharp
new(seed: 42)
new(seed: 123)
```

They were replaced with valid positional constructor calls:

```csharp
Random random = new(42);
Random random = new(123);
```

The fixed seeds make the educational examples reproducible across runs.

The final source also addresses Visual Studio analyzer suggestions by:

- using collection expressions for small arrays;
- ensuring the pass-by-value method parameter is visibly used before and after
  reassignment;
- keeping examples divided into focused methods;
- removing the instructional infinite loop;
- preserving intentionally problematic code inside comments instead of leaving
  the executable project in a broken state.

Final IDE result:

```text
No issues found
```

---

# 14. Runtime Verification

Run the module from the repository root:

```powershell
dotnet run --project `
    ".\curriculum\debug-csharp-console-applications\modules\implement-vscode-debugging-tools\implement-vscode-debugging-tools.csproj"
```

Verified output includes:

```text
C# Visual Studio Code Debugging Tools Review

1. DEBUGGER INTERFACE
2. BREAKPOINTS AND EXECUTION FLOW
3. CONDITIONAL BREAKPOINTS
4. VARIABLES AND PROGRAM STATE
5. WATCH EXPRESSIONS
6. CALL STACK
7. PASS-BY-VALUE DEBUGGER CHALLENGE

Debugger tools review completed.
```

The final pass-by-value output verifies:

```text
Before pass-by-value method: 5
Local parameter on entry: 5
Local parameter after set: 10
After pass-by-value method: 5
Return-method input value: 5
After corrected method: 10
```

The CALL STACK demonstration also confirms that the controlled
`DivideByZeroException` is handled and the application continues.

---

# 15. Build Verification

## Module Project

```powershell
dotnet build `
    ".\curriculum\debug-csharp-console-applications\modules\implement-vscode-debugging-tools\implement-vscode-debugging-tools.csproj"
```

Verified result:

```text
Build succeeded in 0.9 seconds
```

## Full Solution

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified on:

```text
2026-08-13
```

Verified result:

```text
Build succeeded in 2.7 seconds
```

Solution project count:

```text
34 / 34 projects
```

Final diagnostics:

```text
Compiler errors: 0
Compiler warnings: 0
Visual Studio: No issues found
```

---

# 16. Module Assessment and Achievement

Microsoft Learn module:

**Implement the Visual Studio Code Debugging Tools for C#**

Completion:

```text
12 / 12 units
```

Assessment result:

```text
Module assessment passed
```

Microsoft Learn Achievement:

```text
Earned
```

Completion date:

```text
2026-08-13
```

---

# Module 2 Key Takeaways

1. A debugger provides direct evidence of runtime control flow and application
   state.
2. Breakpoints pause execution at intentional source locations.
3. `Step Into` follows the next executable statement and can enter a method.
4. `Step Over` executes a method call without stepping through its internal
   statements.
5. `Step Out` completes the current method and returns to its caller.
6. Conditional breakpoints avoid repeatedly stopping on irrelevant data.
7. Hit count breakpoints stop after a configured number of encounters.
8. Logpoints provide diagnostic output without changing source logic or pausing
   execution.
9. `VARIABLES` exposes current state and can be used to modify values while
   debugging.
10. `WATCH` tracks variables and expressions across execution steps.
11. `CALL STACK` reconstructs the method path leading to the current execution
    point.
12. `launch.json` defines debugger launch behavior.
13. Console applications requiring `Console.ReadLine()` need an interactive
    terminal configuration.
14. Zero-based indexing bugs become easier to identify when variable state is
    observed directly.
15. Value-type parameters such as `int` receive copied values unless a different
    parameter-passing mechanism is explicitly used.
16. Debugging is most effective when developers inspect evidence rather than
    guess at runtime behavior.

---

# Section 6 Progress After Module 2

```text
Section: Debug C# Console Applications
Modules completed: 2 / 6
Learning progress: 33.3%
Repository-verified modules: 2 / 6
Registered solution projects: 34
Latest completed module: Implement the Visual Studio Code Debugging Tools for C#
Latest module assessment: Passed
Latest Microsoft Learn Achievement: Earned
Latest project run: Verified
Latest project build: Succeeded
Latest full solution build: Succeeded
Latest IDE diagnostics: No issues found
```

---

# Next Step

Continue with:

## Module 3 — Implement Exception Handling in C# Console Applications

The next module continues Section 6 by moving from debugger-based investigation
into structured runtime exception handling.

**Status:** ⏳ Not started
