using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Gestion_de_Articulos
{
    internal class listaArticulo
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Conexion acceso = new Conexion();

            try
            {
                acceso.setearConsulta("select a.Id as Id, Codigo, Nombre, a.Descripcion as Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, Precio from Articulos a join Marcas m on m.Id=a.IdMarca join Categorias c on c.Id=a.IdCategoria"); //la consulta es temporal, va a haber que reemplazar los id de marca y categoria por el nombre de los mismso
                acceso.ejecutarLectura();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)acceso.Lector["Id"];
                    aux.Codigo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    aux.Marca = (string)acceso.Lector["Marca"]; //a revisar
                    aux.Categoria = (string)acceso.Lector["Categoria"]; //a revisar
                    aux.Precio = (decimal)acceso.Lector["Precio"];

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
    }
}
