using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;

namespace Cacao.Utils
{
    class BinSerial
    {
        public static byte[] Serializar(object aSerializar)
        {
            MemoryStream memory = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(memory, aSerializar);

            return memory.ToArray();
        }

        public static object Deserializar(byte[] data)
        {
            MemoryStream memory = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Binder = new CurrentAssemblyDeserializationBinder();

            return formatter.Deserialize(memory);
        }
    }

    public class CurrentAssemblyDeserializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            return Type.GetType(String.Format("{0},{1}", typeName, Assembly.GetExecutingAssembly().FullName));
        }
    }
}
