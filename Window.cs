using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    internal class Window
    {
        private int fags;

        public int Fags
        {
            get { return fags; }
            set { fags = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private bool iced;

        public bool Iced
        {
            get { return iced; }
            set { iced = value; }
        }

        public Window(int fags, int amount,bool iced)
        {
            Fags = fags;
            Amount = amount;
            Iced = iced;
        }
    }
}
