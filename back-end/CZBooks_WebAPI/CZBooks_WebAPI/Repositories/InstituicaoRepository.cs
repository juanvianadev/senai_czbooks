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
    public class InstituicaoRepository : IInstituicaoRepository
    {
        CzBooksContext ctx = new CzBooksContext();

        public void Atualizar(int id, Instituicao instAtualizado)
        {
            Instituicao instBuscado = ctx.Instituicao.Find(id);

            if (instAtualizado.Nome != null)
            {
                instBuscado.Nome = instAtualizado.Nome;
            }

            if (instAtualizado.Endereco != null)
            {
                instBuscado.Endereco = instAtualizado.Endereco;
            }
        }

        public Instituicao BuscarPorId(int id)
        {
            return ctx.Instituicao.FirstOrDefault(e => e.IdInst == id);
        }

        public void Cadastrar(Instituicao novoInst)
        {
            ctx.Instituicao.Add(novoInst);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Instituicao.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Instituicao> Listar()
        {

            return ctx.Instituicao

                .Include(e => e.IdInst)

                .ToList();
        }
    }
}
