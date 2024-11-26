﻿using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UtiliteGetNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilite.ShowReceivedNumber();
        }

        class Utilite
        {
            public static void ShowReceivedNumber()
            {
                int number = GetNumber();
                Console.WriteLine($"Число - {number}");
            }

            public static int GetNumber(int lowerLimitRangeNumbers = Int32.MinValue, int upperLimitRangeNumbers = Int32.MaxValue)
            {
                bool isEnterNumber = true;
                int enterNumber = 0;
                string userInput;

                while (isEnterNumber)
                {
                    Console.WriteLine($"Введите число.");

                    userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out enterNumber) == false)
                        Console.WriteLine("Не корректный ввод.");
                    else if (VerifyForAcceptableNumber(enterNumber, lowerLimitRangeNumbers, upperLimitRangeNumbers))
                        isEnterNumber = false;
                }

                return enterNumber;
            }

            private static bool VerifyForAcceptableNumber(int number, int lowerLimitRangeNumbers, int upperLimitRangeNumbers)
            {
                if (number < lowerLimitRangeNumbers)
                {
                    Console.WriteLine($"Число вышло за нижний предел допустимого значения.");
                    return false;
                }
                else if (number > upperLimitRangeNumbers)
                {
                    Console.WriteLine($"Число вышло за верхний предел допустимого значения.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}