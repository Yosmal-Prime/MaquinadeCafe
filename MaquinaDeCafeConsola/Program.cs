using System;
using System.Threading;
using MaquinaDeCafeTDD;

class Program
{
    static void Main(string[] args)
    {
        var maquina = new MaquinaDeCafe();
        bool continuar = true;

        Console.WriteLine("Bienvenido a la Máquina de Café.");

        while (continuar)
        {
            Console.Clear(); // Limpiar la consola antes de mostrar el menú
            Console.WriteLine("Selecciona el tamaño del vaso:");
            Console.WriteLine("1. Pequeño (3 oz)");
            Console.WriteLine("2. Mediano (5 oz)");
            Console.WriteLine("3. Grande (7 oz)");
            Console.WriteLine("0. Salir");

            // Leer la opción del usuario
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número.");
                continue; // Volver al inicio del bucle
            }

            string tamanoVaso = "";
            switch (opcion)
            {
                case 1:
                    tamanoVaso = "pequeño";
                    break;
                case 2:
                    tamanoVaso = "mediano";
                    break;
                case 3:
                    tamanoVaso = "grande";
                    break;
                case 0:
                    continuar = false; // Salir del bucle
                    Console.WriteLine("Gracias por usar la Máquina de Café. ¡Hasta luego!");
                    continue; // Salir del bucle
                default:
                    Console.WriteLine("Opción no válida, por favor intenta de nuevo.");
                    continue; // Volver al inicio del bucle
            }

            // Selección de azúcar
            Console.WriteLine("¿Cuántas cucharadas de azúcar deseas?");
            int cucharadasAzucar;
            if (!int.TryParse(Console.ReadLine(), out cucharadasAzucar) || cucharadasAzucar < 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                continue; // Volver al inicio del bucle
            }
            maquina.SeleccionarAzucar(cucharadasAzucar);
            Console.WriteLine($"Se añadieron {cucharadasAzucar} cucharadas de azúcar.");

            // Mostrar resumen de la preparación
            Console.Clear();
            Console.WriteLine("Preparando tu café...");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Café {tamanoVaso} ({maquina.SeleccionarVaso(tamanoVaso)} oz)");
            Console.WriteLine($"Cucharadas de azúcar: {cucharadasAzucar}");
            Console.WriteLine("---------------------------");

            // Simulación de preparación de café
            Console.Write("Preparando");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(500); // Simular tiempo de preparación
            }
            Console.WriteLine("\n¡Café listo!");

            // Esperar a que el usuario presione una tecla para recoger el café
            Console.WriteLine("Presiona cualquier tecla para recoger el café.");
            Console.ReadKey(); // Esperar a que el usuario presione una tecla

            // Recoger vaso
            Console.WriteLine(maquina.RecogerVaso());
        }
    }
}
