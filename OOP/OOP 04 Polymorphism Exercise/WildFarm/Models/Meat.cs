using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Meat : Food
    {
        public Meat(int quantity)
        {
            this.Quantity = quantity;
        }
        public override int Quantity { get; set; }
    }
}
