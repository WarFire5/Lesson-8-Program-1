﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Чётное");
            }

            else
            {
                Console.WriteLine("Нечётное");
            }

            Console.ReadLine();
        }
    }
}
