using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Configuration;
using dominio;
using gestor;
using conexion;

namespace Gestion_de_Articulos
{
    public partial class frm_Principal : Form
    {
        private List<Articulo> listaArt;
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cargar();
            cbo_Campo.Items.Add("Nombre");
            cbo_Campo.Items.Add("Marca");
            cbo_Campo.Items.Add("Categoria");
            cbo_Campo.Items.Add("Precio");

        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Articulos.CurrentRow != null) 
            {
                Articulo seleccion = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.Imagen.UrlLink);
            }
            
        }

        private void cargar()
        {
            gestionArticulo lista = new gestionArticulo();
            
            try
            {
                listaArt = lista.listar();
                dgv_Articulos.DataSource = listaArt;
                ocultarColumnas();
                cargarImagen(listaArt[0].Imagen.UrlLink);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ocultarColumnas() 
        {
            dgv_Articulos.Columns["Imagen"].Visible = false;
            dgv_Articulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pb_Imagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_Imagen.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_Agregar ventana = new frm_Agregar();
            ventana.ShowDialog();
            cargar();
        }

        private void tb_Buscador_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filtro = tb_Buscador.Text;
            if (filtro != "")
            {
                listafiltrada = listaArt.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Marca.ToString().ToLower().Contains(filtro.ToLower()) || x.Descripcion.ToLower().Contains(filtro.ToLower()) || x.Categoria.ToString().ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listafiltrada = listaArt;
            }
            dgv_Articulos.DataSource = null;
            dgv_Articulos.DataSource = listafiltrada;
            ocultarColumnas();
        }

        private void cbo_Campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbo_Campo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbo_Criterio.Items.Clear();
                cbo_Criterio.Items.Add("Mayor a");
                cbo_Criterio.Items.Add("Menor a");
                cbo_Criterio.Items.Add("Igual a");
            }
            else if (opcion == "Nombre")
            {
                cbo_Criterio.Items.Clear();
                cbo_Criterio.Items.Add("Comienza con");
                cbo_Criterio.Items.Add("Termina con");
                cbo_Criterio.Items.Add("Contiene");
            }
            else if (opcion == "Marca")
            {
                cbo_Criterio.Items.Clear();
                cbo_Criterio.Items.Add("Comienza con");
                cbo_Criterio.Items.Add("Termina con");
                cbo_Criterio.Items.Add("Contiene");
            }
            else 
            {
                cbo_Criterio.Items.Clear();
                cbo_Criterio.Items.Add("Comienza con");
                cbo_Criterio.Items.Add("Termina con");
                cbo_Criterio.Items.Add("Contiene");

            }
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            try
            {

                gestionArticulo articulo = new gestionArticulo();
                if (cbo_Campo.SelectedItem == null || cbo_Criterio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un campo y un criterio para filtrar.");
                    return;
                }

                string campo = cbo_Campo.SelectedItem.ToString();
                string criterio = cbo_Criterio.SelectedItem.ToString();
                string filtro = tbx_Filtro.Text;

                dgv_Articulos.DataSource = articulo.filtrar(campo, criterio, filtro);
            }

            catch (Exception)
            {

                MessageBox.Show("Por favor añada los campos a filtrar");
            }
        
        }

        private void btn_Editar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            frm_Agregar modificar = new frm_Agregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btn_Detalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            frm_Detalle detalle = new frm_Detalle(seleccionado);
            detalle.ShowDialog();
            cargar();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Marcas fr = new Marcas();
            fr.ShowDialog();
        }
    }
}
