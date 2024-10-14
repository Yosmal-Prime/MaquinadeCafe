using System;
using System.Threading.Channels;

namespace Yosmal
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, pin;
            double balance = 0;
            string nombre, apellido, sexo;

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Cajero ATM");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Su balance actual es de " + balance);
                        Console.ReadKey();
                        break;
                        

                    //case "2":
                        monto:
                        Console.WriteLine("¿Cuanto deseas depositar a la cuenta?");
                        double monto = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Vas agregar a tu cuenta la suma de : " + monto);
                        Console.WriteLine("Si /s        No/n");
                        string opcion2 = Console.ReadLine();
                        opcion2 = opcion2.ToUpper();

                        switch (opcion2)
                        {
                            case "S":
                                Console.WriteLine("Se ha agregado a tu cuenta la suma de : " + monto + "\nPase buenas");
                                balance = monto;
                                break;

                            case "N":

                                goto monto;

                             break;
                                    

                            default:
                                break;
                        }



                        break;

                   // case "3":
                        break;

                   // case "4":
                        break;

                    default:
                        Console.WriteLine("Debes ingresar un número válido");
                        Console.ReadKey();
                        break;

                }



            }
        }
    }
}
