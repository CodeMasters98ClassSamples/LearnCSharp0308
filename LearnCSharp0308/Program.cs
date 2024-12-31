using LearnCSharp0308.General;

namespace LearnCSharp0308
{

    //Comment کامنت
    //Container for peoprties(data) and methods
    //Proprty , Method
    //Private, Public, internal -> Access Modifier
    //DRY => Dont repeat yoourself
    internal class Program
    {

        static void Main(string[] args)
        {
            string phoneNumber = string.Empty;
            Utility.IsValidMobileNumber(phoneNumber);
            //Version 1
            //while (true)
            //{
            //    Console.WriteLine("Please enter your phonenumber?");
            //    phoneNumber = Console.ReadLine() ?? string.Empty;
            //    bool isValid = IsValidMobileNumber(phoneNumber);
            //    if (isValid)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please Eneter Valid mobile");
            //    }
            //}

            //Version 2
            //while (true)
            //{
            //    Console.WriteLine("Please enter your phonenumber?");
            //    phoneNumber = Console.ReadLine() ?? string.Empty;
            //    if (IsValidMobileNumber(phoneNumber))
            //        break;
            //    else
            //        Console.WriteLine("Please Eneter Valid mobile");
            //}

            //Version 3
            do
            {
                Console.WriteLine("Please enter your phonenumber?");
                phoneNumber = Console.ReadLine() ?? string.Empty;
                if (Utility.IsValidMobileNumber(phoneNumber))
                    break;
                else
                    Console.WriteLine("Please Eneter Valid mobile");
            } while (true);


            Utility.ShowWarmWellcomeMessage("Parham");
            string wellComeMessage = Utility.GetWellComeMessage();
            int res = Utility.Add(x: 15, y: 25);

            Console.WriteLine("Please enter your username?");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password?");
            string password = Console.ReadLine();

            Console.WriteLine("You entered username: " + username + " and password: " + password);
            Console.ResetColor();
        }
    }
}
