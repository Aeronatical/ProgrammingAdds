﻿using System;
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
        {
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
        {
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
        {
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
        {
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
        {
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
    }
}
