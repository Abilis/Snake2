using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class FoodCreator
    {
        int mapWigth;
        int mapHeigth;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWigth, int mapHeigth, char sym)
        {
            this.mapWigth = mapWigth;
            this.mapHeigth = mapHeigth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWigth - 2);
            int y = random.Next(2, mapHeigth - 2);
            return new Point(x, y, sym);
        }
    }
}
