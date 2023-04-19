using System;
using System.IO;

namespace AgensyEkz
{

    class Program
    {            
        
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка работы программы о турагенстве");
            Console.WriteLine("Пожалуста, введите размер массива (количество рейсов):");
            int.TryParse(Console.ReadLine(), out int size);
            TouristicAgency agency= new TouristicAgency(size);

            Tour[] tours = new Tour[size];
            for (int i = 0; i < tours.Length; i++)
            {

                Console.WriteLine("Направление поездки:");
                string plate = string.Empty;
                plate = Console.ReadLine();
                tours[i].travelDirection = plate;
                Console.WriteLine(plate);
                Console.WriteLine(tours[i].travelDirection);
                Console.WriteLine("Продолжительность поездки:");
                int.TryParse(Console.ReadLine(), out int time);
                tours[i].time = time;
                Console.WriteLine("Цена поездки:");
                int.TryParse(Console.ReadLine(), out int price);
                tours[i].price = price;

            }

            Tour buf;
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].time < tours[i + 1].time)
                {
                    buf = tours[i];
                    tours[i] = tours[i + 1];
                    tours[i + 1] = buf;
                }
            }
            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].price < tours[i + 1].price)
                {
                    buf = tours[i];
                    tours[i] = tours[i + 1];
                    tours[i + 1] = buf;
                }
            }

            try
            {
                FileStream fs = new FileStream("Sorted Tours.txt", FileMode.OpenOrCreate);
                StreamWriter sr = new StreamWriter(fs);
                for (int i = 0; i < tours.Length; i++)
                {
                    string corrected = $"Направление: {tours[i].travelDirection}, длительность: {tours[i].time}, цена: {tours[i].price} \n";
                    sr.Write(corrected);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Похоже, что-то пошло не так. Попробуйте ещё раз.");
            }
            catch (ObjectDisposedException exc)
            {
                Console.WriteLine("Похоже, что-то пошло не так. Попробуйте ещё раз.");
            }


        }
    }
}
