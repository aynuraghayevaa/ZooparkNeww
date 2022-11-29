using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Animal
{
    public class Cat : AbstractAnimal
    {
        public Cat(string name, double foodAmount, int age) : base(name, foodAmount, age) 
          {  
            Age = 7;
            FoodAmount = foodAmount;
            IsPredator = false;
            biom = Option.Biom.tundra;
            Foods = new List<Option.Food>() { Option.Food.fish, Option.Food.meat };
            

        }
        public override void Sound()
        {
            Console.WriteLine($"Cat {Name} goes Miaw");
        }

    }
}
