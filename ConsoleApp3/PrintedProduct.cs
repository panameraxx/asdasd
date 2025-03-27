using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class PrintedProduct
    {
        private string name;
        public PrintedProduct() { }
        public PrintedProduct(string name) { Name = name; }
        public string Name
        {
            get { return name; }
            set { name = (value != "") ? value : "SoName"; }
        }
        public abstract void Print();
        public abstract void Cost();
    }
}
