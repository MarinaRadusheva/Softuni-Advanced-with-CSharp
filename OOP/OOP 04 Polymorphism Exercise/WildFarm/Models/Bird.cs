﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Bird : Animal
    {
        public abstract double WingSize { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
