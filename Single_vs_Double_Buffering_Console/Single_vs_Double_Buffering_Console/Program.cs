using System;
class Program
{
    static int rows = 50;
    static int cols = 50;
    static int x = rows / 2;
    static int y = cols / 2;
    static char[,] cells = new char[rows, cols];
    static bool isDoubleBuffering = false;
    static void Main()
    {
        Console.WriteLine("Commands: arrow keys to move, s to single buffer, d to double buffer, and q to quit.");
        Console.WriteLine("Hit any key to proceed.");
        Console.ReadKey();
        Console.Clear();
        // cols*2 to compensate for font aspect ratio that is not square
        // rows+1 to line at bottom to see last line displayed
        Console.SetWindowSize(cols * 2, rows + 1);
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                cells[row, col] = ' ';
            }
        }
        Draw(x, y, '*');
        while (true)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Q) break;
            Draw(x, y, ' ');
            switch (keyPressed.Key)
            {
                case ConsoleKey.UpArrow:
                    x--;
                    if (x == -1) x = rows - 1;
                    break;
                case ConsoleKey.DownArrow:
                    x++;
                    if (x == cols) x = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    y--;
                    if (y == -1) y = cols - 1;
                    break;
                case ConsoleKey.RightArrow:
                    y++;
                    if (y == rows) y = 0;
                    break;
                case ConsoleKey.S:
                    isDoubleBuffering = false;
                    break;
                case ConsoleKey.D:
                    isDoubleBuffering = true;
                    break;
            }
            Draw(x, y, '*');
        }
    }
    static void Draw(int x, int y, char c)
    {
        if (isDoubleBuffering)
        {
            DoubleBufferDraw(x, y, c);
        }
        else
        {
            SingleBufferDraw(x, y, c);
        }
    }
    static void SingleBufferDraw(int x, int y, char c)
    {
        if (x >= 0 && x < rows && y >= 0 && y < cols) cells[x, y] = c;
        Console.Clear();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(cells[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    static void DoubleBufferDraw(int x, int y, char c)
    {
        if (x >= 0 && x < rows && y >= 0 && y < cols) cells[x, y] = c;
        Console.Clear();
        string screenBuffer = "";
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                //Console.Write(cells[row, col] + " ");
                screenBuffer += cells[row, col] + " ";
            }
            screenBuffer += "\n";
        }
        Console.WriteLine(screenBuffer);
    }
}