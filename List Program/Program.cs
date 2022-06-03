using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Program
{
    public class Member
    {
        public string name;
        public byte age;
        public string job;
        private string department = "N/A";
        public Member() {}
        public Member(string name, byte age, string job, string department)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            departmentSG = department;
        }

        public string departmentSG
        {
            get { return department; }
            set
            {
                if (value == "F" || value == "RH" || value == "M" || value == "D" || value == "S")
                {
                    department = value;
                }
            }
        }

        ~Member()
        {
            Console.WriteLine("Objeto Destruido");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string nameList;
            char C;

            do
            {
                C = '/';
                try
                {
                    Console.Clear();

                    Console.WriteLine("Crear Listas de Trabajo\n");
                    Console.WriteLine("a) Crear o Modificar una Lista.");
                    Console.WriteLine("b) Borrar una Lista.");
                    Console.WriteLine("c) Salir del Programa.");

                    Console.Write("\n   Seleccione una opción: ");
                    C = char.Parse(Console.ReadLine());

                    Console.Clear();
                }
                catch(FormatException)
                {
                    Console.Write("\n¡Ingrese un solo Carácter!");
                    Console.ReadKey();

                    Console.Clear();
                }
                switch (C)
                {
                    case 'a':

                        Console.WriteLine("Crear o Modificar una Lista:");
                        Console.Write("\n   Nombre: ");
                        nameList = (Console.ReadLine() + ".txt");

                        StreamWriter list = new StreamWriter(nameList, true);

                        try
                        {
                            Console.Write("\n      Nombre: ");
                            string name = Console.ReadLine();
                            Console.Write("      Edad: ");
                            byte age = byte.Parse(Console.ReadLine());
                            Console.Write("      Trabajo: ");
                            string job = Console.ReadLine();
                            Console.Write("      Departamento: ");
                            string departmentSG = Console.ReadLine();

                            Member member = new Member(name, age, job, departmentSG);

                            list.Write("Nombre: {0}\nEdad: {1}\nTrabajo: {2}\nDepartamento: {3}\n\n",
                                member.name, member.age, member.job, member.departmentSG);

                            list.Close();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error de Formato");
                            Console.ReadKey();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n" + e.Message);
                            Console.ReadKey();
                        }
                        finally
                        {
                            list.Close();
                        }

                        break;

                    case 'b':

                        DeleteFile();

                        break;

                    case 'c':
                        break;

                    default:

                        Console.WriteLine("¡Ingrese una de las 3 opciones!");
                        Console.ReadKey();

                        break;
                }
            }
            while (C != 'c');
        }

        static void DeleteFile()
        {
            Console.WriteLine("Borrar una Lista:");
            Console.Write("\n   Nombre: ");
            string fileD = (Console.ReadLine() + ".txt");

            bool check = File.Exists(fileD);
            try
            {
                if (check == true)
                {
                    File.Delete(fileD);
                    Console.Write("\n-Se eliminó el archivo: {0} ", fileD);
                }
                else
                {
                    Console.Write("\n-No se encontró el archivo: {0} ", fileD);
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("\n" + e.Message);
                Console.ReadKey();
            }
        }
    }
}