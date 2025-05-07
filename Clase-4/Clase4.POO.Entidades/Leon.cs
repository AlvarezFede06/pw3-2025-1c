
namespace Clase4.POO.Entidades
{
    public class Leon : Animal
    {
        public Leon()
        {
        }
        public Leon(string nombre, string tipo) : base(nombre, tipo)
        {
        }
        public override string HacerSonido()
        {
            return "Rugido";
        }
    }
}
