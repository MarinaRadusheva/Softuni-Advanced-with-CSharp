using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity)
        {
            this.Quantity = quantity;
        }
        public override int Quantity { get; set; }
    }
}
