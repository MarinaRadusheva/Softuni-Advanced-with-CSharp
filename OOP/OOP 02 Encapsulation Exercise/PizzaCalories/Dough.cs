using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string textureType;
        private double weight;
        private double modifierByFlour;
        private double modifierByTexture;
        public Dough(string flour, string texture, double weight)
        {
            this.FlourType = flour;
            this.TextureType = texture;
            this.Weight = weight;

        }
        protected string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }
        protected string TextureType
        {
            get => this.textureType;
            private set
            {
                List<string> textures = new List<string> { "crispy", "chewy", "homemade" };
                if (!textures.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.textureType = value;
            }
        }
        protected double Weight
        {
            get => this.weight;
            private set
            {
                if (value<1||value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
        public double DoughCalories { get => this.GetDoughCalories(); }
        private double GetDoughCalories()
        {
            SetModifiers();
            double calories = (2 * this.Weight) * modifierByFlour * modifierByTexture;
            return calories;
        }
        private void SetModifiers()
        {
            switch (FlourType.ToLower())
            {
                case "white":
                    modifierByFlour = 1.5;
                    break;
                case "wholegrain":
                    modifierByFlour = 1.0;
                    break;
            }
            switch (TextureType.ToLower())
            {
                case "crispy":
                    modifierByTexture = 0.9;
                    break;
                case "chewy":
                    modifierByTexture = 1.1;
                    break;
                case "homemade":
                    modifierByTexture = 1.0;
                    break;
            }
        }
    }
}