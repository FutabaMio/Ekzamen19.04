using System;
using System.IO;

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
            Tour[] tours = new Tour[size];
            TouristicAgency agency= new TouristicAgency(name, size);
        }
    }
}
