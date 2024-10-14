using Implementación_de_Listas_Enlazadas;
using System;

class Program
{
    static void Main(string[] args)
    {
         
        Lista lista = new Lista();
        int opcion;

        do
        {
            Console.WriteLine("\nMenú de Opciones:");
            Console.WriteLine("1. Insertar al Frente");
            Console.WriteLine("2. Insertar al Final");
            Console.WriteLine("3. Insertar en una Posición");
            Console.WriteLine("4. Eliminar al Frente");
            Console.WriteLine("5. Eliminar al Final");
            Console.WriteLine("6. Mostrar Lista");
            Console.WriteLine("7. Insertar en Orden Ascendente");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valorFrente = int.Parse(Console.ReadLine());
                    lista.InsertarAlFrente(valorFrente);
                    break;
                case 2:
                    Console.Write("Ingrese un valor: ");
                    int valorFinal = int.Parse(Console.ReadLine());
                    lista.InsertarAlFinal(valorFinal);
                    break;
                case 3:
                    Console.Write("Ingrese un valor: ");
                    int valorPosicion = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la posición: ");
                    int posicion = int.Parse(Console.ReadLine());
                    lista.InsertarEnPosicion(valorPosicion, posicion);
                    break;
                case 4:
                    lista.EliminarAlFrente();
                    Console.WriteLine("Elemento eliminado al frente.");
                    break;
                case 5:
                    lista.EliminarAlFinal();
                    Console.WriteLine("Elemento eliminado al final.");
                    break;
                case 6:
                    Console.WriteLine("Contenido de la lista:");
                    lista.MostrarLista();
                    break;
                case 7:
                    Console.Write("Ingrese un valor: ");
                    int valorAsc = int.Parse(Console.ReadLine());
                    lista.InsertarAscendente(valorAsc);
                    break;
                case 8:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 8);
    }
}
