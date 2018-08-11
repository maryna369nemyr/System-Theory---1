using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public void textBox_output_TextChanged()
        //{
           
        //    string message = "";
            
        //    int k = (int)Math.Log10(Program.k) - 1;
        //    for (int i = 0; i < Program.k; i = i + (int)(10 * (k > 0 ? k : 0.1)))
        //    {
        //        string temp = i.ToString(); message += temp + " \t ";
        //        for (int j = 0; j < Program.x[i].M.Length; j++)
        //            for (int l = 0; l < Program.x[i].M[j].Length; l++)
        //            {
        //                message += Program.x[i].M[j][l].ToString() + " \t ";

        //            }
        //        message += " \r\n ";
        //    }
        //    textBox_output.Text = message;
           
        //}



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void textBox_output_TextChanged()
        {
            string message = "";

            int k = (int)Math.Log10(Program.k) - 1;
            for (int i = 0; i < Program.k; i = i + (int)(10 * (k > 0 ? k : 0.1)))
            {
                string temp = i.ToString(); message += temp + " \t ";
                for (int j = 0; j < Program.x[i].M.Length; j++)
                    for (int l = 0; l < Program.x[i].M[j].Length; l++)
                    {
                        message += Program.x[i].M[j][l].ToString() + " \t ";

                    }
                message += " \r\n ";
            }
            textBox_output.Text = message;
        }
    }
}
