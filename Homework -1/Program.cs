using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задание №1          
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            int n = mas.Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();               
            }
            Console.WriteLine("Элементы двумерного массива по диагонали:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write($"{mas[i, j]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            // Задача №2
            string[,] directory =
            {
                {"Алексей" , "88005553535"},
                {"Вероника", "88006005036"},
                {"Андрей" , "88005553535"},
                {"Стас", "88006005036"},
                {"Женя" , "88005553535"},
                {"Саша", "88006005036"},
            };
            Console.WriteLine("Телефонный справочкник");
            for (int i = 0; i < directory.GetLength(0); i++)
                Console.WriteLine($"{directory[i, 0]}; {directory[i, 1]}");
            Console.WriteLine();
            Console.WriteLine();

            // Задача №3
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            Console.WriteLine("Слово в обратном порядке");
            for (int i = word.Length - 1 ; i >=0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();

            
        }
    }
}
