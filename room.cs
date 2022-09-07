using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum FLoors
{
    Wood,
    Carpet,
    Concrete,
    Tile,
}
namespace LiveGood
{
    internal abstract class room
    {
        private int doors;

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }

        private Window window;

        public Window Window
        {
            get { return window; }
            set { window = value; }
        }

        private FLoors floor;

        public FLoors Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public room(int doors, int size, FLoors floor, Window window)
        {
            this.doors = doors;
            this.size = size;
            this.floor = floor;
            this.Window = window;
        }



    }
}
