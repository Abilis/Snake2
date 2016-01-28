using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            leftline.Drow();
            VerticalLine rigthline = new VerticalLine(78, 0, 24, '+');
            rigthline.Drow();

            //отрисовка точек
            Point p1 = new Point(7, 18, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGTH);
            snake.Drow();

            //генерация еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '%');
            Point food = foodCreator.CreateFood();
            food.Draw();

            //движение змейки
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }

                else
                {
                    snake.Move();
                }
                Thread.Sleep(120);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
            }          
        }
    }
}

