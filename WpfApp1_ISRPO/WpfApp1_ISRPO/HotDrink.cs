using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1_ISRPO
{
    public abstract class HotDrink
    {
        bool sugar = true;
        bool milk = true;
        int price;

        public bool Sugar { get{ return sugar; } set { sugar = value; } }
        public bool Milk { get { return milk; } set { milk = value; } }
        public int Price { get { return price; } set { price = value; } }
    }
}
