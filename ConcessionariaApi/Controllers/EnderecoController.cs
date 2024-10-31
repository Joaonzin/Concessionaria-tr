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
        [HttpPost("adicionar-endereco")]
        public Endereco AdicionarAluno(Endereco enderecoDTO)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDTO);
            _service.Adicionar(endereco);
            return endereco;
        }
        [HttpGet("listar-endereco-Cliente")]
        public List<Endereco> ListarEnderecoAluno([FromQuery] int ClienteId)
        {
            return _service.ListarEnderecoAluno(ClienteId);
        }
        [HttpPut("editar-endereco")]
        public void EditarEndereco(Endereco p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-endereco")]
        public void DeletarEndereco(int id)
        {
            _service.Remover(id);
        }
    }
}
