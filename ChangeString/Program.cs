using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nplease insert a string: ");
            string str = Console.ReadLine();

            Console.Write("please insert a char to be removed from the string: ");
            char charToBeRemoved = char.Parse(Console.ReadLine());
            
            string newString = "";
            foreach(char character in str) {
                if (character == charToBeRemoved) continue;
                newString += character;
            }
        
            Console.WriteLine($"\nthis is you treated string with all the {charToBeRemoved} removed: {newString}");
        }
    }
}
