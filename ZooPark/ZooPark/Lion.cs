using ZooPark.Animal;

namespace Program.cs
{
    internal class Lion : AbstractAnimal
    {
        public Lion(string name, double foodAmount, int age) : base(name, foodAmount, age)
        {
            Age = 12;
            FoodAmount = foodAmount;
            IsPredator = true;
            biom = ZooPark.Option.Biom.desert;

        }

        public override void Sound()
        {
            Console.WriteLine($"Lion {Name} says rawr");
        }
    }
}