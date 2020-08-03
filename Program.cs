using System;
using System.Collections.Generic;

namespace Lab10
{
    public class Program
    {
        public static bool UserContinueSelection { get; private set; } = true;

        static void Main(string[] args)
        {
            while (UserContinueSelection == true)
            {

                List<Circle> circleList = new List<Circle>();
                Console.WriteLine("Enter a radius");
                var userInput = Console.ReadLine();
                bool success = Double.TryParse(userInput, out double radius);

                if (success)
                {
                    var circle = new Circle(radius);
                    circleList.Add(circle);

                    Console.WriteLine($"The circumfrance is: {circle.CalculateFormattedCircumference()}");
                    Console.WriteLine($"The area is: {circle.CalculateFormattedArea()}");

                    UserContinue();
                }
                else
                {
                    Console.WriteLine($"Plese put valid input");
                }
            }
        }
        private static void UserContinue()
        {
            Console.WriteLine("Do you want to continue? (Y/N)");
            var userContinue = Console.ReadLine();

            if (userContinue.Contains("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                UserContinueSelection = true;
            }
            else
            {
                UserContinueSelection = false;
            }
        }
    }
}
