using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Articulos
{
    internal class Conexion
    {
        public static SqlConnection Conectar() 
        {
            SqlConnection conexion = new SqlConnection("server=CristianEsc\\SQLEXPRESS01; database=CATALOGO_P3_DB; Trusted_Connection=true; ");
            conexion.Open();

            return conexion;
        }
    }
}
