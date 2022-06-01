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
            StreamWriter sw = new StreamWriter("Ejemplo.txt",true);

            string[] Lines = { "Linea 1", "Linea 2", "Linea 3" };


            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }

            sw.Close();

            Console.WriteLine("Escribiendo . . .");
            Console.ReadLine();
        }
    }
}
