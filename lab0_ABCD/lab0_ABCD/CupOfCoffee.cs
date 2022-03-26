using System;
using System.Collections.Generic;
using System.Text;

namespace lab0_ABCD
{
    class CupOfCoffee : HotDrink, ICup
    {
        string ICup.Type { get; set; }
        public string type
        {
            get { return ICup; }
            set
            {
                Type = value;
                Console.WriteLine($"Тип стакана: {Type}");
            }
        }
        string Capacity { get; set; }
        public string capacity {
            get { return Capacity; }
            set
            {
                Type = value;
                Console.WriteLine($"Объем: {Capacity}");
            }
        }

        private string beanType;
        public string BeanType {
            get { return beanType; }
            set {
                beanType = value;
                Console.WriteLine($"Тип зерен: {beanType}");
            } 
        }
        public override string AddMilk()
        {
            Milk = Convert.ToInt32(Console.ReadLine());
            return $"Молоко: {Milk}";
        }

        public override string AddSugar()
        {
            Sugar = Convert.ToInt32(Console.ReadLine());
            return $"Сахар: {Sugar}"; ;
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
