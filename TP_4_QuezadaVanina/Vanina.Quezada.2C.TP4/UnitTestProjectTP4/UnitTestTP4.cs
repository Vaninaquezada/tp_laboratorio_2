using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectTP4
{
    [TestClass]
    public class UnitTestTP4
    {
        /// <summary>
        /// Valida que al crear un nuevo correo la lista de paquetes no sea nula
        /// </summary>
        [TestMethod]
        public void TestInstaciaListaPaqueteNotNull()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        /// <summary>
        /// Valida que al intentar ingrasar un tracking ya existente tire una excepcion del tipo TrackingIdRepetidoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestPaqueteRepetido()
        {
            Correo correo = new Correo();
            Paquete paquete1 = new Paquete("direccion 123","123-456-7890");
            Paquete paquete2 = new Paquete("direccion 123", "123-456-7890");
            correo += paquete1;
            correo += paquete2;
        }
    }
}
