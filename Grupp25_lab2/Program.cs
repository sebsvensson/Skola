using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Grupp 25:
 * Emma Davidsson
 * Jesper Storberg
 * Ludvig Olofsson
 * Mirwais Hotaki
 * Sebastian Svensson
 */

namespace Grupp25_lab2
{
    static class Program
    {
        public static AppForm appform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Kurs.PopulateKurser();
            Student.PopulateStudenter();
            Lärare.PopulateLärare();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            appform = new AppForm();
            Application.Run(appform);
        }
    }
}
