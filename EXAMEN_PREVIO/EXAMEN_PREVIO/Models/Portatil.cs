using EXAMEN_PREVIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO.Models
{
    class Portatil:Dispositivo,IReparable
    {

        public Ram ram { get; set; }
        public string Procesador { get; set; }
        public SO so { get; set; }


    }
}
