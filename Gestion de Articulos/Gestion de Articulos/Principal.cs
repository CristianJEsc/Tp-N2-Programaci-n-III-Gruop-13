using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestion_de_Articulos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
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
            

        }
    }
}
