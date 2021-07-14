using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CZBooks_WebAPI.Domains;
using CZBooks_WebAPI.Interfaces;
using CZBooks_WebAPI.Repositories;
using System;

namespace CZBooks_WebAPI.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    [Authorize(Roles = "1")]
    public class LivroController : ControllerBase
    {

        private ILivroRepository _livroRepository { get; set; }

 
        public LivroController()
        {
            _livroRepository = new LivroRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_livroRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Livro novoLivro)
        {
            try
            {
                _livroRepository.Cadastrar(novoLivro);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Livro livroAtualizado)
        {
            try
            {

                _livroRepository.Atualizar(id, livroAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

