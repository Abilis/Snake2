using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамки
            HorizontalLine upline = new HorizontalLine(1, 78, 1, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(1, 78, 24, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(1, 1, 24, '+');
            leftline.Drow();
            VerticalLine rigthline = new VerticalLine(78, 1, 24, '+');
            rigthline.Drow();

            //отрисовка точек
            Point p1 = new Point(7, 18, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGTH);
            snake.Drow();
            snake.Move();


            Console.ReadLine();
        }
    }
}
