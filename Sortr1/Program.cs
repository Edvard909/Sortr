using System.Collections.Concurrent;

namespace Sortr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//For Integers
                Console.WriteLine("Enter a number of integers : ");
                int max = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter numbers : ");
                int[] numbers = new int[max];

                for (int i = 0; i < max; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                SortrForInt.QuickSort(numbers, 0, max - 1);

                Console.WriteLine("Here are your values : ");

                for (int i = 0; i < max; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }


            {//For Chars
                Console.WriteLine("Enter a number of letters: ");
                int max = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a letter : ");
                string notSortedWord = Console.ReadLine();
                var letters = notSortedWord.ToCharArray();


                char[] chars = new char[max];

                for (int i = 0; i < max; i++)
                {
                    chars[i] = Convert.ToChar(Console.ReadLine());
                }

                SortrForChar.QuickSort(chars, 0, max - 1);

                Console.WriteLine("Here are your values : ");

                for (int i = 0; i < max; i++)
                {
                    Console.Write(chars[i] + " ");
                }
            }


            {//For Double
                Console.WriteLine("Enter a number of decimal numbers : ");
                int max = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter decimal numbers : ");
                double[] numbers = new double[max];

                for (int i = 0; i < max; i++)
                {
                    numbers[i] = Convert.ToDouble(Console.ReadLine());
                }

                SortrForDouble.QuickSort(numbers, 0, max - 1);

                Console.WriteLine("Here are your values : ");

                for (int i = 0; i < max; i++)
                {
                    Console.Write(numbers[i] + "   ");
                }
            }


        }

    }
}