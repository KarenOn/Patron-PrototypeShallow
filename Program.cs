using System;

namespace Prototype_shallow
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal am = new Animal() { Nombre = "Perro Mauricio", Patas = 4 };
            Animal amclon = am.Clone() as Animal;
            amclon.Patas = 5;

            Console.WriteLine(am.Patas);
            Console.ReadKey();
        }
    }
}
