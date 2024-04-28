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
    public partial class frm_Detalle : Form
    {
        private Articulo articulo = new Articulo();
        public frm_Detalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frm_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                tbx_Codigo.Text = articulo.Codigo;
                tbx_Nombre.Text = articulo.Nombre;
                tbx_Descripcion.Text = articulo.Descripcion;
                tbx_Marca.Text = articulo.Marca.Descripcion;
                tbx_Categoria.Text = articulo.Categoria.Descripcion;
                tbx_Precio.Text = articulo.Precio.ToString();
                tbx_url.Text = articulo.imagenes[0];
                cargarImagen(articulo.imagenes[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbx_articulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbx_articulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }
    }
}
