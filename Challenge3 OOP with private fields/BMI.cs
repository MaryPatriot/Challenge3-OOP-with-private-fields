﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_OOP_with_private_fields
{
    class BMI
    {
        
            private  string _fullName;
            private  double _mass;
            private  double _height;

        

        public BMI(string fullName, double mass, double height)
        {
            _fullName = fullName;
            _mass = mass;
            _height = height;
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




