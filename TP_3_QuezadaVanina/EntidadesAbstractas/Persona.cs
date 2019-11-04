using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {

        private string apellido;
        private string nombre;
        private int dni;
        private ENacionalidad nacionalidad;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        #region Propiedades
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.Nacionalidad, value); }
        }

        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.Nacionalidad, value); }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidarNombreApellido(value); }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = this.ValidarNombreApellido(value); }
        }


        #endregion
        # region Constructores
        public Persona()
        { }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion
        #region Metodos

        /// <summary>
        /// ToString retornará los datos de la Persona.
        /// </summary>
        /// <returns> string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1} \n", this.apellido, this.nombre);
            sb.AppendFormat("NACIONALIDAD: {0} \n", this.nacionalidad);
            return sb.ToString();
        }

        /// <summary>
        /// validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y 89999999 y Extranjero entre 90000000 y 99999999.
        /// Caso contrario, se lanzará la excepción NacionalidadInvalidaException.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns> int</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato < 1 || dato >= 89999999)
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                    }

                    break;
                case ENacionalidad.Extranjero:
                    if (dato < 90000000 || dato >= 99999999)
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                    }
                    break;

            }

            return dato;

        }

        /// <summary>
        /// Valida dni cuando el dato es string
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            dato = dato.Replace(".", "");

            if (dato.Length < 1 || dato.Length > 8)
                throw new DniInvalidoException(dato.ToString());
            int numeroDni;
            try
            {
                numeroDni = Int32.Parse(dato);
            }
            catch (Exception e)
            {
                throw new DniInvalidoException(dato.ToString(), e);
            }

            return this.ValidarDni(nacionalidad, numeroDni);
        }

        /// <summary>
        /// Valida que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se cargará.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {

            Regex regex = new Regex(@"[a-zA-Z]*");
            Match match = regex.Match(dato);

            if (match.Success)
            { return match.Value; }
            else
            { return ""; }
        }
        #endregion


    }
}
