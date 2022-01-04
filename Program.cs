﻿using System;

namespace DZ_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 3.Игра «Угадай число» 
            //Что нужно сделать
            //Разработайте программу по следующему алгоритму:
            //Пользователь вводит максимальное целое число диапазона. 
            //На основе диапазона целых чисел(от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона.
            //Пользователю предлагается ввести загаданное программой случайное число.Пользователь вводит свои предположения в консоли приложения.
            //Если число меньше загаданного, программа сообщает об этом пользователю. 
            //Если больше, то тоже сообщает, что число больше загаданного.
            //Программа завершается, когда пользователь угадал число.
            ///Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая, какое число было загадано.
            
            Console.WriteLine("Введите максимальное целое число больше нуля");                          //Запрашиваем ввод максимального возможного числа
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();                                                               //Объявляем переменную для псевдослучайного выбора числа
            int r  = random.Next(max);                                                                  //Объявляем переменную типа int и присваиваем ей псевдослучайное значение в диапазоне от 0 до максимального значения пользователя

            while (true)                                                                                //Запускаем цикл while
            {
                Console.WriteLine("Введите число");                                                     //Запрашиваем пользователя ввести случайное число
                string x = Console.ReadLine();                                                          //Объявляем переменную типа string для инициализации пустого значения 
                if (x == "")                                                                            //Вводим условие: Если введено пустое значение, то выводим сообщение и останавливаем цикл
                {
                    Console.WriteLine($"Вы ввели пустое значение. Загаданное число равнялось {r}");     
                    break;
                }
                else                                                                                    //В противном случае преобразуем переменную x типа string в новую переменную y типа int для сравнения чисел
                {
                    int y = int.Parse(x);
                    if (y < r)                                                                          //Вводим условия сравнения чисел вводимых пользователей с загаданным и выводим соответствующее сообщение. Если пользователь угадал, останавливаем цикл.
                    {
                        Console.WriteLine($"Ваше число меньше загаданного");
                    }
                    else if (y > r)
                    {
                        Console.WriteLine($"Ваше число больше загаданного");
                    }
                    else
                    {
                        Console.WriteLine($"Поздравляем! Вы угадали число");
                        break;
                    }
                }
            }

        }
    }
}
