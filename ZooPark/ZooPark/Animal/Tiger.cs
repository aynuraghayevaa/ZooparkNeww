using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooPark.Animal

{ 
public class Tiger : AbstractAnimal
{
    public Tiger(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
    {
        IsPredator = true;
        biom = Option.Biom.tropics;
        Age = 100;
        Area = 400;
        Foods = new List<Option.Food>() { Option.Food.meat };

    }
    public override void Sound()
    {
        Console.WriteLine($"rawr, tiger {Name}");
    }
}
}