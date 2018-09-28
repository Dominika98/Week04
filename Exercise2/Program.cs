using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Danielita", "Koch", 2412);

            // IFormatter formatter = new BinaryFormatter();
            // Stream stream = new FileStream("thing.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            // formatter.Serialize(stream, p);
            // stream.Close();

            MemoryStream stream1 = new MemoryStream();  
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            ser.WriteObject(stream1, p);

            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            System.Console.WriteLine("JSON from of Person objext: ");
            System.Console.WriteLine(sr.ReadToEnd());
        }
    }
}
