using System;
using System.Windows.Forms;
using System.Threading;
namespace WildFireGDI
{
    static class Program
    {
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm window = new MainForm();
            Application.Run(window);

        }
    }
}
