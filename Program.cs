using System;
using ZedGraph;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    static class Program
    {
        public static int k ;
        public static List<double> y = new List<double>();
        public static List<Matrix> x = new List<Matrix>();


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

           // Processing.function();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
     

        }
    }
}
