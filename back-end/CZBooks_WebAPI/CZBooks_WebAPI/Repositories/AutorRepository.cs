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
    public class AutorRepository : IAutorRepository
    {
        CzBooksContext ctx = new CzBooksContext();


        public void Atualizar(int id, Autor autorAtualizado)
        {
            Autor autorBuscado = ctx.Autors.Find(id);

            if (autorAtualizado.Nome != null)
            {
                autorBuscado.Nome = autorAtualizado.Nome;
            }
        }

        public Autor BuscarPorId(int id)
        {
            return ctx.Autors.FirstOrDefault(e => e.IdAutor == id);
        }

        public void Cadastrar(Autor novoAutor)
        {
            ctx.Autors.Add(novoAutor);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Autors.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Autor> Listar()
        {

            return ctx.Autors

                .Include(e => e.IdAutor)
         
                .ToList();
        }
    }
}

       
