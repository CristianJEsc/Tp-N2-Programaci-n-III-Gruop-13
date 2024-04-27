using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using dominio;
using conexion;
using System.Data.SqlTypes;

namespace gestor
{
    public class gestionArticulo
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Conexion acceso = new Conexion();

            try
            {
                //acceso.setearConsulta("select distinct(a.Id) as Id, Codigo, Nombre, a.Descripcion as Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, Precio, i.ImagenUrl as 'Url' from Articulos a left join Marcas m on m.Id=a.IdMarca left join Categorias c on c.Id=a.IdCategoria left join Imagenes i on a.id=i.IdArticulo"); //de momento la consulta repite el articulo si tiene mas de una imagen (ej: articulo id=2). hay que revisar esto
                acceso.setearConsulta("select distinct(a.Id) as Id, Codigo, Nombre, a.Descripcion as Descripcion, case when m.Descripcion is null then '' else m.Descripcion end as Marca, case when c.Descripcion is null then '' else c.Descripcion end as Categoria, Precio, case when i.ImagenUrl is null then '' else i.ImagenUrl end as 'Url' from Articulos a left join Marcas m on m.Id=a.IdMarca left join Categorias c on c.Id=a.IdCategoria left join Imagenes i on a.id=i.IdArticulo"); //usar esta hasta que me respondan la consulta en el foro
                acceso.ejecutarLectura();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)acceso.Lector["Id"];
                    aux.Codigo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    if(!(acceso.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)acceso.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    if(!(acceso.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)acceso.Lector["Categoria"];
                    aux.Precio = (decimal)acceso.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    if(!(acceso.Lector["Url"] is DBNull))
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

        public void agregar(Articulo nuevo)
        {
            Conexion acceso = new Conexion();
            
            try
            {
                acceso.setearConsulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio )values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, " + nuevo.Precio + " )");
                acceso.setearParametro("@IdMarca", nuevo.Marca.IdMarca);
                acceso.setearParametro("@IdCategoria", nuevo.Categoria.IdCategoria);
        
                acceso.ejecutarAccion();
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            Conexion datos = new Conexion();
            List<Articulo> lista = new List<Articulo>();
            try
            {
                string consulta = @"select distinct(a.Id) as Id, Codigo, Nombre, a.Descripcion as Descripcion, case when m.Descripcion is null then '' else m.Descripcion end as Marca, case when c.Descripcion is null then '' else c.Descripcion end as Categoria, Precio, case when i.ImagenUrl is null then '' else i.ImagenUrl end as 'Url' from Articulos a left join Marcas m on m.Id=a.IdMarca left join Categorias c on c.Id=a.IdCategoria left join Imagenes i on a.id=i.IdArticulo ";

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += " where Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += " where Precio < " + filtro;
                            break;
                        default:
                            consulta += " where Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " where Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " where Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += " where Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " where m.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " where m.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += " where m.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Categoria")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " where c.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " where c.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += " where c.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta( consulta );
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    if (!(datos.Lector["Url"] is DBNull))
                        aux.Imagen.UrlLink = (string)datos.Lector["Url"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
