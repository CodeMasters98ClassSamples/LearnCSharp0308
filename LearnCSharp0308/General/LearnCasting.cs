using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp0308.General
{
    internal class LearnCasting
    {
        public static void Casting()
        {
            int number1 = 10;
            long number2 = 5;

            //smaller to bigger
            number2 = number1;

            //bigger to smaller
            number1 = (int)number2;

            // string to int
            //int number3 = "15";
            int number3 = int.Parse("150000");
            short number4 = short.Parse("1");
            long number5 = long.Parse("100000");


            // int to string
            int number6 = 15;
            string number6Str = number6.ToString();
        }
    }
}
