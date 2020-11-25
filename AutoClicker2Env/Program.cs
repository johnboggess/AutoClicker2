using System;
using System.IO;

using PerCederberg.Grammatica.Runtime;
namespace AutoClicker2Env
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"bool funcName(bool a, number b, string c)";
            Parser parser = new GrammarParser(new StringReader(str));
            Node n = parser.Parse();
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
