using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_OOP_with_private_fields
{
    class Program
    {
        static void Main(string[] args)
        {

            BMI John = new BMI("John Robert", 105, 166);
            BMI Mark = new BMI("Mark Robert", 75, 198);

            double A = John.CalculateBMI();
            double B = Mark.CalculateBMI();

            Console.WriteLine(A);
            Console.WriteLine(B);
            BMI.BMICom(A, B );

            

          



        }
    }
}
