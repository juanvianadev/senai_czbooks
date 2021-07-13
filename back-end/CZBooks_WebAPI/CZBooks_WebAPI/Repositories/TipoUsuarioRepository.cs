using Microsoft.EntityFrameworkCore;
using CZBooks_WebAPI.Contexts;
using CZBooks_WebAPI.Domains;
using CZBooks_WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks_WebAPI.Repositories
{
    public class TiposUsuarioRepository : ITipoUsuarioRepository
    {
        CzBooksContext ctx = new CzBooksContext();

        public void Atualizar(int id, TiposUsuario TipoUAtualizado)
        {
            TiposUsuario TipoUoBuscado = ctx.TiposUsuario.Find(id);

            if (TipoUAtualizado.Tipo != null)
            {
                TipoUoBuscado.Tipo = TipoUAtualizado.Tipo;
            }

        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Cadastrar(TiposUsuario novoTiposU)
        {
            ctx.TiposUsuario.Add(novoTiposU);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.TiposUsuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {

            return ctx.TiposUsuario

                .Include(e => e.IdTipoUsuario)

                .ToList();
        }
    }
}

