using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks_WebAPI.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int IdAutor { get; set; }
        public int IdCategoria { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string DataPubli { get; set; }
        public decimal Preco { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categorium IdCategoriaNavigation { get; set; }
    }
}
