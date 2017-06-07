using EXAMEN_PREVIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO.Models
{
    class Tablet:Dispositivo, IReparable
    {
       
        public Tablet(string marca, string modelo, int pulgadas, SO sO,int precio)
        {
            Marca = marca;
            Modelo = modelo;
            Pulgadas = pulgadas;
            so = sO;
            Precio = precio;
        }
        public Dispositivo marca { get; set; }
        public Dispositivo modelo { get; set; }
        public Dispositivo pulgadas { get; set; }
        public string SistemaOperativo { get; set; }
        public SO so { get; set; }

        public override float Precio
        {
            get
            {
                throw new NotImplementedException("error");
            }

            set
            {
                throw new NotImplementedException("error");
            }
        }
    }
}
