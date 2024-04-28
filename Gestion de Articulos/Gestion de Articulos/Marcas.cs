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
using dominio;
using gestor;


namespace Gestion_de_Articulos
{
    public partial class Marcas : Form
    {

        private gestionMarca GestMarca = new gestionMarca();
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public List<Marca> CargaDatos()
        {
            List<Marca> lista = new List<Marca>();

            lista = GestMarca.listar();
            dgv_Marcas.DataSource = lista;


            return lista;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string marca;
            marca = Convert.ToString(dgv_Marcas.SelectedRows[0].Cells[1].Value);

            DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR LA MARCA: " + marca, "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                int id;
                id = Convert.ToInt32(dgv_Marcas.SelectedRows[0].Cells[0].Value);
                GestMarca.EliminarMarca(id);
                //  MessageBox.Show(Convert.ToString(id));
                this.CargaDatos();

            }
            else
            {
                return;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
          AgregarMarca fr = new AgregarMarca();
            fr.Show();
            CargaDatos();
        }
    }
}
