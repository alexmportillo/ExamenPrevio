using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO.Interfaces
{
    public interface IReparable
    {
        float Precio { get; set; }
        void Reparar (float precio);
    }
}
