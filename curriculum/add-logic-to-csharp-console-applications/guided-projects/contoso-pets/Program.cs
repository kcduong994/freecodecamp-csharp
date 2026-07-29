/*
 * Guided Project:
 * Develop Conditional Branching and Looping Structures in C#
 *
 * Application:
 * Contoso Pets
 *
 * Project goals:
 * - Store pet information in a two-dimensional string array.
 * - Generate predefined sample data.
 * - Keep the main menu running until the user enters "exit".
 * - Use switch statements to select menu branches.
 * - Display all stored pet information.
 * - Add and validate one or more new pets.
 * - Demonstrate for, while, do-while, if, switch, nullable input,
 *   variable scope, and zero-based array indexing.
 *
 * Guided-project scope:
 * - Menu option 1 is fully implemented.
 * - Menu option 2 is fully implemented.
 * - Menu options 3 through 8 remain placeholders for later modules.
 */

namespace ContosoPets;

internal static class Program
{
    /*
     * Array dimensions:
     * - Each row represents one pet.
     * - Each column represents one characteristic of that pet.
     */
    private const int MaxPets = 8;
    private const int CharacteristicCount = 6;

    /*
     * Named column indexes avoid unexplained numeric literals.
     *
     * animals[row, PetIdColumn] is clearer than animals[row, 0].
     */
    private const int PetIdColumn = 0;
    private const int SpeciesColumn = 1;
    private const int AgeColumn = 2;
    private const int NicknameColumn = 3;
    private const int PhysicalDescriptionColumn = 4;
    private const int PersonalityDescriptionColumn = 5;

    /*
     * Empty rows contain field labels because this guided project stores
     * display-ready strings directly in the array.
     */
    private const string EmptyPetId = "ID #: ";

    private static void Main()
    {
        /*
         * Data is stored only in memory. Closing the program removes pets that
         * were entered during the current session.
         */
        string[,] ourAnimals = new string[MaxPets, CharacteristicCount];

        PopulateSampleData(ourAnimals);
        RunApplication(ourAnimals);
    }

    /// <summary>
    /// Populates four sample pets and initializes the remaining array rows.
    /// </summary>
    /// <param name="animals">The runtime pet-data array.</param>
    private static void PopulateSampleData(string[,] animals)
    {
        string animalSpecies;
        string animalId;
        string animalAge;
        string animalPhysicalDescription;
        string animalPersonalityDescription;
        string animalNickname;

        /*
         * Arrays are zero indexed.
         *
         * An array containing eight rows has valid row indexes 0 through 7.
         * GetLength(0) returns the number of rows, not the last valid index.
         */
        for (int row = 0; row < animals.GetLength(0); row++)
        {
            /*
             * The switch statement creates sample data for rows 0 through 3.
             * The default branch initializes all unused rows.
             */
            switch (row)
            {
                case 0:
                    animalSpecies = "dog";
                    animalId = "d1";
                    animalAge = "2";
                    animalPhysicalDescription =
                        "medium sized cream colored female golden retriever " +
                        "weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription =
                        "loves to have her belly rubbed and likes to chase " +
                        "her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalId = "d2";
                    animalAge = "9";
                    animalPhysicalDescription =
                        "large reddish-brown male golden retriever weighing " +
                        "about 85 pounds. housebroken.";
                    animalPersonalityDescription =
                        "loves to have his ears rubbed when he greets you at " +
                        "the door, or at any time! loves to lean-in and give " +
                        "doggy hugs.";
                    animalNickname = "loki";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalId = "c3";
                    animalAge = "1";
                    animalPhysicalDescription =
                        "small white female weighing about 8 pounds. " +
                        "litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "puss";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalId = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = string.Empty;
                    animalPersonalityDescription = string.Empty;
                    animalNickname = string.Empty;
                    break;

                default:
                    animalSpecies = string.Empty;
                    animalId = string.Empty;
                    animalAge = string.Empty;
                    animalPhysicalDescription = string.Empty;
                    animalPersonalityDescription = string.Empty;
                    animalNickname = string.Empty;
                    break;
            }

            /*
             * The first index selects a pet row.
             * The second index selects one characteristic column.
             */
            animals[row, PetIdColumn] = $"ID #: {animalId}";
            animals[row, SpeciesColumn] = $"Species: {animalSpecies}";
            animals[row, AgeColumn] = $"Age: {animalAge}";
            animals[row, NicknameColumn] = $"Nickname: {animalNickname}";
            animals[row, PhysicalDescriptionColumn] =
                $"Physical description: {animalPhysicalDescription}";
            animals[row, PersonalityDescriptionColumn] =
                $"Personality: {animalPersonalityDescription}";
        }
    }

    /// <summary>
    /// Runs the main menu until the normalized selection equals "exit".
    /// </summary>
    /// <param name="animals">The shared runtime pet-data array.</param>
    private static void RunApplication(string[,] animals)
    {
        string menuSelection;

        /*
         * do-while is appropriate because the menu must appear at least once.
         */
        do
        {
            DisplayMainMenu();
            menuSelection = ReadMenuSelection();

            /*
             * menuSelection is a string, so the case labels are strings such as
             * case "1": rather than integer labels such as case 1:.
             */
            switch (menuSelection)
            {
                case "1":
                    ListAllPets(animals);
                    PauseBeforeReturningToMenu();
                    break;

                case "2":
                    AddNewPets(animals);
                    PauseBeforeReturningToMenu();
                    break;

                case "3":
                    ShowChallengeProjectPlaceholder(
                        "Ensure animal ages and physical descriptions are complete");
                    break;

                case "4":
                    ShowChallengeProjectPlaceholder(
                        "Ensure animal nicknames and personality descriptions are complete");
                    break;

                case "5":
                    ShowUnderConstructionPlaceholder("Edit an animal's age");
                    break;

                case "6":
                    ShowUnderConstructionPlaceholder(
                        "Edit an animal's personality description");
                    break;

                case "7":
                    ShowUnderConstructionPlaceholder(
                        "Display all cats with a specified characteristic");
                    break;

                case "8":
                    ShowUnderConstructionPlaceholder(
                        "Display all dogs with a specified characteristic");
                    break;

                case "exit":
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using Contoso PetFriends.");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine(
                        $"\"{menuSelection}\" is not a valid menu option.");
                    PauseBeforeReturningToMenu();
                    break;
            }
        }
        while (menuSelection != "exit");
    }

    /// <summary>
    /// Displays all available application commands.
    /// </summary>
    private static void DisplayMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine(
            "Welcome to the Contoso PetFriends app. " +
            "Your main menu options are:");
        Console.WriteLine();
        Console.WriteLine(" 1. List all of our current pet information");
        Console.WriteLine(
            " 2. Add a new animal friend to the ourAnimals array");
        Console.WriteLine(
            " 3. Ensure animal ages and physical descriptions are complete");
        Console.WriteLine(
            " 4. Ensure animal nicknames and personality descriptions are complete");
        Console.WriteLine(" 5. Edit an animal's age");
        Console.WriteLine(" 6. Edit an animal's personality description");
        Console.WriteLine(
            " 7. Display all cats with a specified characteristic");
        Console.WriteLine(
            " 8. Display all dogs with a specified characteristic");
        Console.WriteLine();
        Console.WriteLine(
            "Enter your selection number " +
            "(or type \"Exit\" to exit the program):");
    }

    /// <summary>
    /// Reads and normalizes a top-level menu selection.
    /// </summary>
    /// <returns>
    /// A trimmed lower-case value. Null input is treated as "exit".
    /// </returns>
    private static string ReadMenuSelection()
    {
        /*
         * Console.ReadLine() returns string?.
         *
         * The null-coalescing operator supplies "exit" if no console input is
         * available. Normalization makes Exit, EXIT, and exit equivalent.
         */
        return (Console.ReadLine() ?? "exit")
            .Trim()
            .ToLowerInvariant();
    }

    /// <summary>
    /// Displays every characteristic for each occupied pet row.
    /// </summary>
    /// <param name="animals">The pet-data array.</param>
    private static void ListAllPets(string[,] animals)
    {
        Console.WriteLine();
        Console.WriteLine("CURRENT PET INFORMATION");
        Console.WriteLine("=======================");

        int displayedPetCount = 0;

        /*
         * The outer loop processes one pet row at a time.
         *
         * A foreach over a rectangular two-dimensional array would flatten the
         * array into 48 individual strings. Nested for loops preserve the
         * relationship between one pet row and its six characteristics.
         */
        for (int row = 0; row < animals.GetLength(0); row++)
        {
            if (!HasPetData(animals, row))
            {
                continue;
            }

            displayedPetCount++;
            Console.WriteLine();

            /*
             * The inner loop completes all six columns before the outer loop
             * advances to the next pet.
             */
            for (
                int column = 0;
                column < animals.GetLength(1);
                column++)
            {
                Console.WriteLine(animals[row, column]);
            }
        }

        if (displayedPetCount == 0)
        {
            Console.WriteLine();
            Console.WriteLine("No pets are currently stored.");
        }
    }

    /// <summary>
    /// Adds validated pet records until the user stops or capacity is reached.
    /// </summary>
    /// <param name="animals">The pet-data array.</param>
    private static void AddNewPets(string[,] animals)
    {
        int petCount = CountPets(animals);

        Console.WriteLine();
        Console.WriteLine("ADD A NEW PET");
        Console.WriteLine("=============");

        if (petCount >= animals.GetLength(0))
        {
            Console.WriteLine(
                "We have reached our limit on the number of pets " +
                "that we can manage.");
            return;
        }

        Console.WriteLine(
            $"We currently have {petCount} pets that need homes. " +
            $"We can manage {animals.GetLength(0) - petCount} more.");

        string anotherPet = "y";

        /*
         * Both conditions must remain true:
         * - the user wants to continue;
         * - the array still has an empty row.
         */
        while (
            anotherPet == "y" &&
            petCount < animals.GetLength(0))
        {
            string animalSpecies = ReadAnimalSpecies();

            /*
             * petCount is the number of occupied rows and also the index of the
             * next empty row because occupied rows are stored contiguously.
             *
             * Four existing pets occupy indexes 0-3, so petCount == 4 and the
             * fifth pet is stored at row index 4.
             */
            string animalId =
                animalSpecies[..1] +
                (petCount + 1).ToString();

            string animalAge = ReadAnimalAge();

            string animalPhysicalDescription = ReadOptionalDescription(
                "Enter a physical description of the pet " +
                "(size, color, gender, weight, housebroken):");

            string animalPersonalityDescription = ReadOptionalDescription(
                "Enter a description of the pet's personality " +
                "(likes or dislikes, tricks, energy level):");

            string animalNickname = ReadOptionalDescription(
                "Enter a nickname for the pet:");

            /*
             * Save before incrementing petCount because petCount currently
             * identifies the next available zero-based row.
             */
            SavePet(
                animals,
                petCount,
                animalId,
                animalSpecies,
                animalAge,
                animalNickname,
                animalPhysicalDescription,
                animalPersonalityDescription);

            Console.WriteLine();
            Console.WriteLine($"Pet {animalId} was added successfully.");

            petCount++;

            if (petCount < animals.GetLength(0))
            {
                anotherPet = ReadYesOrNo(
                    "Do you want to enter information for another pet (y/n)?");
            }
        }

        if (petCount >= animals.GetLength(0))
        {
            Console.WriteLine();
            Console.WriteLine(
                "We have reached our limit on the number of pets " +
                "that we can manage.");
        }
    }

    /// <summary>
    /// Counts rows that contain assigned pet data.
    /// </summary>
    private static int CountPets(string[,] animals)
    {
        int petCount = 0;

        for (int row = 0; row < animals.GetLength(0); row++)
        {
            if (HasPetData(animals, row))
            {
                petCount++;
            }
        }

        return petCount;
    }

    /// <summary>
    /// Returns true when the specified row contains an assigned pet ID.
    /// </summary>
    private static bool HasPetData(string[,] animals, int row)
    {
        return animals[row, PetIdColumn] != EmptyPetId;
    }

    /// <summary>
    /// Reads a required species and accepts only "dog" or "cat".
    /// </summary>
    private static string ReadAnimalSpecies()
    {
        string animalSpecies;
        bool validEntry;

        do
        {
            Console.WriteLine();
            Console.WriteLine(
                "Enter \"dog\" or \"cat\" to begin a new entry:");

            animalSpecies = (Console.ReadLine() ?? string.Empty)
                .Trim()
                .ToLowerInvariant();

            validEntry =
                animalSpecies == "dog" ||
                animalSpecies == "cat";

            if (!validEntry)
            {
                Console.WriteLine(
                    "Invalid species. Please enter only \"dog\" or \"cat\".");
            }
        }
        while (!validEntry);

        return animalSpecies;
    }

    /// <summary>
    /// Reads "?" or a non-negative whole-number age.
    /// </summary>
    private static string ReadAnimalAge()
    {
        string animalAge;
        bool validEntry;

        do
        {
            Console.WriteLine(
                "Enter the pet's age, or enter \"?\" if it is unknown:");

            animalAge = (Console.ReadLine() ?? string.Empty).Trim();

            /*
             * TryParse validates numeric text without throwing an exception.
             * Negative values are rejected because they cannot represent age.
             */
            validEntry =
                animalAge == "?" ||
                (
                    int.TryParse(animalAge, out int petAge) &&
                    petAge >= 0
                );

            if (!validEntry)
            {
                Console.WriteLine(
                    "Invalid age. Enter \"?\" or a non-negative whole number.");
            }
        }
        while (!validEntry);

        return animalAge;
    }

    /// <summary>
    /// Reads optional text and substitutes "tbd" for blank or null input.
    /// </summary>
    private static string ReadOptionalDescription(string prompt)
    {
        Console.WriteLine(prompt);

        string value = (Console.ReadLine() ?? string.Empty)
            .Trim()
            .ToLowerInvariant();

        /*
         * "tbd" means "to be determined" and represents information that may
         * become available after examination or observation.
         */
        return value.Length == 0
            ? "tbd"
            : value;
    }

    /// <summary>
    /// Reads and validates a yes/no response.
    /// </summary>
    private static string ReadYesOrNo(string prompt)
    {
        string response;

        do
        {
            Console.WriteLine();
            Console.WriteLine(prompt);

            response = (Console.ReadLine() ?? string.Empty)
                .Trim()
                .ToLowerInvariant();

            if (response != "y" && response != "n")
            {
                Console.WriteLine(
                    "Invalid response. Please enter \"y\" or \"n\".");
            }
        }
        while (response != "y" && response != "n");

        return response;
    }

    /// <summary>
    /// Stores one pet as six formatted strings in the selected row.
    /// </summary>
    private static void SavePet(
        string[,] animals,
        int row,
        string animalId,
        string animalSpecies,
        string animalAge,
        string animalNickname,
        string animalPhysicalDescription,
        string animalPersonalityDescription)
    {
        animals[row, PetIdColumn] = $"ID #: {animalId}";
        animals[row, SpeciesColumn] = $"Species: {animalSpecies}";
        animals[row, AgeColumn] = $"Age: {animalAge}";
        animals[row, NicknameColumn] = $"Nickname: {animalNickname}";
        animals[row, PhysicalDescriptionColumn] =
            $"Physical description: {animalPhysicalDescription}";
        animals[row, PersonalityDescriptionColumn] =
            $"Personality: {animalPersonalityDescription}";
    }

    /// <summary>
    /// Displays a placeholder for features assigned to the later challenge.
    /// </summary>
    private static void ShowChallengeProjectPlaceholder(string featureName)
    {
        Console.WriteLine();
        Console.WriteLine(featureName);
        Console.WriteLine(
            "Challenge Project - please check back soon to see progress.");
        PauseBeforeReturningToMenu();
    }

    /// <summary>
    /// Displays a placeholder for features not yet implemented.
    /// </summary>
    private static void ShowUnderConstructionPlaceholder(string featureName)
    {
        Console.WriteLine();
        Console.WriteLine(featureName);
        Console.WriteLine(
            "UNDER CONSTRUCTION - please check back next month to see progress.");
        PauseBeforeReturningToMenu();
    }

    /// <summary>
    /// Pauses so the user can read output before the menu appears again.
    /// </summary>
    private static void PauseBeforeReturningToMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Press the Enter key to continue.");
        _ = Console.ReadLine();
    }
}