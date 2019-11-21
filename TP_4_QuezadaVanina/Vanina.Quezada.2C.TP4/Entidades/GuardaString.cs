using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
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
