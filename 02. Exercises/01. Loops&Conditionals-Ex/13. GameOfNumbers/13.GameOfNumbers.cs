﻿/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 2017/05/29
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GameOfNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combs = 0;
            int sum = 0;

            bool keepLooping = true;

            int currentI = 0;
            int currentJ = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combs++;
                    sum = i + j;
                    if (sum == magicNum)
                    {
                        currentI = i;
                        currentJ = j;
                        keepLooping = false;
                        break;
                    }
                }
                if (keepLooping == false)
                {
                    break;
                }
            }

            if (keepLooping == false)
            {
                Console.WriteLine("Number found! {currentJ} + {currentI} = {magicNum}");
            }
            else
            {
                Console.WriteLine("{combs} combinations - neither equals {magicNum}");
            }
        }
    }
}