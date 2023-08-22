// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var escapePressed = false;
while (!escapePressed)
{
    var pos = Console.GetCursorPosition();
    var pressedKey = Console.ReadKey();
    if (pressedKey.Key == ConsoleKey.Escape)
    {
        escapePressed = true;
    }
    switch (pressedKey.Key)
    {
        case ConsoleKey.H:
            Console.SetCursorPosition(pos.Left - 1, pos.Top);
            break;
        case ConsoleKey.J:
            Console.SetCursorPosition(pos.Left, pos.Top + 1);
            break;
        case ConsoleKey.K:
            Console.SetCursorPosition(pos.Left, pos.Top - 1);
            break;
        case ConsoleKey.L:
            Console.SetCursorPosition(pos.Left + 1, pos.Top);
            break;
        default:
            break;
    }
}