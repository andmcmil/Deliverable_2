using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ActivityID = 0;
            int AmountofPeople = 0;
            string Activity = "";
            string ModeofTransport = "";
            string ActivityType = "";
            //Ask and recieve inputs for activites and mode of transportation
            Console.WriteLine("Hello! What are you in the mood for?");
            Console.WriteLine("Your Options are: 1) action, 2) chill Times, 3) danger, 4) good food");
            ActivityID = Convert.ToInt32((Console.ReadLine()));
            //Determine activity
            if (ActivityID == 1)
            {
                Activity = "stock car racing";
                ActivityType = "action";
            }
            else if (ActivityID == 2)
            {
                Activity = "hiking";
                ActivityType = "chill times";
            }
            else if (ActivityID == 3)
            {
                Activity = "skydiving";
                ActivityType = "danger";
            }
            else if (ActivityID == 4)
            {
                Activity = "Taco Bell";
                ActivityType = "good food";
            }
            else Console.WriteLine("Invalid entry. Please try again. Thank you!");

            //Determine appropriate mode of transportation
            Console.WriteLine("How many people are you bringing with you?");
            AmountofPeople = Convert.ToInt32(Console.ReadLine());
            if (AmountofPeople == 0)
                ModeofTransport = "sneakers";
            else if (AmountofPeople >= 1 && AmountofPeople <= 4)
                ModeofTransport = "a sedan";
            else if (AmountofPeople >= 5 && AmountofPeople <= 10)
                ModeofTransport = "a Volkswagen bus";
            else if (AmountofPeople >= 11)
                ModeofTransport = "an airplane";
            else Console.WriteLine("Invalid entry. Please try again. Thank you!");

            //Make suggestion
            if (ActivityID < 1 || ActivityID > 4)
                Console.WriteLine("Invalid activity option choice. Please choose a valid option. Thank you!");
            else if (AmountofPeople < 0)
                Console.WriteLine("Invalid amount of people. Please enter a valid amount of people. Thank you!");
            else if (ActivityID < 1 || ActivityID > 4 && AmountofPeople < 0)
                Console.WriteLine("Invalid activity option choice and invalid number of people. Please re-enter valid activity option choice and number of people. Thank you!");
            else Console.WriteLine("Okay, if you are in the mood for " + ActivityType + ", then I would recommend " + Activity + " with " + ModeofTransport + " as your transportation.");

            Console.WriteLine("Goodbye!");
            Console.ReadKey();

        }
    }
}