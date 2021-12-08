using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class Utilities
    {

        public  static int ReadInteger()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Add the no of Spike: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice > 0)   // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }


        public static double ReadDouble()
        {
            bool validNum = false; // valid number initially set to zero
            double choice = 0.0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Add flying Speed: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = double.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice > 0.0)   // Check if the converted double lies above zero

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }


        public static double ReadDouble2()
        {
            bool validNum = false; // valid number initially set to zero
            double choice = 0.0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Add weight value: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = double.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice > 0.0)   // Check if the converted double lies above zero
                    {
                        validNum = true;  // Then set validNum to be true if the above condition holds.

                    }

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }



        public static string ReadString()
        {
            Console.Write("Add a dog color :");
            string strInput = Console.ReadLine();

            if(strInput != string.Empty)
            {
                return strInput;
            }
            else
            {
                return string.Empty;
            }
        }



        public static string ReadString2()
        {
            Console.Write("Add the wolf breed :");
            string strInput = Console.ReadLine();

            if (strInput != string.Empty)
            {
                return strInput;
            }
            else
            {
                return string.Empty;
            }
        }


        public static string ReadString3()
        {
            Console.Write("Add the head color of the worm:");
            string strInput = Console.ReadLine();

            if (strInput != string.Empty)
            {
                return strInput;
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
