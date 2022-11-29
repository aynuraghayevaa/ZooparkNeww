using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Option;

namespace ZooPark.Animal
{
    public abstract class AbstractAnimal
    {
        public string Species;
        public int Area;
        public bool IsPredator;
        public List<Food> Foods;
        public string Name;
        public double FoodAmount;
        public int Age;
        public Biom biom;
        internal Biom BiomType;

        public AbstractAnimal(string species, int area, string sound, string name, double foodAmount, int age)
        {
            Species = species;
            Area = area;
            Name = name;
            FoodAmount = foodAmount;
            Age = age;

           
             
        }

        protected AbstractAnimal(string name, double foodAmount, int age)
        {
            this.name = name;
            this.foodAmount = foodAmount;
            this.age = age;
        }

        public string species { get; set; }
        public int area { get; set; }
        public string name { get; set; }
        public double foodAmount { get; set; }
        public int age { get; set; }
        public abstract void Sound();
        

       
        
    }
}
