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

            [HttpPost("adicionar-Funcionario")]
            public void AdicionarFuncionario(Funcionario funcionario)
            {
                _service.Adicionar(funcionario);
            }

            [HttpGet("listar-Funcionario")]
            public List<Funcionario> ListarFuncionario()
            {
                return _service.Listar();
            }

            [HttpPut("editar-Funcionario")]
            public void EditarFuncionario(Funcionario funcionario)
            {
                _service.Editar(funcionario);
            }

            [HttpDelete("deletar-Funcionario")]
            public void DeletarFuncionario(int id)
            {
                _service.Remover(id);
            }
        }
    }

}
