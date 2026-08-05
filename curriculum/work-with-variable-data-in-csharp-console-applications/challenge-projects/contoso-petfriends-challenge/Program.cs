using System.Globalization;
using System.Threading;

// ============================================================================
// Challenge Project: Work with Variable Data in C#
// Application: Contoso PetFriends
//
// Purpose:
// Extend the Contoso PetFriends dog-search feature so that a user can enter
// several comma-separated characteristics. The application sorts the terms,
// searches every available dog's combined description, reports all matches,
// and displays a spinner with a countdown from 2 to 0.
//
// Challenge requirements demonstrated:
// - collect and validate console input;
// - split one string into a string array;
// - trim and sort array elements;
// - iterate through pets and search terms;
// - build strings from multiple data sources;
// - search without case sensitivity;
// - format decimal donation values safely;
// - display a rotating search animation and numeric countdown.
//
// Data-storage note:
// The application stores pet information only in memory. All runtime data is
// discarded when the process exits because no file or database is used.
// ============================================================================

// Use an explicit culture so the challenge output remains stable on computers
// configured for Korean won, Vietnamese đồng, euros, or another currency.
CultureInfo currencyCulture =
    CultureInfo.GetCultureInfo("en-US");

// --------------------------------------------------------------------------
// Pet-table dimensions and field indexes
// --------------------------------------------------------------------------

// The first array dimension represents a pet row.
// The second dimension represents one field within that pet record.
const int MaxPets = 8;
const int PetFieldCount = 7;

// Named indexes prevent unexplained numeric positions from being repeated
// throughout the application.
const int IdIndex = 0;
const int SpeciesIndex = 1;
const int AgeIndex = 2;
const int NicknameIndex = 3;
const int PhysicalDescriptionIndex = 4;
const int PersonalityDescriptionIndex = 5;
const int SuggestedDonationIndex = 6;

// Reusable labels make it possible to store and later extract field values
// without relying on fragile numeric offsets.
const string IdLabel = "ID #: ";
const string SpeciesLabel = "Species: ";
const string AgeLabel = "Age: ";
const string NicknameLabel = "Nickname: ";
const string PhysicalDescriptionLabel = "Physical description: ";
const string PersonalityLabel = "Personality: ";
const string SuggestedDonationLabel = "Suggested Donation: ";

// Missing or invalid donation text receives this project-defined fallback.
const decimal DefaultSuggestedDonation = 45.00M;

// The challenge requires a countdown from 2 to 0.
const int SearchCountdownStart = 2;

// A short delay makes the spinner visible without making each search too slow.
const int SearchFrameDelayMilliseconds = 100;

// --------------------------------------------------------------------------
// Working variables used while sample records are created
// --------------------------------------------------------------------------

string animalSpecies = string.Empty;
string animalId = string.Empty;
string animalAge = string.Empty;
string animalPhysicalDescription = string.Empty;
string animalPersonalityDescription = string.Empty;
string animalNickname = string.Empty;
string suggestedDonation = string.Empty;

// Console-input and menu state.
string? readResult;
string menuSelection = string.Empty;

// --------------------------------------------------------------------------
// Create and populate the in-memory pet-data table
// --------------------------------------------------------------------------

string[,] ourAnimals =
    new string[MaxPets, PetFieldCount];

for (int petIndex = 0; petIndex < MaxPets; petIndex++)
{
    switch (petIndex)
    {
        case 0:
            animalSpecies = "dog";
            animalId = "d1";
            animalAge = "2";

            animalPhysicalDescription =
                "medium sized cream colored female golden retriever " +
                "weighing about 45 pounds. housebroken.";

            animalPersonalityDescription =
                "loves to have her belly rubbed and likes to chase her tail. " +
                "gives lots of kisses.";

            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalId = "d2";
            animalAge = "9";

            animalPhysicalDescription =
                "large reddish-brown male golden retriever weighing about " +
                "85 pounds. housebroken.";

            animalPersonalityDescription =
                "loves to have his ears rubbed when he greets you at the door, " +
                "or at any time! loves to lean-in and give doggy hugs.";

            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalId = "c3";
            animalAge = "1";

            animalPhysicalDescription =
                "small white female weighing about 8 pounds. " +
                "litter box trained.";

            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalId = "c4";
            animalAge = string.Empty;
            animalPhysicalDescription = string.Empty;
            animalPersonalityDescription = string.Empty;
            animalNickname = "lion";

            // This intentionally empty value exercises the fallback donation.
            suggestedDonation = string.Empty;
            break;

        default:
            // Unused rows receive empty values. The empty ID later identifies
            // rows that should not be displayed or searched.
            animalSpecies = string.Empty;
            animalId = string.Empty;
            animalAge = string.Empty;
            animalPhysicalDescription = string.Empty;
            animalPersonalityDescription = string.Empty;
            animalNickname = string.Empty;
            suggestedDonation = string.Empty;
            break;
    }

    ourAnimals[petIndex, IdIndex] =
        IdLabel + animalId;

    ourAnimals[petIndex, SpeciesIndex] =
        SpeciesLabel + animalSpecies;

    ourAnimals[petIndex, AgeIndex] =
        AgeLabel + animalAge;

    ourAnimals[petIndex, NicknameIndex] =
        NicknameLabel + animalNickname;

    ourAnimals[petIndex, PhysicalDescriptionIndex] =
        PhysicalDescriptionLabel +
        animalPhysicalDescription;

    ourAnimals[petIndex, PersonalityDescriptionIndex] =
        PersonalityLabel +
        animalPersonalityDescription;

    // InvariantCulture treats the period in values such as "49.99" as the
    // decimal separator regardless of the computer's regional configuration.
    bool donationWasParsed =
        decimal.TryParse(
            suggestedDonation,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            out decimal decimalDonation);

    if (!donationWasParsed)
    {
        decimalDonation =
            DefaultSuggestedDonation;
    }

    ourAnimals[petIndex, SuggestedDonationIndex] =
        SuggestedDonationLabel +
        decimalDonation.ToString(
            "C2",
            currencyCulture);
}

// --------------------------------------------------------------------------
// Main application loop
// --------------------------------------------------------------------------

do
{
    // Clearing the screen improves the interactive experience, but it is not a
    // business requirement. Some debuggers and redirected-output environments
    // do not support Console.Clear(), so failure is safely ignored.
    if (!Console.IsOutputRedirected)
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Continue without clearing the terminal.
        }
    }

    Console.WriteLine(
        "Welcome to the Contoso PetFriends app. " +
        "Your main menu options are:");

    Console.WriteLine(
        " 1. List all of our current pet information");

    Console.WriteLine(
        " 2. Display all dogs with specified characteristics");

    Console.WriteLine();

    Console.WriteLine(
        "Enter your selection number " +
        "(or type Exit to exit the program)");

    readResult =
        Console.ReadLine();

    // Null-coalescing prevents a null input from causing an exception.
    // Trimming and invariant lowercase normalization make menu commands such
    // as " EXIT ", "Exit", and "exit" equivalent.
    menuSelection =
        (readResult ?? string.Empty)
            .Trim()
            .ToLowerInvariant();

    switch (menuSelection)
    {
        // ------------------------------------------------------------------
        // Menu option 1: list all populated pet records
        // ------------------------------------------------------------------
        case "1":
            for (
                int petIndex = 0;
                petIndex < MaxPets;
                petIndex++)
            {
                bool rowContainsPet =
                    ourAnimals[petIndex, IdIndex] !=
                    IdLabel;

                if (!rowContainsPet)
                {
                    continue;
                }

                Console.WriteLine();

                for (
                    int fieldIndex = 0;
                    fieldIndex < PetFieldCount;
                    fieldIndex++)
                {
                    Console.WriteLine(
                        ourAnimals[
                            petIndex,
                            fieldIndex]);
                }
            }

            Console.WriteLine();
            Console.WriteLine(
                "Press the Enter key to continue.");

            Console.ReadLine();
            break;

        // ------------------------------------------------------------------
        // Menu option 2: perform a sorted, multiple-term dog search
        // ------------------------------------------------------------------
        case "2":
            string[] dogSearchTerms =
                Array.Empty<string>();

            // Continue prompting until Split() produces at least one non-empty
            // term. Inputs such as null, "", spaces, or ",,," are rejected.
            while (dogSearchTerms.Length == 0)
            {
                Console.WriteLine();

                Console.WriteLine(
                    "Enter dog characteristics to search for " +
                    "separated by commas:");

                readResult =
                    Console.ReadLine();

                string rawSearchInput =
                    readResult ?? string.Empty;

                // RemoveEmptyEntries discards empty comma-separated elements.
                // TrimEntries removes surrounding whitespace from each term.
                dogSearchTerms =
                    rawSearchInput.Split(
                        ',',
                        StringSplitOptions.RemoveEmptyEntries |
                        StringSplitOptions.TrimEntries);

                if (dogSearchTerms.Length == 0)
                {
                    Console.WriteLine();

                    Console.WriteLine(
                        "Enter at least one non-empty characteristic.");
                }
            }

            // The challenge requires alphanumeric ordering. OrdinalIgnoreCase
            // gives stable sorting without treating uppercase and lowercase as
            // different search categories.
            Array.Sort(
                dogSearchTerms,
                StringComparer.OrdinalIgnoreCase);

            Console.WriteLine();

            // These frames resemble a rotating dial when rewritten repeatedly
            // on one console line.
            string[] searchingIcons =
            {
                "|",
                "/",
                "-",
                "\\"
            };

            bool anyDogMatched =
                false;

            // Inspect all possible pet rows.
            for (
                int petIndex = 0;
                petIndex < MaxPets;
                petIndex++)
            {
                bool rowContainsPet =
                    ourAnimals[petIndex, IdIndex] !=
                    IdLabel;

                if (!rowContainsPet)
                {
                    continue;
                }

                bool isDog =
                    ourAnimals[petIndex, SpeciesIndex]
                        .Contains(
                            "dog",
                            StringComparison.OrdinalIgnoreCase);

                if (!isDog)
                {
                    continue;
                }

                // Search both required description fields as one string.
                string dogDescription =
                    ourAnimals[
                        petIndex,
                        PhysicalDescriptionIndex] +
                    Environment.NewLine +
                    ourAnimals[
                        petIndex,
                        PersonalityDescriptionIndex];

                // Remove the stored label before placing the nickname inside a
                // sentence. NicknameLabel.Length avoids a magic number.
                string dogNickname =
                    ourAnimals[petIndex, NicknameIndex]
                        .Substring(
                            NicknameLabel.Length);

                bool currentDogMatched =
                    false;

                // Search the current dog once for every sorted user term.
                foreach (string searchTerm in dogSearchTerms)
                {
                    // ------------------------------------------------------
                    // Search-status spinner with countdown: 2, 1, 0
                    // ------------------------------------------------------
                    if (!Console.IsOutputRedirected)
                    {
                        int previousStatusLength =
                            0;

                        for (
                            int countdown = SearchCountdownStart;
                            countdown >= 0;
                            countdown--)
                        {
                            foreach (string icon in searchingIcons)
                            {
                                string searchStatus =
                                    $"Searching our dog {dogNickname} " +
                                    $"for {searchTerm} {icon} {countdown}";

                                // Pad shorter frames so no characters from the
                                // previous frame remain visible.
                                Console.Write(
                                    "\r" +
                                    searchStatus.PadRight(
                                        previousStatusLength));

                                previousStatusLength =
                                    searchStatus.Length;

                                Thread.Sleep(
                                    SearchFrameDelayMilliseconds);
                            }
                        }

                        // Erase the final animation frame and return the cursor
                        // to the beginning of the line.
                        Console.Write(
                            "\r" +
                            new string(
                                ' ',
                                previousStatusLength) +
                            "\r");
                    }
                    else
                    {
                        // Redirected output cannot display a real spinner.
                        // Emit one readable status line and skip the delay.
                        Console.WriteLine(
                            $"Searching our dog {dogNickname} " +
                            $"for {searchTerm}.");
                    }

                    // Contains(..., OrdinalIgnoreCase) searches naturally
                    // across both description fields without changing the
                    // stored strings or requiring lowercase copies.
                    bool termMatched =
                        dogDescription.Contains(
                            searchTerm,
                            StringComparison.OrdinalIgnoreCase);

                    if (!termMatched)
                    {
                        continue;
                    }

                    Console.WriteLine(
                        $"Our dog {dogNickname} matches your search " +
                        $"for {searchTerm}.");

                    currentDogMatched =
                        true;

                    anyDogMatched =
                        true;
                }

                // Display the dog's details once after every search term has
                // been checked, even when several terms matched this dog.
                if (currentDogMatched)
                {
                    Console.WriteLine();

                    Console.WriteLine(
                        $"{ourAnimals[petIndex, NicknameIndex]} " +
                        $"({ourAnimals[petIndex, IdIndex]})");

                    Console.WriteLine(
                        dogDescription);

                    Console.WriteLine();
                }
            }

            if (!anyDogMatched)
            {
                Console.WriteLine(
                    "None of our dogs are a match for: " +
                    string.Join(
                        ", ",
                        dogSearchTerms));

                Console.WriteLine();
            }

            Console.WriteLine(
                "Press the Enter key to continue.");

            Console.ReadLine();
            break;

        // ------------------------------------------------------------------
        // Exit command
        // ------------------------------------------------------------------
        case "exit":
            // The do-while condition ends the program after this switch.
            break;

        // ------------------------------------------------------------------
        // Unsupported menu input
        // ------------------------------------------------------------------
        default:
            Console.WriteLine();

            Console.WriteLine(
                "Invalid selection. Enter 1, 2, or Exit.");

            Console.WriteLine(
                "Press the Enter key to continue.");

            Console.ReadLine();
            break;
    }
}
while (menuSelection != "exit");