using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //fibonachi
            int[] ints = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int p = 0;
            Console.WriteLine("Фибоначи");
            while (p < 11) 
            {
                Console.WriteLine(ints[p]);
                p++;
            }

            //chet 2-20
            for (int i = 2; i < 20; i+= 2) 
            {
                Console.WriteLine(i);

            }

            //tabl 
            for (int i = 1; i <= 5; i++) {
                for (int j = 1; j <=5; j++) {
                    Console.WriteLine($"{i * j}");
                }
            }

            //parol
            string password = "qwerty";
            string userInput;

            do
            {
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();
            }
            while (userInput != password);
            Console.WriteLine("Пароль верен");









        }


    }
}