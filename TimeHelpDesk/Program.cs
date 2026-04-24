using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHelpDesk
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                FormLogin login = new FormLogin();

                if (login.ShowDialog() != DialogResult.OK)
                    break; // fecha o app se cancelar login

                Form1 principal = new Form1();
                Application.Run(principal);
            }
        }
    }
}
