using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_de_Listas_Enlazadas
{
    public class Lista
    {
        private Nodo cabeza;

        public Lista()
        {
            cabeza = null;
        }

        // Método para insertar al final (cola)
        public void InsertarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
            }
        }

        // para insertar al principio (cabeza)
        public void InsertarAlFrente(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.siguiente = cabeza;
            cabeza = nuevo;
        }

        // eliminar en la cabeza
        public void EliminarAlFrente()
        {
            if (cabeza != null)
            {
                cabeza = cabeza.siguiente;
            }
        }

        //  para eliminar en la cola
        public void EliminarAlFinal()
        {
            if (cabeza != null)
            {
                if (cabeza.siguiente == null)
                {
                    cabeza = null;
                }
                else
                {
                    Nodo actual = cabeza;
                    while (actual.siguiente.siguiente != null)
                    {
                        actual = actual.siguiente;
                    }
                    actual.siguiente = null;
                }
            }
        }

        // Método para insertar en una posición específica
        public void InsertarEnPosicion(int valor, int posicion)
        {
            Nodo nuevo = new Nodo(valor);
            if (posicion == 0)
            {
                InsertarAlFrente(valor);
            }
            else
            {
                Nodo actual = cabeza;
                for (int i = 0; i < posicion - 1 && actual != null; i++)
                {
                    actual = actual.siguiente;
                }

                if (actual != null)
                {
                    nuevo.siguiente = actual.siguiente;
                    actual.siguiente = nuevo;
                }
                else
                {
                    InsertarAlFinal(valor);
                    Console.WriteLine("La posición no existe. Insertado al final.");
                }
            }
        }

        // mostrar la lista
        public void MostrarLista()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.dato + " -> ");
                actual = actual.siguiente;
            }
            Console.WriteLine("null");
        }

        // insertar en forma ascendente
        public void InsertarAscendente(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (cabeza == null || cabeza.dato >= valor)
            {
                nuevo.siguiente = cabeza;
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.siguiente != null && actual.siguiente.dato < valor)
                {
                    actual = actual.siguiente;
                }
                nuevo.siguiente = actual.siguiente;
                actual.siguiente = nuevo;
            }
        }
    }

}
