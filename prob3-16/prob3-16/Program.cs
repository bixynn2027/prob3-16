﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力：");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("2の倍数です");
            }
            if (num % 3 == 0)
            {
                Console.WriteLine("3の倍数です");
            }
            if (num % 2 == 0 && num % 3 == 0)
            {
                Console.WriteLine("2と3の公倍数です");
            }
        }
    }
}
