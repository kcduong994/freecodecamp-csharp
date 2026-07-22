/*
 * Student Grading Application
 *
 * This guided project demonstrates how to:
 * - store related data in arrays;
 * - process student names with an outer foreach loop;
 * - process assignment scores with an inner foreach loop;
 * - select each student's score array with if-else-if statements;
 * - distinguish exam scores from extra-credit scores;
 * - calculate numeric grades;
 * - assign letter grades automatically.
 */

// The first five values in each score array are regular exam assignments.
const int examAssignments = 5;

// Extra-credit scores are worth 10% of a regular exam score.
// Integer division is retained to match the expected Microsoft Learn results.
const int extraCreditDivisor = 10;

// Each student's array contains five exam scores followed by
// zero or more extra-credit assignment scores.
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];

// Adding a student requires adding their name here,
// creating their score array above, and extending the selection structure below.
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

// Display the report header once before processing the students.
Console.WriteLine("STUDENT GRADING REPORT");
Console.WriteLine();
Console.WriteLine(
    $"{"Student",-12}{"Numeric Grade",15}{"Letter Grade",15}");
Console.WriteLine(new string('-', 42));

// The outer loop processes one student during each iteration.
foreach (string currentStudent in studentNames)
{
    int[] studentScores;

    // Select the score array belonging to the current student.
    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }
    else if (currentStudent == "Becky")
    {
        studentScores = beckyScores;
    }
    else if (currentStudent == "Chris")
    {
        studentScores = chrisScores;
    }
    else if (currentStudent == "Eric")
    {
        studentScores = ericScores;
    }
    else if (currentStudent == "Gregor")
    {
        studentScores = gregorScores;
    }
    else
    {
        // Skip an unknown student rather than reusing another student's scores.
        continue;
    }

    int assignmentScoreSum = 0;
    int gradedAssignmentCount = 0;

    // The inner loop processes every score belonging to the current student.
    foreach (int score in studentScores)
    {
        gradedAssignmentCount++;

        if (gradedAssignmentCount <= examAssignments)
        {
            // Regular exam scores contribute their complete value.
            assignmentScoreSum += score;
        }
        else
        {
            // Extra-credit scores contribute 10% of their original value.
            assignmentScoreSum += score / extraCreditDivisor;
        }
    }

    decimal numericGrade =
        (decimal)assignmentScoreSum / examAssignments;

    string letterGrade;

    // Thresholds are evaluated from highest to lowest.
    // The first matching branch determines the final letter grade.
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
    else if (numericGrade >= 87)
    {
        letterGrade = "B+";
    }
    else if (numericGrade >= 83)
    {
        letterGrade = "B";
    }
    else if (numericGrade >= 80)
    {
        letterGrade = "B-";
    }
    else if (numericGrade >= 77)
    {
        letterGrade = "C+";
    }
    else if (numericGrade >= 73)
    {
        letterGrade = "C";
    }
    else if (numericGrade >= 70)
    {
        letterGrade = "C-";
    }
    else if (numericGrade >= 67)
    {
        letterGrade = "D+";
    }
    else if (numericGrade >= 63)
    {
        letterGrade = "D";
    }
    else if (numericGrade >= 60)
    {
        letterGrade = "D-";
    }
    else
    {
        letterGrade = "F";
    }

    Console.WriteLine(
        $"{currentStudent,-12}{numericGrade,15:F1}{letterGrade,15}");
}