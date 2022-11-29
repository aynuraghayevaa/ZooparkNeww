using ZooPark.Animal;

namespace Program.cs
{
    internal class Elephant : AbstractAnimal
    {
        public Elephant(string name, double foodAmount, int age) : base(name, foodAmount, age)
        {
            Age = 27;
            FoodAmount = foodAmount;
            IsPredator = true;
            biom = ZooPark.Option.Biom.tundra;
            Foods = new List<ZooPark.Option.Food>() { ZooPark.Option.Food.hay };
        }

        public override void Sound()
        {
            Console.WriteLine("Elephants make some weird noises");
        }
    }
}