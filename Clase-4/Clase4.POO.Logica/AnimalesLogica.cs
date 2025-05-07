
using Clase4.POO.Entidades;

namespace Clase4.POO.Logica
{
    public interface IAnimal
    {
        List<Animal> ObtenerAnimales();
        void AgregarAnimal(Animal animal);
  
    }

    public class AnimalesLogica : IAnimal
    {
        private List<Animal> animales;
        public AnimalesLogica()
        {
            animales = new List<Animal>();
            animales.Add(new Perro("Firulais", "Perro"));
            animales.Add(new Gato("Michi", "Gato"));
            animales.Add(new Gallina("Clara", "Gallina"));
            animales.Add(new Leon("Simba", "Leon"));
            animales.Add(new Vaca("Lola", "Vaca"));

        }
        public List<Animal> ObtenerAnimales()
        {
            return animales;
        }
        public void AgregarAnimal(Animal animal)
        {
            animales.Add(animal);
        }
       
    }
}
