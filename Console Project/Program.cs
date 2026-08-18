using DotEnv.Core;
using Newtonsoft.Json;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace ProjetFin
{
    internal class Program
    {
        internal static async Task Main()
        {
            Console.WriteLine("Before call");
            Rates test = new Rates();
            Console.WriteLine("After call");

        }
    }
}
