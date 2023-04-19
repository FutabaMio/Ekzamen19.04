using System;
using System.Collections.Generic;
using System.Text;

namespace AgensyEkz
{
    public class TouristicAgency
    {
        //поля
        string name;
        public Tour[] tours;

        //конструктор
        public TouristicAgency(string s, int x)
        {
            name = s;
            tours = new Tour[x];
        }

        //функция заполнения массива
        public void Filling(Tour[] tours)
        {
            for(int i=0; i<tours.Length; i++)
            {
                Console.WriteLine("Направление поездки:");
                tours[i].travelDirection = Console.ReadLine();
                Console.WriteLine("Продолжительность поездки (пожалуйста придерживайтесь формата ЧЧ.ММ):");
                tours[i].time = double.Parse(Console.ReadLine());
                Console.WriteLine("Цена поездки:");
                tours[i].price = double.Parse(Console.ReadLine());
            }
        }

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
        public void WriteToFile()
        {

        }
    }
}
