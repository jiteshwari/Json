using Newtonsoft.Json.Linq;
using System;

namespace Json
{
    public class A
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string jsonData = "{  \"FirstName\":\"Jitu\",\"LastName\":\"Sahu\" }";
            dynamic data = JObject.Parse(jsonData);

            Console.WriteLine(string.Concat("Hi ", data.FirstName, " " + data.LastName));
            Console.ReadKey();
        }
    }
}
