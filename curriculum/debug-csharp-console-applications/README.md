# Debug C# Console Applications

> Foundational C# with Microsoft Certification
> Get Started with C#, Part 6

## Section Status

**Status:** In Progress
**Modules completed:** 1 / 6
**Current solution project count:** 33
**Target framework:** .NET 10.0
**Primary development environment:** Visual Studio
**Section started:** 2026-08-12

This section focuses on identifying runtime issues, using debugger tools to inspect application execution, and implementing exception handling in C# console applications.

The official Microsoft Learn learning path introduces debugging with Visual Studio Code and the C# debugger tools, then progresses into exception handling, creating and throwing exceptions, and practical debugging projects.

---

## Learning Path Progress

| # | Module | Status |
|---|---|---|
| 1 | Review the Principles of Code Debugging and Exception Handling | âœ… Completed |
| 2 | Implement the Visual Studio Code Debugging Tools for C# | â³ Not started |
| 3 | Implement Exception Handling in C# Console Applications | â³ Not started |
| 4 | Create and Throw Exceptions in C# Console Applications | â³ Not started |
| 5 | Guided Project - Debug and Handle Exceptions in a C# Console Application Using Visual Studio Code | â³ Not started |
| 6 | Challenge Project - Debug a C# Console Application Using Visual Studio Code | â³ Not started |

---

# Module 1 â€” Review the Principles of Code Debugging and Exception Handling

## Completion

**Status:** âœ… Completed
**Completed:** 2026-08-12
**Units:** 6 / 6
**Assessment:** Passed
**Microsoft Learn Achievement:** Earned
**XP:** 1000

### Project

```text
modules/review-code-debugging-exception-handling/
â”œâ”€â”€ Program.cs
â””â”€â”€ review-code-debugging-exception-handling.csproj
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
   â†“
Does the program behave as expected?

DEBUGGING
   â†“
Why is the program behaving incorrectly?

EXCEPTION HANDLING
   â†“
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
  â†“
execute
  â†“
BREAKPOINT
  â†“
pause
  â†“
inspect
  â†“
step
  â†“
inspect again
  â†“
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
    â†“
Detected while compiling/building
    â†“
Application cannot successfully start
```

versus:

```text
RUNTIME EXCEPTION
    â†“
Application built successfully
    â†“
Application begins running
    â†“
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
      â†“
An error occurs
      â†“
Exception is thrown
      â†“
Is the exception handled?
      â”‚
   â”Œâ”€â”€â”´â”€â”€â”
  Yes    No
   â†“      â†“
catch   Unhandled
   â†“    exception
respond  â†“
   â†“    application may terminate
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
 â†“
int.Parse(userInput)
 â†“
"not-a-number" cannot become int
 â†“
FormatException is thrown
 â†“
catch (FormatException exception)
 â†“
inspect exception
 â†“
controlled response
 â†“
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
â”‚
â”œâ”€â”€ may produce an exception
â”‚
â””â”€â”€ may produce incorrect behavior without an exception


EXCEPTION
â”‚
â””â”€â”€ runtime error represented by an exception object
```

---

# 8. Core Mental Model

The main mental model from this module is:

```text
                    CODE VERIFICATION
                           â”‚
           â”Œâ”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”¼â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”€â”
           â†“               â†“               â†“
        TESTING         DEBUGGING       EXCEPTION
                                         HANDLING
           â”‚               â”‚               â”‚
           â†“               â†“               â†“
     Is behavior       Why is the      How should the
       correct?         behavior       application react
                        incorrect?     to runtime failure?
```

Debugging then follows the application itself:

```text
INPUT
  â†“
PROCESSING
  â†“
STATE CHANGES
  â†“
OUTPUT
```

When the output or behavior is incorrect, the debugger helps trace the program through that flow and inspect where the state begins to differ from what was expected.

---

# 9. Important Terminology

## Debug

**debug**
`/ËŒdiËËˆbÊŒÉ¡/`

To locate and fix defects in a program.

## Debugging

**debugging**
`/ËŒdiËËˆbÊŒÉ¡.ÉªÅ‹/`

The process of isolating and diagnosing software problems.

## Debugger

**debugger**
`/ËŒdiËËˆbÊŒÉ¡.É™r/`

A software tool used to observe and control program execution.

## Breakpoint

**breakpoint**
`/ËˆbreÉªk.pÉ”Éªnt/`

A deliberate point where debugger-controlled execution pauses.

## Runtime

**runtime**
`/ËˆrÊŒn.taÉªm/`

The period during which an application is executing.

## Exception

**exception**
`/ÉªkËˆsep.ÊƒÉ™n/`

An object representing an abnormal condition or error that occurs during program execution.

## Throw

**throw**
`/Î¸rÉ™ÊŠ/`

To propagate an exception from code that encounters an error.

## Catch

**catch**
`/kÃ¦tÊƒ/`

To receive and handle an exception that has been thrown.

## Exception Handling

**exception handling**
`/ÉªkËˆsep.ÊƒÉ™n ËŒhÃ¦n.dÉ™l.ÉªÅ‹/`

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

# Next Step

Continue with:

## Module 2 â€” Implement the Visual Studio Code Debugging Tools for C#

The next module focuses on practical debugger usage, including:

- the debugger interface;
- breakpoints;
- controlling program execution;
- inspecting variables;
- monitoring execution flow;
- conditional breakpoints;
- debugger configuration.

**Status:** â³ Not started

