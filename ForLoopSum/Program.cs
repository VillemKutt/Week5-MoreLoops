﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada 3 numbrit
            //programm kuvab nende numbrite summat

            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;
            }

            Console.WriteLine($"Sinu summa on: {sum}");
        }
    }
}
