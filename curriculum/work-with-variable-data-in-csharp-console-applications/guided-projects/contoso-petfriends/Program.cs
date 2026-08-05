using System.Globalization;

// ============================================================================
// Guided Project: Work with Variable Data in C#
// Application: Contoso PetFriends
//
// Purpose:
// Maintain an in-memory list of adoptable pets, display each pet's information,
// assign a suggested donation amount, and search dogs by a requested physical
// or personality characteristic.
//
// Curriculum concepts applied:
// - choosing and converting data types;
// - parsing decimal text safely with decimal.TryParse();
// - formatting currency with an explicit culture;
// - storing related values in a two-dimensional array;
// - searching and normalizing string data;
// - using loops and Boolean flags to report search results.
//
// Data note:
// The application stores runtime data only. Closing the application discards
// all values because no file or database persistence is implemented.
// ============================================================================

// Explicit culture makes the displayed currency stable on computers whose
// regional settings use won, Vietnamese đồng, euros, or another currency.
CultureInfo currencyCulture = CultureInfo.GetCultureInfo("en-US");

// #1 Define the fixed dimensions and field positions of the pet-data table.
//
// Named constants replace unexplained numeric indexes. If the table layout is
// changed later, each field position has one authoritative definition.
const int MaxPets = 8;
const int PetFieldCount = 7;

const int IdIndex = 0;
const int SpeciesIndex = 1;
const int AgeIndex = 2;
const int NicknameIndex = 3;
const int PhysicalDescriptionIndex = 4;
const int PersonalityDescriptionIndex = 5;
const int SuggestedDonationIndex = 6;

const decimal DefaultSuggestedDonation = 45.00M;

const string IdLabel = "ID #: ";
const string SpeciesLabel = "Species: ";
const string AgeLabel = "Age: ";
const string NicknameLabel = "Nickname: ";
const string PhysicalDescriptionLabel = "Physical description: ";
const string PersonalityLabel = "Personality: ";
const string SuggestedDonationLabel = "Suggested Donation: ";

// #2 Declare working variables used while the sample records are created.
//
// These values are assigned inside the switch statement and then copied into
// one row of the two-dimensional array.
string animalSpecies = string.Empty;
string animalId = string.Empty;
string animalAge = string.Empty;
string animalPhysicalDescription = string.Empty;
string animalPersonalityDescription = string.Empty;
string animalNickname = string.Empty;
string suggestedDonation = string.Empty;

// Variables used by the menu and console-input workflow.
string? readResult;
string menuSelection = string.Empty;

// #3 Create the in-memory data table.
//
// Dimension 1 identifies a pet row.
// Dimension 2 identifies one of the seven fields in that row.
string[,] ourAnimals = new string[MaxPets, PetFieldCount];

// #4 Populate the array with the guided project's sample data.
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

            // An empty donation value intentionally demonstrates the fallback
            // path in decimal.TryParse().
            suggestedDonation = string.Empty;
            break;

        default:
            // Unused rows remain identifiable by an empty ID value.
            animalSpecies = string.Empty;
            animalId = string.Empty;
            animalAge = string.Empty;
            animalPhysicalDescription = string.Empty;
            animalPersonalityDescription = string.Empty;
            animalNickname = string.Empty;
            suggestedDonation = string.Empty;
            break;
    }

    ourAnimals[petIndex, IdIndex] = IdLabel + animalId;
    ourAnimals[petIndex, SpeciesIndex] = SpeciesLabel + animalSpecies;
    ourAnimals[petIndex, AgeIndex] = AgeLabel + animalAge;
    ourAnimals[petIndex, NicknameIndex] = NicknameLabel + animalNickname;

    ourAnimals[petIndex, PhysicalDescriptionIndex] =
        PhysicalDescriptionLabel + animalPhysicalDescription;

    ourAnimals[petIndex, PersonalityDescriptionIndex] =
        PersonalityLabel + animalPersonalityDescription;

    // Parse machine-authored decimal text with InvariantCulture so the period
    // is consistently treated as the decimal separator.
    bool donationWasParsed = decimal.TryParse(
        suggestedDonation,
        NumberStyles.Number,
        CultureInfo.InvariantCulture,
        out decimal decimalDonation);

    if (!donationWasParsed)
    {
        // Empty or invalid source data receives the project-defined default.
        decimalDonation = DefaultSuggestedDonation;
    }

    // Store the formatted presentation string while preserving two decimals.
    ourAnimals[petIndex, SuggestedDonationIndex] =
        SuggestedDonationLabel +
        decimalDonation.ToString("C2", currencyCulture);
}

// #5 Display and process the top-level menu until the user enters "exit".
do
{
    // Console.Clear() can fail when output is redirected or in some debugger
    // environments. Skipping it in redirected sessions keeps the app usable.
    if (!Console.IsOutputRedirected)
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Clearing the display is cosmetic. The menu can continue safely.
        }
    }

    Console.WriteLine(
        "Welcome to the Contoso PetFriends app. " +
        "Your main menu options are:");

    Console.WriteLine(
        " 1. List all of our current pet information");

    Console.WriteLine(
        " 2. Display all dogs with a specified characteristic");

    Console.WriteLine();
    Console.WriteLine(
        "Enter your selection number " +
        "(or type Exit to exit the program)");

    // Null-safe normalization allows inputs such as "  EXIT  " or "Exit".
    readResult = Console.ReadLine();
    menuSelection = (readResult ?? string.Empty)
        .Trim()
        .ToLowerInvariant();

    switch (menuSelection)
    {
        case "1":
            // List every populated pet row and all seven stored fields.
            for (int petIndex = 0; petIndex < MaxPets; petIndex++)
            {
                bool rowContainsPet =
                    ourAnimals[petIndex, IdIndex] != IdLabel;

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
                        ourAnimals[petIndex, fieldIndex]);
                }
            }

            Console.WriteLine();
            Console.WriteLine(
                "Press the Enter key to continue.");

            Console.ReadLine();
            break;

        case "2":
            // Collect one non-empty characteristic to use as the search term.
            string dogCharacteristic = string.Empty;

            while (string.IsNullOrWhiteSpace(dogCharacteristic))
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Enter one desired dog characteristic to search for:");

                readResult = Console.ReadLine();

                dogCharacteristic = (readResult ?? string.Empty)
                    .Trim();
            }

            bool dogMatchWasFound = false;

            // #6 Search every populated dog record in the data table.
            for (int petIndex = 0; petIndex < MaxPets; petIndex++)
            {
                bool isDog = ourAnimals[petIndex, SpeciesIndex]
                    .Contains(
                        "dog",
                        StringComparison.OrdinalIgnoreCase);

                if (!isDog)
                {
                    continue;
                }

                // #7 Combine the two searchable descriptions and report every
                // dog whose physical or personality text contains the term.
                string dogDescription =
                    ourAnimals[petIndex, PhysicalDescriptionIndex] +
                    Environment.NewLine +
                    ourAnimals[petIndex, PersonalityDescriptionIndex];

                bool descriptionContainsCharacteristic =
                    dogDescription.Contains(
                        dogCharacteristic,
                        StringComparison.OrdinalIgnoreCase);

                if (!descriptionContainsCharacteristic)
                {
                    continue;
                }

                // Remove the stored label so the sentence displays only the
                // pet's actual nickname.
                string dogNickname =
                    ourAnimals[petIndex, NicknameIndex]
                        .Substring(NicknameLabel.Length);

                Console.WriteLine();
                Console.WriteLine(
                    $"Our dog {dogNickname} is a match!");

                Console.WriteLine(dogDescription);

                dogMatchWasFound = true;
            }

            if (!dogMatchWasFound)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "None of our dogs match the characteristic: " +
                    dogCharacteristic);
            }

            Console.WriteLine();
            Console.WriteLine(
                "Press the Enter key to continue.");

            Console.ReadLine();
            break;

        case "exit":
            // The loop condition ends the program after this switch completes.
            break;

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