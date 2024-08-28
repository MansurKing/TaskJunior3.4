using System;

namespace TaskJunior3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitFromConsole = "exit";
            string sum = "sum";
            string userInput = "0";
            string numberCommand = "number";

            int numberEntering = 0;

            bool isWork = true;

            int[] nambers = new int[0];

            Console.WriteLine("Добро пожаловать в мир 'Динамических массивов'\n");
            Console.WriteLine($"Введите команду:\n" +
                              $"{sum} - программа выведет сумму всех веденных чисел.\n" +
                              $"{exitFromConsole} - завершение работы программы.\n" +
                              $"{numberCommand} - ввод любого числа для сохранения его в массиве.\n");
            while (isWork)
            {
                Console.Write("\nВведенные вами числа: ");

                for (int i = 0; i < nambers.Length; i++)
                {
                    ConsoleColor defautColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(nambers[i] + " ");
                    Console.ForegroundColor = defautColor;
                }

                Console.Write("\nВведите команду: ");
                userInput = Console.ReadLine();

                if (userInput == numberCommand)
                {
                    Console.Write("\nВведите число: ");
                    numberEntering = Convert.ToInt32(Console.ReadLine());

                    int[] tempNambers = new int[nambers.Length + 1];

                    for (int i = 0; i < nambers.Length; i++)
                    {
                        tempNambers[i] = nambers[i];
                    }

                    tempNambers[tempNambers.Length - 1] = numberEntering;
                    nambers = tempNambers;
                }
                else if (userInput == sum)
                {
                    int sumOfAllIndexes = 0;

                    for (int i = 0; i < nambers.Length; i++)
                    {
                        sumOfAllIndexes += nambers[i];
                    }

                    Console.WriteLine($"\nСумма всех введенных вами чисел - {sumOfAllIndexes}");
                }
                else if (userInput == exitFromConsole)
                {
                    isWork = false;
                    Console.WriteLine("\nПрограмма завершена.");
                }
                else
                {
                    ConsoleColor defautColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nВы ввели неправильные значения, попробуйте еще раз).\n");
                    Console.ForegroundColor = defautColor;
                }
            }
        }
    }
}
