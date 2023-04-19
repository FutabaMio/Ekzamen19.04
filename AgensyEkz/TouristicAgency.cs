using System;
using System.Collections.Generic;
using System.IO;
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
                try
                {
                Console.WriteLine("Направление поездки:");
                tours[i].travelDirection = Console.ReadLine();
                Console.WriteLine("Продолжительность поездки (пожалуйста придерживайтесь формата ЧЧ.ММ):");
                tours[i].time = double.Parse(Console.ReadLine());
                Console.WriteLine("Цена поездки:");
                tours[i].price = double.Parse(Console.ReadLine());
                }
                catch (FormatException exc){
                    Console.WriteLine("Обнаружено несоответствие форматов, проверьте введённые данные.");
                }
                catch(ArgumentNullException exc)
                {
                    Console.WriteLine("Похоже, вы ничего не ввели, попрбуйте ещё раз.");
                }
                catch(OverflowException exc)
                {
                    Console.WriteLine("Похоже, вы ввели слишком большое числ, попробуйте ещё раз.");
                }
                
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
