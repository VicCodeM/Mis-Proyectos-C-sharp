using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace frontendBacken
{
    public partial class Form1 : Form
    {
        List<string> numeros = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "" };
        Random r1 = new Random();
        Button [,] mb = new Button[4, 4];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int r = r1.Next(numeros.Count());
                    Button b1 = new Button();
                    b1.Text = numeros[r];
                    b1.Click += new System.EventHandler(Mover);

                    numeros.RemoveAt(r);
                    b1.Width = 100;
                    b1.Height = 100;
                    b1.Location = new Point(i * 100 + 5, j * 100 + 5);
                    b1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    mb[i, j] = b1;
                    Controls.Add(mb[i, j]);

                }

            }
        }

        private void Mover(object sender, EventArgs e)
        {
            int x = ((((Button)sender).Location.X) - 5) / 100;
            int y = ((((Button)sender).Location.Y) - 5) / 100;
            //MessageBox.Show("x=" + x + " y= " + y);
            if (x +1 <= 3)
            {
                if (mb[x+1,y].Text=="")
                {
                    string t = mb[x, y].Text;
                    mb[x, y].Text = mb[x+1, y].Text;
                    mb[x+1, y].Text = t;
                    Ganaste();
                }
            }

            if (x - 1 >= 0)
            {
                if (mb[x - 1, y].Text == "")
                {
                    string t = mb[x, y].Text;
                    mb[x, y].Text = mb[x - 1, y].Text;
                    mb[x - 1, y].Text = t;
                    Ganaste();
                }
            }
            if (y +1 <= 3)
            {
                if (mb[x, y + 1].Text == "")
                {
                    string t = mb[x, y].Text;
                    mb[x, y].Text = mb[x, y + 1].Text;
                    mb[x, y + 1].Text = t;
                    Ganaste();
                }
            }
            if (y - 1 >= 0)
            {
                if (mb[x, y-1].Text == "")
                {
                    string t = mb[x, y].Text;
                    mb[x, y].Text = mb[x, y-1].Text;
                    mb[x, y-1].Text = t;
                    Ganaste();
                }
            }

        }
        public void Ganaste()
        {
            bool bandera = false;
            int[,] mn = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mb[i, j].Text =="")
                    {
                        mn[i, j] = 16;
                        continue;
                        
                    }
                    mn[i, j] = Convert.ToInt32(mb[i, j].Text);
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mn[i, j] != (j * 4) + i + 1)
                    {
                        bandera = true;
                    }
    
                }

            }
            if (bandera == false)
            {
                MessageBox.Show("Felcidades Ganaste");
            }
        }
    }
}
