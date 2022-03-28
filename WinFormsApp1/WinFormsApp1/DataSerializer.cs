using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    internal class DataSerializer
    {
        // Creates Binary file
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) ;
            {
                File.Delete(filePath);
            }
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }
        // Converts Binary file
        public object BinaryDeserialize(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }

        // Creates XML file
        public void XmlSerialize(Type dataType, object data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            StreamWriter writer = new StreamWriter(filePath);
            xmlSerializer.Serialize(writer, data);
            writer.Close();
        }
        // Converts XML file
        public object XmlDeserialize(Type dataType, string filePath)
        {
            object obj = null;
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                obj = xmlSerializer.Deserialize(reader);
                reader.Close();
            }
            return obj;
        }

        // Creates JSON file
        public void JsonSerialize(object data, string filePath)
        {
            string text = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(text);
            writer.Close();
        }

        // Converts JSON file
        public T JsonDeserialize<T>(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string text = sr.ReadToEnd();
            sr.Close();
            return JsonConvert.DeserializeObject<T>(text, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }
    }
}
