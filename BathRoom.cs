using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    internal class BathRoom:room
    {
        static Window window = new Window(1, 1, true);
        public BathRoom(int doors, int size, FLoors floor) : base(doors, size, floor, window)
        {

        }
    }
}
