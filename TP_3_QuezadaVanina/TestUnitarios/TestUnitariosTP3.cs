using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivo;
using Excepciones;
using EntidadesAbstractas;
using EntidadesInstanciables;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitariosTP3
    {
        /// <summary>
        /// Test valida que al haber error en archivos tire una ArchivosException
        /// </summary>
        [TestMethod]
        public void ValidaArchivosException()
        {
            Texto t = new Texto();

            Assert.ThrowsException<ArchivosException>(() => t.Guardar("\\Jornada.txt", "Texto de prueba"));

        }
        /// <summary>
        /// Test valida que al ingresar dni con letras tire una DniInvalidoException
        /// </summary>
        [TestMethod]
        public void ValidaDniInvalidoException()
        {
            string dniTexto = "30a00123";

            Assert.ThrowsException<DniInvalidoException>(() => new Profesor(1, "Juan", "Lopez", dniTexto, EntidadesAbstractas.Persona.ENacionalidad.Argentino));

        }
        /// <summary>
        /// Test valida que DNI get devuelva un campo numerico
        /// </summary>
        [TestMethod]
        public void ValidaDni()
        {
            string dni = "456";
            Profesor profesor = new Profesor(1, "Juan", "Lopez", dni, EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Assert.IsTrue(profesor.DNI.GetType() == typeof(int));
        }
        /// <summary>
        /// Comprueba que algun dato del profesor no pueda ser null
        /// </summary>
        [TestMethod]
        public void ValidaProfesorNoNull()
        {
            string dni = "456";
            Profesor profesor = new Profesor(1, "Juan", "Lopez", dni, EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Assert.IsNotNull(profesor.DNI);
        }
    }
}
