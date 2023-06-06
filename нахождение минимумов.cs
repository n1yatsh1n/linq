﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Link1_15_05_2023
{
    internal class Program
    {
        public static List<int> listInt = new List<int>();

        public static void Main()
        {
            Menu();
            var flag2 = true;
            while (flag2)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        var flag = true;
                        while (flag)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите значение: ");
                            listInt.Add(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Хотите добавить еще одно значение?\n" +
                                              "1. Да\n" +
                                              "2. Нет");
                            switch (Console.ReadKey().Key)
                            {
                                case ConsoleKey.D1:
                                    break;
                                case ConsoleKey.D2:
                                    flag = false;
                                    break;
                            }
                        }
                        goto default;
                    case ConsoleKey.D2:
                        Console.Clear();
                        if (listInt.Count == 0)
                        {
                            Console.WriteLine("Лист пуст!");
                        }
                        else
                        {
                            int number1 = listInt.Min();
                            var listEdit = (from p in listInt where p % 2 != 0 select p);
                            int number2 = listEdit.ToArray().Min();
                            Console.WriteLine($"Минимальное значение до преобразования: {number1}");
                            Console.WriteLine($"Минимальное значение после преобразования: {number2}");
                        }
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        goto default;
                    case ConsoleKey.D3:
                        Console.Clear();
                        flag2 = false;
                        break;
                    default:
                        Menu();
                        break;
                }
            }
            
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("МЕНЮ\n" +
                              "1. Заполнение списка\n" +
                              "2. Вывод результата\n" +
                              "3. Выход\n");
        }
    }
}