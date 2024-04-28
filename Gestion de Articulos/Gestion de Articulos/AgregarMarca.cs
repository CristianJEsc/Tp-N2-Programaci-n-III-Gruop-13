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
    public partial class AgregarMarca : Form
    {
        private gestionMarca gestionMarca = new gestionMarca();
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void AgregarMarca_Load(object sender, EventArgs e)
        {
            int id = 0;
            txtid.Text =Convert.ToString(gestionMarca.ProximoID());
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("LA MARCA YA EXISTE", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {


                    gestionMarca.AgregarMarca(txbDescripcion.Text);
                    MessageBox.Show("Marca agregada correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            marcas = gestionMarca.ListaMarcas();
            foreach (var item in marcas)
            {
                if (item.Equals(nombre.ToUpper()))
                {
                    validar = true;
                }

            }
            

            return validar;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
