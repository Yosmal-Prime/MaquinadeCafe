using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaquinaDeCafeTDD;


namespace MaquinaDeCafeTDD
{
    public class MaquinaDeCafe
    {
        public int SeleccionarVaso(string tamano)
        {
            switch (tamano.ToLower())
            {
                case "pequeño":
                    return 3; 
                case "mediano":
                    return 5; 
                case "grande":
                    return 7; 
                default:
                    throw new ArgumentException("Tamaño de vaso no válido");
            }
        }

        public int SeleccionarAzucar(int cucharadas)
        {
            if (cucharadas < 0)
            {
                throw new ArgumentException("La cantidad de azúcar no puede ser negativa");
            }
            return cucharadas; // Simplemente devolvemos la cantidad solicitada
        }

        public string RecogerVaso()
        {
            return "Vaso recogido con éxito."; // Mensaje de éxito al recoger el vaso
        }
    }
}
