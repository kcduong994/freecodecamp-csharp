using System;
using System.Threading;

// ============================================================================
// Challenge Project — Create a Mini-Game
// Learning path: Create Methods in C# Console Applications
//
// Purpose:
// Build a small interactive console game by completing and coordinating an
// existing set of methods.
//
// This challenge is especially useful because it introduces a real game loop:
//
//     initialize game state
//          ↓
//     read player input
//          ↓
//     update player state
//          ↓
//     detect collisions
//          ↓
//     apply food effects
//          ↓
//     render the next state
//          ↓
//     repeat until the game terminates
//
// Core method concepts practiced:
//
// - understanding and modifying existing code;
// - Boolean-returning methods;
// - required and optional parameters;
// - return values;
// - method composition;
// - shared game state;
// - collision detection;
// - input handling;
// - state transitions;
// - game-loop control;
// - terminal-resize detection.
//
// NOTE ABOUT THE SUPPLIED FINAL SOURCE
// ------------------------------------
// The supplied Microsoft challenge specification says that the "fast" player
// state should change horizontal movement by 3.
//
// The supplied Final/Program.cs in the uploaded lab archive calls Move(1, ...),
// which produces the same horizontal step as normal movement.
//
// This repository version follows the WRITTEN CHALLENGE SPECIFICATION and uses
// a horizontal speed of 3 for the fast state.
//
// The challenge also describes unsupported-key termination as optional.
// The constants below make both optional behaviors explicit and easy to test.
// ============================================================================


// ============================================================================
// GAME CONFIGURATION
// ============================================================================

// Horizontal movement step while the player is in the fast state.
//
// Normal movement:
//     1 column per key press
//
// Fast movement:
//     3 columns per key press
const int FastHorizontalSpeed = 3;

// Duration of the temporary frozen state.
const int FreezeDurationMilliseconds = 1000;

// Optional challenge feature:
// true  -> any unsupported key terminates the game.
// false -> unsupported keys are ignored.
const bool ExitOnUnsupportedKey = true;

// Optional challenge feature:
// true  -> (^-^) moves horizontally by FastHorizontalSpeed.
// false -> (^-^) moves at normal speed.
const bool EnableFastMovement = true;


// ============================================================================
// SHARED GAME STATE
// ============================================================================

// One Random instance is reused by the entire game.
//
// Reusing one instance is preferable to repeatedly creating Random objects
// while the game is running.
Random random = new();

// Hide the blinking text cursor so the console looks more like a game screen.
Console.CursorVisible = false;

// The player and every food string are five characters wide.
//
// Subtracting five columns from Console.WindowWidth leaves enough horizontal
// room to render the complete player/food string without writing past the
// right edge of the terminal.
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;

// Main loop termination flag.
//
// false -> keep running.
// true  -> leave the game loop.
bool shouldExit = false;


// ============================================================================
// PLAYER POSITION
// ============================================================================

// Console coordinates of the player's LEFT-MOST character.
//
// Console coordinates use:
//
// X -> horizontal position / column.
// Y -> vertical position / row.
int playerX = 0;
int playerY = 0;


// ============================================================================
// FOOD POSITION
// ============================================================================

// Console coordinates of the food's LEFT-MOST character.
int foodX = 0;
int foodY = 0;


// ============================================================================
// AVAILABLE PLAYER STATES AND FOOD TYPES
// ============================================================================

// Matching indexes connect food types to player states:
//
// index 0:
//     food   = "@@@@@"
//     player = "('-')"
//     effect = normal
//
// index 1:
//     food   = "$$$$$"
//     player = "(^-^)"
//     effect = faster horizontal movement
//
// index 2:
//     food   = "#####"
//     player = "(X_X)"
//     effect = temporary freeze
string[] states =
{
    "('-')",
    "(^-^)",
    "(X_X)"
};

string[] foods =
{
    "@@@@@",
    "$$$$$",
    "#####"
};


// ============================================================================
// CURRENT GAME OBJECT STATE
// ============================================================================

// Current player appearance.
//
// The player starts in the normal state.
string player = states[0];

// Index of the food currently displayed.
//
// This index is important because ChangePlayer() uses the same index to choose
// the matching player appearance from the `states` array.
int food = 0;


// ============================================================================
// INITIALIZATION
// ============================================================================

InitializeGame();


// ============================================================================
// MAIN GAME LOOP
// ============================================================================
//
// A game loop repeatedly performs:
//
// INPUT
//     ↓
// UPDATE
//     ↓
// COLLISION / RULE CHECKING
//     ↓
// RENDERING
//     ↓
// repeat
//
// In this small console game, several rendering operations happen inside the
// methods that update state.
// ============================================================================

while (!shouldExit)
{
    // ------------------------------------------------------------------------
    // 1. VALIDATE THE TERMINAL BEFORE PROCESSING THE NEXT FRAME
    // ------------------------------------------------------------------------
    //
    // The original game dimensions are captured before the loop starts.
    //
    // If the user resizes the terminal, the coordinate assumptions used by the
    // game are no longer reliable. The safest challenge behavior is therefore
    // to stop execution.
    if (TerminalResized())
    {
        Console.Clear();

        Console.Write(
            "Console was resized. Program exiting.");

        shouldExit = true;

        // Continue is unnecessary because the loop condition will fail on the
        // next iteration, but skipping the rest of this iteration is clearer.
        continue;
    }


    // ------------------------------------------------------------------------
    // 2. APPLY THE CURRENT PLAYER STATE
    // ------------------------------------------------------------------------

    if (PlayerIsSick())
    {
        // Sick state:
        //
        // The player does not read movement input for one second.
        // FreezePlayer() then restores the normal appearance.
        FreezePlayer();
    }
    else if (
        EnableFastMovement &&
        PlayerIsFaster())
    {
        // Fast state:
        //
        // The optional `speed` parameter changes only LEFT and RIGHT movement.
        //
        // The written challenge specification requests a horizontal movement
        // value of 3 while this state is active.
        Move(
            speed: FastHorizontalSpeed,
            otherKeysExit: ExitOnUnsupportedKey);
    }
    else
    {
        // Normal state:
        //
        // `speed` is omitted, so Move() uses its default value of 1.
        Move(
            otherKeysExit: ExitOnUnsupportedKey);
    }


    // ------------------------------------------------------------------------
    // 3. STOP IMMEDIATELY IF INPUT REQUESTED TERMINATION
    // ------------------------------------------------------------------------

    if (shouldExit)
    {
        continue;
    }


    // ------------------------------------------------------------------------
    // 4. COLLISION DETECTION — DID THE PLAYER REACH THE FOOD?
    // ------------------------------------------------------------------------

    if (GotFood())
    {
        // The food index determines the new player state.
        ChangePlayer();

        // The consumed food is replaced immediately with another randomly
        // selected food item at another random location.
        ShowFood();
    }
}


// ============================================================================
// METHOD: TerminalResized
// ============================================================================

bool TerminalResized()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // - no explicit parameters;
    // - reads the original `height` and `width`;
    // - reads the terminal's current dimensions.
    //
    // PROCESSING:
    // compare the current terminal dimensions with the dimensions captured
    // when the game started.
    //
    // OUTPUT:
    // true  -> terminal size changed.
    // false -> terminal size is unchanged.

    bool heightChanged =
        height !=
        Console.WindowHeight - 1;

    bool widthChanged =
        width !=
        Console.WindowWidth - 5;

    return
        heightChanged ||
        widthChanged;
}


// ============================================================================
// METHOD: ShowFood
// ============================================================================

void ShowFood()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // no explicit parameters.
    //
    // PROCESSING:
    // 1. randomly select one food type;
    // 2. randomly select a valid X position;
    // 3. randomly select a valid Y position;
    // 4. render the food.
    //
    // OUTPUT:
    // no return value;
    // updates shared game state:
    // - food
    // - foodX
    // - foodY
    // and writes the food to the console.

    // Select a valid index:
    //
    // 0, 1, or 2
    food =
        random.Next(
            0,
            foods.Length);

    // Random.Next() excludes the upper bound.
    //
    // The horizontal range leaves enough room for the complete five-character
    // food string.
    foodX =
        random.Next(
            0,
            width - player.Length);

    foodY =
        random.Next(
            0,
            height - 1);

    // Move the console cursor to the generated coordinates.
    Console.SetCursorPosition(
        foodX,
        foodY);

    // Draw the currently selected food.
    Console.Write(
        foods[food]);
}


// ============================================================================
// METHOD: GotFood
// ============================================================================

bool GotFood()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // reads:
    // - playerX
    // - playerY
    // - foodX
    // - foodY
    //
    // PROCESSING:
    // compare player and food coordinates.
    //
    // OUTPUT:
    // true  -> player and food occupy the same starting coordinate.
    // false -> they do not.
    //
    // This is the game's COLLISION DETECTION method.
    //
    // Because the challenge uses the left-most coordinate of each five-
    // character object, collision is intentionally simplified to an exact
    // coordinate match.

    bool sameHorizontalPosition =
        playerX == foodX;

    bool sameVerticalPosition =
        playerY == foodY;

    return
        sameHorizontalPosition &&
        sameVerticalPosition;
}


// ============================================================================
// METHOD: PlayerIsSick
// ============================================================================

bool PlayerIsSick()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // current `player` appearance.
    //
    // PROCESSING:
    // compare it with states[2].
    //
    // OUTPUT:
    // true  -> player is "(X_X)".
    // false -> player is in another state.

    return
        player.Equals(
            states[2],
            StringComparison.Ordinal);
}


// ============================================================================
// METHOD: PlayerIsFaster
// ============================================================================

bool PlayerIsFaster()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // current `player` appearance.
    //
    // PROCESSING:
    // compare it with states[1].
    //
    // OUTPUT:
    // true  -> player is "(^-^)".
    // false -> player is in another state.

    return
        player.Equals(
            states[1],
            StringComparison.Ordinal);
}


// ============================================================================
// METHOD: ChangePlayer
// ============================================================================

void ChangePlayer()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // current `food` index.
    //
    // PROCESSING:
    // use the shared index to select the matching player appearance.
    //
    // OUTPUT:
    // no return value;
    // updates `player` and redraws the player.
    //
    // The two arrays deliberately use matching indexes:
    //
    // foods[0]  -> states[0]
    // foods[1]  -> states[1]
    // foods[2]  -> states[2]

    player =
        states[food];

    Console.SetCursorPosition(
        playerX,
        playerY);

    Console.Write(
        player);
}


// ============================================================================
// METHOD: FreezePlayer
// ============================================================================

void FreezePlayer()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // no explicit parameters.
    //
    // PROCESSING:
    // pause the current thread for one second.
    //
    // OUTPUT:
    // no return value;
    // restores the player's normal state after the delay.
    //
    // This implements the temporary effect of consuming "#####".

    Thread.Sleep(
        FreezeDurationMilliseconds);

    player =
        states[0];

    // The next movement call redraws the player during normal gameplay.
}


// ============================================================================
// METHOD: Move
// ============================================================================

void Move(
    int speed = 1,
    bool otherKeysExit = false)
{
    // METHOD CONTRACT
    //
    // INPUT:
    //
    // speed
    // → optional horizontal movement distance.
    // → default = 1.
    //
    // otherKeysExit
    // → optional rule controlling unsupported input.
    // → false = ignore unsupported keys.
    // → true  = terminate on unsupported keys.
    //
    // PROCESSING:
    // 1. save the player's previous coordinates;
    // 2. read one key;
    // 3. update player coordinates or exit state;
    // 4. erase the old player rendering;
    // 5. clamp the new coordinates to the terminal;
    // 6. redraw the player.
    //
    // OUTPUT:
    // no return value;
    // updates:
    // - playerX
    // - playerY
    // - shouldExit
    // and updates console rendering.

    // Save the previous location before movement.
    //
    // We need this location later so we know where to erase the old player.
    int lastX =
        playerX;

    int lastY =
        playerY;


    // Read a single key without echoing it to the terminal.
    ConsoleKey key =
        Console.ReadKey(
            intercept: true)
        .Key;


    // ------------------------------------------------------------------------
    // INPUT → STATE UPDATE
    // ------------------------------------------------------------------------

    switch (key)
    {
        case ConsoleKey.UpArrow:
            // Vertical movement stays one row per key press.
            playerY--;
            break;

        case ConsoleKey.DownArrow:
            playerY++;
            break;

        case ConsoleKey.LeftArrow:
            // Horizontal movement uses the optional speed parameter.
            playerX -= speed;
            break;

        case ConsoleKey.RightArrow:
            playerX += speed;
            break;

        case ConsoleKey.Escape:
            // Escape always terminates the game.
            shouldExit = true;
            break;

        default:
            // Optional challenge behavior:
            //
            // otherKeysExit = true
            // → unsupported key ends the game.
            //
            // otherKeysExit = false
            // → unsupported key changes nothing.
            shouldExit =
                otherKeysExit;
            break;
    }


    // ------------------------------------------------------------------------
    // ERASE THE PLAYER AT THE OLD POSITION
    // ------------------------------------------------------------------------

    Console.SetCursorPosition(
        lastX,
        lastY);

    // The player string is five characters wide.
    //
    // Writing the same number of spaces removes the old rendering.
    for (
        int index = 0;
        index < player.Length;
        index++)
    {
        Console.Write(" ");
    }


    // ------------------------------------------------------------------------
    // KEEP THE PLAYER INSIDE THE TERMINAL BOUNDS
    // ------------------------------------------------------------------------
    //
    // The ternary expressions implement clamping:
    //
    // X < 0
    // → use 0
    //
    // X >= width
    // → use width
    //
    // otherwise
    // → keep X unchanged

    playerX =
        playerX < 0
            ? 0
            : playerX >= width
                ? width
                : playerX;

    playerY =
        playerY < 0
            ? 0
            : playerY >= height
                ? height
                : playerY;


    // ------------------------------------------------------------------------
    // DRAW THE PLAYER AT THE NEW POSITION
    // ------------------------------------------------------------------------

    Console.SetCursorPosition(
        playerX,
        playerY);

    Console.Write(
        player);
}


// ============================================================================
// METHOD: InitializeGame
// ============================================================================

void InitializeGame()
{
    // METHOD CONTRACT
    //
    // INPUT:
    // shared initial game state.
    //
    // PROCESSING:
    // 1. clear the terminal;
    // 2. generate and display the first food;
    // 3. place the player at the origin.
    //
    // OUTPUT:
    // no return value;
    // establishes the first visible game state.

    Console.Clear();

    ShowFood();

    Console.SetCursorPosition(
        0,
        0);

    Console.Write(
        player);
}


// ============================================================================
// GAME ARCHITECTURE SUMMARY
// ============================================================================
//
// 1. GAME STATE
//
// playerX / playerY
// → player position
//
// foodX / foodY
// → food position
//
// player
// → current visual + gameplay state
//
// food
// → current food type
//
// shouldExit
// → controls game-loop lifetime
//
//
// 2. INPUT
//
// Console.ReadKey(...)
//      ↓
// Move(...)
//      ↓
// direction / exit decision
//
//
// 3. UPDATE
//
// directional key
//      ↓
// player coordinates change
//
// food collision
//      ↓
// ChangePlayer()
//      ↓
// gameplay state changes
//
//
// 4. COLLISION DETECTION
//
// GotFood()
//      ↓
// player position == food position
//      ↓
// true / false
//
//
// 5. FOOD EFFECTS
//
// @@@@@
//      ↓
// ('-')
//      ↓
// normal movement
//
// $$$$$
//      ↓
// (^-^)
//      ↓
// faster horizontal movement
//
// #####
//      ↓
// (X_X)
//      ↓
// temporary freeze
//
//
// 6. GAME LOOP
//
// while (!shouldExit)
//      ↓
// terminal valid?
//      ↓
// evaluate player state
//      ↓
// read movement input
//      ↓
// detect food collision
//      ↓
// apply food effect
//      ↓
// spawn new food
//      ↓
// repeat
//
//
// 7. METHOD DESIGN
//
// TerminalResized()
// → returns bool
//
// GotFood()
// → returns bool
//
// PlayerIsSick()
// → returns bool
//
// PlayerIsFaster()
// → returns bool
//
// Move(int speed = 1, bool otherKeysExit = false)
// → optional parameters
//
// ChangePlayer()
// → state transition
//
// FreezePlayer()
// → temporary gameplay effect
//
// ShowFood()
// → world-object generation
//
// InitializeGame()
// → initial state setup
//
//
// 8. THE IMPORTANT PROGRAMMING LESSON
//
// This game is not "one big block of code."
//
// It is a collection of small responsibilities:
//
// INPUT
//      ↓
// METHODS
//      ↓
// GAME STATE
//      ↓
// RULES
//      ↓
// OUTPUT
//
// That same architecture scales into larger games and ordinary applications.
// ============================================================================