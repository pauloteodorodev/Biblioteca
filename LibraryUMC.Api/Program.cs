using LibraryUMC.Domain.Repositories;
using LibraryUMC.Infrastructure.DTO;
using LibraryUMC.Infrastructure.Repositorio;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Adiciona as configura��es do appsettings.json
builder.Configuration.AddJsonFile("appsettings.json");

// Adiciona servi�os ao container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 //L� as configura��es do appsettings.json
IConfigurationSection connectionStringSection = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection");

// Adiciona a string de conex�o ao servi�o Singleton
builder.Services.AddSingleton(new StringConexao { StringConexaoBD = connectionStringSection.Value });


builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();

var app = builder.Build();

// Configura a pipeline de requisi��es HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
