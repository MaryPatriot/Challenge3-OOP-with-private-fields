using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_OOP_with_private_fields
{
    class BMI
    {
        
            private static string _fullName;
            private static double _mass;
            private static double _height;


            public static string FullName { get => _fullName; set => _fullName = value; }



            public static double Mass { get => _mass; set => _mass = value; }
            public static double Weight { get => _height; set => _height = value; }

            public BMI()
            {
                //this.FullName = _fullName;
                //this.Mass = _mass;
                //this.Height = _height;

            }

            public double CalculateBMI()
            {
                double BMICal = _mass / (Math.Pow(_height, 2));
                return BMICal;
            }

            public static void BMICom(double A, double B)
            {
                if (A > B)
                {
                    Console.WriteLine("John BMI is higher than Mark BMI");
                }
                else if (A < B)
                {
                    Console.WriteLine("Mark BMI is higher than John BMI");
                }
                else if (A == B)
                {
                    Console.WriteLine("Mark BMI is the same as John BMI");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }






















        }


    }




