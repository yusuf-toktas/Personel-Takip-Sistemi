using System;
using System.Windows.Forms;

namespace PTS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FormLogin formLogin = new FormLogin())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormPersonelYonetimi());
                }
            }
        }
    }
}