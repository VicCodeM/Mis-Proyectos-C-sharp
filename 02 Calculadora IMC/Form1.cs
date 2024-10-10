namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double estatura, peso;
                string nombre;
                nombre = textNombre.Text;
                estatura = double.Parse(textEstatura.Text);//convertimos texto a double
                peso = double.Parse(textPeso.Text);//convertimos texto a double
                Persona cliente = new Persona(nombre, estatura, peso);//constructor
                listBox1.Items.Add(cliente);//agregamos ala lista de datos
                textEstatura.Text = "";
                textNombre.Text = "";
                textPeso.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error");
            }
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            double imc;
            string nombre;
            imc = ((Persona)listBox1.SelectedItem).CalcIMC();
            nombre = ((Persona)listBox1.SelectedItem).nombre;
            MessageBox.Show(string.Format("{0} tiene un IMC de {1:0.00}",nombre, imc),"Atención");


        }
    }
}