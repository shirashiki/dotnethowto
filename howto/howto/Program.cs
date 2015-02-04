using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pepo.Howto
{
    /// <summary>
    /// Pepo is the name of my parrot!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //  run this with Ctrl + F5 to see output
            Console.Write(howto.Properties.Settings.Default.ExampleSetting);
        }
    }
}
