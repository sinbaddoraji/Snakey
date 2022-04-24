using System;


string gameArena;

void Init()
{

    gameArena = "";
    Console.CursorSize = 50;
    
    for (int y = 0; y < Console.WindowHeight - 5; y++)
    {
        for (int x = 1; x < Console.WindowWidth; x++)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            if (x == 1 || x == Console.WindowWidth - 1)
            {
                Console.Write("|");
            }
            else if (y == 0 || y == Console.WindowHeight - 6)
            {
                Console.Write("-");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}



Init();
Console.WriteLine(gameArena);
var _snake = new Snakey.Snake(5, 5);

int _direction = 1;
int _frame_rate = 200;

//-1 = No movement, 0 - Left, 1 - Right, 2 - Up, 3 - Down
ConsoleKey[] directions = new ConsoleKey[] { ConsoleKey.A, ConsoleKey.D, ConsoleKey.W, ConsoleKey.S };
while (true)
{
    if(Console.KeyAvailable)
    {
        ConsoleKey choice = Console.ReadKey(true).Key;
        

        if(choice == ConsoleKey.R)
        {
            _snake.GrowSnake(_direction);
        }
        else
        {
            _direction = Array.IndexOf(directions, choice);
        }
    }
    _snake.MoveSnake(_direction);
    Thread.Sleep(_frame_rate);
}


