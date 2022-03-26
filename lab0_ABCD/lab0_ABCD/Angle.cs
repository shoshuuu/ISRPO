using System;
using System.Collections.Generic;
using System.Text;

namespace lab0_ABCD
{
    class Angle
    {
        private int angle { get; set; }
        private float minutes { get; set; }
        private char direction { get; set; }

        private char[] dirs = { 'N', 'S', 'E', 'W' };


        public Angle()
        {
            angle = 0;
            minutes = 0;
            direction = 'S';
        }

        public Angle(int Angle, float Minutes, char Direction)
        {
            angle = Angle;
            minutes = Minutes;

            bool flag = false;
            for (int i = 0; i < dirs.Length; i++)
            {
                if (Direction == dirs[i])
                {
                    direction = Direction;
                    flag = true;
                    break;
                }
            }

            if (!flag)
                direction = 'S';
        }

        public void EnterCoordinate(int Angle, float Minutes, char Direction)
        {
            angle = Angle;
            minutes = Minutes;

            for (int i = 0; i < dirs.Length; i++)
            {
                if (dirs[i] == Direction)
                {
                    direction = Direction;
                    break;
                }
            }
        }

        public void PrintCoordinates()
        {
            Console.WriteLine($"Coordinates: {direction}{angle}°{minutes}' ");
        }
    }
}
