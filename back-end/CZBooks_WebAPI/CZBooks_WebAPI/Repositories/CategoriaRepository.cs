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
    public class CategoriaRepository : ICategoriumRepository
    {
        CzBooksContext ctx = new CzBooksContext();

        public void Atualizar(int id, Categorium categoriaAtualizado)
        {
        Categorium categoriaBuscado = ctx.Categoria.Find(id);

            if (categoriaAtualizado.Nome != null)
            {
                categoriaBuscado.Nome = categoriaAtualizado.Nome;
            }
        }

        public Categorium BuscarPorId(int id)
        {
           return ctx.Categoria.FirstOrDefault(e => e.IdCategoria == id);
        }

        public void Cadastrar(Categorium novoCategoria)
        {
            ctx.Categoria.Add(novoCategoria);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Categoria.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Categorium> Listar()
        {
            return ctx.Categoria

                .Include(e => e.IdCategoria)

                .ToList();
        }
    }
}
