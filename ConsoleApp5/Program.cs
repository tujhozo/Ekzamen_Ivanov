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
    class Newsstand
    {
        static void Main(string[] args)
        {
            Magazine rty = new Magazine();
            int n, m = 0;
            Console.Write("Введите размер массива: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ошибка ввод, Введитее ещё раз: ");
            }
            object[] mas = new object[n * 4];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите название: ");
                rty.name = Console.ReadLine();
                mas[m] = rty.name;
                m++;
                Console.Write("Введите издателя: ");
                rty.izdatel = Console.ReadLine();
                mas[m] = rty.izdatel;
                m++;
                Console.Write("Введите цену: ");
                while (!int.TryParse(Console.ReadLine(), out rty.price))
                {

                }
                mas[m] = rty.price;
                m++;
                Console.Write("Введите ISSN: ");
                while (!int.TryParse(Console.ReadLine(), out rty.ISSN))
                {

                }
                mas[m] = rty.ISSN;
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
