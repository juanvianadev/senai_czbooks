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
    public class LivroRepository : ILivroRepository
    {
        CzBooksContext ctx = new CzBooksContext();
        public void Atualizar(int id, Livro livroAtualizado)
        {
            Livro livroBuscado = ctx.Livro.Find(id);

            if (livroAtualizado.Sinopse != null)
            {
                livroBuscado.Sinopse = livroAtualizado.Sinopse;
            }

            if (livroAtualizado.Preco > 0 )
            {
                livroBuscado.Preco = livroAtualizado.Preco;
            }
        }

        public Livro BuscarPorId(int id)
        {
            return ctx.Livro.FirstOrDefault(e => e.IdLivro == id);
        }

        public void Cadastrar(Livro novoLivro)
        {
            ctx.Livro.Add(novoLivro);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Livro.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Livro> Listar()
        {

            return ctx.Livro

                .Include(e => e.IdLivro)

                .ToList();
        }
    }
}
