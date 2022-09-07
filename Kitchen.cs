using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    internal class Kitchen : room
    {
        static Window window = new Window(2, 1, false);
        public Kitchen(int doors, int size, FLoors floor) : base(doors, size, floor, window)
        {

        }
    }
}
