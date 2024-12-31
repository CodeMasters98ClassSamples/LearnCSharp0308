namespace LearnCSharp0308.General
{
    public class Utility
    {
        public static bool IsValidMobileNumber(string mobileNumber)
        {

            try
            {
                if (string.IsNullOrEmpty(mobileNumber))
                    return false;

                mobileNumber = mobileNumber.Trim().Replace("+98", "0");

                return mobileNumber.Length == 11 ? true : false;

                //if (mobileNumber.Length == 11)
                //    return true;
                //else
                //    return false;

            }
            catch (Exception ex)
            {
                //Log to Repo:(File,Database,Queue,ELK)
                //Alter
                //return false;
                throw;
            }

        }


        public static string GetDesciptionDayOfWeek(int index)
        {
            string nameOfDay = default;
            switch (index)
            {
                case 1:
                    nameOfDay = "Saturday";
                    break;
                case 2:
                    nameOfDay = "Sunday";
                    break;
                case 3:
                    nameOfDay = "Monday";
                    break;
                case 4:
                    nameOfDay = "Tuesday";
                    break;
                case 5:
                    nameOfDay = "Tuesday";
                    break;
                default:
                    break;
            }
            return nameOfDay;
        }

        //هم ورودی دارد و هم خروجی دارد
        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public static int Add(int x, int y, int z)
        {
            int result = x + y + z;
            return result;
        }

        // نه ورودی دارد و نه خروجی دارد
        public static void ShowWellcomeMessage()
        {
            Console.WriteLine("Wellcome.");
        }

        //ورودی دارد اما خروجی ندارد
        public static void ShowWarmWellcomeMessage(string name)
        {
            Console.WriteLine($"Wellcome {name}.......");
        }

        //ورودی ندارد ولی خروجی دارد
        public static string GetWellComeMessage()
        {
            return "Wellcome......";
        }



    }
}
