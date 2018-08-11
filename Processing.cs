using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    static class Processing
    {
        static public int q;
        static public double a1;
        static public double a2;
        static public double b;
        static public double T;
        static public bool checkLimit;
        static public Matrix x_0 = new Matrix(3, 1);

        static public bool checkString( string s1, string s2, string s3, string s4, string s5,string s6,string s7,string s8)
        {
            return (s1.Length != 0 && s2.Length != 0 && s3.Length != 0 && s4.Length != 0 && s5.Length != 0 && s6.Length != 0 && s7.Length != 0 && s8.Length != 0);
        }

        static public void function()
        {
            Program.x.Clear();
            Program.y.Clear();

            int k_var = (Program.k > 4) ? Program.k / 4 : Program.k;
            Matrix A = new Matrix(1, 1);
            Matrix B = new Matrix(1, 1);
            Matrix C = new Matrix(1, 1);
            Matrix E = new Matrix(1, 1);
            Matrix F = new Matrix(1, 1);
            Matrix G = new Matrix(1, 1);
            Matrix X = new Matrix(1, 1);

            

            A.inputByFile("inputA.txt");
            B.inputByFile("inputB.txt");
            C.inputByFile("inputC.txt");
            E.inputByFile("inputE.txt");
            A.M[2][1] = -a1;
            A.M[2][2] = -a2;
            B.M[2][0] = b;

            F = F.make_F(A, T, q);
          
            G = G.make_G(A, B, T, q);
          

            int[] u;
            init_u(Program.k, k_var, out u);

            checkLimit = Matrix.checkLimit(A, Processing.T);
            //Matrix.X_function_Y(F, G, u, T, C);
            Matrix.X_function_Y_const(F, G, T, C);
        }
       
        
        public static void init_u(int k, int k_var, out int[] result)
        {
            result = new int[(int)k + 1];
            for (int i = 0; i < k + 1; i++)
            {
                if (((i - 1) / k_var) % 2 == 0)
                    result[i] = 1;
                else result[i] = -1;

            }
        }
        public static bool checkComponents(int q, double a1, double a2, double T)
        {
            return(((q<=10 && q>=1) &&( a1<=10 && a1>=1) &&(a2<=10 && a2>=1) && (T<=1 && T>=0.001)));
        }
    }
}
