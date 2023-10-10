using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class Gato : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "miau miau...";
        }
    }
}
