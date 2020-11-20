using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int speed, int power)
        {
            this.engineSpeed = speed;
            this.EnginePower = power;
        }
        public int EngineSpeed { get;}
        public int EnginePower { get;}
    }
}
