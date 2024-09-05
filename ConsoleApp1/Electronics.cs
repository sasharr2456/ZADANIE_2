using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Electronics : Product
    {
        public int WarrantyPeriod; 

        public override string GetInformation()
        {
            return $"Electronics: {Name}, Warranty: {WarrantyPeriod} years, Price: {Price:C}";
        }
    }
}
