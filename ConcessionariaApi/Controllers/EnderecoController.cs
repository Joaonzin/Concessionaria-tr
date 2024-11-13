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
        public Endereco AdicionarAluno(Endereco enderecoDTO)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDTO);
            _service.Adicionar(endereco);
            return endereco;
        }
        /// <summary>
        /// Endpoint para Listando um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpGet("listar-endereco-Cliente")]
        public List<Endereco> ListarEnderecoAluno(int ClienteId)
        {
            return _service.ListarEnderecoAluno(ClienteId);
        }
        /// <summary>
        /// Endpoint para Editando um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpPut("editar-endereco")]
        public void EditarEndereco(Endereco p)
        {
            _service.Editar(p);
        }
        /// <summary>
        /// Endpoint para Deletando um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        [HttpDelete("deletar-endereco")]
        public void DeletarEndereco(int id)
        {
            _service.Remover(id);
        }
    }
}