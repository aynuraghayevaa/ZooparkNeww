using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Animal;

namespace ZooPark.Option
{
    public class Aviary

    {
        public Aviary(string name, Biom biom, int square)
        {
            name = name;
            biom = biom;
            square = square;
            
        }
        public Dictionary<Food, double> Feeders;
        public string name;
        public Biom biom;
        public int square;
        protected List<AbstractAnimal> Animals = new List<AbstractAnimal>();
        public void AddAnimal(AbstractAnimal animal)
        {
            bool CouldLive = false;
            if (animal.BiomType == biom && square > animal.Area)
            {
                if (Animals.Count != 0)
                {
                    if (Animals.ElementAt(0).IsPredator == false && animal.IsPredator == false)
                    {
                        Animals.Add(animal);
                        CouldLive = true;
                        square -= animal.Area;
                    }
                    if (Animals.ElementAt(0).IsPredator == true && animal.GetType() == Animals.ElementAt(0).GetType()) ;
                    Animals.Add(animal);
                    CouldLive = true;
                    square -= animal.Area;
                }

            }
            else
                Animals.Add(animal);
            CouldLive = true;
            square -= animal.Area;
        }
    }
}
