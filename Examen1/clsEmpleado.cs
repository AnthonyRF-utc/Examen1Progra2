using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Examen1
{
    internal class clsEmpleado
    {
        // atributos
        static int cantidad = 2;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public string[] direccion = new string[cantidad];
        static public string[] telefono = new string[cantidad];
        static public string[] salario = new string[cantidad];
    


        // metodos

        public static string pidecedula()
        {
            Console.WriteLine("Ingrese la cedula");
            string ced = Console.ReadLine();
            return ced;
        }
        static public void Agregar()
        {
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el numero de cedula: {0}" ,i);
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Digite el nombre: {0}",i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la direccion: {0}" ,i);
                direccion[i] = Console.ReadLine();
                Console.WriteLine("Digite el numero de telefono: {0}" ,i);
                telefono[i] = Console.ReadLine();
                Console.WriteLine("Digite el salario: {0}" ,i);
                salario[i] = Console.ReadLine();
                Console.Clear();
            }

        }

        static public void Consultar(string cedu)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (cedu.Equals(cedula[i]))
                {
                    Console.WriteLine($"Nombre:{nombre[i]} , la cedula: {cedula[i]} , la direccion: {direccion[i]}" +
                        $" , el numero de telefono: {telefono[i]} y el salario: {salario[i]}");
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("El empleado no ha sido encontrado");
            }

        }

        static public void Modificar(string cedu)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (cedu.Equals(cedula[i]))
                {
                    Console.WriteLine("Digite el nombre: ");
                    nombre[i] = Console.ReadLine() ;
                    Console.WriteLine("Digite la cedula");
                    cedula[i] = Console.ReadLine() ;
                    Console.WriteLine("Digite la direccion: ");
                    direccion[i] = Console.ReadLine() ;
                    Console.WriteLine("Ingrese el numero de telefono: ");
                    telefono[i] = Console.ReadLine() ;
                    Console.WriteLine("Digite el salario:");
                    salario[i] = Console.ReadLine();
                  
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("El empleado no ha sido encontrado");
            }

        }

        static public void Borrar()
        {
            Console.WriteLine("Digite cedula: ");
            string cedu = Console.ReadLine();
            bool borrado = false;
            for (int i = 0;i < cantidad; i++)
            {
                if (cedu.Equals(cedula[i]))
                {
                    Console.WriteLine("Digite el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite la direccion: ");
                    direccion[0] = Console.ReadLine();
                    Console.WriteLine("Ingrese el numero de telefono:");
                    telefono[i] = Console.ReadLine();
                    Console.WriteLine("Digite el salario: ");
                    salario[i] = Console.ReadLine();
                  // int.TryParse(Console.ReadLine(), out cantidad[i]);
                    borrado = true;
                    break;
                }
            }
        }

        static public void Inicializar()
        {
            cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat("", cantidad).ToArray();
            salario = Enumerable.Repeat("", cantidad).ToArray();
            Console.WriteLine("El sistema ha sido inicializado");
        }
        
        static public void ListaEmpleado()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                    Console.WriteLine("Cedula");
                    cedula[i] = Console.ReadLine();

                    Console.WriteLine("Nombre: " + nombre[i] +  "Cedula: " + cedula[i] +  "Direccion: " + direccion[i] +
                        "Numero de telefono: " + telefono[i] + "Salario: " + salario[i]);
                
            }
        }

        static public void Calculaprom()
        {
            List<double> salario = new List<double>();
            double promedioSalarios = salario.Average();

            Console.WriteLine("El promedio de salarios es de: {0}", salario.Average() );

        }

        static public void CalculaSalariomasAlto()
        {
           
        }
    }
}
