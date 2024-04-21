using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Articulos
{
    internal class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public Marca MarcaArt { get; set; }
        public string Marca { get; set; }    //a revisar

        //public Categoria CategoriaArt { get; set; }
        public string Categoria { get; set; }    //a revisar
        public decimal Precio { get; set; }

        //public List<Imagen> Imagenes { get; set; }
        public string UrlImagen { get; set; } //a revisar

    }
}
