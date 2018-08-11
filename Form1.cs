using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    

    public partial class Form1 : Form
    {

        static public bool enable = false;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = enable;
            button_output.Enabled = enable;
           
        }

        private void CreateGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;
            PointPairList list = new PointPairList();
            myPane.CurveList.Clear();
            for (int i = 0; i < Program.y.Count; i++)
            {
                list.Add(i, Program.y[i]);
            }
            myPane.Title = "";
            LineItem myCurve = myPane.AddCurve("Result",
                  list, Color.Purple, SymbolType.None);

            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CreateGraph(zedGraphControl1);
        }

        private void Enter_k_Click(object sender, EventArgs e)
        {


   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button_init_Click(object sender, EventArgs e)
        {
            enable = false;

            string s_q = textBox_q.Text;
            string s_b = textBox_b.Text;
            string s_a1 = textBox_a1.Text;
            string s_a2 = textBox_a2.Text;
            string s_T = textBox_T.Text;
            string s_x0 = textBox_x0.Text, s_x1 = textBox_x1.Text, s_x2 = textBox_x2.Text;

            if (!Processing.checkString(s_q, s_b, s_a1, s_a2, s_T, s_x0, s_x1, s_x2)) { MessageBox.Show(" The fields are empty."); }

            else
            {
                try
                {

                    Processing.q = Int32.Parse(s_q);

                    Processing.a1 = double.Parse(s_a1);
                    Processing.a2 = double.Parse(s_a2);
                    Processing.b = double.Parse(s_b);
                    Processing.T = double.Parse(s_T);
                    Processing.x_0.M[0][0] = double.Parse(s_x0);
                    Processing.x_0.M[1][0] = double.Parse(s_x1);
                    Processing.x_0.M[2][0] = double.Parse(s_x2);





                    Program.k = (int)(30 / Processing.T);

                    if (!Processing.checkComponents(Processing.q, Processing.a1, Processing.a2, Processing.T)) MessageBox.Show(" Incorrect parametres. Please, try to input again.");
                    else
                    {
                        Processing.function();
                        if (!Processing.checkLimit) MessageBox.Show(" Limit doesn't exist . Please, Enter correct T.");
           
                        enable = true;
                    }

                    button1.Enabled = enable;
                    button_output.Enabled = enable;

                }
                catch (Exception ex)
                {
                    enable = false;
                    MessageBox.Show(ex.Message);
                    button1.Enabled = enable;
                    button_output.Enabled = enable;
                }
            }






        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label_k_Click(object sender, EventArgs e)
        {

        }

        private void label_q_Click(object sender, EventArgs e)
        {

        }

        private void button_output_Click(object sender, EventArgs e)
        {


            
                Form2 form = new Form2();
                form.Show();

                form.textBox_output_TextChanged();
                form.Show();
            


        }

        private void textBox_q_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_T_TextChanged(object sender, EventArgs e)
        {

        }
                
    }
}
