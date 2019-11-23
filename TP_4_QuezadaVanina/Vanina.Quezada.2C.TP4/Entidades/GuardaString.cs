using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {


        /// <summary>
        /// Metodo de extencion Guarda datos en un archivo txt
        /// </summary>
        /// <param name="texto">texto a guardar en el archivo</param>
        /// <param name="archivo">nombre del archivo donde se guarda el texto</param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool respuesta = false;
            archivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\" + archivo;

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
                {
                    file.WriteLine(texto);
                }

                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return respuesta;
        }
    }
}
