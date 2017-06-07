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
        protected string Marca;
        protected string Modelo;
        protected int Pulgadas;

        public abstract float Precio { get; set; }

        public Dispositivo(string marca,string modelo,int pulgadas)
        {
           Marca = marca;
           Modelo = modelo;
           Pulgadas = pulgadas;
        }
        //Getters y setters como en Java
       
        public void setPulgadas(int pulgadas)
        {
            if (pulgadas < 0)
            {
                throw new Exception("Las pulgadas no puede ser menor de 0");
            }
            Pulgadas = pulgadas;
        }

        public override string  ToString() 
        {
            return string.Format("{0} {1} {2} ", Marca, Modelo, Pulgadas);
        }

        void IReparable.Reparar(float precio)
        {
            throw new NotImplementedException();
        }

             public static implicit operator Dispositivo(string Marca)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Dispositivo(int Modelo)
        {
            throw new NotImplementedException();
        }
    }
    }
    
}
