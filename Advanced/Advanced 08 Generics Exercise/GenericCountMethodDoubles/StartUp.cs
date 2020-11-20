﻿using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> values = new List<double>();
            for (int i = 0; i < n; i++)
            {
                values.Add(double.Parse(Console.ReadLine()));
            }
            Box<double> box = new Box<double>(values);
            double valueToCompare = double.Parse(Console.ReadLine());
            int count = box.GetCountOfHigherValues(valueToCompare);
            Console.WriteLine((count));
        }
    }
}
