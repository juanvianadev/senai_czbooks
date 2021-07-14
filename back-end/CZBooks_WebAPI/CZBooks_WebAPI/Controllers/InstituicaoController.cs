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
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _instituicaoRepository { get; set; }

        public InstituicaoController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(_instituicaoRepository.Listar());
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
                return Ok(_instituicaoRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Instituicao novaInstituicao)
        {
            try
            {
                _instituicaoRepository.Cadastrar(novaInstituicao);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Instituicao instituicaoAtualizada)
        {
            try
            {
                _instituicaoRepository.Atualizar(id, instituicaoAtualizada);

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
                _instituicaoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
