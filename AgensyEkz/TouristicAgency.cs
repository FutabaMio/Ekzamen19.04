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
        public TouristicAgency(int x)
        {
            tours = new Tour[x];
        }

        //функция сортировки
        public void Sort(Tour[] tours)
        {
            Tour buf;
            for(int i=0; i < tours.Length; i++)
            {
                for(int j=i+1; j<tours.Length-1; j++)
                {
                    buf.
                }
            }
        }
    }
}
