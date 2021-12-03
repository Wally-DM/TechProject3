using System;

namespace TechProject3
{
    class Program
    {
        // David Wallace - Tech Porject 3
        // this number will be how Kilometers are converted to Miles.
        const decimal KM_TO_M = 0.621371m;

        // this will try to cap off the maximum distance shown to be only 200.
        const int MAXIMUM_DISTANCE = 200;

        // this will display the output for the Miles
        static void header()
        {
            Console.WriteLine("Kilometers\t Miles");
        }
        static void Main(string[] args)
        {
            // As the user for input
            Console.Write("Enter a Kilometer-Increment value, an integer between 10 and 25:");

            /*
            Use the try catch block to validate user input.
            If the user provides bad input, the catch
            will handle the error and a message will be displayed.
            */

            int distance_inc;

            try
            {
                // this will try to get an appropirate integer from the user.

                do
                {

                    // this will test and see if the number the user entered is valid.
                    if (!int.TryParse(Console.ReadLine(), out distance_inc) && distance_inc >= 0 && distance_inc <= MAXIMUM_DISTANCE)
                    {
                        Console.WriteLine("You need to enter a number less than " + MAXIMUM_DISTANCE.ToString() + ".\n");
                    }

                }
                while (distance_inc <= 0 || distance_inc > MAXIMUM_DISTANCE);

                // this will display the header set earlier
                header();

                // this will loop until the set maximum distance.
                int Distance = distance_inc;
                while (Distance <= MAXIMUM_DISTANCE)
                {
                    // this will show the Kilometers
                    Console.WriteLine(Distance);

                    // this will show the Miles
                    Console.Write("\t\t");
                    Console.WriteLine((Distance * KM_TO_M).ToString("0.0"));

                    // this will hopefully increment the distance each time!
                    Distance += distance_inc;
                }

            } // End of try
            catch
            {
                Console.WriteLine("Please enter an appropriate integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);

            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
