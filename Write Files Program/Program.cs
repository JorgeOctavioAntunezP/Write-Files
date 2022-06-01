using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Files_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir y Capturar un Nombre
            Console.Write("Ingresa un Nombre: ");
            string name = Console.ReadLine();

            // Crear un Archivo.txt
            StreamWriter sw = new StreamWriter("Nombres.txt",true);

            // Escribir los Nombres en el Archivo.txt
            sw.WriteLine(name);

            sw.Close(); // Cerrar Archivo.txt

            // Mensaje de Tarea Realizada
            Console.WriteLine("Escribiendo . . .");
            Console.ReadLine();
        }
    }
}