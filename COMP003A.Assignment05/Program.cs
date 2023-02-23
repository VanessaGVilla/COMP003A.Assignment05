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
            
        }





        /// Builds an isosceles triangle using the given character and size
        /// </summary>
        /// <param name="inputCharacter">The character to use for building the triangle</param>
        /// <param name="size">The size of the triangle</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
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
                output = output.Substring(o, i);
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