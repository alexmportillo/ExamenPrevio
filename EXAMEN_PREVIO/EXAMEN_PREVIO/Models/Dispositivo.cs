using EXAMEN_PREVIO.Interfaces;
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

        float IReparable.Precio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string  ToString() 
        {
            return String.Format("{0} {1} {2} ", Marca, Modelo, Pulgadas);
        }

        void IReparable.Reparar(float precio)
        {
            throw new NotImplementedException();
        }
    }
    
}
