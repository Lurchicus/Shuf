using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuf
{
    static class Program
    {
        //This project exists for the sole purpose of honing my C# skills as I transition away
        // from VB.NET as my primary .NET language.
        // Copyright Dan Rhea 2015
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Shuf1());
        }
    }
}
