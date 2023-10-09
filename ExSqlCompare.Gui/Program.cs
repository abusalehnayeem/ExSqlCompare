using System;
using System.Windows.Forms;

namespace ExSqlCompare.Gui
{
    internal static class Program
    {
        #region private members

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion
    }
}