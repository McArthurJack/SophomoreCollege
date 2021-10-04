using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McArthurJA2
{
    class Cereal
    {
        //The variables used in each cereal item and uses get set to create them
        public string Brand { get; set; }
        public char Mfr { get; set; }
        public char Type { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Sodium { get; set; }
        public float Fiber { get; set; }
        public float Carbo { get; set; }
        public float Sugars { get; set; }
        public float Potass { get; set; }
        public float Vitamins { get; set; }
        public float Shelf { get; set; }
        public float Weight { get; set; }
        public float Cups { get; set; }
        public float Rating { get; set; }

        //Upon creation of a new Cereal the CSV file data is input into the variable slots where they apply
        public Cereal(string Brand, char Mfr, char Type, int Calories, int Protein, int Fat, int Sodium, float Fiber, float Carbo, float Sugars, float Potass, float Vitamins, float Shelf, float Weight, float Cups, float Rating)
        {
            this.Brand = Brand;
            this.Mfr = Mfr;
            this.Type = Type;
            this.Calories = Calories;
            this.Protein = Protein;
            this.Fat = Fat;
            this.Sodium = Sodium;
            this.Fiber = Fiber;
            this.Carbo = Carbo;
            this.Sugars = Sugars;
            this.Potass = Potass;
            this.Vitamins = Vitamins;
            this.Shelf = Shelf;
            this.Weight = Weight;
            this.Cups = Cups;
            this.Rating = Rating;
        }
    }
}
