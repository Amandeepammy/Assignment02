using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        public static int Menu_Selection_Validation()
        {
            string user_input = string.Empty;
            bool loop_flag = false;

            while (loop_flag == false)
            {
                Console.WriteLine("1 = Enter Triangle Dimensions");
                Console.WriteLine("2 = Exit\n");

                Console.WriteLine("Please select an option 1 or 2, by entering a number:\n");
                user_input = Console.ReadLine();

                if (user_input != "1" &&
                    user_input != "2")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }
                else
                {
                    loop_flag = true;
                }
            }

            Console.WriteLine();
            return int.Parse(user_input);
        }

        public static int User_Input_Validation(string selected_option)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {selected_option} of the Triangle:");
                string user_input = Console.ReadLine();
                Console.WriteLine();

                bool result = (int.TryParse(user_input, out aNumber));

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again with a positive integer value.\n");
                }
                else if (aNumber == 0)
                {
                    Console.WriteLine("Please Enter The values above 0, as the length and width cannot be zero.\n");
                }
                else if (aNumber < 0)
                {
                    Console.WriteLine("Please Enter The values above 0, as the sides of Triangle cannot be less than zero.\n");
                }
                else if (aNumber > 32767)
                {
                    Console.WriteLine("Please Enter The values below 32767 as it is the maximum integer range.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Your entered {selected_option} of the Triangle is: {aNumber}.\n");
                }
            }

            return aNumber;
        }


        static void Main(string[] args)
        {
            int selection;
            selection = Menu_Selection_Validation();

            while (selection != 2)
            {
                switch (selection)
                {
                    case 1:
                        int first_side;
                        int second_side;
                        int third_side;

                        first_side = User_Input_Validation("First Side");
                        second_side = User_Input_Validation("Second Side");
                        third_side = User_Input_Validation("Third Side");

                        Console.WriteLine("You provided sides of the Triangle are {0}, {1} and {2}\n", first_side, second_side, third_side);

                        Console.WriteLine(TriangleSolver.Analyze(first_side, second_side, third_side));
                        break;


                        default:
                        break;
                }

                selection = Menu_Selection_Validation();

            }

        }
    }
}
