using System.Net;
using LibraryUMC.Domain.DTO.UsuarioDTO;
using Microsoft.AspNetCore.Mvc;

namespace LibraryUMC.Api.Controllers.Usuario;


[ApiController]
[Route("usuario")]

public class UsuarioController : ControllerBase
{
    [HttpPost("cadastrar-novo")]
    public Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDTO usuarioDto)
    {
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