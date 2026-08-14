# Debug C# Console Applications

> Foundational C# with Microsoft Certification
> Get Started with C#, Part 6

## Section Status

**Status:** In Progress
**Modules completed:** 4 / 6
**Current solution project count:** 36
**Target framework:** .NET 10.0
**Primary development environment:** Visual Studio

This section focuses on identifying runtime issues, using debugger tools to inspect application execution, and implementing exception handling in C# console applications.

The official Microsoft Learn learning path introduces debugging with Visual Studio Code and the C# debugger tools, then progresses into exception handling, creating and throwing exceptions, and practical debugging projects.

---

## Learning Path Progress

| # | Module | Status |
|---|---|---|
| 1 | Review the Principles of Code Debugging and Exception Handling | ✅ Completed |
| 2 | Implement the Visual Studio Code Debugging Tools for C# | ✅ Completed |
| 3 | Implement Exception Handling in C# Console Applications | ✅ Completed |
| 4 | Create and Throw Exceptions in C# Console Applications | ✅ Completed |
| 5 | Guided Project - Debug and Handle Exceptions in a C# Console Application Using Visual Studio Code | ⏳ Not started |
| 6 | Challenge Project - Debug a C# Console Application Using Visual Studio Code | ⏳ Not started |

---

# Module 1 — Review the Principles of Code Debugging and Exception Handling

## Completion

**Status:** ✅ Completed
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

# Module 3 — Implement Exception Handling in C# Console Applications

## Completion

**Status:** ✅ Completed
**Units:** 11 / 11
**Assessment:** Passed
**Microsoft Learn Achievement:** Earned
**Target framework:** .NET 10.0
**Project registration in solution:** Verified
**Solution project count:** 35
**Final organized Program.cs:** Completed
**Professional source comments:** Completed
**Final source length:** 659 lines
**Full solution build:** Succeeded in 3.8 seconds
**IDE diagnostics:** No issues found

### Project

```text
modules/implement-exception-handling/
├── Program.cs
└── implement-exception-handling.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

After adding this module, the solution increased from:

```text
34 projects
```

to:

```text
35 projects
```

---

## Module Learning Objectives

This module moves from identifying runtime failures to implementing structured
exception-handling behavior in C#.

The completed learning objectives include:

1. examining common categories of runtime exceptions;
2. reviewing common .NET exception types;
3. understanding `try`, `catch`, and `finally`;
4. understanding the exception-handling process used by the CLR;
5. understanding call stack unwinding;
6. catching exceptions at different levels of the call stack;
7. inspecting properties exposed by exception objects;
8. catching specific exception types;
9. using multiple `catch` clauses when different failures require different
   responses;
10. using `checked` when integral overflow must generate an exception;
11. separating independent failure scenarios so each exception can be handled.

The repository implementation converts the lesson exercises into one stable
study application that intentionally generates exceptions but catches every
intentional failure so the program can continue running to completion.

---

# 1. Common Scenarios That Require Exception Handling

Runtime exceptions often arise when an application interacts with data,
external systems, or values that cannot be trusted completely.

Common scenarios reviewed in this module include:

```text
User input
Data processing and calculations
File input/output
Database operations
Network communication
Web services / REST APIs
Third-party libraries
Other external resources
```

The common theme is:

```text
Application expects something
            ↓
Runtime reality differs
            ↓
Operation fails
            ↓
Exception object is produced
            ↓
Application decides whether and how to handle it
```

Exception handling does not remove the underlying error condition. It provides
a structured way for the application to respond to that condition.

---

# 2. `try`, `catch`, and `finally`

C# exception handling is built around three core keywords.

## `try`

The `try` block contains guarded code that may fail.

```csharp
try
{
    // Code that may generate an exception.
}
```

## `catch`

The `catch` block contains the handler for a compatible exception.

```csharp
catch (FormatException exception)
{
    Console.WriteLine(exception.Message);
}
```

## `finally`

The `finally` block executes when control leaves the associated `try`
statement, whether the protected code succeeds or fails.

```csharp
finally
{
    // Cleanup or required state restoration.
}
```

Three common structural patterns are:

```text
try-catch

try-finally

try-catch-finally
```

The repository project demonstrates all three patterns.

---

# 3. `try-catch` Pattern

A basic `try-catch` pattern protects code that may fail:

```csharp
try
{
    int numerator = 3000;
    int denominator = 0;

    Console.WriteLine(numerator / denominator);
}
catch (DivideByZeroException exception)
{
    Console.WriteLine(
        $"Handled: {exception.GetType().Name}");
}
```

Execution flow:

```text
try
 ↓
integer division by zero
 ↓
DivideByZeroException
 ↓
matching catch found
 ↓
handler executes
 ↓
program continues
```

The important distinction is that the exception still occurs. The handler
changes what the application does after that failure occurs.

---

# 4. `try-finally` and Guaranteed Cleanup

The repository includes a simple `try-finally` demonstration:

```csharp
bool cleanupCompleted = false;

try
{
    Console.WriteLine(
        "Protected operation completed.");
}
finally
{
    cleanupCompleted = true;

    Console.WriteLine(
        "Cleanup executed in finally.");
}
```

The central idea is:

```text
Enter try
   ↓
success OR exception
   ↓
leave try statement
   ↓
finally executes
```

This makes `finally` useful for cleanup and required state restoration.

Modern .NET code frequently uses `using` or `await using` for disposable
resources, but `finally` remains fundamental because it explains the underlying
guaranteed-cleanup behavior.

---

# 5. `try-catch-finally`

The complete pattern combines guarded execution, exception handling, and
cleanup:

```csharp
try
{
    _ = int.Parse(
        "not-a-number");
}
catch (FormatException exception)
{
    Console.WriteLine(
        $"Handled: {exception.GetType().Name}");
}
finally
{
    Console.WriteLine(
        "Finalization executed.");
}
```

Conceptually:

```text
try
 ↓
operation fails
 ↓
catch
 ↓
handle failure
 ↓
finally
 ↓
required cleanup
 ↓
continue
```

---

# 6. Exceptions Are Objects

Exceptions are represented as objects whose types ultimately derive from:

```text
System.Exception
```

For example, a simplified inheritance path is:

```text
Object
  ↓
Exception
  ↓
SystemException
  ↓
InvalidCastException
```

This distinction matters:

```text
Exception class
    = definition of an exception type

Exception object
    = runtime instance containing details about one failure
```

Because an exception is an object, a `catch` clause can store it in a variable:

```csharp
catch (DivideByZeroException exception)
{
    Console.WriteLine(
        exception.Message);
}
```

---

# 7. Important `Exception` Properties

The module reviews properties inherited from `System.Exception`.

| Property | Purpose |
| --- | --- |
| `Data` | Arbitrary key-value diagnostic data |
| `HelpLink` | Optional URI/URL for additional help |
| `HResult` | Numeric error identifier |
| `InnerException` | Preserves a nested/underlying exception |
| `Message` | Human-readable description of the error |
| `Source` | Application/object associated with the error |
| `StackTrace` | Execution path associated with the exception |
| `TargetSite` | Method that threw the exception |

The repository implementation inspects several of them:

```csharp
Console.WriteLine(
    $"Type: {exception.GetType().FullName}");

Console.WriteLine(
    $"Message: {exception.Message}");

Console.WriteLine(
    $"HResult: {exception.HResult}");

Console.WriteLine(
    $"TargetSite: {exception.TargetSite?.Name ?? "<unknown>"}");

Console.WriteLine(
    $"StackTrace available: {exception.StackTrace is not null}");
```

The Microsoft Learn exercises focus especially on `Message` because it gives
the application an immediate description of the failure.

---

# 8. Common Runtime Exception Types

The module reviews several exceptions generated by failed runtime operations.

## `ArrayTypeMismatchException`

Occurs when an array cannot store an element because the runtime type is
incompatible with the actual array type.

Repository example:

```csharp
string[] names =
[
    "Dog",
    "Cat",
    "Fish"
];

object[] objects = names;

objects[2] = 13;
```

Although the reference is viewed as `object[]`, the actual runtime array is
still `string[]`, so storing an `int` is invalid.

---

## `DivideByZeroException`

Integer division by zero throws:

```text
DivideByZeroException
```

Example:

```csharp
int numerator = 3000;
int denominator = 0;

_ = numerator / denominator;
```

An important contrast is floating-point arithmetic.

```csharp
double numerator = 3000.0;
double denominator = 0.0;

double result =
    numerator /
    denominator;
```

Floating-point division follows IEEE 754 behavior and can produce:

```text
Infinity
-Infinity
NaN
```

instead of throwing `DivideByZeroException`.

---

## `FormatException`

Occurs when input has an invalid format for the requested conversion.

```csharp
string userValue =
    "two";

_ =
    int.Parse(
        userValue);
```

---

## `IndexOutOfRangeException`

Occurs when code accesses an array index outside its valid bounds.

For:

```csharp
int[] values =
[
    3,
    6,
    9,
    12,
    15,
    18,
    21
];
```

valid indexes are:

```text
0 through 6
```

Therefore:

```csharp
values[values.Length]
```

means:

```csharp
values[7]
```

and causes `IndexOutOfRangeException`.

---

## `InvalidCastException`

Occurs when an explicit runtime cast is invalid.

```csharp
object value =
    "This is a string";

_ =
    (int)value;
```

The runtime object is a `string`, not an `int`.

---

## `NullReferenceException`

Occurs when code attempts to access an instance member through a null
reference.

Repository demonstration:

```csharp
string? text =
    null;

_ =
    text!.Length;
```

The null-forgiving operator `!` suppresses nullable static-analysis warnings in
this intentional demonstration. It does **not** create an object and does
**not** prevent the runtime exception.

---

## `OverflowException`

Overflow checking depends on context.

The repository explicitly uses:

```csharp
_ =
    checked(
        first +
        second);
```

with:

```csharp
int first =
    int.MaxValue;

int second =
    int.MaxValue;
```

The `checked` context causes integral overflow to generate:

```text
OverflowException
```

---

# 9. Checked and Unchecked Integral Arithmetic

Integral arithmetic is not always exception-producing by default.

A `checked` context requests overflow checking:

```csharp
int result =
    checked(
        first +
        second);
```

Conceptually:

```text
result fits target type?
      │
   ┌──┴──┐
  yes    no
   ↓      ↓
assign  OverflowException
```

This is important when silent truncation or wraparound would make the
application state unreliable.

---

# 10. Exception Search Process

When an exception occurs, the CLR searches for the nearest compatible
`catch` clause.

The search begins where the exception was thrown.

Conceptually:

```text
Exception thrown in Method C
            ↓
Method C has matching catch?
      │
   ┌──┴──┐
  yes    no
   ↓      ↓
handle   caller Method B
              ↓
        matching catch?
              ↓
             ...
```

If no compatible `catch` exists anywhere in the call stack:

```text
Unhandled exception
        ↓
application terminates
```

---

# 11. Call Stack Unwinding

The module introduces the term:

**call stack unwinding**

The call stack can be visualized as method layers:

```text
Main / top-level statements
          ↓
      Process1()
          ↓
     WriteMessage()
```

When an exception is thrown inside `WriteMessage()` and that method cannot
handle it, the runtime moves back through the calling methods until a
compatible handler is found.

Repository example:

```text
top-level statements
        ↓
DemonstrateCallStackUnwinding()
        ↓
ProcessForPropagation()
        ↓
WriteMessageForPropagation()
        ↓
DivideByZeroException
```

The two inner methods do not handle the exception, so the CLR unwinds back to
the compatible handler in `DemonstrateCallStackUnwinding()`.

This demonstrates that:

```text
throw location
≠
catch location
```

An exception may be caught several call-stack levels below the method where the
failure occurred.

---

# 12. `finally` During Stack Unwinding

A key detail from the exception search process is that applicable `finally`
blocks execute before control reaches the selected `catch`.

Conceptually:

```text
outer try
  ↓
inner try
  ↓
exception
  ↓
compatible outer catch identified
  ↓
inner finally executes
  ↓
control enters outer catch
```

Therefore `finally` participates in stack unwinding and helps guarantee cleanup
as execution leaves protected scopes.

---

# 13. Catching an Exception Closer to Its Source

The module challenge moves exception handling from the top-level statements
into the intermediate method.

Conceptually:

```text
Top level
   ↓
Process1()
   ↓
WriteMessage()
   ↓
exception
```

If `Process1()` contains:

```csharp
try
{
    WriteMessage();
}
catch (DivideByZeroException exception)
{
    Console.WriteLine(
        "Exception caught in Process1");
}
```

then `Process1()` is the nearest compatible handler.

The outer handler is never executed for that exception.

The repository preserves this idea through:

```text
ProcessWithLocalHandler()
        ↓
WriteMessageForLocalHandler()
        ↓
DivideByZeroException
        ↓
caught locally
```

The core rule is:

```text
The nearest compatible handler wins.
```

---

# 14. Catch Specific Exception Types

A bare catch:

```csharp
catch
{
}
```

can catch broadly but provides little type-specific intent.

Likewise:

```csharp
catch (Exception exception)
{
}
```

is extremely broad.

The module emphasizes a better default:

> Catch the most specific exception type that the current layer knows how to
> handle meaningfully.

For example:

```csharp
catch (DivideByZeroException exception)
{
    Console.WriteLine(
        exception.Message);
}
```

This prevents a handler designed for divide-by-zero recovery from accidentally
absorbing an unrelated runtime failure.

---

# 15. Multiple `catch` Clauses

Different input values can fail for different reasons.

The repository example uses:

```csharp
string[] inputValues =
[
    "three",
    "9999999999",
    "0",
    "2"
];
```

Parsing can produce different outcomes:

```text
"three"
    ↓
FormatException

"9999999999"
    ↓
OverflowException

"0"
    ↓
success

"2"
    ↓
success
```

The handler structure is:

```csharp
try
{
    int number =
        int.Parse(
            inputValue);
}
catch (FormatException)
{
    // Invalid format.
}
catch (OverflowException)
{
    // Outside Int32 range.
}
catch (Exception exception)
{
    // General fallback, placed last.
}
```

More specific handlers must appear before broader base-class handlers.

---

# 16. Why One `try` Block Does Not Catch Every Failure Sequentially

A particularly important lesson from the challenge is that a single `try`
block does **not** continue executing after an exception is caught elsewhere.

Suppose one `try` contains:

```text
Operation A → OverflowException
Operation B → NullReferenceException
Operation C → IndexOutOfRangeException
Operation D → DivideByZeroException
```

As soon as Operation A throws:

```text
Operation A throws
      ↓
leave try immediately
      ↓
matching catch executes
      ↓
Operations B, C, D are never reached
```

This is why the challenge's four independent failures need separate protected
operations if the goal is to display all four error messages.

---

# 17. Independent `try-catch` Blocks

The final repository project separates the four independent challenge
scenarios:

```text
DemonstrateCheckedOverflowChallenge()
DemonstrateNullReferenceChallenge()
DemonstrateIndexOutOfRangeChallenge()
DemonstrateDivideByZeroChallenge()
```

Each method has its own `try-catch`.

This enables the program to produce all four handled failures:

```text
OverflowException
NullReferenceException
IndexOutOfRangeException
DivideByZeroException
```

and then continue:

```text
Exiting independent-exception demonstration.
```

This structure should only be used when the operations are genuinely
independent.

If a later operation depends on an earlier operation succeeding, continuing
after the first failure may be incorrect.

---

# 18. Dependent vs. Independent Operations

Before deciding whether to catch and continue, ask:

```text
Did operation 1 fail?
      ↓
Does operation 2 depend on operation 1?
      │
   ┌──┴──┐
  yes    no
   ↓      ↓
 stop    may continue
```

This is a design decision, not merely syntax.

Exception handling should preserve application correctness, not just prevent
the application from terminating.

---

# 19. Repository Implementation Structure

The final `Program.cs` is organized into focused demonstration methods:

```text
DemonstrateExceptionHandlingPatterns()
DemonstrateCommonRuntimeExceptions()
DemonstrateCallStackUnwinding()
DemonstrateNearestCatchHandler()
DemonstrateExceptionProperties()
DemonstrateSpecificCatchClauses()
DemonstrateIndependentTryCatchBlocks()
DemonstrateFinallyCleanup()
```

The common runtime exception examples are further separated into:

```text
DemonstrateArrayTypeMismatchException()
DemonstrateDivideByZeroException()
DemonstrateFormatException()
DemonstrateIndexOutOfRangeException()
DemonstrateInvalidCastException()
DemonstrateNullReferenceException()
DemonstrateOverflowException()
```

The final challenge examples are separated into:

```text
DemonstrateCheckedOverflowChallenge()
DemonstrateNullReferenceChallenge()
DemonstrateIndexOutOfRangeChallenge()
DemonstrateDivideByZeroChallenge()
```

This structure makes the project easier to:

```text
read
debug
test manually
maintain
extend
review later
```

---

# 20. Repository Safety for Intentional Exceptions

The project intentionally creates runtime failures for learning purposes.

However, the executable repository version follows this rule:

```text
Intentional exception
        ↓
specific handler
        ↓
explain failure
        ↓
continue study program
```

As a result, the final project can demonstrate exception behavior without
leaving the repository in a deliberately crashing state.

The intentional `NullReferenceException` example also uses:

```csharp
text!.Length
```

only to suppress nullable analysis for the specific runtime demonstration.

The comment in the source explicitly explains that `!` does not make the value
non-null.

---

# 21. `finally` Cleanup Demonstration

The final repository implementation includes explicit cleanup state:

```csharp
bool resourceIsOpen =
    false;
```

The `try` simulates opening a resource:

```csharp
resourceIsOpen =
    true;
```

The protected processing deliberately triggers a `FormatException`.

The `finally` block restores the required state:

```csharp
finally
{
    resourceIsOpen =
        false;

    Console.WriteLine(
        "finally: resource state was cleaned up.");
}
```

The final state verifies:

```text
resourceIsOpen = false
```

This provides a concrete mental model for guaranteed cleanup.

---

# 22. Core Mental Model

The complete exception-handling model from this module is:

```text
Potentially failing operation
          ↓
         try
          ↓
   exception occurs?
      ┌───┴───┐
     no      yes
      ↓        ↓
 continue   CLR searches
             for nearest
             compatible catch
                ↓
         unwind call stack
          when necessary
                ↓
      applicable finally blocks
             execute
                ↓
             catch
                ↓
       handle/report/recover
                ↓
             continue
```

The design question is not:

```text
"Can I catch this exception?"
```

The better question is:

```text
"Does this layer know how to handle this exception correctly?"
```

---

# 23. Important Terminology

## Exception handling

**exception handling**
`/ɪkˈsep.ʃən ˌhæn.dəl.ɪŋ/`

Structured management of runtime exceptional conditions.

## Call stack

**call stack**
`/ˈkɔːl stæk/`

The runtime stack that records active method calls.

## Stack unwinding

**stack unwinding**
`/stæk ʌnˈwaɪn.dɪŋ/`

The process of moving backward through active method calls while searching for
a compatible exception handler and leaving protected scopes.

## Specific exception

**specific exception**
`/spəˈsɪf.ɪk ɪkˈsep.ʃən/`

A particular derived exception type, such as `FormatException` or
`DivideByZeroException`.

## Checked context

**checked context**
`/tʃekt ˈkɒn.tekst/`

An integral arithmetic context in which overflow is reported by an
`OverflowException`.

## Finally

**finally**
`/ˈfaɪ.nəl.i/`

A block that executes when control leaves the associated `try` statement,
commonly used for cleanup.

---

# 24. Runtime Command

Run the module project from the repository root:

```powershell
dotnet run --project `
    ".\curriculum\debug-csharp-console-applications\modules\implement-exception-handling\implement-exception-handling.csproj"
```

The organized project is designed to run through all demonstrations and finish
with:

```text
Exception handling review completed.
```

---

# 25. Build Verification

## Module Project

```powershell
dotnet build `
    ".\curriculum\debug-csharp-console-applications\modules\implement-exception-handling\implement-exception-handling.csproj"
```

## Full Solution

```powershell
dotnet build .\freecodecamp-csharp.slnx
```


Verified full-solution result:

```text
Build succeeded in 3.8 seconds
```

Solution project count:

```text
35 / 35 projects
```

Final IDE result:

```text
Visual Studio: No issues found
```

---

# 26. Module Assessment and Achievement

Microsoft Learn module:

**Implement Exception Handling in C# Console Applications**

Completion:

```text
11 / 11 units
```

Assessment result:

```text
Module assessment passed
```

Microsoft Learn Achievement:

```text
Earned
```

2026-08-14
```

---

# Module 3 Key Takeaways

1. Exceptions provide a structured, type-safe mechanism for runtime failure
   handling.
2. `try` protects code that may fail.
3. `catch` handles compatible exceptions.
4. `finally` executes when control leaves the associated `try` statement and
   is commonly used for cleanup.
5. All .NET exception types ultimately derive from `System.Exception`.
6. Exception objects expose useful diagnostic properties such as `Message`,
   `StackTrace`, and `TargetSite`.
7. The CLR searches for the nearest compatible exception handler.
8. The CLR can unwind several method-call levels before finding a handler.
9. Applicable `finally` blocks execute during stack unwinding before control
   reaches the selected handler.
10. Catch exception types as specifically as practical.
11. A broad `catch (Exception)` should not replace handlers that understand
    specific recoverable failures.
12. `checked` can convert integral overflow into an `OverflowException`.
13. Integer division by zero throws `DivideByZeroException`.
14. Floating-point division by zero follows IEEE 754 behavior and can produce
    infinity or NaN instead.
15. The first exception in a `try` block immediately transfers control away
    from the remaining statements in that block.
16. Independent failing operations may need independent `try-catch` blocks if
    processing should continue.
17. Dependent processing should generally not continue when an earlier required
    step fails.
18. Exception handling should preserve application correctness, not merely hide
    failures.

---

# Module 4 — Create and Throw Exceptions in C# Console Applications

## Completion

**Status:** ✅ Completed
**Units:** 7 / 7
**Assessment:** Passed
**Microsoft Learn Achievement:** Earned
**Target framework:** .NET 10.0
**Project registration in solution:** Verified
**Solution project count:** 36
**Final organized Program.cs:** Completed
**Professional source comments:** Completed
**Final source length:** 724 lines
**Full solution build:** Succeeded in 2.8 seconds
**IDE diagnostics:** No issues found

### Project

```text
modules/create-throw-exceptions/
├── Program.cs
└── create-throw-exceptions.csproj
```

The project is registered in:

```text
freecodecamp-csharp.slnx
```

After adding this module, the solution increased from:

```text
35 projects
```

to:

```text
36 projects
```

---

## Module Learning Objectives

This module moves from handling exceptions generated by .NET or library code to
deliberately creating and throwing exceptions from application code.

The completed learning objectives include:

1. understanding how exception objects are created;
2. selecting an exception type that closely matches the failure condition;
3. customizing exception information before throwing;
4. throwing exception objects with `throw`;
5. validating method arguments before starting an invalid operation;
6. catching exceptions at the call-stack level where the problem can be
   resolved;
7. re-throwing the original exception with `throw;`;
8. wrapping an original exception inside a new exception through
   `InnerException`;
9. replacing status-string error flow with structured exceptions;
10. distinguishing runtime exceptions from development-time `Debug.Assert`
    checks.

The repository implementation preserves the Microsoft Learn exercises as one
repeatable study application while keeping all intentional failures controlled
so the project can run to completion.

---

# 1. Creating Exception Objects

.NET provides an exception hierarchy rooted at:

```text
System.Exception
```

Application code can create an instance of an exception-derived class whenever
it detects a failure condition that prevents a method from completing its
intended purpose.

Example:

```csharp
ArgumentException invalidArgumentException =
    new ArgumentException();
```

The `new` keyword creates the exception object.

Creating the object does **not** throw it yet.

Conceptually:

```text
detect failure
    ↓
new ExceptionType(...)
    ↓
exception object exists
    ↓
throw
    ↓
runtime begins handler search
```

---

# 2. Choose the Exception Type That Best Matches the Failure

The module emphasizes choosing the exception type whose intended purpose most
closely matches the problem.

Common types reviewed include:

| Exception type | Typical purpose |
| --- | --- |
| `ArgumentException` | Invalid argument value |
| `ArgumentNullException` | Required argument is null |
| `ArgumentOutOfRangeException` | Argument is outside the allowed range |
| `InvalidOperationException` | Current operating state does not support the requested operation |
| `NotSupportedException` | Requested operation or feature is unsupported |
| `IOException` | Input/output operation fails |
| `FormatException` | Data or string format is invalid |

The design rule is:

```text
Method cannot complete its contract
            ↓
Identify the real failure condition
            ↓
Choose the narrowest appropriate exception type
            ↓
throw
```

---

# 3. Customize Exception Information

Exception objects can carry application-specific context.

The `Message` property is read-only after construction, so a custom message is
normally supplied through the constructor.

Example:

```csharp
ArgumentException invalidArgumentException =
    new(
        "GraphData received data outside the expected range.",
        nameof(data));
```

The repository project also uses the `Data` dictionary:

```csharp
invalidArgumentException.Data["Method"] =
    nameof(GraphData);

invalidArgumentException.Data["ExpectedRange"] =
    "0..100";

invalidArgumentException.Data["InvalidValue"] =
    value;
```

This provides structured diagnostic context without inventing a custom
exception class.

The message should explain the problem clearly, but sensitive or
security-relevant information should not be included in user-visible exception
text.

---

# 4. Throwing an Exception

After the exception object is created, `throw` transfers control away from the
current execution path.

```csharp
throw invalidArgumentException;
```

An exception can also be created directly inside the `throw` statement:

```csharp
throw new FormatException(
    "User input values must be valid integers.");
```

Execution changes immediately:

```text
normal statements
      ↓
throw
      ↓
current path stops
      ↓
CLR searches for compatible catch
      ↓
handler found?
```

Statements after the `throw` in that execution path are not executed.

---

# 5. Throw at the Point Where the Stack Trace Should Begin

The runtime creates stack-trace information from the location where the
exception is thrown.

Therefore the method that detects the actual invalid condition should generally
throw the exception at that point.

Conceptually:

```text
bad condition detected in Process1()
              ↓
            throw
              ↓
StackTrace begins from the throw location
              ↓
caller can inspect the origin
```

This makes the failure easier to diagnose than postponing error reporting until
some unrelated later operation fails.

---

# 6. Validate Before Performing an Invalid Operation

The `AverageOfEvenNumbers` exercise demonstrates an important design principle.

The method expects:

```text
upperBound > lowerBound
```

Instead of allowing an invalid range to reach the later calculation, the method
checks its input contract first:

```csharp
if (lowerBound >= upperBound)
{
    throw new ArgumentOutOfRangeException(
        nameof(upperBound),
        "Upper bound must be greater than lower bound.");
}
```

Execution flow:

```text
AverageOfEvenNumbers(lowerBound, upperBound)
              ↓
validate arguments
      ┌───────┴───────┐
    valid           invalid
      ↓                ↓
calculate      ArgumentOutOfRangeException
```

This is preferable to allowing the method to fail later for a secondary reason
such as an invalid calculation.

---

# 7. Why `ArgumentOutOfRangeException` Fits the Exercise

The lesson compares two plausible choices:

```text
ArgumentOutOfRangeException
InvalidOperationException
```

Both relate to the failure, but `ArgumentOutOfRangeException` is more narrowly
scoped because the problem originates from an argument value.

The general selection principle is:

```text
Two exception types both seem valid
            ↓
prefer the type with the narrower,
more precise semantic meaning
```

---

# 8. Catch the Exception Where It Can Be Resolved

An exception should be caught at the call-stack level that has enough context
to resolve or meaningfully handle it.

In the range example:

```text
top-level caller
      ↓
AverageOfEvenNumbers()
      ↓
invalid upperBound
      ↓
ArgumentOutOfRangeException
      ↓
caller catches
      ↓
caller can request/provide a corrected upper bound
```

The method identifies the invalid contract.

The caller owns the user interaction or retry policy.

That separation keeps responsibilities clear.

---

# 9. Customized `FormatException` in a Business Process

The module also demonstrates translating a lower-level parsing problem into
application-specific language.

Repository example:

```csharp
try
{
    _ =
        int.Parse(
            userValue);
}
catch (FormatException)
{
    throw new FormatException(
        "FormatException: User input values in " +
        "'BusinessProcess1' must be valid integers.");
}
```

The method detects a concrete parsing failure and creates an exception whose
message reflects the business-process requirement.

The caller can then inspect:

```text
exception type
Message
StackTrace
```

before deciding what to display or how to respond.

---

# 10. Re-throwing an Exception with `throw;`

A `catch` block can partially handle an exception and then pass the **same**
exception upward.

Syntax:

```csharp
catch (DivideByZeroException exception)
{
    // Partial handling...

    throw;
}
```

The key point is that:

```text
throw;
```

re-throws the original exception object.

Conceptually:

```text
original exception
      ↓
local catch
      ↓
partial handling
      ↓
throw;
      ↓
same exception continues upward
```

This preserves the original diagnostic information.

---

# 11. `throw;` vs. Throwing Another Exception Object

The study project explicitly documents the distinction between:

```csharp
throw;
```

and constructing another exception.

`throw;` means:

```text
re-throw the original exception
```

Creating another exception means:

```text
new exception object
```

These are different operations and should not be treated interchangeably.

When the goal is to preserve the original failure and its throw location during
re-throwing, use:

```csharp
throw;
```

---

# 12. Wrapping an Original Exception

Sometimes a higher layer needs to add its own context while preserving the
underlying failure.

The module demonstrates this pattern:

```csharp
catch (InvalidCastException exception)
{
    throw new ApplicationException(
        "An error occurred in OperatingProcedureForWrapping.",
        exception);
}
```

The resulting exception structure is:

```text
ApplicationException
        │
        └── InnerException
                │
                └── InvalidCastException
```

The outer exception describes the higher-level operation.

The `InnerException` preserves the original failure.

The repository can inspect both:

```csharp
exception.Message

exception.InnerException?.GetType().Name

exception.InnerException?.Message
```

---

# 13. Error Strings vs. Real Exceptions

The challenge begins with code that reports errors by returning strings.

Conceptually:

```csharp
return "Invalid data...";
```

This mixes successful method results with error-state communication.

The completed challenge changes the design:

```text
success
    ↓
normal return / void completion

failure
    ↓
throw exception
```

The methods are converted from:

```text
static string
```

to:

```text
static void
```

and failure information is transferred through exception objects rather than
status strings.

---

# 14. Challenge Call-Stack Responsibilities

The completed challenge has three logical layers:

```text
Top-level statements
        ↓
    Workflow1()
        ↓
     Process1()
```

Each layer has a different responsibility.

## `Process1`

`Process1` detects the actual data failure and throws.

Invalid format:

```csharp
throw new FormatException(
    "Invalid data. User input values must be valid integers.");
```

Zero value:

```csharp
throw new DivideByZeroException(
    "Invalid data. User input values must be non-zero values.");
```

## `Workflow1`

`Workflow1` can handle invalid format locally:

```csharp
catch (FormatException exception)
{
    Console.WriteLine(
        "'Process1' encountered an issue, process aborted.");

    Console.WriteLine(
        exception.Message);
}
```

This allows later workflow entries to continue.

## Top-level caller

`Workflow1` does not handle the zero-value failure.

Therefore:

```text
DivideByZeroException
        ↓
propagates through Workflow1
        ↓
top-level catch
```

The top-level layer reports:

```text
An error occurred during 'Workflow1'.
Invalid data. User input values must be non-zero values.
```

---

# 15. Challenge Control Flow

The three input groups are:

```text
{ "1", "2", "3" }
{ "1", "two", "3" }
{ "0", "1", "2" }
```

Execution is:

```text
Group 1
  ↓
all valid
  ↓
Process1 completes
  ↓
Workflow1 continues

Group 2
  ↓
"two"
  ↓
FormatException
  ↓
Workflow1 catches
  ↓
message displayed
  ↓
Workflow1 continues

Group 3
  ↓
"0"
  ↓
DivideByZeroException
  ↓
Workflow1 has no matching catch
  ↓
exception propagates
  ↓
top-level catches
  ↓
workflow terminates
```

This demonstrates that exception type is not merely descriptive metadata.

It also determines which handler can receive the failure.

---

# 16. Method Contracts and Exception Design

A useful mental model from this module is:

```text
METHOD CONTRACT
      ↓
What does this method promise to do?
      ↓
Can it complete that purpose?
   ┌──┴──┐
  yes    no
   ↓      ↓
return   identify cause
             ↓
      choose exception type
             ↓
           throw
```

This is a stronger design than waiting for an unrelated runtime error to occur
later.

---

# 17. Practices to Avoid

The module identifies several anti-patterns.

## Do not use exceptions for ordinary control flow

Exceptions are for exceptional error conditions.

Normal expected branching should use constructs such as:

```text
if
else
switch
loops
TryParse
```

rather than deliberately throwing and catching exceptions to choose a normal
branch.

---

## Do not return exception objects instead of throwing them

Avoid treating an `Exception` object as an ordinary return value when the
condition should interrupt normal execution.

Structured exception flow exists specifically so failure can propagate through
the call stack separately from normal return values.

---

## Do not intentionally throw overly general or runtime-generated exceptions

The lesson warns against intentionally throwing types such as:

```text
System.Exception
System.SystemException
System.NullReferenceException
System.IndexOutOfRangeException
```

from application source simply to signal a validation rule.

Instead, choose a type whose documented purpose matches the application
condition.

---

## Do not expose sensitive information in exception messages

Exception messages may be displayed, logged, or transmitted.

Therefore message text should not contain secrets, credentials, or other
security-sensitive information.

---

# 18. `Debug.Assert` Is Not a Replacement for Runtime Exceptions

`Debug.Assert` is intended for development-time logic assumptions.

Example:

```csharp
Debug.Assert(
    inventoryCount >= 0,
    "Inventory count should never be negative.");
```

Conceptually:

```text
Debug.Assert
    ↓
"this state should never happen if the code is correct"
```

Runtime exception:

```text
exception
    ↓
"this failure can occur while the application is operating"
```

Therefore:

```text
Debug.Assert
≠
runtime exception handling
```

They solve different problems.

---

# 19. Repository Implementation Structure

The final `Program.cs` organizes the module into focused demonstrations:

```text
ReviewExceptionSelection()
DemonstrateCustomizedExceptionObject()
DemonstrateArgumentOutOfRangeValidation()
DemonstrateBusinessProcessFormatException()
DemonstrateRethrow()
DemonstrateWrappedException()
DemonstrateChallengeWorkflow()
ReviewThrowingPractices()
DemonstrateDebugAssert()
```

Supporting methods include:

```text
GraphData()
AverageOfEvenNumbers()
BusinessProcess1()
OperatingProcedureForRethrow()
BusinessProcessForRethrow()
OperatingProcedureForWrapping()
Workflow1()
Process1()
WriteSectionHeader()
```

This keeps each concept isolated enough to:

```text
read
debug
review
maintain
extend
```

without losing the connection between the demonstrations.

---

# 20. Repository Safety

The project intentionally throws exceptions for educational purposes.

The executable study version follows this pattern:

```text
intentional invalid condition
          ↓
throw specific exception
          ↓
appropriate catch
          ↓
display / inspect / partially handle
          ↓
continue where appropriate
```

The project therefore remains suitable for normal repository builds even though
its purpose is to demonstrate failure behavior.

---

# 21. Core Mental Model

The main progression across Modules 3 and 4 is:

```text
Module 3
Runtime/library failure
       ↓
catch and handle

Module 4
Application detects invalid condition
       ↓
create exception object
       ↓
customize context
       ↓
throw
       ↓
CLR searches call stack
       ↓
appropriate layer catches
```

A more complete flow is:

```text
Method receives state/input
          ↓
Validate method contract
          ↓
Can method complete correctly?
     ┌────┴────┐
    yes       no
     ↓         ↓
 continue   choose specific
 execution   exception type
                ↓
          create exception
                ↓
              throw
                ↓
         stack propagation
                ↓
       appropriate handler
                ↓
      recover / report / rethrow
```

---

# 22. Important Terminology

## Throw

**throw**
`/θrəʊ/`

To transfer control by raising an exception object.

## Re-throw

**re-throw**
`/ˌriː ˈθrəʊ/`

To propagate an already-caught exception again, commonly with `throw;`.

## Argument

**argument**
`/ˈɑːɡ.jə.mənt/`

A value supplied to a method or constructor parameter.

## Argument out of range

**argument out of range**
`/ˈɑːɡ.jə.mənt aʊt əv reɪndʒ/`

An argument value that falls outside the range accepted by the method.

## Inner exception

**inner exception**
`/ˈɪn.ər ɪkˈsep.ʃən/`

The original or underlying exception stored inside another exception object.

## Method contract

**method contract**
`/ˈmeθ.əd ˈkɒn.trækt/`

The expectations and guarantees associated with a method's inputs, behavior,
and result.

## Debug assertion

**debug assertion**
`/ˈdiː.bʌɡ əˈsɜː.ʃən/`

A development-time check for a condition that should logically never be false.

---

# 23. Runtime Command

Run the module project from the repository root:

```powershell
dotnet run --project `
    ".\curriculum\debug-csharp-console-applications\modules\create-throw-exceptions\create-throw-exceptions.csproj"
```

The organized application is designed to complete all demonstrations and finish
with:

```text
Create and throw exceptions review completed.
```

---

# 24. Build Verification

## Module Project

```powershell
dotnet build `
    ".\curriculum\debug-csharp-console-applications\modules\create-throw-exceptions\create-throw-exceptions.csproj"
```

## Full Solution

```powershell
dotnet build .\freecodecamp-csharp.slnx
```

Verified full-solution result:

```text
Build succeeded in 2.8 seconds
```

Solution project count:

```text
36 / 36 projects
```

Final IDE result:

```text
Visual Studio: No issues found
```

---

# 25. Module Assessment and Achievement

Microsoft Learn module:

**Create and Throw Exceptions in C# Console Applications**

Completion:

```text
7 / 7 units
```

Assessment result:

```text
Module assessment passed
```

Microsoft Learn Achievement:

```text
Earned
```

---

# Module 4 Key Takeaways

1. Application code can deliberately create and throw exception objects.
2. Throw an exception when a method cannot complete its intended purpose.
3. Choose the exception type that most closely matches the actual failure.
4. Prefer a narrowly scoped exception type when several types appear equally
   applicable.
5. Validate method arguments before performing operations that depend on those
   arguments being valid.
6. Exception messages can provide useful application-specific context.
7. Sensitive information should not be placed in exception messages.
8. The stack trace begins from the point where the exception is thrown.
9. Catch an exception at the call-stack level that can meaningfully resolve or
   report it.
10. `throw;` re-throws the original exception.
11. A new exception can wrap an original exception through `InnerException`.
12. Exceptions should not be used as ordinary program flow.
13. Exceptions should not be returned as ordinary method results when they are
   intended to signal failure.
14. Avoid intentionally throwing overly general or inappropriate framework
   exception types for application validation rules.
15. `Debug.Assert` is a development-time diagnostic tool, not a replacement for
   runtime exception handling.
16. Structured exceptions separate normal method results from failure flow.
17. Exception type helps determine which layer of the call stack handles the
   failure.

---

# Section 6 Progress After Module 4

```text
Section: Debug C# Console Applications
Modules completed: 4 / 6
Learning progress: 66.7%
Repository-verified modules: 4 / 6
Registered solution projects: 36
Latest completed module: Create and Throw Exceptions in C# Console Applications
Latest module units: 7 / 7
Latest module assessment: Passed
Latest Microsoft Learn Achievement: Earned
Latest organized Program.cs: Completed
Latest professional source comments: Completed
Latest full solution build: Succeeded in 2.8 seconds
Latest IDE diagnostics: No issues found
```

---

# Next Step

Continue with:

## Module 5 — Guided Project: Debug and Handle Exceptions in a C# Console Application Using Visual Studio Code

The next module combines the debugger and exception-handling concepts from the
first four modules in a guided application.

**Status:** ⏳ Not started
