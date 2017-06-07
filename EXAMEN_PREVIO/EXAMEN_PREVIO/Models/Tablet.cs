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
        public SO so { get; set; }
    }
}
