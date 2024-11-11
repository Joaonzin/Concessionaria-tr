using Concessionaria_tr.Entidades;
using Concessionaria_tr.Repositorios;
using Concessionaria_tr.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Informa ao Swagger para incluir o arquivo XML gerado
    var xmlFile = "API.xml"; // Nome do arquivo XML gerado
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Concessionaria",
        Version = "v1",
        Description = "Um Sistema de Agendamento para ver um Carro na loja para depois comprar"
    });
});
InicializadorBd.Inicializar();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IVendaService, VendaService>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();
builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IAgendamentoService, AgendamentoService>();

builder.Services.AddScoped<IVendaRepository, VendaRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Concessionaria");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
