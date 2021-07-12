using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks_WebAPI.Domains
{
    public partial class Categorium
    {
        public Categorium()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdCategoria { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
