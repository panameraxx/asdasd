using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NewPaper : PrintedProduct
    {
        private double kolvo;
        private double price;
        private double circulation;

        public double Kolvo { get { return kolvo; } set { kolvo = value; } }
        public double Price { get { return price; } set { price = value; } }
        public double Circulation { get { return circulation; } set { circulation = value; } }
        public NewPaper() { }
        public NewPaper(string name, double kolvo, double price, double circulation)
        {
            Name = name;
            Kolvo = kolvo;
            Price = price;
            Circulation = circulation;
        }
        public override void Print()
        {
            Console.WriteLine($"Наименование: {Name}\tТираж: {circulation}\t Цена: {price}\t Кол-во: {kolvo}\t ");
        }
        public override void Cost()
        {
            Console.WriteLine($"Стоимость: {kolvo * price * circulation}");
        }
        public static NewPaper Enter()
        {

            Console.Write("Введите название газеты:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите кол-во: ");
            int kolvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тираж журнала: ");
            int circulation = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену журнала:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во: ");

            return new NewPaper(name, kolvo, price, circulation);
        }
    }
}
