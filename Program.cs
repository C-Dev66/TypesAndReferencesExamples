using System;

namespace TypesAndReferencesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example showing which types can be converted

            /*
            float myFloatValue = 10;
            int myIntValue = (int) myFloatValue;
            Console.WriteLine("myIntValue is " + myIntValue);

            int myInt = 36;
            float myFloat = 16.4F;
            myFloat = myInt + myFloat;
            */


            // Testing which types can be cast, & which can't

            /*
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            bool myBool = (bool)myDouble;
            string myString = "false";
            myBool = (bool)myString;
            myString = (string)myInt;
            myString = myInt.ToString();
            myBool = (bool)myByte;
            myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;
            */

            long l = 129401930;
            short s = 516;
            double d = l - s;
            d = d / 123.456;
            Console.WriteLine("the answer is " + d);

            // This will not work b/c you cannot convert a long to a string
            // Unless you use the ToString method

            /*
            long number = 139401930;
            string text = "Player score: " + number;
            text = number;
            */

            Convert.ToString(255, 2);
            Convert.ToString(8675309, 2);

            Random random = new Random();
            

            for (int i = 0; i < 5; i++)
            {
                int value = random.Next(1, 5);
                Console.WriteLine(value);
            }
            
            static int MyMethod(bool add3)
            {
                int value = 12;

                if (add3)
                    value += 3;
                else
                    value -= 2;

                return value;
            }

        }
    }
}
