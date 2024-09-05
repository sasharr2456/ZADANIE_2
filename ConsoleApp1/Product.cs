using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Product
    {
        public string Name;
        public decimal Price;

        public abstract string GetInformation();
    }

}
