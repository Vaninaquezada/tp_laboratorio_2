using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace Archivo
{
    public class Xml<T> : IArchivo<T>
    {

        /// <summary>
        /// Guarda datos en un archivo
        /// </summary>
        /// <param name="archivo">archivo en el que se guardan los datos</param>
        /// <param name="datos">datos a guardar en el archivo</param>
        /// <returns>true si se guardo el archivo sino false</returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(archivo);
                serializer.Serialize(writer, datos);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new Excepciones.ArchivosException(e);
            }
        }
        /// <summary>
        /// lee datos de un archivo
        /// </summary>
        /// <param name="archivo">archivo desde el que se leen los datos</param>
        /// <param name="datos">datos leidos del archivo</param>
        /// <returns>true si se leyo el archivo sino false</returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader reader = new StreamReader(archivo);
                datos = (T)serializer.Deserialize(reader);
                reader.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new Excepciones.ArchivosException(e);
            }
        }
    }
}
