using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementación_de_Listas_Enlazadas
{
  
        public class Nodo
        {
            public int dato;
            public Nodo siguiente;

            public Nodo(int valor)
            {
                dato = valor;
                siguiente = null;
            }
        }

   
}
