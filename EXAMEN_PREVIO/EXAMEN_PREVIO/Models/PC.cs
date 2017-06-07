using System;
using EXAMEN_PREVIO.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO.Models
{
    class PC:Dispositivo,IReparable
    {
        public PC(string fuentealimentacion,List<string>Piezas,Ram Ram)
        {
            FuenteAlimentacion = fuentealimentacion;
            piezas = Piezas;
            ram = Ram;
        }
        public string FuenteAlimentacion { get; set; }
        public List<string> piezas { get; set; }
        public string SistemaOperativo { get; set; }
        public Ram ram { get; set; }
        public string Procesador { get; set; }
        public SO so { get; set; }
        
        
    }
}
