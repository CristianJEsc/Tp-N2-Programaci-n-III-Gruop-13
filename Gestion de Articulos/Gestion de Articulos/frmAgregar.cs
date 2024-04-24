using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using gestor;

namespace Gestion_de_Articulos
{
    public partial class frm_Agregar : Form
    {
        public frm_Agregar()
        {
            InitializeComponent();
        }
        private void frm_Agregar_Load(object sender, EventArgs e)
        {
            gestionMarca marca = new gestionMarca();
            gestionCategoria cat = new gestionCategoria();
            try
            {
                cbo_Marca.DataSource = marca.listar();
                cbo_Categoria.DataSource = cat.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            gestionArticulo gestion = new gestionArticulo();
            try
            {
                art.Codigo = tbx_Codigo.Text;
                art.Nombre = tbx_Nombre.Text;
                art.Descripcion = tbx_Descripcion.Text;
                art.Marca = (Marca)cbo_Marca.SelectedItem;
                art.Categoria = (Categoria)cbo_Categoria.SelectedItem;
                art.Precio = decimal.Parse(tbx_Precio.Text);
                art.Imagen = new Imagen();
                art.Imagen.UrlLink = tbx_url.Text;

                gestion.agregar(art);
                MessageBox.Show("El artículo fue ingresado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
