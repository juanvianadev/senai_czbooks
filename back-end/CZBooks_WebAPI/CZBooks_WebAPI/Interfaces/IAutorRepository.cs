using CZBooks_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks_WebAPI.Interfaces
{
    interface IAutorRepository
    {
        List<Autor> Listar();

        /// <summary>
        /// Busca um evento através do ID
        /// </summary>
        /// <param name="id">ID do evento que será buscado</param>
        /// <returns>Um evento buscado</returns>
        Autor BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo evento
        /// </summary>
        /// <param name="novoEvento">Objeto novoEvento que será cadastrado</param>
        void Cadastrar(Autor novoAutor);

   
        void Atualizar(int id, Autor autorAtualizado);

        /// <summary>
        /// Deleta um evento existente
        /// </summary>
        /// <param name="id">ID do evento que será deletado</param>
        void Deletar(int id);
    }
}
