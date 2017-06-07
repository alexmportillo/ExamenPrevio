using EXAMEN_PREVIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO.Models
{
    class Movil:Dispositivo,IReparable
    {

        public Movil(string marca, string modelo, int pulgadas)
        {
            Marca = marca;
            Modelo = modelo;
            Pulgadas = pulgadas;
            
        }
        
        public Dispositivo Marca { get; set; }
        public Dispositivo Modelo { get; set; }
        public Dispositivo Pulgadas { get; set; }
        public string SistemaOperativo { get; set; }
        public SO so { get; set; }



    }
}
