using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("This program will calculate the area, perimiter, and volume of the classroom. Please continue below.");
                //prompt user to input number and validates entry to ensure a double was entered
                Console.WriteLine("Please enter the length (in feet) of the classroom.");
                string length = Console.ReadLine();
                while (CheckInput(length) == 0)
                {
                    Console.WriteLine("The value entered was not a positive number. The length must be a positive number. Please try again.");
                    length = Console.ReadLine();
                    CheckInput(length);
                }
                //prompt user to input number and validates entry to ensure a double was entered
                Console.WriteLine("Please enter the width (in feet) of the classroom.");
                string width = Console.ReadLine();
                while (CheckInput(width) == 0)
                {
                    Console.WriteLine("The value entered was not a positive number. The width must be a positive number. Please try again.");
                    width = Console.ReadLine();
                    CheckInput(width);
                }
                //prompt user to input number and uses CheckInput method to ensure a positive double was entered
                Console.WriteLine("Please enter the height (in feet) of the classroom.");
                string height = Console.ReadLine();
                while (CheckInput(height) == 0)
                {
                    Console.WriteLine("The value entered was not a positive number. The height must be a positive number. Please try again.");
                    height = Console.ReadLine();
                    CheckInput(height);
                }
                //TryParses to convert all user inputs into doubles from strings & initializes formulas
                bool success1 = double.TryParse(length, out double RoomLength);
                bool success2 = double.TryParse(width, out double RoomWidth);
                bool success3 = double.TryParse(height, out double RoomHeight);
                double Area = RoomLength * RoomWidth;
                double Perim = (2 * RoomLength) + (2 * RoomWidth);
                double Volume = RoomLength * RoomWidth * RoomHeight;

                //Outputs Area to console only if parses are valid
                if (success1)
                {
                    Console.WriteLine("The area of the room is {0} sq. ft.", Area);
                }

                //Outputs Perimiter to console only if parses are valid
                if (success2)
                {
                    Console.WriteLine("The perimiter of the room is: {0} feet.", Perim);
                }
                //Outputs Volume to console only if parses are valid
                if (success3)
                {
                    Console.WriteLine("The volume of the room is: {0} cubic feet.", Volume);
                }
                //Prompts user to run program again - y or Y works, anything else closes
                Console.WriteLine("Would you like to run this program again? (Y/N)");
                if (Console.ReadLine().ToLower() != ("y"))
                    break;
            }
        }
        //method to check if the input number is a positive number
        public static double CheckInput(string input)
        {
            double.TryParse(input, out double number);
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number;
            }
        }
    }
}
