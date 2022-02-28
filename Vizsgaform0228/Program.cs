using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizsgaform0228
{
    static class Program
    {
        internal static string ConnectionString = 
            "Server= (localdb)\\MSSQLlocalDB;" +
            "Database= vizsga;" +
            "Integrated Security = true;"
            
            
            ;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
