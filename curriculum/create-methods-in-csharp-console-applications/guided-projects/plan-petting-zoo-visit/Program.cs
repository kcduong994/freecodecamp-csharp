// ============================================================================
// Guided Project: Plan a Petting Zoo Visit
// Learning path: Create Methods in C# Console Applications
//
// Scenario:
// The Contoso Petting Zoo has 18 animal species. Three schools are visiting:
//
// - School A -> 6 groups (default)
// - School B -> 3 groups
// - School C -> 2 groups
//
// For every school, the application must:
// 1. randomize the animal order;
// 2. divide the animals into the required number of groups;
// 3. print the school name;
// 4. print the animals assigned to each group.
//
// This guided project combines the three method concepts learned previously:
//
//     named methods
//          +
//     parameters / arguments
//          +
//     return values
//          =
//     a complete application workflow
//
// Core data flow:
//
// school name + group count
//          ↓
// PlanSchoolVisit(...)
//          ↓
// RandomizeAnimals()
//          ↓
// AssignGroup(...)
//          ↓
// string[,] group
//          ↓
// PrintGroup(...)
//          ↓
// console output
//
// Source basis:
// Microsoft Learn — Guided Project: Plan a Petting Zoo Visit.
// The implementation intentionally stays close to the lesson design while
// adding comments that explain method contracts, control flow, data flow,
// array dimensions, and the reason behind each algorithmic step.
// ============================================================================


// ============================================================================
// APPLICATION DATA
// ============================================================================

// The petting zoo currently contains 18 different animal species.
//
// This array is shared by the methods below:
// - RandomizeAnimals() mutates its order.
// - AssignGroup(...) reads the current randomized order.
//
// The array contains reference-type string values, while the array itself is
// also a reference type. The methods operate on the same array object declared
// here in the top-level program scope.
string[] pettingZoo =
{
    "alpacas",
    "capybaras",
    "chickens",
    "ducks",
    "emus",
    "geese",
    "goats",
    "iguanas",
    "kangaroos",
    "lemurs",
    "llamas",
    "macaws",
    "ostriches",
    "pigs",
    "ponies",
    "rabbits",
    "sheep",
    "tortoises",
};


// ============================================================================
// TOP-LEVEL APPLICATION FLOW
// ============================================================================
//
// The three calls below describe the complete business requirement.
//
// School A omits the optional `groups` argument, so PlanSchoolVisit() uses its
// default value of 6.
//
// School B and School C explicitly override the default group count.
//
// The same workflow is reused for every school. Only the input data changes.
// ============================================================================

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


// ============================================================================
// METHOD: PlanSchoolVisit
// ============================================================================

void PlanSchoolVisit(
    string schoolName,
    int groups = 6)
{
    // Method contract:
    //
    // INPUT
    // schoolName -> name displayed for the current school.
    // groups     -> number of student groups.
    //               Optional parameter with default value 6.
    //
    // PROCESSING
    // 1. Randomize the shared animal array.
    // 2. Divide the randomized animals into the requested number of groups.
    // 3. Display the school name.
    // 4. Display the group assignments.
    //
    // OUTPUT
    // This is a void method, so it does not return a value.
    // Its visible output is written to the console.

    RandomizeAnimals();

    // AssignGroup(...) returns a two-dimensional string array.
    // The returned value is captured in `group` and then passed to PrintGroup().
    string[,] group =
        AssignGroup(groups);

    Console.WriteLine(schoolName);

    PrintGroup(group);
}


// ============================================================================
// METHOD: RandomizeAnimals
// ============================================================================

void RandomizeAnimals()
{
    // Method contract:
    //
    // INPUT
    // No explicit parameters.
    //
    // The method uses the shared `pettingZoo` array from the top-level scope.
    //
    // PROCESSING
    // Shuffle the array in-place by selecting a random position from the
    // current index through the final index and swapping the two values.
    //
    // OUTPUT
    // No return value.
    // The observable result is the changed order of the shared array.

    Random random =
        new();

    // At each iteration:
    // 1. `i` identifies the current position.
    // 2. `r` selects a random position from i through the end of the array.
    // 3. The values at i and r are swapped.
    //
    // The range begins at i because positions below i have already been
    // finalized by earlier iterations.
    for (
        int i = 0;
        i < pettingZoo.Length;
        i++)
    {
        // Random.Next(minValue, maxValue) includes minValue and excludes
        // maxValue, so r is always a valid array index.
        int r =
            random.Next(
                i,
                pettingZoo.Length);

        // A temporary variable preserves the original value while the two
        // array elements exchange places.
        string temp =
            pettingZoo[r];

        pettingZoo[r] =
            pettingZoo[i];

        pettingZoo[i] =
            temp;
    }
}


// ============================================================================
// METHOD: AssignGroup
// ============================================================================

string[,] AssignGroup(int groups = 6)
{
    // Method contract:
    //
    // INPUT
    // groups -> requested number of groups.
    //           Optional parameter; default = 6.
    //
    // OUTPUT
    // string[,] -> two-dimensional array of group assignments.
    //
    // Dimensions:
    // dimension 0 = number of groups
    // dimension 1 = animals per group
    //
    // School A: 18 / 6 = 3  -> [6, 3]
    // School B: 18 / 3 = 6  -> [3, 6]
    // School C: 18 / 2 = 9  -> [2, 9]

    // The guided project uses only group counts that divide 18 exactly.
    // Therefore this implementation assumes:
    //
    // pettingZoo.Length % groups == 0
    string[,] result =
        new string[
            groups,
            pettingZoo.Length / groups];

    // `start` tracks the next animal in the one-dimensional source array.
    // It advances continuously even though the destination uses two indices.
    int start = 0;

    // Outer loop -> each student group / row.
    for (
        int i = 0;
        i < groups;
        i++)
    {
        // Inner loop -> each animal slot / column in the current group.
        for (
            int j = 0;
            j < result.GetLength(1);
            j++)
        {
            // `start++` uses the current index, then increments it.
            result[i, j] =
                pettingZoo[start++];
        }
    }

    // The completed 2D array becomes the return value of the method.
    return result;
}


// ============================================================================
// METHOD: PrintGroup
// ============================================================================

void PrintGroup(string[,] groups)
{
    // Method contract:
    //
    // INPUT
    // groups -> two-dimensional animal assignment array.
    //
    // PROCESSING
    // Traverse rows and columns.
    //
    // OUTPUT
    // Console text only; the method itself returns no value.

    // GetLength(0) -> number of rows / groups.
    for (
        int i = 0;
        i < groups.GetLength(0);
        i++)
    {
        // Human-readable group numbering starts at 1, while array indexing
        // starts at 0.
        Console.Write(
            $"Group {i + 1}: ");

        // GetLength(1) -> number of columns / animals per group.
        for (
            int j = 0;
            j < groups.GetLength(1);
            j++)
        {
            Console.Write(
                $"{groups[i, j]}  ");
        }

        Console.WriteLine();
    }
}


// ============================================================================
// GUIDED PROJECT SUMMARY
// ============================================================================
//
// PSEUDO-CODE TO METHODS
//
// Randomize animals
//     ↓
// RandomizeAnimals()
//
// Assign animals to groups
//     ↓
// AssignGroup(...)
//
// Print assignments
//     ↓
// PrintGroup(...)
//
// Coordinate the complete visit
//     ↓
// PlanSchoolVisit(...)
//
// OPTIONAL PARAMETERS
//
// PlanSchoolVisit("School A");
// → groups defaults to 6
//
// PlanSchoolVisit("School B", 3);
// → groups is explicitly 3
//
// RETURN VALUES
//
// AssignGroup(...)
//     ↓
// returns string[,]
//     ↓
// captured in `group`
//
// PARAMETERS AND ARGUMENTS
//
// PlanSchoolVisit("School C", 2);
//
// arguments:
// "School C"
// 2
//
// parameters:
// schoolName
// groups
//
// METHOD COMPOSITION
//
// PlanSchoolVisit(...)
//     ↓
// RandomizeAnimals()
//     ↓
// AssignGroup(...)
//     ↓
// PrintGroup(...)
//
// The project demonstrates how a larger application workflow can be assembled
// from smaller methods with focused responsibilities.
// ============================================================================