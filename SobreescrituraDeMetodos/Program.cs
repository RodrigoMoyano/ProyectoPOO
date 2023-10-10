using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "PEPE";
            Gato g1 = new Gato();
            g1.Nombre = "PEPE";
            //Console.WriteLine(a1.ToString());
            Perro p1 = new Perro();
            p1.Nombre = "Negrito";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());
            animales.Add(g1);
            animales.Add(new Gato());

            //INTERFAZ
            //De esta manera puedo invocar cada animal dentro de mi interfaz
            //volar.

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());



            //Animal a1 = g1;
            // De esta manera obligo al compilador lea y guarde a1 en g8 diciedole que si hay un gato en a1
            //por que si no le pongo(Gato) va a decir yo nose si en a1 hay un gato, pero si yo estoy seguro que lo hay
            //de esta manera lo obligo a que lo guarde

            //Gato g8 = (Gato)a1;
            //g8.Nombre = "BLANQUITO";

            //Console.WriteLine(g1.Nombre);
            //Console.WriteLine(g1.comunicarse());
            //Console.WriteLine(p1.comunicarse());

            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.comunicarse());
            //}

            Console.ReadKey();
            //TODO ESTO  LO LLAMAMOS POLIMORFISMO
            //ES LA CARACTERISTICA QUE TIENEN LOS OBJETOS QUE FRENTE AL MISMO
            //ESTIMULO COMPORTARSE DE DISTINTA MANERA.
        }
    }
}
