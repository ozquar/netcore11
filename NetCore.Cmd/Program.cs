using NetCore.Lib;
using System;

namespace NetCore.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string s in Util.GetList())
                Console.WriteLine(s);

        }
    }
}