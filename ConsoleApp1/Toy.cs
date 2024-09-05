using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Toy : Product
    {
        public string ToyType;

        public override string GetInformation()
        {
            return $"Toy: {Name}, Type: {ToyType}, Price: {Price:C}";
        }
    }
}
