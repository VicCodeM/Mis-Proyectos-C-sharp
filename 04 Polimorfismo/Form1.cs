using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Radio";
            label2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Lado 1";
            label2.Visible=true;
            label3.Visible=false;
            textBox2.Visible=true;
            textBox3.Visible=false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Lado 1";
            textBox2.Visible = true;
            textBox3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double radio;
                radio = Convert.ToDouble(textBox1.Text);
                Ciirculo c1 = new Ciirculo(radio);
                Listbox1.Items.Add(c1);
                textBox1.Text = "";
            }
            if (radioButton2.Checked == true)
            {
                double lado1, lado2;
                lado1 = Convert.ToDouble(textBox1.Text);
                lado2 = Convert.ToDouble(textBox2.Text);
                Rectangulo r1 = new Rectangulo(lado1, lado2);
                Listbox1.Items.Add(r1);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (radioButton3.Checked == true)
            {
                double lado1, lado2, lado3;
                lado1= Convert.ToDouble(textBox1.Text);
                lado2= Convert.ToDouble(textBox2.Text);
                lado3 = Convert.ToDouble(textBox3.Text);
                Triangulo t1 = new Triangulo(lado1, lado2, lado3);
                Listbox1.Items.Add(t1);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }

        private void Listbox1_Click(object sender, EventArgs e)
        {
            double area = ((IFiguras)Listbox1.SelectedItem).Area();
            double perimetro= ((IFiguras)Listbox1.SelectedItem).Perimetro();
            string mensaje = string.Format("El area de la figura es {0:0.00} y \n" + "El perimetro de la figura es {1:0.00}", area, perimetro);
            MessageBox.Show(mensaje);
        }
        
    }
}
