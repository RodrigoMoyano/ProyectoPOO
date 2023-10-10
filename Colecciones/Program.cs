using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto
            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();
            //c1.Color = "Amarillo";
            //c2.Color = "Roja";
            //c3.Color = "Blanca";

            //List<Camioneta> listaCamioneta = new List<Camioneta>();
            //listaCamioneta.Add(c1);
            //listaCamioneta.Add(c2);
            //listaCamioneta.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamioneta.Count);
            //listaCamioneta[1] = "Negra";
            //c2.Color = "Verde";
            //Console.WriteLine("El color es: " + listaCamioneta[1].Color);
            //listaCamioneta.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas es: " + listaCamioneta.Count);

            //Otro ciclo para recorrer una coleccion
            //foreach (Camioneta item in listaCamioneta)
            //{
            //    Console.WriteLine("Color: " + item.Color);

            //}

            //Asociacion por agregacion yo creo un auto sin motor
            // y despues creo el el motor y se lo agrego al auto
            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();
        }    
       
    }
}
