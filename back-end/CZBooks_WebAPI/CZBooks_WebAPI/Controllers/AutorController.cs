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
    public class AutorController : ControllerBase
    {
        private IAutorRepository _autorRepository { get; set; }

        public AutorController()
        {
            _autorRepository = new AutorRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_autorRepository.Listar());
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
                return Ok(_autorRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Autor novoAutor)
        {
            try
            {
                _autorRepository.Cadastrar(novoAutor);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Autor autorAtualizado)
        {
            try
            {
                _autorRepository.Atualizar(id, autorAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _autorRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
