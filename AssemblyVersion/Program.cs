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
        /// The second argument can either be omitted or can be a full to use the full version number.
        /// Reflection is used to write the Version information to the console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                Console.WriteLine("AssemblyVersion.exe <path to assembly> \"-full\", use optional full for the full version number: <major>.<minor>.<build>.<revision>");
                return;
            }

            Assembly asm = Assembly.LoadFrom(args[0]);

            try
            {
                //use the full version number <major>.<minor>.<build>.<revision>
                if (args.Count() > 1 && String.Equals(args[1].TrimStart('-'), "full"))
                {
                    Console.WriteLine(asm.GetName().Version);
                    return;
                }
            }
            catch (Exception e)
            {
            }

            //use the old style version number <major>.<minor>.<build>
            Console.WriteLine(asm.GetName().Version.Major + "." + asm.GetName().Version.Minor + "." + asm.GetName().Version.Build);    
        }
    }
}
