using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //Sobreescribo el metodo ToString

        public override string ToString()
        {
            return "Animal Domestico: " + Nombre;
        }
    }   

    
}
