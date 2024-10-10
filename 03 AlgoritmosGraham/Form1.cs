using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraham
{
    public partial class Form1 : Form
    {
        Graphics papel;
        SolidBrush brocha;

        List<Point> lp;
        Point pivote;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            papel = pictureBox1.CreateGraphics();
            brocha = new SolidBrush(Color.Blue);

            lp = new List<Point>();
            pivote = new Point(0,0);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            papel.FillEllipse(brocha, e.X, e.Y,10,10);
            Point p1= new Point(e.X, e.Y);
            lp.Add(p1);
            if (e.Y > pivote.Y)
                pivote = p1;

        }

        public double Angulo(Point pivote,Point p2)
        {
            if (pivote.X == p2.X && pivote.Y == p2.Y)
                return 0;

            if (pivote.X < p2.X && pivote.Y == p2.Y)
                return 0;

            if (pivote.X < p2.X && pivote.Y > p2.Y)
                return Math.Atan((pivote.Y - p2.Y) / (double)(p2.X - pivote.X));

            if (pivote.Y > p2.Y && pivote.X == p2.X)
                return Math.PI / 2.0;

            if (pivote.X>p2.X && pivote.Y>p2.Y)
                return Math.PI-(Math.Atan(pivote.Y - p2.Y) / (double)(pivote.X - p2.X));
            else
                return Math.PI;
        }

        public Point[] ordena(List<Point> lp)
        {
            Point[] ap=lp.ToArray();
            for (int i = 0; i < ap.Length; i++)
            {
                for (int j = 0; j < ap.Length-1; j++)
                {
                    if (Angulo(pivote, ap[j]) > Angulo(pivote, ap[j + 1]))
                    {
                        Point temp = ap[j];
                        ap[j] = ap[j + 1];
                        ap[j + 1] = temp;
                    }

                }
            }
            return ap;
           
        }
        public int ccw(Point p1, Point p2, Point p3)
        {
            int op = (p2.Y-p1.Y)*(p3.X-p2.X)-(p2.X-p1.X)*(p3.Y-p2.Y);
            if (op == 0)
                return 0;
            if (op >0)
                return 1;
            else
                return -1;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Stack<Point> pp = new Stack<Point>();
                Point[] ap = ordena(lp);
                Point t;
                pp.Push(ap[0]);
                pp.Push(ap[1]);
                pp.Push(ap[2]);
                int i = 3;
                while (i < ap.Length)
                {
                    t = pp.Pop();
                    if (ccw(pp.Peek(), t, ap[i]) > 0)
                    {
                        pp.Push(t);
                        pp.Push(ap[i]);
                        i++;
                    }
                }

                ap = pp.ToArray();

                for (int j = 0; j < ap.Length - 1; j++)
                {
                    papel.DrawLine(new Pen(Color.Red), ap[j], ap[j + 1]);

                }
                papel.DrawLine(new Pen(Color.Red), ap[ap.Length - 1], ap[0]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            papel.Clear(pictureBox1.BackColor);
            lp.Clear();
            pivote = new Point (0,0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Estas seguro que quieres salir", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }
    }
}
