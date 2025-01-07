using LearnCSharp0308.General;
using LearnCSharp0308.Models;

namespace LearnCSharp0308
{

    //Comment کامنت
    // User Define Datatype
    //Container for peoprties(data) and methods
    //Proprty , Method
    //Private, Public, internal -> Access Modifier
    //DRY => Dont repeat yoourself
    internal class Program
    {

        static void Main(string[] args)
        {
            AdminUser adminUser = new AdminUser();

            string ValidUsername = "admin";
            string ValidPassword = "123";

            do
            {
                Console.WriteLine(CustomMessage.GetUsername);
                string username = Console.ReadLine() ?? string.Empty;

                Console.WriteLine(CustomMessage.GetPassword);
                string password = Console.ReadLine() ?? string.Empty;

                if (username == ValidUsername && password == ValidPassword)
                    break;
                else
                    Console.WriteLine(CustomMessage.PleaseEnterValidData);
            } while (true);

            Utility.ShowWarmWellcomeMessage();

            Student student = new Student();
            Console.WriteLine("Please enter your FirstName?");
            do
            {
                Console.WriteLine(CustomMessage.GetFirstName);
                student.FirstName = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrEmpty(student.FirstName))
                    break;
                else
                    Console.WriteLine("Please Eneter Valid FirstName");
            } while (true);

            
            Console.ResetColor();
        }
    }
}
