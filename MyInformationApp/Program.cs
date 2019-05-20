using System;

namespace MyInformationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input taken
            Console.WriteLine("\t\t\t\tMy Information Application");
            Console.WriteLine("\t\t\t========================================");
            Console.WriteLine("Provide Us Your Information (:-");
            Console.WriteLine("\n");
            Console.Write("Please Enter Your Full Name : ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Current Address : ");
            string address = Console.ReadLine();
            Console.Write("Please Enter Your Mobile No : ");
            string mobileNo = Console.ReadLine();
            Console.Write("Please Enter Your Date Of Birth : ");
            string dob = Console.ReadLine();
            Console.Write("Please Enter Your Age : ");
            int age =Convert.ToInt32(Console.ReadLine());
            //Show output
            Console.WriteLine("\n\t\t\t\tShow Your All Information :- ");
            Console.WriteLine("\t\t\t========================================");
            Console.WriteLine("\n");
            Console.WriteLine("Name \t\t\tAddress \t\t\tMobile No \t\tDate of Birth \t\t\tAge");
            Console.WriteLine("============================================================================================================");
            Console.WriteLine(name + " \t\t" + address + " \t\t" + mobileNo + " \t\t" + dob + " \t\t\t" + age);
            Console.Write("\nThanks for stay with us...");
            Console.ReadKey();

        }
    }
}
