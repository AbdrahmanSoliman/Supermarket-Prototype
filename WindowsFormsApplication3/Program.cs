using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Program
    {
        public static Form1 f1;
        public static Form2 f2;
        public static Form3 f3;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f1 = new Form1();
            f2 = new Form2();
            f3 = new Form3();
            Application.Run(f1);
            
        }
    }
}
