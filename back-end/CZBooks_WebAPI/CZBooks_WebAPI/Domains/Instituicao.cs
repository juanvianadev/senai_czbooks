using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks_WebAPI.Domains
{
    public partial class Instituicao
    {
        public int IdInst { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
