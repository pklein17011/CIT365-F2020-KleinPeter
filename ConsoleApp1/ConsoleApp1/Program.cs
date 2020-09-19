using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            //Get user name and location. Output WriteLine statements about user
            NameLocation();

            //Output current date and days until Christmas
            DateOutput();

            //6. Add the program example from section 2.1 and run the Glazer App
            GlazerApp();

            //Prompt for exit
            PromptForExit();
        }

        private static void NameLocation()
        {
            //2. Store two variables: your name, your location
            string name, location;

            //Name and location requirements
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write($"Hi {name}! Where are you from? ");
            location = Console.ReadLine();
            Console.WriteLine($"Hello {name}, I bet the weather is nice in {location} today. Press any key to continue...");
            Console.ReadKey();

            //3. Output WriteLine statements that display the two variables.
            Console.WriteLine($"\n\n\nMy name is {name}.");
            Console.WriteLine($"I am from {location}.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DateOutput()
        {
            //4. Output current date but not time
            DateTime now = DateTime.Now;
            Console.WriteLine($"\n\n\nToday's date is {now:d}.");
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();

            //5. Output the number of days until Christmas
            int dayOfYear = now.DayOfYear;
            DateTime dateOfChristmas = new DateTime(2020, 12, 25);
            int dayOfChristmas = dateOfChristmas.DayOfYear;
            int daysUntilChristmas = dayOfChristmas - dayOfYear;
            Console.WriteLine($"\n\n\nThere are {daysUntilChristmas} days until Christmas!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //GlazerApp to calculate wood length and glass area
        private static void GlazerApp()
        {
            //7.1 Provide appropriate text labels for dimensional input

            //Variables for calculation
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Get user inputs
            //Prompt the user for a width
            Console.Write("\n\n\nPlease enter the width: ");
            widthString = Console.ReadLine();

            //Prompt the user for the height
            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();

            //Convert from string to double
            width = double.Parse(widthString);
            height = double.Parse(heightString);

            //Do all the math
            woodLength = Calclength(width, height);
            glassArea = CalcArea(width, height);

            //Return and report to the end user their calculations
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");
        }

        //Calculate the length
        private static double Calclength(double width, double height)
        {
            var result = 2 * (width + height) * 3.25;
            return result;
        }

        //Calculate the area
        private static double CalcArea(double width, double height)
        {
            var result = 2 * (width * height);
            return result;
        }

        //Prompt for exiting the program
        private static void PromptForExit()
        {
            //7.2 Cause the program to pause so it does not automatically terminate
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
