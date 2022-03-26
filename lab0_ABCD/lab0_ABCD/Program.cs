using System;

namespace lab0_ABCD
{


    class Program
    {
        static void Main(string[] args)
        {
            /*Angle test = new Angle(20, 33, 'N');
            test.PrintCoordinates();

            Angle test2 = new Angle();
            test2.PrintCoordinates();
            test2.EnterCoordinate(44, 55, 'W');
            test2.PrintCoordinates();*/


        }

        public virtual void ProcessCup(HotDrink a)
        {
            Console.WriteLine("Выберите напиток: кофе или чай?:");
            Console.Read();
            
        }
    }
}
