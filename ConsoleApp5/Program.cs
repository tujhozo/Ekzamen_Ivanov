﻿using System;
using System.IO;
namespace ConsoleApp5
{
    struct Magazine
    {
        public string name;
        public string izdatel;
        public int price;
        public int ISSN;
    }
    class Mag
    {
        static void Main(string[] args)
        {
            Magazine obj = new Magazine();
            int n, m = 0;
            Console.Write("Введите размер массива = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ошибка ввода! Введитее ещё раз = ");
            }
            object[] mas = new object[n * 4];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите название = ");
                obj.name = Console.ReadLine();
                mas[m] = obj.name;
                m++;
                Console.Write("Введите издателя = ");
                obj.izdatel = Console.ReadLine();
                mas[m] = obj.izdatel;
                m++;
                Console.Write("Введите цену = ");
                while (!int.TryParse(Console.ReadLine(), out obj.price))
                {

                }
                mas[m] = obj.price;
                m++;
                Console.Write("Введите ISSN = ");
                while (!int.TryParse(Console.ReadLine(), out obj.ISSN))
                {

                }
                mas[m] = obj.ISSN;
                m++;
            }
            StreamWriter y = new StreamWriter("File.txt");
            m = 0;
            for (int i = 0; i < n; i++)
            {
                y.WriteLine("Название: " + mas[0]); m++ ;
                y.WriteLine("Издатель: " + mas[1]); m++;
                y.WriteLine("Цена: " + mas[2]); m++;
                y.WriteLine("ISSN: " + mas[3]); m++;
            }
            y.Close();
        }
    }


}
