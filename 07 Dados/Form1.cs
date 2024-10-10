using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        int intento = 1;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Random x = new Random();
            int dado1 = x.Next(1, 6);
            int dado2 = x.Next(1, 6);
             label1.Text= "Dado1 "  + dado1 +"    Dado2 "+dado2;
            if (dado1 == dado2)
            {
                MessageBox.Show("Felicidades ganaste en " + intento + " intentos ");
                intento = 1;
            }
            intento++;
            
            
            
        }
    }
}
