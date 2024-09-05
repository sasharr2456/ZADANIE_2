using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Drink : Product
    {
        public string Volume;

        public override string GetInformation()
        {
            return $"Drink: {Name}, Volume: {Volume}, Price: {Price:C}";
        }
    }
}
