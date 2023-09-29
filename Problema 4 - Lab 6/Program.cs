using System;

namespace Tiendita
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximoPersonas, contadorActual = 0, opcion, personas;

            int totalIngresos = 0, totalSalidas = 0, vecesLleno = 0, vecesVacio = 0;

            Console.Write("Ingrese un número máximo de personas: ");
            maximoPersonas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("========================================");
            Console.WriteLine($"El número máximo establecido es de {maximoPersonas} personas,");
            Console.WriteLine("presione una tecla para comenzar a contar.");
            Console.ReadKey();

            while (true)
            {
                Console.Clear(); // Limpiamos la pantalla para una mejor visualización

                Console.WriteLine("========================================");
                Console.WriteLine($"Personas actualmente en la tienda: {contadorActual}");
                Console.WriteLine("1. Registrar entrada de personas.");
                Console.WriteLine("2. Registrar salida de personas.");
                Console.WriteLine("3. Salir.");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese número de personas que entran: ");
                        personas = Convert.ToInt32(Console.ReadLine());
                        if (contadorActual + personas <= maximoPersonas)
                        {
                            contadorActual += personas;
                            totalIngresos += personas;
                            if (contadorActual == maximoPersonas)
                            {
                                vecesLleno++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Superará el límite. No se puede ingresar esa cantidad de personas.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese número de personas que salen: ");
                        personas = Convert.ToInt32(Console.ReadLine());
                        if (contadorActual - personas >= 0)
                        {
                            contadorActual -= personas;
                            totalSalidas += personas;
                            if (contadorActual == 0)
                            {
                                vecesVacio++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No puede salir más gente de la que está dentro.");
                        }
                        break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("=================================");
                        Console.WriteLine("El programa ha terminado");
                        Console.WriteLine("====================================");
                        Console.WriteLine("Estadísticas:");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"{totalIngresos} personas ingresaron");
                        Console.WriteLine($"{totalSalidas} personas salieron");
                        Console.WriteLine($"{vecesLleno} veces se llenó el local");
                        Console.WriteLine($"Estuvo vacío {vecesVacio} veces");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
