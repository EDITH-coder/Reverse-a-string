using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            //Declare and initialize a string
            String word = Console.ReadLine();
            //Converted a string into array
            char[] Arrword= word.ToCharArray();
            //reverse an array
            Array.Reverse(Arrword);
        
            //created a variable and asign the results of the reverse
            string reversedWrd= new String(Arrword);

            Console.WriteLine("The original word is: " + word);
            Console.WriteLine("The reversed word is: " + reversedWrd);
            Console.WriteLine();
            Console.WriteLine("***************************");
            //Check if the string is palindrome
            if(word==reversedWrd)
            {
                Console.WriteLine("The word is palidrome");
            }
            else
            {
                Console.WriteLine("The word is not palindrome");
            }
            Console.ReadLine();
        }
    }
}
