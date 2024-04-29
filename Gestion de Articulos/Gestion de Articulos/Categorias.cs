using dominio;
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

namespace Gestion_de_Articulos
{
    public partial class Categorias : Form
    {
        private gestionCategoria GestCate = new gestionCategoria();
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }

        public List<Categoria> CargaDatos()
        {
            List<Categoria> lista = new List<Categoria>();

            lista = GestCate.listar();
            dgvCategorias.DataSource = lista;


            return lista;
        }



        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string marca;
            marca = Convert.ToString(dgvCategorias.SelectedRows[0].Cells[1].Value);

            DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR LA MARCA: " + marca, "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                int id;
                id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value);
                GestCate.EliminarCategoria(id);
                //  MessageBox.Show(Convert.ToString(id));
                this.CargaDatos();

            }
            else
            {
                return;
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value);
            string nombre = Convert.ToString(dgvCategorias.CurrentRow.Cells[1].Value);
            ModificarMarca fr = new ModificarMarca(id, nombre);
            fr.Show();
        }

        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
