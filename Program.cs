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

            public static void ShowReceivedPositiveNumber()
            {
                int number = GetPositiveNumber();
                Console.WriteLine($"Число - {number}");
            }

            public static int GetNumber(int enterNumber = 0)
            {
                bool isEnterNumber = true;

                while (isEnterNumber)
                {
                    Console.WriteLine($"Введите число.");

                    if (TryGetNumber(out int number) == true)
                    {
                        isEnterNumber = false;
                        enterNumber = number;
                    }
                }

                return enterNumber;
            }

            public static int GetPositiveNumber(int enterPositiveNumber = 0)
            {
                bool isEnterNumber = true;

                while (isEnterNumber)
                {
                    Console.WriteLine($"Введите число.");

                    if (TryGetNumber(out int number) == true)
                    {
                        enterPositiveNumber = number;

                        if (GetNumberRange(enterPositiveNumber))
                        {
                            Console.WriteLine("Число отрицательное, нужно ввести положительное.");
                        }
                        else
                            isEnterNumber = false;
                    }
                }

                return enterPositiveNumber;
            }

            public static bool TryGetNumber(out int numder)
            {
                string userInput;

                do
                {
                    userInput = Console.ReadLine();
                }
                while (TryGetInputValue(userInput, out numder));

                return true;
            }

            private static bool TryGetInputValue(string input, out int number)
            {
                if (int.TryParse(input, out number) == false)
                {
                    Console.WriteLine("Не корректный ввод.");
                    return true;
                }

                return false;
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