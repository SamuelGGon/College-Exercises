using System;

namespace GeneroMusical
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("sua mae");
            list.Add("Livia");

            list.Add("Caines");

            Console.WriteLine(list.Contains("sua mae"));

            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("cu", "inho");

            Console.WriteLine(d["cu"]);

        }
    }
}