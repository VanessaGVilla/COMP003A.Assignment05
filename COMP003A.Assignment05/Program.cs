/*
    * Author: Vanessa Garcia
    * Course: COMP-003A
    * Purpose: Methods and XML Comments 5
    */

namespace COMP003A.Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  PrintSeparator("Triangle");
            //IsoscelesTriangleBuilder('/' , 10);

            //Console.WriteLIne(AgeCalculator

        }
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        static void PrintSeparator(string title)
        {
            PrintSeparator();
            Console.WriteLine($"\t{title} Section.");
            PrintSeparator();

        }

        static void IsoscelesTriangleBuilder(char inputCharacter, int size)

        {
            string output = "";
            // increasing triangle
            for (int i = 0; i < size; i++)
            {
                output += inputCharacter;
                Console.WriteLine(output);
                //Console.WriteLine("".PadRight(i, inputcharacter));
            }
            // decreasing triangle
            for (int i = size - 1; i > 0; i--)

            {
                output = output.Substring(0, i);
                Console.WriteLine(output);
            }
        }

        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;

        }

        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);

            Console.WriteLine($"{name} turns {age} this year");

        }
    }
}