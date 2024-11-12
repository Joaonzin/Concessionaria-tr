using AutoMapper;
using Concessionaria_tr.Entidades;
using Concessionaria_tr.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaApi.Controllers
{

    namespace ConcessionariaApi.Controllers
    {

        [ApiController]
        [Route("[controller]")]
        public class FuncionarioController : ControllerBase
        {
            private readonly IFuncionarioService _service;
            private readonly IMapper _mapper;

            public FuncionarioController(IFuncionarioService funcionarioService, IMapper mapper)
            {
                _service = funcionarioService;
                _mapper = mapper;
            }

            /// <summary>
            /// Endpoint para Adicionando um Funcionario
            /// </summary>
            /// <param name="Funcionario"></param>
            [HttpPost("adicionar-Funcionario")]
            public IActionResult AdicionarFuncionario(Funcionario funcionario)
            {
                try
                {
                    _service.Adicionar(funcionario);
                    return Ok();

                }
                catch (Exception erro)
                {

                    return BadRequest($"Ocorreu um erro ao adicionar um Funcionario, " +
                   $"o erro foi \n {erro.Message}");
                    throw;
                }

            }

            /// <summary>
            /// Endpoint para Litando um Funcionario
            /// </summary>
            /// <param name="Funcionario"></param>

            [HttpGet("listar-Funcionario")]
            public List<Funcionario> ListarFuncionario()
            {
                try
                {
                    return _service.Listar();
                }
                catch (Exception erro)
                {
                    throw new Exception($"Ocorreu um erro ao listar um Funcionario, " +
                                   $"o erro foi \n {erro.Message}");

                }

            }

            /// <summary>
            /// Endpoint para Editar um Funcionario
            /// </summary>
            /// <param name="Funcionario"></param>

            [HttpPut("editar-Funcionario")]
            public IActionResult EditarFuncionario(Funcionario funcionario)
            {
                try
                {
                    _service.Editar(funcionario);
                    return Ok();

                }
                catch (Exception erro)
                {

                    return BadRequest($"Ocorreu um erro ao editar um Funcionario, " +
                   $"o erro foi \n {erro.Message}");
                    throw;
                }

            }

            /// <summary>
            /// Endpoint para Deletar um Funcionario
            /// </summary>
            /// <param name="Funcionario"></param>

            [HttpDelete("deletar-Funcionario")]
            public IActionResult DeletarFuncionario(int id)
            {

                try
                {
                    _service.Remover(id);
                    return Ok();

                }
                catch (Exception erro)
                {

                    return BadRequest($"Ocorreu um erro ao deletar um Funcionario, " +
                   $"o erro foi \n {erro.Message}");
                    throw;
                }

            }
        }
    }

}