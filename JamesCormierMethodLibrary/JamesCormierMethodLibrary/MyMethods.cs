using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JamesCormierMethodLibrary
{
    public class MyMethods
    {
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        public static int GetValue(int min, int max, string prompt, string errorValue = "You must enter a valid number!", string errorRange = null, string errorLow = null, string errorHigh = null)
        {
            string userPrompt = null;
            int propPrompt = 0;
            bool badValue = false;

            do
            {

                Console.Write(prompt);
                userPrompt = Console.ReadLine();

                badValue = int.TryParse(userPrompt, out propPrompt);
                if (!badValue)
                {
                    Console.Error.WriteLine(errorValue);
                    badValue = true;
                }
                else if (badValue)
                {
                    if (propPrompt < min && errorLow != null)
                    {
                        Console.WriteLine(errorLow);
                        badValue = true;
                    }
                    else if (propPrompt > max && errorHigh != null)
                    {
                        Console.WriteLine(errorHigh);
                        badValue = true;
                    }
                    else if (propPrompt < min || propPrompt > max && errorHigh == null && errorLow == null)
                    {
                        if (errorRange != null)
                        {
                            Console.WriteLine(errorRange);
                            badValue = true;
                        }
                        else if (errorRange == null)
                        {
                            Console.WriteLine("You must enter a value between {0} and {1}!", min, max);
                            badValue = true;
                        }
                    }
                    else
                    {
                        badValue = false;
                        Console.WriteLine();
                    }
                }

            }
            while (badValue);
            return propPrompt;
        }
        public static float GetValue(float min, float max, string prompt, string errorValue = "You must enter a valid number!", string errorRange = null, string errorLow = null, string errorHigh = null)
        {//remember to add the f to the end of the number to make it a float
            string userPrompt = null;
            float propPrompt = 0;
            bool badValue = false;

            do
            {

                Console.Write(prompt);
                userPrompt = Console.ReadLine();

                badValue = float.TryParse(userPrompt, out propPrompt);
                if (!badValue)
                {
                    Console.Error.WriteLine(errorValue);
                    badValue = true;
                }
                else if (badValue)
                {
                    if (propPrompt < min && errorLow != null)
                    {
                        Console.WriteLine(errorLow);
                        badValue = true;
                    }
                    else if (propPrompt > max && errorHigh != null)
                    {
                        Console.WriteLine(errorHigh);
                        badValue = true;
                    }
                    else if (propPrompt < min || propPrompt > max && errorHigh == null && errorLow == null)
                    {
                        if (errorRange != null)
                        {
                            Console.WriteLine(errorRange);
                            badValue = true;
                        }
                        else if (errorRange == null)
                        {
                            Console.WriteLine("You must enter a value between {0} and {1}!", min, max);
                            badValue = true;
                        }
                    }
                    else
                    {
                        badValue = false;
                        Console.WriteLine();
                    }
                }

            }
            while (badValue);
            return propPrompt;
        }
        public static decimal GetValue(decimal min, decimal max, string prompt, string errorValue = "You must enter a valid number!", string errorRange = null, string errorLow = null, string errorHigh = null)
        {//remember to add the m at the end of the number to make it a decimal
            string userPrompt = null;
            decimal propPrompt = 0;
            bool badValue = false;

            do
            {

                Console.Write(prompt);
                userPrompt = Console.ReadLine();

                badValue = decimal.TryParse(userPrompt, out propPrompt);
                if (!badValue)
                {
                    Console.Error.WriteLine(errorValue);
                    badValue = true;
                }
                else if (badValue)
                {
                    if (propPrompt < min && errorLow != null)
                    {
                        Console.WriteLine(errorLow);
                        badValue = true;
                    }
                    else if (propPrompt > max && errorHigh != null)
                    {
                        Console.WriteLine(errorHigh);
                        badValue = true;
                    }
                    else if (propPrompt < min || propPrompt > max && errorHigh == null && errorLow == null)
                    {
                        if (errorRange != null)
                        {
                            Console.WriteLine(errorRange);
                            badValue = true;
                        }
                        else if (errorRange == null)
                        {
                            Console.WriteLine("You must enter a value between {0} and {1}!", min, max);
                            badValue = true;
                        }
                    }
                    else
                    {
                        badValue = false;
                        Console.WriteLine();
                    }
                }

            }
            while (badValue);
            return propPrompt;
        }
        public static double GetValue(double min, double max, string prompt, string errorValue = "You must enter a valid number!", string errorRange = null, string errorLow = null, string errorHigh = null)
        {//remember to add the d at the end of the number to make it a double
            string userPrompt = null;
            double propPrompt = 0;
            bool badValue = false;

            do
            {

                Console.Write(prompt);
                userPrompt = Console.ReadLine();

                badValue = double.TryParse(userPrompt, out propPrompt);
                if (!badValue)
                {
                    Console.Error.WriteLine(errorValue);
                    badValue = true;
                }
                else if (badValue)
                {
                    if (propPrompt < min && errorLow != null)
                    {
                        Console.WriteLine(errorLow);
                        badValue = true;
                    }
                    else if (propPrompt > max && errorHigh != null)
                    {
                        Console.WriteLine(errorHigh);
                        badValue = true;
                    }
                    else if (propPrompt < min || propPrompt > max && errorHigh == null && errorLow == null)
                    {
                        if (errorRange != null)
                        {
                            Console.WriteLine(errorRange);
                            badValue = true;
                        }
                        else if (errorRange == null)
                        {
                            Console.WriteLine("You must enter a value between {0} and {1}!", min, max);
                            badValue = true;
                        }
                    }
                    else
                    {
                        badValue = false;
                        Console.WriteLine();
                    }
                }

            }
            while (badValue);
            return propPrompt;
        }
        public static long GetValue(long min, long max, string prompt, string errorValue = "You must enter a valid number!", string errorRange = null, string errorLow = null, string errorHigh = null)
        {//remember to add the L to the end of the number to make it a long
            string userPrompt = null;
            long propPrompt = 0;
            bool badValue = false;

            do
            {

                Console.Write(prompt);
                userPrompt = Console.ReadLine();

                badValue = long.TryParse(userPrompt, out propPrompt);
                if (!badValue)
                {
                    Console.Error.WriteLine(errorValue);
                    badValue = true;
                }
                else if (badValue)
                {
                    if (propPrompt < min && errorLow != null)
                    {
                        Console.WriteLine(errorLow);
                        badValue = true;
                    }
                    else if (propPrompt > max && errorHigh != null)
                    {
                        Console.WriteLine(errorHigh);
                        badValue = true;
                    }
                    else if (propPrompt < min || propPrompt > max && errorHigh == null && errorLow == null)
                    {
                        if (errorRange != null)
                        {
                            Console.WriteLine(errorRange);
                            badValue = true;
                        }
                        else if (errorRange == null)
                        {
                            Console.WriteLine("You must enter a value between {0} and {1}!", min, max);
                            badValue = true;
                        }
                    }
                    else
                    {
                        badValue = false;
                        Console.WriteLine();
                    }
                }

            }
            while (badValue);
            return propPrompt;
        }
        public static uint GetValue(uint min, uint max, string prompt, string errorValue = "You must enter a valid number!", string errorRange = null, string errorLow = null, string errorHigh = null)
        {//remember to add the u to the end of the number to make it a uint
            string userPrompt = null;
            uint propPrompt = 0;
            bool badValue = false;

            do
            {

                Console.Write(prompt);
                userPrompt = Console.ReadLine();

                badValue = uint.TryParse(userPrompt, out propPrompt);
                if (!badValue)
                {
                    Console.Error.WriteLine(errorValue);
                    badValue = true;
                }
                else if (badValue)
                {
                    if (propPrompt < min && errorLow != null)
                    {
                        Console.WriteLine(errorLow);
                        badValue = true;
                    }
                    else if (propPrompt > max && errorHigh != null)
                    {
                        Console.WriteLine(errorHigh);
                        badValue = true;
                    }
                    else if (propPrompt < min || propPrompt > max && errorHigh == null && errorLow == null)
                    {
                        if (errorRange != null)
                        {
                            Console.WriteLine(errorRange);
                            badValue = true;
                        }
                        else if (errorRange == null)
                        {
                            Console.WriteLine("You must enter a value between {0} and {1}!", min, max);
                            badValue = true;
                        }
                    }
                    else
                    {
                        badValue = false;
                        Console.WriteLine();
                    }
                }

            }
            while (badValue);
            return propPrompt;
        }
        public static bool GetKey(string repeat, ConsoleKey key1)
        { //Remember to add one do loop to the main method and have an if statement for a new bool value to make everything repeat
            bool badRepeat = false;
            do
            {
                Console.Write(repeat);
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == key1)
                    badRepeat = false;
                else
                {
                    badRepeat = true;
                    return false;
                }
            }
            while (badRepeat);
            
            return true;
        }
        public static bool GetKey(string repeat, ConsoleKey key1, ConsoleKey key2)
        { //Remember to add one do loop to the main method and have an if statement for a new bool value to make everything repeat
            bool badRepeat = false;
            do
            {
                Console.Write(repeat);
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == key1)
                    badRepeat = false;
                else if (cki.Key == key2)
                    badRepeat = false;
                else
                {
                    badRepeat = true;
                    return false;
                }
            }
            while (badRepeat);
            return true;
        }
        public static bool Power(int radAdd)
        {
            while (radAdd != 2)
            {
                if (radAdd % 2 == 0)
                {
                    radAdd = radAdd / 2;
                }
                else
                    return false;
            }
            return true;
        }
        
    
    }
}
