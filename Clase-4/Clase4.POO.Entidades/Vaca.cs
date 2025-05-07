
namespace Clase4.POO.Entidades
{
    public class Vaca : Animal
    {
        public Vaca()
        {
        }
        public Vaca(string nombre, string tipo) : base(nombre, tipo)
        {
        }
        public override string HacerSonido()
        {
            return "Muuu";
        }
    }
}
