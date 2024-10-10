using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoAzar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random n = new Random();
            int numero = n.Next(1, 20);
           textBox1.Text = Convert.ToString(numero);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string intento = "19";
            Random r = new Random();
            int n2 = r.Next(18, 21);
            if (intento == textBox1.Text)
            {
                MessageBox.Show("Felicidades, adivino el numero, Enhora buena!");
            }
            else

                MessageBox.Show("Lo siento, su numero no es correcto, intentelo de nuevo");
            
            textBox1.Text = Convert.ToString(n2);
        }
    }
}
