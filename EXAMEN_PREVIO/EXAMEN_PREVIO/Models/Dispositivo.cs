using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO.Models
{
    public abstract class Dispositivo:IReparable
    {
        private String Marca;
        private String Modelo;
        private String Pulgadas;


        public override string  ToString() 
        {
            return String.Format("{0} {1} {2} ", Marca, Modelo, Pulgadas);
        }

    }
    
}
