
namespace Clase4.POO.Entidades
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Animal(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }

        public Animal() { }

      
        public abstract string HacerSonido();

    }
}
