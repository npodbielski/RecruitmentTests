// See https://aka.ms/new-console-template for more information

public class DiamondKata
{
    public static void Main(string[] args)
    {
        var character = args[0][0];
        PrintKata(character);
    }

    private static void PrintKata(char character)
    {
        var size = GetSize(character);
        Console.WriteLine($"Size of the diamond: {size}");
        var lengthOfTheLine = GetLengthOfTheLine(size);
        Console.WriteLine($"Length of the line: {lengthOfTheLine}");
        for (var currentRow = 1; currentRow <= lengthOfTheLine; currentRow++)
        {
            PrintLine(currentRow, lengthOfTheLine, size);
        }
    }

    private static void PrintLine(int currentRow, int lengthOfTheLine, int size)
    {
        var currentLineCharacter = GetCurrentLineCharacter(currentRow, lengthOfTheLine, size);
        var positionOfCharacter = GetCharacterPosition(currentLineCharacter);
        var format = BuildLine(size, positionOfCharacter, currentLineCharacter);
        Console.WriteLine(format);
    }

    private static string BuildLine(int size, int positionOfCharacter, char currentLineCharacter)
    {
        var characters = Enumerable.Range(0, size).Select(i => i == positionOfCharacter ? currentLineCharacter : '-').ToArray();
        return new string(characters.Skip(1).Reverse().ToArray()) + new string(characters);
    }

    private static int GetCharacterPosition(char currentLineCharacter)
    {
        return currentLineCharacter - 'A';
    }

    public static char GetCurrentLineCharacter(int currentRow, int lengthOfTheLine, int size)
    {
        var delta = currentRow <= size ? currentRow - 1 : Math.Abs(lengthOfTheLine - currentRow);
        var currentLineCharacter = (char)(delta + 'A');
        return currentLineCharacter;
    }

    private static int GetLengthOfTheLine(int size)
    {
        return size * 2 - 1;
    }

    private static int GetSize(char character)
    {
        return character - 'A' + 1;
    }
}