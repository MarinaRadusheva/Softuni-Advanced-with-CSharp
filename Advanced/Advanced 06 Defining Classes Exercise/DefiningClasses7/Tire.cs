﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        private double pressure;
        private int age;
        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
        public double Pressure { get;}
        public int Age { get;}
    }
}
