using System.Security.AccessControl;
using System.Xml;

namespace LearnCSharp0308
{
    //Comment کامنت
    //Container for peoprties(data) and methods
    //Proprty , Method
    //Private, Public, internal -> Access Modifier
    //DRY => Dont repeat yoourself
    internal class Program
    {

        static bool IsValidMobileNumber(string mobileNumber)
        {
            if (mobileNumber.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //هم ورودی دارد و هم خروجی دارد
        static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        static int Add(int x, int y, int z)
        {
            int result = x + y + z;
            return result;
        }

        // نه ورودی دارد و نه خروجی دارد
        static void ShowWellcomeMessage()
        {
            Console.WriteLine("Wellcome.");
        }

        //ورودی دارد اما خروجی ندارد
        static void ShowWarWellcomeMessage(string name)
        {
            Console.WriteLine($"Wellcome {name}.......");
        }

        //ورودی ندارد ولی خروجی دارد
        static string GetWellComeMessage() 
        {
            return "Wellcome......";
        }


        static void Main(string[] args)
        {
            //Mehod call

            ShowWellcomeMessage();
            

            ShowWarWellcomeMessage("Parham");
            string wellComeMessage = GetWellComeMessage();
            int res = Add(x: 15,y: 25);

            int number7 = default;
            bool isMale = default;
            var temp = Console.ReadLine();

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

            Console.ResetColor();
            //debgging
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            //DataType Name = initial Value;
            //string username = "parham_dr"; //Hard code
            Console.WriteLine("Hello,  World!");

            Console.WriteLine("age ?");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);

            Console.WriteLine("gender ?");
            string gender = Console.ReadLine();

            if (gender == "male" && age >= 18 && age < 100)
            {

            }
            
            Console.WriteLine("Please enter your phonenumber?");
            string phoneNumber = Console.ReadLine();
            bool isValid = IsValidMobileNumber(phoneNumber);

            Console.WriteLine("Please enter your username?");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password?");
            string password = Console.ReadLine();

            Console.WriteLine("You entered username: " + username + " and password: " + password);
            Console.ResetColor();
        }
    }
}
