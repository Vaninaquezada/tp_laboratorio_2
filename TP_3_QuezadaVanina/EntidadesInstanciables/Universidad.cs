using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #region Enum
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion
        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }

        }

        public List<Jornada> Jornada
        {
            get { return this.jornada; }
        }

        public Jornada this[int index]
        {
            get
            {
                if (index < this.jornada.Count || index > this.jornada.Count)
                    return this.jornada[index];
                else
                    return null;
            }
        }

        #endregion
        #region Constructores
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion
        #region Metodos

        /// <summary>
        /// serializará los datos del Universidad en un XML, incluyendo todos los datos de sus
        ///   Profesores, Alumnos y Jornadas.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            bool banderita = false;
            string archivo = "";
            try
            {
                Xml<Universidad> guardar = new Xml<Universidad>();

                archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Universidad.xml";

                banderita = guardar.Guardar(archivo, uni);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);

            }
            return banderita;
        }

        /// <summary>
        /// Lee archivo xml con los datos de los alumnos
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            bool banderita;
            Universidad datos;
            try
            {
                Xml<Universidad> leer = new Xml<Universidad>();
                string archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Universidad.xml";

                
                banderita = leer.Leer(archivo, out datos);
             

            }
            catch (Exception e)
            {
                throw new ArchivosException(e);

            }

            
            return datos;
        }
        /// <summary>
        /// Guarda los datos de la universidad en un string
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: ");
            foreach (Jornada j in uni.Jornada)
            {
                sb.Append(j.ToString());
            
            }

            return sb.ToString();

        }

        /// <summary>
        /// Devuelve los datos 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        ///Un Universidad será igual a un Alumno si el mismo está inscripto en él. 
        /// </summary>
        /// <param name="u">universida</param>
        /// <param name="a">alumno</param>
        /// <returns>bool</returns>
        public static bool operator ==(Universidad u, Alumno a)
        {
            foreach (Alumno alumno in u.alumnos)
            {
                if (alumno == a)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor i in u.profesores)
            {
                if (i == clase)
                    return i;
            }
            throw new Excepciones.SinProfesorException();

        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {


            return u == clase;


        }
        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor inst in g.profesores)
            {
                if (inst == i)
                    return true;
            }
            return false;

        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u == a)
                throw new AlumnoRepetidoException();
            else
                u.alumnos.Add(a);

            return u;

        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j = new Jornada(clase, g == clase);

            foreach (Alumno a in g.alumnos)
            {
                if (a == clase)
                    j += a;
            }
            g.jornada.Add(j);
            return g;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u.profesores == null || u != i)
                u.profesores.Add(i);
            return u;
        }

        #endregion
    }
}
