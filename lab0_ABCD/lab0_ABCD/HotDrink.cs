using System;
using System.Collections.Generic;
using System.Text;

namespace lab0_ABCD
{
    abstract class HotDrink
    {
        private int sugar = 3;
        public int Sugar
        {
            get { return sugar; }
            set {sugar = value; }
        }
        private int milk = 3;
        public int Milk
        {
            get { return milk; }
            set { milk = value; }
        }
        public abstract string Drink();
        public abstract string AddMilk();
        public abstract string AddSugar();
    }
}
