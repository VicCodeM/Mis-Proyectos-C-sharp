using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos
{
    public partial class Mascotas : Form
    {
        public Mascotas()
        {
            InitializeComponent();
        }

        private void mascotasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mascotasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.Mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.Fill(this.veterinariaDataSet.Mascotas);

        }
    }
}
