/*
 * Student Grading Report — Challenge Project
 *
 * This application processes student exam and extra-credit scores.
 * It demonstrates:
 * - arrays for related student data;
 * - nested foreach loops;
 * - if-else-if selection;
 * - running totals and assignment counters;
 * - decimal grade calculations;
 * - automatic letter-grade classification;
 * - aligned console-report formatting.
 *
 * The first five values in each score array are regular exams.
 * Any remaining values are extra-credit assignments worth 10%.
 */

const int examAssignments = 5;
const decimal extraCreditWeight = 0.10m;

// Each score array contains five exams followed by extra-credit assignments.
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

string[] studentNames =
[
    "Sophia",
    "Andrew",
    "Emma",
    "Logan"
];

Console.WriteLine("STUDENT GRADING REPORT");
Console.WriteLine();

Console.WriteLine(
    $"{"Student",-12}" +
    $"{"Exam Score",14}" +
    $"{"Overall Grade",17}" +
    $"{"Letter",10}" +
    $"{"Extra Credit",24}");

Console.WriteLine(new string('-', 77));

// The outer loop applies the same grading process to every student.
foreach (string currentStudent in studentNames)
{
    int[] studentScores;

    /*
     * Select the score array associated with the current student.
     * Unknown names are skipped so scores from a previous student
     * can never be reused accidentally.
     */
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
    else
    {
        continue;
    }

    int assignmentCount = 0;
    int extraCreditAssignmentCount = 0;

    int examScoreSum = 0;
    int extraCreditScoreSum = 0;

    /*
     * Array position determines the score type:
     * the first five values are exams and later values are extra credit.
     */
    foreach (int score in studentScores)
    {
        assignmentCount++;

        if (assignmentCount <= examAssignments)
        {
            examScoreSum += score;
        }
        else
        {
            extraCreditAssignmentCount++;
            extraCreditScoreSum += score;
        }
    }

    decimal examScore =
        (decimal)examScoreSum / examAssignments;

    decimal averageExtraCreditScore =
        extraCreditAssignmentCount > 0
            ? (decimal)extraCreditScoreSum / extraCreditAssignmentCount
            : 0m;

    /*
     * Extra-credit points are based on 10% of the extra-credit sum,
     * distributed across the five regular exam assignments.
     */
    decimal extraCreditPoints =
        extraCreditScoreSum * extraCreditWeight / examAssignments;

    decimal overallGrade =
        examScore + extraCreditPoints;

    string letterGrade;

    // Thresholds must be checked from highest to lowest.
    if (overallGrade >= 97)
    {
        letterGrade = "A+";
    }
    else if (overallGrade >= 93)
    {
        letterGrade = "A";
    }
    else if (overallGrade >= 90)
    {
        letterGrade = "A-";
    }
    else if (overallGrade >= 87)
    {
        letterGrade = "B+";
    }
    else if (overallGrade >= 83)
    {
        letterGrade = "B";
    }
    else if (overallGrade >= 80)
    {
        letterGrade = "B-";
    }
    else if (overallGrade >= 77)
    {
        letterGrade = "C+";
    }
    else if (overallGrade >= 73)
    {
        letterGrade = "C";
    }
    else if (overallGrade >= 70)
    {
        letterGrade = "C-";
    }
    else if (overallGrade >= 67)
    {
        letterGrade = "D+";
    }
    else if (overallGrade >= 63)
    {
        letterGrade = "D";
    }
    else if (overallGrade >= 60)
    {
        letterGrade = "D-";
    }
    else
    {
        letterGrade = "F";
    }

    Console.WriteLine(
        $"{currentStudent,-12}" +
        $"{examScore,14:F1}" +
        $"{overallGrade,17:F2}" +
        $"{letterGrade,10}" +
        $"{averageExtraCreditScore,12:F0} " +
        $"({extraCreditPoints:F2} pts)");
}