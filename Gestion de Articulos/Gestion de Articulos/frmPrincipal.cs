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
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccion = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccion.Imagen.UrlLink);
        }

        private void cargar()
        {
            gestionArticulo lista = new gestionArticulo();
            listaArt = lista.listar();
            try
            {
                dgv_Articulos.DataSource = listaArt;
            }
            catch (Exception)
            {

                throw;
            }
            dgv_Articulos.Columns["Imagen"].Visible = false;
            cargarImagen(listaArt[0].Imagen.UrlLink);
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            frm_Editar ventana = new frm_Editar();
            ventana.ShowDialog();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_Agregar ventana = new frm_Agregar();
            ventana.ShowDialog();
            cargar();
        }


        /*private void Principal_Load(object sender, EventArgs e)
        {//Cargador de Formulario
            Conexion.Conectar();
            dgv_Articulos.DataSource = Index();
        }
        // Metodo para cargar los datos del Data Grid View
        public DataTable Index()
        {
            Conexion.Conectar();
            DataTable datatabe = new DataTable();
            string sql = "SELECT * FROM Articulos";

            SqlCommand cmd = new SqlCommand(sql, Conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(datatabe);

            return datatabe;

        }
        //Agregar
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();

                string SQL_Agregar = @"
                                INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                                VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)";

                SqlCommand command = new SqlCommand(SQL_Agregar, Conexion.Conectar());
                command.Parameters.AddWithValue("@Codigo", tbx_Codigo.Text);
                command.Parameters.AddWithValue("@Nombre", tbx_Nombre.Text);
                command.Parameters.AddWithValue("@Descripcion", tbx_Descripcion.Text);
                command.Parameters.AddWithValue("@IdMarca", int.Parse(cbx_Marca.Text));
                command.Parameters.AddWithValue("@IdCategoria", int.Parse(cbx_Categoria.Text));
                command.Parameters.AddWithValue("@Precio", decimal.Parse(tbx_Precio.Text));

                //guardamos los datos ejecutando la consulta SQL
                command.ExecuteNonQuery();
                MessageBox.Show("Articulo Agregado correctamente");
                dgv_Articulos.DataSource = Index();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                throw;
            }
            finally 
            {
                
            }
            

        }*/
    }
}
