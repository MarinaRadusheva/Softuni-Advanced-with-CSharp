using Cars.Contracts;
namespace Cars.Models
{
    public class Tesla : Car, IElectricCar
    {

        public Tesla(string model, string color, int batteries) : base(model, color)
        {
            this.Battery = batteries;
        }

        public int Battery { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" with {this.Battery} Batteries";
        }
    }
}
