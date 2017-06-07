using EXAMEN_PREVIO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PREVIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Movil M = new Movil("huawei", "5", 20);
            int i = (int)SO.Windows;
            Console.WriteLine(M.ToString());
            Console.WriteLine("Indice SO:" + i);
        }
    }
}