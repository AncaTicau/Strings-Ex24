using System;

namespace StringsEx24
{
    class Program
    {
        static void Main(string[] args)
        {
            //string givenString = "This is a string";
            string givenString = "Th";
            Console.WriteLine(GetStringFirstTwoAndLastTwoChar(givenString));
        }
        //Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string.
        public static string GetStringFirstTwoAndLastTwoChar(string input)
        {
            if (input.Length < 2)
            {
                return string.Empty;
            }

            string firstTwoChars = input.Substring(0, 2);
            string lastTwoChars = input.Substring(input.Length - 2);
            string newString = firstTwoChars + lastTwoChars;

            return newString;
        }
    }
}
