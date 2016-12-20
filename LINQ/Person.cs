using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Person
    {
        public string personId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public static int BMI(int h, int w)
        {
            int BMI = (703 * w) / (h * h);
            return BMI;
        }

    }

    
}
