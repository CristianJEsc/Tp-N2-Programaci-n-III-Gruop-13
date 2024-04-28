using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using conexion;
using System.Data.SqlTypes;


namespace gestor
{
    public class gestionMarca
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            Conexion acceso = new Conexion();
            try
            {
                acceso.setearConsulta("select Id, Descripcion from Marcas");
                acceso.ejecutarLectura();
                while (acceso.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IdMarca = (int)acceso.Lector["Id"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }

        public void AgregarMarca(string descripcion) {
        Conexion conexion = new Conexion();
            conexion.setearConsulta("  INSERT INTO MARCAS (Descripcion) VALUES (@descripcion)");
            conexion.setearParametro("descripcion", descripcion);
            conexion.ejecutarLectura();

            conexion.cerrarConexion();
        
        
        
        }

        public decimal  ProximoID()
        {
            decimal id = 0;
            Conexion conexion = new Conexion();
            conexion.setearConsulta("  SELECT IDENT_CURRENT('[CATALOGO_P3_DB].[dbo].[MARCAS]') + 1 AS ProximoId;");
            conexion.ejecutarLectura();
            conexion.Lector.Read();
            id = (decimal)conexion.Lector["ProximoId"];
            return id;
        }

        public void EliminarMarca(int id)
        {
            Conexion datos = new Conexion();

            try
            {

                datos.setearConsulta("delete from MARCAS where ID = @id ");
                datos.setearParametro("id", id);
                datos.ejecutarLectura();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            finally
            {

                datos.cerrarConexion();

            }

        }
    }
}
