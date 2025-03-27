using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Magazine : PrintedProduct
    {
        private int circulation;
        private double price;
        public Magazine() { }
        public Magazine(string name, int circulation, double price) : base(name)
        {
            Circulation = circulation;
            Price = price;
        }

        public int Circulation { get { return circulation; } set { circulation = value; } }
        public double Price { get { return price; } set { price = value; } }

        public override void Cost()
        {
            Console.WriteLine($"Стоимость: {price * circulation}");
        }
        public override void Print()
        {
            Console.WriteLine($"Наименование: {Name}\tТираж: {circulation}\t Цена: {price}");
        }
        public static Magazine Enter()
        {

            Console.Write("Введите название журнала:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите тираж журнала:");
            int circulation = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену журнала:");
            double price = double.Parse(Console.ReadLine());
            return new Magazine(name, circulation, price);
        }
    }
}
