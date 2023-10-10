using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class Animal
    {
        //Le agrego el virtual para poder sobrescribir el tostring en gato
        public virtual string comunicarse()
        {
            return "ruido... ruido...";
        }
    }
}
