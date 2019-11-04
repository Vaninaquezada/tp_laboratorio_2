using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivo
{
    public class Texto
    {
        /// <summary>
        /// Guarda datos en un archivo
        /// </summary>
        /// <param name="archivo">archivo en el que se guardan los datos</param>
        /// <param name="datos">datos a guardar en el archivo</param>
        /// <returns>true si se guardo el archivo sino false</returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
                {
                    file.WriteLine(datos);
                }

                return true;
            }
            catch (Exception e)
            {
                throw new Excepciones.ArchivosException(e);
            }
        }
        /// <summary>
        /// Lee un archivo txt
        /// </summary>
        /// <param name="archivo">archivo a leer</param>
        /// <param name="datos">datos que contiene el archivo</param>
        /// <returns>true si se pudo leer el archivo sino false</returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                }

                return true;
            }
            catch (Exception e)
            {
                throw new Excepciones.ArchivosException(e);
            }
        }
    }
}
