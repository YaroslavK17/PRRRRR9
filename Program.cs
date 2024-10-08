//***********************************************************
//* Практическая работа № 9                                 *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pr_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\t\tЗдравствуйте!");
                Console.WriteLine("\t\t\t\t\t\tПрактическая работа №9");
                Console.WriteLine("Вариант №2, Задание №5");
                try
                {
                    Random random = new Random();
                    int[] arr = new int[50];
                    int sum = 0;
                    //Заполнение массива случайными нечетными числами
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int oddNumber;
                        do
                        {
                            oddNumber = random.Next(1, 100);
                        } while (oddNumber % 2 == 0);
                        arr[i] = oddNumber;
                        sum += oddNumber;
                    }
                    double arithmeticMean = (double)sum / arr.Length; // Среднее арифметическое
                    double theSumOfSquares = 0; // sumOfSquares - сумма квадратов
                    foreach (var number in arr)
                    {
                        theSumOfSquares += Math.Pow(number - arithmeticMean, 2);
                    }
                    double standardDeviation = Math.Sqrt(theSumOfSquares / arr.Length);
                    Console.WriteLine("\nМассив случайных нечетных чисел - ");
                    Console.WriteLine(string.Join(", ", arr));
                    Console.WriteLine($"Сумма - {sum}");
                    Console.WriteLine($"Среднее арифметическое {Math.Round(arithmeticMean, 2)}");
                    Console.WriteLine($"Среднее квадратическое - {Math.Round(standardDeviation, 2)}");
                    Console.WriteLine("\t\t\t\t\t\tХотите продолжить? (да/нет)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer != "да") break;
                }
                catch (IndexOutOfRangeException iOfREx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникла ошибка - {iOfREx.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (DivideByZeroException dByZEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникла ошибка - {dByZEx.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.ReadLine();
            }
        }
    }
}
