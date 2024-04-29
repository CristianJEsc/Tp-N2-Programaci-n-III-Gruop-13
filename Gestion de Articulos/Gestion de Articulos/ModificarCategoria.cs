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

        public ModificarCategoria(int id)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(gestCat.ProximoID());

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


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDescripcion.Text))
            {


                MessageBox.Show("LA DESCRIPCION NO PUEDE ESTAR VACIA", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (ValidarMarca(txbDescripcion.Text))
                {
                    MessageBox.Show("LA CATEGORIA YA EXISTE", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {


                    gestCat.AgregarCategoria(txbDescripcion.Text);
                    MessageBox.Show("Categoria agregada correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool ValidarMarca(string nombre)
        {
            List<string> marcas = new List<string>();
            bool validar = false;
            marcas = gestCat.ListaCategorias();
            foreach (var item in marcas)
            {
                if (item.Equals(nombre.ToUpper()))
                {
                    validar = true;
                }

            }


            return validar;

        }

    }
}
