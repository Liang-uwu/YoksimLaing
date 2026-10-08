using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoksimLaing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable: (605120289) N = último dígito (9) + 10 = 19

            static readonly int N = 19;

            static string[] nombre = new string[N];
            static string[] cedula = new string[N];

            static int cantidad = 0;

            static void Registrar()
            {
                if (cantidad < N)
                {
                    Console.Write("Ingrese el nombre del paciente: ");
                    nombre[cantidad] = Console.ReadLine();

                    Console.Write("Ingrese la cedula del paciente: ");
                    cedula[cantidad] = Console.ReadLine();

                    cantidad++;

                    Console.WriteLine("Paciente registrado correctamente");
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible");
                }
            }

            static void Buscar()
            {
                Console.Write("Ingrese la cedula del paciente: ");
                string ced = Console.ReadLine();

                int encontrado = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (ced == cedula[i])
                    {
                        Console.WriteLine("Nombre: " + nombre[i]);
                        Console.WriteLine("Cedula: " + cedula[i]);

                        encontrado = 1;
                    }
                }

                if (encontrado == 0)
                {
                    Console.WriteLine("Paciente no encontrado");
                }
            }

            static void Corregir()
            {
                Console.Write("Ingrese la cedula del paciente: ");
                string ced = Console.ReadLine();

                int encontrado = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (ced == cedula[i])
                    {
                        Console.Write("Ingrese el nuevo nombre: ");
                        nombre[i] = Console.ReadLine();

                        Console.WriteLine("Paciente corregido correctamente");

                        encontrado = 1;
                    }
                }

                if (encontrado == 0)
                {
                    Console.WriteLine("Paciente no encontrado");
                }
            }

            static void Baja()
            {
                Console.Write("Ingrese la cedula del paciente: ");
                string ced = Console.ReadLine();

                int encontrado = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (ced == cedula[i])
                    {
                        nombre[i] = "";
                        cedula[i] = "";

                        Console.WriteLine("Paciente dado de baja");

                        encontrado = 1;
                    }
                }

                if (encontrado == 0)
                {
                    Console.WriteLine("Paciente no encontrado");
                }
            }

            static void menu()
            {
                int opcion = 0;

                do
                {
                    Console.WriteLine("Control delcenso");
                    Console.WriteLine("1. Registrar paciente");
                    Console.WriteLine("2. Buscar paciente");
                    Console.WriteLine("3. Corregir paciente");
                    Console.WriteLine("4. Dar de baja paciente");
                    Console.WriteLine("5. Salir");

                    Console.Write("Seleccione una opcion: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Registrar();
                            break;

                        case 2:
                            Buscar();
                            break;

                        case 3:
                            Corregir();
                            break;

                        case 4:
                            Baja();
                            break;

                        case 5:
                            Console.WriteLine("Finalizar");
                            break;

                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }

                } while (opcion != 5);

            }
    }
}
