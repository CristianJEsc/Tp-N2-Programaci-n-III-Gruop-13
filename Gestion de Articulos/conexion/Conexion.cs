using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion
{
    /*internal class Conexion
{
    public static SqlConnection Conectar() 
    {
        SqlConnection conexion = new SqlConnection("server=CristianEsc\\SQLEXPRESS01; database=CATALOGO_P3_DB; Trusted_Connection=true; ");
        conexion.Open();

        return conexion;
    }
}*/
    public class Conexion
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public Conexion()
        {
            conexion = new SqlConnection("server=192.168.1.2,1433\\sql-server-express; database=CATALOGO_P3_DB; integrated security = false; user=SA; password=Cor12345!; "); //Cristian: comentar esta linea y descomentar la siguiente
            //conexion = new SqlConnection("server=CristianEsc\\SQLEXPRESS01; database=CATALOGO_P3_DB; Trusted_Connection=true; "); //Franco: comentar esta línea y descomentar la anterior
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();

        }
    }
}
