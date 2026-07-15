// ============================================================================
// Guided Project: Calculate and Print Student Grades
// Learning path: Write Your First Code Using C#
//
// Project objective:
// Calculate the average grade for each student from five assignment scores,
// then display the student's name, numeric score, and letter grade.
//
// Concepts practiced:
// - Declaring and initializing variables
// - Choosing appropriate numeric data types
// - Performing addition and division
// - Casting an integer value to decimal
// - Formatting console output with \\t and \\n
// ============================================================================


// ============================================================================
// SECTION 1: STORE THE NUMBER OF GRADED ASSIGNMENTS
// ============================================================================

// Each student currently has five graded assignments.
// This value is used as the divisor when calculating each student's average.
int currentAssignments = 5;


// ============================================================================
// SECTION 2: STORE STUDENT NAMES
// ============================================================================

// Store each student's name in a string variable so the name can be reused
// when the final grade report is displayed.
string sophiaName = "Sophia";
string nicolasName = "Nicolas";
string zahirahName = "Zahirah";
string jeongName = "Jeong";


// ============================================================================
// SECTION 3: STORE ASSIGNMENT SCORES
// ============================================================================

// Each assignment score is stored as an int because every score is a whole
// number between 0 and 100.

// Sophia's assignment scores.
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

// Nicolas's assignment scores.
int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

// Zahirah's assignment scores.
int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

// Jeong's assignment scores.
int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


// ============================================================================
// SECTION 4: CALCULATE THE TOTAL SCORE FOR EACH STUDENT
// ============================================================================

// Add the five assignment scores for each student.
// The totals are stored as int values because adding whole numbers produces
// another whole number.
int sophiaSum =
    sophia1 + sophia2 + sophia3 + sophia4 + sophia5;

int nicolasSum =
    nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;

int zahirahSum =
    zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;

int jeongSum =
    jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


// Expected totals:
//
// Sophia:  473
// Nicolas: 418
// Zahirah: 417
// Jeong:   477
//
// These temporary output statements are useful while developing or debugging
// the program. They remain commented out so the final console output contains
// only the required grade report.
//
// Console.WriteLine($"{sophiaName}: {sophiaSum}");
// Console.WriteLine($"{nicolasName}: {nicolasSum}");
// Console.WriteLine($"{zahirahName}: {zahirahSum}");
// Console.WriteLine($"{jeongName}: {jeongSum}");


// ============================================================================
// SECTION 5: CALCULATE THE AVERAGE SCORE FOR EACH STUDENT
// ============================================================================

// Average score formula:
//
// average score = total assignment score / number of assignments
//
// Both sophiaSum and currentAssignments are int variables. If they were divided
// directly, C# would perform integer division and discard the decimal portion.
//
// Example:
//
// 473 / 5 = 94
//
// To preserve the fractional part, cast one operand to decimal before division:
//
// (decimal)473 / 5 = 94.6
//
// Casting the total score is sufficient because C# then converts the other
// operand to decimal for the calculation.
decimal sophiaScore =
    (decimal)sophiaSum / currentAssignments;

decimal nicolasScore =
    (decimal)nicolasSum / currentAssignments;

decimal zahirahScore =
    (decimal)zahirahSum / currentAssignments;

decimal jeongScore =
    (decimal)jeongSum / currentAssignments;


// The following pattern compiles, but it produces an inaccurate average because
// integer division happens before the result is assigned to a decimal variable:
//
// decimal incorrectSophiaScore = sophiaSum / currentAssignments;
//
// The result would be 94 instead of 94.6.


// ============================================================================
// SECTION 6: DISPLAY THE FINAL GRADE REPORT
// ============================================================================

// The letter grades are assigned directly in this guided project because
// conditional statements such as if and else have not been introduced yet.
//
// Escape sequences used:
//
// \\t inserts a horizontal tab.
// \\n inserts a new line.
//
// Two tab characters are used after shorter names so the numeric scores appear
// in approximately the same column.
Console.WriteLine("Student\t\tGrade\n");

Console.WriteLine(
    $"{sophiaName}:\t\t{sophiaScore}\tA"
);

Console.WriteLine(
    $"{nicolasName}:\t{nicolasScore}\tB"
);

Console.WriteLine(
    $"{zahirahName}:\t{zahirahScore}\tB"
);

Console.WriteLine(
    $"{jeongName}:\t\t{jeongScore}\tA"
);


// ============================================================================
// EXPECTED OUTPUT
// ============================================================================
//
// Student         Grade
//
// Sophia:         94.6    A
// Nicolas:        83.6    B
// Zahirah:        83.4    B
// Jeong:          95.4    A
// ============================================================================