using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UtiliteGetNumber
{
    internal class Program
    {
        class Utilite
        {
            public static void ShowReceivedNumber()
            {
                int number = GetNumber();
                Console.WriteLine($"Число - {number}");
            }

            public static int GetNumber()
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
                    else
                        isEnterNumber = false;
                }

                return enterNumber;
            }

            public static int GetNumber(char signNumber)
            {
                bool isEnterNumber = true;
                int enterNumber = 0;
                string userInput;

                while (isEnterNumber)
                {
                    Console.WriteLine($"Введите число.");

                    userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out enterNumber) == false)
                    {
                        Console.WriteLine("Не корректный ввод.");
                    }
                    else if(signNumber=='-')
                    {
                        if (GetNumberRange(enterNumber))
                        {
                            Console.WriteLine("Число отрицательное, нужно ввести положительное.");
                        }
                        else
                            isEnterNumber = false;
                    }
                    else
                    {
                        isEnterNumber = false;
                    }
                }

                return enterNumber;
            }

            private static bool GetNumberRange(int number)
            {
                int positiveValue = 0;

                if (number < positiveValue)
                    return true;

                return false;
            }
        }
    }
}