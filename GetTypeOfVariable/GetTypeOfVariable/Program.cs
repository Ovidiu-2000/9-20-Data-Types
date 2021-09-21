using System;

namespace GetTypeOfVariable
{
    class Program
    {
        static Type GetTypeOfInput(string input)
        {
            int convertToInt;
            long convertToLong;
            double convertToDouble;
            DateTime convertToDateTime;
            bool convertToBool;
            char convertToChar;

            if (int.TryParse(input, out convertToInt))
            {
                return convertToInt.GetType();
            }
            else if(long.TryParse(input, out convertToLong))
            {
                return convertToLong.GetType();
            }
            else if(double.TryParse(input, out convertToDouble))
            {
               return convertToDouble.GetType();
            }
            else if(char.TryParse(input, out convertToChar))
            {
                return convertToChar.GetType();
            }
            else if(bool.TryParse(input, out convertToBool))
            {
                return convertToBool.GetType();
            }
            else if(DateTime.TryParse(input, out convertToDateTime))
            {
                return convertToDateTime.GetType();
            }
            return input.GetType();
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("The type of variable you entered is: " + GetTypeOfInput(input));
        }
    }
}
