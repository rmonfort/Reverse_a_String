using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string userInput = Console.ReadLine();
            string reversedString = ReverseString(userInput);
            Console.WriteLine(reversedString);
        }

        // Reverses a given string and returns the reversed string
        private static string ReverseString(string stringToReverse)
        {
            char[] charactersInString = stringToReverse.ToCharArray(); // Convert string to char array
            Array.Reverse(charactersInString); // Reverse characters in array
            return new string(charactersInString); // Return reversed character array as a string
        }
    }
}
