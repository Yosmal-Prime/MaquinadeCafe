using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaDeCafeTDD; 

namespace MaquinaDeCafeTests
{
    [TestClass]
    public class MaquinaDeCafeTests
    {
        [TestMethod]
        public void SeleccionarVasoPequeno_DebeDevolver3Oz()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            int tamanoVaso = maquina.SeleccionarVaso("pequeño");

            // Verificar
            Assert.AreEqual(3, tamanoVaso);  // Esperamos que el vaso pequeño sea de 3 Oz
        }

        [TestMethod]
        public void SeleccionarVasoMediano_DebeDevolver5Oz()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            int tamanoVaso = maquina.SeleccionarVaso("mediano");

            // Verificar
            Assert.AreEqual(5, tamanoVaso);  // Esperamos que el vaso mediano sea de 5 Oz
        }

        [TestMethod]
        public void SeleccionarVasoGrande_DebeDevolver7Oz()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            int tamanoVaso = maquina.SeleccionarVaso("grande");

            // Verificar
            Assert.AreEqual(7, tamanoVaso);  // Esperamos que el vaso grande sea de 7 Oz
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SeleccionarVasoInvalido_DeberiaLanzarExcepcion()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            maquina.SeleccionarVaso("extra grande"); // Esto debería lanzar una excepción
        }

        
        //Azucar 

        [TestMethod]
        public void SeleccionarAzucar_DevuelveCantidadCorrecta()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            int cantidadAzucar = maquina.SeleccionarAzucar(2);

            // Verificar
            Assert.AreEqual(2, cantidadAzucar);  // Esperamos que se devuelva 2 cucharadas de azúcar
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SeleccionarAzucar_Negativa_DeberiaLanzarExcepcion()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            maquina.SeleccionarAzucar(-1); // Esto debería lanzar una excepción
        }

        //Recoger Vaso dew CAFE

        [TestMethod]
        public void RecogerVaso_DevuelveMensajeDeExito()
        {
            // Configurar
            var maquina = new MaquinaDeCafe();

            // Actuar
            string mensaje = maquina.RecogerVaso();

            // Verificar
            Assert.AreEqual("Vaso recogido con éxito.", mensaje);  // Verificamos el mensaje de éxito
        }



    }
}
