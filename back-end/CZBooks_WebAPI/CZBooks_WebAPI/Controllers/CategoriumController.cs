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
    public class CategoriumController : ControllerBase
    {
            private ICategoriumRepository _categoriumRepository { get; set; }

            public CategoriumController()
            {
                _categoriumRepository = new CategoriaRepository();
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_categoriumRepository.Listar());
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
                    return Ok(_categoriumRepository.BuscarPorId(id));
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            [HttpPost]
            public IActionResult Post(Categorium novoCategoria)
            {
                try
                {
                    _categoriumRepository.Cadastrar(novoCategoria);

                    // Retorna um status code
                    return StatusCode(201);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }

            [HttpPut("{id}")]
            public IActionResult Put(int id, Categorium categoriaAtualizado)
            {
                try
                {
                    _categoriumRepository.Atualizar(id, categoriaAtualizado);

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
                    _categoriumRepository.Deletar(id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }

        }
    }

