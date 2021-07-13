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
    public class UsuarioRepository : IUsuarioRepository
    {
        CzBooksContext ctx = new CzBooksContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {

            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            // Verifica se o e-mail do usuário foi informado
            if (usuarioAtualizado.Email != null)
            {
                // Atribui os novos valores ao campos existentes
                usuarioBuscado.Email = usuarioAtualizado.Email;
            }

            // Verifica se a senha do usuário foi informado
            if (usuarioAtualizado.Senha != null)
            {
                // Atribui os novos valores ao campos existentes
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            // Atualiza o tipo de usuário que foi buscado
            ctx.Usuario.Update(usuarioBuscado);

            // Salva as informações para serem gravadas no banco
            ctx.SaveChanges();

        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {

            return ctx.Usuario

                .Include(e => e.IdUsuario)

                .ToList();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
