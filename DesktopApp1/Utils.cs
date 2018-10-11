using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeromApp
{
    class Utils
    {
        public static float TryParseFloat(string s)
        {
            float result;
            float.TryParse(s, out result);
            return result;
        }
        public static int TryParseInt(string s)
        {
            int result;
            int.TryParse(s, out result);
            return result;
        }

        public static void WriteObject<T>(string fileName, T item)
        {
            File.AppendAllText(fileName, JsonConvert.SerializeObject(item));
        }

        public static List<T> ReadFromFile<T>(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<T>();
            }

            var txt = File.ReadAllText(fileName);

            if (string.IsNullOrEmpty(txt))
            {
                return new List<T>();
            }

            return JsonConvert.DeserializeObject<List<T>>(txt);
        }


        public static void WriteArray<T>(string fileName, T item) =>

            File.WriteAllText(fileName, JsonConvert.SerializeObject(item));

        public static void AppendObject<T>(string fileName, T item)
        {
            var items = ReadFromFile<T>(fileName);
            items.Add(item);
            WriteArray(fileName, items);
        }

    }
}
