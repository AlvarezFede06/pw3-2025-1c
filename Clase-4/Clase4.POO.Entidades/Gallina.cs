
namespace Clase4.POO.Entidades
{
    public class Gallina : Animal
    {
        public Gallina()
        {
        }
        public Gallina(string nombre, string tipo) : base(nombre, tipo)
        {
        }

        public override string HacerSonido()
        {
            return "Cloc cloc";
        }
    }
}
