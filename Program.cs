using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Standalone
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
            bool game = true;
            do
            {
                Application.Run(new Game());
                DialogResult d = MessageBox.Show("Szeretnél új játékot kezdeni?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                    game = true;
                else
                    game = false;
            } while (game);
        }
    }
}
