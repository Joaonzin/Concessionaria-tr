using AutoMapper;
using Concessionaria_tr.Services;
using Microsoft.AspNetCore.Mvc;
using Concessionaria_tr.Entidades;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _service;
        private readonly IMapper _mapper;
        public EnderecoController(IEnderecoService enderecoService, IMapper mapper)
        {
            _service = enderecoService;
            _mapper = mapper;
        }
        /// <summary>
        /// Endpoint para Adicionado um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpPost("adicionar-endereco")]
        public IActionResult AdicionarEndereco(Endereco enderecoDTO)
        {
            try
            {
                Endereco endereco = _mapper.Map<Endereco>(enderecoDTO);
                _service.Adicionar(endereco);
                return Ok(endereco); 
            }
            catch (Exception erro)
            {
                
                return BadRequest($"Ocorreu um erro ao adicionar o Endereco, " +
                                   $"o erro foi: \n{erro.Message}");
            }
        }
        /// <summary>
        /// Endpoint para Listando um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpGet("listar-endereco-Cliente")]
        public List<Endereco> ListarEnderecoCliente(int ClienteId)
        {
            try
            {
                return _service.ListarEnderecoCliente(ClienteId);
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao listar um Endereco, " +
                                    $"o erro foi \n {erro.Message}");
            }
            
        }
        /// <summary>
        /// Endpoint para Editando um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpPut("editar-endereco")]
        public IActionResult EditarEndereco(Endereco endereco)
        {
            try
            {
                _service.Editar(endereco);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao editar um Cliente, " +
                                   $"o erro foi \n {erro.Message}");
                throw;
            }
            
        }
        /// <summary>
        /// Endpoint para Deletando um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpDelete("deletar-endereco")]
        public IActionResult DeletarEndereco(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao deletar um Cliente, " +
                                   $"o erro foi \n {erro.Message}");
                throw;

            }
            
        }
    }
}