﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int result = DateModifier.DateCalculate(firstDate, secondDate);
            Console.WriteLine(result);
        }
    }
}
