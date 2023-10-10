using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Auto
    {
        public Auto() 
        { 
         Chasis = new Chasis();
        }   
        //Asociacion
        public int Año { get; set; }
        public int Modelo { get; set; }
        public int Color { get; set;}

        
       // Para diferenciar una asociacion entre Composicion y Agregacion
       //lo que tengo que preguntarme es si mi clase en mi caso auto,
       //si este auto puede nacer sin un chasis, la respuesta es si
       //entonces la asociacion va a ser de composicion, en cambio
       //Si le pregunto si un auto nace con un motor la respuesta es no,
       //yo puedo luego agregarle un motor pero no nace con uno
       //entonces la asociaion de de agregacion.

        //Conposicion
        
        public Chasis Chasis { get; set; } 

        //Agregacion
        public Motor Motor { get; set; }
    }
}
