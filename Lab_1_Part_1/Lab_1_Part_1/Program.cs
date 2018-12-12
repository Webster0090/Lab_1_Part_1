using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
namespace Lab_1_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                double user1, user2, user3;

                Console.WriteLine("Hello! Please enter three dollar amount values! "); // This line prompts the user the enter numbers
                List<double> currancy = new List<double>(); // This is adding the numbers the user has entered to a list array

                Console.WriteLine("Please enter your first number"); // Taking the entered numbers and adding it to the currency list.
                user1 = double.Parse(Console.ReadLine());
                currancy.Add(user1);
                Console.WriteLine("Please enter your second number");
                user2 = double.Parse(Console.ReadLine());
                currancy.Add(user2);
                Console.WriteLine("Please enter your third number");
                user3 = double.Parse(Console.ReadLine());
                currancy.Add(user3);


                Console.WriteLine("_________\n");
                Console.WriteLine($"US dollar {user1.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}"); // This line is converting each number into a dollar amount
                Console.WriteLine($"Swedish {user1.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE"))}");
                Console.WriteLine($"Thai {user1.ToString("c", CultureInfo.CreateSpecificCulture("th-TH"))}");
                Console.WriteLine($"Japanies Yen {user1.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");

                Console.WriteLine("_________\n");
                Console.WriteLine($"US dollar {user2.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");
                Console.WriteLine($"Swedish {user2.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE"))}");
                Console.WriteLine($"Thai {user2.ToString("c", CultureInfo.CreateSpecificCulture("th-TH"))}");
                Console.WriteLine($"Yen {user2.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");

                Console.WriteLine("_________\n");
                Console.WriteLine($"US dollar {user3.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");
                Console.WriteLine($"Swedish {user3.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE"))}");
                Console.WriteLine($"Yen {user3.ToString("c", CultureInfo.CreateSpecificCulture("th-TH"))}");
                Console.WriteLine($"US dollar {user3.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"))}");



                Console.WriteLine("_________\n");
                Console.WriteLine("Lowest number is {0}", currancy.Min()); // Taking the minimum, maximum and average 
                Console.WriteLine("Highest number is {0}", currancy.Max());
                Console.WriteLine(String.Format("Average is {0:0}", currancy.Average())); 

                Console.WriteLine("\nWould you like to to run this program agian, y/n?"); // This line is asking the user if they would like to continue with the program
                string userAnswer = Console.ReadLine().ToLower(); //Taking in the user input and using ToLower to ensure it is not case sensative

                if (userAnswer == "y") // If the user enters "Y" or "y" the program will continue and start from the begining 
                {
                    continue;

                }
                else if (userAnswer == "n") //If the user enters "N" or "n" it will break the while loop and the program will end
                {
                    Console.WriteLine("Thanks for coming! Goodbye!");
                    break;
                }


            }
        }
    }
}


           

            


            






