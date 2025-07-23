
using System;

namespace ExtensionMethodMiniProject
{
    public static class ConsoleHelper
    { 
        //helpername depends by type - console type.
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(output)) 
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }
        public static int RequestInt(this string message)
        {
            return message.RequestInt( false);
        }

        private static int RequestInt(this string message, bool useMinMax,  int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInvalidRange = true;
            while (isValidInt == false || isInvalidRange == false)
            {
                Console.WriteLine(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInvalidRange = (output >= minValue && output <= maxValue);
                    //if (output >= minValue && output <= maxValue)
                    //{
                    //    isInvalidRange = true;
                    //}
                    //else
                    //{
                    //    isInvalidRange = false;
                    //}
                }
            }

            return output;
        }
    }
}
