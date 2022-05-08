using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    static class Program
    {
        [STAThread]
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void SetProcessDPIAware();
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
