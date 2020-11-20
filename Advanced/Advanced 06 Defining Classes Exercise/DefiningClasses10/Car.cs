using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;
        public Car(string make, string model, int horsePower, string plateNum)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = plateNum;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }
        public override string ToString()
        {
            return $"Make: {Make}{Environment.NewLine}Model: {Model}{Environment.NewLine}HorsePower: {HorsePower}{Environment.NewLine}RegistrationNumber: {RegistrationNumber}";
        }
    }
}
