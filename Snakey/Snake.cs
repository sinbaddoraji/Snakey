using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakey
{
    internal class Snake
    {
        List<SnakeObject> head = new List<SnakeObject>();
        //-1 = No movement, 0 - Left, 1 - Right, 2 - Up, 3 - Down
        public Snake(int x, int y)
        {
            head.Add(new SnakeObject(x, y));
        }

        public void MoveSnake(int direction)
        {
            for(int i = head.Count - 1; i > 1; i--)
            {
                head[i] = head[i - 1];
            }
            head.Last().Move(direction);
        }

        public void GrowSnake(int direction)
        {
            SnakeObject newHead = new SnakeObject(head.Last().x, head.Last().y);
            newHead.Move(direction);
            head.Add(newHead);

        }
    }

    internal class SnakeObject
    {
        public int x;
        public int y;


        public void Display()
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("x");
        }

        public SnakeObject(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }

        public void Move(int direction)
        {
            //-1 = No movement, 0 - Left, 1 - Right, 2 - Up, 3 - Down
            Console.CursorLeft = x;
            Console.CursorTop = y;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ");

            if (direction == 0 && x > 1)
            {
                x--;
            }
            if (direction == 1 && x < Console.WindowWidth - 3)
            {
                x++;
            }
            if (direction == 2 && y > 1)
            {
                y--;
            }
            if (direction == 3 && y < Console.WindowHeight - 7)
            {
                y++;
            }

            Display();
        }

    }
}
