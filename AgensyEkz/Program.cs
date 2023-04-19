using System;

namespace AgensyEkz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка работы программы о турагенстве");
            Console.WriteLine("Пожалуйста, введите название турагенства:");
            string name = Console.ReadLine();
            Console.WriteLine("Пожалуста, введите размер массива (количество рейсов):");
            int.TryParse(Console.ReadLine(), out int size);

        }
    }
}
