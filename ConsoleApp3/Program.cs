using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 способ
            //PrintedProduct pressa = new Magazine("Информатизация образования", 100, 24.5);
            //pressa.Print();
            //pressa.Cost();

            //2 способ
            //List<PrintedProduct> printedProducts = new List<PrintedProduct>();
            //printedProducts.Add(new Magazine("длала", 827, 124.23));
            //printedProducts.Add(new NewPaper("пыпп", 735, 83, 268));
            //foreach (PrintedProduct printedProduct in printedProducts)
            //{
            //    printedProduct.Print();
            //    printedProduct.Cost();
            //}

            //3 способ
            List<PrintedProduct> pressa = new List<PrintedProduct>();
            bool flag = true;
            do
            {
                Console.WriteLine("Введите название печатной продукции: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "m":
                    case "M":
                        {
                            pressa.Add(Magazine.Enter()); break;
                        }
                    case "n":
                    case "N":
                        {
                            pressa.Add(NewPaper.Enter()); break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет такой печатной продукции"); break;
                        }
                }
                foreach (PrintedProduct p in pressa)
                {
                    p.Print();
                    p.Cost();

                }
            }
            while (flag);
            Console.ReadKey();
        }
    }
}
