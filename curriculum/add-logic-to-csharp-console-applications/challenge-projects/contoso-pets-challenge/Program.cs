using System;

/*
 * Challenge Project: Develop Branching and Looping Structures in C#
 * -----------------------------------------------------------------
 * Application: Contoso PetFriends
 *
 * Learning goals demonstrated in this file:
 *   - Selection: if, else, switch
 *   - Iteration: for, while, do-while
 *   - Flow control: continue, break, return
 *   - Input validation: int.TryParse, string.IsNullOrWhiteSpace
 *   - Variable scope: constants, local variables, method parameters
 *
 * Challenge scope:
 *   - Menu option 1: list existing pet records.
 *   - Menu option 2: add a new pet record.
 *   - Menu option 3: complete missing ages and physical descriptions.
 *   - Menu option 4: complete missing nicknames and personality descriptions.
 *
 * Menu options 5-8 intentionally remain under construction because they are
 * displayed by the starter application but are outside this challenge's
 * required implementation.
 */
internal static class Program
{
    // ---------------------------------------------------------------------
    // Array configuration
    // ---------------------------------------------------------------------

    // The application can hold no more than eight pet records at runtime.
    private const int MaxPets = 8;

    // Each row contains six fields. Named column constants avoid unexplained
    // numeric indexes such as ourAnimals[i, 4] throughout the application.
    private const int FieldCount = 6;
    private const int PetIdColumn = 0;
    private const int SpeciesColumn = 1;
    private const int AgeColumn = 2;
    private const int NicknameColumn = 3;
    private const int PhysicalDescriptionColumn = 4;
    private const int PersonalityDescriptionColumn = 5;

    // ---------------------------------------------------------------------
    // Display labels stored together with each field value
    // ---------------------------------------------------------------------

    private const string PetIdLabel = "ID #: ";
    private const string SpeciesLabel = "Species: ";
    private const string AgeLabel = "Age: ";
    private const string NicknameLabel = "Nickname: ";
    private const string PhysicalDescriptionLabel = "Physical description: ";
    private const string PersonalityDescriptionLabel = "Personality: ";

    // The starter application uses these values when information is unknown.
    private const string UnknownAge = "?";
    private const string ToBeDetermined = "tbd";

    // The two-dimensional array stores data only while the program is running.
    // No file or database persistence is implemented in this challenge.
    private static readonly string[,] OurAnimals =
        new string[MaxPets, FieldCount];

    private static void Main()
    {
        InitializeAnimalRecords();
        RunMainMenu();
    }

    // =====================================================================
    // APPLICATION STARTUP
    // =====================================================================

    /// <summary>
    /// Creates the starter dataset and initializes every array cell.
    /// Empty rows receive labels with empty values, for example "ID #: ".
    /// </summary>
    private static void InitializeAnimalRecords()
    {
        for (int i = 0; i < MaxPets; i++)
        {
            string animalSpecies;
            string animalId;
            string animalAge;
            string animalNickname;
            string animalPhysicalDescription;
            string animalPersonalityDescription;

            // The switch selects a predefined record based on the row index.
            // Rows not explicitly configured fall through to default and are
            // initialized as empty slots.
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalId = "d1";
                    animalAge = "2";
                    animalNickname = "lola";
                    animalPhysicalDescription =
                        "medium sized cream colored female golden retriever " +
                        "weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription =
                        "loves to have her belly rubbed and likes to chase " +
                        "her tail. gives lots of kisses.";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalId = "d2";
                    animalAge = "9";
                    animalNickname = "loki";
                    animalPhysicalDescription =
                        "large reddish-brown male golden retriever weighing " +
                        "about 85 pounds. housebroken.";
                    animalPersonalityDescription =
                        "loves to have his ears rubbed when he greets you at " +
                        "the door, or at any time! loves to lean-in and give " +
                        "doggy hugs.";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalId = "c3";
                    animalAge = "1";
                    animalNickname = "puss";
                    animalPhysicalDescription =
                        "small white female weighing about 8 pounds. " +
                        "litter box trained.";
                    animalPersonalityDescription = "friendly";
                    break;

                case 3:
                    // This record intentionally contains incomplete data so
                    // menu options 3 and 4 have information to validate.
                    animalSpecies = "cat";
                    animalId = "c4";
                    animalAge = UnknownAge;
                    animalNickname = string.Empty;
                    animalPhysicalDescription = string.Empty;
                    animalPersonalityDescription = string.Empty;
                    break;

                default:
                    animalSpecies = string.Empty;
                    animalId = string.Empty;
                    animalAge = string.Empty;
                    animalNickname = string.Empty;
                    animalPhysicalDescription = string.Empty;
                    animalPersonalityDescription = string.Empty;
                    break;
            }

            StoreAnimalRecord(
                i,
                animalId,
                animalSpecies,
                animalAge,
                animalNickname,
                animalPhysicalDescription,
                animalPersonalityDescription);
        }
    }

    /// <summary>
    /// Writes one complete row to the array using the application's standard
    /// display labels.
    /// </summary>
    private static void StoreAnimalRecord(
        int rowIndex,
        string animalId,
        string animalSpecies,
        string animalAge,
        string animalNickname,
        string animalPhysicalDescription,
        string animalPersonalityDescription)
    {
        OurAnimals[rowIndex, PetIdColumn] = PetIdLabel + animalId;
        OurAnimals[rowIndex, SpeciesColumn] = SpeciesLabel + animalSpecies;
        OurAnimals[rowIndex, AgeColumn] = AgeLabel + animalAge;
        OurAnimals[rowIndex, NicknameColumn] = NicknameLabel + animalNickname;
        OurAnimals[rowIndex, PhysicalDescriptionColumn] =
            PhysicalDescriptionLabel + animalPhysicalDescription;
        OurAnimals[rowIndex, PersonalityDescriptionColumn] =
            PersonalityDescriptionLabel + animalPersonalityDescription;
    }

    // =====================================================================
    // MAIN MENU AND BRANCHING
    // =====================================================================

    /// <summary>
    /// Repeatedly displays the menu and routes the user's selection to the
    /// corresponding feature. The loop stops only when the user enters exit.
    /// </summary>
    private static void RunMainMenu()
    {
        string menuSelection;

        do
        {
            Console.Clear();
            DisplayMainMenu();

            // ReadLine can return null. The null-coalescing operator converts
            // that result to an empty string before normalization.
            menuSelection = (Console.ReadLine() ?? string.Empty)
                .Trim()
                .ToLowerInvariant();

            switch (menuSelection)
            {
                case "1":
                    DisplayAllAnimals();
                    break;

                case "2":
                    AddNewAnimals();
                    break;

                case "3":
                    EnsureAgesAndPhysicalDescriptionsAreComplete();
                    break;

                case "4":
                    EnsureNicknamesAndPersonalitiesAreComplete();
                    break;

                case "5":
                    ShowUnderConstruction("Edit an animal's age");
                    break;

                case "6":
                    ShowUnderConstruction(
                        "Edit an animal's personality description");
                    break;

                case "7":
                    ShowUnderConstruction(
                        "Display cats with a specified characteristic");
                    break;

                case "8":
                    ShowUnderConstruction(
                        "Display dogs with a specified characteristic");
                    break;

                case "exit":
                    // No feature runs. The do-while condition ends the loop.
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine(
                        "Invalid selection. Enter a number from 1 to 8, " +
                        "or type Exit.");
                    Pause();
                    break;
            }
        }
        while (menuSelection != "exit");

        Console.WriteLine();
        Console.WriteLine("Thank you for using Contoso PetFriends.");
    }

    private static void DisplayMainMenu()
    {
        Console.WriteLine(
            "Welcome to the Contoso PetFriends app. " +
            "Your main menu options are:");
        Console.WriteLine(" 1. List all of our current pet information");
        Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
        Console.WriteLine(
            " 3. Ensure animal ages and physical descriptions are complete");
        Console.WriteLine(
            " 4. Ensure animal nicknames and personality descriptions " +
            "are complete");
        Console.WriteLine(" 5. Edit an animal's age");
        Console.WriteLine(" 6. Edit an animal's personality description");
        Console.WriteLine(
            " 7. Display all cats with a specified characteristic");
        Console.WriteLine(
            " 8. Display all dogs with a specified characteristic");
        Console.WriteLine();
        Console.WriteLine(
            "Enter your selection number (or type Exit to exit the program)");
    }

    // =====================================================================
    // MENU OPTION 1: LIST EXISTING RECORDS
    // =====================================================================

    private static void DisplayAllAnimals()
    {
        Console.Clear();
        Console.WriteLine("Current Contoso PetFriends records:");

        bool foundAnimal = false;

        for (int i = 0; i < MaxPets; i++)
        {
            // continue skips the rest of this iteration but keeps the for loop
            // running so later rows are still checked.
            if (!IsOccupiedRow(i))
            {
                continue;
            }

            foundAnimal = true;
            Console.WriteLine();

            for (int field = 0; field < FieldCount; field++)
            {
                Console.WriteLine(OurAnimals[i, field]);
            }
        }

        if (!foundAnimal)
        {
            Console.WriteLine();
            Console.WriteLine("No animal records are currently available.");
        }

        Pause();
    }

    // =====================================================================
    // MENU OPTION 2: ADD NEW RECORDS
    // =====================================================================

    private static void AddNewAnimals()
    {
        Console.Clear();

        int petCount = CountOccupiedRows();

        if (petCount >= MaxPets)
        {
            Console.WriteLine(
                "We have reached the maximum number of pets that we can " +
                "manage.");
            Pause();
            return;
        }

        Console.WriteLine(
            $"We currently have {petCount} pets that need homes. " +
            $"We can manage {MaxPets - petCount} more.");

        string anotherPet = "y";

        // The while condition combines two independent requirements:
        // the user wants to continue, and the array still has free capacity.
        while (anotherPet == "y" && petCount < MaxPets)
        {
            int targetRow = FindFirstEmptyRow();

            // Defensive guard: this should not occur because petCount was
            // checked, but it prevents an invalid array index if the dataset
            // becomes inconsistent in a future revision.
            if (targetRow == -1)
            {
                break;
            }

            string animalSpecies = PromptForSpecies();
            string animalId =
                animalSpecies[..1] + (petCount + 1).ToString();
            string animalAge = PromptForAgeOrUnknown();

            // Blank optional fields are stored as "tbd". Options 3 and 4
            // later treat "tbd" as incomplete and request final information.
            string animalPhysicalDescription = PromptForOptionalText(
                "Enter a physical description of the pet " +
                "(size, color, gender, weight, housebroken)");

            string animalPersonalityDescription = PromptForOptionalText(
                "Enter a description of the pet's personality " +
                "(likes or dislikes, tricks, energy level)");

            string animalNickname = PromptForOptionalText(
                "Enter a nickname for the pet");

            StoreAnimalRecord(
                targetRow,
                animalId,
                animalSpecies,
                animalAge,
                animalNickname,
                animalPhysicalDescription,
                animalPersonalityDescription);

            petCount++;

            Console.WriteLine();
            Console.WriteLine(
                $"Pet record {animalId} was added successfully.");

            if (petCount < MaxPets)
            {
                anotherPet = PromptForYesOrNo(
                    "Do you want to enter information for another pet (y/n)?");
            }
        }

        if (petCount >= MaxPets)
        {
            Console.WriteLine();
            Console.WriteLine(
                "We have reached the maximum number of pets that we can " +
                "manage.");
        }

        Pause();
    }

    private static string PromptForSpecies()
    {
        string animalSpecies;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry:");

            animalSpecies = (Console.ReadLine() ?? string.Empty)
                .Trim()
                .ToLowerInvariant();

            if (animalSpecies != "dog" && animalSpecies != "cat")
            {
                Console.WriteLine(
                    "Invalid species. Enter exactly 'dog' or 'cat'.");
            }
        }
        while (animalSpecies != "dog" && animalSpecies != "cat");

        return animalSpecies;
    }

    private static string PromptForAgeOrUnknown()
    {
        string animalAge;
        bool validEntry;

        do
        {
            Console.WriteLine();
            Console.WriteLine(
                "Enter the pet's age, or enter ? if the age is unknown:");

            animalAge = (Console.ReadLine() ?? string.Empty).Trim();

            validEntry =
                animalAge == UnknownAge ||
                int.TryParse(animalAge, out _);

            if (!validEntry)
            {
                Console.WriteLine(
                    "Invalid age. Enter a whole number or the ? character.");
            }
        }
        while (!validEntry);

        return animalAge;
    }

    private static string PromptForOptionalText(string prompt)
    {
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine(
            "Press Enter without typing a value to store it as 'tbd'.");

        string value = (Console.ReadLine() ?? string.Empty).Trim();

        return string.IsNullOrWhiteSpace(value)
            ? ToBeDetermined
            : value.ToLowerInvariant();
    }

    private static string PromptForYesOrNo(string prompt)
    {
        string answer;

        do
        {
            Console.WriteLine();
            Console.WriteLine(prompt);

            answer = (Console.ReadLine() ?? string.Empty)
                .Trim()
                .ToLowerInvariant();

            if (answer != "y" && answer != "n")
            {
                Console.WriteLine("Invalid answer. Enter y or n.");
            }
        }
        while (answer != "y" && answer != "n");

        return answer;
    }

    // =====================================================================
    // MENU OPTION 3: COMPLETE AGE AND PHYSICAL DESCRIPTION
    // =====================================================================

    private static void EnsureAgesAndPhysicalDescriptionsAreComplete()
    {
        Console.Clear();

        for (int i = 0; i < MaxPets; i++)
        {
            // Empty rows represent unused array capacity and must not prompt
            // the user for animal information.
            if (!IsOccupiedRow(i))
            {
                continue;
            }

            string petId = OurAnimals[i, PetIdColumn];
            string currentAge = ExtractValue(
                OurAnimals[i, AgeColumn],
                AgeLabel);

            // TryParse validates the value without throwing an exception.
            // If the stored age is "?", blank, or nonnumeric, prompt until
            // the user enters a value that can be converted to int.
            if (!int.TryParse(currentAge, out _))
            {
                string enteredAge;
                bool validAge;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter an age for {petId}:");

                    enteredAge =
                        (Console.ReadLine() ?? string.Empty).Trim();

                    validAge = int.TryParse(enteredAge, out _);

                    if (!validAge)
                    {
                        Console.WriteLine(
                            "Invalid age. Enter a whole numeric value, " +
                            "for example 1 or 7.");
                    }
                }
                while (!validAge);

                OurAnimals[i, AgeColumn] = AgeLabel + enteredAge;
            }

            string currentPhysicalDescription = ExtractValue(
                OurAnimals[i, PhysicalDescriptionColumn],
                PhysicalDescriptionLabel);

            // Besides null and empty input, this implementation considers
            // the placeholder "tbd" incomplete. That is an allowed extra
            // validation rule and ensures the record contains real details.
            if (IsIncompleteText(currentPhysicalDescription))
            {
                string enteredPhysicalDescription = PromptForRequiredText(
                    $"Enter a physical description for {petId} " +
                    "(size, color, breed, gender, weight, housebroken):");

                OurAnimals[i, PhysicalDescriptionColumn] =
                    PhysicalDescriptionLabel +
                    enteredPhysicalDescription.ToLowerInvariant();
            }
        }

        Console.WriteLine();
        Console.WriteLine(
            "Age and physical description fields are complete for all " +
            "of our friends.");
        Pause();
    }

    // =====================================================================
    // MENU OPTION 4: COMPLETE NICKNAME AND PERSONALITY DESCRIPTION
    // =====================================================================

    private static void EnsureNicknamesAndPersonalitiesAreComplete()
    {
        Console.Clear();

        for (int i = 0; i < MaxPets; i++)
        {
            if (!IsOccupiedRow(i))
            {
                continue;
            }

            string petId = OurAnimals[i, PetIdColumn];
            string currentNickname = ExtractValue(
                OurAnimals[i, NicknameColumn],
                NicknameLabel);

            if (IsIncompleteText(currentNickname))
            {
                string enteredNickname = PromptForRequiredText(
                    $"Enter a nickname for {petId}:");

                OurAnimals[i, NicknameColumn] =
                    NicknameLabel + enteredNickname;
            }

            string currentPersonalityDescription = ExtractValue(
                OurAnimals[i, PersonalityDescriptionColumn],
                PersonalityDescriptionLabel);

            if (IsIncompleteText(currentPersonalityDescription))
            {
                string enteredPersonalityDescription = PromptForRequiredText(
                    $"Enter a personality description for {petId} " +
                    "(likes or dislikes, tricks, energy level):");

                OurAnimals[i, PersonalityDescriptionColumn] =
                    PersonalityDescriptionLabel +
                    enteredPersonalityDescription.ToLowerInvariant();
            }
        }

        Console.WriteLine();
        Console.WriteLine(
            "Nickname and personality description fields are complete " +
            "for all of our friends.");
        Pause();
    }

    // =====================================================================
    // SHARED VALIDATION AND ARRAY HELPERS
    // =====================================================================

    /// <summary>
    /// Requests a required text value. The loop rejects null, empty, and
    /// whitespace-only input and therefore cannot return an invalid string.
    /// </summary>
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
                    "The value cannot be empty. Please enter valid text.");
            }
        }
        while (string.IsNullOrWhiteSpace(value));

        return value;
    }

    /// <summary>
    /// Removes a known display label from the beginning of a stored field.
    /// Example: "Age: 2" becomes "2".
    /// </summary>
    private static string ExtractValue(string storedField, string label)
    {
        if (storedField.StartsWith(label, StringComparison.Ordinal))
        {
            return storedField[label.Length..].Trim();
        }

        // The fallback keeps the method safe if a future record is stored
        // without the expected label.
        return storedField.Trim();
    }

    /// <summary>
    /// Determines whether a free-text field still needs real information.
    /// </summary>
    private static bool IsIncompleteText(string value)
    {
        return
            string.IsNullOrWhiteSpace(value) ||
            value.Equals(
                ToBeDetermined,
                StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// A row is occupied when the data portion of its pet ID is non-empty.
    /// </summary>
    private static bool IsOccupiedRow(int rowIndex)
    {
        string petId = ExtractValue(
            OurAnimals[rowIndex, PetIdColumn],
            PetIdLabel);

        return !string.IsNullOrWhiteSpace(petId);
    }

    private static int CountOccupiedRows()
    {
        int count = 0;

        for (int i = 0; i < MaxPets; i++)
        {
            if (IsOccupiedRow(i))
            {
                count++;
            }
        }

        return count;
    }

    /// <summary>
    /// Returns the first unused row, or -1 when the array is full.
    /// </summary>
    private static int FindFirstEmptyRow()
    {
        for (int i = 0; i < MaxPets; i++)
        {
            if (!IsOccupiedRow(i))
            {
                return i;
            }
        }

        return -1;
    }

    // =====================================================================
    // PLACEHOLDERS AND CONSOLE UTILITIES
    // =====================================================================

    private static void ShowUnderConstruction(string featureName)
    {
        Console.Clear();
        Console.WriteLine(featureName);
        Console.WriteLine();
        Console.WriteLine(
            "UNDER CONSTRUCTION - this feature is outside the current " +
            "challenge specification.");
        Pause();
    }

    private static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
    }
}