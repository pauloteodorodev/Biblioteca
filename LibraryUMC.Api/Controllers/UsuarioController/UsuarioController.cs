using System.Net;
using LibraryUMC.Domain.DTO.UsuarioDTO;
using LibraryUMC.Domain.Repositories;
using LibraryUMC.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryUMC.Api.Controllers.UsuarioController;


[ApiController]
[Route("usuario")]

public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepositorio usuarioRepositorio;

    public UsuarioController(IUsuarioRepositorio connectionString)
    {
        this.usuarioRepositorio = connectionString;
    }

    [HttpPost("cadastrar-novo")]
    public  Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDTO usuarioDto)
    {
        var service = new UsuarioService(usuarioRepositorio);
        service.CadastrarUsuario(usuarioDto);
        return Task.FromResult<IActionResult>(StatusCode((int)HttpStatusCode.OK));
    }
    
    [HttpGet("buscar-usuario/{id:guid}")]
    public Task<IActionResult> BuscarUsuario()
    {
        return Task.FromResult<IActionResult>(StatusCode((int)HttpStatusCode.OK));
    }
    
    [HttpDelete("deletar-usuario/{id:guid}")]
    public Task<IActionResult> DeletarUsuario()
    {
        return Task.FromResult<IActionResult>(StatusCode((int)HttpStatusCode.OK));
    }
    
    
}