using gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using gestor;

namespace Gestion_de_Articulos
{
    public partial class ModificarCategoria : Form
    {
        private gestionCategoria gestCat = new gestionCategoria();
        public ModificarCategoria()
        {
            InitializeComponent();
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {

        }

        public ModificarCategoria(int id, string descripcion)
        {
            InitializeComponent();
            cargaDatos(id, descripcion);
        }

        public void cargaDatos(int id, string des)
        {
            txtID.Text = Convert.ToString(id);
            txbDescripcion.Text = des;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            gestCat.ModificarCategoria(Convert.ToInt32(txtID.Text), txbDescripcion.Text);
            MessageBox.Show("MARCA MODIFICADA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

    }
}
