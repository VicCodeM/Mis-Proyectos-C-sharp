using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool Bisiesto(int a)
        {
            return (a % 4 == 0);
        }

        public int DiasMes(int a, int m)
        {
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                return 31;
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return 30;
            if (m == 2 && Bisiesto(a))
                return 29;
            else
                return 28;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int a = Convert.ToInt32(textBox3.Text);
            int n = Convert.ToInt32(textBox4.Text);

            for (int i = 0; i <= n; i++)
            {
                d++;
                if (d > DiasMes(a, m))
                {
                    d = 1;
                    m++;
                    if (m > 12)
                    {
                        m = 1;
                        a++;
                    }
                }
            }
            label5.Text = d+"/"+m+"/"+a;
        }
    }
}
