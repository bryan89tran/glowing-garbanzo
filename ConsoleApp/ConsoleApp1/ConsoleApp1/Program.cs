using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersName;
            string usersAge;

            Console.WriteLine("What is your name");
            usersName = Console.ReadLine();

            Console.WriteLine("How old are you");
            usersAge = Console.ReadLine();

            //Concat string
            Console.WriteLine("Your Name is " + usersName);
            Console.WriteLine("Your age is " + usersAge);


            //Interlope string interpolation
            string response = $"Your Name is {usersName} and you are {usersAge} yours old";
            Console.WriteLine(response);

            //String Format
            string typeOfProduct = "Wiget";
            double pricePerOunce = 17.36;
            string outPutString;

            outPutString = String.Format("The current price is {0:C}", pricePerOunce);
            Console.WriteLine(outPutString);


            Console.WriteLine(String.Format("{0, 10} {1, 10}", "Type", "Price"));
            Console.WriteLine(String.Format("{0, 10} {1, 10}", typeOfProduct, pricePerOunce));

            //String literals
            Console.WriteLine("C:\\My Documents\\Home");
            Console.WriteLine(@"C:\My Documents\Home");
            
        }
    }
}
