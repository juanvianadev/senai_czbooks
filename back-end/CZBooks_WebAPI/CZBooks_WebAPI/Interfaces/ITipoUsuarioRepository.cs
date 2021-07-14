using CZBooks_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks_WebAPI.Interfaces
{
    interface ITiposUsuarioRepository
    {
         
            List<TiposUsuario> Listar();

            TiposUsuario BuscarPorId(int id);

            void Cadastrar(TiposUsuario novoTipoUsuario);


            void Atualizar(int id, Domains.TiposUsuario tipoUsuarioAtualizado);

            void Deletar(int id);

    }
}
