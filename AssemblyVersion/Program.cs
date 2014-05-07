using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyVersion
{
    class Program
    {
        /// <summary>
        /// This is designed to be a console application that accepts the path to an assembly file as the first argument.
        /// Reflection is used to write the Version information to the console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(args[0]);
            Console.WriteLine(asm.GetName().Version.Major + "." + asm.GetName().Version.Minor + "." + asm.GetName().Version.Build);
        }
    }
}
