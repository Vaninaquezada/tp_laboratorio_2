using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectTP4
{
    [TestClass]
    public class UnitTestTP4
    {
        [TestMethod]
        public void TestInstaciaListaPaqueteNotNull()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

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
