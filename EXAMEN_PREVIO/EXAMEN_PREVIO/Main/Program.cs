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
            Console.WriteLine("Hola Mundo!");
            var miTienda= new Tienda();
            miTienda.Dispositivo = CargarTienda();

            try
            {
                miTienda.EvaluarTodos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //Fin de programa
            Console.ReadLine();
        }
        private static IList<Disp> CargarTienda()
        {
            var lista = new List<Disp>();

            lista.Add(new Disp("Yusep", "Guardiola", 32, "ER20983"));
            lista.Add(new Disp("Salvatore", "Mojonen", 31, "ER20984"));
            lista.Add(new Disp("Utrero", "Rusep", 32, "ER20985"));
            lista.Add(new Disp("Maxy", "Iglesias", 23, "ER20973"));
            lista.Add(new Disp("Yusep", "Ratata", 33, "ER20345"));
            lista.Add(new Disp("Isma", "El", 43, "ER20789"));

            return lista;
        }
    }
}
