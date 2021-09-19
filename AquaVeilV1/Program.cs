using System;
using System.Windows.Forms;
using AquaVeilV1.Forms;

namespace AquaVeilV1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frMain());
        }
    }
}
