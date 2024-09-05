using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Meat : Product
    {
        public decimal Weight; 

        public override string GetInformation()
        {
            return $"Meat: {Name}, Weight: {Weight} kg, Price: {Price:C}";
        }
    }
}
