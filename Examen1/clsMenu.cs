using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class clsMenu
    {
        static int opcion = 0;

        public static void Desplegar()
        {
            do
            {
                Console.WriteLine("1- Agregar Empleados");
                Console.WriteLine("2- Consultar Empleados");
                Console.WriteLine("3- Modificar Empleados");
                Console.WriteLine("4- Borrar Empleado");
                Console.WriteLine("5- Inicializar");
                Console.WriteLine("6- Reportes");
                Console.WriteLine("7- Salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: clsEmpleado.Agregar(); break;
                    case 2: clsEmpleado.Consultar(clsEmpleado.pidecedula()); break;
                    case 3: clsEmpleado.Modificar(clsEmpleado.pidecedula()); break;
                    case 4: clsEmpleado.Borrar(); break;
                    case 5:
                        clsEmpleado.Inicializar(); break;
                    case 6: Console.Clear(); Submenu(); break;
                    case 7: break;
                    default:
                        break;
                }
            } while (opcion != 7);
        }
        public static void Submenu()
        {
            do
            {
                Console.WriteLine("1- Consultar Empleados");
                Console.WriteLine("2- Listar todos los empleados");
                Console.WriteLine("3- Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4- Calcular y mostrar el salario mas alto y bajo de todos los empleados");
                Console.WriteLine("5- Salir");
                int.TryParse(Console.ReadLine().Trim(), out opcion);
                switch (opcion)
                {
                    case 1: 
                        Console.WriteLine("Consulta Empleados");

                        clsEmpleado.Consultar(clsEmpleado.pidecedula());

                        break;
                    case 2: Console.WriteLine("Lista Empleados");

                        clsEmpleado.ListaEmpleado();
                        break;
                         
                    case 3: Console.WriteLine("Calcula el promedio de los salarios"); 

                        clsEmpleado.Calculaprom();
                        break;   

                    case 4: Console.WriteLine("Calcula salario mas alto");

                        clsEmpleado.CalculaSalariomasAlto();
                        break; 
                    default:
                        break;

                }
             } while (opcion != 5) ;
        }
     }
 }
