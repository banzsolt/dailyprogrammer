using System;
using System.Collections.Generic;

namespace _29_08_2016
{
    class Program
    {
        private static readonly List<string> BaseValues = new List<string>
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            "k", "l", "m", "m", "o", "p", "q", "r", "s", "t",
            "u", "v", "w", "x", "y", "z"
        };

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "q")
            {
                Bonus(input);

                //var highestBase = HighestBase(input);
                //var value = RevertToBase10(input, highestBase);

                //Console.WriteLine("base {0} => {1}", highestBase, value);
                input = Console.ReadLine();
            }
        }

        private static int HighestBase(string input)
        {
            var highestBase = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var baseIndex = BaseValues.IndexOf(input[i].ToString());
                highestBase = baseIndex > highestBase ? baseIndex : highestBase;
            }
            return highestBase + 1;
        }

        private static long RevertToBase10(string input, int inBase)
        {
            var result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var position = input.Length - i - 1;
                result += BaseValues.IndexOf(input[i].ToString())*(int) Math.Pow(inBase, position);
            }
            return result;
        }

        private static void Bonus(string input)
        {
            var minimumBase = HighestBase(input);
            for (int i = minimumBase; i <= 16; i++)
            {
                var value = RevertToBase10(input, i);
                Console.WriteLine("base {0} => {1}", i, value);
            }
        }
        
    }
}
