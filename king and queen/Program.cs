using System;
using System.Windows.Forms;

namespace TicTacToeApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Start the application with the main menu
        }
    }
}
