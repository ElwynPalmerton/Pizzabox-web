using System.IO;
using System.Xml.Serialization;
using sc = System.Console;

namespace PizzaBox.Storing.Repositories
{
    public class FileRepository
    {
        public T ReadFromFile<T>(string path) where T : class
        {
            try
            {
                var reader = new StreamReader(path);
                var xml = new XmlSerializer(typeof(T));
                return xml.Deserialize(reader) as T;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public bool WriteToFile<T>(string path, T items) where T: class
        {
            try{
                var writer = new StreamWriter(path);
                var xml = new XmlSerializer(typeof(T));
                xml.Serialize(writer, items);
                return true;
            }
            catch (System.Exception e) {
                return false;
            }
        }
    }

}