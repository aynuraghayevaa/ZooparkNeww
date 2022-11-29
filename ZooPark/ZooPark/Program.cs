using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Animal;
using ZooPark.Option;

namespace Program.cs
{
    public class Program
    {
      

        static void Main(string[] args)
        {
            Aviary place = new Aviary("Baku Zoo", Biom.tundra, 12000);

            AbstractAnimal Dumbo = new Elephant("Dumbo", 45, 10);
            AbstractAnimal Alex = new Lion("Alex", 30, 5);
            place.AddAnimal(Dumbo);
            place.AddAnimal(Alex);
            Console.Read();
        
            

            
        }
    }

}