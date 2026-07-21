/*
 * This program reverses a message, counts the number of times
 * the letter 'o' appears, and prints the results to the console.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] messageCharacters = originalMessage.ToCharArray();
Array.Reverse(messageCharacters);

int letterOCount = 0;

foreach (char character in messageCharacters)
{
    if (character == 'o')
    {
        letterOCount++;
    }
}

string reversedMessage = new string(messageCharacters);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {letterOCount} times.");