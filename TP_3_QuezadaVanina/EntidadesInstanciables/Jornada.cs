﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Jornada
    {

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
        public Universidad.EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }
        public Profesor Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }


        #endregion
        #region Constructores
        public Jornada()
        {
            alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion
        #region Metodos

        /// <summary>
        /// Guardar de clase guardará los datos de la Jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                Texto t = new Archivo.Texto();
               
                return t.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Jornada.txt", jornada.ToString());

            }
            catch (Exception e)
            {
                throw new ArchivosException(e);

            }
        }

        /// <summary>
        /// Leer de clase retornará los datos de la Jornada como texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Leer(Jornada jornada)
        {
            try
            {
                Texto t = new Archivo.Texto();
                string datos;
                string archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Jornada.txt";
                bool s = t.Leer(archivo, out datos); ;
                Console.WriteLine(datos);
                return s;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);

            }
        }

        /// <summary>
        /// ToString mostrará todos los datos de la Jornada.
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CLASE DE {0} POR {1}", this.clase.ToString(), this.instructor.ToString());

            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());

            }
            sb.AppendLine("<-------------------------------------------->");
            return sb.ToString();
        }
        #endregion
        #region Sobrecargas
        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {

            if (j.alumnos != null)
            {
                foreach (Alumno item in j.alumnos)
                {
                    if (item == a)
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return j;
        }
        #endregion
    }
}