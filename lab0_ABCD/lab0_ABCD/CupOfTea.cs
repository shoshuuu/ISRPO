using System;
using System.Collections.Generic;
using System.Text;

namespace lab0_ABCD
{
    class CupOfTea : HotDrink, ICup
    {
        string ICup.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICup.Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string LeafType { get; set; }
        public override string AddMilk()
        {
            Console.WriteLine();
            Milk = Convert.ToInt32(Console.ReadLine());
            return "Готово";
        }

        public override string AddSugar()
        {
            throw new NotImplementedException();
        }

        public override string Drink()
        {
            throw new NotImplementedException();
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }
    }
}
