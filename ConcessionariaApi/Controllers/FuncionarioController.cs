namespace ConcessionariaApi.Controllers
{
    using AutoMapper;
    using Concessionaria_tr._01_Entidades;
    using Concessionaria_tr._01_Services;
    using Concessionaria_tr._02_Repositorios.Interface;
    using Concessionaria_tr._03_Aplicacao;
    using Concessionaria_tr._03_Entidades;
    using Microsoft.AspNetCore.Mvc;

    namespace ConcessionariaApi.Controllers
    {

        [ApiController]
        [Route("[controller]")]
        public class FuncionarioController : ControllerBase
        {
            private readonly IFuncionarioService _service;
            private readonly IMapper _mapper;

            public FuncionarioController(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new FuncionarioService(_config);
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
