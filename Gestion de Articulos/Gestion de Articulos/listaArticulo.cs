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
                acceso.setearConsulta("select distinct( a.Id) as Id, Codigo, Nombre, a.Descripcion as Descripcion, case when m.Descripcion is null then '' else m.Descripcion end as Marca, case when c.Descripcion is null then '' else c.Descripcion end as Categoria, Precio, case when i.ImagenUrl is null then '' else i.ImagenUrl end as 'Url' from Articulos a left join Marcas m on m.Id=a.IdMarca left join Categorias c on c.Id=a.IdCategoria left join Imagenes i on a.id=i.IdArticulo"); //de momento la consulta repite el articulo si tiene mas de una imagen (ej: articulo id=2). hay que revisar esto
                acceso.ejecutarLectura();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)acceso.Lector["Id"];
                    aux.Codigo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)acceso.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)acceso.Lector["Categoria"];
                    aux.Precio = (decimal)acceso.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.UrlLink = (string)acceso.Lector["Url"];

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
