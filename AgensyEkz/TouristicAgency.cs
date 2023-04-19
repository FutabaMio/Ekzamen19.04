using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AgensyEkz
{
    public class TouristicAgency
    {
        //поля
        //string name;
         //int x;
        //Tour[] tours1;

        //конструктор
        public TouristicAgency(int size)
        {
            //name = s;
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

            

            //Filling(tours);
            //Sort(tours);
           // WriteToFile(tours);
        }

        //функция заполнения массива
        /*public void Filling(Tour[] tours)
        {
            for(int i=0; i<tours.Length; i++)
            {
                Console.WriteLine("Направление поездки:");
                tours[i].travelDirection = Console.ReadLine();
                Console.WriteLine("Продолжительность поездки:");
                int.TryParse(Console.ReadLine(), out int time);
                tours[i].time = time;
                Console.WriteLine("Цена поездки:");
                int.TryParse(Console.ReadLine(), out int price);
                tours[i].price = price;


            }
        }*/

        //функция сортировки
        public void Sort(Tour[] tours)
        {
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
        }

        //функция записи в файл
        public void WriteToFile(Tour[] tours)
        {
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
            catch(IOException exc)
            {
                Console.WriteLine("Похоже, что-то пошло не так. Попробуйте ещё раз.");
            }
            catch(ObjectDisposedException exc)
            {
                Console.WriteLine("Похоже, что-то пошло не так. Попробуйте ещё раз.");
            }
        }
    }
}
