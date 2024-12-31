using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp0308.General
{
    internal class LearnWorkingWithString
    {
        public static void HowToWorkWithString()
        {
            //چاق کردن رشته ها روش بهینه خودش رو داره.
            string s = "Test";
            s = "test2";
            s = "test3";
            int num1 = 16;
            int num2 = 26;
            Int32 num3 = 26;
            int result = num1 + num2;
            string output = "Sum of " + num1 + " and " + num2 + " = " + result;
            string Output = $"Sum of {num1} and {num2} = {result}"; //Readibility
            Console.WriteLine(Output);
        }
    }
}
