using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*internal class StringFormatter
    {
       //format a string to uppercase
        public string Format(string input)
        {
            return input.ToUpper();
        }
        //format a string a given number of times
        public string Format(string input, int count)
        {
            return string.Concat(Enumerable.Repeat(input, count));
        }
        //concatantes 2 string with a space
        public string Format(string first, string second)
        {
            return $"{first} {second}"; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringFormatter formatter = new StringFormatter();
            Console.WriteLine("Choose a formatting option:");
            Console.WriteLine("1. Uppercase");
            Console.WriteLine("2. Repeat");
            Console.WriteLine("3. Concatanate");
            Console.WriteLine("Enter the option (1, 2, 3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a string: ");
                    string input1 = Console.ReadLine();
                    string upper=formatter.Format(input1);
                    Console.WriteLine($"Uppercase: {upper}");
                    break;
                case 2:
                    Console.Write("Enter a string: ");
                    string input2 = Console.ReadLine();
                    Console.Write("Enter the count:");
                    int count = int.Parse(Console.ReadLine());
                    string repeated = formatter.Format(input2, count);
                    Console.WriteLine($"Repeated: {repeated}");
                    break;
                case 3:
                    Console.Write("Enter the first String: ");
                    string first = Console.ReadLine();
                    Console.Write("Enter the second string: ");
                    string second = Console.ReadLine();
                    string concatenated = formatter.Format(first, second);
                    Console.WriteLine($"Concatenated: {concatenated}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }*/
}
