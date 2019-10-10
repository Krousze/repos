using System;

class Sample
{
    protected static int origRow;
    protected static int origCol;

    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }

    public static void Main()
    {
        // Clear the screen, then save the top and left coordinates.
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        // Draw the left side of a 10x20 rectangle, from top to bottom.
        WriteAt("+", 0, 0);
        WriteAt("|", 0, 1);
        WriteAt("|", 0, 2);
        WriteAt("|", 0, 3);
        WriteAt("|", 0, 4);
        WriteAt("|", 0, 5);
        WriteAt("|", 0, 6);
        WriteAt("|", 0, 7);
        WriteAt("|", 0, 8);
        WriteAt("|", 0, 9);
        WriteAt("+", 0, 10);

        // Draw the bottom side, from left to right.
        WriteAt("-", 1, 10);
        WriteAt("-", 2, 10);
        WriteAt("-", 3, 10);
        WriteAt("-", 4, 10);
        WriteAt("-", 5, 10);
        WriteAt("-", 6, 10);
        WriteAt("-", 7, 10);
        WriteAt("-", 8, 10);
        WriteAt("-", 9, 10);
        WriteAt("+", 10, 10);
        WriteAt("-", 11, 10);
        WriteAt("-", 12, 10);
        WriteAt("-", 13, 10);
        WriteAt("-", 14, 10);
        WriteAt("-", 15, 10);
        WriteAt("-", 16, 10);
        WriteAt("-", 17, 10);
        WriteAt("-", 18, 10);
        WriteAt("-", 19, 10);
        WriteAt("+", 20, 10);

        // Draw the right side, from bottom to top.
        WriteAt("+", 20, 10);
        WriteAt("|", 20, 9);
        WriteAt("|", 20, 8);
        WriteAt("|", 20, 7);
        WriteAt("|", 20, 6);
        WriteAt("|", 20, 5);
        WriteAt("|", 20, 4);
        WriteAt("|", 20, 3);
        WriteAt("|", 20, 2);
        WriteAt("|", 20, 1);
        WriteAt("+", 20, 0);

        // Draw the top side, from right to left.
        WriteAt("-", 1, 0);
        WriteAt("-", 2, 0);
        WriteAt("-", 3, 0);
        WriteAt("-", 4, 0);
        WriteAt("-", 5, 0);
        WriteAt("-", 6, 0);
        WriteAt("-", 7, 0);
        WriteAt("-", 8, 0);
        WriteAt("-", 9, 0);
        WriteAt("+", 10, 0);
        WriteAt("-", 11, 0);
        WriteAt("-", 12, 0);
        WriteAt("-", 13, 0);
        WriteAt("-", 14, 0);
        WriteAt("-", 15, 0);
        WriteAt("-", 16, 0);
        WriteAt("-", 17, 0);
        WriteAt("-", 18, 0);
        WriteAt("-", 19, 0);

        // draw left upper quadrant of face

        WriteAt("^", 4, 2);
        WriteAt("^", 5, 2);
        WriteAt("[", 4, 3);
        WriteAt("]", 5, 3);

        // draw right upper quadrant of face

        WriteAt("^", 15, 2);
        WriteAt("^", 16, 2);
        WriteAt("[", 15, 3);
        WriteAt("]", 16, 3);

        // Draw nose

        WriteAt("V", 10, 5);

        // draw left lower quadrant of face

        WriteAt(" _", 2, 5);
        WriteAt(@"\", 4, 6);
        WriteAt(@"\", 5, 7);
        WriteAt(@"\_", 6, 8);
        WriteAt("___", 7, 8);
        WriteAt("___", 8, 8);
        WriteAt("___", 9, 8);


        // draw right lower quadrant of face

        WriteAt(" _", 16, 5);
        WriteAt(@" /", 15, 6);
        WriteAt(@" /", 14, 7);
        WriteAt(@"_/", 13, 8);
        WriteAt("___", 11, 8);
        WriteAt("_ _", 10, 8);
        WriteAt(" U ", 10, 9);




        WriteAt("Happy with Just a little tongue!", 0, 12);
        Console.WriteLine();
    }
}