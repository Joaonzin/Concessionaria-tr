using AutoMapper;
using Concessionaria_tr._01_Entidades;
using Concessionaria_tr._01_Services;
using Concessionaria_tr._02_Repositorios.Interface;
using Concessionaria_tr._03_Aplicacao;
using Concessionaria_tr._03_Entidades.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace ConcessionariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _service;
        private readonly IMapper _mapper;

        public VendaController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new VendaService(_config);
            _mapper = mapper;
        }

        [HttpPost("adicionar-venda")]
        public void AdicionarVenda(Venda venda)
        {
            _service.Adicionar(venda);
        }

        [HttpGet("listar-venda")]
        public List<VendaDTO> ListarVenda()
        {
            return _service.Listar();
        }

        [HttpPut("editar-venda")]
        public void EditarVenda(Venda venda)
        {
            _service.Editar(venda);
        }

        [HttpDelete("deletar-venda")]
        public void DeletarVenda(int id)
        {
            _service.Remover(id);
        }
    }
}

