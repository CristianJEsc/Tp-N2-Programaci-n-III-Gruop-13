using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Articulos
{
    internal class Coneccion_a_DB
    {
        private SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CATALOGO_P3_DB;Data Source=CristianEsc\\SQLEXPRESS01");

    }
}
