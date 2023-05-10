using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Calculation
    {
      
        public void EqualityCheck(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Both the lines are equal");
            else
                Console.WriteLine("Lines are different");
        }
    }
}
