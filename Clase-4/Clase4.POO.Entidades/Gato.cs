
namespace Clase4.POO.Entidades
{
    public class Gato : Animal
    {
        public Gato()
        {
        }
        public Gato(string nombre, string tipo) : base(nombre, tipo)
        {
        }
        public override string HacerSonido()
        {
            return "Miau";
        }
    }

}
